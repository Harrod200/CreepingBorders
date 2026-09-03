using HarmonyLib;
using PavonisInteractive.TerraInvicta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityModManagerNet;


namespace CreepingBorders
{
    /// <summary>
    /// Enumeration for landmass types
    /// </summary>
    public enum LandmassType
    {
        Island,
        Continent
    }

    public class CreepingBordersSettings : UnityModManager.ModSettings
    {
        public bool EnableBorderExpansion = true;
        public bool NoHostileClaims = true;
        public bool NoDistanceCohesionMalus = true;
        public bool NoPopulationMalus = true;
        public bool ClaimIslandsOnCapitalContact = false;
        public bool ClaimIslandsWithinDistance = false;
        public float ClaimIslandsDistanceKM = 1000f;
        public float CohesionRestStateBaseValue = 16f;
        public bool EnableDiscontiguityMalus = false;
        public float DiscontiguityMalusPercentage = 5.0f;
        public bool EnableInstantAnnexations = true;
        public bool EnableDebugLogging = false;

        public override void Save(UnityModManager.ModEntry modEntry)
        {
            UnityModManager.ModSettings.Save<CreepingBordersSettings>(this, modEntry);
        }
    }

    public class CreepingBordersCls
    {
        public static UnityModManager.ModEntry mod;
        public static CreepingBordersSettings Settings;
        public static bool enabled = true;

        public static bool Load(UnityModManager.ModEntry modEntry)
        {
            CreepingBordersCls.mod = modEntry;
            CreepingBordersCls.Settings = UnityModManager.ModSettings.Load<CreepingBordersSettings>(modEntry);
            modEntry.OnToggle = new System.Func<UnityModManager.ModEntry, bool, bool>(CreepingBordersCls.OnToggle);
            modEntry.OnGUI = new System.Action<UnityModManager.ModEntry>(CreepingBordersCls.OnGUI);
            modEntry.OnSaveGUI = new System.Action<UnityModManager.ModEntry>(CreepingBordersCls.OnSaveGUI);
            modEntry.OnUpdate = new System.Action<UnityModManager.ModEntry, float>(CreepingBordersCls.OnUpdate);

            try
            {
                var harmony = new HarmonyLib.Harmony("com.creepingborders.harmonymod");
                harmony.PatchAll();
                modEntry.Logger.Log("Creeping Borders patches applied.");
                return true;
            }
            catch (Exception ex)
            {
                modEntry.Logger.Error("Failed to apply patches: " + ex);
                return false;
            }
        }

        private static bool islandAnalysisPerformed = false;

        private static void OnUpdate(UnityModManager.ModEntry modEntry, float deltaTime)
        {
            // Run island analysis once when the game is first loaded
            if (!islandAnalysisPerformed && GameStateManager.HasGamestates)
            {
                islandAnalysisPerformed = true;
                AnalyzeIslandDistances();
            }
        }

        private static bool OnToggle(UnityModManager.ModEntry modEntry, bool value)
        {
            CreepingBordersCls.enabled = value;
            return true;
        }

        private static void OnGUI(UnityModManager.ModEntry modEntry)
        {
            GUILayout.Label("Creeping Borders Settings:", new GUILayoutOption[0]);

            // ====================================================================
            // BORDER EXPANSION
            // ====================================================================
            GUILayout.Space(8f);
            GUILayout.Label("<b>Border Expansion</b>", new GUILayoutOption[0]);
            CreepingBordersCls.Settings.EnableBorderExpansion = GUILayout.Toggle(CreepingBordersCls.Settings.EnableBorderExpansion, "Enable Border Expansion", new GUILayoutOption[0]);
            GUILayout.Label("Automatically expands nation borders by claiming adjacent unclaimed regions when control of a region changes", new GUILayoutOption[0]);

            // ====================================================================
            // ISLAND CLAIMS
            // ====================================================================
            GUILayout.Space(8f);
            GUILayout.Label("<b>Island Claims</b>", new GUILayoutOption[0]);

            CreepingBordersCls.Settings.ClaimIslandsOnCapitalContact = GUILayout.Toggle(CreepingBordersCls.Settings.ClaimIslandsOnCapitalContact, "Claim Islands on Capital Contact", new GUILayoutOption[0]);
            GUILayout.Label("When bordering an enemy nation's capital, automatically claim all island regions belonging to that nation", new GUILayoutOption[0]);

            GUILayout.Space(8f);
            CreepingBordersCls.Settings.ClaimIslandsWithinDistance = GUILayout.Toggle(CreepingBordersCls.Settings.ClaimIslandsWithinDistance, "Claim Islands Within Distance", new GUILayoutOption[0]);
            GUILayout.Label("Claim all island regions of neighboring nations within the distance threshold (in KM)", new GUILayoutOption[0]);

            GUILayout.Space(8f);
            GUILayout.Label("Island Claim Distance: " + CreepingBordersCls.Settings.ClaimIslandsDistanceKM.ToString("F0") + " KM", new GUILayoutOption[0]);
            CreepingBordersCls.Settings.ClaimIslandsDistanceKM = GUILayout.HorizontalSlider(CreepingBordersCls.Settings.ClaimIslandsDistanceKM, 50f, 2000f, new GUILayoutOption[0]);
            // Round to nearest 50
            CreepingBordersCls.Settings.ClaimIslandsDistanceKM = Mathf.Round(CreepingBordersCls.Settings.ClaimIslandsDistanceKM / 50f) * 50f;

            // ====================================================================
            // CLAIM BEHAVIOR
            // ====================================================================
            GUILayout.Space(8f);
            GUILayout.Label("<b>Claim Behavior</b>", new GUILayoutOption[0]);
            CreepingBordersCls.Settings.NoHostileClaims = GUILayout.Toggle(CreepingBordersCls.Settings.NoHostileClaims, "No Hostile Claims", new GUILayoutOption[0]);
            GUILayout.Label("Makes all hostile claims friendly", new GUILayoutOption[0]);

            GUILayout.Space(8f);
            CreepingBordersCls.Settings.EnableInstantAnnexations = GUILayout.Toggle(CreepingBordersCls.Settings.EnableInstantAnnexations, "Enable Instant Annexations", new GUILayoutOption[0]);
            GUILayout.Label("Automatically annexes annexable regions instantly instead of requiring occupation", new GUILayoutOption[0]);

            // ====================================================================
            // COHESION SYSTEM
            // ====================================================================
            GUILayout.Space(8f);
            GUILayout.Label("<b>Cohesion System</b>", new GUILayoutOption[0]);

            GUILayout.Label("Cohesion Rest State Base Value: " + CreepingBordersCls.Settings.CohesionRestStateBaseValue.ToString("F1"), new GUILayoutOption[0]);
            CreepingBordersCls.Settings.CohesionRestStateBaseValue = GUILayout.HorizontalSlider(CreepingBordersCls.Settings.CohesionRestStateBaseValue, 5f, 50f, new GUILayoutOption[0]);
            // Round to nearest 0.5
            CreepingBordersCls.Settings.CohesionRestStateBaseValue = Mathf.Round(CreepingBordersCls.Settings.CohesionRestStateBaseValue * 2f) / 2f;

            GUILayout.Space(8f);
            CreepingBordersCls.Settings.NoDistanceCohesionMalus = GUILayout.Toggle(CreepingBordersCls.Settings.NoDistanceCohesionMalus, "No Distance Cohesion Malus", new GUILayoutOption[0]);
            GUILayout.Label("Removes the cohesion malus from distance between claimed regions", new GUILayoutOption[0]);

            GUILayout.Space(8f);
            CreepingBordersCls.Settings.NoPopulationMalus = GUILayout.Toggle(CreepingBordersCls.Settings.NoPopulationMalus, "No Population Malus", new GUILayoutOption[0]);
            GUILayout.Label("Removes the cohesion malus from population", new GUILayoutOption[0]);

            GUILayout.Space(8f);
            CreepingBordersCls.Settings.EnableDiscontiguityMalus = GUILayout.Toggle(CreepingBordersCls.Settings.EnableDiscontiguityMalus, "Enable Discontiguity Malus", new GUILayoutOption[0]);
            GUILayout.Label("Apply a malus to cohesion for non-contiguous regions. Contiguous = reachable from capital without crossing enemy territory", new GUILayoutOption[0]);

            if (CreepingBordersCls.Settings.EnableDiscontiguityMalus)
            {
                GUILayout.Space(4f);
                GUILayout.Label("Discontiguity Malus Percentage: " + CreepingBordersCls.Settings.DiscontiguityMalusPercentage.ToString("F1") + "%", new GUILayoutOption[0]);
                CreepingBordersCls.Settings.DiscontiguityMalusPercentage = GUILayout.HorizontalSlider(CreepingBordersCls.Settings.DiscontiguityMalusPercentage, 0.5f, 10f, new GUILayoutOption[0]);
            }

            // ====================================================================
            // UTILITIES
            // ====================================================================
            GUILayout.Space(8f);
            GUILayout.Label("<b>Utilities</b>", new GUILayoutOption[0]);
            CreepingBordersCls.Settings.EnableDebugLogging = GUILayout.Toggle(CreepingBordersCls.Settings.EnableDebugLogging, "Enable Debug Logging", new GUILayoutOption[0]);
            GUILayout.Label("Logs cohesion calculations for each nation", new GUILayoutOption[0]);
        }

        private static void OnSaveGUI(UnityModManager.ModEntry modEntry)
        {
            CreepingBordersCls.Settings.Save(modEntry);
        }

        /// <summary>
        /// Analyzes island distances for all nations at mod load time.
        /// Identifies the closest contiguous region for each island and logs the information.
        /// Checks every island region against its controlling nation only.
        /// </summary>
        public static void AnalyzeIslandDistances()
        {
            if (!CreepingBordersCls.enabled)
                return;

            try
            {
                TINationState[] allNations = GameStateManager.AllNations();
                if (allNations == null || allNations.Length == 0)
                    return;

                CreepingBordersCls.mod.Logger.Log("[Island Analysis] Starting island distance analysis - checking every island against its controlling nation...");
                int totalIslandsAnalyzed = 0;
                HashSet<TIRegionState> analyzedIslands = new HashSet<TIRegionState>(); // Track analyzed islands to avoid duplicates

                // Iterate through all regions in the game to find islands
                foreach (TINationState nation in allNations)
                {
                    if (nation == null || !nation.extant || nation.regions == null || nation.regions.Count == 0)
                        continue;

                    // For each region this nation controls, check if it's an island
                    foreach (TIRegionState region in nation.regions)
                    {
                        if (region == null || analyzedIslands.Contains(region))
                            continue;

                        // Check if this region is an island
                        if (region.GetLandmassType() != LandmassType.Island)
                            continue;

                        // Mark this island as analyzed
                        analyzedIslands.Add(region);
                        totalIslandsAnalyzed++;

                        // Get contiguous regions for the nation that controls this island
                        var contiguousInfo = TINationStateExtensions.GetTrueContiguousRegionsWithExtended(nation);
                        if (contiguousInfo.FullyContiguousRegions.Count > 0)
                        {
                            // Analyze this island against only its controlling nation's contiguous regions
                            AnalyzeSingleIsland(region, nation, contiguousInfo.FullyContiguousRegions);
                        }
                        else
                        {
                            // Nation has no contiguous regions (shouldn't happen, but log it)
                            CreepingBordersCls.mod.Logger.Log(
                                $"[Island Analysis] Island: {region.displayName} | Nation: {nation.displayName} | " +
                                $"WARNING: Controlling nation has no contiguous regions");
                        }
                    }
                }

                CreepingBordersCls.mod.Logger.Log($"[Island Analysis] Analysis complete. Analyzed {totalIslandsAnalyzed} islands across all nations.");
            }
            catch (Exception ex)
            {
                CreepingBordersCls.mod.Logger.Error($"[Island Analysis] Error during island distance analysis: {ex.Message}");
            }
        }

        /// <summary>
        /// Analyzes a single island and logs its closest contiguous region and distance.
        /// Also identifies and logs if the island is fully discontiguous.
        /// </summary>
        private static void AnalyzeSingleIsland(TIRegionState island, TINationState nation, HashSet<TIRegionState> contiguousRegions)
        {
            if (island == null || contiguousRegions == null || contiguousRegions.Count == 0)
                return;

            float minDistance = float.MaxValue;
            TIRegionState closestRegion = null;
            float maxDistance = CreepingBordersCls.Settings.ClaimIslandsDistanceKM;
            float extendedMaxDistance = maxDistance * 2f; // 200% threshold for extended distance

            // Find the closest contiguous region
            foreach (TIRegionState contiguousRegion in contiguousRegions)
            {
                if (contiguousRegion == null)
                    continue;

                float distance = TIRegionState.DistanceBetweenTwoCoordinates_km(
                    island.latitude, island.longitude,
                    contiguousRegion.latitude, contiguousRegion.longitude,
                    island.ref_spaceBody.meanRadius_km);

                if (distance < minDistance)
                {
                    minDistance = distance;
                    closestRegion = contiguousRegion;
                }
            }

            if (closestRegion != null && minDistance < float.MaxValue)
            {
                // Determine if island is fully discontiguous or partially contiguous
                bool isFullyDiscontiguous = minDistance > extendedMaxDistance;
                bool isPartiallyDiscontiguous = !isFullyDiscontiguous && minDistance > maxDistance;

                string contiguityStatus = isFullyDiscontiguous ? "FULLY DISCONTIGUOUS" : 
                                         isPartiallyDiscontiguous ? "PARTIALLY DISCONTIGUOUS (Extended Distance)" : 
                                         "CONTIGUOUS";

                // Check if this island is a bridge island (adjacent to other islands in contiguous set)
                bool isBridgeIsland = false;
                int adjacentIslandCount = 0;
                foreach (TIRegionState neighbor in island.Neighbors)
                {
                    if (neighbor != null && neighbor.nation == nation && 
                        neighbor.GetLandmassType() == LandmassType.Island && 
                        contiguousRegions.Contains(neighbor))
                    {
                        isBridgeIsland = true;
                        adjacentIslandCount++;
                    }
                }

                string bridgeInfo = isBridgeIsland ? $" [BRIDGE ISLAND - connects {adjacentIslandCount} other island(s)]" : "";

                CreepingBordersCls.mod.Logger.Log(
                    $"[Island Analysis] Island: {island.displayName} | Nation: {nation.displayName} | " +
                    $"Closest Region: {closestRegion.displayName} | Distance: {minDistance:F2} km | " +
                    $"Status: {contiguityStatus}{bridgeInfo}");

                // Log detailed warning for fully discontiguous islands
                if (isFullyDiscontiguous)
                {
                    CreepingBordersCls.mod.Logger.Log(
                        $"[Island Analysis] ⚠️  ALERT: {island.displayName} is FULLY DISCONTIGUOUS " +
                        $"({minDistance:F2} km from {closestRegion.displayName}, beyond max {extendedMaxDistance:F2} km threshold)");
                }
            }
        }
    }

    // ====================================================================
    // PHASE 2: EXTENSION METHODS
    // ====================================================================

    /// <summary>
    /// Extension methods for TINationState to handle annexable regions logic
    /// </summary>
    public static class TINationStateExtensions
    {
        // Cache for distance calculations to avoid repeated Haversine formula computation
        private static readonly Dictionary<(TIRegionState, TIRegionState), float> distanceCache = 
            new Dictionary<(TIRegionState, TIRegionState), float>();

        // Cache for coastal region checks to avoid iterating neighbors repeatedly
        private static readonly Dictionary<TIRegionState, bool> coastalRegionCache = 
            new Dictionary<TIRegionState, bool>();

        /// <summary>
        /// Clears the distance cache (call after significant game state changes)
        /// </summary>
        public static void ClearDistanceCache()
        {
            distanceCache.Clear();
        }

        /// <summary>
        /// Clears the coastal region cache (call after borders change)
        /// </summary>
        public static void ClearCoastalRegionCache()
        {
            coastalRegionCache.Clear();
        }
        /// Generic BFS traversal with custom traversability predicate
        /// Returns set of regions reachable from starting point
        /// </summary>
        private static HashSet<TIRegionState> BFSTraversal(TIRegionState start, 
            Func<TIRegionState, TINationState, bool> canTraverse, TINationState context = null)
        {
            HashSet<TIRegionState> visited = new HashSet<TIRegionState>();

            if (start == null)
                return visited;

            Queue<TIRegionState> queue = new Queue<TIRegionState>();
            queue.Enqueue(start);
            visited.Add(start);

            while (queue.Count > 0)
            {
                TIRegionState current = queue.Dequeue();

                foreach (TIRegionState neighbor in current.Neighbors)
                {
                    if (neighbor == null || visited.Contains(neighbor))
                        continue;

                    if (!canTraverse(neighbor, context))
                        continue;

                    visited.Add(neighbor);
                    queue.Enqueue(neighbor);
                }
            }

            return visited;
        }

        /// <summary>
        /// Checks if a region is within distance range of any region in the given set
        /// Uses cached distance calculations to avoid repeated Haversine formula computation
        /// </summary>
        private static bool IsWithinDistanceOf(TIRegionState region, HashSet<TIRegionState> referenceRegions, float maxDistanceKm)
        {
            if (region == null || referenceRegions == null || referenceRegions.Count == 0 || maxDistanceKm <= 0)
                return false;

            // Check distance to each reference region with early exit on first match
            foreach (TIRegionState refRegion in referenceRegions)
            {
                if (refRegion == null)
                    continue;

                // Check cache first, calculate if not cached
                // Use direct tuple comparison (works for reference types)
                var key = (region, refRegion);
                if (!distanceCache.TryGetValue(key, out float distance))
                {
                    distance = TIRegionState.DistanceBetweenTwoCoordinates_km(
                        region.latitude, region.longitude,
                        refRegion.latitude, refRegion.longitude,
                        region.ref_spaceBody.meanRadius_km);
                    distanceCache[key] = distance;
                }

                if (distance <= maxDistanceKm)
                    return true; // Early exit - found a reference region within distance
            }

            return false;
        }

        /// <summary>
        /// Checks if a region is within extended distance (up to 200% of maxDistance)
        /// Returns distance category: 0 = within normal range, 1 = extended range, -1 = out of range
        /// </summary>
        private static int GetExtendedDistanceCategory(TIRegionState region, HashSet<TIRegionState> referenceRegions, float maxDistanceKm)
        {
            if (region == null || referenceRegions == null || referenceRegions.Count == 0 || maxDistanceKm <= 0)
                return -1; // Out of range

            float extendedMaxDistance = maxDistanceKm * 2f; // 200% of max distance

            foreach (TIRegionState refRegion in referenceRegions)
            {
                if (refRegion == null)
                    continue;

                // Check cache first, calculate if not cached
                var key = (region, refRegion);
                if (!distanceCache.TryGetValue(key, out float distance))
                {
                    distance = TIRegionState.DistanceBetweenTwoCoordinates_km(
                        region.latitude, region.longitude,
                        refRegion.latitude, refRegion.longitude,
                        region.ref_spaceBody.meanRadius_km);
                    distanceCache[key] = distance;
                }

                if (distance <= maxDistanceKm)
                    return 0; // Within normal range
                else if (distance <= extendedMaxDistance)
                    return 1; // Extended range
            }

            return -1; // Out of range
        }

        /// <summary>
        /// Gets the extended distance category, actual distance to nearest reference region, and the closest region's name.
        /// Returns a tuple of (category, distance, closestRegionName) where:
        /// - category: 0 (normal), 1 (extended), -1 (out of range)
        /// - distance: The actual distance to the nearest reference region, or float.MaxValue if out of range
        /// - closestRegionName: The display name of the closest reference region, or "Unknown" if none found
        /// </summary>
        private static (int category, float distance, string closestRegionName) GetExtendedDistanceInfo(TIRegionState region, HashSet<TIRegionState> referenceRegions, float maxDistanceKm)
        {
            if (region == null || referenceRegions == null || referenceRegions.Count == 0 || maxDistanceKm <= 0)
                return (-1, float.MaxValue, "Unknown");

            float extendedMaxDistance = maxDistanceKm * 2f; // 200% of max distance
            float minDistance = float.MaxValue;
            int category = -1;
            TIRegionState closestRegion = null;

            foreach (TIRegionState refRegion in referenceRegions)
            {
                if (refRegion == null)
                    continue;

                // Normalize cache key to ensure (A,B) and (B,A) map to the same cache entry
                var normalizedKey = region.GetHashCode() < refRegion.GetHashCode() 
                    ? (region, refRegion) 
                    : (refRegion, region);

                if (!distanceCache.TryGetValue(normalizedKey, out float distance))
                {
                    distance = TIRegionState.DistanceBetweenTwoCoordinates_km(
                        region.latitude, region.longitude,
                        refRegion.latitude, refRegion.longitude,
                        region.ref_spaceBody.meanRadius_km);
                    distanceCache[normalizedKey] = distance;
                }

                if (distance < minDistance)
                {
                    minDistance = distance;
                    closestRegion = refRegion;

                    if (distance <= maxDistanceKm)
                    {
                        category = 0; // Within normal range - early exit since we found the best case
                        return (category, minDistance, closestRegion.displayName);
                    }
                    else if (distance <= extendedMaxDistance)
                        category = 1; // Extended range
                }
            }

            string closestRegionName = closestRegion != null ? closestRegion.displayName : "Unknown";
            return (category, minDistance < float.MaxValue ? minDistance : float.MaxValue, closestRegionName);
        }



        /// <summary>
        /// Gets regions that can be directly annexed by this nation.
        /// Uses BFS to find contiguous regions from capital and identifies island landmasses.
        /// </summary>
        public static List<TIRegionState> AnnexableRegions(this TINationState nation)
        {
            if (!CreepingBordersCls.enabled || nation == null || nation.capital == null || 
                nation.claims == null || nation.claims.Count == 0)
            {
                return new List<TIRegionState>();
            }

            // Build HashSet of claimed regions for O(1) lookup
            var claimedSet = new HashSet<TIRegionState>(nation.claims);

            // Find all regions contiguous with the capital using full adjacency BFS
            var contiguousWithCapital = BFSTraversal(nation.capital, (neighbor, n) =>
            {
                return neighbor.IsAdjacent(neighbor, true) && claimedSet.Contains(neighbor);
            });

            // Collect annexable regions
            var annexableRegions = new List<TIRegionState>(contiguousWithCapital.Count + 10); // Pre-size for efficiency

            // Check all claimed regions for annexability
            foreach (TIRegionState claimedRegion in nation.claims)
            {
                if (claimedRegion == null || claimedRegion.nation == nation)
                    continue;

                // Criterion 1: Contiguous with capital OR Criterion 2: Island landmass
                if (contiguousWithCapital.Contains(claimedRegion) || 
                    claimedRegion.GetLandmassType() == LandmassType.Island)
                {
                    annexableRegions.Add(claimedRegion);
                }
            }

            return annexableRegions;
        }

        /// <summary>
        /// Result type for contiguous regions with extended distance tracking
        /// </summary>
        public class ContiguousRegionsInfo
        {
            /// <summary>
            /// Regions within normal maxDistance (fully contiguous)
            /// </summary>
            public HashSet<TIRegionState> FullyContiguousRegions { get; set; }

            /// <summary>
            /// Regions between maxDistance and 200% of maxDistance (extended/partial islands)
            /// </summary>
            public HashSet<TIRegionState> ExtendedDistanceRegions { get; set; }

            /// <summary>
            /// Combined set for quick lookup (FullyContiguousRegions + ExtendedDistanceRegions)
            /// </summary>
            public HashSet<TIRegionState> AllContiguousRegions { get; set; }
        }

        /// <summary>
        /// Gets regions that are truly contiguous with the capital, treating regions held by other nations as blockers.
        /// Also includes islands within ClaimIslandsDistanceKM range if enabled.
        /// Uses BFS with IsAdjacent checks to find connected regions only through owned or unclaimed territory.
        /// </summary>
        public static HashSet<TIRegionState> GetTrueContiguousRegions(this TINationState nation)
        {
            if (nation == null || nation.capital == null)
                return new HashSet<TIRegionState>();

            // Use internal method to get full info, extract only fully contiguous for backward compatibility
            var fullInfo = GetTrueContiguousRegionsWithExtended(nation);
            return fullInfo.AllContiguousRegions;
        }

        /// <summary>
        /// Gets regions that are truly contiguous with the capital, including extended distance islands.
        /// Returns both fully contiguous and extended distance regions separately.
        /// Extended distance regions (100-200% of maxDistance) are treated as partially contiguous.
        /// </summary>
        public static ContiguousRegionsInfo GetTrueContiguousRegionsWithExtended(TINationState nation)
        {
            var result = new ContiguousRegionsInfo
            {
                FullyContiguousRegions = new HashSet<TIRegionState>(),
                ExtendedDistanceRegions = new HashSet<TIRegionState>(),
                AllContiguousRegions = new HashSet<TIRegionState>()
            };

            if (nation == null || nation.capital == null)
                return result;

            // First pass: BFS from capital through adjacency only
            Queue<TIRegionState> queue = new Queue<TIRegionState>();
            queue.Enqueue(nation.capital);
            result.FullyContiguousRegions.Add(nation.capital);
            result.AllContiguousRegions.Add(nation.capital);

            while (queue.Count > 0)
            {
                TIRegionState current = queue.Dequeue();

                foreach (TIRegionState neighbor in current.Neighbors)
                {
                    if (neighbor == null)
                        continue;

                    // Check adjacency: true for FullAdjacency or FriendlyCrossingOnly
                    if (!neighbor.IsAdjacent(current, false))
                        continue;

                    // Only traverse if neighbor is owned by this nation or is unclaimed
                    if (neighbor.nation != null && neighbor.nation != nation)
                        continue;

                    // Use Add() return value to check if already visited (more efficient than Contains())
                    if (result.AllContiguousRegions.Add(neighbor))
                    {
                        result.FullyContiguousRegions.Add(neighbor);
                        queue.Enqueue(neighbor);
                    }
                }
            }

            // Second pass: Add islands within distance range (normal and extended)
            // Skips if ClaimIslandsWithinDistance is disabled or if ClaimIslandsDistanceKM is 0 (early exit optimization)
            if (nation.regions != null && CreepingBordersCls.Settings.ClaimIslandsWithinDistance)
            {
                float maxDistance = CreepingBordersCls.Settings.ClaimIslandsDistanceKM;
                if (maxDistance > 0) // Early exit: distance disabled or set to 0
                {
                    // Pre-filter islands and coastal continents (cheaper check) before expensive distance calculations
                    var candidateRegions = new List<TIRegionState>();
                    var regionTypeMap = new Dictionary<TIRegionState, string>();

                    foreach (TIRegionState region in nation.regions)
                    {
                        if (region == null || result.AllContiguousRegions.Contains(region))
                            continue;

                        // Include islands OR coastal continents
                        LandmassType landmassType = region.GetLandmassType();
                        if (landmassType == LandmassType.Island)
                        {
                            candidateRegions.Add(region);
                            regionTypeMap[region] = "Island";
                        }
                        else if (landmassType == LandmassType.Continent && IsCoastalRegion(region))
                        {
                            candidateRegions.Add(region);
                            regionTypeMap[region] = "Coastal Continent";
                        }
                    }

                    // Check distance for filtered region candidates
                    if (candidateRegions.Count > 0)
                    {
                        var regionsToAdd = new Dictionary<TIRegionState, bool>(); // true = fully, false = extended

                        foreach (TIRegionState region in candidateRegions)
                        {
                            var (distanceCategory, distance, closestRegionName) = GetExtendedDistanceInfo(region, result.FullyContiguousRegions, maxDistance);

                            if (distanceCategory == 0)
                            {
                                // Within normal range - fully contiguous
                                regionsToAdd[region] = true;
                                if (CreepingBordersCls.Settings.EnableDebugLogging)
                                {
                                    string regionType = regionTypeMap[region];
                                    CreepingBordersCls.mod.Logger.Log($"[Contiguity] {region.displayName} ({nation.displayName}): {regionType} within distance range (fully contiguous) - Distance: {distance:F2} km from {closestRegionName}");
                                }
                            }
                            else if (distanceCategory == 1)
                            {
                                // Extended range - partially contiguous
                                regionsToAdd[region] = false;
                                if (CreepingBordersCls.Settings.EnableDebugLogging)
                                {
                                    string regionType = regionTypeMap[region];
                                    CreepingBordersCls.mod.Logger.Log($"[Contiguity] {region.displayName} ({nation.displayName}): {regionType} in extended distance range (partially contiguous) - Distance: {distance:F2} km from {closestRegionName} (max: {maxDistance:F2} km)");
                                }
                            }
                        }

                        // Add all discovered regions in single pass
                        foreach (var kvp in regionsToAdd)
                        {
                            result.AllContiguousRegions.Add(kvp.Key);
                            if (kvp.Value)
                            {
                                result.FullyContiguousRegions.Add(kvp.Key);
                            }
                            else
                            {
                                result.ExtendedDistanceRegions.Add(kvp.Key);
                            }
                        }
                    }
                }
            }

            // Third pass: Find continental regions connected through coastal island chains
            // This allows regions separated only by a chain of adjacent islands to be contiguous
            if (nation.regions != null)
            {
                FindContinentsConnectedByIslands(nation, result);
            }

            return result;
        }

        /// <summary>
        /// Determines if an island is coastal (adjacent to any contiguous region of the nation).
        /// Used to identify islands that can serve as bridges between continental regions.
        /// </summary>
        private static bool IsCoastalIsland(TIRegionState island, TINationState nation, HashSet<TIRegionState> contiguousRegions)
        {
            if (island == null || island.GetLandmassType() != LandmassType.Island || island.nation != nation)
                return false;

            // Check if this island is adjacent to any contiguous region
            foreach (TIRegionState neighbor in island.Neighbors)
            {
                if (neighbor != null && contiguousRegions.Contains(neighbor))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Checks if a region (island or continent) is coastal (has water neighbors)
        /// Used to determine if a region can bridge to other regions through distance-based detection
        /// Results are cached to avoid repeated neighbor iteration
        /// </summary>
        private static bool IsCoastalRegion(TIRegionState region)
        {
            if (region == null)
                return false;

            // Check cache first
            if (coastalRegionCache.TryGetValue(region, out bool isCached))
                return isCached;

            // Check if this region has any water neighbors
            bool isCoastal = false;
            foreach (TIRegionState neighbor in region.Neighbors)
            {
                if (neighbor != null && neighbor.onTheWater)
                {
                    isCoastal = true;
                    break;
                }
            }

            coastalRegionCache[region] = isCoastal;
            return isCoastal;
        }

        /// <summary>
        /// Finds continental regions connected to the nation through coastal island chains.
        /// Uses BFS to traverse through adjacent coastal islands to discover new continental regions.
        /// Also discovers island-to-island connections through coastal islands (allowing islands to be bridged together).
        /// Runs iteratively to handle chains of islands that act as bridges.
        /// Modifies currentContiguity in-place to add newly discovered continental regions.
        /// </summary>
        private static void FindContinentsConnectedByIslands(TINationState nation, ContiguousRegionsInfo currentContiguity)
        {
            if (nation == null || nation.regions == null || currentContiguity.FullyContiguousRegions.Count == 0)
                return;

            bool foundNewRegions = true;
            int iterationCount = 0;
            const int maxIterations = 100; // Safety limit to prevent infinite loops

            // Pre-compute landmass types ONCE to avoid repeated expensive GetLandmassType() calls
            var islandLookup = new Dictionary<TIRegionState, bool>(nation.regions.Count);
            foreach (TIRegionState region in nation.regions)
            {
                if (region != null)
                    islandLookup[region] = region.GetLandmassType() == LandmassType.Island;
            }

            // Debug: Log bridge detection starting
            if (CreepingBordersCls.Settings.EnableDebugLogging)
            {
                CreepingBordersCls.mod.Logger.Log($"[Contiguity] Starting bridge island detection for {nation.displayName} with {currentContiguity.FullyContiguousRegions.Count} initial contiguous regions");
            }

            // Iteratively find bridges until no new regions are discovered
            while (foundNewRegions && iterationCount < maxIterations)
            {
                foundNewRegions = false;
                iterationCount++;

                // Find all coastal islands (islands adjacent to currently contiguous regions)
                var coastalIslands = new HashSet<TIRegionState>();
                foreach (TIRegionState region in nation.regions)
                {
                    if (region != null && IsCoastalIsland(region, nation, currentContiguity.FullyContiguousRegions))
                    {
                        coastalIslands.Add(region);
                    }
                }

                if (CreepingBordersCls.Settings.EnableDebugLogging)
                {
                    CreepingBordersCls.mod.Logger.Log($"[Contiguity] Bridge iteration {iterationCount}: Found {coastalIslands.Count} coastal islands");
                    foreach (var island in coastalIslands)
                    {
                        CreepingBordersCls.mod.Logger.Log($"[Contiguity]   - Coastal island: {island.displayName}");
                    }
                }

                // Adjacency-based bridge detection (only if coastal islands exist)
                if (coastalIslands.Count > 0)
                {
                    // BFS through coastal islands to find connected continental regions and other islands
                    Queue<TIRegionState> queue = new Queue<TIRegionState>(coastalIslands);
                    HashSet<TIRegionState> visitedIslands = new HashSet<TIRegionState>(coastalIslands);

                    while (queue.Count > 0)
                    {
                        TIRegionState currentIsland = queue.Dequeue();

                        if (CreepingBordersCls.Settings.EnableDebugLogging)
                        {
                            CreepingBordersCls.mod.Logger.Log($"[Contiguity]   Processing island: {currentIsland.displayName}");
                        }

                        // Check all neighbors of this coastal island
                        foreach (TIRegionState neighbor in currentIsland.Neighbors)
                        {
                            if (neighbor == null)
                            {
                                if (CreepingBordersCls.Settings.EnableDebugLogging)
                                    CreepingBordersCls.mod.Logger.Log($"[Contiguity]     Neighbor is null, skipping");
                                continue;
                            }

                            if (neighbor.nation != nation)
                            {
                                if (CreepingBordersCls.Settings.EnableDebugLogging)
                                    CreepingBordersCls.mod.Logger.Log($"[Contiguity]     Neighbor {neighbor.displayName} not owned by {nation.displayName} (owned by {neighbor.nation?.displayName ?? "none"}), skipping");
                                continue;
                            }

                            // Use pre-computed island lookup (faster than GetLandmassType())
                            bool isNeighborIsland = islandLookup[neighbor];

                            if (CreepingBordersCls.Settings.EnableDebugLogging)
                            {
                                CreepingBordersCls.mod.Logger.Log($"[Contiguity]     Neighbor: {neighbor.displayName} (Island: {isNeighborIsland}, InContiguity: {currentContiguity.AllContiguousRegions.Contains(neighbor)})");
                            }

                            // If neighbor is not yet in contiguity, consider adding it
                            if (currentContiguity.AllContiguousRegions.Add(neighbor))  // Returns true if added
                            {
                                // Add continental regions
                                if (!isNeighborIsland)
                                {
                                    currentContiguity.FullyContiguousRegions.Add(neighbor);
                                    foundNewRegions = true;

                                    if (CreepingBordersCls.Settings.EnableDebugLogging)
                                    {
                                        CreepingBordersCls.mod.Logger.Log(
                                            $"[Contiguity] {neighbor.displayName} ({nation.displayName}): " +
                                            $"Connected to mainland through coastal island chain (via {currentIsland.displayName})");
                                    }
                                }
                                // Add islands that are adjacent to coastal islands (island-to-island bridges)
                                else if (isNeighborIsland)
                                {
                                    currentContiguity.FullyContiguousRegions.Add(neighbor);
                                    foundNewRegions = true;

                                    if (CreepingBordersCls.Settings.EnableDebugLogging)
                                    {
                                        CreepingBordersCls.mod.Logger.Log(
                                            $"[Contiguity] {neighbor.displayName} ({nation.displayName}): " +
                                            $"Island bridged to contiguity through {currentIsland.displayName}");
                                    }
                                }
                            }

                            // If neighbor is another island not yet visited, add it to queue for further exploration
                            if (!visitedIslands.Contains(neighbor) && isNeighborIsland)
                            {
                                visitedIslands.Add(neighbor);
                                queue.Enqueue(neighbor);
                            }
                        }
                    }
                }

                // Third pass: Connect islands within distance range to each other (distance-based bridges)
                // This allows islands that are within ClaimIslandsDistanceKM of each other to be contiguous
                // This is especially important for upgrading extended-distance islands to fully-contiguous if they're close to fully-contiguous islands
                if (CreepingBordersCls.Settings.ClaimIslandsWithinDistance && CreepingBordersCls.Settings.ClaimIslandsDistanceKM > 0)
                {
                    float maxDistance = CreepingBordersCls.Settings.ClaimIslandsDistanceKM;

                    if (CreepingBordersCls.Settings.EnableDebugLogging)
                    {
                        CreepingBordersCls.mod.Logger.Log($"[Contiguity] Distance-based island bridge pass starting. Max distance: {maxDistance} km");
                    }

                    // Get all islands (including extended distance ones) that might be bridgeable
                    var candidateIslands = new List<TIRegionState>();
                    foreach (TIRegionState region in nation.regions)
                    {
                        if (region != null && islandLookup[region] && 
                            (currentContiguity.ExtendedDistanceRegions.Contains(region) || !currentContiguity.AllContiguousRegions.Contains(region)))
                        {
                            candidateIslands.Add(region);
                        }
                    }

                    if (CreepingBordersCls.Settings.EnableDebugLogging)
                    {
                        CreepingBordersCls.mod.Logger.Log($"[Contiguity] Found {candidateIslands.Count} candidate islands for distance-based bridging (including extended distance)");
                    }

                    // For each candidate island, check if it's within distance of any island in contiguity
                    foreach (TIRegionState candidateIsland in candidateIslands)
                    {
                        float minDistance = float.MaxValue;
                        TIRegionState closestContiguousIsland = null;

                        // Check distance to all FULLY contiguous islands
                        foreach (TIRegionState contiguousRegion in currentContiguity.FullyContiguousRegions)
                        {
                            if (contiguousRegion == null || !islandLookup[contiguousRegion])
                                continue;

                            // Use cached distance to avoid redundant calculations
                            var normalizedKey = candidateIsland.GetHashCode() < contiguousRegion.GetHashCode()
                                ? (candidateIsland, contiguousRegion)
                                : (contiguousRegion, candidateIsland);

                            float distance;
                            if (!distanceCache.TryGetValue(normalizedKey, out distance))
                            {
                                distance = TIRegionState.DistanceBetweenTwoCoordinates_km(
                                    candidateIsland.latitude, candidateIsland.longitude,
                                    contiguousRegion.latitude, contiguousRegion.longitude,
                                    candidateIsland.ref_spaceBody.meanRadius_km);
                                distanceCache[normalizedKey] = distance;
                            }

                            if (distance < minDistance)
                            {
                                minDistance = distance;
                                closestContiguousIsland = contiguousRegion;

                                // Early exit if we found something within range
                                if (distance <= maxDistance)
                                    break;
                            }
                        }

                        // If within distance range of a fully contiguous island, upgrade or add to contiguity
                        if (closestContiguousIsland != null && minDistance <= maxDistance)
                    {
                        // If it was in extended distance, move it to fully contiguous
                        if (currentContiguity.ExtendedDistanceRegions.Contains(candidateIsland))
                        {
                            currentContiguity.ExtendedDistanceRegions.Remove(candidateIsland);
                            currentContiguity.FullyContiguousRegions.Add(candidateIsland);
                            foundNewRegions = true;

                            CreepingBordersCls.mod.Logger.Log(
                                $"[Contiguity] {candidateIsland.displayName} ({nation.displayName}): " +
                                $"Island bridge upgrade from extended to fully contiguous - {minDistance:F2} km from {closestContiguousIsland.displayName}");
                        }
                        // If it wasn't in contiguity at all, add it
                        else if (!currentContiguity.AllContiguousRegions.Contains(candidateIsland))
                        {
                            currentContiguity.FullyContiguousRegions.Add(candidateIsland);
                            currentContiguity.AllContiguousRegions.Add(candidateIsland);
                            foundNewRegions = true;

                            CreepingBordersCls.mod.Logger.Log(
                                $"[Contiguity] {candidateIsland.displayName} ({nation.displayName}): " +
                                $"Island bridge connection - {minDistance:F2} km from {closestContiguousIsland.displayName}");
                        }
                    }
                }
                }
            }

            if (CreepingBordersCls.Settings.EnableDebugLogging)
            {
                CreepingBordersCls.mod.Logger.Log($"[Contiguity] Bridge island resolution completed in {iterationCount} iterations for {nation.displayName}. Final contiguous count: {currentContiguity.FullyContiguousRegions.Count}");
            }
        }
    }

    /// <summary>
    /// Extension methods for TIRegionState to determine landmass characteristics
    /// </summary>
    public static class TIRegionStateExtensions
    {
        private const int ContinentSize = 5;

        // Cache for landmass type results to avoid expensive BFS recalculation
        private static readonly Dictionary<TIRegionState, LandmassType> landmassTypeCache = 
            new Dictionary<TIRegionState, LandmassType>();

        // Cache for island distance lists: (island, nation) -> (fully contiguous list, partially contiguous list)
        private static readonly Dictionary<(TIRegionState island, TINationState nation), (List<TIRegionState> fully, List<TIRegionState> partially)> islandDistanceCache =
            new Dictionary<(TIRegionState, TINationState), (List<TIRegionState>, List<TIRegionState>)>();

        /// <summary>
        /// Clears the landmass type cache (call after game state changes significantly)
        /// </summary>
        public static void ClearLandmassTypeCache()
        {
            landmassTypeCache.Clear();
        }

        /// <summary>
        /// Clears the island distance cache (call after claims or borders change)
        /// </summary>
        public static void ClearIslandDistanceCache()
        {
            islandDistanceCache.Clear();
        }

        /// <summary>
        /// Clears all caches (call after major game state changes)
        /// </summary>
        public static void ClearAllCaches()
        {
            TINationStateExtensions.ClearDistanceCache();
            TINationStateExtensions.ClearCoastalRegionCache();
            ClearLandmassTypeCache();
            ClearIslandDistanceCache();
        }

        /// <summary>
        /// Builds and returns cached lists of islands within normal and extended distance ranges for a given island.
        /// This method performs the actual distance calculations once per island-nation combination.
        /// </summary>
        private static (List<TIRegionState> fullyContiguous, List<TIRegionState> partiallyContiguous) BuildIslandDistanceLists(
            TIRegionState island, TINationState nation, float maxDistance)
        {
            var fullyContiguousList = new List<TIRegionState>();
            var partiallyContiguousList = new List<TIRegionState>();

            if (island == null || nation == null || maxDistance <= 0)
                return (fullyContiguousList, partiallyContiguousList);

            // Get the capital's true contiguous regions to check distances from
            var trueContiguousFromCapital = nation.GetTrueContiguousRegions();
            if (trueContiguousFromCapital.Count == 0)
                return (fullyContiguousList, partiallyContiguousList);

            float extendedMaxDistance = maxDistance * 2f; // 200% threshold

            // Check all other regions in nation
            if (nation.regions != null)
            {
                foreach (TIRegionState otherRegion in nation.regions)
                {
                    if (otherRegion == null || otherRegion == island)
                        continue;

                    // Only cache other islands
                    if (otherRegion.GetLandmassType() != LandmassType.Island)
                        continue;

                    // Find closest distance from this island to any contiguous region
                    float minDistance = float.MaxValue;
                    foreach (TIRegionState contiguousRegion in trueContiguousFromCapital)
                    {
                        if (contiguousRegion == null)
                            continue;

                        float distance = TIRegionState.DistanceBetweenTwoCoordinates_km(
                            otherRegion.latitude, otherRegion.longitude,
                            contiguousRegion.latitude, contiguousRegion.longitude,
                            otherRegion.ref_spaceBody.meanRadius_km);

                        if (distance < minDistance)
                            minDistance = distance;
                    }

                    // Classify based on distance
                    if (minDistance <= maxDistance)
                    {
                        fullyContiguousList.Add(otherRegion);
                    }
                    else if (minDistance <= extendedMaxDistance)
                    {
                        partiallyContiguousList.Add(otherRegion);
                    }
                    // Else: beyond extended range, not added to either list
                }
            }

            if (CreepingBordersCls.Settings.EnableDebugLogging)
            {
                CreepingBordersCls.mod.Logger.Log($"[Island Cache] Built cache for {island.displayName} ({nation.displayName}): " +
                    $"{fullyContiguousList.Count} fully contiguous, {partiallyContiguousList.Count} partially contiguous islands");
            }

            return (fullyContiguousList, partiallyContiguousList);
        }

        /// <summary>
        /// Gets or builds the cached distance lists for islands.
        /// Uses lazy loading: cache is built on first access and reused thereafter.
        /// </summary>
        private static (List<TIRegionState> fullyContiguous, List<TIRegionState> partiallyContiguous) GetOrBuildIslandDistanceCache(
            TIRegionState island, TINationState nation, float maxDistance)
        {
            if (island == null || nation == null || maxDistance <= 0)
                return (new List<TIRegionState>(), new List<TIRegionState>());

            var cacheKey = (island, nation);

            // Check if already cached
            if (islandDistanceCache.TryGetValue(cacheKey, out var cachedLists))
            {
                if (CreepingBordersCls.Settings.EnableDebugLogging)
                {
                    CreepingBordersCls.mod.Logger.Log($"[Island Cache] Cache hit for {island.displayName} ({nation.displayName})");
                }
                return cachedLists;
            }

            // Not cached, build and cache it
            var newLists = BuildIslandDistanceLists(island, nation, maxDistance);
            islandDistanceCache[cacheKey] = newLists;

            if (CreepingBordersCls.Settings.EnableDebugLogging)
            {
                CreepingBordersCls.mod.Logger.Log($"[Island Cache] Cache miss for {island.displayName} ({nation.displayName}) - built new cache entry");
            }

            return newLists;
        }

        /// <summary>
        /// Gets the list of fully contiguous islands (within normal distance range).
        /// Results are cached using lazy loading.
        /// </summary>
        public static List<TIRegionState> GetFullyContiguousIslands(this TIRegionState island, TINationState nation, float maxDistance)
        {
            if (island == null || island.GetLandmassType() != LandmassType.Island)
                return new List<TIRegionState>();

            var (fullyContiguous, _) = GetOrBuildIslandDistanceCache(island, nation, maxDistance);
            return fullyContiguous;
        }

        /// <summary>
        /// Gets the list of partially contiguous islands (within extended distance range 100-200%).
        /// Results are cached using lazy loading.
        /// </summary>
        public static List<TIRegionState> GetPartiallyContiguousIslands(this TIRegionState island, TINationState nation, float maxDistance)
        {
            if (island == null || island.GetLandmassType() != LandmassType.Island)
                return new List<TIRegionState>();

            var (_, partiallyContiguous) = GetOrBuildIslandDistanceCache(island, nation, maxDistance);
            return partiallyContiguous;
        }

        /// <summary>
        /// Determines if this region is part of an island or continent based on contiguous region count
        /// Results are cached to avoid expensive BFS recalculation
        /// </summary>
        public static LandmassType GetLandmassType(this TIRegionState region)
        {
            if (region == null)
                return LandmassType.Island;

            // Check cache first
            if (landmassTypeCache.TryGetValue(region, out LandmassType cachedType))
                return cachedType;

            HashSet<TIRegionState> visited = new HashSet<TIRegionState>();
            Queue<TIRegionState> queue = new Queue<TIRegionState>();
            queue.Enqueue(region);
            visited.Add(region);

            // Iterative BFS with early exit - more efficient than recursion for this use case
            while (queue.Count > 0 && visited.Count < ContinentSize)
            {
                TIRegionState current = queue.Dequeue();

                // Only follow full adjacencies
                foreach (TIRegionState neighbor in current.Neighbors)
                {
                    if (!visited.Contains(neighbor) && neighbor.IsAdjacent(current, true))
                    {
                        visited.Add(neighbor);
                        queue.Enqueue(neighbor);

                        // Early exit if continent threshold reached
                        if (visited.Count >= ContinentSize)
                        {
                            landmassTypeCache[region] = LandmassType.Continent;
                            return LandmassType.Continent;
                        }
                    }
                }
            }

            LandmassType result = visited.Count < ContinentSize ? LandmassType.Island : LandmassType.Continent;
            landmassTypeCache[region] = result;
            return result;
        }

        /// <summary>
        /// Internal result type for discontiguity analysis
        /// </summary>
        private class DiscontiguityInfo
        {
            public bool IsFullyDiscontiguous { get; set; }
            public bool IsPartiallyDiscontiguous { get; set; }
        }

        /// <summary>
        /// Calculates discontiguity info for a region (caches result to avoid redundant calculations)
        /// </summary>
        private static DiscontiguityInfo GetDiscontiguityInfo(TIRegionState region)
        {
            if (region == null || region.nation == null)
                return new DiscontiguityInfo { IsFullyDiscontiguous = false, IsPartiallyDiscontiguous = false };

            TINationState nation = region.nation;

            // Get the contiguous regions with extended distance tracking
            var contiguousInfo = TINationStateExtensions.GetTrueContiguousRegionsWithExtended(nation);
            var trueContiguousRegions = contiguousInfo.FullyContiguousRegions;
            var extendedRegions = contiguousInfo.ExtendedDistanceRegions;

            // If region is in fully contiguous set, both are false
            if (trueContiguousRegions.Contains(region))
            {
                if (CreepingBordersCls.Settings.EnableDebugLogging)
                {
                    CreepingBordersCls.mod.Logger.Log($"[Contiguity] {region.displayName} ({nation.displayName}): Contiguous (part of main landmass)");
                }
                return new DiscontiguityInfo { IsFullyDiscontiguous = false, IsPartiallyDiscontiguous = false };
            }

            // If region is in extended distance set, treat as partially discontiguous
            if (extendedRegions.Contains(region))
            {
                if (CreepingBordersCls.Settings.EnableDebugLogging)
                {
                    CreepingBordersCls.mod.Logger.Log($"[Contiguity] {region.displayName} ({nation.displayName}): PARTIALLY DISCONTIGUOUS - in extended distance island range");
                }
                return new DiscontiguityInfo { IsFullyDiscontiguous = false, IsPartiallyDiscontiguous = true };
            }

            // If region is discontiguous, check if it's reachable through allies
            var discontiguousRegions = new HashSet<TIRegionState>();
            foreach (TIRegionState r in nation.regions)
            {
                if (r != null && !trueContiguousRegions.Contains(r) && !extendedRegions.Contains(r))
                    discontiguousRegions.Add(r);
            }

            // If no discontiguous regions exist, return false for both
            if (discontiguousRegions.Count == 0)
                return new DiscontiguityInfo { IsFullyDiscontiguous = false, IsPartiallyDiscontiguous = false };

            // Check if this region is reachable through allies
            var allyReachableRegions = GetAllyReachableDiscontiguousRegions(nation, discontiguousRegions);
            bool isAllyReachable = allyReachableRegions.Contains(region);

            DiscontiguityInfo result = new DiscontiguityInfo 
            { 
                IsFullyDiscontiguous = !isAllyReachable,
                IsPartiallyDiscontiguous = isAllyReachable
            };

            // Log discontiguity detection
            if (CreepingBordersCls.Settings.EnableDebugLogging)
            {
                if (result.IsFullyDiscontiguous)
                {
                    CreepingBordersCls.mod.Logger.Log($"[Contiguity] {region.displayName} ({nation.displayName}): FULLY DISCONTIGUOUS - not reachable through allied territory");
                }
                else if (result.IsPartiallyDiscontiguous)
                {
                    CreepingBordersCls.mod.Logger.Log($"[Contiguity] {region.displayName} ({nation.displayName}): PARTIALLY DISCONTIGUOUS - reachable through allied territory");
                }
            }

            return result;
        }

        /// <summary>
        /// Determines if this region is fully discontiguous (not reachable even through allied territory)
        /// Only meaningful when the owning nation has discontiguous regions
        /// </summary>
        public static bool IsFullyDiscontiguous(this TIRegionState region)
        {
            if (region == null)
                return false;

            bool result = GetDiscontiguityInfo(region).IsFullyDiscontiguous;

            if (CreepingBordersCls.Settings.EnableDebugLogging && result)
            {
                CreepingBordersCls.mod.Logger.Log($"[Contiguity] IsFullyDiscontiguous check: {region.displayName} = {result}");
            }

            return result;
        }

        /// <summary>
        /// Determines if this region is partially discontiguous (discontiguous but reachable through allied territory)
        /// Only meaningful when the owning nation has discontiguous regions
        /// </summary>
        public static bool IsPartiallyDiscontiguous(this TIRegionState region)
        {
            if (region == null)
                return false;

            bool result = GetDiscontiguityInfo(region).IsPartiallyDiscontiguous;

            if (CreepingBordersCls.Settings.EnableDebugLogging && result)
            {
                CreepingBordersCls.mod.Logger.Log($"[Contiguity] IsPartiallyDiscontiguous check: {region.displayName} = {result}");
            }

            return result;
        }

        /// <summary>
        /// Gets the contiguity status of this region as a human-readable string
        /// </summary>
        public static string GetContiguityStatus(this TIRegionState region)
        {
            if (region == null || region.nation == null)
                return Loc.T("UI.Nation.Contiguity.Unknown");

            if (region.IsFullyDiscontiguous())
                return Loc.T("UI.Nation.Contiguity.FullyDiscontiguous");

            if (region.IsPartiallyDiscontiguous())
                return Loc.T("UI.Nation.Contiguity.PartiallyDiscontiguous");

            return Loc.T("UI.Nation.Contiguity.Contiguous");
        }

        /// <summary>
        /// Helper method to format region and nation info for consistent logging output
        /// </summary>
        private static string FormatRegionNationInfo(TIRegionState region)
        {
            if (region == null)
                return "null";

            if (region.nation == null)
                return $"{region.displayName} (unowned)";

            return $"{region.displayName} ({region.nation.displayName})";
        }

        /// <summary>
        /// Helper method to find which discontiguous regions can be reached through allied territory
        /// </summary>
        private static HashSet<TIRegionState> GetAllyReachableDiscontiguousRegions(TINationState nation, HashSet<TIRegionState> discontiguousRegions)
        {
            HashSet<TIRegionState> reachableThroughAllies = new HashSet<TIRegionState>();

            if (nation == null || nation.allies == null || nation.allies.Count == 0)
            {
                if (CreepingBordersCls.Settings.EnableDebugLogging && discontiguousRegions.Count > 0)
                {
                    CreepingBordersCls.mod.Logger.Log($"[Contiguity] {nation.displayName}: No allies to bridge discontiguous regions. Discontiguous count: {discontiguousRegions.Count}");
                }
                return reachableThroughAllies;
            }

            if (discontiguousRegions == null || discontiguousRegions.Count == 0)
            {
                return reachableThroughAllies;
            }

            // Build a set of regions we can traverse through (own + allied)
            HashSet<TIRegionState> traversableRegions = new HashSet<TIRegionState>(nation.regions.Where(r => r != null));

            // Add all allied regions
            int allyRegionCount = 0;
            foreach (TINationState ally in nation.allies)
            {
                if (ally?.regions != null)
                {
                    foreach (TIRegionState allyRegion in ally.regions)
                    {
                        if (allyRegion != null)
                        {
                            traversableRegions.Add(allyRegion);
                            allyRegionCount++;
                        }
                    }
                }
            }

            if (CreepingBordersCls.Settings.EnableDebugLogging)
            {
                CreepingBordersCls.mod.Logger.Log($"[Contiguity] {nation.displayName}: Checking ally reachability. Discontiguous regions: {discontiguousRegions.Count}, Traversable regions: {traversableRegions.Count} (own: {nation.regions.Count}, allied: {allyRegionCount})");
            }

            // BFS from capital, allowing traversal through own and allied regions
            Queue<TIRegionState> queue = new Queue<TIRegionState>();
            HashSet<TIRegionState> visited = new HashSet<TIRegionState>();

            queue.Enqueue(nation.capital);
            visited.Add(nation.capital);

            while (queue.Count > 0)
            {
                TIRegionState current = queue.Dequeue();

                // Check each neighbor
                foreach (TIRegionState neighbor in current.Neighbors)
                {
                    if (neighbor == null || visited.Contains(neighbor))
                        continue;

                    // Check adjacency (peaceful traversal)
                    if (!neighbor.IsAdjacent(current, false))
                        continue;

                    // Can traverse if it's in our traversable set (own or allied)
                    if (!traversableRegions.Contains(neighbor))
                        continue;

                    visited.Add(neighbor);
                    queue.Enqueue(neighbor);

                    // If this neighbor is one of our discontiguous regions, it's reachable through allies
                    if (discontiguousRegions.Contains(neighbor))
                    {
                        reachableThroughAllies.Add(neighbor);
                        if (CreepingBordersCls.Settings.EnableDebugLogging)
                        {
                            CreepingBordersCls.mod.Logger.Log($"[Contiguity]   └─ {neighbor.displayName} is ally-reachable via {current.displayName}");
                        }
                    }
                }
            }

            if (CreepingBordersCls.Settings.EnableDebugLogging && reachableThroughAllies.Count > 0)
            {
                CreepingBordersCls.mod.Logger.Log($"[Contiguity] {nation.displayName}: Found {reachableThroughAllies.Count} ally-reachable discontiguous regions");
            }

            return reachableThroughAllies;
        }
    }

    // ====================================================================
    // PHASE 3: HARMONY PATCHES - OCCUPATION SYSTEM
    // ====================================================================

    [HarmonyPatch(typeof(TIRegionState), "CheckAndTriggerOccupation")]
    public static class Patch_CheckAndTriggerOccupation
    {
        /// <summary>
        /// Prefix patch to allow instant annexation of annexable regions instead of occupation
        /// </summary>
        static bool Prefix(TIRegionState __instance)
        {
            if (!CreepingBordersCls.enabled || !CreepingBordersCls.Settings.EnableInstantAnnexations)
            {
                return true; // Use vanilla logic
            }

            // Check if region is being occupied
            if (__instance.occupations == null || __instance.occupations.Count == 0)
            {
                return true; // No occupation, use vanilla
            }

            // Get the occupying nation (first in dictionary)
            var occupyingNation = __instance.occupations.Keys.FirstOrDefault();
            if (occupyingNation == null)
            {
                return true; // Use vanilla
            }

            // Check if this region is in the occupying nation's annexable regions
            var annexableRegions = occupyingNation.AnnexableRegions();
            if (annexableRegions.Contains(__instance))
            {
                // Instant transfer: annexable regions are automatically transferred
                occupyingNation.TransferRegionsControlTo(new List<TIRegionState> { __instance }, occupyingNation, false, true, false, false, false);

                // Clear occupation
                __instance.occupations.Clear();

                // Trigger event
                GameControl.eventManager.TriggerEvent(new OccupationStatusChange(__instance), null, 
                    new object[] { __instance, occupyingNation }.Where(x => x != null).ToArray());

                return false; // Skip vanilla
            }

            return true; // Use vanilla occupation process
        }
    }

    // ====================================================================
    // PHASE 4: HARMONY PATCHES - COHESION SYSTEM
    // ====================================================================

    [HarmonyPatch(typeof(TINationState), "cohesionRestState", MethodType.Getter)]
    public static class Patch_CohesionRestState_BaseValue
    {
        /// <summary>
        /// Prefix patch to override cohesion base value with configurable setting
        /// </summary>
        static bool Prefix(out float __result, TINationState __instance)
        {
            __result = 0f;

            if (!CreepingBordersCls.enabled)
            {
                return true; // Use vanilla
            }

            if (!__instance.extant)
            {
                __result = __instance.cohesion;
                return false; // Skip vanilla
            }

            // Use configurable base value instead of hardcoded 16f
            float baseValue = CreepingBordersCls.Settings.CohesionRestStateBaseValue;

            // Gather impacts, applying settings overrides
            float inequalityImpact = __instance.inequalityImpactOnCohesion;
            float gdpImpact = __instance.perCapitaGDPImpactOnCohesion;

            // Apply NoPopulationMalus setting
            float populationImpact = CreepingBordersCls.Settings.NoPopulationMalus ? 0f : __instance.populationImpactOnCohesion;

            // Apply NoDistanceCohesionMalus setting
            float regionsImpact = CreepingBordersCls.Settings.NoDistanceCohesionMalus ? 0f : __instance.regionsImpactOnCohesion;

            float hostileClaimsImpact = __instance.hostileClaimsImpactOnCohesion;
            float rivalsImpact = __instance.rivalsImpactOnCohesion;
            float warsImpact = __instance.warsImpactOnCohesion;
            float eliteDivideImpact = __instance.publicEliteDivideImpactOnCohesion;
            float publicOpinionImpact = __instance.publicOpinionImpactOnCohesion;
            float autocracyImpact = __instance.autocracyImpactOnCohesion;
            float anocracyImpact = __instance.anocracyImpactOnCohesion;

            // Sum all impacts
            float total = baseValue + inequalityImpact + gdpImpact + populationImpact + regionsImpact +
                         hostileClaimsImpact + rivalsImpact + warsImpact + eliteDivideImpact +
                         publicOpinionImpact + autocracyImpact + anocracyImpact;

            // Apply democracy impact
            total += __instance.DemocracyImpactOnCohesion(total);

            // Clamp to valid range
            __result = Mathf.Clamp(total, 0f, 10f);

            // Debug logging for Phase 4 calculations
            if (CreepingBordersCls.Settings.EnableDebugLogging)
            {
                StringBuilder logBuilder = new StringBuilder();
                logBuilder.AppendLine($"[Phase 4] Cohesion Calculation for {__instance.displayName}");
                logBuilder.AppendLine($"  Base Value: {baseValue:F2}");
                if (inequalityImpact != 0f) logBuilder.AppendLine($"  Inequality Impact: {inequalityImpact:F2}");
                if (gdpImpact != 0f) logBuilder.AppendLine($"  GDP Impact: {gdpImpact:F2}");
                if (populationImpact != 0f) logBuilder.AppendLine($"  Population Impact: {populationImpact:F2}");
                if (regionsImpact != 0f) logBuilder.AppendLine($"  Regions Impact: {regionsImpact:F2}");
                if (hostileClaimsImpact != 0f) logBuilder.AppendLine($"  Hostile Claims Impact: {hostileClaimsImpact:F2}");
                if (rivalsImpact != 0f) logBuilder.AppendLine($"  Rivals Impact: {rivalsImpact:F2}");
                if (warsImpact != 0f) logBuilder.AppendLine($"  Wars Impact: {warsImpact:F2}");
                if (eliteDivideImpact != 0f) logBuilder.AppendLine($"  Elite Divide Impact: {eliteDivideImpact:F2}");
                if (publicOpinionImpact != 0f) logBuilder.AppendLine($"  Public Opinion Impact: {publicOpinionImpact:F2}");
                if (autocracyImpact != 0f) logBuilder.AppendLine($"  Autocracy Impact: {autocracyImpact:F2}");
                if (anocracyImpact != 0f) logBuilder.AppendLine($"  Anocracy Impact: {anocracyImpact:F2}");
                float democracyImpact = __instance.DemocracyImpactOnCohesion(total - __instance.DemocracyImpactOnCohesion(total));
                if (democracyImpact != 0f) logBuilder.AppendLine($"  Democracy Impact: {democracyImpact:F2}");
                logBuilder.Append($"  Total (before clamp): {total:F2} => Final (clamped): {__result:F2}");
                CreepingBordersCls.mod.Logger.Log(logBuilder.ToString());
            }

            return false; // Skip vanilla
        }
    }

    [HarmonyPatch(typeof(TINationState), "CohesionRestStateDetail", MethodType.Getter)]
    public static class Patch_CohesionDisplay
    {
        /// <summary>
        /// Prefix patch to modify cohesion detail display with discontiguity info
        /// </summary>
        static bool Prefix(out string __result, TINationState __instance)
        {
            __result = "";

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(Loc.T("UI.Nation.CohesionReststateBreakdown"));

            // Use configurable base value
            float baseValue = CreepingBordersCls.Settings.CohesionRestStateBaseValue;
            stringBuilder.AppendLine(Loc.T("UI.Nation.BaseValue", new object[] { baseValue.ToString("N2") }));

            // Add all cohesion components (unchanged from vanilla except base value)
            if (__instance.inequalityImpactOnCohesion != 0f)
            {
                stringBuilder.AppendLine(Loc.T("UI.Nation.FromInequality", new object[] 
                { 
                    ColorCohesionRestStateValue(TIUtilities.ForceValueSign(__instance.inequalityImpactOnCohesion, 
                        TIUtilities.FormatBigOrSmallNumber(__instance.inequalityImpactOnCohesion, 1, 7, 0, false, false), 
                        false, false, NationInfoController.WhatIsGood.upIsGood), __instance.inequalityImpactOnCohesion) 
                }));
            }

            if (__instance.perCapitaGDPImpactOnCohesion != 0f)
            {
                stringBuilder.AppendLine(Loc.T("UI.Nation.FromLowPCGDP", new object[] 
                { 
                    ColorCohesionRestStateValue(TIUtilities.ForceValueSign(__instance.perCapitaGDPImpactOnCohesion, 
                        TIUtilities.FormatBigOrSmallNumber(__instance.perCapitaGDPImpactOnCohesion, 1, 7, 0, false, false), 
                        false, false, NationInfoController.WhatIsGood.upIsGood), __instance.perCapitaGDPImpactOnCohesion) 
                }));
            }

            if (__instance.populationImpactOnCohesion != 0f && !CreepingBordersCls.Settings.NoPopulationMalus)
            {
                stringBuilder.AppendLine(Loc.T("UI.Nation.FromPopulation", new object[] 
                { 
                    ColorCohesionRestStateValue(TIUtilities.ForceValueSign(__instance.populationImpactOnCohesion, 
                        TIUtilities.FormatBigOrSmallNumber(__instance.populationImpactOnCohesion, 1, 7, 0, false, false), 
                        false, false, NationInfoController.WhatIsGood.upIsGood), __instance.populationImpactOnCohesion) 
                }));
            }

            if (__instance.regionsImpactOnCohesion != 0f && !CreepingBordersCls.Settings.NoDistanceCohesionMalus)
            {
                stringBuilder.AppendLine(Loc.T("UI.Nation.FromRegions", new object[] 
                { 
                    ColorCohesionRestStateValue(TIUtilities.ForceValueSign(__instance.regionsImpactOnCohesion, 
                        TIUtilities.FormatBigOrSmallNumber(__instance.regionsImpactOnCohesion, 1, 7, 0, false, false), 
                        false, false, NationInfoController.WhatIsGood.upIsGood), __instance.regionsImpactOnCohesion) 
                }));
            }

            if (__instance.hostileClaimsImpactOnCohesion != 0f)
            {
                stringBuilder.AppendLine(Loc.T("UI.Nation.FromHostileClaims_Cohesion", new object[]
                {
                    ColorCohesionRestStateValue(TIUtilities.ForceValueSign(__instance.hostileClaimsImpactOnCohesion, false, false, ""), __instance.hostileClaimsImpactOnCohesion),
                    TIUtilities.FormatBigOrSmallNumber(__instance.hostileClaimsImpactOnCohesion, 1, 7, 0, false, false)
                }));
            }

            if (__instance.rivalsImpactOnCohesion != 0f)
            {
                stringBuilder.AppendLine(Loc.T("UI.Nation.FromRivals", new object[] 
                { 
                    ColorCohesionRestStateValue(TIUtilities.ForceValueSign(__instance.rivalsImpactOnCohesion, 
                        TIUtilities.FormatBigOrSmallNumber(__instance.rivalsImpactOnCohesion, 1, 7, 0, false, false), 
                        false, false, NationInfoController.WhatIsGood.upIsGood), __instance.rivalsImpactOnCohesion) 
                }));
            }

            if (__instance.warsImpactOnCohesion != 0f)
            {
                stringBuilder.AppendLine(Loc.T("UI.Nation.FromWars", new object[] 
                { 
                    ColorCohesionRestStateValue(TIUtilities.ForceValueSign(__instance.warsImpactOnCohesion, 
                        TIUtilities.FormatBigOrSmallNumber(__instance.warsImpactOnCohesion, 1, 7, 0, false, false), 
                        false, false, NationInfoController.WhatIsGood.upIsGood), __instance.warsImpactOnCohesion) 
                }));
            }

            if (__instance.publicEliteDivideImpactOnCohesion != 0f)
            {
                stringBuilder.AppendLine(Loc.T("UI.Nation.FromIdeology", new object[] 
                { 
                    ColorCohesionRestStateValue(TIUtilities.ForceValueSign(__instance.publicEliteDivideImpactOnCohesion, 
                        TIUtilities.FormatBigOrSmallNumber(__instance.publicEliteDivideImpactOnCohesion, 1, 7, 0, false, false), 
                        false, false, NationInfoController.WhatIsGood.upIsGood), __instance.publicEliteDivideImpactOnCohesion) 
                }));
            }

            if (__instance.publicOpinionImpactOnCohesion != 0f)
            {
                stringBuilder.AppendLine(Loc.T("UI.Nation.FromInternalDifferences", new object[] 
                { 
                    ColorCohesionRestStateValue(TIUtilities.ForceValueSign(__instance.publicOpinionImpactOnCohesion, 
                        TIUtilities.FormatBigOrSmallNumber(__instance.publicOpinionImpactOnCohesion, 1, 7, 0, false, false), 
                        false, false, NationInfoController.WhatIsGood.upIsGood), __instance.publicOpinionImpactOnCohesion) 
                }));
            }

            if (__instance.autocracyImpactOnCohesion != 0f)
            {
                stringBuilder.AppendLine(Loc.T("UI.Nation.FromAutocracy", new object[] 
                { 
                    ColorCohesionRestStateValue(TIUtilities.ForceValueSign(__instance.autocracyImpactOnCohesion, 
                        TIUtilities.FormatBigOrSmallNumber(__instance.autocracyImpactOnCohesion, 1, 7, 0, false, false), 
                        false, false, NationInfoController.WhatIsGood.upIsGood), __instance.autocracyImpactOnCohesion) 
                }));
            }

            if (__instance.anocracyImpactOnCohesion != 0f)
            {
                stringBuilder.AppendLine(Loc.T("UI.Nation.FromAnocracy", new object[] 
                { 
                    ColorCohesionRestStateValue(TIUtilities.ForceValueSign(__instance.anocracyImpactOnCohesion, 
                        TIUtilities.FormatBigOrSmallNumber(__instance.anocracyImpactOnCohesion, 1, 7, 0, false, false), 
                        false, false, NationInfoController.WhatIsGood.upIsGood), __instance.anocracyImpactOnCohesion) 
                }));
            }

            // Calculate total with settings overrides applied
            float baseVal = CreepingBordersCls.Settings.CohesionRestStateBaseValue;
            float populationImpactForTotal = CreepingBordersCls.Settings.NoPopulationMalus ? 0f : __instance.populationImpactOnCohesion;
            float regionsImpactForTotal = CreepingBordersCls.Settings.NoDistanceCohesionMalus ? 0f : __instance.regionsImpactOnCohesion;
            float discontiguityImpactForTotal = CreepingBordersCls.Settings.EnableDiscontiguityMalus ? GetDiscontiguityImpactOnCohesion(__instance) : 0f;

            float total = baseVal + __instance.inequalityImpactOnCohesion + __instance.perCapitaGDPImpactOnCohesion +
                         populationImpactForTotal + regionsImpactForTotal +
                         __instance.hostileClaimsImpactOnCohesion + __instance.rivalsImpactOnCohesion +
                         __instance.warsImpactOnCohesion + __instance.publicEliteDivideImpactOnCohesion +
                         __instance.publicOpinionImpactOnCohesion + __instance.autocracyImpactOnCohesion +
                         __instance.anocracyImpactOnCohesion + discontiguityImpactForTotal;

            float democracyImpact = __instance.DemocracyImpactOnCohesion(total);
            if (democracyImpact != 0f)
            {
                stringBuilder.AppendLine(Loc.T("UI.Nation.FromDemocracy", new object[]
                {
                    ColorCohesionRestStateValue(TIUtilities.ForceValueSign(democracyImpact, false, false, ""), democracyImpact),
                    TIUtilities.FormatBigOrSmallNumber(democracyImpact, 1, 7, 0, false, false)
                }));
            }

            // Add discontiguity malus if enabled (insert before final line)
            if (CreepingBordersCls.Settings.EnableDiscontiguityMalus)
            {
                if (discontiguityImpactForTotal != 0f)
                {
                    if (CreepingBordersCls.Settings.EnableDebugLogging)
                    {
                        CreepingBordersCls.mod.Logger.Log($"[Discontiguity] Applied impact: {discontiguityImpactForTotal:N2}");
                    }
                    stringBuilder.AppendLine(Loc.T("UI.Nation.FromDiscontiguity", new object[] 
                    { 
                        ColorCohesionRestStateValue(discontiguityImpactForTotal.ToString("N2"), discontiguityImpactForTotal) 
                    }));
                }
            }

            stringBuilder.AppendLine(Loc.T("UI.Nation.CohesionLimits", new object[] { (total + democracyImpact).ToString("N2") }));

            __result = stringBuilder.ToString();
            return false; // Skip vanilla
        }

        /// <summary>
        /// Helper to append a cohesion component line with consistent formatting
        /// </summary>
        private static void AppendCohesionComponent(StringBuilder sb, string locKey, object[] locParams)
        {
            sb.AppendLine(Loc.T(locKey, locParams));
        }

        /// <summary>
        /// Colors a cohesion value red if negative, green if positive, unmodified if zero
        /// </summary>
        private static string ColorCohesionRestStateValue(string formattedValue, float value)
        {
            if (value < 0f)
            {
                return TIUtilities.RedLine(formattedValue);
            }
            if (value > 0f)
            {
                return TIUtilities.GreenLine(formattedValue);
            }
            return formattedValue;
        }

        /// <summary>
        /// Identifies which discontiguous regions can be reached through allied territory
        /// Allows traversal through allied nations to determine secondary connectivity
        /// </summary>
        public static HashSet<TIRegionState> GetDiscontiguousRegionsReachableThroughAllies(TINationState nation, HashSet<TIRegionState> discontiguousRegions)
        {
            HashSet<TIRegionState> reachableThroughAllies = new HashSet<TIRegionState>();

            if (nation == null || nation.allies == null || nation.allies.Count == 0)
            {
                return reachableThroughAllies; // No allies, no regions reachable through them
            }

            if (discontiguousRegions == null || discontiguousRegions.Count == 0)
            {
                return reachableThroughAllies; // No discontiguous regions to check
            }

            // Build a set of regions we can traverse through (own + allied)
            // Using initializer with LINQ for more efficient collection building
            HashSet<TIRegionState> traversableRegions = new HashSet<TIRegionState>(nation.regions.Where(r => r != null));

            // Add all allied regions
            foreach (TINationState ally in nation.allies)
            {
                if (ally?.regions != null)
                {
                    foreach (TIRegionState allyRegion in ally.regions)
                    {
                        if (allyRegion != null)
                            traversableRegions.Add(allyRegion);
                    }
                }
            }

            // BFS from capital, allowing traversal through own and allied regions
            Queue<TIRegionState> queue = new Queue<TIRegionState>();
            HashSet<TIRegionState> visited = new HashSet<TIRegionState>();

            queue.Enqueue(nation.capital);
            visited.Add(nation.capital);

            while (queue.Count > 0)
            {
                TIRegionState current = queue.Dequeue();

                // Check each neighbor
                foreach (TIRegionState neighbor in current.Neighbors)
                {
                    if (neighbor == null || visited.Contains(neighbor))
                        continue;

                    // Check adjacency (peaceful traversal)
                    if (!neighbor.IsAdjacent(current, false))
                        continue;

                    // Can traverse if it's in our traversable set (own or allied)
                    if (!traversableRegions.Contains(neighbor))
                        continue;

                    visited.Add(neighbor);
                    queue.Enqueue(neighbor);

                    // If this neighbor is one of our discontiguous regions, it's reachable through allies
                    if (discontiguousRegions.Contains(neighbor))
                    {
                        reachableThroughAllies.Add(neighbor);
                    }
                }
            }

            return reachableThroughAllies;
        }

        /// <summary>
        /// Calculates cohesion penalty for non-contiguous territories
        /// Treats regions held by other nations as blockers to contiguity
        /// Halves the penalty for regions reachable through allied territory
        /// </summary>
        private static float GetDiscontiguityImpactOnCohesion(TINationState nation)
        {
            if (nation == null || nation.regions == null || nation.regions.Count <= 1)
                return 0f;

            // Find truly contiguous regions including extended distance islands
            var contiguousInfo = TINationStateExtensions.GetTrueContiguousRegionsWithExtended(nation);
            var trueContiguousRegions = contiguousInfo.FullyContiguousRegions;
            var extendedRegions = contiguousInfo.ExtendedDistanceRegions;

            // Find regions that are not contiguous with the capital
            HashSet<TIRegionState> discontiguousRegions = new HashSet<TIRegionState>();
            float discontiguousPopulation = 0f;

            if (nation.regions != null)
            {
                foreach (TIRegionState region in nation.regions)
                {
                    // Count population of regions not in any contiguous set
                    if (region != null && !trueContiguousRegions.Contains(region) && !extendedRegions.Contains(region))
                    {
                        discontiguousRegions.Add(region);
                        discontiguousPopulation += region.population;
                    }
                }
            }

            // Calculate population penalties for all categories
            // Start with extended islands (get half penalty like ally-reachable)
            float extendedPopulation = 0f;
            foreach (TIRegionState island in extendedRegions)
            {
                if (island != null)
                    extendedPopulation += island.population;
            }

            // Apply penalty based on population of discontiguous regions
            float totalHalfPenaltyPopulation = extendedPopulation; // Extended islands start as half-penalty

            if (discontiguousPopulation > 0f || extendedPopulation > 0f)
            {
                // Check which discontiguous regions can be reached through allied territory
                var allyReachableRegions = GetDiscontiguousRegionsReachableThroughAllies(nation, discontiguousRegions);

                // Split population into categories
                float fullPenaltyPopulation = 0f;      // Not reachable even through allies
                float halfPenaltyPopulation = extendedPopulation;  // Start with extended islands, add ally-reachable

                // For detailed logging
                List<string> fullyDiscontiguousRegions = new List<string>();
                List<string> partiallyDiscontiguousRegions = new List<string>();
                List<string> extendedIslands = new List<string>();

                // Log extended islands
                if (CreepingBordersCls.Settings.EnableDebugLogging && extendedRegions.Count > 0)
                {
                    foreach (TIRegionState island in extendedRegions)
                    {
                        if (island != null)
                            extendedIslands.Add(island.displayName);
                    }
                }

                foreach (TIRegionState region in discontiguousRegions)
                {
                    if (allyReachableRegions.Contains(region))
                    {
                        halfPenaltyPopulation += region.population;
                        if (CreepingBordersCls.Settings.EnableDebugLogging)
                            partiallyDiscontiguousRegions.Add(region.displayName);
                    }
                    else
                    {
                        fullPenaltyPopulation += region.population;
                        if (CreepingBordersCls.Settings.EnableDebugLogging)
                            fullyDiscontiguousRegions.Add(region.displayName);
                    }
                }

                // Calculate weighted penalty
                // Full penalty for unreachable regions, half penalty for ally-reachable regions and extended islands
                float malusPercentage = CreepingBordersCls.Settings.DiscontiguityMalusPercentage / 100f;
                float fullPenalty = -(fullPenaltyPopulation / 1000000f) * malusPercentage;
                float halfPenalty = -(halfPenaltyPopulation / 1000000f) * malusPercentage * 0.5f;  // Halved!

                float totalPenalty = fullPenalty + halfPenalty;
                float clampedPenalty = Mathf.Clamp(totalPenalty, -10f, 0f);

                if (CreepingBordersCls.Settings.EnableDebugLogging)
                {
                    StringBuilder debugLog = new StringBuilder();
                    debugLog.AppendLine($"[Discontiguity] {nation.displayName} Cohesion Impact Calculation:");
                    debugLog.AppendLine($"  Total Discontiguous Population: {discontiguousPopulation:N0}");
                    debugLog.AppendLine($"  Extended Island Population: {extendedPopulation:N0}");

                    if (extendedIslands.Count > 0)
                    {
                        debugLog.AppendLine($"  Extended Distance Islands ({extendedIslands.Count} regions, {extendedPopulation:N0} pop) [Half Penalty]:");
                        foreach (string regionName in extendedIslands)
                        {
                            debugLog.AppendLine($"    - {regionName}");
                        }
                    }

                    if (fullyDiscontiguousRegions.Count > 0)
                    {
                        debugLog.AppendLine($"  Fully Discontiguous ({fullyDiscontiguousRegions.Count} regions, {fullPenaltyPopulation:N0} pop):");
                        foreach (string regionName in fullyDiscontiguousRegions)
                        {
                            debugLog.AppendLine($"    - {regionName}");
                        }
                        debugLog.AppendLine($"    Full Penalty: {fullPenalty:N2}");
                    }

                    if (partiallyDiscontiguousRegions.Count > 0)
                    {
                        debugLog.AppendLine($"  Partially Discontiguous via Allies ({partiallyDiscontiguousRegions.Count} regions, {halfPenaltyPopulation - extendedPopulation:N0} pop) [Half Penalty]:");
                        foreach (string regionName in partiallyDiscontiguousRegions)
                        {
                            debugLog.AppendLine($"    - {regionName}");
                        }
                        debugLog.AppendLine($"    Half Penalty (combined with extended): {halfPenalty:N2}");
                    }

                    debugLog.Append($"  Total Penalty (clamped): {clampedPenalty:N2}");
                    CreepingBordersCls.mod.Logger.Log(debugLog.ToString());
                }

                return clampedPenalty;
            }

            return 0f;
        }
    }

    // ====================================================================
    // HARMONY PATCHES - UTILITY
    // ====================================================================

    [HarmonyPatch(typeof(TINationState), "TransferRegionsControlTo")]
    public static class Patch_TransferRegionsControlTo
    {
        static void Postfix()
        {
            if (!CreepingBordersCls.enabled || !CreepingBordersCls.Settings.NoHostileClaims)
            {
                return;
            }

            // Clear all hostile claims from all nations whenever a region changes owner
            TINationState[] allNations = GameStateManager.AllNations();
            foreach (TINationState nation in allNations)
            {
                if (nation != null && nation.hostileClaims != null)
                {
                    nation.hostileClaims.Clear();
                }
            }
        }
    }

    // ====================================================================
    // HARMONY PATCHES - REGION LIST ITEM UI
    // ====================================================================

    [HarmonyPatch(typeof(RegionListItemController), "UpdateListItem")]
    public static class Patch_RegionListItemController_UpdateListItem
    {
        // Cached field references to avoid reflection overhead on every call
        private static System.Reflection.FieldInfo cachedRegionField;
        private static System.Reflection.FieldInfo cachedBackgroundImageField;

        /// <summary>
        /// Initialize cached field references (called once on first use)
        /// </summary>
        private static void InitializeFieldCache()
        {
            if (cachedRegionField != null)
                return; // Already cached

            var type = typeof(RegionListItemController);
            cachedRegionField = type.GetField("region", 
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            cachedBackgroundImageField = type.GetField("backgroundImage", 
                System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
        }

        /// <summary>
        /// Patch to add discontiguity-based highlighting to region list items
        /// Light orange for fully discontiguous regions, pale yellow for partially discontiguous
        /// </summary>
        static void Postfix(RegionListItemController __instance, RegionListItem_Data data)
        {
            if (!CreepingBordersCls.enabled || data.claim)
                return; // Claims take precedence - don't override

            InitializeFieldCache();

            if (cachedRegionField == null || cachedBackgroundImageField == null)
                return;

            var region = cachedRegionField.GetValue(__instance) as TIRegionState;
            if (region == null)
                return;

            var backgroundImage = cachedBackgroundImageField.GetValue(__instance) as Image;
            if (backgroundImage == null)
                return;

            // Check discontiguity status
            if (region.IsFullyDiscontiguous())
            {
                // Light orange for fully discontiguous regions (RGB: 1.0, 0.65, 0.3, alpha: 0.2)
                backgroundImage.color = new Color(1.0f, 0.65f, 0.3f, 0.2f);
            }
            else if (region.IsPartiallyDiscontiguous())
            {
                // Pale yellow for partially discontiguous regions (RGB: 1.0, 1.0, 0.5, alpha: 0.15)
                backgroundImage.color = new Color(1.0f, 1.0f, 0.5f, 0.15f);
            }
        }
    }

    // ====================================================================
    // HARMONY PATCHES - REGION DATA TOOLTIP
    // ====================================================================

    [HarmonyPatch(typeof(NationInfoController), "BuildRegionDataTooltip")]
    public static class Patch_BuildRegionDataTooltip
    {
        /// <summary>
        /// Postfix patch to add landmass type and contiguity information to region tooltip
        /// </summary>
        static void Postfix(ref string __result, TIRegionState region)
        {
            if (!CreepingBordersCls.enabled || region == null)
                return;

            // Get the landmass type and contiguity status
            LandmassType landmassType = region.GetLandmassType();
            string landmassTypeStr = landmassType == LandmassType.Island ? Loc.T("UI.Nation.Landmass.Island") : Loc.T("UI.Nation.Landmass.Continent");
            string contiguityStatus = region.GetContiguityStatus();

            // Append using StringBuilder for efficiency - avoid string concatenation
            // Use TrimEnd to remove extra newlines before appending
            StringBuilder sb = new StringBuilder(__result.TrimEnd());
            sb.AppendLine().AppendLine();
            sb.AppendLine($"{Loc.T("UI.Region.Tooltip.Landmass")}: {landmassTypeStr}");
            sb.AppendLine($"{Loc.T("UI.Region.Tooltip.Contiguity")}: {contiguityStatus}");

            __result = sb.ToString();
        }
    }
}


