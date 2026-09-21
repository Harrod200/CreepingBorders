using System.Collections.Generic;
using System.Linq;
using PavonisInteractive.TerraInvicta;

namespace Assistance
{
    /// <summary>
    /// Manual diagnostic for TIRegionState_BorderDistance. This is NOT something I
    /// (the AI) can run — it requires an actual running game with regions loaded
    /// and, ideally, the map scene visible so RegionController instances (and
    /// therefore real border polygons, not just centroid fallback) exist.
    ///
    /// Wire this up to a debug button (see Main.cs snippet in the comment below)
    /// or call TIRegionBorderDistanceTest.RunNamedPairTest() from anywhere you can
    /// trigger code in-game (a UMM console command, a temporary keybind, etc.).
    ///
    /// Results are written via Main.mod.Logger.Log, so check the UMM log
    /// panel/file after running it.
    /// </summary>
    public static class TIRegionBorderDistanceTest
    {
        /// <summary>
        /// Finds all regions whose displayName contains the given text
        /// (case-insensitive). Use this first if you're not sure of the exact
        /// display name / whether a city has its own region at all in TI's
        /// (coarse) region map — TI regions are often much bigger than a single
        /// city, so "Singapore" and "Kuala Lumpur" may simply BE the same region.
        /// </summary>
        public static List<TIRegionState> FindRegionsByDisplayName(string partial)
        {
            return GameStateManager.AllRegions()
                .Where(r => r.displayName != null &&
                            r.displayName.ToLowerInvariant().Contains(partial.ToLowerInvariant()))
                .ToList();
        }

        /// <summary>
        /// Looks up the four named regions, logs which actual region each name
        /// resolved to (important: if two names resolve to the SAME TIRegionState,
        /// the 0 km result is trivially correct via the regionA == regionB
        /// short-circuit — not evidence the border-distance math itself works),
        /// whether each had a live RegionController (real polygon vs. centroid
        /// fallback), and the three requested pairwise distances.
        /// </summary>
        public static void RunNamedPairTest()
        {
            LogCandidates("Singapore");
            LogCandidates("Kuala Lumpur");
            LogCandidates("Jakarta");
            LogCandidates("Medan");

            TIRegionState singapore = FindRegionsByDisplayName("Singapore").FirstOrDefault();
            TIRegionState kualaLumpur = FindRegionsByDisplayName("Kuala Lumpur").FirstOrDefault();
            TIRegionState jakarta = FindRegionsByDisplayName("Jakarta").FirstOrDefault();
            TIRegionState medan = FindRegionsByDisplayName("Medan").FirstOrDefault();

            RunPair("Singapore", singapore, "Kuala Lumpur", kualaLumpur);
            RunPair("Singapore", singapore, "Jakarta", jakarta);
            RunPair("Medan", medan, "Jakarta", jakarta);
        }

        private static void LogCandidates(string searchTerm)
        {
            List<TIRegionState> matches = FindRegionsByDisplayName(searchTerm);

            if (matches.Count == 0)
            {
                Log($"[BorderDistanceTest] No region displayName contains \"{searchTerm}\".");
                return;
            }

            foreach (TIRegionState match in matches)
            {
                Log($"[BorderDistanceTest] \"{searchTerm}\" matched region: " +
                    $"displayName=\"{match.displayName}\" templateName=\"{match.templateName}\" " +
                    $"centroid=({match.latitude:F4}, {match.longitude:F4}) " +
                    $"hasLiveController={(match.Controller != null)}");
            }
        }

        private static void RunPair(string nameA, TIRegionState regionA, string nameB, TIRegionState regionB)
        {
            if (regionA == null || regionB == null)
            {
                Log($"[BorderDistanceTest] Skipping {nameA} vs {nameB} — one or both regions not found.");
                return;
            }

            if (regionA == regionB)
            {
                Log($"[BorderDistanceTest] {nameA} vs {nameB}: SAME TIRegionState " +
                    $"(\"{regionA.displayName}\") — 0 km is trivial (region == region short-circuit), " +
                    "not a test of the border-polygon math.");
                return;
            }

            float borderDistance = regionA.ShortestBorderDistance_km(regionB);
            float centroidDistance = regionA.DistanceToRegion_km(regionB);

            Log($"[BorderDistanceTest] {nameA} (\"{regionA.displayName}\") vs {nameB} (\"{regionB.displayName}\"): " +
                $"border={borderDistance:F1} km, centroid={centroidDistance:F1} km, " +
                $"usedRealPolygon={(regionA.Controller != null && regionB.Controller != null)}");
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

/*
Add debug buttons to trigger these from Main.cs's OnGUI, next to the existing
settings toggles, gated behind debugLogging so it doesn't clutter the normal panel:

    if (Main.settings.debugLogging)
    {
        GUILayout.Space(8f);
        if (GUILayout.Button("Run Border Distance Test (SG/KL/Jakarta/Medan)", new GUILayoutOption[0]))
        {
            TIRegionBorderDistanceTest.RunNamedPairTest();
        }

        GUILayout.Space(4f);
        if (GUILayout.Button("Precompute ALL Region Border Distances (slow, one-time)", new GUILayoutOption[0]))
        {
            TIRegionState_BorderDistance.PrecomputeAllPairs();
        }
    }

Run the precompute button FIRST (with the full world map loaded/visible), check
the log for the "WARNING: N regions had no live Controller" line and re-run if
that count isn't 0, THEN run the named-pair test — at that point every distance
it reports will be served from the disk-backed table instead of a live sweep,
and RunPair's "usedRealPolygon" check tells you whether the baked value came
from real geometry or a centroid fallback for that particular pair.
*/
