# Cultural Inertia & Assimilation — Design Plan (rev 8)

## Locked parameters (full set)

- **Seed on capture:** 0% — conquest never changes culture by itself; only Unity completions and recognised absorptions do.
- **Cohesion malus:** `(foreignShare × popWeight) × culturalMismatchMax`, default 20 (slider 0–30). More severe than vanilla hostile claims (maxCombinedImpactFromHostileClaims = 16).
- **Defunct nations:** frozen display name.
- **Assimilation:** flat +0.5% owner culture per Unity completion, taken proportionally from other cultures; <0.5% snaps to zero.
- **Friendly-claim threshold:** 30% culture share, configurable (default 30). Replaces vanilla democracy-based hostile-claim logic; `ClaimWillBeHostile` patched; `WillBeHostileExplanation` text updated; vanilla hostile-claim cohesion/unrest penalties zeroed and replaced by the cultural malus.
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
