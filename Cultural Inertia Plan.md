# Cultural Inertia & Assimilation — Design Plan (rev 9)

## REV 9 AMENDMENT — Claims & Culture Integration (user spec, 2026-10-06)

This section supersedes the conflicting parts of the rev 8 locked parameters (specifically "Seed on capture: 0%" and the C10-friendly-threshold-only rule) where they overlap. It is written as a claim-culture state machine on top of the verified vanilla mechanics.

### Claim provenance (prerequisite, verified in decompile)

- Research-granted claims are distinguishable by an **active `TIBilateralTemplate`** with key `"Claim" + claimant.templateName + region.templateName` (`TemplateManager.Find<TIBilateralTemplate>(..., false)`, `BilateralIsActive()`). Verified: `TIRegionState.cs` lines 2465/2471/2496 (`NationsWithClaim`, `SecessionCandidates`). This test is save/load-proof with zero persistence (templates rebuild from data).
- Mod-generated claims (adjacency/island engine) call `SetClaim(region, true, true)` and have **no** template → `Find` returns null → mod-sourced.
- Caveat: some vanilla runtime claims (faction actions, war outcomes) also lack templates; the bilateral test classifies "research-granted (data-defined)" vs "everything else", which matches the two regimes specified below.
- Note for UI (open item, pending decision): mod claims currently render **no flag icon** in the region list because vanilla's flag column is gated by active templates (`NationsWithClaim` filter), not by claims themselves.

### Claim-culture state machine (normative rules)

1. **Research-granted friendly claim → conversion.** When a nation that holds a research-granted **non-hostile** claim (active template, not in `hostileClaims`) converts a region to its control — by unification (`AbsorbNation`, already hooked via `OnAbsorption`) **or** invasion (`TransferRegionsControlTo`, already patched) — the region's claimant-culture share is seeded to **max(50%, current claimant culture share)**.
   - *Supersedes rev 8 "seed on capture 0%" for this case only.*
1. **Research-granted friendly claim → conversion.** When a nation that holds a research-granted **non-hostile** claim (active template, not in `hostileClaims`) converts a region to its control — by unification (`AbsorbNation`, already hooked via `OnAbsorption`) **or** invasion (`TransferRegionsControlTo`, already patched) — the region's claimant-culture share is seeded to **max(50%, current claimant culture share)**.

2. **Research-granted friendly claims never demote by culture.** A claim whose bilateral template is active and non-hostile **stays friendly regardless of cultural share** (user amendment 21:21). The 50% figure is **not** a standing floor on culture — it is only the **minimum seed on conversion**: a claimant converting the region with, e.g., 38% culture is bumped to 50% at that moment; a claimant whose culture has since fallen to 31% or below is *not* re-floored. The culture value itself floats freely; only the claim's friendliness is protected.

2a. **Mod-generated (adjacency/island) friendly claims demote by culture.** Claims granted by the mod's claim engine that are currently friendly (≥30%) **fall to hostile when the claimant's share drops below 25%** — the hysteresis band's lower bound. There is no template protecting them; only research-granted claims enjoy permanent friendliness. (Supersedes any blanket immunity reading.)
3. **Mod adjacency/island claims start hostile at 0%.** The claim engine (`ClaimAdjacentUnclaimedRegions`) keeps `SetClaim(fromSeizure: true)`; composition untouched — the conquest rule (0% seed) still applies. These claims enter state 4 below.
4. **Conversion band (hysteresis).** Any **vanilla hostile claim** (including research-granted ones that are currently hostile) or **mod-generated claim**:
   - becomes **friendly** when claimant culture share reaches **≥ 30%**;
   - falls back to **hostile** when share drops **< 25%** (mod-sourced friendly claims only — research-granted claims are exempt per rule 2; a research-granted claim that was seeded hostile stays hostile until it earns ≥30%, then never demotes);
   - between 25–30% the current state holds (no thrash).
   - Friendly→hostile flip: `SetClaim(region, fromSeizure: true, forceFromSeizure: true)` adds to `hostileClaims` (TINationState.cs:7668, verified). Hostile→friendly flip: `SetClaim(region, false, false)` on an existing claim routes to `RemoveHostileClaim(region)` (verified).
5. **Hostility derivation.** `ClaimWillBeHostile(region, ...)` (TINationState.cs:7723, verified) is patched per rev 8 (democracy rule → culture band) **plus** state-2 immunity: claims with an active bilateral template that were seeded under rule 1 always return non-hostile. `WillBeBeHostileExplanation` text updated to describe the culture band.

### Occupation mechanics (user spec, 2026-10-06 21:21)

A region that is **occupied** (under `CheckAndTriggerOccupation`-style occupation, vanilla's owner-is-present-but-not-controlling state — the mod already patches/queues on this path) rather than annexed counts for cultural mechanics as follows:

- **Counts as owned by the occupier at half effect.** The occupier's cultural composition tracking treats the occupied region as part of its owned set, but all cultural rates against it — defensive budget grants and cohesion-malus calculations — apply at **×½**.
- **Counts against the occupier's defensive budget at full population cost.** The occupied region's full population enters the inverse-population split of the occupier's 0.5% defensive budget (it dilutes the occupier's home grants like a normal owned region), but only delivers half-strength culture into itself. I.e. it costs the occupier full dilution and returns half assimilation — occupations are culturally expensive to hold.
- **Blocks the original owner's defensive spread, but not its offensive budget.** An occupied region suppresses the original owner's defensive-budget culture along that edge: owned regions of the original owner that border the occupied region gain **no defensive-budget culture from the original owner's Unity completions** for as long as the occupation holds (the original owner's border region set for defensive purposes treats the occupied region as a dead edge). However, the occupied region itself **remains a valid target of the original owner's offensive budget** — the defender's Unity completions still pour their offensive 0.5% split into the occupied region alongside other foreign targets, fighting the occupier's half-strength consolidation and giving the defender a route to win the region back culturally. Ally/rival weighting on that offensive grant is computed against the **occupier** (it's the occupier's control the spread is contesting).
- **Valid Outreach targets.** Occupied regions can be targeted by Cultural Outreach. The **original owner** may Outreach its own lost region (full-strength deposits, same cost formula on the region's population — a focused counter-siege to its own offensive spread). Third nations may also Outreach it: the spread being contested is the **occupier's** half-strength consolidation, so costs and ally/rival weighting are computed against the occupier regardless of who pays. Outreach on an occupied region is a legitimate way to pre-empt the occupier's annexation or flip the region back culturally.
- **Ends when the occupation ends.** On annexation, the normal conversion rules fire (0% seed for conquest, or the research-claim 50% bump if the occupier held a research-granted claim); on liberation/restoration, the original owner's adjacency resumes and the occupier's claims/culture tracking releases the region.

### Minority-rule malus and non-owner population weighting (user spec, 2026-10-07)

1. **Broad Offensive is a mostly passive effect** — by design. It is the background attrition/cultural weather layer; focused cultural agency is Outreach's job. No split cap or cost rebalance is applied; the design intent is that broad offensive is not a competitive conversion tool.

2. **Minority-rule cohesion malus.** A region whose **owning nation's cultural share is below 40%** suffers an additional cohesion malus on top of the existing cultural-mismatch malus: **minority-rule malus = max(0, (40% − ownerShare)) × 2 × mismatchMax** — continuous from 0 at 40% owner culture to full `mismatchMax` (default 20, range 0–30) at 0% owner culture. Low culture hurts proportionally more the deeper the deficit, with no cliff at the threshold. Unassimilated conquests and Outreach-captured regions are thus governed under real minority pressure rather than only claim hysteresis. (Adds to, not replaces, the existing `foreignShare × popWeight × mismatchMax` term.)

3. **Non-owner population weighting.** Any calculation that **benefits from population count** (defensive/offensive budget splits by population weight, Outreach cost basis, absorption/seed sizing) counts the **non-nation cultural populace at ×0.3** — foreign inhabitants are worth 30% of owner-culture inhabitants for beneficial effects. Any **detrimental** calculation (cohesion malus scaling, occupation dilution cost, breakaway pressure) counts them at **×1.3** — foreign pop is 30% heavier in penalties. Rationale: culturally foreign populations contribute less to the state's cultural consolidation but amplify unrest and mismatch pressure. All plan formulas that weight by population should be read with these two multipliers applied to the foreign portion.

#### Resolved edge-case decisions (2026-10-07)

1. **Effective population weight is calculated per region, then summed** for nation-level calculus. The mod must therefore track a per-region cultural-economic decomposition — GDP, influence yield, etc. are aggregated from per-region weighted values, not patched as nation-level scalars. This is the core architectural commitment of the weighting system.
2. **Public-opinion influence income is excluded** from the weighting (item 6 struck from the beneficial list). Influence income reads vanilla `GetPublicOpinionOfFaction` unweighted.
3. **Minority-rule malus scales continuously** — the 40% gate is not a cliff; the penalty ramps from 0 at 40% owner culture to full `(100% − share) × mismatchMax` at 0%. Low culture should hurt continuously, not step. (Supersedes the earlier "at or above 40% it is zero" wording for the *slope*, not the *ceiling*.)
4. **Budget-split weighting uses full population; effect magnitude uses ×0.3/×1.3.** The inverse-pop split decides *where* effort goes (unweighted targeting); the ×0.3/×1.3 weighting applies to how *strongly* the effect lands (efficacy). Separated so struggling regions still receive budget priority while foreign-heavy regions convert more slowly.
5. **Seceded nations seed at 50% owner culture** across all their regions at independence. New nations inherit a plausible base rather than spawning at maximum minority pressure.

**AI reaction to research wobble — verified safe (vanilla decompile audit).**
- `TINationState.research_month` (TINationState.cs:3079) is a live property recomputed per read, not a cached snapshot; the AI planner additionally forces recalculation daily (`GetYearlyIncome(Research, forceRecalculate: true)`, AIDailyFactionPlanner.cs:3285). The AI always sees the current, drifting value — no stale cache to go inconsistent with our weighting.
- Tech race slots are sticky: once `BeginTechRace` is called the slot is locked until the tech completes or `CantWin`/`CantLose` (TIFactionState.cs:16737-16790). Race pacing math is *relative* (own vs rival researchPerDay, AIEvaluators.cs:1083-1110), so slow culture drift moves both sides together — no oscillation. Absolute pacing only matters at race start, a one-shot committed decision.
- Project selection is event-driven: `AIReviewProjects` is set only when a slot frees or a project completes (TIFactionState.cs:7238, AIDailyFactionPlanner.cs:3288-3293), so wobble cannot churn project choices day to day.
- `DistributeResearchToSlots` (TIFactionState.cs:7058) runs daily but culture share moves fractions of a percent per day; slot weights glide.
- Faction nation-value scoring (AIEvaluators.cs:287) reads `nation.research_month` for support/coup/pillage targeting — it glides smoothly; no thrash.
- Net: the ×0.3/×1.3 weighting creates slow drift, and every AI consumer is either sticky, event-gated, or relative. No flip-flopping expected. Intended emergent effect: an assimilating nation's faction tech-race output softens, which the AI reads correctly as reduced pacing.

#### Affected vanilla population-effect calculus (compiled 2026-10-07, verified against decompile + Reference doc)

The ×0.3 (beneficial) / ×1.3 (detrimental) foreign-populace weighting applies to the following vanilla calculations. Classification is by outcome sign for the acting nation, not by code location:

**Beneficial (foreign populace counts ×0.3):**
1. **`economyScore` / `SetBaseInvestmentPoints_month()`** (TINationState.cs:~4530) — IP base is GDP^0.35; GDP is the product of population and per-capita income. Foreign populace contributes 30% of IP weight.
2. **`priorityEffectPopScaling`** (`SetPriorityEffectPopScaling()`, ~4760) — `(pop/50M)^populationBasedIPEffectScaling` multiplies all priority effect magnitudes. Foreign ×0.3 for effects whose outcome is beneficial (Economy income, Knowledge/education, Unity cohesion+, Mission Control, Environment cleanup, etc.).
3. **`economyPriorityPerCapitaIncomeChange × population_Millions`** in `OnEconomyPriorityComplete()` (~5164) — GDP gain scales with pop; foreign ×0.3.
4. **Knowledge priority education gain** (~4871) — scales with `population_Millions/82`; foreign ×0.3.
5. **Welfare priority inequality reduction** (~4863) — scales with `population_Millions/335`; the effect is beneficial, foreign ×0.3.
7. **`MaxAnnualDirectInvestIPs`** (~4786) — `pop^0.175 × GDP^0.175`; foreign ×0.3.
8. **Nation research output** (~3083 formula: education × pop × PCGDP curve × democracy curve × cohesion/unrest modifiers) — foreign ×0.3.
9. **`allowedArmies`** (~3311) — army cap from `population_Millions / minPopulationForAdditionalArmiesPer_millions`; foreign ×0.3 (foreign pops raise fewer home armies).
10. **`spaceDefenseCoverage`** (~3498) — anti-space-defense coverage weighted by region pop; foreign ×0.3.
11. **Annual population growth rate** (~3561) — region-growth weighted by pop; foreign ×0.3.

**Detrimental (foreign populace counts ×1.3):**
1. **`populationImpactOnCohesion`** (~2386) — `−pop^populationCohesionImpactPower`; foreign ×1.3 (foreign-heavy nations take heavier cohesion drag).
2. **`distanceFromCapitalToPopCenter_km`** (~2475) — population-weighted population-centroid feeding `regionsImpactOnCohesion`; foreign ×1.3.
3. **`hostileClaimsImpactOnUnrest` / `TotalImpactFromHostileClaims()`** — pop-weighted hostile-claim unrest; foreign ×1.3.
4. **Separatist-movement cohesion impact** (`cohesionImpactMultiplierIfSeparatistMovement` weighting in claim/cohesion tick) — foreign ×1.3.
5. **Climate damage** (`MonthlyTemperatureEconomicImpact`, ~4350) — environment-damage weighting by `populationInMillions`; foreign ×1.3.
6. **GHG emissions** — `PoptoGHG` (11373: 2.41) converts population to emissions; foreign ×1.3.
7. **Occupation dilution cost** (this mod's own rule, same multiplier set) and **`investmentPoints_occupationPenalty_frac`** (~2392) — penalises IP by occupied GDP proportion, itself pop-driven; foreign ×1.3.
8. **Breakaway/secession pressure term in the minority-rule malus** (this plan) — foreign ×1.3.

**Explicitly out of scope:** nuke/casualty losses (TIRegionState ~1264) — left unweighted; casualties fall uniformly regardless of cultural composition.

**Excluded (structural bookkeeping, unweighted):** perCapitaGDP as a ratio (it divides by total pop — re-weighting the denominator would silently inflate GDP for mixed nations; the ×0.3 already enters through the GDP numerator), population *proportions* in `Independence()`/secession splits (~9556, ~10244), `PeriodicOrganicCoupChance()` (no pop term), unrest rest state (no direct pop term; army-based unrest relief is per-army, not per-pop), and `RandomRegionWeightedByPopulation` targeting (a selector, not an effect).

**Implementation note:** vanilla population fields are read-only aggregates. The mod should implement a `WeightedPopulation(TINationState/TIRegionState, beneficial|detrimental)` helper that splits each region's `populationInMillions` into owner-culture share (full weight) and foreign share (×0.3 or ×1.3), and inject it at the listed call sites via Harmony patches on the getters where feasible (patch the nation-level getters, e.g. an `effectivePopulation` prefix on `population_Millions` is NOT possible — instead patch the specific methods above). Where a method body is too entangled (e.g. research formula), postfix-scale the result by the observed foreign share rather than patching internals.

### Unity completion effect amendment

Supersedes rev 8's flat assimilation rule ("+0.5% owner culture per Unity completion") and the flat portion of the Cultural Outreach policy's effect model.

**Principle (user clarification):** *public opinion is a vanilla mechanic, not a cultural level — it must not scale cultural inertia.* The old `unityPublicOpinionBaseStrength` scaling in `OnUnityCompleted` is retired. Cultural levels live only in the mod's composition model.

**Rule.** When nation A completes a Unity priority:

1. **Owned regions:** every region owned by A gains a **flat +0.5%** of A's state culture, subtracted proportionally from the region's current shares (`NudgeComposition`, CulturalInertia.cs:150 — unchanged behaviour).
2. **Non-owned regions (adjacent/in-range):** all regions adjacent to any A-owned region (the claim engine's `Neighbors` walk) plus all in-range regions (the distance layer's `ShortestBorderDistance_km` threshold used for extended island range) form the affected set. The **same 0.5% budget is divided across the whole affected set, weighted inversely by population** — each region's grant is `0.5% × (1/pop) / Σ(1/popᵢ)` over affected non-owned regions: more population = harder to influence. Ownership modifiers still apply before distribution:
   - region owned by an **allied nation** of A → **excluded** from the affected set (nullified);
   - region owned by a **non-rival nation** → counts with **half weight** (its effective grant halved);
   - unclaimed / rival-owned / non-allied foreign → full weight.
   Ally status via the vanilla alliance relation used by `GetAllyReachableDiscontiguousRegions`; rivalry via `TINationState.rivals`.
3. **Cultural Outreach policy is retained** — it is now the player-directed way to concentrate influence on a single targeted region (bypassing the population dilution for that one region). Description to be reworded at implementation.

**Resolution refactoring note.** Population-weighted fractional grants (e.g. 0.04% on a large neighbour) fall below the current composition resolution — the model's minimum quantum. The composition representation must be refactored to accumulate sub-resolution deltas: either (a) switch shares to higher-precision storage (float accumulation with a global remainder/slop bucket per region), or (b) move to integer basis-point/permille counters. Decision (2026-10-07): adopt (a) — float accumulation with increased resolution, and adjust the snapping ratios accordingly. Below-resolution grants must be *carried*, not discarded, so repeated completions still reach the 30% band eventually. The snap-to-zero threshold (<0.5%) is adjusted to match the finer resolution so genuine small grants are not clipped.

**Influence cost (user spec, amended 20:26).** Unity priority completion now carries an **influence cost for the non-owned spread**, scaling with the affected foreign population:

- Cost formula: `cost = Σ(affected unowned/foreign pop) / 100M` — **1 influence per 100M affected population, no cap** (the earlier 2-cap is removed).
- **Who pays — control-point split:** the cost is charged to the **controlling factions of the completing nation's control points**, split **proportionally** by point ownership: faction A holding 3 of 4 points pays 0.75, faction B holding 1 pays 0.25. Each faction pays its share if it can afford it (per-faction `CanAffordInfluence` on its share); a faction that cannot afford its share skips it — the other factions' paid shares still fund a proportional fraction of the spread (see below).
- **Unowned control points get a free pass:** any point of the nation held by no faction contributes no payer and no cost share — that fraction of the spread happens free.
- **All-or-nothing payment (user amendment):** if **full** payment cannot be made in the proportional split, **no payment is deducted at all** and only the **defensive budget** applies (see budget model below) — the non-owned spread is skipped entirely. Partial spreads are out.

**Budget model (user amendments, 21:00–21:01):** each Unity completion grants a **0.5% offensive budget and a 0.5% defensive budget** — the same magnitude, spent according to stance. The **offensive budget** is split inverse-population across the affected non-owned set (rule 2). The **defensive budget** is split by the **same inverse-population logic across all owned regions** (supersedes the flat 0.5% per owned region and the former ×2 defensive doubling). **Defensive stance rolls the offensive budget into the defensive budget:** a Defensive completion spends the full **1.0%** across owned regions; a failed offensive payment leaves only the base **0.5%** defensive budget — so Defensive is genuinely stronger at home, and a failed offensive is not.
- **Payment path:** per-faction share check via `TIFactionState.CanAffordInfluence(share)` for **all** payer factions first; only if every faction can afford its share are all shares deducted via `AddToCurrentResource(−share, FactionResource.Influence, ...)` (TIFactionState.cs:869 pattern, same as the mod's LegitimiseClaim option). Any one faction failing its check → nobody pays, no spread.
- **Order:** compute affected set → cost → all-or-nothing affordability check → owned nudges → spread (only if paid).
- AI factions pay on the same terms; there is no player/AI distinction. Uncontrolled nations (no faction holds any point) spread entirely free.

**Offensive/Defensive cultural stance policy (user spec, same evening).** A **new national policy option pair** (third synthetic key, `(PolicyType)1003`, registered by the existing `Patch_RegisterPolicyOptions` postfix alongside 1001/1002) toggles the nation's cultural spread stance:

- **Offensive (default):** the rules above — owned nudges at 0.5%, influence cost paid for the pop-weighted non-owned spread.
- **Defensive:** the offensive budget is rolled into the defensive budget — the full **1.0%** is split inverse-pop across owned regions. No influence cost is incurred.
- **Offensive, payment failed:** the offensive budget is not spent and no payment is deducted; the **defensive budget (0.5%) applies to owned regions only** — weaker than a true Defensive completion, which is the point: switching to Defensive buys consolidation strength.
- Per-nation state: the stance is a property of the nation (set by whoever controls it via the policy), read by `OnUnityCompleted` at completion time. Save/load persistence follows the same path as the existing mod policy options.
- The policy pair overrides the mod's existing synthetic options' pattern: two mutually exclusive options (Offensive / Defensive), same `TIPolicyOption` subclass surface already verified in §4.13 of the E2E doc.

**Interaction with rev 9 C13:** claim-band evaluation (C13c) reads shares after the completion pass in the same tick; a completion that pushes a claimed region to ≥30% flips the claim that tick.

### Implementation plan (checkpoint C13, extends C10)

| Part | Work | Est. credits |
|---|---|---|
| C13a | Provenance helper `IsResearchGrantedClaim(nation, region)` (bilateral template test) + call-site wiring in the claim engine and `TransferRegionsControlTo` patch | ~40 |
| C13b | Rule 1 seeding: conversion hook reads provenance, seeds `max(0.5, share)` via `NudgeComposition`-style blend; rules fire from the existing `OnAbsorption` and `TransferRegionsControlTo` postfixes | ~60 |
| C13c | Rule 4 hysteresis evaluation: periodic pass (DailyUpdate cadence or on completion/capture events) flips claims via `SetClaim`; shares read from `CulturalInertia` composition | ~70 |
| C13d | Rule 5: `ClaimWillBeHostile` / `WillBeHostileExplanation` patches extended with template-based immunity; tooltip text reflects the new rules | ~40 |

Estimated total: ~210 credits.

### Design notes / risks

- **Third-party conversion:** rule 1 fires only when the *claimant* converts the region. If a different nation seizes a research-claimed region, no seed occurs (their own claim path applies); on reconquest by the original claimant the floor re-applies.
- **`NoHostileClaims` setting interaction:** that setting mass-clears `hostileClaims`; with rev 9 rules it should be re-scoped or retired in favour of the band, else the two fight each other. Decision pending user.
- **Flag-icon visibility:** mod claims remain invisible in the region-list flag column unless the runtime-template injection discussed this session is implemented; this is orthogonal to the state machine and can be a separate checkpoint (C14) if wanted.
- **Democracy rule removal:** rev 8 already replaces `HostileClaimDueToDemocracy` with the culture band; rule 2's immunity relies on that replacement being in place.

### Original rev 8 locked parameters (retained; superseded only where rev 9 conflicts)

## Locked parameters (full set)

- **Seed on capture:** 0% — conquest never changes culture by itself; only Unity completions and recognised absorptions do.
- **Cohesion malus:** `(foreignShare × popWeight) × culturalMismatchMax`, default 20 (slider 0–30). More severe than vanilla hostile claims (maxCombinedImpactFromHostileClaims = 16).
- **Defunct nations:** frozen display name.
- **Assimilation:** flat +0.5% owner culture per Unity completion, taken proportionally from other cultures; <0.5% snaps to zero.
- **Friendly-claim threshold:** 30% culture share, configurable (default 30). Replaces vanilla democracy-based hostile-claim logic; `ClaimWillBeHostile` patched; `WillBeHostileExplanation` text updated; vanilla hostile-claim cohesion/unrest penalties zeroed and replaced by the cultural malus. *(Rev 9 adds hysteresis fallback at <25% and research-claim immunity — see the rev 9 amendment.)*
- **Cultural Outreach policy:** apply your Unity completions to one foreign claimable region (any region claimable under creeping-borders rules). **Influence cost identical in form to the broad offensive spread** (user amendment 20:32): 1 influence per 100M of the **target region's population** per Unity completion, no cap, paid by the completing nation's control-point factions proportionally, all-or-nothing — if payment fails, that Outreach completion applies the defensive budget to owned regions only and the target's clock does not advance. Confirmation dialog on selection shows live cost + remaining completions to 30%. Auto-cancel: exec control point of target or executing nation changes faction. One target per nation. AI may use it on adjacent claimable regions.
- **Absorption:** recognised unification (via requiredNationState research projects) seeds absorbed regions at 50% absorber culture; unrecognised seeds unchanged.
- **UI:** region tooltip culture breakdown (sorted shares, <0.5% hidden, frozen names for defunct nations) + assimilation progress ("Assimilation: 37%, 163 completions remaining"); claim UI recolors on the 30% threshold.
- **Persistence:** culture compositions saved in savegame structure; fallback on load = current owner at 100%.

## Breakaways

1. **Trigger stays vanilla** (cohesion ≤ 3, unrest ≥ 6 drives DailySecessionCheck and the instigated path); the cultural malus feeds it indirectly. No trigger patch.
2. **Culture-weighted defection (postfix):** `defectChance × (1 + 2 × claimantCultureShare − ownerCultureShare)` — assimilated regions stay loyal; culturally-aligned revivers become natural magnets.
3. **No reconquest seed.** A region retaken by its former owner keeps its composition exactly as it was; only Unity completions move culture. No special-case seeds anywhere except breakaway formation and recognised absorption.
4. **Breakaway nations spawn at 50%:** new nation's founding regions seed 50% new-nation culture / 50% parent culture (frozen parent name on the parent's share). Formation, not conquest.
5. **Breakaway malus relief:** ×0.5 cultural mismatch malus while `breakaway == true` (vanilla never clears breakawayParent, so effectively permanent).
6. **Frequency multiplier:** organic secession chance ×3 (slider 1–10); instigated path unchanged.

## Mod menu tunables

Friendly threshold (default 30) · max malus (default 20, range 0–30) · breakaway frequency multiplier (default ×3, range 1–10) · breakaway malus relief (fixed ×0.5). *(Outreach cost unified with the broad spread at rev 9: 1 influence per 100M target pop, proportional control-point split, all-or-nothing.)*

## Balance watch-items for playtesting

- At malus 20 a large unassimilated conquest can floor cohesion to 0 → full instability spiral (coups, breakaways). Intended: Outreach-before-conquest (pre-pump to 30%+) halves the malus before taking the region.
- Hostile/friendly claim distinction after the 30% rule: conquest-then-outreach (friendly, no capital secession 3× modifier) vs land-grab (hostile claim, 3×) gets a real mechanical distinction.
- ×3 breakaway multiplier compounds with the malus; verify nations don't chain-collapse too fast.

## Implementation notes (from code reconnaissance)

- Hook for per-completion assimilation: `TINationState.OnUnityPriorityComplete` (postfix).
- Daily hook for nothing — assimilation is Unity-driven only, not time-based.
- Cohesion malus goes into `cohesionRestState` computation (same place as the existing non-contiguity malus in the mod's cohesion patch).
- Absorption hook: `TINationState.AbsorbNation` (postfix); recognised = nation is a `requiredNationState` of a unification project valid for the absorber.
- Breakaway helpers to patch: `TINationState.DailySecessionCheck` (region-selection predicate culture weighting) and `SecessionChance` (frequency multiplier postfix).
- Outreach policy registers via `PolicyManager.policies`, same as existing mod policies.
