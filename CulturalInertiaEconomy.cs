using System;
using System.Collections.Generic;
using HarmonyLib;
using UnityEngine;
using PavonisInteractive.TerraInvicta;

namespace CreepingBorders
{
    /// <summary>
    /// C13 Cultural Inertia — economy layer (handover §7).
    /// Effective population: foreign populace counts ×0.3 in beneficial
    /// effects (research, economy, priority pop scaling) and ×1.3 in
    /// detriments (cohesion impact). Composition-weighted; falls back to
    /// vanilla weights (×1.0 everywhere) when no composition data exists.
    /// </summary>
    public static class CulturalInertiaEconomy
    {
        public static bool Active => CreepingBordersCls.enabled && CreepingBordersCls.Settings.EnableCulturalInertia;

        /// <summary>
        /// Weighted/actual population ratio for a nation. benign=true uses the
        /// beneficial foreign weight, false the detriment weight.
        /// </summary>
        public static float PopWeightRatio(TINationState nation, bool benign)
        {
            if (!Active || nation == null || nation.regions == null || nation.regions.Count == 0) return 1f;
            float weight = benign ? CreepingBordersCls.Settings.BeneficialForeignWeight
                                  : CreepingBordersCls.Settings.DetrimentForeignWeight;
            double actual = 0.0, effective = 0.0;
            string ownerCulture = CulturalInertia.CultureOfNation(nation);
            bool anyData = false;
            foreach (var region in nation.regions)
            {
                if (region == null) continue;
                double gdpProp = 1.0;
                try { gdpProp = region.NationalGDPProportion(); }
                catch (Exception) { gdpProp = 1.0 / nation.regions.Count; }
                float share = 1f;
                if (!string.IsNullOrEmpty(ownerCulture) &&
                    CulturalInertia.Composition(region).TryGetValue(ownerCulture, out float s))
                {
                    share = Mathf.Clamp01(s);
                    anyData = true;
                }
                double contrib = (double)region.populationInMillions * gdpProp;
                actual += contrib;
                effective += contrib * (share + (1f - share) * weight);
            }
            if (!anyData || actual <= 0.0) return 1f;
            return (float)(effective / actual);
        }

        // --------------------------------------------------------------
        // Harmony postfixes on the vanilla getters.
        // --------------------------------------------------------------

        [HarmonyPatch(typeof(TINationState), "get_research_month")]
        public static class Patch_ResearchMonth
        {
            static void Postfix(TINationState __instance, ref float __result)
            {
                if (!Active || __instance == null) return;
                __result *= PopWeightRatio(__instance, benign: true);
            }
        }

        [HarmonyPatch(typeof(TINationState), "get_economyScore")]
        public static class Patch_EconomyScore
        {
            static void Postfix(TINationState __instance, ref float __result)
            {
                if (!Active || __instance == null) return;
                __result *= PopWeightRatio(__instance, benign: true);
            }
        }

        [HarmonyPatch(typeof(TINationState), "get_priorityEffectPopScaling")]
        public static class Patch_PriorityEffectPopScaling
        {
            static void Postfix(TINationState __instance, ref float __result)
            {
                if (!Active || __instance == null) return;
                __result *= PopWeightRatio(__instance, benign: true);
            }
        }

        [HarmonyPatch(typeof(TINationState), "get_populationImpactOnCohesion")]
        public static class Patch_PopulationImpactOnCohesion
        {
            static void Postfix(TINationState __instance, ref float __result)
            {
                if (!Active || __instance == null) return;
                __result *= PopWeightRatio(__instance, benign: false);
            }
        }
    }
}
