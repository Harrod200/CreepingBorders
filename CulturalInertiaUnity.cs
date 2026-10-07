using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using PavonisInteractive.TerraInvicta;

namespace CreepingBorders
{
    /// <summary>
    /// C13 Cultural Inertia — Unity completion engine.
    ///
    /// Replaces vanilla Unity priority behaviour when the Cultural Inertia
    /// master toggle is on (replacing prefix).
    ///
    /// Handover §3.2–3.3:
    ///   Daily Unity IP = GDP_B^0.35 × 1.0 × 12/365.2422 (vanilla economyScore);
    ///   flat 2 IP per completion (vanilla behaviour unchanged).
    ///   Per completion:
    ///   - Defensive stance: OwnedDefensiveBudget + OwnedOffensiveBudget (1.0%)
    ///     of composition spread over owned regions, inverse-population split.
    ///     Free (no influence), zero unowned spread.
    ///   - Offensive stance: OwnedOffensiveBudget (0.5%) on owned regions,
    ///     UnownedOffensiveBudget (0.5%) on the unowned spread:
    ///     adjacency ∪ island-range of owned regions; ally regions null-weighted,
    ///     non-rival × NeutralNationWeight, rival ×1.0.
    ///     Cost = InfluenceCostPer100M × (affected foreign pop / 100M),
    ///     paid proportionally by the nation's control-point factions,
    ///     ALL-OR-NOTHING: failure = owned budget only, no deduction.
    ///   - Occupation: owner's defensive spread skips occupied regions; its
    ///     offensive budget still targets them (toward owner culture, ×0.5).
    ///     Occupier delivering culture does so at ×0.5 strength with full
    ///     pop dilution cost.
    /// </summary>
    public static class CulturalInertiaUnity
    {
        public enum UnityStance { Defensive, Offensive }

        private static readonly Dictionary<string, UnityStance> _stances
            = new Dictionary<string, UnityStance>();

        public static UnityStance StanceOf(TIFactionState faction)
        {
            if (faction == null)
                return CreepingBordersCls.Settings.UnityDefaultStanceDefensive
                    ? UnityStance.Defensive : UnityStance.Offensive;
            if (_stances.TryGetValue(faction.ID.ToString(), out var s)) return s;
            return CreepingBordersCls.Settings.UnityDefaultStanceDefensive
                ? UnityStance.Defensive : UnityStance.Offensive;
        }

        public static void SetStance(TIFactionState faction, UnityStance stance)
        {
            if (faction == null) return;
            _stances[faction.ID.ToString()] = stance;
        }

        /// <summary>
        /// The culture a faction promotes: the state culture of the nation
        /// whose executive control point it holds; fallback = the nation with
        /// the most control points it holds; fallback null.
        /// </summary>
        public static string CultureOfFaction(TIFactionState faction)
        {
            if (faction == null) return null;
            try
            {
                var execNation = GameStateManager.AllNations().FirstOrDefault(n =>
                    n != null && n.executiveFaction == faction);
                if (execNation != null) return CulturalInertia.CultureOfNation(execNation);
                var counts = new Dictionary<TINationState, int>();
                foreach (var n in GameStateManager.AllNations())
                {
                    if (n?.controlPoints == null) continue;
                    int held = n.controlPoints.Count(cp => cp != null && cp.faction == faction);
                    if (held > 0) counts[n] = held;
                }
                var best = counts.OrderByDescending(kv => kv.Value).FirstOrDefault().Key;
                return best == null ? null : CulturalInertia.CultureOfNation(best);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Handles one Unity completion for a nation. The vanilla completion
        /// is suppressed by the prefix patch when the mod is enabled.
        /// </summary>
        public static void RunCompletion(TINationState nation)
        {
            if (!CulturalInertia.Enabled || nation == null) return;
            try
            {
                var settings = CreepingBordersCls.Settings;
                var regions = new List<TIRegionState>(nation.regions ?? new List<TIRegionState>());
                if (regions.Count == 0) return;

                // --- Ownership audit ---------------------------------
                TIFactionState executive = nation.executiveFaction;
                var owned = new List<TIRegionState>();      // owner-controlled
                var occupiedByOthers = new List<TIRegionState>(); // owner's, occupied by another faction
                var occupiedByUs = new List<TIRegionState>();     // regions we occupy (leadOccupier == this nation)
                foreach (var region in regions)
                {
                    if (region == null) continue;
                    bool occupiedNow = false;
                    try
                    {
                        occupiedNow = region.OccupiedOrOccupationUnderway();
                    }
                    catch (Exception) { occupiedNow = false; }
                    if (occupiedNow) occupiedByOthers.Add(region);
                    else owned.Add(region);
                }
                if (owned.Count == 0 && occupiedByOthers.Count == 0) return;

                // Regions we occupy (leadOccupier is a nation of ours).
                foreach (var all in GameStateManager.AllRegions())
                {
                    if (all == null) continue;
                    try
                    {
                        if (all.leadOccupier == nation && all.nation != nation)
                            occupiedByUs.Add(all);
                    }
                    catch (Exception) { }
                }

                UnityStance stance = StanceOf(executive);

                float defTotal = settings.OwnedDefensiveBudget;
                float offOwned = settings.OwnedOffensiveBudget;
                float offUnowned = settings.UnownedOffensiveBudget;

                if (stance == UnityStance.Defensive)
                {
                    // Both budgets rolled into the defensive spread; no unowned spread.
                    SpreadOwned(nation, owned, defTotal + offOwned, strengthScale: 1f);
                }
                else
                {
                    SpreadOwned(nation, owned, offOwned, strengthScale: 1f);
                    SpreadUnowned(nation, owned, occupiedByOthers, occupiedByUs, offUnowned);
                }

                CulturalInertia.DebugLog(
                    $"[C13] Unity completion {nation.displayName}: stance {stance}, def {defTotal + (stance == UnityStance.Defensive ? offOwned : 0f):F2}%, offOwned {offOwned:F2}%, offUnowned {offUnowned:F2}%.");
            }
            catch (Exception e)
            {
                CulturalInertia.DebugLog($"[C13] RunCompletion error: {e.Message}");
            }
        }

        // ------------------------------------------------------------------
        // Owned spread: inverse-population split toward the owner culture.
        // ------------------------------------------------------------------
        private static void SpreadOwned(TINationState nation, List<TIRegionState> regions,
            float budgetPct, float strengthScale)
        {
            if (regions.Count == 0 || budgetPct <= 0f) return;
            string ownerCulture = CulturalInertia.CultureOfNation(nation);
            if (string.IsNullOrEmpty(ownerCulture)) return;

            float invSum = 0f;
            foreach (var r in regions)
            {
                float pop = Mathf.Max(1f, r.populationInMillions);
                invSum += 1f / pop;
            }
            if (invSum <= 0f) return;

            foreach (var r in regions)
            {
                float pop = Mathf.Max(1f, r.populationInMillions);
                float share = budgetPct * ((1f / pop) / invSum);
                CulturalInertia.NudgeComposition(r, ownerCulture, share * strengthScale);
            }
        }

        // ------------------------------------------------------------------
        // Unowned spread: adjacency ∪ island-range targets, ally null-weight,
        // non-rival × NeutralNationWeight, rival ×1.0. Costed, all-or-nothing.
        // ------------------------------------------------------------------
        private static void SpreadUnowned(TINationState nation,
            List<TIRegionState> owned, List<TIRegionState> occupiedByOthers,
            List<TIRegionState> occupiedByUs, float budgetPct)
        {
            if (budgetPct <= 0f) return;
            var settings = CreepingBordersCls.Settings;
            string ownerCulture = CulturalInertia.CultureOfNation(nation);
            if (string.IsNullOrEmpty(ownerCulture)) return;

            var candidates = new Dictionary<TIRegionState, float>(); // region -> weight
            var seen = new HashSet<string>();

            // Adjacency from owned regions.
            foreach (var r in owned)
                foreach (var nb in NeighborRegions(r))
                    if (nb != null && seen.Add(nb.ID.ToString())) candidates[nb] = 1f;

            // Island range from owned regions (DistanceToRegion_km is cached).
            float islandKm = settings.IslandRangeKm;
            if (islandKm > 0f)
            {
                foreach (var all in GameStateManager.AllRegions())
                {
                    if (all == null) continue;
                    bool inRange = false;
                    foreach (var r in owned)
                    {
                        try { if (r.DistanceToRegion_km(all) <= islandKm) { inRange = true; break; } }
                        catch (Exception) { }
                    }
                    if (inRange && seen.Add(all.ID.ToString())) candidates[all] = 1f;
                }
            }

            // Exclude own regions and regions already owned-side.
            foreach (var kv in candidates.Where(kv => kv.Key.nation == nation || owned.Contains(kv.Key)).ToList())
                candidates.Remove(kv.Key);

            // Regions we occupy are always valid offensive targets (§3.6).
            var halfStrength = new HashSet<string>();
            foreach (var occ in occupiedByUs)
            {
                if (occ == null || occ.nation == nation) continue;
                if (!candidates.ContainsKey(occ)) candidates[occ] = 0.5f;
                halfStrength.Add(occ.ID.ToString());
            }

            if (candidates.Count == 0) return;

            // Weighting: allies null-weighted, non-rival × NeutralNationWeight.
            var finalTargets = new List<(TIRegionState region, float weight)>();
            foreach (var kv in candidates)
            {
                var targetNation = kv.Key.nation;
                if (targetNation == null) continue;
                if (targetNation == nation) continue;
                if (IsAllied(nation, targetNation)) continue; // null weight
                // Regions WE occupy skip the neutrality weighting (§3.6).
                if (occupiedByUs.Contains(kv.Key)) { finalTargets.Add((kv.Key, 1f)); continue; }
                float w = IsRival(nation, targetNation) ? 1f : settings.NeutralNationWeight;
                if (w <= 0f) continue;
                finalTargets.Add((kv.Key, w));
            }

            // Owner's occupied regions: offensive budget still targets them,
            // toward owner culture at ×0.5, costed like foreign spread.
            foreach (var region in occupiedByOthers)
                CulturalInertia.NudgeComposition(region, ownerCulture, budgetPct * 0.5f);

            if (finalTargets.Count == 0) return;

            // Affected foreign pop for influence cost — full pop dilution,
            // including our own occupied regions (§3.6).
            float affectedPop = 0f;
            foreach (var (region, weight) in finalTargets)
                affectedPop += Mathf.Max(0f, region.populationInMillions) * weight;
            float cost = affectedPop / 100f * settings.InfluenceCostPer100M;

            if (cost > 0f)
            {
                if (!PayInfluence(nation, cost, null))
                    return; // all-or-nothing: only owned budget landed (already applied)
            }

            // Distribute unowned budget inverse-pop among weighted targets.
            float wSum = finalTargets.Sum(t => t.weight);
            if (wSum <= 0f) return;

            foreach (var (region, weight) in finalTargets)
            {
                // Occupier delivers its culture at ×½ strength (§3.6);
                // the original owner pushes its culture back at full strength.
                bool weOccupy = halfStrength.Contains(region.ID.ToString());
                float strength = weOccupy ? 0.5f : 1f;
                float share = budgetPct * (weight / wSum) * strength;
                CulturalInertia.NudgeComposition(region, ownerCulture, share);
            }
        }

        private static bool IsAllied(TINationState a, TINationState b)
        {
            if (a == null || b == null) return false;
            try { return a.allies.Contains(b); }
            catch (Exception) { return false; }
        }

        private static bool IsRival(TINationState owner, TINationState target)
        {
            if (owner == null || target == null) return false;
            try { return owner.enemies.Contains(target); }
            catch (Exception) { return false; }
        }

        private static IEnumerable<TIRegionState> NeighborRegions(TIRegionState region)
        {
            var result = new List<TIRegionState>();
            if (region?.Neighbors == null) return result;
            foreach (var n in region.Neighbors)
                if (n != null) result.Add(n);
            return result;
        }

        // ------------------------------------------------------------------
        // Influence payment: proportional across the nation's CP factions,
        // all-or-nothing. Returns false without deducting if anyone can't pay.
        // ------------------------------------------------------------------
        public static bool PayInfluence(TINationState nation, float totalCost, TIFactionState completingFaction)
        {
            if (nation == null || totalCost <= 0f) return true;
            var cps = nation.controlPoints;
            if (cps == null || cps.Count == 0) return true;
            var payers = new Dictionary<TIFactionState, float>();
            foreach (var cp in cps)
            {
                if (cp == null || cp.faction == null) continue;
                payers[cp.faction] = payers.TryGetValue(cp.faction, out float v) ? v + 1f : 1f;
            }
            if (payers.Count == 0) return true; // nobody to charge

            int totalCps = Mathf.RoundToInt(payers.Values.Sum());
            if (totalCps == 0) return true;
            var charges = new List<(TIFactionState faction, float amount)>();
            foreach (var pair in payers)
                charges.Add((pair.Key, totalCost * (pair.Value / totalCps)));

            foreach (var (faction, amount) in charges)
            {
                if (faction.GetCurrentResourceAmount(FactionResource.Influence) < amount)
                    return false;
            }
            foreach (var (faction, amount) in charges)
                faction.AddToCurrentResource(-amount, FactionResource.Influence, false, null);
            return true;
        }

        // ------------------------------------------------------------------
        // Focused Outreach (handover §3.3): one foreign claimable region per
        // nation. Full Unity budget lands on the single target. Cost =
        // InfluenceCostPer100M × target pop / 100M, all-or-nothing.
        // Called by the AI outreach tick / player action.
        // ------------------------------------------------------------------
        public static void OnOutreachCompleted(TIFactionState faction, TIRegionState targetRegion)
        {
            if (!CulturalInertia.Enabled || faction == null || targetRegion == null) return;
            try
            {
                var settings = CreepingBordersCls.Settings;
                string culture = CultureOfFaction(faction);
                if (string.IsNullOrEmpty(culture)) return;

                var ownerNation = targetRegion.nation;
                float pop = Mathf.Max(0f, targetRegion.populationInMillions);
                float cost = pop / 100f * settings.InfluenceCostPer100M;
                if (cost > 0f)
                {
                    // Charge the faction's home nation CPs proportionally.
                    var homeNation = GameStateManager.AllNations().FirstOrDefault(n =>
                        n != null && n.executiveFaction == faction);
                    if (!PayInfluence(homeNation, cost, faction)) return;
                }
                float budget = settings.OwnedDefensiveBudget + settings.OwnedOffensiveBudget;
                CulturalInertia.NudgeComposition(targetRegion, culture, budget);
                CulturalInertia.DebugLog($"[C13] Outreach by {faction.displayName} on {targetRegion.displayName}: +{budget:F2}% {culture}.");
            }
            catch (Exception e)
            {
                CulturalInertia.DebugLog($"[C13] OnOutreachCompleted error: {e.Message}");
            }
        }

        // ------------------------------------------------------------------
        // Claimability gate for Outreach targets (adjacent or island range,
        // occupied regions are valid targets).
        // ------------------------------------------------------------------
        public static bool IsClaimableTarget(TIFactionState faction, TIRegionState target)
        {
            if (faction == null || target == null) return false;
            try
            {
                float islandKm = CreepingBordersCls.Settings.IslandRangeKm;
                foreach (var n in GameStateManager.AllNations())
                {
                    if (n == null || n.executiveFaction != faction) continue;
                    foreach (var owned in n.regions)
                    {
                        if (owned == null) continue;
                        if (owned.Neighbors != null && owned.Neighbors.Contains(target)) return true;
                        if (islandKm > 0f)
                        {
                            try { if (owned.DistanceToRegion_km(target) <= islandKm) return true; }
                            catch (Exception) { }
                        }
                    }
                }
            }
            catch (Exception) { }
            return false;
        }
    }
}
