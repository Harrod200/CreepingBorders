using PavonisInteractive.TerraInvicta;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CreepingBorders
{
    /// <summary>
    /// Connectivity levels, strongest first. A region's level is the strongest
    /// link it has to its nation's capital.
    /// </summary>
    public enum ConnectivityLevel
    {
        Disconnected = 0,
        Distant = 1,
        Partial = 2,
        Full = 3,
        Capital = 4
    }

    /// <summary>
    /// Polygonal Region Connectivity Manager v2 (checkpoint C3).
    ///
    /// Fixpoint BFS from the nation capital over AdjacentRegions(false)
    /// (FullAdjacency + FriendlyCrossingOnly), with:
    ///  - distance-based Full/Partial levels gated by the C1/C2 border-distance cache,
    ///  - rival/at-war traversal blocking (only unclaimed or owned regions),
    ///  - island-bridge inheritance (islands grant continental regions contiguity —
    ///    the reversed-inheritance amendment),
    ///  - a cross-continental gate: two continental regions that are neither adjacent
    ///    nor island-bridged never become contiguous through distance-based levels
    ///    (Alaska–Kamchatka / Spain–Rabat cases).
    /// </summary>
    public static class PolygonalRegionConnectivityManager
    {
        // ---------------------------------------------------------------
        // Distance thresholds (multiples of X).
        // NOTE: exact numeric values were specified in the attached design
        // doc, which is not in the handover package. Defaults aligned with
        // the C1/C2 bbox filter (3X): FC within 1X, PC within 3X. Flagged
        // for confirmation with the owner.
        // ---------------------------------------------------------------
        /// <summary>X: the option claim distance (km).</summary>
        public const float X_km = 300f;

        /// <summary>Full-connectivity distance threshold, in multiples of X.</summary>
        public const float FullDistanceX = 1f;
        /// <summary>Partial-connectivity distance threshold, in multiples of X.</summary>
        public const float PartialDistanceX = 3f;

        /// <summary>Per-nation connectivity result.</summary>
        public class NationConnectivity
        {
            public readonly Dictionary<TIRegionState, ConnectivityLevel> Levels =
                new Dictionary<TIRegionState, ConnectivityLevel>();
            /// <summary>Regions at Partial or better (includes the capital).</summary>
            public readonly HashSet<TIRegionState> ConnectedRegions =
                new HashSet<TIRegionState>();
            /// <summary>Regions at Full or better (includes the capital).</summary>
            public readonly HashSet<TIRegionState> FullyContiguousRegions =
                new HashSet<TIRegionState>();

            public ConnectivityLevel GetLevel(TIRegionState region)
            {
                if (region == null) return ConnectivityLevel.Disconnected;
                return Levels.TryGetValue(region, out var lvl) ? lvl : ConnectivityLevel.Disconnected;
            }
        }

        private static readonly Dictionary<TINationState, NationConnectivity> cache =
            new Dictionary<TINationState, NationConnectivity>();
        private static bool cacheDirty = true;

        /// <summary>Invalidate cached connectivity; call when borders or adjacency change.</summary>
        public static void Invalidate()
        {
            cacheDirty = true;
        }

        /// <summary>
        /// Connectivity info for a nation, recomputed when stale.
        /// Returns null when the nation or its capital is null.
        /// </summary>
        public static NationConnectivity Get(TINationState nation)
        {
            if (nation == null || nation.capital == null) return null;
            if (!cacheDirty && cache.TryGetValue(nation, out var cached)) return cached;
            if (cacheDirty)
            {
                cache.Clear();
                cacheDirty = false;
            }
            var result = Compute(nation);
            cache[nation] = result;
            return result;
        }

        /// <summary>
        /// Core fixpoint computation. Levels only ever improve; a region whose level
        /// improved is re-enqueued so island-bridge inheritance propagates.
        /// </summary>
        private static NationConnectivity Compute(TINationState nation)
        {
            var result = new NationConnectivity();
            var capital = nation.capital;
            result.Levels[capital] = ConnectivityLevel.Capital;

            // Landmass bookkeeping, computed once per computation.
            var isIsland = new Dictionary<TIRegionState, bool>();
            var landmassId = new Dictionary<TIRegionState, object>();
            foreach (var region in GameStateManager.AllRegions())
            {
                if (region == null) continue;
                bool island = region.isIsland;
                isIsland[region] = island;
                landmassId[region] = island ? null : (object)region.GetLandmassType();
            }

            var frontier = new Queue<TIRegionState>();
            frontier.Enqueue(capital);

            while (frontier.Count > 0)
            {
                var current = frontier.Dequeue();
                var currentLevel = result.Levels[current];

                // ---- Pass A: adjacency traversal over AdjacentRegions(false). ----
                foreach (var neighbor in current.AdjacentRegions(false))
                {
                    if (neighbor == null) continue;
                    if (!CanTraverse(nation, neighbor)) continue;
                    // Adjacency is a physical border; the level passes through unchanged.
                    Propagate(result, frontier, neighbor, currentLevel);
                }

                // ---- Pass B: distance-based levels, gated by the C1/C2 cache. ----
                // Only regions at Partial or better can project distance connectivity.
                if (currentLevel >= ConnectivityLevel.Partial)
                {
                    foreach (var neighbor in GameStateManager.AllRegions())
                    {
                        if (neighbor == null || neighbor == current) continue;
                        if (!CanTraverse(nation, neighbor)) continue;

                        // Amendment gate: distance-based contiguity applies within a
                        // continent only. Cross-continental links must be island-bridged
                        // (Pass C) or geometrically adjacent (Pass A).
                        if (!IsSameLandmass(current, neighbor, isIsland, landmassId)) continue;

                        var dist = GeographicPolygonMath.GetRegionPairDistance(
                            current, neighbor, X_km, PartialDistanceX * X_km);
                        if (dist.result != PolygonDistanceResult.Known) continue;
                        if (dist.distanceKm > PartialDistanceX * X_km) continue;

                        var level = dist.distanceKm <= FullDistanceX * X_km
                            ? ConnectivityLevel.Full
                            : ConnectivityLevel.Partial;
                        Propagate(result, frontier, neighbor, level);
                    }
                }

                // ---- Pass C: island-bridge inheritance (reversed inheritance). ----
                // A connected island grants Partial contiguity to adjacent continental
                // regions — including across continents — and vice versa. This is the
                // only route by which two continental regions separated by sea become
                // connected through this manager.
                if (currentLevel >= ConnectivityLevel.Partial && isIsland[current])
                {
                    foreach (var neighbor in current.Neighbors)
                    {
                        if (neighbor == null || !CanTraverse(nation, neighbor)) continue;
                        if (isIsland[neighbor]) continue;
                        Propagate(result, frontier, neighbor, ConnectivityLevel.Partial);
                        if (currentLevel >= ConnectivityLevel.Full)
                        {
                            Propagate(result, frontier, neighbor, ConnectivityLevel.Full);
                        }
                    }
                }
            }

            // Derived sets.
            foreach (var kv in result.Levels)
            {
                if (kv.Value >= ConnectivityLevel.Partial) result.ConnectedRegions.Add(kv.Key);
                if (kv.Value >= ConnectivityLevel.Full) result.FullyContiguousRegions.Add(kv.Key);
            }

            return result;
        }

        /// <summary>Monotone propagation: only improvements are recorded and re-enqueued.</summary>
        private static void Propagate(
            NationConnectivity result,
            Queue<TIRegionState> frontier,
            TIRegionState region,
            ConnectivityLevel level)
        {
            if (level <= ConnectivityLevel.Disconnected) return;
            result.Levels.TryGetValue(region, out var existing);
            if (level > existing)
            {
                result.Levels[region] = level;
                frontier.Enqueue(region);
            }
        }

        /// <summary>
        /// Traversal gate: the region must be unclaimed or owned by this nation
        /// (rival/at-war blocking).
        /// </summary>
        private static bool CanTraverse(TINationState nation, TIRegionState region)
        {
            if (region == null) return false;
            return region.nation == null || region.nation == nation;
        }

        /// <summary>
        /// True when distance-based connectivity may link the two regions:
        /// same continental landmass, or at least one is an island (islands are
        /// handled by the island-bridge pass, which has its own gate).
        /// </summary>
        private static bool IsSameLandmass(
            TIRegionState a,
            TIRegionState b,
            Dictionary<TIRegionState, bool> isIsland,
            Dictionary<TIRegionState, object> landmassId)
        {
            if (isIsland[a] || isIsland[b]) return true;
            object idA = landmassId.TryGetValue(a, out var va) ? va : null;
            object idB = landmassId.TryGetValue(b, out var vb) ? vb : null;
            return idA != null && idA.Equals(idB);
        }

        /// <summary>Compact per-level distribution dump for logging.</summary>
        public static string DumpLevels(NationConnectivity nc)
        {
            var counts = new Dictionary<ConnectivityLevel, int>();
            foreach (var lvl in nc.Levels.Values)
            {
                counts.TryGetValue(lvl, out var c);
                counts[lvl] = c + 1;
            }
            return string.Join(", ", counts.OrderBy(kv => kv.Key).Select(kv => $"{kv.Key}: {kv.Value}"));
        }
    }
}
