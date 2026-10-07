using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using PavonisInteractive.TerraInvicta;

namespace CreepingBorders
{
    /// <summary>
    /// C13 Cultural Inertia — claims layer (handover §4).
    /// - Research-granted claims (active TIBilateralTemplate, relationType
    ///   Claim) are permanently friendly and immune to the hysteresis band.
    /// - Hostile/friendly classification of culture-claims flips through a
    ///   hysteresis band: hostile → friendly when the claimant culture reaches
    ///   ≥30% of the region pop, friendly → hostile below 25%.
    /// - Conversion seeds (all bump-only, invariant: capture never lowers the
    ///   capturer's share):
    ///     research-claim conversion → max(50%, current share)
    ///     unrecognised absorption  → max(50%, current share)  (in CulturalInertia.OnAbsorption)
    ///     breakaway founding       → 50/50
    ///     occupation liberation    → composition persists (no seed needed)
    /// </summary>
    public static class CulturalInertiaClaims
    {
        /// <summary>
        /// Per-nation Culture share of a region, or null when the region has no
        /// recorded composition (composition is per-nation-culture in the store).
        /// </summary>
        public static float? CultureShare(TIRegionState region, TINationState cultureNation)
        {
            if (region == null || cultureNation == null) return null;
            string culture = CulturalInertia.CultureOfNation(cultureNation);
            if (string.IsNullOrEmpty(culture)) return null;
            return CulturalInertia.Composition(region).TryGetValue(culture, out float v) ? v : 0f;
        }

        /// <summary>
        /// True when the claim from this nation on this region comes from an
        /// active TIBilateralTemplate (research/mission-granted) claim.
        /// </summary>
        public static bool IsResearchGrantedClaim(TIRegionState region, TINationState claimant)
        {
            if (region == null || claimant == null) return false;
            try
            {
                foreach (TIBilateralTemplate t in TemplateManager.IterateByClass<TIBilateralTemplate>(true))
                {
                    if (t == null) continue;
                    if (t.relationType == BilateralRelationType.Claim &&
                        t.regionState1 == region &&
                        t.nationState1 == claimant &&
                        t.BilateralIsActive())
                        return true;
                }
            }
            catch (Exception) { }
            return false;
        }

        /// <summary>
        /// Runs the hysteresis pass over all claims of the given nation (called
        /// from the daily tick and after conquest events).
        /// </summary>
        public static void UpdateClaims(TINationState nation)
        {
            if (nation == null || nation.alienNation) return;
            var s = CreepingBordersCls.Settings;
            float promote = Mathf.Clamp01(s.HostilePromoteThreshold); // ≥ 0.30 → friendly
            float demote = Mathf.Clamp01(s.HostileDemoteThreshold);  // < 0.25 → hostile

            // Friendly claims that should turn hostile.
            foreach (var region in nation.claims.ToList())
            {
                if (region == null || region.nation == nation) continue;
                if (nation.hostileClaims.Contains(region)) continue;
                if (IsResearchGrantedClaim(region, nation)) continue; // immune
                if (CulturalInertia.IsLegitimised(nation, region)) continue; // legitimised: acts like a researched claim
                float? share = CultureShare(region, nation);
                if (share.HasValue && share.Value < demote)
                {
                    nation.hostileClaims.AddUnique(region);
                }
            }

            // Hostile claims that should turn friendly.
            foreach (var region in nation.hostileClaims.ToList())
            {
                if (region == null) continue;
                if (IsResearchGrantedClaim(region, nation)) continue; // immune, stays hostile only if template says so
                float? share = CultureShare(region, nation);
                if (!share.HasValue || share.Value >= promote)
                {
                    nation.hostileClaims.Remove(region);
                }
            }
        }

        /// <summary>Update all nations (daily tick).</summary>
        public static void UpdateAll()
        {
            try
            {
                foreach (var n in GameStateManager.AllNations())
                {
                    if (n == null) continue;
                    UpdateClaims(n);
                }
            }
            catch (Exception) { }
        }

        // ------------------------------------------------------------------
        // Conversion seeds (handover §4).
        // ------------------------------------------------------------------

        /// <summary>
        /// Called when a nation captures a region in war. If the capture was
        /// enabled by a research-granted claim, the capturer's culture share
        /// seeds to max(50%, current). Plain conquest seeds 0% (bump-only,
        /// invariant: capture never lowers the capturer's share).
        /// </summary>
        public static void OnConquest(TIRegionState region, TINationState capturer)
        {
            if (region == null || capturer == null) return;
            if (!CreepingBordersCls.Settings.EnableCulturalInertia) return;
            float current = CultureShare(region, capturer) ?? 0f;
            if (IsResearchGrantedClaim(region, capturer))
            {
                float seed = Mathf.Max(CreepingBordersCls.Settings.ResearchClaimConversionFloor, current);
                if (seed > current)
                    CulturalInertia.NudgeComposition(region, CulturalInertia.CultureOfNation(capturer), seed - current);
            }
            // Plain conquest: no seed, composition persists (capture never lowers).
        }

        /// <summary>
        /// Called when a breakaway nation is founded. Its capital region's
        /// culture seeds 50/50 between the parent culture and the breakaway
        /// culture; other regions keep their composition.
        /// </summary>
        public static void OnBreakaway(TIRegionState capitalRegion, TINationState parent, TINationState breakaway)
        {
            if (capitalRegion == null || breakaway == null) return;
            if (!CreepingBordersCls.Settings.EnableCulturalInertia) return;
            float floor = Mathf.Clamp01(CreepingBordersCls.Settings.SecessionCultureFloor);
            float current = CultureShare(capitalRegion, breakaway) ?? 0f;
            float target = Mathf.Max(floor, current);
            if (target > current)
                CulturalInertia.NudgeComposition(capitalRegion,
                    CulturalInertia.CultureOfNation(breakaway), target - current);
        }
    }
}
