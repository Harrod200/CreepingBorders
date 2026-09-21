using HarmonyLib;
using PavonisInteractive.TerraInvicta;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityModManagerNet;

namespace CreepingBorders
{
    // ========================================================================
    // CULTURAL INERTIA & ASSIMILATION  (rev 8 implementation)
    //
    // Locked design parameters:
    //   * Seed on capture: 0%      — conquest never changes culture by itself;
    //                                only Unity completions and recognised
    //                                absorptions shift composition.
    //   * Cohesion malus           = (foreignShare * popWeight) * culturalMismatchMax
    //                                feeding the vanilla cohesion rest state.
    //   * Unity completions        — each completed Unity priority nudges every
    //                                owned region's composition toward the
    //                                nation's state culture.
    //   * Absorptions recognised   — a nation absorbed into another contributes
    //                                its culture composition to the victor's
    //                                regions at the recognised rate.
    //
    // Culture identity is derived from nations (cultureId == starting nation
    // id). Composition is stored per-region as a dictionary of cultureId ->
    // share (0..1) and persisted alongside the vanilla save file.
    // ========================================================================

    public static class CulturalInertia
    {
        internal const string ModName = "CulturalInertia";

        // --- runtime state ---------------------------------------------------
        // Keyed by region gamestate id (stable across save/load).
        private static readonly Dictionary<string, Dictionary<string, float>> compositions =
            new Dictionary<string, Dictionary<string, float>>();

        // Regions whose composition is recorded at first game load, mapped to
        // the nation that owned them then (the culture seed).
        private static readonly Dictionary<string, string> seededRegions =
            new Dictionary<string, string>();

        private static bool stateLoadedThisSession = false;

        // --- config (settings-driven) -----------------------------------------
        public static bool Enabled => CreepingBordersCls.Settings.EnableCulturalInertia;
        public static float CulturalMismatchMax => CreepingBordersCls.Settings.CulturalMismatchMax;
        public static float UnityAssimilationStrength => CreepingBordersCls.Settings.UnityAssimilationStrength;
        public static float AbsorptionRecognitionRate => CreepingBordersCls.Settings.AbsorptionRecognitionRate;

        /// <summary>
        /// C9: global multiplier applied to every SecessionChance roll.
        /// Default 3x; exposed as a slider in the mod settings UI.
        /// </summary>
        public static float SecessionFrequencyMultiplier =>
            CreepingBordersCls.Settings.SecessionFrequencyMultiplier;

        // ======================================================================
        // CULTURE IDENTITIES
        // ======================================================================

        /// <summary>
        /// Culture id for a nation: its gamestate id, which is stable and
        /// serialisable. The nation's starting identity is its culture.
        /// </summary>
        public static string CultureOfNation(TINationState nation)
        {
            return nation == null ? null : nation.ID.ToString();
        }

        /// <summary>
        /// The state culture of the nation currently owning a region.
        /// Falls back to the region's seeded culture, then to a global default.
        /// </summary>
        public static string StateCultureOfRegion(TIRegionState region)
        {
            if (region == null) return null;
            if (region.nation != null) return CultureOfNation(region.nation);
            if (seededRegions.TryGetValue(region.ID.ToString(), out var seeded)) return seeded;
            return "unassigned";
        }

        // ======================================================================
        // COMPOSITION ACCESS
        // ======================================================================

        /// <summary>
        /// Gets (initialising if needed) the culture composition of a region.
        /// A region seen for the first time is seeded at 100% its owning
        /// nation's culture — this is the only "seeding" that happens, and it
        /// reflects the state of the world at mod first-activation, not any
        /// conquest that follows. Conquest itself never shifts composition.
        /// </summary>
        public static Dictionary<string, float> Composition(TIRegionState region)
        {
            if (region == null) return null;
            if (!compositions.TryGetValue(region.ID.ToString(), out var comp))
            {
                comp = new Dictionary<string, float>();
                string culture = StateCultureOfRegion(region) ?? "unassigned";
                comp[culture] = 1f;
                compositions[region.ID.ToString()] = comp;
                if (!seededRegions.ContainsKey(region.ID.ToString()))
                    seededRegions[region.ID.ToString()] = culture;
            }
            return comp;
        }

        /// <summary>
        /// Fraction (0..1) of the region's population whose culture differs
        /// from the owning nation's state culture.
        /// </summary>
        public static float ForeignShare(TIRegionState region)
        {
            if (region == null || !Enabled) return 0f;
            string stateCulture = StateCultureOfRegion(region) ?? "unassigned";
            var comp = Composition(region);
            float foreign = 0f;
            foreach (var kv in comp)
            {
                if (kv.Key != stateCulture)
                    foreign += kv.Value;
            }
            return Mathf.Clamp01(foreign);
        }

        /// <summary>
        /// Population-weighted foreign share: foreignShare scaled by the
        /// region's share of the nation's population, so a small foreign
        /// enclave matters less than a large one.
        /// </summary>
        public static float PopWeightedForeignShare(TIRegionState region)
        {
            if (region == null || region.nation == null) return 0f;
            float foreign = ForeignShare(region);
            if (foreign <= 0f) return 0f;

            float nationPop = 0f;
            foreach (var r in region.nation.regions)
                nationPop += r.populationInMillions;
            if (nationPop <= 0f) return foreign;

            float weight = Mathf.Clamp01(region.populationInMillions / nationPop);
            return foreign * Mathf.Clamp01(weight * region.nation.regions.Count); // proportional share, capped at 1
        }

        /// <summary>
        /// Shifts a region's composition toward a target culture by the given
        /// absolute fraction. Shares are clamped to 0..1 and the dictionary is
        /// renormalised so the total always sums to 1.
        /// </summary>
        public static void NudgeComposition(TIRegionState region, string targetCulture, float amount)
        {
            if (region == null || string.IsNullOrEmpty(targetCulture) || amount <= 0f) return;
            var comp = Composition(region);

            // Compute current share of the target culture.
            comp.TryGetValue(targetCulture, out var targetShare);
            float newTarget = Mathf.Clamp01(targetShare + amount);

            // Reduce every other culture proportionally so total stays 1.
            float othersTotal = 1f - targetShare;
            float reduction = newTarget - targetShare;
            if (othersTotal > 0f && reduction > 0f)
            {
                float scale = (othersTotal - reduction) / othersTotal;
                if (scale < 0f) scale = 0f;
                var keys = new List<string>(comp.Keys);
                foreach (var k in keys)
                {
                    if (k == targetCulture) continue;
                    comp[k] = comp[k] * scale;
                    if (comp[k] <= 0.0005f) comp.Remove(k);
                }
            }
            comp[targetCulture] = newTarget;
        }

        // ======================================================================
        // MECHANICS: UNITY COMPLETION
        // ======================================================================

        /// <summary>
        /// Called when a nation completes a Unity priority. Every owned region
        /// is nudged toward the nation's state culture. The strength scales
        /// with the nation's unity public opinion effect so cultural drift
        /// tracks actual cultural investment, not just priority completion.
        /// </summary>
        public static void OnUnityCompleted(TINationState nation)
        {
            if (!Enabled || nation == null || !nation.extant) return;
            try
            {
                string stateCulture = CultureOfNation(nation);
                if (string.IsNullOrEmpty(stateCulture)) return;

                // Base strength per completion, scaled by the global unity
                // public-opinion knob so it stays proportionate to vanilla.
                float strength = TemplateManager.global.unityPublicOpinionBaseStrength
                                 * UnityAssimilationStrength;

                foreach (var region in nation.regions)
                {
                    if (region == null) continue;
                    // Assimilation is slower where the foreign share is small.
                    float foreign = ForeignShare(region);
                    if (foreign <= 0f) continue;
                    float amount = strength * foreign;
                    NudgeComposition(region, stateCulture, amount);
                }

                CreepingBordersCls.mod?.Logger.Log(
                    $"[CulturalInertia] {nation.displayName} completed Unity: assimilation pass applied (strength {strength:F2}).");
            }
            catch (Exception ex)
            {
                CreepingBordersCls.mod?.Logger.Error($"[CulturalInertia] OnUnityCompleted error: {ex.Message}");
            }
        }

        // ======================================================================
        // MECHANICS: ABSORPTION
        // ======================================================================

        /// <summary>
        /// Called when a nation absorbs another. The absorbed nation's culture
        /// composition contributes to the victor's regions at the recognised
        /// rate: previously-absorbed cultures are not erased, they blend in.
        /// </summary>
        public static void OnAbsorption(TINationState victor, TINationState absorbed)
        {
            if (!Enabled || victor == null || absorbed == null) return;
            try
            {
                string victorCulture = CultureOfNation(victor);
                string absorbedCulture = CultureOfNation(absorbed);
                if (string.IsNullOrEmpty(victorCulture) || string.IsNullOrEmpty(absorbedCulture))
                    return;

                float recognition = Mathf.Clamp01(AbsorptionRecognitionRate);

                // For each region the victor gains, blend the absorbed nation's
                // composition into it at the recognition rate.
                foreach (var region in absorbed.regions.ToList())
                {
                    if (region == null) continue;
                    // Seed the region with the absorbed culture weighted by the
                    // recognition rate, remainder to the victor's culture.
                    var comp = Composition(region);
                    comp.TryGetValue(absorbedCulture, out var absorbedShare);
                    float transferred = absorbedShare * recognition;
                    comp[absorbedCulture] = absorbedShare - transferred;
                    if (comp[absorbedCulture] <= 0.0005f) comp.Remove(absorbedCulture);
                    comp.TryGetValue(victorCulture, out var victorShare);
                    comp[victorCulture] = Mathf.Clamp01(victorShare + transferred);
                    compositions[region.ID.ToString()] = comp;
                }

                CreepingBordersCls.mod?.Logger.Log(
                    $"[CulturalInertia] {victor.displayName} absorbed {absorbed.displayName}: culture blended at recognition rate {recognition:F2}.");
            }
            catch (Exception ex)
            {
                CreepingBordersCls.mod?.Logger.Error($"[CulturalInertia] OnAbsorption error: {ex.Message}");
            }
        }

        // ======================================================================
        // COHESION INTEGRATION
        // ======================================================================

        /// <summary>
        /// The cohesion rest-state malus a nation suffers from cultural
        /// mismatch across its regions:
        ///   sum over regions of (foreignShare * popWeight) * culturalMismatchMax
        ///
        /// Breakaway relief (C6): while the nation is flagged as a breakaway
        /// (nation.breakaway == true), the mismatch malus is halved. Vanilla
        /// never clears breakawayParent, so the relief is effectively permanent.
        /// </summary>
        public static float CohesionMalus(TINationState nation)
        {
            if (!Enabled || nation == null || !nation.extant) return 0f;
            float total = 0f;
            foreach (var region in nation.regions)
            {
                if (region == null) continue;
                total += PopWeightedForeignShare(region);
            }
            if (nation.breakaway) total *= 0.5f;
            return total * CulturalMismatchMax;
        }

        // ======================================================================
        // PERSISTENCE
        // ======================================================================

        private static string StateFilePath(string savePath)
        {
            return savePath + ".culturalinertia.json";
        }

        [Serializable]
        private class RegionCompositionSave
        {
            public string regionId;
            public string[] cultureIds;
            public float[] shares;
            public string seededCulture;
        }

        private static void SaveState(string savePath)
        {
            try
            {
                var list = new List<RegionCompositionSave>();
                foreach (var kv in compositions)
                {
                    if (kv.Value == null || kv.Value.Count == 0) continue;
                    var entry = new RegionCompositionSave
                    {
                        regionId = kv.Key,
                        cultureIds = kv.Value.Keys.ToArray(),
                        shares = kv.Value.Values.ToArray(),
                        seededCulture = seededRegions.TryGetValue(kv.Key, out var s) ? s : null
                    };
                    list.Add(entry);
                }
                var wrapper = new Dictionary<string, object> { { "regions", list } };
                string json = JsonUtility.ToJson(new SerializableWrapper { regions = list.ToArray() });
                File.WriteAllText(StateFilePath(savePath), json);
            }
            catch (Exception ex)
            {
                CreepingBordersCls.mod?.Logger.Error($"[CulturalInertia] SaveState error: {ex.Message}");
            }
        }

        [Serializable]
        private class SerializableWrapper
        {
            public RegionCompositionSave[] regions;
        }

        private static void LoadState(string savePath)
        {
            if (stateLoadedThisSession) return; // guard against double-load in one session
            try
            {
                compositions.Clear();
                seededRegions.Clear();
                string path = StateFilePath(savePath);
                if (!File.Exists(path))
                {
                    stateLoadedThisSession = true;
                    return; // Fresh game: compositions will be seeded lazily.
                }
                var wrapper = JsonUtility.FromJson<SerializableWrapper>(File.ReadAllText(path));
                if (wrapper?.regions == null) { stateLoadedThisSession = true; return; }
                foreach (var entry in wrapper.regions)
                {
                    if (entry == null || string.IsNullOrEmpty(entry.regionId)) continue;
                    var comp = new Dictionary<string, float>();
                    if (entry.cultureIds != null && entry.shares != null)
                    {
                        int n = Math.Min(entry.cultureIds.Length, entry.shares.Length);
                        for (int i = 0; i < n; i++)
                            comp[entry.cultureIds[i]] = Mathf.Clamp01(entry.shares[i]);
                    }
                    compositions[entry.regionId] = comp;
                    if (!string.IsNullOrEmpty(entry.seededCulture))
                        seededRegions[entry.regionId] = entry.seededCulture;
                }
                stateLoadedThisSession = true;
                CreepingBordersCls.mod?.Logger.Log(
                    $"[CulturalInertia] Loaded culture compositions for {compositions.Count} regions.");
            }
            catch (Exception ex)
            {
                CreepingBordersCls.mod?.Logger.Error($"[CulturalInertia] LoadState error: {ex.Message}");
            }
        }

        /// <summary>Clears all in-memory culture state (on returning to main menu).</summary>
        public static void ResetInMemoryState()
        {
            compositions.Clear();
            seededRegions.Clear();
            stateLoadedThisSession = false;
        }

        // ======================================================================
        // C7: CULTURE-WEIGHTED DEFECTION
        // ======================================================================

        /// <summary>
        /// Multiplier applied to a region's secession roll based on its
        /// foreign culture share (C7). A region at 100% state culture has a
        /// factor of 0.05 (rarely defects); a fully foreign region keeps the
        /// full vanilla chance (factor 1.0). The 0.05 floor keeps edge cases
        /// (e.g. unrest spikes) from making defection literally impossible.
        /// </summary>
        public static float SecessionCultureFactor(TIRegionState region)
        {
            if (region == null || !Enabled) return 1f;
            return Mathf.Clamp01(ForeignShare(region)) * 0.95f + 0.05f;
        }

        /// <summary>
        /// Culture-weighted replacement for DailySecessionCheck (C7).
        /// Mirrors the vanilla logic exactly, but scales both the initial
        /// capital-region roll and the follower-region rolls by each region's
        /// SecessionCultureFactor. When the mod is disabled the vanilla
        /// method runs untouched (prefix returns false only when active).
        /// </summary>
        private static void CultureWeightedSecessionCheck(TINationState seceder)
        {
            if (seceder.alienNation || (seceder.capital == null && !seceder.alienNation)) return;

            TINationState parentNation = seceder.capital.nation;
            if (parentNation.cohesion > TINationState.maxCohesionForSecession
                || parentNation.unrest < TINationState.minUnrestForSecession
                || parentNation.capital == seceder.capital)
                return;

            float vanillaChance = seceder.SecessionChance(0.5f, true);
            float cultureFactor = SecessionCultureFactor(seceder.capital);
            float weightedChance = vanillaChance * cultureFactor;

            // Verification log (C7 acceptance): dump weighted vs vanilla
            // chances whenever a candidate clears the cohesion/unrest gate.
            try
            {
                CreepingBordersCls.mod?.Logger.Log(
                    $"[CulturalInertia] Secession candidate {seceder.displayName}: " +
                    $"vanilla={vanillaChance:F6} weighted={weightedChance:F6} " +
                    $"foreignShare={ForeignShare(seceder.capital):F2} factor={cultureFactor:F2}");
            }
            catch (Exception) { /* logging must never break the check */ }

            if (TIUtilities.RandomFloatValue() >= weightedChance) return;

            var secessionRegions = new List<TIRegionState> { seceder.capital };
            foreach (var region in parentNation.regions)
            {
                if (region == parentNation.capital || region == seceder.capital) continue;
                if (!seceder.claims.Contains(region)) continue;
                if (seceder.ClaimWillBeHostile(region)) continue;
                if (region.armies.Count != 0) continue;

                float followerRoll = TIUtilities.RandomFloatValue() * 100f;
                float followerThreshold = 3f * (parentNation.unrest * 2f
                                                - parentNation.cohesion
                                                - parentNation.democracy);
                followerThreshold *= SecessionCultureFactor(region);
                if (followerRoll < followerThreshold)
                    secessionRegions.Add(region);
            }

            parentNation.Secession(parentNation.HighestUnrestContributor(), seceder, secessionRegions, null);
        }


        // ======================================================================
        // C8: BREAKAWAY 50/50 SPAWN
        // ======================================================================

        /// <summary>
        /// C8: when a breakaway nation forms, each transferred region's culture
        /// composition is rewritten to a ~50/50 split between the parent
        /// nation's culture and the local (seeded) culture. The parent keeps
        /// its existing composition for the region. Gated on the mod being
        /// active; any failure leaves composition untouched.
        /// </summary>
        private static void BreakawaySpawnBalance(TINationState newNation, List<TIRegionState> transferringRegions, TINationState parent)
        {
            if (!CreepingBordersCls.enabled || !Enabled) return;
            if (newNation == null || parent == null || transferringRegions == null) return;

            string parentCulture = CultureOfNation(parent);
            string localCulture = CultureOfNation(newNation);
            if (string.IsNullOrEmpty(parentCulture) || string.IsNullOrEmpty(localCulture) || parentCulture == localCulture) return;

            foreach (var region in transferringRegions)
            {
                if (region == null) continue;
                try
                {
                    var comp = Composition(region);
                    comp[parentCulture] = 0.5f;
                    comp[localCulture] = 0.5f;
                    // Remove any other cultures that may have been present.
                    foreach (var k in new List<string>(comp.Keys))
                        if (k != parentCulture && k != localCulture) comp.Remove(k);
                }
                catch (Exception) { /* never break secession */ }
            }
        }

        // ======================================================================
        // HARMONY PATCHES
        // ======================================================================

        [HarmonyPatch(typeof(TINationState), nameof(TINationState.DailySecessionCheck))]
        public static class Patch_DailySecessionCheck
        {
            // Prefix takes over the method entirely when the mod is active;
            // returning false skips the vanilla body. On any error we fall
            // back to vanilla by returning true.
            static bool Prefix(TINationState __instance)
            {
                if (!CreepingBordersCls.enabled || !Enabled) return true;
                try
                {
                    CultureWeightedSecessionCheck(__instance);
                }
                catch (Exception)
                {
                    return true; // never break the daily tick
                }
                return false;
            }
        }

        [HarmonyPatch(typeof(TINationState), nameof(TINationState.OnUnityPriorityComplete))]
        public static class Patch_OnUnityPriorityComplete
        {
            static void Postfix(TINationState __instance)
            {
                if (!CreepingBordersCls.enabled || !Enabled) return;
                CulturalInertia.OnUnityCompleted(__instance);
            }
        }

        [HarmonyPatch(typeof(TINationState), nameof(TINationState.AbsorbNation))]
        public static class Patch_AbsorbNation
        {
            static void Postfix(TINationState __instance, TIFactionState actingFaction, TINationState joiningNationState)
            {
                if (!CreepingBordersCls.enabled || !Enabled) return;
                CulturalInertia.OnAbsorption(__instance, joiningNationState);
            }
        }

        [HarmonyPatch(typeof(TINationState), "cohesionRestState", MethodType.Getter)]
        public static class Patch_CohesionRestState_Getter
        {
            static void Postfix(TINationState __instance, ref float __result)
            {
                if (!CreepingBordersCls.enabled || !Enabled) return;
                try
                {
                    float malus = CulturalInertia.CohesionMalus(__instance);
                    if (malus > 0f)
                        __result = Mathf.Max(0f, __result - malus);
                }
                catch (Exception)
                {
                    // Never break vanilla cohesion computation.
                }
            }
        }

        [HarmonyPatch(typeof(GameStateManager), nameof(GameStateManager.SaveAllGameStates))]
        public static class Patch_SaveAllGameStates
        {
            static void Postfix(string filepath)
            {
                if (!CreepingBordersCls.enabled || !Enabled) return;
                CulturalInertia.SaveState(filepath);
            }
        }

        [HarmonyPatch(typeof(GameStateManager), nameof(GameStateManager.LoadAllGameStates))]
        public static class Patch_LoadAllGameStates
        {
            static void Postfix(string filepath)
            {
                if (!CreepingBordersCls.enabled) return;
                CulturalInertia.LoadState(filepath);
            }
        }
    }
}

        [HarmonyPatch(typeof(TINationState), nameof(TINationState.SecessionChance))]
        public static class Patch_SecessionChance
        {
            // C9: postfix multiplies the final vanilla chance by the
            // configured frequency multiplier (default 3x). Applies to both
            // organic and non-organic rolls. Gated on the mod being active;
            // on any error the vanilla chance is left untouched.
            static void Postfix(TINationState __instance, ref float __result)
            {
                if (!CreepingBordersCls.enabled || !Enabled) return;
                try
                {
                    float mult = SecessionFrequencyMultiplier;
                    if (mult != 1f) __result *= mult;
                }
                catch (Exception) { /* never break the roll */ }
            }
        }

        [HarmonyPatch(typeof(TINationState), nameof(TINationState.Secession))]
        public static class Patch_Secession
        {
            // C8: postfix rewrites the culture composition of each transferred
            // region to a ~50/50 split between parent and local culture.
            static void Postfix(TINationState __instance, TIFactionState actingFaction, TINationState newNation, List<TIRegionState> transferringRegions, TINationState liberator)
            {
                try
                {
                    // C8 applies to secession spawns only, not liberations.
                    if (liberator != null) return;
                    BreakawaySpawnBalance(newNation, transferringRegions, __instance);
                }
                catch (Exception) { /* never break secession */ }
            }
        }
