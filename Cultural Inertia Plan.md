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
2. **Research-granted friendly claims are immune to demotion.** A claim in state 1 can never fall to hostile by cultural incompatibility. Implementation note: because the 50% floor exceeds the 30% friendly threshold, and owner-culture share is monotonically non-decreasing (culture only moves via Unity completions and recognised absorptions in the owner's favour), the seed itself guarantees permanent friendliness — **no separate immunity flag or persistence is required**. `ClaimWillBeHostile`'s culture rule simply cannot trip at ≥50%.
3. **Mod adjacency/island claims start hostile at 0%.** The claim engine (`ClaimAdjacentUnclaimedRegions`) keeps `SetClaim(fromSeizure: true)`; composition untouched — the conquest rule (0% seed) still applies. These claims enter state 4 below.
4. **Conversion band (hysteresis).** Any **vanilla hostile claim** (including research-granted ones that are currently hostile) or **mod-generated claim**:
   - becomes **friendly** when claimant culture share reaches **≥ 30%**;
   - falls back to **hostile** when share drops **< 25%**;
   - between 25–30% the current state holds (no thrash).
   - Friendly→hostile flip: `SetClaim(region, fromSeizure: true, forceFromSeizure: true)` adds to `hostileClaims` (TINationState.cs:7668, verified). Hostile→friendly flip: `SetClaim(region, false, false)` on an existing claim routes to `RemoveHostileClaim(region)` (verified).
5. **Hostility derivation.** `ClaimWillBeHostile(region, ...)` (TINationState.cs:7723, verified) is patched per rev 8 (democracy rule → culture band) **plus** state-2 immunity: claims with an active bilateral template that were seeded under rule 1 always return non-hostile. `WillBeBeHostileExplanation` text updated to describe the culture band.

### Unity completion effect amendment (user spec, 2026-10-06 — same session as rev 9; amended same evening)

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

**Resolution refactoring note.** Population-weighted fractional grants (e.g. 0.04% on a large neighbour) fall below the current composition resolution — the model's minimum quantum. The composition representation must be refactored to accumulate sub-resolution deltas: either (a) switch shares to higher-precision storage (float accumulation with a global remainder/slop bucket per region), or (b) move to integer basis-point/permille counters. Decision at implementation; (a) is the lower-risk default. Below-resolution grants must be *carried*, not discarded, so repeated completions still reach the 30% band eventually.

**Influence cost (user spec, amended 20:26).** Unity priority completion now carries an **influence cost for the non-owned spread**, scaling with the affected foreign population:

- Cost formula: `cost = Σ(affected unowned/foreign pop) / 100M` — **1 influence per 100M affected population, no cap** (the earlier 2-cap is removed).
- **Who pays — control-point split:** the cost is charged to the **controlling factions of the completing nation's control points**, split **proportionally** by point ownership: faction A holding 3 of 4 points pays 0.75, faction B holding 1 pays 0.25. Each faction pays its share if it can afford it (per-faction `CanAffordInfluence` on its share); a faction that cannot afford its share skips it — the other factions' paid shares still fund a proportional fraction of the spread (see below).
- **Unowned control points get a free pass:** any point of the nation held by no faction contributes no payer and no cost share — that fraction of the spread happens free.
- **Funding fraction semantics:** total spread potency = sum of paid shares ÷ total cost. If all payer factions afford their shares, the full pop-weighted split applies; if only half the cost is paid, the non-owned spread proceeds at half strength (grants scaled proportionally). Owned-region nudges (rule 1) always apply in full regardless.
- **Payment path:** per-faction `TIFactionState.CanAffordInfluence(share)` then `AddToCurrentResource(−share, FactionResource.Influence, ...)` (TIFactionState.cs:869 pattern, same as the mod's LegitimiseClaim option).
- **Order:** compute affected set → cost → per-faction affordability & payment → owned nudges → spread (paid fraction only).
- AI factions pay on the same terms; there is no player/AI distinction. Uncontrolled nations (no faction holds any point) spread entirely free.

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
- **Cultural Outreach policy:** apply your Unity completions to one foreign claimable region (any region claimable under creeping-borders rules). Cost: 1 influence per 10M population of the target per Unity completion (configurable). Confirmation dialog on selection shows live cost + remaining completions to 30%. Auto-cancel: exec control point of target or executing nation changes faction, or first failed influence payment. One target per nation. AI may use it on adjacent claimable regions, budget-checked.
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

Friendly threshold (default 30) · max malus (default 20, range 0–30) · outreach base cost (default 1 influence / 10M pop) · breakaway frequency multiplier (default ×3, range 1–10) · breakaway malus relief (fixed ×0.5).

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
