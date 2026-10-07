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

        // C13: exact fractional pops awaiting conversion, bucketed per region
        // and per source culture. Whole pops are converted immediately when a
        // bucket reaches 1; sub-unit remainders carry over to the next tick so
        // total population is conserved to the last individual.
        private static Dictionary<string, Dictionary<string, double>> remainderBuckets
            = new Dictionary<string, Dictionary<string, double>>();

        // C13: claim-source ledger. When a regime change carries a hostile
        // claim over to a new owner, the ledger records which culture made the
        // original claim so Unity-driven expiry can weigh it correctly.
        private static Dictionary<string, Dictionary<string, string>> claimSourceLedger
            = new Dictionary<string, Dictionary<string, string>>();

        // C13: claims deliberately legitimised (via the Legitimise Claim policy
        // or vanilla's no-seizure claim path). Legitimised claims act like
        // research-granted claims: permanently friendly, never re-flipped to
        // hostile by the hysteresis pass. Keyed "<claimantNationId>:<regionId>"
        // and persisted alongside the vanilla save.
        private static readonly HashSet<string> legitimisedClaims = new HashSet<string>();

        // --- config (settings-driven) -----------------------------------------
        public static bool Enabled => CreepingBordersCls.Settings.EnableCulturalInertia;
        public static float CulturalMismatchMax => CreepingBordersCls.Settings.CulturalMismatchMax;
        public static float UnityAssimilationStrength => CreepingBordersCls.Settings.UnityAssimilationStrength;
        public static float AbsorptionRecognitionRate => CreepingBordersCls.Settings.AbsorptionRecognitionRate;

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
        // DEBUG LOGGING
        // ======================================================================
        public static void DebugLog(string msg)
        {
            if (CreepingBordersCls.mod != null) CreepingBordersCls.mod.Logger.Log("[C13] " + msg);
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

        // ======================================================================
        // C13: EXACT-POP CONVERSION WITH REMAINDER BUCKETS
        // ======================================================================

        /// <summary>
        /// Converts an exact number of pops in a region from their source
        /// culture to the target culture. Whole pops convert immediately;
        /// fractional remainders are held in a per-region, per-source-culture
        /// bucket and spill over into whole pops on subsequent ticks, so no
        /// population is created or destroyed.
        /// </summary>
        public static void ConvertPopulationExact(TIRegionState region, string targetCulture,
            string sourceCultureId, double exactPops)
        {
            if (region == null || string.IsNullOrEmpty(targetCulture) || exactPops <= 0) return;
            if (!Enabled) return;
            var comp = Composition(region);
            if (!comp.TryGetValue(sourceCultureId, out var sourceShare) || sourceShare <= 0f) return;

            double regionPop = region.populationInMillions * 1_000_000.0;
            if (regionPop <= 0) return;

            // How many pops the composition still holds in the source culture.
            double sourcePops = sourceShare * regionPop;

            // Pull any previously banked remainder forward for this source culture.
            Dictionary<string, double> buckets = null;
            string regionKey = region.ID.ToString();
            if (!remainderBuckets.TryGetValue(regionKey, out buckets))
            {
                buckets = new Dictionary<string, double>();
                remainderBuckets[regionKey] = buckets;
            }
            buckets.TryGetValue(sourceCultureId, out double banked);

            double available = sourcePops + banked;
            double convert = Math.Min(exactPops, available);
            if (convert <= 0) return;

            int whole = (int)Math.Floor(convert);
            double remainder = convert - whole;

            // Bank the sub-unit remainder for this source culture.
            buckets[sourceCultureId] = remainder;

            if (whole <= 0)
            {
                // Not enough banked to move a single pop yet.
                return;
            }

            // Shift whole pops from source to target in the composition store.
            double popDelta = whole / regionPop;
            double newSource = sourceShare - popDelta;
            if (newSource <= 0.0005f)
            {
                comp.Remove(sourceCultureId);
            }
            else
            {
                comp[sourceCultureId] = (float)newSource;
            }

            comp.TryGetValue(targetCulture, out var targetShare);
            double newTarget = Math.Min(1.0, (double)targetShare + popDelta);
            comp[targetCulture] = (float)newTarget;

            Renormalise(comp);
        }

        /// <summary>
        /// Renormalises a composition so shares sum to 1.0 within float
        /// tolerance, dropping any culture that has fallen to dust.
        /// </summary>
        private static void Renormalise(Dictionary<string, float> comp)
        {
            if (comp == null || comp.Count == 0) return;
            float total = 0f;
            foreach (var v in comp.Values) total += v;
            if (total <= 0f) return;
            var keys = new List<string>(comp.Keys);
            foreach (var k in keys)
            {
                comp[k] = comp[k] / total;
                if (comp[k] <= 0.0005f) comp.Remove(k);
            }
        }

        /// <summary>
        /// Gets the claim-source ledger entry: the culture that originally made
        /// the claim carried over to this region, or null if none.
        /// </summary>
        public static string ClaimSourceCulture(TIRegionState region)
        {
            if (region == null) return null;
            if (claimSourceLedger.TryGetValue(region.ID.ToString(), out var bySource))
            {
                // The ledger stores one source per claiming culture; for a
                // region the relevant entry is keyed by the claiming culture.
                foreach (var kv in bySource)
                    return kv.Key; // single claiming culture per region (first wins)
            }
            return null;
        }

        /// <summary>
        /// Records a carried-over claim in the ledger: the claim on this region
        /// originally came from the given culture (usually the absorbed or
        /// defeated nation whose claim the new owner inherited).
        /// </summary>
        public static void RecordClaimCarryover(TIRegionState region, string claimingCultureId)
        {
            if (region == null || string.IsNullOrEmpty(claimingCultureId)) return;
            string regionKey = region.ID.ToString();
            if (!claimSourceLedger.TryGetValue(regionKey, out var bySource))
            {
                bySource = new Dictionary<string, string>();
                claimSourceLedger[regionKey] = bySource;
            }
            bySource[claimingCultureId] = claimingCultureId;
        }

        /// <summary>
        /// True if the given culture has a recorded carried-over claim on the region.
        /// </summary>
        public static bool HasCarriedOverClaim(TIRegionState region, string claimingCultureId)
        {
            if (region == null || string.IsNullOrEmpty(claimingCultureId)) return false;
            return claimSourceLedger.TryGetValue(region.ID.ToString(), out var bySource)
                && bySource.ContainsKey(claimingCultureId);
        }

        /// <summary>
        /// Expires all carried-over claims recorded for a nation's culture.
        /// Called when an Outreach action completes: the carried-over claims
        /// disappear along with the nation's active hostile claims.
        /// </summary>
        public static void ExpireCarriedOverClaims(TINationState nation)
        {
            if (nation == null || nation.regions == null) return;
            string culture = CultureOfNation(nation);
            int expired = 0;
            foreach (var region in nation.regions)
            {
                if (region == null) continue;
                string regionKey = region.ID.ToString();
                if (claimSourceLedger.TryGetValue(regionKey, out var bySource)
                    && bySource.Remove(culture))
                {
                    expired++;
                }
            }
            if (expired > 0)
            {
                CreepingBordersCls.mod?.Logger.Log(
                    $"[CulturalInertia] {nation.displayName}: {expired} carried-over claim(s) expired by Outreach.");
            }
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

        [Serializable]
        private class RemainderSave
        {
            public string regionId;
            public string cultureIds;
            public double[] remainders;
        }

        [Serializable]
        private class ClaimLedgerSave
        {
            public string regionId;
            public string[] claimingCultures;
        }

        [Serializable]
        private class ExtendedStateWrapper
        {
            public RemainderSave[] remainders;
            public ClaimLedgerSave[] claimLedger;
            public string[] legitimised;
        }

        public static string LegitimisedKey(TINationState claimant, TIRegionState region)
        {
            if (claimant == null || region == null) return null;
            return claimant.ID.ToString() + ":" + region.ID.ToString();
        }

        /// <summary>
        /// True if the nation has legitimised its claim on the region: the
        /// claim now behaves like a research-granted claim and never flips
        /// back to hostile.
        /// </summary>
        public static bool IsLegitimised(TINationState claimant, TIRegionState region)
        {
            string key = LegitimisedKey(claimant, region);
            return key != null && legitimisedClaims.Contains(key);
        }

        public static void MarkLegitimised(TINationState claimant, TIRegionState region)
        {
            string key = LegitimisedKey(claimant, region);
            if (key != null && legitimisedClaims.Add(key) && CreepingBordersCls.Settings.EnableDebugLogging)
                CreepingBordersCls.mod?.Logger.Log(
                    $"[CulturalInertia] {claimant.displayName} legitimised claim on {region.displayName} (permanent friendly claim)");
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
                string json = JsonUtility.ToJson(new SerializableWrapper { regions = list.ToArray() });
                File.WriteAllText(StateFilePath(savePath), json);

                // C13 extension: remainder buckets + claim-source ledger.
                var remList = new List<RemainderSave>();
                foreach (var kv in remainderBuckets)
                {
                    if (kv.Value == null || kv.Value.Count == 0) continue;
                    remList.Add(new RemainderSave
                    {
                        regionId = kv.Key,
                        cultureIds = string.Join(";", kv.Value.Keys),
                        remainders = kv.Value.Values.ToArray()
                    });
                }
                var ledgerList = new List<ClaimLedgerSave>();
                foreach (var kv in claimSourceLedger)
                {
                    if (kv.Value == null || kv.Value.Count == 0) continue;
                    ledgerList.Add(new ClaimLedgerSave
                    {
                        regionId = kv.Key,
                        claimingCultures = kv.Value.Keys.ToArray()
                    });
                }
                var extPath = StateFilePath(savePath) + ".ext.json";
                File.WriteAllText(extPath, JsonUtility.ToJson(new ExtendedStateWrapper
                {
                    remainders = remList.ToArray(),
                    claimLedger = ledgerList.ToArray(),
                    legitimised = legitimisedClaims.ToArray()
                }));
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

                // C13 extension: remainder buckets + claim-source ledger.
                remainderBuckets.Clear();
                claimSourceLedger.Clear();
                var extPath = StateFilePath(savePath) + ".ext.json";
                if (File.Exists(extPath))
                {
                    var ext = JsonUtility.FromJson<ExtendedStateWrapper>(File.ReadAllText(extPath));
                    if (ext?.remainders != null)
                    {
                        foreach (var rem in ext.remainders)
                        {
                            if (rem == null || string.IsNullOrEmpty(rem.regionId)) continue;
                            var buckets = new Dictionary<string, double>();
                            var ids = (rem.cultureIds ?? "").Split(';');
                            if (rem.remainders != null)
                            {
                                int n = Math.Min(ids.Length, rem.remainders.Length);
                                for (int i = 0; i < n; i++)
                                    buckets[ids[i]] = Math.Max(0.0, rem.remainders[i]);
                            }
                            remainderBuckets[rem.regionId] = buckets;
                        }
                    }
                    if (ext?.claimLedger != null)
                    {
                        foreach (var ledger in ext.claimLedger)
                        {
                            if (ledger == null || string.IsNullOrEmpty(ledger.regionId)) continue;
                            var bySource = new Dictionary<string, string>();
                            if (ledger.claimingCultures != null)
                            {
                                foreach (var c in ledger.claimingCultures)
                                    bySource[c] = c;
                            }
                            claimSourceLedger[ledger.regionId] = bySource;
                        }
                    }
                    if (ext?.legitimised != null)
                    {
                        foreach (var k in ext.legitimised)
                            if (!string.IsNullOrEmpty(k)) legitimisedClaims.Add(k);
                    }
                }
                stateLoadedThisSession = true;
                CreepingBordersCls.mod?.Logger.Log(
                    $"[CulturalInertia] Loaded culture compositions for {compositions.Count} regions " +
                    $"({remainderBuckets.Count} remainder buckets, {claimSourceLedger.Count} claim-ledger entries).");
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
            remainderBuckets.Clear();
            claimSourceLedger.Clear();
            legitimisedClaims.Clear();
            stateLoadedThisSession = false;
        }

        // ======================================================================
        // HARMONY PATCHES
        // ======================================================================

        [HarmonyPatch(typeof(TINationState), nameof(TINationState.OnUnityPriorityComplete))]
        public static class Patch_OnUnityPriorityComplete
        {
            // Handover §3.2: the mod REPLACES vanilla Unity completion when the
            // Cultural Inertia master toggle is on (replacing prefix).
            static bool Prefix(TINationState __instance, ref bool __runOriginal)
            {
                if (!CreepingBordersCls.enabled || !Enabled) return true;
                __runOriginal = false;
                CulturalInertiaUnity.RunCompletion(__instance);
                return false;
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

        [HarmonyPatch(typeof(TINationState), nameof(TINationState.RemoveHostileClaim))]
        public static class Patch_RemoveHostileClaim
        {
            // Any deliberate conversion of a hostile claim to a friendly one
            // (the mod's Legitimise Claim policy, vanilla's no-seizure claim
            // path) marks the claim as legitimised: from then on it behaves
            // like a research-granted claim and the C13 hysteresis pass never
            // flips it back to hostile.
            static void Postfix(TINationState __instance, TIRegionState region)
            {
                if (!CreepingBordersCls.enabled || !Enabled) return;
                try { CulturalInertia.MarkLegitimised(__instance, region); }
                catch (Exception) { }
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
