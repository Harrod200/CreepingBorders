# Cultural Inertia — Pseudocode Implementation Plan (rev 9 / C13)

Companion to `Cultural Inertia Plan.md`. Every patch point below is verified
against `Docs/Terra Invicta Class & Method Reference.md` and the decompile.
Line refs are decompile anchors; reference md entries are listed alongside.

## 0. Module map

```
CulturalInertia.cs        — state store, culture ids, composition math (exists, rev 8)
CreepingBordersCls.cs     — claims engine, policies, influence (exists)
CulturalInertiaClaims.cs  — NEW: provenance, conversion seeding, hysteresis
CulturalInertiaUnity.cs   — NEW: unity completion budgets, stance, influence payment
CulturalInertiaEconomy.cs — NEW: effective-population weighting, minority malus
```

## 1. Provenance (C13a) — `CulturalInertiaClaims.cs`

```csharp
// Ref md: TINationState.SetClaim / ClaimWillBeHostile / RemoveHostileClaim
//         TIBilateralTemplate.BilateralIsActive (ref md 48487)
static bool IsResearchGrantedClaim(TINationState n, TIRegionState r)
    => TemplateManager.Find<TIBilateralTemplate>(
           "Claim" + n.templateName + r.templateName, false) is TIBilateralTemplate t
       && t.BilateralIsActive();

static bool HostilityWritesAllowed(TINationState n)
    => !TemplateManager.global.NoHostileClaims;   // ruling: setting overrides ALL hostility writes
```

Patch points (postfix, all already named in ref md TINationState §23910/23913/23916):

```csharp
[HarmonyPatch(typeof(TINationState), nameof(SetClaim))]            // ref md 23910
static void Postfix(n, region, fromSeizure, forceFromSeizure) {
    if (!HostilityWritesAllowed(n)) return;              // gate BEFORE any hostility
    bool willBeHostile = n.ClaimWillBeHostile(region);   // ref md 23913
    if (willBeHostile) ClaimsEngine.RecordClaimSource(n, region, ModSourced);
    else if (IsResearchGrantedClaim(n, region)) ClaimsEngine.RecordClaimSource(n, region, ResearchSourced);
    else ClaimsEngine.RecordClaimSource(n, region, ModSourced);
}
```

## 2. Conversion seeding (C13b) — `CulturalInertiaClaims.cs`

Patch points: `TransferRegionsControlTo` (ref md 23980; existing patch
`CreepingBordersCls.cs:2186`) — extend the existing postfix rather than adding one.

```csharp
static void OnRegionConverted(TIRegionState r, TINationState from, TINationState to) {
    // Rule 1 — research-granted non-hostile claim → 50% floor bump
    if (IsResearchGrantedClaim(to, r) && !to.hostileClaims.Contains(r)
        && Composition(r, to.cultureId) < S.ResearchClaimConversionFloor)
        SetCulture(r, to.cultureId, S.ResearchClaimConversionFloor);  // bump UP only

    // Rule 2 — unclaimed conquest → 0% seed (existing rev 8 rule, unchanged)
    // Rule 3 — unification of same-culture regions: composition carries over
    //          (AbsorbNation postfix, CulturalInertia.cs:399, already hooked)

    // Rule 4 — seceded/breakaway nations seed at 50% of parent owner culture
    // Patch: TIRegionState secession paths route through TransferRegionsControlTo;
    //        detect `newNation.breakawayParent == from` and apply the S.SecessionCultureFloor floor
    //        against from's culture for every region in the breakaway.

    // Rule 5 — occupation release: when region returns to `from` (liberation),
    //          keep the composition that accumulated under occupation; clear
    //          occupier's outreach/bookkeeping. No reset.

    // Research-claim immunity: claims flagged ResearchSourced are excluded from
    // hysteresis demotion forever (see §3).
}
```

## 3. Hostility hysteresis band (C13c)

```csharp
// Called from the daily claim tick (existing engine loop in CreepingBordersCls.cs)
static void EvaluateBand(TINationState n, TIRegionState r) {
    if (!HostilityWritesAllowed(n)) return;
    float share = Composition(r, n.cultureId);
    bool currentlyHostile = n.hostileClaims.Contains(r);
    if (IsResearchGrantedClaim(n, r)) return;   // immune: never demotes, never flips
    if (!currentlyHostile && share < S.HostileDemoteThreshold) n.SetClaim(r, hostile path);   // demote
    if (currentlyHostile  && share >= S.HostilePromoteThreshold) n.RemoveHostileClaim(r);      // promote
    // 5% gap = hysteresis; prevents flip-flop at boundary.
}
```

## 4. Unity completion budgets (C13d) — `CulturalInertiaUnity.cs`

Patch point: `TINationState.OnUnityPriorityComplete` (ref md 23789; existing patch
`CulturalInertia.cs:389` — replace its body, keep the hook).

```csharp
[HarmonyPatch(typeof(TINationState), nameof(OnUnityPriorityComplete))]
static void Prefix(TINationState __instance, out bool __runOriginal) {
    __runOriginal = false;                          // we fully own completion
    var n = __instance;

    // --- stance --------------------------------------------------------
    bool defensive = GetStancePolicy(n) == Stance.Defensive;   // 3rd synthetic policy key

    // --- budgets -------------------------------------------------------
    float ownBudget   = defensive ? 2*S.OwnedOffensiveBudget : S.OwnedDefensiveBudget;
    float unownedBudget = defensive ? 0.00f : S.UnownedOffensiveBudget;

    // --- owned: inverse-pop split of ownBudget across owned regions ----
    var owned = n.regions;
    float wSum = owned.Sum(r => 1f / r.population);
    foreach (var r in owned)
        NudgeComposition(r, n.cultureId, ownBudget * (1f/r.population) / wSum);

    if (defensive || unownedBudget <= 0) return;

    // --- unowned target set (adjacency ∪ island-range) ------------------
    var targets = AdjacentForeignRegions(n)            // claim-engine walk (existing)
                .Union(IslandRangeForeignRegions(n))   // distance layer threshold
                .Where(t => !IsOccupiedByOrFor(n, t))  // occupied edges blocked for defender side
                .ToList();
    if (!targets.Any()) return;

    // ally null / non-rival half weighting
    float affectedPop = targets.Where(Ally).Sum(Pop)*0f
                      + targets.Where(Rival).Sum(Pop)
                      + targets.Where(Neutral).Sum(Pop)*0.5f;

    // --- influence payment: all-or-nothing ------------------------------
    float cost = affectedPop * S.InfluenceCostPer100M / 100f;  // no cap
    var payers = PayerFactions(n);                     // CP owners, proportional split
    foreach (var f in payers) if (!f.CanAffordInfluence(cost*f.share)) {
        // failed payment → base offensive owned nudge ONLY (already granted above at 0.5)
        return;                                        // no deduction, no unowned spread
    }
    foreach (var f in payers) f.influence -= cost * f.share;

    // --- unowned: inverse-pop split of unownedBudget --------------------
    float wu = targets.Sum(t => Weight(t) / t.population);   // Weight: ally 0, neutral .5, rival 1
    foreach (var t in targets) NudgeComposition(t, n.cultureId, unownedBudget*(Weight(t)/t.population)/wu);

    // --- occupation exception: defender's offensive budget still targets
    //     regions occupied FROM it (fighting chance) — added to targets above.
}
```

Note: unowned regions in the same nation as an ally are null-weighted via
`Weight(t) == 0` and dropped from the split denominator.

## 5. Focused Outreach (C13e)

Existing Outreach patch in `CreepingBordersCls.cs` (~2513/2625 gates). Changes:

```csharp
static OutreachCost(TIRegionState target) => target.population * S.InfluenceCostPer100M / 100f;
// adjacency requirement: target must be adjacent to an owned region OR within
// the island-range threshold (same predicate as broad target set).
// failed payment → degrade to defensive-equivalent for that completion:
//   owned regions get 0.5% budget (not doubled), no deduction, no clock advance.
```

## 6. Effective population weighting (C13f) — `CulturalInertiaEconomy.cs`

Per-region effective population (ruling: computed per region, summed):

```csharp
static float EffectivePopulation(TIRegionState r, TINationState owner) {
    float foreign = r.population * (1 - Composition(r, owner.cultureId));
    return r.population + foreign * BENEFICIAL_WEIGHT;   // 0.3
}
static float EffectivePopulation_Detriment(TIRegionState r, TINationState owner) {
    float foreign = r.population * (1 - Composition(r, owner.cultureId));
    return r.population + foreign * DETRIMENT_WEIGHT;    // 1.3
}
```

Patch points (postfix on getters; each recomputed from the per-region sum):

| Vanilla member | Ref md anchor | Direction |
|---|---|---|
| `economyScore` / `baseInvestmentPoints_month` | TINationState §23616 | beneficial |
| `priorityEffectPopScaling` | TINationState §23616 | beneficial |
| `populationImpactOnCohesion` | TINationState §23616 | detrimental |
| `research_month` | TINationState §23616 | beneficial |
| unrest contributions via pop | TINationState §23616 | detrimental |
| (list per plan rev 9 beneficial/detrimental tables; EXCLUDES: nukes, casualty losses, public opinion) | | |

```csharp
[HarmonyPatch(typeof(TINationState), "cohesionRestState", MethodType.Getter)]  // ref md 23616
static void Postfix(TINationState __instance, ref float __result) {
    __result -= MinorityRuleMalus(__instance);
}
static float MinorityRuleMalus(TINationState n) {
    float m = 0;
    foreach (var r in n.regions) {
        float share = Composition(r, n.cultureId);
        if (share < S.MinorityRuleThreshold)                                   // scaled penalty (ruling 5)
            m += (S.MinorityRuleThreshold - share) * S.CulturalMismatchMax * ScalePenalty(r);
    }
    return m;
}
// ScalePenalty: per user ruling 5, the penalty is scaled (not flat) to exacerbate
// low-culture pain — proportional to affected population share of the nation.
```

## 7. Composition storage refactor (C13g)

Rev 8 store is `Dictionary<string region, Dictionary<string culture, float>>`.
Changes per ruling 3:

```csharp
// float accumulation with per-region remainder bucket (option a)
struct Composition {
    Dictionary<string,float> shares;   // full-precision floats
    float remainder;                   // slop bucket for below-snap deltas
}
const float SNAP_TO_ZERO = S.SnapToZero;   // default 0.0005 (ruling 3: finer)
static void NudgeComposition(TIRegionState r, string cultureId, float delta) {
    var c = Store(r);
    if (delta > 0 && delta < SNAP_TO_ZERO) { c.remainder += delta; return; }
    if (c.remainder >= SNAP_TO_ZERO) { delta += c.remainder; c.remainder = 0; }
    c.shares[cultureId] = Mathf.Clamp01((c.shares.GetValueOrZero(cultureId)) + delta);
    Renormalize(c);   // proportional subtraction from all other shares
}
```

Save/load: extend existing `SaveAllGameStates`/`LoadAllGameStates` patches
(`CulturalInertia.cs:428/438`) to persist `remainder` alongside shares.

## 8. Persistence & settings

**Rule: every balance number in this plan is a mod option.** No magic numbers in
code — each constant below lives in `CreepingBordersCls.Settings` (UMM settings
menu) with the discussed figure as the default. Stance is set per-nation via
the 3rd synthetic policy key (PolicyManager patch pattern at
`CreepingBordersCls.cs:2474`).

| Setting | Default | Used in |
|---|---|---|
| `StancePolicy` (per-nation policy: offensive/defensive) | offensive | §4, §5 |
| `OwnedDefensiveBudget` | 0.50 | §4 owned budget (defensive doubles to 1.0) |
| `OwnedOffensiveBudget` | 0.50 | §4 owned budget |
| `UnownedOffensiveBudget` | 0.50 | §4 unowned budget |
| `InfluenceCostPer100M` | 1.0 | §4, §5 cost |
| `NeutralNationWeight` | 0.5 | §4 ally/rival weighting |
| `HostileDemoteThreshold` | 0.25 | §3 band |
| `HostilePromoteThreshold` | 0.30 | §3 band |
| `ResearchClaimConversionFloor` | 0.50 | §2 bump |
| `SecessionCultureFloor` | 0.50 | §2 breakaway seed |
| `MinorityRuleThreshold` | 0.40 | §6 malus onset |
| `BeneficialForeignWeight` | 0.3 | §6 effective pop (beneficial calcs) |
| `DetrimentForeignWeight` | 1.3 | §6 effective pop (detriment calcs) |
| `SnapToZero` | 0.0005 | §7 remainder bucket |
| `CulturalMismatchMax` | (existing) | §6 malus scale |
- Claim-source ledger persisted with the same save hook as compositions.

## 9. Test matrix (from the four session scenarios)

1. Flower sim: A offensive / B defensive / C outreach / D offensive — rates must match the session table (±rounding).
2. Occupation cutoff: D occupies A2 → A loses D1 as outreach target; A's defensive budget resplits over 3 regions; D's over 3.
3. Research-claim conversion: 38% culture + research claim → bump to exactly 50%.
4. Hysteresis: share oscillating at 27.5% must not flip hostility repeatedly.
5. Failed payment: any faction short → owned 0.5% only, zero deduction.
6. NoHostileClaims ON → no band writes, mod claims behave friendly.
