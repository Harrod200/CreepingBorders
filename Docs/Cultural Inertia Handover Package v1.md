# Cultural Inertia (C13) — Handover Package v1

Date: 2026-10-07. For an AI dev implementing Cultural Inertia with minimal
friction. Everything here is decided; do not relitigate (§8).

## 0. Fast-start checklist

1. Read `Docs/Efficiency Instructions for Future Instances.md` (golden rules).
2. Run `PREFLIGHT.sh` (or restore-build.sh). Build must be green before edits.
3. Read `Docs/Cultural Inertia Plan.md` (rev 9, repo root of /rool-drive/CB)
   — the behavioural contract. Then this package. Then code.
4. Search `Docs/Terra Invicta Class & Method Reference.md` (2.9 MB, VERIFIED)
   before decompiling anything. Never use the two
   `Terra_Invicta_Decompiled_Architecture*.md` files — they invent methods.
5. Read `Docs/Handover Notes v5.md` for build/deploy mechanics and the C1–C5
   context you're building on top of.

## 1. Scope: what C13 is

Replace Terra Invicta's single-value regional alignment with a per-region
**cultural composition** (cultureId → share). Culture moves ONLY through mod
events: Unity completions, Outreach deposits, and one-way conversion seeds.
Conquest alone never changes culture. Claims become culture-driven with a
30%/25% hysteresis band; research-granted claims are permanently friendly.
Two AI layers (stance + Outreach) make AI nations use the systems.

## 2. Files to create / touch

| File | Action | Contains |
|---|---|---|
| `CulturalInertia.cs` (exists, 448 lines) | extend | composition store, save/load, AbsorbNation hook (already at :399), Unity completion hook (already at :389) |
| `CulturalInertiaClaims.cs` | NEW | claim provenance, conversion seeding, hysteresis |
| `CulturalInertiaUnity.cs` | NEW | Unity budgets, stance split, influence payment |
| `CulturalInertiaEconomy.cs` | NEW | effective-pop weighting, minority malus |
| `CulturalInertiaAI.cs` | NEW | stance AI, Outreach AI, daily tick |
| `CreepingBordersCls.cs` (2853 lines) | extend | Outreach gates (~2513/2625), TransferRegionsControlTo postfix (:2186), PolicyManager patch (:2474), settings class |

## 3. The nine mechanics (all normative)

1. **Composition store** — `region → (cultureId → share)`, normalized,
   high float resolution with a remainder bucket (snap-to-zero 0.0005).
   Persist in savegame; fallback on load = current owner at 100%.
2. **Unity completion budgets** — base IP = GDP_B^0.35 × 1.0 (vanilla
   economyScore); monthly IP × 12/365.2422 = daily Unity IP; flat 2 IP per
   completion. Per completion:
   - Owned regions: inverse-population split of a budget.
   - Defensive stance: 1.0% (both budgets rolled in), zero unowned spread, free.
   - Offensive stance: 0.5% owned + 0.5% unowned. Unowned target set =
     adjacency ∪ island-range; ally regions null-weighted, non-rival ×0.5,
     rival ×1.0. Cost = 1 influence per 100M affected foreign pop, no cap,
     paid proportionally by the nation's control-point factions,
     **all-or-nothing** — failure = owned 0.5% only, no deduction.
3. **Focused Outreach** — one foreign claimable region per nation (must be
   adjacent or in island range; occupied regions are valid targets). Cost =
   1 inf per 100M target pop, same all-or-nothing rules. Full Unity budget
   lands on the single target.
4. **Conversion seeds** (all bump-only, invariant: capture never lowers the
   capturer's share):
   - Research-claim conversion → max(50%, current share).
   - Unrecognised absorption → max(50%, current).
   - Breakaway founding regions → 50% new nation / 50% parent.
   - Plain conquest / mod claims → 0% seed (composition untouched).
   - Occupation liberation → composition persists, no reset.
5. **Claim hysteresis** — friendly ≥30%, demote to hostile <25%, promote
   back at ≥30%. Research-granted claims (active TIBilateralTemplate) are
   IMMUNE: never demote, never flip. Mod claims (no template) demote.
   Vanilla `NoHostileClaims` setting OVERRIDES all hostile-claim writes.
6. **Occupation** — occupier delivers culture at ×½ strength with full pop
   dilution cost. Original owner's DEFENSIVE spread along the occupied edge
   is blocked, but its OFFENSIVE budget still targets the occupied region.
   Rivalry/ally weighting computed vs the occupier.
7. **Effective population** — foreign populace counts ×0.3 in beneficial
   calculus (economyScore/IP, priorityEffectPopScaling, research_month) and
   ×1.3 in detrimental calculus (populationImpactOnCohesion, unrest from
   pop, +7 more entries in the plan's tables). EXCLUDED: nukes, casualty
   losses, public opinion. Computed PER REGION and summed for nation level.
8. **Minority-rule malus** — below 40% owner culture, continuous penalty
   (no cliff): `(threshold − share) × culturalMismatchMax × scale`, added to
   the cohesionRestState patch. Scaled (not flat) to exacerbate low-culture
   pain; proportional to affected population share.
9. **AI layers** — vanilla adapts for free (Unity self-correction via
   cohesionWarning loop; faction targeting via EvaluateNation reading the
   reweighted economyScore/research_month). NEW: stance AI (defensive when
   losing culture/occupied/at-war-and-poor; offensive when influence >
   buffer + projected 30d spend; buffer default 15) evaluated on the 14-day
   nation cadence; Outreach AI daily, one target per cooldown (30d), score
   gate 0.5, near-promotion band (25–30%) weighted highest. Player nations:
   never AI-set. Uncontrolled nations: neutral default.

## 4. Patch points (ref md-verified)

| Hook | Anchor | Type |
|---|---|---|
| `TINationState.OnUnityPriorityComplete` | ref md 23789; CulturalInertia.cs:389 | prefix, `__runOriginal=false`, master-toggle passthrough |
| `TINationState.AbsorbNation` | TINationState.cs:9801; CulturalInertia.cs:399 | postfix |
| `TransferRegionsControlTo` | ref md 23980; CreepingBordersCls.cs:2186 | extend existing postfix |
| `cohesionRestState` getter | ref md 23616 | postfix (add malus) |
| economyScore / research_month / priorityEffectPopScaling / populationImpactOnCohesion | TINationState §23616 | postfix getters |
| Outreach gates | CreepingBordersCls.cs ~2513/2625 | modify |
| Stance policy key | PolicyManager patch pattern, CreepingBordersCls.cs:2474 | 3rd synthetic policy |
| AI stance tick | `PeriodicNationUpdateTask` (NationPeriodicUpdate.cs:90, 14d cadence; vanilla Unity logic at :150) | postfix |
| AI Outreach tick | `AIDailyFactionPlanner` daily update | postfix |
| Save/load | CulturalInertia.cs:428/438 | extend with remainder + claim-source ledger |

## 5. Settings (ALL numbers are UMM options, defaults shown)

`OwnedDefensiveBudget` 0.50 · `OwnedOffensiveBudget` 0.50 ·
`UnownedOffensiveBudget` 0.50 · `InfluenceCostPer100M` 1.0 ·
`NeutralNationWeight` 0.5 · `HostileDemoteThreshold` 0.25 ·
`HostilePromoteThreshold` 0.30 · `ResearchClaimConversionFloor` 0.50 ·
`SecessionCultureFloor` 0.50 · `MinorityRuleThreshold` 0.40 ·
`BeneficialForeignWeight` 0.3 · `DetrimentForeignWeight` 1.3 ·
`SnapToZero` 0.0005 · `CulturalMismatchMax` (existing, default 20) ·
`AiInfluenceBuffer` 15 · `AiOutreachCooldownDays` 30 ·
`AiOutreachMinScore` 0.5 · `EnableCulturalInertia` (master toggle, ON).

**Master toggle:** one early-return gate at the top of every mod hook;
OFF → claims and Unity behave exactly as vanilla.

Breakaway items (rev 8, still in force): culture-weighted defection
`defectChance × (1 + 2×claimantShare − ownerShare)`; breakaway malus relief
×0.5; organic secession chance ×3 (slider 1–10).

## 6. Build & test

Build: two commands, `Docs/Build Setup.md` / restore-build.sh (net48).
Deploy: Debug_Toggle.bat / Deploy.bat. `modinfo.json` version 0.4.0 — bump
on shipping.

Test matrix (from the session's four scenarios — recreate with the same
parameters):
1. Flower sim (A offensive / B defensive / C outreach-on-D1 / D offensive,
   full mutual adjacency, all rivals, affordable, all 100% own-culture):
   rates must match the session table ±rounding. A 5.36 completions/30d.
2. D occupies A2 (3M) cutting A–D1 link → A loses D1 as Outreach target;
   A defensive budget resplits 4→3 regions; D's over 3 (incl. A2 at ×½).
3. 38% culture + research claim conversion → exactly 50%.
4. Share oscillating at 27.5% must not flip hostility repeatedly.
5. Any payer faction short → owned 0.5% only, zero influence deducted.
6. NoHostileClaims ON → no band writes; mod claims behave friendly.
7. Capture invariant: walk all capture paths; capturer share never falls.
8. Master toggle OFF → vanilla behaviour everywhere.

## 7. Provenance & gotchas

- Reference md verified: TINationState.cs:4768 (daily IP conversion),
  TIEffectsState.cs:3056 (AbsorbNation call site), TIRegionState.cs
  2465/2471/2496 (research-claim template test).
- Research-claim test is save/load-proof with zero persistence (templates
  rebuild from data) — do not add a persistence layer for it.
- France→EU unification: absorber TINationState persists; shares carry
  through rename intact. ONLY custom case: template renames the JOINING
  nation into an extant third culture → merge shares before destruction.
- No flag icon on mod claims = deliberate feature (visual differentiation);
  do NOT implement runtime-template injection.
- AI never thrashes on the research wobble: research_month is recomputed
  per read; AIDailyFactionPlanner forces daily recalculation (AIDailyFactionPlanner.cs:3285).

## 8. Design decisions in force (do not relitigate)

Full amendment log: git history in this repo (`git log --oneline` — rev 9
commits run 791c8f7..4656c95, dated 2026-10-06/07). Key rulings:
- 2026-10-07 00:41 — Broad Offensive is passive by design (weather layer;
  Outreach carries agency). Minority malus added; ×0.3/×1.3 weighting added.
- 2026-10-07 01:07 — per-region effective-pop summation; public opinion
  excluded; malus scaled; secession seed 50%.
- 2026-10-07 01:17 — NoHostileClaims overrides; no flag icon is a feature;
  float resolution raised, snapping ratios adjusted.
- 2026-10-07 21:01 — defensive rolls offensive+defensive budgets into 1.0%
  owned. 21:21 — research claims stay friendly at any share; 50% is
  conversion-only bump. 21:25 — occupied regions affected by defender's
  offensive budget. 21:28 — occupied regions remain valid Outreach targets.
- 2026-10-07 01:44 — capture non-loss invariant verified; absorption seed
  fixed to max(50%, current).

## 9. What is NOT in scope

- C4 declarative national states, C5 rising threat narrative (separate tasks).
- HostileClaimsBlockCreep sub-option (D44) — separate, outstanding.
- Less-invasive policy refactor — proposal ready in Docs, apply separately.
- Map-data flag questions (Svalbard polygon etc.) — for the map author.
