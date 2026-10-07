using HarmonyLib;
using PavonisInteractive.TerraInvicta;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityModManagerNet;
using Poly2Tri;


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
        /// <summary>X: the option claim distance (km). Full gate = X, Partial gate = 3X. 0-2000, 50 km increments.</summary>
        public float ClaimDistanceKm = 300f;
        public bool NoHostileClaims = false;
        public bool NoPopulationMalus = false;
        public float CohesionRestStateBaseValue = 16f;
        public bool EnableDiscontiguityMalus = false;
        public float DiscontiguityMalusPercentage = 5.0f;
        public bool EnableInstantAnnexations = false;
        public bool UnificationUseCurrentCapital = true;
        public bool EnableDebugLogging = false;
        public bool EnableCulturalInertia = true;
        public float CulturalMismatchMax = 2.0f;
        public float UnityAssimilationStrength = 1.0f;
        public float AbsorptionRecognitionRate = 0.5f;

        // --- C13 Cultural Inertia: Unity budgets ---
        public float OwnedDefensiveBudget = 0.50f;
        public float OwnedOffensiveBudget = 0.50f;
        public float UnownedOffensiveBudget = 0.50f;
        public float InfluenceCostPer100M = 1.0f;
        public float NeutralNationWeight = 0.5f;
        public bool UnityDefaultStanceDefensive = true;
        public float IslandRangeKm = 300f;

        // --- C13 Cultural Inertia: claims ---
        public float HostileDemoteThreshold = 0.25f;
        public float HostilePromoteThreshold = 0.30f;
        public float ResearchClaimConversionFloor = 0.50f;
        public float SecessionCultureFloor = 0.50f;

        // --- C13 Cultural Inertia: economy / malus ---
        public float MinorityRuleThreshold = 0.40f;
        public float BeneficialForeignWeight = 0.3f;
        public float DetrimentForeignWeight = 1.3f;
        public float SnapToZero = 0.0005f;

        // --- C13 Cultural Inertia: AI ---
        public float AiInfluenceBuffer = 15f;
        public int AiOutreachCooldownDays = 30;
        public float AiOutreachMinScore = 0.5f;

        public override void Save(UnityModManager.ModEntry modEntry)
        {
            UnityModManager.ModSettings.Save<CreepingBordersSettings>(this, modEntry);
        }
    }

    public class CreepingBordersCls
    {
        public static UnityModManager.ModEntry mod;
        public static CreepingBordersSettings Settings;

        // Shared influence cost for the Set Capital / Legitimise Claim policy options.
        public const float INFLUENCE_COST = 90f;

        /// <summary>
        /// True if the nation's executive faction can afford the influence cost of these policy options.
        /// Mirrors vanilla affordability gating (e.g. federation/unification options disabled without cost).
        /// </summary>
        public static bool CanAffordInfluence(TINationState nation)
        {
            if (nation == null || nation.executiveFaction == null)
            {
                return false;
            }
            return nation.executiveFaction.GetCurrentResourceAmount(FactionResource.Influence) >= INFLUENCE_COST;
        }
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

        internal static bool borderExpansionOnLoadPerformed = false;

        private static void OnUpdate(UnityModManager.ModEntry modEntry, float deltaTime)
        {
            // Run border expansion check once when the game is first loaded
            if (!borderExpansionOnLoadPerformed && GameStateManager.HasGamestates)
            {
                borderExpansionOnLoadPerformed = true;
                ApplyBorderExpansionOnLoad();

                // C1 verification: exercise the distance layer's pure logic on load.
                if (CreepingBordersCls.Settings.EnableDebugLogging)
                {
                    TestDistanceLayer.Run(msg => CreepingBordersCls.mod.Logger.Log(msg));
                }
            }
        }

        private static bool OnToggle(UnityModManager.ModEntry modEntry, bool value)
        {
            CreepingBordersCls.enabled = value;
            return true;
        }

        private static float lastClaimDistanceKm = 300f;

        private static void OnGUI(UnityModManager.ModEntry modEntry)
        {
            var settings = CreepingBordersCls.Settings;
            var emptyOptions = new GUILayoutOption[0];

            GUILayout.Label("Creeping Borders Settings:", emptyOptions);

            // ====================================================================
            // BORDER EXPANSION
            // ====================================================================
            GUILayout.Space(8f);
            GUILayout.Label("<b>Border Expansion</b>", emptyOptions);
            settings.EnableBorderExpansion = GUILayout.Toggle(settings.EnableBorderExpansion, "Enable Border Expansion", emptyOptions);
            GUILayout.Label("Automatically expands nation borders by claiming adjacent unclaimed regions when control of a region changes", emptyOptions);

            GUILayout.Space(4f);
            GUILayout.Label("Claim Distance (X): " + settings.ClaimDistanceKm.ToString("F0") + " km", emptyOptions);
            settings.ClaimDistanceKm = GUILayout.HorizontalSlider(settings.ClaimDistanceKm, 0f, 2000f, emptyOptions);
            // Round to nearest 50 km
            settings.ClaimDistanceKm = Mathf.Round(settings.ClaimDistanceKm / 50f) * 50f;
            if (settings.ClaimDistanceKm < 50f) settings.ClaimDistanceKm = 50f;
            GUILayout.Label("Distance bridging gates: Full contiguity within X km, Partial within 3X km. Distance bridging is disabled at X = 0", emptyOptions);
            if (settings.ClaimDistanceKm != lastClaimDistanceKm)
            {
                lastClaimDistanceKm = settings.ClaimDistanceKm;
                PolygonalRegionConnectivityManager.Invalidate();
            }

            // ====================================================================
            // CLAIM BEHAVIOR
            // ====================================================================
            GUILayout.Space(8f);
            GUILayout.Label("<b>Claim Behavior</b>", emptyOptions);
            settings.NoHostileClaims = GUILayout.Toggle(settings.NoHostileClaims, "No Hostile Claims", emptyOptions);
            GUILayout.Label("Makes all hostile claims friendly", emptyOptions);

            GUILayout.Space(8f);
            settings.EnableInstantAnnexations = GUILayout.Toggle(settings.EnableInstantAnnexations, "Enable Instant Annexations", emptyOptions);
            GUILayout.Label("Automatically annexes annexable regions instantly instead of requiring occupation", emptyOptions);

            GUILayout.Space(8f);
            settings.UnificationUseCurrentCapital = GUILayout.Toggle(settings.UnificationUseCurrentCapital, "Unification Uses Current Capital", emptyOptions);
            GUILayout.Label("Unification requires a claim on the target's CURRENT capital instead of its original capital, so a destroyed or relocated original capital no longer blocks unification", emptyOptions);

            // ====================================================================
            // COHESION SYSTEM
            // ====================================================================
            GUILayout.Space(8f);
            GUILayout.Label("<b>Cohesion System</b>", emptyOptions);

            GUILayout.Label("Cohesion Rest State Base Value: " + settings.CohesionRestStateBaseValue.ToString("F1"), emptyOptions);
            settings.CohesionRestStateBaseValue = GUILayout.HorizontalSlider(settings.CohesionRestStateBaseValue, 5f, 50f, emptyOptions);
            // Round to nearest 0.5
            settings.CohesionRestStateBaseValue = Mathf.Round(settings.CohesionRestStateBaseValue * 2f) / 2f;

            GUILayout.Space(8f);
            settings.NoPopulationMalus = GUILayout.Toggle(settings.NoPopulationMalus, "No Population Malus", emptyOptions);
            GUILayout.Label("Removes the cohesion malus from population", emptyOptions);

            GUILayout.Space(8f);
            settings.EnableDiscontiguityMalus = GUILayout.Toggle(settings.EnableDiscontiguityMalus, "Enable Discontiguity Malus", emptyOptions);
            GUILayout.Label("Apply a malus to cohesion for non-contiguous regions. Contiguous = reachable from capital without crossing enemy territory", emptyOptions);

            if (settings.EnableDiscontiguityMalus)
            {
                GUILayout.Space(4f);
                GUILayout.Label("Discontiguity Malus Percentage: " + settings.DiscontiguityMalusPercentage.ToString("F1") + "%", emptyOptions);
                settings.DiscontiguityMalusPercentage = GUILayout.HorizontalSlider(settings.DiscontiguityMalusPercentage, 0.5f, 10f, emptyOptions);
            }

            // ====================================================================
            // CULTURAL INERTIA
            // ====================================================================
            GUILayout.Space(8f);
            GUILayout.Label("<b>Cultural Inertia</b>", emptyOptions);
            settings.EnableCulturalInertia = GUILayout.Toggle(settings.EnableCulturalInertia, "Enable Cultural Inertia", emptyOptions);
            GUILayout.Label("Foreign-culture populations drag cohesion; Unity and recognised absorptions shift culture", emptyOptions);

            if (settings.EnableCulturalInertia)
            {
                GUILayout.Space(4f);
                GUILayout.Label("Cultural Mismatch Max: " + settings.CulturalMismatchMax.ToString("F1"), emptyOptions);
                settings.CulturalMismatchMax = GUILayout.HorizontalSlider(settings.CulturalMismatchMax, 0.5f, 5f, emptyOptions);

                GUILayout.Space(4f);
                GUILayout.Label("Unity Assimilation Strength: " + settings.UnityAssimilationStrength.ToString("F2"), emptyOptions);
                settings.UnityAssimilationStrength = GUILayout.HorizontalSlider(settings.UnityAssimilationStrength, 0f, 5f, emptyOptions);

                GUILayout.Space(4f);
                GUILayout.Label("Absorption Recognition Rate: " + (settings.AbsorptionRecognitionRate * 100f).ToString("F0") + "%", emptyOptions);
                settings.AbsorptionRecognitionRate = GUILayout.HorizontalSlider(settings.AbsorptionRecognitionRate, 0f, 1f, emptyOptions);
            }

            // ====================================================================
            // UTILITIES
            // ====================================================================
            GUILayout.Space(8f);
            GUILayout.Label("<b>Utilities</b>", emptyOptions);
            settings.EnableDebugLogging = GUILayout.Toggle(settings.EnableDebugLogging, "Enable Debug Logging", emptyOptions);
            GUILayout.Label("Logs cohesion calculations for each nation", emptyOptions);
        }

        private static void OnSaveGUI(UnityModManager.ModEntry modEntry)
        {
            CreepingBordersCls.Settings.Save(modEntry);
        }

        /// <summary>
        /// Applies border expansion logic to all nations on game load.
        /// Ensures that any existing territories get adjacent unclaimed regions claimed.
        /// </summary>
        public static void ApplyBorderExpansionOnLoad()
        {
            if (!CreepingBordersCls.enabled || !CreepingBordersCls.Settings.EnableBorderExpansion)
                return;

            try
            {
                TINationState[] allNations = GameStateManager.AllNations();
                if (allNations == null || allNations.Length == 0)
                    return;

                int totalClaimsAdded = 0;

                // Process each nation
                foreach (TINationState nation in allNations)
                {
                    if (nation == null || !nation.extant || nation.regions == null || nation.regions.Count == 0)
                        continue;

                    // Create a list of all regions controlled by this nation
                    List<TIRegionState> nationRegions = new List<TIRegionState>(nation.regions);

                    // Apply border expansion to this nation's regions
                    ClaimAdjacentUnclaimedRegions(nation, nationRegions);

                    if (CreepingBordersCls.Settings.EnableDebugLogging)
                    {
                        CreepingBordersCls.mod.Logger.Log(
                            $"[BorderExpansion] Applied border expansion check on load for nation: {nation.displayName}");
                    }

                    totalClaimsAdded += (nation.claims != null ? nation.claims.Count : 0);
                }

                if (CreepingBordersCls.Settings.EnableDebugLogging)
                {
                    CreepingBordersCls.mod.Logger.Log(
                        $"[BorderExpansion] Game load border expansion complete. Processed {allNations.Length} nations.");
                }
            }
            catch (Exception ex)
            {
                CreepingBordersCls.mod.Logger.Error($"[BorderExpansion] Error during game load border expansion: {ex.Message}");
            }
        }

        /// <summary>
        /// Helper method to claim adjacent regions when border expansion is enabled
        /// </summary>
        internal static void ClaimAdjacentUnclaimedRegions(TINationState nation, List<TIRegionState> transferredRegions)
        {
            if (!CreepingBordersCls.Settings.EnableBorderExpansion || nation == null || transferredRegions == null)
            {
                return;
            }

            // Collect all adjacent regions from the transferred regions
            HashSet<TIRegionState> adjacentRegions = new HashSet<TIRegionState>();

            foreach (TIRegionState region in transferredRegions)
            {
                if (region == null || region.Neighbors == null)
                    continue;

                // Check all neighbors of this transferred region
                foreach (TIRegionState neighbor in region.Neighbors)
                {
                    if (neighbor == null)
                        continue;

                    // Only add regions not already claimed
                    if (nation.claims != null && nation.claims.Contains(neighbor))
                        continue;

                    // Don't claim regions the nation already controls
                    if (neighbor.nation == nation)
                        continue;

                    adjacentRegions.Add(neighbor);
                }
            }

            // Now add claims to all adjacent regions
            if (adjacentRegions.Count > 0)
            {
                foreach (TIRegionState adjacentRegion in adjacentRegions)
                {
                    if (adjacentRegion != null)
                    {
                        // Use SetClaim instead of AddClaim to properly register the claim with the game
                        // This ensures bilateral templates and data dirty flags are properly set
                        nation.SetClaim(adjacentRegion, fromSeizure: true, forceFromSeizure: false);

                        if (CreepingBordersCls.Settings.EnableDebugLogging)
                        {
                            CreepingBordersCls.mod.Logger.Log(
                                $"[BorderExpansion] {nation.displayName} claimed adjacent region: {adjacentRegion.displayName} (owned by {(adjacentRegion.nation != null ? adjacentRegion.nation.displayName : "unclaimed")})");
                        }
                    }
                }
            }
            else if (CreepingBordersCls.Settings.EnableDebugLogging && transferredRegions.Count > 0)
            {

                CreepingBordersCls.mod.Logger.Log(
                    $"[BorderExpansion] No adjacent unclaimed regions found for {nation.displayName} around {transferredRegions.Count} region(s)");
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
        /// <summary>
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
        /// Determines if two regions can be connected via naval routes with navalFreedom enabled.
        /// Checks if both regions have access to common water bodies and if the nation has naval freedom.
        /// </summary>
        /// <param name="region1">First region to check</param>
        /// <param name="region2">Second region to check</param>
        /// <param name="nation">The nation checking the connection</param>
        /// <returns>True if regions can be connected via naval routes, false otherwise</returns>




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

            // Validate capital is owned by this nation
            if (nation.capital.nation != nation)
            {
                return new List<TIRegionState>();
            }

            // Collect annexable regions: fully contiguous with the capital, per the
            // PolygonalRegionConnectivityManager. The old dual criterion (BFS-contiguous
            // OR any island claim) is replaced: island claims qualify only when the
            // manager grants them Full via distance bridging (<= FullDistanceX). Partial
            // regions - including politically severed ones capped by the Incident 6d
            // physical-reachability rule - are NOT annexable.
            var connectivity = PolygonalRegionConnectivityManager.Get(nation);
            var annexableRegions = new List<TIRegionState>(nation.claims.Count);

            foreach (TIRegionState claimedRegion in nation.claims)
            {
                if (claimedRegion == null || claimedRegion.nation == nation)
                    continue;

                if (connectivity.FullyContiguousRegions.Contains(claimedRegion))
                {
                    annexableRegions.Add(claimedRegion);
                }
            }

            return annexableRegions;
        }

        /// <summary>
        /// Result type for contiguous regions
        /// </summary>
        public class ContiguousRegionsInfo
        {
            /// <summary>
            /// Regions that are fully contiguous
            /// </summary>
            public HashSet<TIRegionState> FullyContiguousRegions { get; set; }

            /// <summary>
            /// Regions that are extended distance regions (no longer used)
            /// </summary>
            public HashSet<TIRegionState> ExtendedDistanceRegions { get; set; }

            /// <summary>
            /// Combined set for quick lookup
            /// </summary>
            public HashSet<TIRegionState> AllContiguousRegions { get; set; }
        }

        /// <summary>
        /// Gets regions that are truly contiguous with the capital, treating regions held by other nations as blockers.

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
        /// Gets regions that are truly contiguous with the capital.
        /// Returns fully contiguous regions.
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

            // Validate capital is owned by this nation before starting BFS
            if (nation.capital.nation != nation)
                return result;

            // Primary computation: PolygonalRegionConnectivityManager fixpoint BFS
            // (adjacency pass, polygon distance bridging pass, island-bridge pass).
            // Previously this method ran its own adjacency-only BFS, which ignored
            // the polygon distance system entirely (archipelago nations like
            // Indonesia got zero distance bridging — Incident 4).
            var connectivity = PolygonalRegionConnectivityManager.Get(nation);
            if (connectivity != null)
            {
                foreach (var pair in connectivity.Levels)
                {
                    TIRegionState region = pair.Key;
                    ConnectivityLevel level = pair.Value;
                    if (level >= ConnectivityLevel.Partial)
                    {
                        result.AllContiguousRegions.Add(region);
                        if (level >= ConnectivityLevel.Full)
                            result.FullyContiguousRegions.Add(region);
                        else
                            result.ExtendedDistanceRegions.Add(region);
                    }
                }
            }

            // Legacy island-bridge pass retained: adds regions the manager could
            // not reach (e.g. missing geometry). Levels already granted by the
            // manager are >= Partial, and this pass only ADDS to AllContiguous,
            // so it can never downgrade a distance-bridged result.
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



                // Adjacency-based bridge detection (only if coastal islands exist)
                if (coastalIslands.Count > 0)
                {
                    // BFS through coastal islands to find connected continental regions and other islands
                    Queue<TIRegionState> queue = new Queue<TIRegionState>(coastalIslands);
                    HashSet<TIRegionState> visitedIslands = new HashSet<TIRegionState>(coastalIslands);

                    while (queue.Count > 0)
                    {
                        TIRegionState currentIsland = queue.Dequeue();

                        // Check all neighbors of this coastal island
                        foreach (TIRegionState neighbor in currentIsland.Neighbors)
                        {
                            if (neighbor == null || neighbor.nation != nation)
                                continue;

                            // Use pre-computed island lookup (faster than GetLandmassType())
                            bool isNeighborIsland = islandLookup[neighbor];

                            // If neighbor is not yet in contiguity, consider adding it
                            if (currentContiguity.AllContiguousRegions.Add(neighbor))  // Returns true if added
                            {
                                // Only add islands through island bridges
                                // Continental regions cannot inherit contiguity from islands
                                if (isNeighborIsland)
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
                                else if (!isNeighborIsland)
                                {
                                    // Continental neighbors are NOT added through island bridges
                                    // Remove it from AllContiguousRegions since we added it but won't add to FullyContiguousRegions
                                    currentContiguity.AllContiguousRegions.Remove(neighbor);

                                    if (CreepingBordersCls.Settings.EnableDebugLogging)
                                    {
                                        CreepingBordersCls.mod.Logger.Log(
                                            $"[Contiguity] {neighbor.displayName} ({nation.displayName}): " +
                                            $"Continental regions cannot inherit contiguity from islands (blocked)");
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
            }

            if (CreepingBordersCls.Settings.EnableDebugLogging)
            {
                CreepingBordersCls.mod.Logger.Log($"[Contiguity] Bridge island resolution completed in {iterationCount} iterations for {nation.displayName}. Final contiguous count: {currentContiguity.FullyContiguousRegions.Count}");
            }
        }

        /// <summary>
        /// Checks if an island region has any adjacencies to fully contiguous regions.
        /// This is used to determine if an island should be treated as continental-like

        /// </summary>
        private static bool HasAdjacenciesToContiguousRegions(TIRegionState island, HashSet<TIRegionState> fullyContiguousRegions)
        {
            if (island == null || fullyContiguousRegions == null || fullyContiguousRegions.Count == 0)
                return false;

            // Check all neighbors of this island
            foreach (TIRegionState neighbor in island.Neighbors)
            {
                if (neighbor == null || !fullyContiguousRegions.Contains(neighbor))
                    continue;

                // Check if we have full adjacency with this contiguous region
                if (neighbor.IsAdjacent(island, true))
                {
                    return true;
                }
            }

            return false;
        }
    }

    /// <summary>
    /// Extension methods for TIRegionState to determine landmass characteristics
    /// </summary>
    public static class TIRegionStateExtensions
    {
        private const int ContinentSize = 5;


        private static readonly Dictionary<TIRegionState, LandmassType> landmassTypeCache = 
            new Dictionary<TIRegionState, LandmassType>();


        private static readonly Dictionary<(TIRegionState region, TINationState nation), DiscontiguityInfo> regionContiguityCache =
            new Dictionary<(TIRegionState, TINationState), DiscontiguityInfo>();

        // ========== Border Distance Calculation (Polygon-based) ==========
        private static readonly FieldInfo PolyLatLonsField =
            AccessTools.Field(typeof(RegionController), "polyLatLons");

        private static readonly Dictionary<TIRegionState, List<Vector2>> VertexCache =
            new Dictionary<TIRegionState, List<Vector2>>();

        private const string CacheFileName = "BorderDistanceCache.csv"; // managed by GeographicPolygonMath
        /// <summary>

        /// </summary>
        public static void ClearLandmassTypeCache()
        {
            landmassTypeCache.Clear();
        }

        /// <summary>

        /// </summary>
        public static void ClearRegionContiguityCache(TIRegionState region, TINationState nation)
        {
            if (region == null || nation == null)
                return;

            var key = (region, nation);
            regionContiguityCache.Remove(key);
        }

        /// <summary>

        /// </summary>
        public static void ClearRegionContiguityCacheForNation(TINationState nation)
        {
            if (nation == null)
                return;

            var keysToRemove = regionContiguityCache.Keys
                .Where(k => k.nation == nation)
                .ToList();

            foreach (var key in keysToRemove)
            {
                regionContiguityCache.Remove(key);
            }
        }

        /// <summary>
        /// Clears all caches
        /// </summary>
        public static void ClearAllCaches()
        {
            ClearLandmassTypeCache();
            regionContiguityCache.Clear();
        }

        /// <summary>
        /// Tracks path information for single-pass BFS with path scoring (allied nation traversal)
        /// </summary>
        private class RegionPathInfo
        {
            public TIRegionState Region { get; set; }
            public int AlliedNationCost { get; set; }  // Number of unique allied nations in path
            public HashSet<TINationState> AlliedNationsInPath { get; set; }  // Set of allied nations traversed
        }

        /// <summary>
        /// Performs single-pass BFS with path scoring to find discontiguous regions reachable through allies.
        /// Returns regions organized by path cost (fewest unique allied nations preferred).
        /// If any region is reachable with cost 0 (direct path through own regions), returns immediately.
        /// Ignores national boundaries during traversal and counts unique allied nations per path.
        /// </summary>
        private static Dictionary<int, HashSet<TIRegionState>> BFSWithPathScoring(TINationState nation, HashSet<TIRegionState> discontiguousRegions)
        {
            var regionsByCost = new Dictionary<int, HashSet<TIRegionState>>();

            if (nation == null || nation.capital == null || discontiguousRegions == null || discontiguousRegions.Count == 0)
                return regionsByCost;

            if (nation.capital.nation != nation)
                return regionsByCost;

            if (nation.allies == null || nation.allies.Count == 0)
                return regionsByCost;

            // Track best cost found for each region (cost = count of unique allied nations)
            var bestCostForRegion = new Dictionary<TIRegionState, int>();
            var queue = new Queue<RegionPathInfo>();

            // Initialize with capital at cost 0
            var startPath = new RegionPathInfo
            {
                Region = nation.capital,
                AlliedNationCost = 0,
                AlliedNationsInPath = new HashSet<TINationState>()
            };
            queue.Enqueue(startPath);
            bestCostForRegion[nation.capital] = 0;

            bool foundDirectPath = false;  // Early termination flag

            while (queue.Count > 0 && !foundDirectPath)
            {
                var currentPath = queue.Dequeue();
                TIRegionState current = currentPath.Region;

                // Explore neighbors
                foreach (TIRegionState neighbor in current.Neighbors)
                {
                    if (neighbor == null)
                        continue;

                    // Check adjacency (peaceful traversal)
                    if (!neighbor.IsAdjacent(current, false))
                        continue;

                    // Determine cost to traverse to this neighbor
                    int newCost = currentPath.AlliedNationCost;
                    var newAlliedNations = new HashSet<TINationState>(currentPath.AlliedNationsInPath);

                    // Classify neighbor ownership
                    bool isOwnRegion = neighbor.nation == nation;
                    bool isAllyRegion = neighbor.nation != null && nation.allies.Contains(neighbor.nation);
                    bool isUnclaimedOrHostile = !isOwnRegion && !isAllyRegion;

                    // Cannot traverse through hostile or neutral territory
                    if (isUnclaimedOrHostile)
                        continue;

                    // If ally region and not yet in path, increment cost
                    if (isAllyRegion && !newAlliedNations.Contains(neighbor.nation))
                    {
                        newCost++;
                        newAlliedNations.Add(neighbor.nation);
                    }

                    // Check if we've found a better path to this neighbor
                    if (bestCostForRegion.TryGetValue(neighbor, out int existingCost))
                    {
                        // Skip if we found equal or worse path
                        if (newCost >= existingCost)
                            continue;
                    }

                    // This is a new best path to this region
                    bestCostForRegion[neighbor] = newCost;

                    // Check if this is a discontiguous region
                    if (discontiguousRegions.Contains(neighbor))
                    {
                        // Record this region as reachable with this cost
                        if (!regionsByCost.ContainsKey(newCost))
                            regionsByCost[newCost] = new HashSet<TIRegionState>();
                        regionsByCost[newCost].Add(neighbor);

                        if (CreepingBordersCls.Settings.EnableDebugLogging)
                        {
                            CreepingBordersCls.mod.Logger.Log($"[Contiguity] {neighbor.displayName} is reachable with cost {newCost}");
                        }

                        // Early termination: if we found a direct path (cost 0), we can stop
                        if (newCost == 0)
                        {
                            foundDirectPath = true;
                        }
                    }

                    // Continue BFS to this neighbor
                    var nextPath = new RegionPathInfo
                    {
                        Region = neighbor,
                        AlliedNationCost = newCost,
                        AlliedNationsInPath = newAlliedNations
                    };
                    queue.Enqueue(nextPath);
                }
            }

            return regionsByCost;
        }

        /// <summary>
        /// Determines if this region is part of an island or continent based on contiguous region count

        /// </summary>
        public static LandmassType GetLandmassType(this TIRegionState region)
        {
            if (region == null)
                return LandmassType.Island;

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

        // ========== Border Distance Calculation Methods ==========

        /// <summary>
        /// Shortest great-circle distance (km) between the two regions' border polygons.
        /// Single source of truth: delegates to GeographicPolygonMath (edge-to-arc,
        /// shared disk cache). No centroid fallback — regions without geometry are
        /// Unknown in the manager, and the tooltip reports the same value the
        /// manager classified with (Incident 5).
        /// </summary>
        public static float ShortestBorderDistance_km(this TIRegionState regionA, TIRegionState regionB)
        {
            if (regionA == null || regionB == null)
                return 0f;

            if (regionA == regionB)
                return 0f;

            var (distanceKm, result) = GeographicPolygonMath.GetRegionPairDistance(
                regionA, regionB,
                PolygonalRegionConnectivityManager.X_km,
                PolygonalRegionConnectivityManager.PartialDistanceX * PolygonalRegionConnectivityManager.X_km);

            if (result == PolygonDistanceResult.Unknown || result == PolygonDistanceResult.Beyond3X)
                return float.MaxValue;

            return distanceKm;
        }

        private static List<Vector2> GetBorderLonLat(TIRegionState region)
        {
            if (VertexCache.TryGetValue(region, out List<Vector2> cached))
                return cached;

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

        /// <summary>
        /// Computes every unique region pair's border distance via GeographicPolygonMath
        /// (edge-to-arc, appends misses to the shared BorderDistanceCache.csv).
        /// Run this once when the full map is loaded to get accurate polygon geometry.
        /// </summary>
        public static void PrecomputeAllPairs()
        {
            TIRegionState[] allRegions = GameStateManager.AllRegions();
            int total = allRegions.Length * (allRegions.Length - 1) / 2;
            int done = 0;
            int unknown = 0;

            CreepingBordersCls.mod.Logger.Log($"[BorderDistance] Precomputing {total} region pairs ({allRegions.Length} regions)...");

            for (int i = 0; i < allRegions.Length; i++)
            {
                TIRegionState regionA = allRegions[i];

                for (int j = i + 1; j < allRegions.Length; j++)
                {
                    TIRegionState regionB = allRegions[j];

                    var (_, result) = GeographicPolygonMath.GetRegionPairDistance(
                        regionA, regionB,
                        PolygonalRegionConnectivityManager.X_km,
                        PolygonalRegionConnectivityManager.PartialDistanceX * PolygonalRegionConnectivityManager.X_km);

                    if (result == PolygonDistanceResult.Unknown)
                        unknown++;

                    done++;
                }

                if (i % 25 == 0)
                {
                    CreepingBordersCls.mod.Logger.Log($"[BorderDistance] ...{done}/{total} pairs done.");
                }
            }

            CreepingBordersCls.mod.Logger.Log($"[BorderDistance] Precompute complete: {done} pairs processed.");
            if (unknown > 0)
            {
                CreepingBordersCls.mod.Logger.Log($"[BorderDistance] WARNING: {unknown} pairs had no polygon geometry — " +
                    "they are Unknown in the shared cache. Re-run this with the full world map visible/loaded to get real polygons for those.");
            }
        }

        /// <summary>
        /// Clears the in-memory vertex cache (call after a scene reload).
        /// The pair-distance table is managed by GeographicPolygonMath.
        /// </summary>
        public static void InvalidateCache()
        {
            VertexCache.Clear();
            GeographicPolygonMath.ReloadTable();
        }

        /// <summary>
        /// Internal result type for discontiguity analysis
        /// </summary>
        private class DiscontiguityInfo
        {
            public enum PathType
            {
                DirectBFS,           // Direct BFS path to capital
                FullyContiguousIsland,   // Island within normal distance
                PartiallyContiguousIsland, // Island within extended distance
                AllyRoute,           // Reachable through allied territory
                Discontiguous        // Not contiguous at all
            }

            public bool IsFullyDiscontiguous { get; set; }
            public bool IsPartiallyDiscontiguous { get; set; }
            public PathType ContiguityPathType { get; set; }
            public TIRegionState NextHopRegion { get; set; }  // Next region in path (e.g., island next hop, ally capital)
            public float NextHopDistance { get; set; }        // Distance to next hop (for islands)
            public TINationState AllyNation { get; set; }     // Allied nation if path goes through allies
        }

        /// <summary>
        /// Calculates discontiguity info for a region based on requirements:
        /// - Extended regions: Within 2x distance to fully contiguous island
        /// - Partially discontiguous: Reachable through allied regions
        /// - Fully discontiguous: Not in either category
        /// 
        /// Returns DiscontiguityInfo with IsFullyDiscontiguous and IsPartiallyDiscontiguous flags.
        /// These flags are only meaningful when the region is not in the main contiguous set.
        /// </summary>
        private static DiscontiguityInfo GetDiscontiguityInfo(TIRegionState region)
        {
            if (region == null || region.nation == null)
                return new DiscontiguityInfo 
                { 
                    IsFullyDiscontiguous = false, 
                    IsPartiallyDiscontiguous = false,
                    ContiguityPathType = DiscontiguityInfo.PathType.Discontiguous
                };

            TINationState nation = region.nation;

            var cacheKey = (region, nation);
            if (regionContiguityCache.TryGetValue(cacheKey, out var cachedInfo))
            {
                return cachedInfo;
            }

            // Get the contiguous regions with extended distance tracking
            var contiguousInfo = TINationStateExtensions.GetTrueContiguousRegionsWithExtended(nation);
            var trueContiguousRegions = contiguousInfo.FullyContiguousRegions;
            var extendedRegions = contiguousInfo.ExtendedDistanceRegions;

            // If region is in fully contiguous set, determine how it achieved contiguity (Direct BFS or via island)
            if (trueContiguousRegions.Contains(region))
            {
                if (CreepingBordersCls.Settings.EnableDebugLogging)
                {
                    CreepingBordersCls.mod.Logger.Log($"[Contiguity] {region.displayName} ({nation.displayName}): Contiguous (part of main landmass)");
                }

                // Check if this region is an island (added via island route)
                var result = new DiscontiguityInfo 
                { 
                    IsFullyDiscontiguous = false, 
                    IsPartiallyDiscontiguous = false,
                    ContiguityPathType = DiscontiguityInfo.PathType.DirectBFS
                };

                // Only regions that reached contiguity via island bridging get a next hop.
                // A region with an adjacency path to the capital is a direct BFS route:
                // even if flagged LandmassType.Island (no naval adjacency, e.g. Britain),
                // showing an island hop would be wrong (Incident 6 follow-up).
                if (region.GetLandmassType() == LandmassType.Island &&
                    !CanReachCapitalThroughAdjacencies(region, nation))
                {
                    result.NextHopRegion = FindClosestContiguousRegion(region, nation, trueContiguousRegions);
                    if (result.NextHopRegion != null)
                    {
                        result.ContiguityPathType = DiscontiguityInfo.PathType.FullyContiguousIsland;
                        result.NextHopDistance = region.ShortestBorderDistance_km(result.NextHopRegion);
                    }
                }

                regionContiguityCache[cacheKey] = result;
                return result;
            }

            // PRE-CHECK: For regions not yet found by main BFS, check if islands can reach capital through adjacencies
            // This catches island regions that might have adjacency paths to the capital
            if (region.GetLandmassType() == LandmassType.Island && !trueContiguousRegions.Contains(region))
            {
                if (CanReachCapitalThroughAdjacencies(region, nation))
                {
                    // Island can reach capital through adjacencies - treat as fully contiguous via direct path
                    if (CreepingBordersCls.Settings.EnableDebugLogging)
                    {
                        CreepingBordersCls.mod.Logger.Log($"[Contiguity] {region.displayName} ({nation.displayName}): Island reaches capital via adjacencies - upgrading to DirectBFS");
                    }

                    var result = new DiscontiguityInfo 
                    { 
                        IsFullyDiscontiguous = false, 
                        IsPartiallyDiscontiguous = false,
                        ContiguityPathType = DiscontiguityInfo.PathType.DirectBFS
                    };

                    regionContiguityCache[cacheKey] = result;
                    return result;
                }
            }

            if (extendedRegions.Contains(region))
            {
                if (CreepingBordersCls.Settings.EnableDebugLogging)
                {
                    CreepingBordersCls.mod.Logger.Log($"[Contiguity] {region.displayName} ({nation.displayName}): PARTIALLY DISCONTIGUOUS - in extended distance island range");
                }

                var result = new DiscontiguityInfo 
                { 
                    IsFullyDiscontiguous = false, 
                    IsPartiallyDiscontiguous = true,
                    ContiguityPathType = DiscontiguityInfo.PathType.PartiallyContiguousIsland
                };

                // Find the closest contiguous region for the next hop
                result.NextHopRegion = FindClosestContiguousRegion(region, nation, trueContiguousRegions);
                if (result.NextHopRegion != null)
                {
                    float distance = region.ShortestBorderDistance_km(result.NextHopRegion);
                    result.NextHopDistance = distance;
                }

                regionContiguityCache[cacheKey] = result;
                return result;
            }

            // Remaining regions are discontiguous - check if reachable through allies
            var discontiguousRegions = new HashSet<TIRegionState>();
            foreach (TIRegionState r in nation.regions)
            {
                if (r != null && !trueContiguousRegions.Contains(r) && !extendedRegions.Contains(r))
                    discontiguousRegions.Add(r);
            }

            // If no discontiguous regions exist, region must be in a contiguous set
            if (discontiguousRegions.Count == 0)
            {
                var result = new DiscontiguityInfo 
                { 
                    IsFullyDiscontiguous = false, 
                    IsPartiallyDiscontiguous = false,
                    ContiguityPathType = DiscontiguityInfo.PathType.DirectBFS
                };
                regionContiguityCache[cacheKey] = result;
                return result;
            }

            // Check if this discontiguous region is reachable through allied territory
            var allyReachableRegions = GetAllyReachableDiscontiguousRegions(nation, discontiguousRegions);
            bool isAllyReachable = allyReachableRegions.Contains(region);

            DiscontiguityInfo finalResult = new DiscontiguityInfo 
            { 
                IsFullyDiscontiguous = !isAllyReachable,
                IsPartiallyDiscontiguous = isAllyReachable,
                ContiguityPathType = isAllyReachable ? DiscontiguityInfo.PathType.AllyRoute : DiscontiguityInfo.PathType.Discontiguous
            };

            // If ally-reachable, find which ally is the bridge
            if (isAllyReachable && nation.allies != null)
            {
                foreach (TINationState ally in nation.allies)
                {
                    if (ally?.capital != null)
                    {
                        finalResult.AllyNation = ally;
                        break; // Use first ally as the bridge for now
                    }
                }
            }

            // Log discontiguity detection
            if (CreepingBordersCls.Settings.EnableDebugLogging)
            {
                if (finalResult.IsFullyDiscontiguous)
                {
                    CreepingBordersCls.mod.Logger.Log($"[Contiguity] {region.displayName} ({nation.displayName}): FULLY DISCONTIGUOUS - not reachable through allied territory");
                }
                else if (finalResult.IsPartiallyDiscontiguous)
                {
                    CreepingBordersCls.mod.Logger.Log($"[Contiguity] {region.displayName} ({nation.displayName}): PARTIALLY DISCONTIGUOUS - reachable through allied territory");
                }
            }

            regionContiguityCache[cacheKey] = finalResult;
            return finalResult;
        }

        /// <summary>
        /// Helper method to find the next hop on the island route: the contiguous region
        /// that makes the most progress TOWARD THE CAPITAL. Ranks candidates by their
        /// polygon distance to the nation capital (ascending), tie-broken by distance
        /// to the region itself. Ranking by distance-to-self picks symmetric nearest
        /// neighbours (e.g. Medan<->Banda Aceh loop) instead of the route home.
        /// </summary>
        private static TIRegionState FindClosestContiguousRegion(TIRegionState region, TINationState nation, HashSet<TIRegionState> contiguousRegions)
        {
            if (region == null || nation == null || nation.capital == null ||
                contiguousRegions == null || contiguousRegions.Count == 0)
                return null;

            TIRegionState capital = nation.capital;
            TIRegionState best = null;
            float bestToCapital = float.MaxValue;
            float bestToSelf = float.MaxValue;

            // A next hop must actually be reachable: within the Full gate (X) of this region.
            // Without this filter, the capital (distance-to-capital = 0) always wins the ranking
            // even when it is hundreds of km away and cannot serve as a hop (Incident 8).
            float FULL_GATE_KM = PolygonalRegionConnectivityManager.X_km; // Full gate = X

            foreach (TIRegionState contiguousRegion in contiguousRegions)
            {
                if (contiguousRegion == null || contiguousRegion == region)
                    continue;

                float toSelf = region.ShortestBorderDistance_km(contiguousRegion);
                if (toSelf > FULL_GATE_KM)
                    continue;

                float toCapital = contiguousRegion.ShortestBorderDistance_km(capital);

                if (toCapital < bestToCapital ||
                    (toCapital == bestToCapital && toSelf < bestToSelf))
                {
                    bestToCapital = toCapital;
                    bestToSelf = toSelf;
                    best = contiguousRegion;
                }
            }

            return best;
        }

        /// <summary>
        /// Checks if an island region can reach the nation's capital through adjacencies (not distance).
        /// Uses BFS traversal following only full adjacencies.
        /// </summary>
        private static bool CanReachCapitalThroughAdjacencies(TIRegionState island, TINationState nation)
        {
            if (island == null || nation == null || nation.capital == null)
                return false;

            // Quick check: if this region IS the capital, it's already contiguous
            if (island == nation.capital)
                return true;

            HashSet<TIRegionState> visited = new HashSet<TIRegionState>();
            Queue<TIRegionState> queue = new Queue<TIRegionState>();
            queue.Enqueue(island);
            visited.Add(island);

            // BFS through adjacencies only (full adjacency)
            while (queue.Count > 0)
            {
                TIRegionState current = queue.Dequeue();

                foreach (TIRegionState neighbor in current.Neighbors)
                {
                    if (neighbor == null || visited.Contains(neighbor))
                        continue;

                    // Ownership filter: a BFS route through foreign territory is
                    // politically broken, not contiguous. If the only land path to the
                    // capital crosses another nation, this region must fall through to
                    // distance bridging instead (Incident 6c: Glasgow isolated from
                    // London by a foreign Midlands must NOT upgrade to DirectBFS).
                    if (neighbor.nation != nation)
                        continue;

                    // Only traverse full adjacencies
                    if (!neighbor.IsAdjacent(current, true))
                        continue;

                    // Check if we reached the capital
                    if (neighbor == nation.capital)
                    {
                        if (CreepingBordersCls.Settings.EnableDebugLogging)
                        {
                            CreepingBordersCls.mod.Logger.Log($"[Contiguity] {island.displayName} ({nation.displayName}): Island can reach capital through adjacencies!");
                        }
                        return true;
                    }

                    visited.Add(neighbor);
                    queue.Enqueue(neighbor);
                }
            }

            return false;
        }

        /// <summary>
        /// Determines if this region is fully discontiguous (not reachable even through allied territory)
        /// Only meaningful when the owning nation has discontiguous regions
        /// </summary>
        public static bool IsFullyDiscontiguous(this TIRegionState region)
        {
            if (region == null)
                return false;

            return GetDiscontiguityInfo(region).IsFullyDiscontiguous;
        }

        /// <summary>
        /// Determines if this region is partially discontiguous (discontiguous but reachable through allied territory)
        /// Only meaningful when the owning nation has discontiguous regions
        /// </summary>
        public static bool IsPartiallyDiscontiguous(this TIRegionState region)
        {
            if (region == null)
                return false;

            return GetDiscontiguityInfo(region).IsPartiallyDiscontiguous;
        }

        /// <summary>
        /// Gets the contiguity status of this region as a human-readable string with detailed information about the path
        /// </summary>
        public static string GetContiguityStatus(this TIRegionState region)
        {
            if (region == null || region.nation == null)
                return Loc.T("UI.Nation.Contiguity.Unknown");

            TINationState nation = region.nation;

            // Check if this region is the capital
            if (nation.capital != null && region == nation.capital)
                return Loc.T("UI.Nation.Contiguity.Capital");

            var discontiguityInfo = GetDiscontiguityInfo(region);

            if (discontiguityInfo.IsFullyDiscontiguous)
                return Loc.T("UI.Nation.Contiguity.FullyDiscontiguous");

            // Handle partially discontiguous / fully contiguous cases based on path type
            switch (discontiguityInfo.ContiguityPathType)
            {
                case DiscontiguityInfo.PathType.DirectBFS:
                    return Loc.T("UI.Nation.Contiguity.DirectBFS", new object[] { nation.capital.displayName });

                case DiscontiguityInfo.PathType.FullyContiguousIsland:
                    if (discontiguityInfo.NextHopRegion != null)
                    {
                        // Check if island is blockaded (no naval freedom)
                        if (region.GetLandmassType() == LandmassType.Island && !nation.navalFreedom)
                        {
                            return Loc.T("UI.Nation.Contiguity.IslandRouteFullyBlockaded", 
                                new object[] { discontiguityInfo.NextHopRegion.displayName, discontiguityInfo.NextHopDistance.ToString("F0") });
                        }

                        return Loc.T("UI.Nation.Contiguity.IslandRouteFully", 
                            new object[] { discontiguityInfo.NextHopRegion.displayName, discontiguityInfo.NextHopDistance.ToString("F0") });
                    }
                    return Loc.T("UI.Nation.Contiguity.Contiguous");

                case DiscontiguityInfo.PathType.PartiallyContiguousIsland:
                    if (discontiguityInfo.NextHopRegion != null)
                    {
                        // Check if island is blockaded (no naval freedom)
                        if (region.GetLandmassType() == LandmassType.Island && !nation.navalFreedom)
                        {
                            return Loc.T("UI.Nation.Contiguity.IslandRouteExtendedBlockaded",
                                new object[] { discontiguityInfo.NextHopRegion.displayName, discontiguityInfo.NextHopDistance.ToString("F0") });
                        }

                        return Loc.T("UI.Nation.Contiguity.IslandRouteExtended",
                            new object[] { discontiguityInfo.NextHopRegion.displayName, discontiguityInfo.NextHopDistance.ToString("F0") });
                    }
                    return Loc.T("UI.Nation.Contiguity.PartiallyDiscontiguous");

                case DiscontiguityInfo.PathType.AllyRoute:
                    if (discontiguityInfo.AllyNation != null)
                    {
                        return Loc.T("UI.Nation.Contiguity.AllyRoute",
                            new object[] { nation.capital.displayName, discontiguityInfo.AllyNation.displayName });
                    }
                    return Loc.T("UI.Nation.Contiguity.PartiallyDiscontiguous");

                case DiscontiguityInfo.PathType.Discontiguous:
                default:
                    return Loc.T("UI.Nation.Contiguity.FullyDiscontiguous");
            }
        }

        /// <summary>
        /// Helper method to format region and nation info for consistent logging output
        /// </summary>


        /// <summary>
        /// Helper method to find which discontiguous regions can be reached through allied territory.
        /// Uses optimized single-pass BFS with path scoring instead of multiple BFS passes.
        /// Prioritizes paths with fewest unique allied nations.
        /// </summary>
        public static HashSet<TIRegionState> GetAllyReachableDiscontiguousRegions(TINationState nation, HashSet<TIRegionState> discontiguousRegions)
        {
            HashSet<TIRegionState> reachableThroughAllies = new HashSet<TIRegionState>();

            if (nation == null || nation.capital == null || nation.allies == null || nation.allies.Count == 0)
            {
                if (CreepingBordersCls.Settings.EnableDebugLogging && discontiguousRegions.Count > 0)
                {
                    CreepingBordersCls.mod.Logger.Log($"[Contiguity] {nation.displayName}: No allies to bridge discontiguous regions. Discontiguous count: {discontiguousRegions.Count}");
                }
                return reachableThroughAllies;
            }

            if (nation.capital.nation != nation)
            {
                if (CreepingBordersCls.Settings.EnableDebugLogging)
                {
                    CreepingBordersCls.mod.Logger.Log($"[Contiguity] {nation.displayName}: Capital is not owned by this nation. Skipping ally reachability check.");
                }
                return reachableThroughAllies;
            }

            if (discontiguousRegions == null || discontiguousRegions.Count == 0)
            {
                return reachableThroughAllies;
            }

            // Use optimized single-pass BFS with path scoring
            var regionsByCost = BFSWithPathScoring(nation, discontiguousRegions);

            if (regionsByCost.Count == 0)
            {
                if (CreepingBordersCls.Settings.EnableDebugLogging)
                {
                    CreepingBordersCls.mod.Logger.Log($"[Contiguity] {nation.displayName}: No discontiguous regions reachable through allies");
                }
                return reachableThroughAllies;
            }

            // Get all reachable regions (regardless of cost)
            // Prefer direct paths (cost 0) if available, otherwise include all paths
            foreach (var kvp in regionsByCost.OrderBy(x => x.Key))
            {
                foreach (var region in kvp.Value)
                {
                    reachableThroughAllies.Add(region);
                    if (CreepingBordersCls.Settings.EnableDebugLogging)
                    {
                        CreepingBordersCls.mod.Logger.Log($"[Contiguity]   └─ {region.displayName} is ally-reachable (path cost: {kvp.Key})");
                    }
                }

                // Early exit optimization: if we found any direct paths (cost 0), stop looking for costlier paths
                // This ensures we prioritize direct connections
                if (kvp.Key == 0 && kvp.Value.Count > 0)
                    break;
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

            float regionsImpact = __instance.regionsImpactOnCohesion;

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

            if (__instance.regionsImpactOnCohesion != 0f)
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
            float regionsImpactForTotal = __instance.regionsImpactOnCohesion;
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

            if (nation == null || nation.capital == null || nation.allies == null || nation.allies.Count == 0)
            {
                return reachableThroughAllies; // No allies or capital, no regions reachable through them
            }

            // Validate capital is owned by this nation
            if (nation.capital.nation != nation)
            {
                return reachableThroughAllies; // Capital doesn't belong to this nation
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
                var allyReachableRegions = TIRegionStateExtensions.GetAllyReachableDiscontiguousRegions(nation, discontiguousRegions);

                // Split population into categories
                float fullPenaltyPopulation = 0f;      // Not reachable even through allies
                float halfPenaltyPopulation = extendedPopulation;  // Start with extended islands, add ally-reachable
                float doublePenaltyPopulation = 0f;    // Hostile regions that are discontiguous (double penalty)

                // For detailed logging
                List<string> fullyDiscontiguousRegions = new List<string>();
                List<string> partiallyDiscontiguousRegions = new List<string>();
                List<string> extendedIslands = new List<string>();
                List<string> hostileDiscontiguousRegions = new List<string>();

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
                    // Check if this region is hostile (partial or fully discontiguous hostile claim)
                    bool isHostile = region.hostileRegion;

                    if (isHostile)
                    {
                        // Hostile discontiguous regions get DOUBLE penalty
                        doublePenaltyPopulation += region.population;
                        if (CreepingBordersCls.Settings.EnableDebugLogging)
                            hostileDiscontiguousRegions.Add(region.displayName);
                    }
                    else if (allyReachableRegions.Contains(region))
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
                // DOUBLE penalty for hostile discontiguous regions
                float malusPercentage = CreepingBordersCls.Settings.DiscontiguityMalusPercentage / 100f;
                float fullPenalty = -(fullPenaltyPopulation / 1000000f) * malusPercentage;
                float halfPenalty = -(halfPenaltyPopulation / 1000000f) * malusPercentage * 0.5f;  // Halved!
                float doublePenalty = -(doublePenaltyPopulation / 1000000f) * malusPercentage * 2f;  // DOUBLED!

                float totalPenalty = fullPenalty + halfPenalty + doublePenalty;
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

                    if (hostileDiscontiguousRegions.Count > 0)
                    {
                        debugLog.AppendLine($"  Hostile Discontiguous ({hostileDiscontiguousRegions.Count} regions, {doublePenaltyPopulation:N0} pop) [DOUBLE Penalty]:");
                        foreach (string regionName in hostileDiscontiguousRegions)
                        {
                            debugLog.AppendLine($"    - {regionName}");
                        }
                        debugLog.AppendLine($"    Double Penalty: {doublePenalty:N2}");
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

    [HarmonyPatch(typeof(GameControl), "ResetLoadingState")]
    public static class Patch_ResetLoadingState
    {
        /// <summary>
        /// Postfix patch that resets game load flags when a new game/save is loaded.
        /// This ensures border expansion and island analysis run for each new game.
        /// </summary>
        static void Postfix()
        {
            if (!CreepingBordersCls.enabled)
            {
                return;
            }

            // Reset flags so they run again for the new game/save
            CreepingBordersCls.borderExpansionOnLoadPerformed = false;
            CulturalInertia.ResetInMemoryState();

            if (CreepingBordersCls.Settings.EnableDebugLogging)
            {
                CreepingBordersCls.mod.Logger.Log("[GameLoad] Reset load flags for new game/save");
            }
        }
    }

    [HarmonyPatch(typeof(TINationState), "TransferRegionsControlTo")]
    public static class Patch_TransferRegionsControlTo
    {
        static void Postfix(TINationState __instance, List<TIRegionState> regions, TINationState newNation)
        {
            if (!CreepingBordersCls.enabled)
            {
                return;
            }

            // Extract transferred regions and receiving nation from parameters
            var transferredRegions = regions;
            var receivingNation = newNation;

            if (transferredRegions == null || receivingNation == null)
            {
                return;
            }

            // __instance is the losing nation (transferring regions away)
            TINationState losingNation = __instance;

            foreach (var region in transferredRegions)
            {
                if (region != null)
                {
                    TIRegionStateExtensions.ClearRegionContiguityCache(region, losingNation);
                    TIRegionStateExtensions.ClearRegionContiguityCache(region, receivingNation);
                }
            }

            TIRegionStateExtensions.ClearRegionContiguityCacheForNation(losingNation);
            TIRegionStateExtensions.ClearRegionContiguityCacheForNation(receivingNation);

            // Clear hostile claims if that setting is enabled
            if (CreepingBordersCls.Settings.NoHostileClaims)
            {
                TINationState[] allNations = GameStateManager.AllNations();
                foreach (TINationState nation in allNations)
                {
                    if (nation != null && nation.hostileClaims != null)
                    {
                        nation.hostileClaims.Clear();
                    }
                }
            }

            // §4: conversion seeds on capture — research-claim converts at
            // max(50%, current), plain conquest never lowers the capturer's share.
            if (CreepingBordersCls.Settings.EnableCulturalInertia)
            {
                foreach (var region in transferredRegions)
                {
                    if (region != null)
                        CulturalInertiaClaims.OnConquest(region, receivingNation);
                }
            }

            // Refresh claims for all nations when border expansion is enabled
            if (CreepingBordersCls.Settings.EnableBorderExpansion)
            {
                TINationState[] allNations = GameStateManager.AllNations();
                foreach (TINationState nation in allNations)
                {
                    if (nation != null && nation.extant && nation.regions != null && nation.regions.Count > 0)
                    {
                        List<TIRegionState> nationRegions = new List<TIRegionState>(nation.regions);
                        CreepingBordersCls.ClaimAdjacentUnclaimedRegions(nation, nationRegions);

                        if (CreepingBordersCls.Settings.EnableDebugLogging)
                        {
                            CreepingBordersCls.mod.Logger.Log(
                                $"[BorderExpansion] Refreshed claims for nation: {nation.displayName}");
                        }
                    }
                }
            }
            else
            {
                // If border expansion disabled, only claim for receiving nation (backward compatibility)
                CreepingBordersCls.ClaimAdjacentUnclaimedRegions(receivingNation, transferredRegions);
            }
        }
    }

    [HarmonyPatch(typeof(TINationState), "DeclareLimitedWar")]
    public static class Patch_DeclareLimitedWar
    {
        static void Postfix(TINationState __instance)
        {
            if (!CreepingBordersCls.enabled)
            {
                return;
            }

            // Clear caches when a war is declared (affects contiguity through ally routes)
            if (__instance != null)
            {
                TIRegionStateExtensions.ClearRegionContiguityCacheForNation(__instance);
            }
        }
    }

    [HarmonyPatch(typeof(TINationState), "DeclareFullWar")]
    public static class Patch_DeclareFullWar
    {
        static void Postfix(TINationState __instance)
        {
            if (!CreepingBordersCls.enabled)
            {
                return;
            }

            // Clear caches when a full war is declared (affects contiguity through ally routes)
            if (__instance != null)
            {
                TIRegionStateExtensions.ClearRegionContiguityCacheForNation(__instance);
            }
        }
    }

    [HarmonyPatch(typeof(TINationState), "JoinWar")]
    public static class Patch_JoinWar
    {
        static void Postfix(TINationState __instance)
        {
            if (!CreepingBordersCls.enabled)
            {
                return;
            }

            // Clear caches when nation joins a war (affects ally-based contiguity)
            if (__instance != null)
            {
                TIRegionStateExtensions.ClearRegionContiguityCacheForNation(__instance);
            }
        }
    }

    [HarmonyPatch(typeof(TINationState), "WhitePeace")]
    public static class Patch_WhitePeace
    {
        static void Postfix(TINationState __instance)
        {
            if (!CreepingBordersCls.enabled)
            {
                return;
            }

            // Clear caches when peace is made (ally status may change, affecting contiguity)
            if (__instance != null)
            {
                TIRegionStateExtensions.ClearRegionContiguityCacheForNation(__instance);
            }
        }
    }

    [HarmonyPatch(typeof(TINationState), "InitiateAlliance")]
    public static class Patch_InitiateAlliance
    {
        static void Postfix(TINationState __instance, TINationState newAlly)
        {
            if (!CreepingBordersCls.enabled || __instance == null || newAlly == null)
            {
                return;
            }

            // Clear caches for both nations when alliance is formed (affects ally-based contiguity)
            TIRegionStateExtensions.ClearRegionContiguityCacheForNation(__instance);
            TIRegionStateExtensions.ClearRegionContiguityCacheForNation(newAlly);
        }
    }

    [HarmonyPatch(typeof(TINationState), "EndAlliance")]
    public static class Patch_EndAlliance
    {
        static void Postfix(TINationState __instance, TINationState nation)
        {
            if (!CreepingBordersCls.enabled || __instance == null || nation == null)
            {
                return;
            }

            // Clear caches for both nations when alliance ends (ally-based contiguity may be lost)
            TIRegionStateExtensions.ClearRegionContiguityCacheForNation(__instance);
            TIRegionStateExtensions.ClearRegionContiguityCacheForNation(nation);
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

            // C13: cultural composition block (values to 3 dp, 31-day trend).
            if (CulturalInertia.Enabled)
            {
                try
                {
                    var cultures = CulturalInertiaTrends.CurrentCultures(region);
                    if (cultures.Count > 0)
                    {
                        sb.AppendLine(Loc.T("UI.Region.Tooltip.Cultures"));
                        foreach (var kv in cultures)
                        {
                            string entry;
                            if (CulturalInertiaTrends.Trend(region, kv.Key, out float current, out float delta)
                                && Math.Abs(delta) >= 0.0005f)
                            {
                                // Vanilla tooltip accent colors (TIUtilities):
                                // green #85B260, red #B26A60. The color wraps the
                                // arrow+trend segment of the localized entry.
                                string color = delta > 0f ? "#85B260" : "#B26A60";
                                string entryKey = delta > 0f
                                    ? "UI.Region.Tooltip.CultureEntryGrowth"
                                    : "UI.Region.Tooltip.CultureEntryDecline";
                                string raw = Loc.T(entryKey, CulturalInertiaTrends.DisplayName(kv.Key),
                                    kv.Value.ToString("F3"), Math.Abs(delta).ToString("F3"));
                                int marker = raw.IndexOf(kv.Value.ToString("F3"), StringComparison.Ordinal);
                                entry = marker >= 0
                                    ? raw.Substring(0, marker + kv.Value.ToString("F3").Length)
                                      + $"<color={color}>" + raw.Substring(marker + kv.Value.ToString("F3").Length)
                                      + $"</color>"
                                    : raw;
                            }
                            else
                            {
                                // No trend yet (fresh sample < 2 points) or flat:
                                // plain entry, no arrow, no color.
                                entry = Loc.T("UI.Region.Tooltip.CultureEntry",
                                    CulturalInertiaTrends.DisplayName(kv.Key), kv.Value.ToString("F3"));
                            }
                            sb.AppendLine(entry);
                        }
                    }
                }
                catch (Exception ex)
                {
                    CreepingBordersCls.mod?.Logger.Error(
                        $"[CulturalInertia] Tooltip culture block error: {ex.Message}");
                }
            }

            __result = sb.ToString();
        }
    }

    // ====================================================================
    // HARMONY PATCHES - POLICY SYSTEM
    // ====================================================================

    // ====================================================================
    // HARMONY PATCH - POLICY OPTION REGISTRATION (data source, not UI)
    // ====================================================================

    /// <summary>
    /// Registers the mod's policy options (Set Capital, Legitimise Claim) in
    /// PolicyManager.policies, exactly like vanilla Initialize does. Every UI
    /// surface (notification popup, nation info panel) reads that dictionary, so
    /// registering here makes the options appear everywhere with zero UI patches.
    /// The options get synthetic PolicyType keys so they can never collide with
    /// vanilla enum values or fall into vanilla switch/filter logic (e.g. the
    /// CancelOption exclusions in CodexController and NotificationScreenController).
    /// </summary>
    [HarmonyPatch(typeof(PolicyManager), "Initialize")]
    public static class Patch_RegisterPolicyOptions
    {
        public static readonly PolicyType SetCapitalType = (PolicyType)1001;
        public static readonly PolicyType LegitimiseClaimType = (PolicyType)1002;

        static void Postfix()
        {
            try
            {
                // TIPolicyOption's ctor sets dataName = GetType().ToString() and
                // caches the display name, so the base-class text methods resolve
                // the existing Loc keys (CreepingBorders.<ClassName>.*) for free.
                PolicyManager.policies.Add(SetCapitalType, new RegionSelectorPlaceholder());
                PolicyManager.policies.Add(LegitimiseClaimType, new LegitimiseClaimOption());
            }
            catch (Exception ex)
            {
                CreepingBordersCls.mod.Logger.Error($"[PolicyRegistration] ERROR registering options: {ex.Message}");
            }
        }
    }

    /// <summary>
    /// Region selector policy option that sets the nation's capital to the selected region
    /// </summary>
    public class RegionSelectorPlaceholder : TIPolicyOption
    {
        public override PolicyType GetPolicyType()
        {
            // Synthetic value so vanilla filters/switches on vanilla enum values never touch us
            return Patch_RegisterPolicyOptions.SetCapitalType;
        }

        public override bool Allowed(TINationState nation)
        {
            // Option shows in the list but is disabled (greyed out, like vanilla federation/unification)
            // when the executive faction cannot afford the influence cost.
            return nation != null && nation.extant && nation.regions != null && nation.regions.Count > 0
                && CreepingBordersCls.CanAffordInfluence(nation);
        }

        public override IList<TIGameState> GetPossibleTargets(TINationState policyNation)
        {
            // Return the nation's regions as possible targets (excluding hostile regions)
            if (policyNation == null || policyNation.regions == null)
            {
                return new List<TIGameState>();
            }

            // Sort alphabetically by region display name for a stable, readable list
            var validRegions = policyNation.regions
                .Where(region => region != null && (policyNation.hostileClaims == null || !policyNation.hostileClaims.Contains(region)))
                .OrderBy(region => region.displayName, StringComparer.CurrentCulture)
                .Cast<TIGameState>()
                .ToList();

            if (CreepingBordersCls.Settings.EnableDebugLogging)
            {
                CreepingBordersCls.mod.Logger.Log($"[RegionSelector] GetPossibleTargets: {policyNation.displayName} has {policyNation.regions.Count} regions, {validRegions.Count} are valid (non-hostile)");
            }

            return validRegions;
        }

        public override void OnPassage(TINationState enactingNation, TIGameState policyTarget)
        {
            // Set the selected region as the nation's capital
            if (enactingNation == null || policyTarget == null)
            {
                if (CreepingBordersCls.Settings.EnableDebugLogging)
                {
                    CreepingBordersCls.mod.Logger.Log($"[RegionSelector] OnPassage: Invalid input - enactingNation={enactingNation}, policyTarget={policyTarget}");
                }
                return;
            }

            // Ensure policyTarget is a region
            var targetRegion = policyTarget as TIRegionState;
            if (targetRegion == null)
            {
                if (CreepingBordersCls.Settings.EnableDebugLogging)
                {
                    CreepingBordersCls.mod.Logger.Log($"[RegionSelector] OnPassage: policyTarget is not a TIRegionState");
                }
                return;
            }

            // Ensure the target region belongs to this nation
            if (targetRegion.nation != enactingNation)
            {
                if (CreepingBordersCls.Settings.EnableDebugLogging)
                {
                    CreepingBordersCls.mod.Logger.Log($"[RegionSelector] OnPassage: Target region {targetRegion.displayName} belongs to {targetRegion.nation?.displayName}, not {enactingNation.displayName}");
                }
                return;
            }

            // Check if this is a hostile region - should not happen but log if it does
            if (enactingNation.hostileClaims != null && enactingNation.hostileClaims.Contains(targetRegion))
            {
                if (CreepingBordersCls.Settings.EnableDebugLogging)
                {
                    CreepingBordersCls.mod.Logger.Log($"[RegionSelector] OnPassage: Cannot set hostile region {targetRegion.displayName} as capital");
                }
                return;
            }

            // Set the target region as the nation's capital
            enactingNation.SetCapital(targetRegion);

            // Deduct influence cost (90 influence)
            const float INFLUENCE_COST = CreepingBordersCls.INFLUENCE_COST;
            TIFactionState executiveFaction = enactingNation.executiveFaction;
            if (executiveFaction != null)
            {
                executiveFaction.AddToCurrentResource(-INFLUENCE_COST, FactionResource.Influence, false, null);
            }

            if (CreepingBordersCls.Settings.EnableDebugLogging)
            {
                CreepingBordersCls.mod.Logger.Log($"[RegionSelector] ✓ {enactingNation.displayName} set capital to {targetRegion.displayName} (cost: {INFLUENCE_COST} influence)");
            }
        }

        public override int Importance(TINationState policyNation, TIGameState target)
        {
            return 0;
        }
    }

    /// <summary>
    /// Policy option that converts hostile claims to friendly claims
    /// </summary>
    public class LegitimiseClaimOption : TIPolicyOption
    {
        public override PolicyType GetPolicyType()
        {
            // Synthetic value so vanilla filters/switches on vanilla enum values never touch us
            return Patch_RegisterPolicyOptions.LegitimiseClaimType;
        }


        public override bool Allowed(TINationState nation)
        {
            // With Cultural Inertia enabled, claim conversion is handled
            // organically by the C13 claims engine — the policy option is
            // hidden and disabled so it never appears in any nation's list.
            if (CulturalInertia.Enabled) return false;

            if (CreepingBordersCls.Settings.EnableDebugLogging)
            {
                CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] Allowed() called for nation={nation?.displayName ?? "null"}");
            }

            bool isAllowed = nation != null && nation.extant && nation.hostileClaims != null && nation.hostileClaims.Count > 0
                && CreepingBordersCls.CanAffordInfluence(nation);

            if (CreepingBordersCls.Settings.EnableDebugLogging)
            {
                if (nation == null)
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] Allowed() returning false: nation is null");
                else if (!nation.extant)
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] Allowed() returning false: nation not extant ({nation.displayName})");
                else if (nation.hostileClaims == null)
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] Allowed() returning false: hostileClaims is null ({nation.displayName})");
                else if (nation.hostileClaims.Count == 0)
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] Allowed() returning false: no hostile claims ({nation.displayName})");
                else
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] Allowed() returning true: {nation.displayName} has {nation.hostileClaims.Count} hostile claims");
            }

            return isAllowed;
        }

        public override IList<TIGameState> GetPossibleTargets(TINationState policyNation)
        {
            if (CreepingBordersCls.Settings.EnableDebugLogging)
            {
                CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] ===== GetPossibleTargets() STARTED =====");
                CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] policyNation={policyNation?.displayName ?? "null"}");
            }

            // Return only hostile claims on OTHER nations' regions (not on own regions)
            if (policyNation == null || policyNation.hostileClaims == null)
            {
                if (CreepingBordersCls.Settings.EnableDebugLogging)
                {
                    if (policyNation == null)
                        CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] GetPossibleTargets: policyNation is null - returning empty list");
                    else
                        CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] GetPossibleTargets: {policyNation.displayName} has null hostileClaims - returning empty list");
                }
                return new List<TIGameState>();
            }

            if (CreepingBordersCls.Settings.EnableDebugLogging)
            {
                CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] Found {policyNation.hostileClaims.Count} total hostile claims for {policyNation.displayName}");
                foreach (var claim in policyNation.hostileClaims)
                {
                    string claimInfo = claim?.displayName ?? "null";
                    string claimNation = claim?.nation?.displayName ?? "null";
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim]   - Claim: {claimInfo} (owned by {claimNation})");
                }
            }

            // Sort first by owner nation name, then by region name, both alphabetically
            var otherNationsHostileClaims = policyNation.hostileClaims
                .Where(region => region != null && region.nation != policyNation)
                .OrderBy(region => region.nation != null ? region.nation.displayName : string.Empty, StringComparer.CurrentCulture)
                .ThenBy(region => region.displayName, StringComparer.CurrentCulture)
                .Cast<TIGameState>()
                .ToList();

            if (CreepingBordersCls.Settings.EnableDebugLogging)
            {
                CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] After filtering: {otherNationsHostileClaims.Count} claims on other nations");
                foreach (var claim in otherNationsHostileClaims)
                {
                    var claimRegion = claim as TIRegionState;
                    string claimInfo = claimRegion?.displayName ?? claim?.displayName ?? "unknown";
                    string claimNation = claimRegion?.nation?.displayName ?? "null";
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim]   - Valid claim: {claimInfo} (owned by {claimNation})");
                }
                CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] ===== GetPossibleTargets() COMPLETED =====");
            }

            return otherNationsHostileClaims;
        }

        public override void OnPassage(TINationState enactingNation, TIGameState policyTarget)
        {
            if (CreepingBordersCls.Settings.EnableDebugLogging)
            {
                CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] ===== OnPassage() STARTED =====");
                CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] enactingNation={enactingNation?.displayName ?? "null"}");
                CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] policyTarget={policyTarget?.displayName ?? "null"}");
            }

            // Convert the hostile claim to a friendly claim
            if (enactingNation == null || policyTarget == null)
            {
                if (CreepingBordersCls.Settings.EnableDebugLogging)
                {
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] ✗ VALIDATION FAILED: Invalid input");
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim]   enactingNation={enactingNation?.displayName ?? "null"}");
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim]   policyTarget={policyTarget?.displayName ?? "null"}");
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] ===== OnPassage() ABORTED (null inputs) =====");
                }
                return;
            }

            // Ensure policyTarget is a region
            var targetRegion = policyTarget as TIRegionState;
            if (targetRegion == null)
            {
                if (CreepingBordersCls.Settings.EnableDebugLogging)
                {
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] ✗ VALIDATION FAILED: policyTarget is not a TIRegionState");
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim]   policyTarget type: {policyTarget.GetType().Name}");
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] ===== OnPassage() ABORTED (wrong type) =====");
                }
                return;
            }

            if (CreepingBordersCls.Settings.EnableDebugLogging)
            {
                CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] ✓ Cast to TIRegionState successful: {targetRegion.displayName}");
                CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] targetRegion.nation={targetRegion.nation?.displayName ?? "null"}");
            }

            // Ensure this is actually a hostile claim on another nation's region
            if (!enactingNation.hostileClaims.Contains(targetRegion))
            {
                if (CreepingBordersCls.Settings.EnableDebugLogging)
                {
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] ✗ VALIDATION FAILED: Region not in hostile claims");
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim]   {enactingNation.displayName}.hostileClaims.Contains({targetRegion.displayName}) = false");
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim]   Available claims for {enactingNation.displayName}: {enactingNation.hostileClaims.Count}");
                    foreach (var claim in enactingNation.hostileClaims)
                    {
                        CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim]     - {claim?.displayName ?? "null"}");
                    }
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] ===== OnPassage() ABORTED (not in claims) =====");
                }
                return;
            }

            if (CreepingBordersCls.Settings.EnableDebugLogging)
            {
                CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] ✓ Region is in hostile claims list");
            }

            // Ensure the target region belongs to a different nation
            if (targetRegion.nation == enactingNation)
            {
                if (CreepingBordersCls.Settings.EnableDebugLogging)
                {
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] ✗ VALIDATION FAILED: Cannot legitimise claim on own region");
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim]   targetRegion.nation ({targetRegion.nation.displayName}) == enactingNation ({enactingNation.displayName})");
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] ===== OnPassage() ABORTED (own region) =====");
                }
                return;
            }

            if (CreepingBordersCls.Settings.EnableDebugLogging)
            {
                CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] ✓ Region belongs to different nation ({targetRegion.nation.displayName})");
                CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] --- All validations passed, proceeding with action ---");
            }

            // Convert the hostile claim to a friendly claim
            if (CreepingBordersCls.Settings.EnableDebugLogging)
            {
                CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] Calling RemoveHostileClaim({targetRegion.displayName})...");
            }

            enactingNation.RemoveHostileClaim(targetRegion);

            if (CreepingBordersCls.Settings.EnableDebugLogging)
            {
                CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] ✓ RemoveHostileClaim() completed successfully");
                bool stillInClaims = enactingNation.hostileClaims.Contains(targetRegion);
                CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim]   Region still in hostile claims: {stillInClaims}");
                CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim]   Remaining hostile claims for {enactingNation.displayName}: {enactingNation.hostileClaims.Count}");
            }

            // Deduct influence cost (90 influence)
            const float INFLUENCE_COST = CreepingBordersCls.INFLUENCE_COST;
            TIFactionState executiveFaction = enactingNation.executiveFaction;

            if (CreepingBordersCls.Settings.EnableDebugLogging)
            {
                CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] Attempting influence deduction...");
                CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim]   INFLUENCE_COST = {INFLUENCE_COST}");
                CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim]   executiveFaction = {executiveFaction?.displayName ?? "null"}");
                if (executiveFaction != null)
                {
                    float currentInfluence = executiveFaction.GetCurrentResourceAmount(FactionResource.Influence);
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim]   Current influence before deduction: {currentInfluence}");
                }
            }

            if (executiveFaction != null)
            {
                executiveFaction.AddToCurrentResource(-INFLUENCE_COST, FactionResource.Influence, false, null);

                if (CreepingBordersCls.Settings.EnableDebugLogging)
                {
                    float influenceAfter = executiveFaction.GetCurrentResourceAmount(FactionResource.Influence);
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] ✓ Influence deduction completed");
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim]   Influence after deduction: {influenceAfter}");
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim]");
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] ========================================");
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] ✓✓✓ ACTION COMPLETED SUCCESSFULLY ✓✓✓");
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] ========================================");
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] {enactingNation.displayName} legitimised hostile claim on {targetRegion.displayName}");
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] Cost: {INFLUENCE_COST} influence");
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] ========================================");
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] ===== OnPassage() COMPLETED =====");
                }
            }
            else
            {
                if (CreepingBordersCls.Settings.EnableDebugLogging)
                {
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] ⚠ WARNING: No executive faction found for {enactingNation.displayName}");
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim]   Influence cost NOT deducted!");
                    CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] ===== OnPassage() COMPLETED (with warning) =====");
                }
            }
        }

                public override int Importance(TINationState policyNation, TIGameState target)
                {
                    if (CreepingBordersCls.Settings.EnableDebugLogging)
                    {
                        CreepingBordersCls.mod.Logger.Log($"[LegitimiseClaim] Importance() called for nation={policyNation?.displayName ?? "null"}, target={target?.displayName ?? "null"} - returning 0");
                    }
                    return 0;
                }
            }

    }
