using System;
using System.Collections.Generic;
using System.Linq;

namespace GeometryUtils
{
    /// <summary>
    /// A simple 2D point/vector.
    /// </summary>
    public readonly struct Point2D
    {
        public double X { get; }
        public double Y { get; }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static Point2D operator -(Point2D a, Point2D b) => new Point2D(a.X - b.X, a.Y - b.Y);
        public static Point2D operator +(Point2D a, Point2D b) => new Point2D(a.X + b.X, a.Y + b.Y);
        public static Point2D operator *(Point2D a, double s) => new Point2D(a.X * s, a.Y * s);

        public double Dot(Point2D other) => X * other.X + Y * other.Y;
        public double LengthSquared => X * X + Y * Y;
        public double Length => Math.Sqrt(LengthSquared);

        public override string ToString() => $"({X:F6}, {Y:F6})";
    }

    /// <summary>
    /// Result of a closest-point-between-polygons query.
    /// </summary>
    public readonly struct ClosestPointResult
    {
        /// <summary>The minimum distance between the two polygon boundaries.</summary>
        public double Distance { get; }

        /// <summary>The closest point on the boundary of the first polygon.</summary>
        public Point2D PointOnA { get; }

        /// <summary>The closest point on the boundary of the second polygon.</summary>
        public Point2D PointOnB { get; }

        /// <summary>Index of the edge on polygon A that produced the closest point (edge i connects vertex i to vertex i+1).</summary>
        public int EdgeIndexA { get; }

        /// <summary>Index of the edge on polygon B that produced the closest point.</summary>
        public int EdgeIndexB { get; }

        public ClosestPointResult(double distance, Point2D pointOnA, Point2D pointOnB, int edgeIndexA, int edgeIndexB)
        {
            Distance = distance;
            PointOnA = pointOnA;
            PointOnB = pointOnB;
            EdgeIndexA = edgeIndexA;
            EdgeIndexB = edgeIndexB;
        }
    }

    /// <summary>
    /// A geographic point in degrees (matches how coordinates are usually stored/exchanged).
    /// </summary>
    public readonly struct GeoPoint
    {
        public double LongitudeDegrees { get; }
        public double LatitudeDegrees { get; }

        public GeoPoint(double longitudeDegrees, double latitudeDegrees)
        {
            LongitudeDegrees = longitudeDegrees;
            LatitudeDegrees = latitudeDegrees;
        }

        public override string ToString() => $"({LongitudeDegrees:F6}°, {LatitudeDegrees:F6}°)";
    }

    /// <summary>
    /// Result of a closest-point-between-polygons query expressed in real-world geographic terms.
    /// </summary>
    public readonly struct GeoClosestPointResult
    {
        /// <summary>Great-circle distance between the closest points, in kilometers.</summary>
        public double DistanceKm { get; }

        /// <summary>Closest point on polygon A's boundary, in longitude/latitude degrees.</summary>
        public GeoPoint PointOnA { get; }

        /// <summary>Closest point on polygon B's boundary, in longitude/latitude degrees.</summary>
        public GeoPoint PointOnB { get; }

        public GeoClosestPointResult(double distanceKm, GeoPoint pointOnA, GeoPoint pointOnB)
        {
            DistanceKm = distanceKm;
            PointOnA = pointOnA;
            PointOnB = pointOnB;
        }
    }

    public static class PolygonProximity
    {
        private const double EarthRadiusKm = 6371.0088;

        /// <summary>
        /// Same as <see cref="FindClosestPoints(IReadOnlyList{Point2D}, IReadOnlyList{Point2D})"/>,
        /// but takes polygons as longitude/latitude in degrees and returns the closest points
        /// back in degrees, plus the true great-circle distance between them in kilometers.
        ///
        /// Internally this converts to radians (so the planar nearest-edge search is done in a
        /// consistent, roughly-equirectangular space), finds the closest points there, then
        /// converts just those two points back to degrees and runs a haversine calculation for
        /// an accurate real-world distance -- rather than naively scaling the planar distance,
        /// which would be inaccurate (distance-per-degree-of-longitude shrinks with latitude).
        /// </summary>
        /// <param name="polygonA">Ordered vertices of the first polygon, as (longitude, latitude) in degrees.</param>
        /// <param name="polygonB">Ordered vertices of the second polygon, as (longitude, latitude) in degrees.</param>
        public static GeoClosestPointResult FindClosestGeoPoints(IReadOnlyList<GeoPoint> polygonA, IReadOnlyList<GeoPoint> polygonB)
        {
            if (polygonA == null || polygonA.Count == 0)
                throw new ArgumentException("Polygon A must contain at least one vertex.", nameof(polygonA));
            if (polygonB == null || polygonB.Count == 0)
                throw new ArgumentException("Polygon B must contain at least one vertex.", nameof(polygonB));

            List<Point2D> radiansA = polygonA.Select(p => new Point2D(DegToRad(p.LongitudeDegrees), DegToRad(p.LatitudeDegrees))).ToList();
            List<Point2D> radiansB = polygonB.Select(p => new Point2D(DegToRad(p.LongitudeDegrees), DegToRad(p.LatitudeDegrees))).ToList();

            ClosestPointResult planarResult = FindClosestPoints(radiansA, radiansB);

            var geoPointA = new GeoPoint(RadToDeg(planarResult.PointOnA.X), RadToDeg(planarResult.PointOnA.Y));
            var geoPointB = new GeoPoint(RadToDeg(planarResult.PointOnB.X), RadToDeg(planarResult.PointOnB.Y));

            double distanceKm = HaversineDistanceKm(geoPointA, geoPointB);

            return new GeoClosestPointResult(distanceKm, geoPointA, geoPointB);
        }

        private static double DegToRad(double degrees) => degrees * Math.PI / 180.0;
        private static double RadToDeg(double radians) => radians * 180.0 / Math.PI;

        private static double HaversineDistanceKm(GeoPoint a, GeoPoint b)
        {
            double lat1 = DegToRad(a.LatitudeDegrees);
            double lat2 = DegToRad(b.LatitudeDegrees);
            double dLat = DegToRad(b.LatitudeDegrees - a.LatitudeDegrees);
            double dLon = DegToRad(b.LongitudeDegrees - a.LongitudeDegrees);

            double h = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(lat1) * Math.Cos(lat2) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(h), Math.Sqrt(1 - h));

            return EarthRadiusKm * c;
        }

        /// <summary>
        /// Computes the minimum distance between the boundaries of two simple polygons
        /// (each given as an ordered list of vertices; the edge from the last vertex back
        /// to the first is included automatically).
        ///
        /// This checks every vertex of one polygon against every edge of the other polygon
        /// (in both directions), which correctly finds the true closest points -- including
        /// cases where the closest point lies in the middle of an edge, not just at a vertex.
        ///
        /// Time complexity is O(n * m) for polygons with n and m vertices. For very large
        /// polygons where this is a bottleneck, consider a spatial acceleration structure
        /// (e.g. bounding-box pruning or a k-d tree) as a pre-filter.
        /// </summary>
        /// <param name="polygonA">Ordered vertices of the first polygon (closed automatically).</param>
        /// <param name="polygonB">Ordered vertices of the second polygon (closed automatically).</param>
        /// <returns>The closest distance and the corresponding closest points on each polygon.</returns>
        /// <exception cref="ArgumentException">Thrown if either polygon has fewer than 1 vertex.</exception>
        public static ClosestPointResult FindClosestPoints(IReadOnlyList<Point2D> polygonA, IReadOnlyList<Point2D> polygonB)
        {
            if (polygonA == null || polygonA.Count == 0)
                throw new ArgumentException("Polygon A must contain at least one vertex.", nameof(polygonA));
            if (polygonB == null || polygonB.Count == 0)
                throw new ArgumentException("Polygon B must contain at least one vertex.", nameof(polygonB));

            double bestDistance = double.MaxValue;
            Point2D bestPointOnA = default;
            Point2D bestPointOnB = default;
            int bestEdgeA = -1;
            int bestEdgeB = -1;

            // Check every vertex of B against every edge of A.
            for (int bi = 0; bi < polygonB.Count; bi++)
            {
                Point2D vertexB = polygonB[bi];

                for (int ai = 0; ai < polygonA.Count; ai++)
                {
                    Point2D edgeStart = polygonA[ai];
                    Point2D edgeEnd = polygonA[(ai + 1) % polygonA.Count];

                    Point2D closestOnEdge = ClosestPointOnSegment(vertexB, edgeStart, edgeEnd);
                    double dist = (vertexB - closestOnEdge).Length;

                    if (dist < bestDistance)
                    {
                        bestDistance = dist;
                        bestPointOnA = closestOnEdge;
                        bestPointOnB = vertexB;
                        bestEdgeA = ai;
                        bestEdgeB = -1; // matched at a vertex of B, not a specific edge of B
                    }
                }
            }

            // Check every vertex of A against every edge of B (covers the symmetric case).
            for (int ai = 0; ai < polygonA.Count; ai++)
            {
                Point2D vertexA = polygonA[ai];

                for (int bi = 0; bi < polygonB.Count; bi++)
                {
                    Point2D edgeStart = polygonB[bi];
                    Point2D edgeEnd = polygonB[(bi + 1) % polygonB.Count];

                    Point2D closestOnEdge = ClosestPointOnSegment(vertexA, edgeStart, edgeEnd);
                    double dist = (vertexA - closestOnEdge).Length;

                    if (dist < bestDistance)
                    {
                        bestDistance = dist;
                        bestPointOnA = vertexA;
                        bestPointOnB = closestOnEdge;
                        bestEdgeA = -1;
                        bestEdgeB = bi;
                    }
                }
            }

            return new ClosestPointResult(bestDistance, bestPointOnA, bestPointOnB, bestEdgeA, bestEdgeB);
        }

        /// <summary>
        /// Finds the closest point to <paramref name="point"/> that lies on the segment
        /// from <paramref name="segStart"/> to <paramref name="segEnd"/>.
        /// </summary>
        private static Point2D ClosestPointOnSegment(Point2D point, Point2D segStart, Point2D segEnd)
        {
            Point2D segVector = segEnd - segStart;
            double segLengthSquared = segVector.LengthSquared;

            // Degenerate segment (start == end): the "closest point on the segment" is just the point itself.
            if (segLengthSquared < 1e-18)
                return segStart;

            Point2D toPoint = point - segStart;
            double t = toPoint.Dot(segVector) / segLengthSquared;
            t = Math.Clamp(t, 0.0, 1.0);

            return segStart + segVector * t;
        }
    }
}
