using System;
using HarmonyLib;
using PavonisInteractive.TerraInvicta;

namespace CreepingBorders
{
    /// <summary>
    /// UMM option: "Unification Uses Current Capital".
    /// Vanilla requires the absorber to hold a claim on the target's ORIGINAL
    /// capital (TemplateManager.global.prohibitCapitalShenanigans decides
    /// original vs current; breakaway parent/child unification is exempt).
    /// When this option is on, the check always uses the CURRENT capital, so a
    /// destroyed/relocated original capital no longer blocks unification.
    /// Implemented as a prefix on TINationState.MyClaimOnOtherCapital that
    /// evaluates the claim against targetNation.capital, covering all call
    /// sites (eligibleUnifications, CanUnifyFeedback, bilateral capitalClaim
    /// checks). The body mirrors vanilla MyClaimOnOtherCapital with
    /// originalCapital=false — it is deliberately inlined rather than called,
    /// because a normal call from inside the prefix would re-enter Harmony and
    /// recurse.
    /// </summary>
    [HarmonyPatch(typeof(TINationState), nameof(TINationState.MyClaimOnOtherCapital))]
    public static class UnificationCapitalFix
    {
        public static bool Prefix(TINationState __instance, TINationState targetNation, ref bool originalCapital, bool includeHostile, ref bool __result)
        {
            if (!CreepingBordersCls.enabled || !CreepingBordersCls.Settings.UnificationUseCurrentCapital || !originalCapital)
                return true; // run vanilla unchanged

            originalCapital = false; // keep the original method's out-of-line copy consistent
            TIRegionState region = targetNation.capital;
            bool hasClaim = __instance.claims.Contains(region);
            bool friendly = !__instance.ClaimWillBeHostile(region, true) && !__instance.HostileClaimDueToDemocracy(targetNation);
            __result = targetNation.extant && hasClaim && (includeHostile || friendly);
            return false;
        }
    }
}
