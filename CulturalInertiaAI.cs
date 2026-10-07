using System;
using System.Collections.Generic;
using System.Linq;
using HarmonyLib;
using UnityEngine;
using PavonisInteractive.TerraInvicta;
using PavonisInteractive.TerraInvicta.Tasks;

namespace CreepingBorders
{
    /// <summary>
    /// C13 Cultural Inertia — AI layer (plan §10.2–§10.4).
    /// Stance AI: postfix on PeriodicNationUpdateTask, 14d cadence per nation.
    /// Outreach AI: postfix on AIDailyFactionPlanner, one focused Outreach
    /// per faction per cooldown (default 30d), gated by affordability and
    /// the §5 claimability gate.
    /// </summary>
    public static class CulturalInertiaAI
    {
        private static readonly Dictionary<string, float> outreachCooldownUntil =
            new Dictionary<string, float>();

        // ------------------------------------------------------------------
        // Stance AI (§10.2). Runs at the vanilla 14d nation cadence.
        // ------------------------------------------------------------------
        [HarmonyPatch(typeof(TINationState), "PeriodicNationUpdateTask")]
        public static class Patch_PeriodicNationUpdateTask
        {
            static void Postfix(TINationState __instance)
            {
                try
                {
                    if (!CulturalInertia.Enabled) return;
                    if (__instance == null || !__instance.extant) return;
                    var faction = __instance.executiveFaction;
                    if (faction == null) return;
                    TIFactionState humanFaction = null;
                    foreach (var f in GameStateManager.AllHumanFactions())
                        if (f != null && !f.player.isAI) { humanFaction = f; break; }
                    if (humanFaction != null && faction == humanFaction) return;

                    // once per 14-day cadence per faction
                    if (__instance.ID.GetHashCode() % 14 != GameStateManager.Time().daysInCampaign % 14) return;

                    DecideStance(faction);
                }
                catch (Exception e)
                {
                    CulturalInertia.DebugLog("[C13] stance AI error: " + e.Message);
                }
            }
        }

        static void DecideStance(TIFactionState faction)
        {
            var settings = CreepingBordersCls.Settings;
            bool losingCulture = false, occupied = false, atWar = false;
            foreach (var n in GameStateManager.AllNations())
            {
                if (n == null || !n.extant || n.executiveFaction != faction) continue;
                atWar |= (n.wars != null && n.wars.Count > 0);
                string culture = CulturalInertia.CultureOfNation(n);
                if (n.regions != null)
                {
                    foreach (var r in n.regions)
                    {
                        if (r == null) continue;
                        try { occupied |= r.OccupiedOrOccupationUnderway(); } catch (Exception) { }
                        float share;
                        CulturalInertia.Composition(r).TryGetValue(culture, out share);
                        if (share < settings.MinorityRuleThreshold) losingCulture = true;
                    }
                }
            }
            bool influenceWealthy =
                faction.GetCurrentResourceAmount(FactionResource.Influence) >
                settings.AiInfluenceBuffer;
            var stance = (losingCulture || occupied || (atWar && !influenceWealthy))
                ? CulturalInertiaUnity.UnityStance.Defensive
                : CulturalInertiaUnity.UnityStance.Offensive;
            if (CulturalInertiaUnity.StanceOf(faction) != stance)
            {
                CulturalInertiaUnity.SetStance(faction, stance);
                CulturalInertia.DebugLog($"[C13] AI stance {faction.displayName}: {stance}");
            }
        }

        // ------------------------------------------------------------------
        // Outreach AI (§10.3, §10.4). Daily postfix on AIDailyFactionPlanner.
        // ------------------------------------------------------------------
        [HarmonyPatch(typeof(AIDailyFactionPlanner), "Update")]
        public static class Patch_AIDailyFactionPlanner
        {
            static void Postfix()
            {
                try
                {
                    if (!CulturalInertia.Enabled) return;
                    foreach (var faction in GameStateManager.AllFactions())
                    {
                        if (faction == null || !faction.player.isAI) continue;
                        float now = GameStateManager.Time().daysInCampaign;
                        outreachCooldownUntil.TryGetValue(faction.ID.ToString(), out float until);
                        if (now < until) continue;
                        MaybeFocusOutreach(faction, now);
                    }
                }
                catch (Exception e)
                {
                    CulturalInertia.DebugLog("[C13] outreach AI error: " + e.Message);
                }
            }
        }

        static void MaybeFocusOutreach(TIFactionState faction, float nowDays)
        {
            var settings = CreepingBordersCls.Settings;
            string culture = CulturalInertiaUnity.CultureOfFaction(faction);
            if (string.IsNullOrEmpty(culture)) return;

            TIRegionState best = null;
            float bestScore = settings.AiOutreachMinScore;
            foreach (var nation in GameStateManager.AllNations())
            {
                if (nation == null || !nation.extant || nation.regions == null) continue;
                foreach (var region in nation.regions)
                {
                    if (region == null) continue;
                    if (!CulturalInertiaUnity.IsClaimableTarget(faction, region)) continue;

                    float score = 0f;
                    CulturalInertia.Composition(region).TryGetValue(culture, out float share);
                    score += share; // near-promote bonus: 25–30% band worth most
                    if (CulturalInertia.HasCarriedOverClaim(region, culture)) score += 0.15f;

                    // cost penalty scaled by influence
                    float pop = Mathf.Max(1f, region.populationInMillions);
                    float cost = pop / 100f * settings.InfluenceCostPer100M;
                    float influence = faction.GetCurrentResourceAmount(FactionResource.Influence);
                    score -= Mathf.Clamp01(cost / Mathf.Max(1f, influence));

                    if (score > bestScore) { bestScore = score; best = region; }
                }
            }
            if (best == null) return;
            CulturalInertiaUnity.OnOutreachCompleted(faction, best);
            outreachCooldownUntil[faction.ID.ToString()] =
                nowDays + settings.AiOutreachCooldownDays;
            CulturalInertia.DebugLog(
                $"[C13] AI outreach {faction.displayName} -> {best.displayName} (score {bestScore:F2}).");
        }
    }
}
