using System.Collections.Generic;
using System.IO;
using System.Reflection;
using HarmonyLib;
using Poly2Tri;
using PavonisInteractive.TerraInvicta;
using UnityEngine;

namespace Assistance
{
    /// <summary>
    /// Computes the shortest great-circle distance between the BORDERS of two
    /// TIRegionState instances, with an optional precomputed, disk-backed lookup
    /// table so the expensive O(N*M) vertex-pair sweep only ever has to run once
    /// per region pair, ever (not once per session, and not once per call).
    ///
    /// See the original per-call implementation notes for the caveats around
    /// where border geometry actually lives (RegionController.polyLatLons, a
    /// private field, only populated once that region's controller is
    /// instantiated in-scene) and the vertex-to-vertex approximation. Everything
    /// below is additive: live per-pair computation still works exactly as before
    /// and is what backs a cache-miss.
    /// </summary>
    public static class TIRegionState_BorderDistance
    {
        private static readonly FieldInfo PolyLatLonsField =
            AccessTools.Field(typeof(RegionController), "polyLatLons");

        private static readonly Dictionary<TIRegionState, List<Vector2>> VertexCache =
            new Dictionary<TIRegionState, List<Vector2>>();

        // Disk-backed table: canonical "templateNameA|templateNameB" (alphabetical
        // order, so each unordered pair has exactly one key) -> distance in km.
        // Populated by EnsureTableLoaded() and/or PrecomputeAllPairs().
        private static readonly Dictionary<string, float> PrecomputedTable =
            new Dictionary<string, float>();

        private static bool tableLoaded = false;

        private const string CacheFileName = "BorderDistanceCache.csv";

        /// <summary>
        /// Shortest great-circle distance (km) between the two regions' border
        /// polygons. Checks the precomputed table first; on a miss, computes it
        /// live (vertex-pair sweep, or centroid fallback if geometry isn't
        /// currently available) exactly as before.
        /// </summary>
        public static float ShortestBorderDistance_km(this TIRegionState regionA, TIRegionState regionB)
        {
            if (regionA == null || regionB == null)
            {
                return 0f;
            }

            if (regionA == regionB)
            {
                return 0f;
            }

            EnsureTableLoaded();

            string key = PairKey(regionA.templateName, regionB.templateName);
            if (PrecomputedTable.TryGetValue(key, out float cachedDistance))
            {
                return cachedDistance;
            }

            return ComputeLive(regionA, regionB);
        }

        private static float ComputeLive(TIRegionState regionA, TIRegionState regionB)
        {
            List<Vector2> pointsA = GetBorderLonLat(regionA);
            List<Vector2> pointsB = GetBorderLonLat(regionB);

            if (pointsA == null || pointsA.Count == 0 || pointsB == null || pointsB.Count == 0)
            {
                return regionA.DistanceToRegion_km(regionB);
            }

            double planetRadius_km = regionA.spaceBody.meanRadius_km;
            float shortest = float.MaxValue;

            for (int i = 0; i < pointsA.Count; i++)
            {
                Vector2 a = pointsA[i];
                for (int j = 0; j < pointsB.Count; j++)
                {
                    Vector2 b = pointsB[j];
                    float dist = TIRegionState.DistanceBetweenTwoCoordinates_km(
                        a.y, a.x, b.y, b.x, planetRadius_km);

                    if (dist < shortest)
                    {
                        shortest = dist;
                    }
                }
            }

            return shortest;
        }

        private static List<Vector2> GetBorderLonLat(TIRegionState region)
        {
            if (VertexCache.TryGetValue(region, out List<Vector2> cached))
            {
                return cached;
            }

            List<Vector2> result = null;

            RegionController controller = region.Controller;
            if (controller != null && PolyLatLonsField != null)
            {
                object value = PolyLatLonsField.GetValue(controller);
                if (value is List<Polygon> polygons && polygons.Count > 0)
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

            VertexCache[region] = result;
            return result;
        }

        private static string PairKey(string templateNameA, string templateNameB)
        {
            // Alphabetical ordering so (A,B) and (B,A) hit the same key.
            return string.CompareOrdinal(templateNameA, templateNameB) <= 0
                ? templateNameA + "|" + templateNameB
                : templateNameB + "|" + templateNameA;
        }

        private static string CacheFilePath()
        {
            return Path.Combine(Main.mod.Path, CacheFileName);
        }

        /// <summary>
        /// Loads the precomputed table from disk if present. Safe to call
        /// repeatedly — only reads the file once per process (set forceReload to
        /// re-read after manually editing/replacing the file).
        /// </summary>
        public static void EnsureTableLoaded(bool forceReload = false)
        {
            if (tableLoaded && !forceReload)
            {
                return;
            }

            PrecomputedTable.Clear();
            tableLoaded = true;

            string path = CacheFilePath();
            if (!File.Exists(path))
            {
                Log($"[BorderDistance] No cache file at {path} — will compute live until PrecomputeAllPairs() is run.");
                return;
            }

            int loaded = 0;
            foreach (string line in File.ReadAllLines(path))
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                string[] parts = line.Split(',');
                if (parts.Length != 3)
                {
                    continue;
                }

                if (float.TryParse(parts[2], System.Globalization.NumberStyles.Float,
                        System.Globalization.CultureInfo.InvariantCulture, out float distance))
                {
                    PrecomputedTable[PairKey(parts[0], parts[1])] = distance;
                    loaded++;
                }
            }

            Log($"[BorderDistance] Loaded {loaded} precomputed pair distances from {path}.");
        }

        /// <summary>
        /// Computes every unique region pair's border distance and writes it to
        /// disk. This is a deliberate, potentially slow (O(N^2) pairs, each an
        /// O(V*V) vertex sweep) one-time bake — run it from a debug button with
        /// the map loaded (so RegionController instances, and therefore real
        /// polygons, exist for every region), not automatically on every load.
        ///
        /// Populates PrecomputedTable in memory directly as it computes, in
        /// addition to writing the file for future sessions — no reload needed
        /// after calling this.
        /// </summary>
        public static void PrecomputeAllPairs()
        {
            TIRegionState[] allRegions = GameStateManager.AllRegions();
            int total = allRegions.Length * (allRegions.Length - 1) / 2;
            int done = 0;
            int missingController = 0;

            Log($"[BorderDistance] Precomputing {total} region pairs ({allRegions.Length} regions)...");

            PrecomputedTable.Clear();
            tableLoaded = true;

            using (StreamWriter writer = new StreamWriter(CacheFilePath(), false))
            {
                for (int i = 0; i < allRegions.Length; i++)
                {
                    TIRegionState regionA = allRegions[i];

                    if (regionA.Controller == null)
                    {
                        missingController++;
                    }

                    for (int j = i + 1; j < allRegions.Length; j++)
                    {
                        TIRegionState regionB = allRegions[j];

                        float distance = ComputeLive(regionA, regionB);
                        string key = PairKey(regionA.templateName, regionB.templateName);
                        PrecomputedTable[key] = distance;

                        writer.WriteLine(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                            "{0},{1},{2:F3}", regionA.templateName, regionB.templateName, distance));

                        done++;
                    }

                    if (i % 25 == 0)
                    {
                        Log($"[BorderDistance] ...{done}/{total} pairs done.");
                    }
                }
            }

            Log($"[BorderDistance] Precompute complete: {done} pairs written to {CacheFilePath()}.");
            if (missingController > 0)
            {
                Log($"[BorderDistance] WARNING: {missingController} regions had no live Controller — " +
                    "their pairs fell back to centroid distance, not real border geometry. " +
                    "Re-run this with the full world map visible/loaded to get real polygons for those.");
            }
        }

        /// <summary>
        /// Clears the in-memory vertex cache (call after a scene reload, since
        /// RegionController instances are destroyed/recreated then) and forces the
        /// precomputed table to be re-read from disk next use. Does NOT delete or
        /// rebuild the disk file — call PrecomputeAllPairs() for that.
        /// </summary>
        public static void InvalidateCache()
        {
            VertexCache.Clear();
            tableLoaded = false;
        }

        private static void Log(string message)
        {
            if (Main.mod != null)
            {
                Main.mod.Logger.Log(message);
            }
        }
    }
}
