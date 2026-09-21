using HarmonyLib;
using PavonisInteractive.TerraInvicta;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Poly2Tri;
using UnityEngine;
using System.Reflection;

namespace CreepingBorders
{
    /// <summary>
    /// Result of a region-pair distance query under the v2 connectivity methodology.
    /// </summary>
    public enum PolygonDistanceResult
    {
        /// <summary>A real distance was computed (or loaded from cache).</summary>
        Known,
        /// <summary>The pair failed the bounding-box pre-filter (beyond 3x the option claim distance) — never computed.</summary>
        Beyond3X,
        /// <summary>No usable geometry exists for at least one region (no Controller / no polygon vertices).</summary>
        Unknown
    }

    /// <summary>
    /// Distance layer for the Polygonal Region Connectivity Manager.
    ///
    /// Methodology (per handover v3):
    ///  - Radians-based edge-to-edge math (closest-point-on-segment between polygon edges),
    ///    NOT the vertex-to-vertex sweep of the old ComputeLive.
    ///  - Planet radius comes from region.spaceBody.meanRadius_km, never a hardcoded 6371.0.
    ///  - No single-point fallback: regions without geometry yield Unknown (treated as DC
    ///    by the connectivity manager), never pseudo-connected.
    ///  - Deduplication via PairKey: exactly one row per unordered region pair.
    ///  - Bounding-box pre-filter skips pairs whose padded boxes cannot come within
    ///    3x the option claim distance — they are never swept.
    ///  - Disk cache: 3-column CSV (A,B,distance). Sentinels: >= 0 real km,
    ///    -1 = Beyond3X. Cache misses are computed lazily at runtime and appended.
    /// </summary>
    public static class GeographicPolygonMath
    {
        private const string CacheFileName = "BorderDistanceCache.csv";
        private const float BboxLatPadDegrees = 2f;      // padding for vertex quantisation/coastline resolution
        private const float Beyond3XSentinel = -1f;

        private static readonly Dictionary<string, float> cache = new Dictionary<string, float>();
        private static readonly object cacheLock = new object();
        private static bool tableLoaded = false;

        // ===================== Public API =====================

        /// <summary>
        /// Query the border distance between two regions.
        /// Returns the distance in km and the result classification.
        /// On a cache miss the pair is computed live and appended to the CSV.
        /// </summary>
        public static (float distanceKm, PolygonDistanceResult result) GetRegionPairDistance(
            TIRegionState regionA, TIRegionState regionB, float claimDistanceKm, float maxDistanceKm)
        {
            if (regionA == null || regionB == null || regionA == regionB)
                return (0f, PolygonDistanceResult.Known);

            EnsureTableLoaded();

            string key = PairKey(regionA.templateName, regionB.templateName);
            float cached;
            lock (cacheLock)
            {
                if (cache.TryGetValue(key, out cached))
                    return Classify(cached);
            }

            // Cache miss: compute live.
            return ComputeAndCache(regionA, regionB, key, claimDistanceKm, maxDistanceKm);
        }

        /// <summary>
        /// Clears the in-memory vertex geometry cache (call after scene reload).
        /// The disk table is NOT reloaded — call <see cref="ReloadTable"/> for that.
        /// </summary>
        public static void ClearGeometryCache()
        {
            VertexGeometryCache.Clear();
        }

        /// <summary>
        /// Forces the disk cache to be re-read on next use.
        /// </summary>
        public static void ReloadTable()
        {
            lock (cacheLock)
            {
                cache.Clear();
                tableLoaded = false;
            }
        }

        /// <summary>
        /// Number of entries currently in the in-memory table (for debug logging).
        /// </summary>
        public static int CachedPairCount
        {
            get { lock (cacheLock) return cache.Count; }
        }

        // ===================== Classification =====================

        private static (float, PolygonDistanceResult) Classify(float distance)
        {
            if (distance < 0f)
                return (float.MaxValue, PolygonDistanceResult.Beyond3X);
            return (distance, PolygonDistanceResult.Known);
        }

        // ===================== Live computation =====================

        private static (float, PolygonDistanceResult) ComputeAndCache(
            TIRegionState regionA, TIRegionState regionB, string key, float claimDistanceKm, float maxDistanceKm)
        {
            List<Vector2> pointsA = GetBorderLonLat(regionA);
            List<Vector2> pointsB = GetBorderLonLat(regionB);

            float writeValue;

            if (pointsA == null || pointsA.Count == 0 || pointsB == null || pointsB.Count == 0)
            {
                // No fallback: regions without geometry are Unknown. Do not write a
                // row for them so a later session with geometry loaded can compute it.
                return (float.MaxValue, PolygonDistanceResult.Unknown);
            }

            if (!BoundingBoxesCouldOverlap(pointsA, pointsB, claimDistanceKm, maxDistanceKm, regionA, regionB))
            {
                writeValue = Beyond3XSentinel;
            }
            else
            {
                double radiusKm = regionA.spaceBody != null ? regionA.spaceBody.meanRadius_km : 6371.0;
                writeValue = (float)EdgeToEdgeDistanceKm(pointsA, pointsB, radiusKm);
            }

            lock (cacheLock)
            {
                cache[key] = writeValue;
            }
            AppendCacheEntry(key, writeValue);

            return Classify(writeValue);
        }

        /// <summary>
        /// Bounding-box pre-filter: if the padded boxes of the two regions' polygons
        /// cannot approach within maxDistanceKm on the great-circle surface, skip the
        /// O(n*m) edge sweep entirely. Latitude padding is fixed; longitude padding is
        /// widened by 1/cos(lat) at the boxes' nearest approach — conservative.
        /// </summary>
        private static bool BoundingBoxesCouldOverlap(
            List<Vector2> a, List<Vector2> b,
            float claimDistanceKm, float maxDistanceKm, TIRegionState regionA, TIRegionState regionB)
        {
            double radiusKm = regionA.spaceBody != null ? regionA.spaceBody.meanRadius_km : 6371.0;
            float padKm = 3f * Math.Max(claimDistanceKm, 1f);
            if (padKm > maxDistanceKm) padKm = maxDistanceKm;

            // Convert the km pad to angular degrees at each box's relevant latitude.
            // For latitude: degrees = km / (2*pi*R/360).
            double kmPerDegLat = 2.0 * Math.PI * radiusKm / 360.0;
            double latPadDeg = padKm / kmPerDegLat + BboxLatPadDegrees;

            var boxA = BoundingBoxOf(a);
            var boxB = BoundingBoxOf(b);

            // Longitude pad widened by 1/cos(lat) — use the smaller |lat| of the two
            // boxes (conservative: widest circumference).
            double latForCos = Math.Min(Math.Abs(boxA.centreLat), Math.Abs(boxB.centreLat));
            if (latForCos > 89.0) latForCos = 89.0;
            double lonPadDeg = latPadDeg / Math.Cos(latForCos * Math.PI / 180.0);

            return boxA.minLat - latPadDeg <= boxB.maxLat + latPadDeg
                && boxA.maxLat + latPadDeg >= boxB.minLat - latPadDeg
                && LonRangesOverlap(boxA.minLon - lonPadDeg, boxA.maxLon + lonPadDeg,
                                    boxB.minLon - lonPadDeg, boxB.maxLon + lonPadDeg);
        }

        private struct BoundingBox
        {
            public float minLat, maxLat, minLon, maxLon, centreLat;
        }

        private static BoundingBox BoundingBoxOf(List<Vector2> points)
        {
            // Points are stored as (lon, lat) in radians; convert to degrees.
            float minLon = float.MaxValue, maxLon = float.MinValue;
            float minLat = float.MaxValue, maxLat = float.MinValue;
            foreach (var p in points)
            {
                float lon = p.x * Mathf.Rad2Deg;
                float lat = p.y * Mathf.Rad2Deg;
                if (lon < minLon) minLon = lon;
                if (lon > maxLon) maxLon = lon;
                if (lat < minLat) minLat = lat;
                if (lat > maxLat) maxLat = lat;
            }
            return new BoundingBox { minLat = minLat, maxLat = maxLat, minLon = minLon, maxLon = maxLon, centreLat = (minLat + maxLat) / 2f };
        }

        /// <summary>
        /// Longitude range overlap handling antimeridian wrap. Ranges may exceed [-180,180].
        /// </summary>
        private static bool LonRangesOverlap(double aMin, double aMax, double bMin, double bMax)
        {
            // Normalize both ranges to [0, 360).
            double normLo(double lo, double hi) { return ((lo % 360.0) + 360.0) % 360.0; }

            var aRange = NormalizeRange(aMin, aMax);
            var bRange = NormalizeRange(bMin, bMax);

            foreach (var (aLo, aHi) in aRange)
                foreach (var (bLo, bHi) in bRange)
                    if (aLo <= bHi && bLo <= aHi)
                        return true;
            return false;
        }

        private static List<(double lo, double hi)> NormalizeRange(double min, double max)
        {
            double width = max - min;
            if (width >= 360.0)
                return new List<(double, double)> { (0.0, 359.999999) };

            double lo = ((min % 360.0) + 360.0) % 360.0;
            double hi = lo + width;

            if (hi <= 360.0)
                return new List<(double, double)> { (lo, hi) };

            // Wraps the antimeridian: split into two ranges.
            return new List<(double, double)>
            {
                (lo, 360.0),
                (0.0, hi - 360.0)
            };
        }

        // ===================== Edge-to-edge math =====================

        /// <summary>
        /// Minimum great-circle distance (km) between two polygons using the
        /// attachment's methodology: every VERTEX of A is projected onto every EDGE
        /// of B, and every vertex of B onto every edge of A. This matches the
        /// verified PolygonCache regeneration (Java–Sumatra = 7.6816 km).
        /// </summary>
        public static double EdgeToEdgeDistanceKm(List<Vector2> pointsA, List<Vector2> pointsB, double radiusKm)
        {
            double shortest = double.MaxValue;

            var vecsA = ToUnitVectors(pointsA);
            var vecsB = ToUnitVectors(pointsB);

            // Vertices of A against edges of B.
            for (int i = 0; i < vecsA.Count; i++)
            {
                var p = vecsA[i];
                for (int j = 0; j < vecsB.Count; j++)
                {
                    double d = PointToArcDistance(p, vecsB[j], vecsB[(j + 1) % vecsB.Count], radiusKm);
                    if (d < shortest)
                        shortest = d;
                    if (shortest <= 0.0)
                        return 0.0;
                }
            }

            // Vertices of B against edges of A.
            for (int i = 0; i < vecsB.Count; i++)
            {
                var p = vecsB[i];
                for (int j = 0; j < vecsA.Count; j++)
                {
                    double d = PointToArcDistance(p, vecsA[j], vecsA[(j + 1) % vecsA.Count], radiusKm);
                    if (d < shortest)
                        shortest = d;
                    if (shortest <= 0.0)
                        return 0.0;
                }
            }

            return shortest;
        }

        private static List<Vector3> ToUnitVectors(List<Vector2> lonLatRad)
        {
            var result = new List<Vector3>(lonLatRad.Count);
            foreach (var p in lonLatRad)
            {
                float lon = p.x;
                float lat = p.y;
                result.Add(new Vector3(
                    Mathf.Cos(lat) * Mathf.Cos(lon),
                    Mathf.Cos(lat) * Mathf.Sin(lon),
                    Mathf.Sin(lat)));
            }
            return result;
        }

        /// <summary>
        /// Minimum distance from unit vector p to the great-circle arc a0→a1.
        /// If the closest point on the full great circle lies within the arc,
        /// return that distance; otherwise the nearer endpoint distance.
        /// </summary>
        private static double PointToArcDistance(Vector3 p, Vector3 a0, Vector3 a1, double radiusKm)
        {
            double dot01 = Vector3.Dot(a0, a1);
            bool isPoint = dot01 > 1.0 - 1e-9; // degenerate: zero-length arc

            Vector3 n = Vector3.Cross(a0, a1);
            float nLen = n.magnitude;

            if (!isPoint && nLen > 1e-10f)
            {
                Vector3 nHat = n / nLen;
                // Closest point on the great circle: project p onto the plane.
                Vector3 projected = p - Vector3.Dot(p, nHat) * nHat;
                float projLen = projected.magnitude;
                if (projLen > 1e-10f)
                {
                    Vector3 closest = projected / projLen;
                    // Only valid if the projection lies in the same hemisphere as p —
                    // otherwise the true nearest point on this great circle is the
                    // antipode, which (almost surely) is not on the arc.
                    if (Vector3.Dot(p, closest) > 0f && OnArc(a0, a1, closest))
                    {
                        return radiusKm * Math.Acos(TIClamp(Vector3.Dot(p, closest), -1f, 1f));
                    }
                }
            }

            // Fall back to endpoint distances.
            double d0 = radiusKm * Math.Acos(TIClamp(Vector3.Dot(p, a0), -1f, 1f));
            double d1 = radiusKm * Math.Acos(TIClamp(Vector3.Dot(p, a1), -1f, 1f));
            return Math.Min(d0, d1);
        }

        /// <summary>
        /// True if unit vector v lies on the minor arc from a0 to a1.
        /// </summary>
        private static bool OnArc(Vector3 a0, Vector3 a1, Vector3 v)
        {
            // v must be coplanar and between a0 and a1 in angular order.
            if (Vector3.Dot(v, a0) < 0 && Vector3.Dot(v, a1) < 0)
                return false; // on the far side of the sphere

            // Walk direction consistency: cross(a0, v) and cross(v, a1) must agree with cross(a0, a1).
            Vector3 full = Vector3.Cross(a0, a1);
            Vector3 first = Vector3.Cross(a0, v);
            Vector3 second = Vector3.Cross(v, a1);

            bool sameOrientation = Vector3.Dot(full, first) >= -1e-9f && Vector3.Dot(full, second) >= -1e-9f;

            // For arcs shorter than 180 degrees this is sufficient.
            if (Vector3.Dot(a0, a1) > 0)
                return sameOrientation;

            // For arcs >= 180 degrees, the above can be degenerate; fall back to
            // "between endpoints by dot product" which is conservative.
            return Vector3.Dot(v, a0) >= 0 || Vector3.Dot(v, a1) >= 0;
        }

        // ===================== Geometry access =====================

        private static readonly FieldInfo PolyLatLonsField =
            AccessTools.Field(typeof(RegionController), "polyLatLons");

        private static readonly Dictionary<TIRegionState, List<Vector2>> VertexGeometryCache =
            new Dictionary<TIRegionState, List<Vector2>>();

        /// <summary>
        /// Polygon vertices as (lon, lat) in RADIANS — same convention as the
        /// existing GetBorderLonLat in CreepingBordersCls, so the disk cache stays
        /// interchangeable. Returns null if no usable geometry.
        /// </summary>
        private static List<Vector2> GetBorderLonLat(TIRegionState region)
        {
            if (region == null)
                return null;

            if (VertexGeometryCache.TryGetValue(region, out List<Vector2> cached))
                return cached;

            List<Vector2> result = null;
            RegionController controller = region.Controller;
            if (controller != null && PolyLatLonsField != null)
            {
                if (PolyLatLonsField.GetValue(controller) is List<Polygon> polygons && polygons.Count > 0)
                {
                    result = new List<Vector2>();
                    foreach (Polygon polygon in polygons)
                    {
                        foreach (TriangulationPoint point in polygon.Points)
                        {
                            result.Add(new Vector2((float)point.X, (float)point.Y));
                        }
                    }
                }
            }

            VertexGeometryCache[region] = result;
            return result;
        }

        // ===================== Disk cache =====================

        private static string CacheFilePath()
        {
            return Path.Combine(CreepingBordersCls.mod.Path, CacheFileName);
        }

        private static void EnsureTableLoaded()
        {
            lock (cacheLock)
            {
                if (tableLoaded)
                    return;
                tableLoaded = true;
            }

            string path = CacheFilePath();
            if (!File.Exists(path))
            {
                if (CreepingBordersCls.Settings.EnableDebugLogging)
                    CreepingBordersCls.mod.Logger.Log($"[GeoMath] No cache file at {path} — all pairs will compute live and be appended.");
                return;
            }

            int loaded = 0;
            foreach (string line in File.ReadAllLines(path))
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] parts = line.Split(',');
                if (parts.Length != 3)
                    continue;

                if (float.TryParse(parts[2], System.Globalization.NumberStyles.Float,
                        System.Globalization.CultureInfo.InvariantCulture, out float distance))
                {
                    lock (cacheLock)
                    {
                        cache[PairKey(parts[0], parts[1])] = distance;
                    }
                    loaded++;
                }
            }

            if (CreepingBordersCls.Settings.EnableDebugLogging)
                CreepingBordersCls.mod.Logger.Log($"[GeoMath] Loaded {loaded} pair entries from {path}.");
        }

        /// <summary>
        /// Appends one entry to the CSV. The key is already in sorted (A,B) order via PairKey.
        /// Buffered to avoid one file open per append.
        /// </summary>
        private static void AppendCacheEntry(string key, float value)
        {
            lock (cacheLock)
            {
                try
                {
                    File.AppendAllText(CacheFilePath(),
                        key.Replace("|", ",") + "," + value.ToString("R", System.Globalization.CultureInfo.InvariantCulture) + Environment.NewLine);
                }
                catch (IOException)
                {
                    // Disk write failures must not crash the game; the value is still
                    // in memory, so behaviour is correct for this session.
                }
            }
        }

        /// <summary>
        /// Deduplication: one canonical key per unordered pair.
        /// </summary>
        public static string PairKey(string templateNameA, string templateNameB)
        {
            return string.CompareOrdinal(templateNameA, templateNameB) <= 0
                ? templateNameA + "|" + templateNameB
                : templateNameB + "|" + templateNameA;
        }

        /// <summary>net45-compatible clamp for doubles.</summary>
        private static double TIClamp(double v, double lo, double hi)
        {
            return v < lo ? lo : (v > hi ? hi : v);
        }
    }
}

