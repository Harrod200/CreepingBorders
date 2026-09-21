using System;
using System.Collections.Generic;
using UnityEngine;

namespace CreepingBorders
{
    /// <summary>
    /// C1 verification: pure-logic tests of the distance layer. Called once from
    /// CreepingBordersCls on game load when EnableDebugLogging is on. Logs PASS/FAIL.
    /// </summary>
    public static class TestDistanceLayer
    {
        public static void Run(Action<string> log)
        {
            var failures = new List<string>();

            // 1. PairKey dedup
            string k1 = GeographicPolygonMath.PairKey("b", "a");
            string k2 = GeographicPolygonMath.PairKey("a", "b");
            if (k1 != k2) failures.Add($"PairKey not deduped: {k1} vs {k2}");

            // 2. Identical polygons → 0
            var square = new List<Vector2>();
            for (int i = 0; i <= 8; i++)
            {
                double lon = -0.001 + 0.002 * i / 8.0;
                square.Add(new Vector2((float)lon, (float)(0.001 * Math.Sin(lon * 2))));
            }
            double selfDist = GeographicPolygonMath.EdgeToEdgeDistanceKm(square, square, 6371.0);
            if (selfDist > 1.0) failures.Add($"Self-polygon distance should be ~0, got {selfDist:F3}");

            // 3. Two equatorial strips 1 degree apart latitudinally → ~111.19 km
            var stripA = new List<Vector2>();
            var stripB = new List<Vector2>();
            for (int i = 0; i <= 8; i++)
            {
                float lon = (float)((0.5 + i / 8.0) * Mathf.Deg2Rad);
                stripA.Add(new Vector2(lon, 0f));
                stripB.Add(new Vector2(lon, Mathf.Deg2Rad)); // 1 degree north
            }
            double oneDeg = GeographicPolygonMath.EdgeToEdgeDistanceKm(stripA, stripB, 6371.0);
            if (Math.Abs(oneDeg - 111.19) > 2.0)
                failures.Add($"1-degree equator distance expected ~111.19, got {oneDeg:F2}");

            // 4. Antipodal-crossing safety: near-antipodal points must not yield negative/huge values
            var nearA = new List<Vector2> { new Vector2(0f, 0f), new Vector2(0.01f, 0f) };
            var nearB = new List<Vector2> { new Vector2(Mathf.PI - 0.01f, 0f), new Vector2(Mathf.PI, 0f) };
            double anti = GeographicPolygonMath.EdgeToEdgeDistanceKm(nearA, nearB, 6371.0);
            if (anti < 0 || anti > 20015.0 * 1.01)
                failures.Add($"Near-antipodal distance out of range: {anti:F1}");

            // 5. Small-crossing segments → 0
            var crossA = new List<Vector2> { new Vector2(-0.1f, 0f), new Vector2(0.1f, 0f) };
            var crossB = new List<Vector2> { new Vector2(0f, -0.1f), new Vector2(0f, 0.1f) };
            double cross = GeographicPolygonMath.EdgeToEdgeDistanceKm(crossA, crossB, 6371.0);
            if (cross > 1.0) failures.Add($"Crossing segments should be ~0, got {cross:F3}");

            if (failures.Count == 0)
                log("[C1-Test] ALL PASS — dedup, self-distance, 1-degree equator, antipodal safety, crossing segments.");
            else
                foreach (var f in failures) log("[C1-Test] FAIL: " + f);
        }
    }
}
