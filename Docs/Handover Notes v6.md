# Creeping Borders — Handover Notes v6

Date: 2026-09-21 (evening)
Prepared after session 6 (C2 revision, absorption removal, patch fixes). Supersedes v5.
Read the locked contiguity spec below first — it is the authoritative behavioural
contract. Decision log: Docs/Handover Decision and Findings Log.md (D41–D54).
Repo head: 83213a0 (build green, working tree clean).

## What's new in v6 (vs v5)
- **C2 revised (D50)**: assimilation is flat 0.5% per Unity completion (slider),
  not per absorption (b7e4217).
- **C3-culture absorption mechanic REMOVED (D51)**: vanilla absorption has no
  direct culture effect; AbsorptionRecognitionRate and all absorption
  culture-blending deleted (f3dff60), stale UI label fixed (83213a0). Assimilation
  runs only via Unity completions + planned C11 outreach.
- **Patch-class duplication bug fixed (D52)**: C8/C9/C10 patches in
  CulturalInertia.cs were duplicated and stranded outside the namespace with a
  missing close brace (1aa7e1e). Build is green; 9 unique patch classes verified.
- **C6–C10 implemented** (session 5, owner machine): daily secession reweight,
  SecessionChance 3x slider, breakaway 50/50 spawn, >=30% shared-culture
  non-hostile claims, breakaway mismatch-malus relief.
- **C11 spec only — NO CODE**: Cultural Outreach policy. Research notes in the
  cheat sheet (Session 6 additions): registration mirrors CreepingBordersCls.cs
  policy options; Loc keys `CreepingBorders.<ClassName>.*`;
  TIPolicyOptionWithConfirm is AI-approval, use vanilla RequiresTargetConfirm for
  the payment confirm; influence payment mirrors existing targeted policies;
  targeting reuses adjacency/contiguity helpers. ~120 credits to implement.
- First session task: implement HostileClaimsBlockCreep (still outstanding, item 1 below).


## Reference documents (read FIRST, before touching code)
- `Docs/Terra Invicta Class & Method Reference.md` — 2.9 MB index of every
  class/method/field in the decompiled game, verified against the source
  (spot-checked: TIGameState, TIFactionState, TIRegionState all accurate).
  Search this BEFORE decompiling anything. NOTE: this is a verified doc; the
  two `Terra_Invicta_Decompiled_Architecture*.md` files in attachments are NOT
  trustworthy (contain invented methods, e.g. PreTurnUpdate hooks that do not
  exist) and are deliberately excluded from this zip.
- `Docs/Vanilla API Cheat Sheet.md` — curated, project-specific version of the
  same knowledge. Grows only; add findings back at end of session.

## What's new in v4
- **C3 implemented and building clean**: `PolygonalRegionConnectivityManager.cs`
  (connected to csproj; `dotnet build` => 0 errors).
- **Build environment solved**: the v3 blocker ("reference assemblies not found")
  is fixed by `Docs/Build Setup.md` + `restore-build.sh`. Setup is now ~2 commands.
- **Vanilla API cheat sheet restored**: `Docs/ADJACENCY_MOVEMENT_ANALYSIS.md` is
  back (recovered from git commit d79a090) — includes decompiled bodies of
  IsAdjacent / AdjacentRegions / Neighbors and adjacency-type semantics.
- **Handover template** added: `Docs/Handover Template.md` — fill this in for v5.

## Current task state
| Task | Status |
|------|--------|
| C1 distance layer | done, pushed (owner machine) |
| C2 object placement | done, pushed (owner machine) |
| C3 connectivity manager | **code complete in this zip** — verify + push |
| C4 declarative national states | not started |
| C5 rising threat narrative | not started |

## C3 quick facts (so the next session doesn't re-derive them)
- File: `PolygonalRegionConnectivityManager.cs` (~250 lines), self-contained.
- Levels: `Disconnected < Distant < Partial < Full < Capital`; strongest link to
  nation capital wins. Enum is at the top of the file.
- Fixpoint BFS from nation capital over `AdjacentRegions(false)`, blocked by
  rivals/at-war (`CanTraverse`).
- FC = any land-connected region. PC propagates from FC regions to immediate land
  neighbours. Regions with `GetLandmassType() == LandmassType.Island` are skipped
  from PC propagation (island chain gate from the plan amendment).
- DC = capital-continental regions within `PartialDistanceX` (default 300, equals
  the mod's option-claim-distance; re-read it from `ModControl.main.optionClaimDistance`
  if available rather than hard-coding) that are NOT land-connected — a
  cross-continental partial-claim bucket.
- Distance calls go through `GeographicPolygonMath.GetRegionPairDistance(a, b, X, 3X)`
  which hits the C1 cache; X is `optionClaimDistance`, 3X matches the bbox
  pre-filter pad in `TIRegionState_BorderDistance.cs`.
- Not yet wired into `CreepingBordersCls` — that's the first C4 step (replace the
  old contiguity BFS in `CreepingBordersCls.cs` around line 383-570).
- Old contiguity code kept intact for reference; C4 deletes it.


## Contiguity behaviour spec — LOCKED 2026-09-21 (owner, this session)
Supersedes the "C3 quick facts" description above. No further code changes this
session; this section is the authoritative behavioural contract.

### Levels
- FC (Full), PC (Partial), DC (Disconnected). Only FC and PC count as connected
  for the cohesion malus; DC never does. Strongest link to the capital wins.

### X
X = `ClaimIslandsDistanceKM` user setting (default 1,000 km; debug slider
50–2,000 km step 50). 2X = extended threshold.

### Propagation
- **Pass A — land adjacency (BFS from capital).** Own/unclaimed regions: level
  passes unchanged. Allied regions: traversable (unbroken BFS chain);
  degradation applies ONCE PER ALLIED NATION crossed on the path
  (Full→Partial, Partial→Disconnected), not per region. All other foreign
  (hostile, unaligned-owned, neutral): hard blocker. PC inherits from PC only
  via Pass A.
- **Distance pass — islands only.** Applies only when at least one endpoint is
  an island; continental-to-continental distance linkage is never considered.
  Distance is polygon-to-polygon (intervening regions irrelevant). Only
  Full-level regions project across distance.
  - Island target: within X of a Full source (island or continental,
    cross-landmass allowed) → FC; within 2X → PC; beyond → DC.
  - Continental target: FC ONLY, and only within X of an FC island. A
    continental region never inherits PC from an island.
- **No region inherits PC from a PC region via distance** — PC sources are Full
  regions only (vanilla adjacency aside).
- **Owner clarification (14:24):** a continental region whose PC came from Pass
  A (BFS allied degradation) CANNOT upgrade to FC via an island bridge. The
  island-bridge FC grant applies only to continental regions with no BFS-sourced
  linkage (DC from Pass A); a BFS-sourced PC stays PC regardless of nearby FC
  islands. Monotonicity aside: island FC never overwrites BFS-derived PC.
- **Island propagation within an island group:** the island region closest to a
  Full source connects via the distance logic; the remaining regions on that
  island connect via normal BFS (Pass A) from it.
- Monotonicity: best level wins; improvements re-enqueued; degradations never
  overwrite a better result.

### Claim-creep rule (owner, 13:56)
`ClaimAdjacentUnclaimedRegions` must NOT propagate claims from hostile claims —
only friendly claims generate further claims. A hostile claim on a region must
not cause that region to spawn additional adjacent claims in later passes.
Implementation (next code session): in the claim pass, skip neighbours whose
current claim is hostile (`nation.hostileClaims.Contains(neighbor)` and/or the
claim came `fromSeizure` in a hostile context) when deciding what to propagate.

### Canonical creep example (owner, 14:05) — defines the desired behaviour
Setup: Nation A has 1 region (A1). Nation B has 3 in a line: B1–B2–B3–A1.
1. Creep gives A a **hostile claim** on B3 (adjacent to A1).
2. A legitimises the claim (Legitimise Claim policy, 90 influence) → friendly.
3. A captures and annexes B3. **Creep now gives A a hostile claim on B2** — this
   is the only forward creep step; the newly controlled region does NOT spawn a
   friendly claim.
4. A captures and annexes B2. B2 is A-controlled but the claim **remains hostile**.
   **Creep does NOT propagate to B1** while the B2 claim is hostile.
5. Vanilla mechanics (unity/government priority investment on B2) legitimise A's
   ownership of B2, removing the hostility from its claim.
6. Only now does creep propagate: A gets a hostile claim on B1.

Implications: creep advances exactly one ring from *friendly-claimed or owned*
regions whose claim/ownership is legitimised; hostility acts as a gate that
vanilla priority investment removes over time. Hostile claims neither propagate
nor get auto-legitimised by the mod. Verify against
`TINationState.claims` / `hostileClaims` / `nonHostileClaims` semantics and the
`accumulatedLegitimizeClaimTriggers` mechanic (priority investment raising it →
claim legitimation), which is the intended de-hostilising loop.

### NEW PLAN ITEM: Claim-creep source gating (owner, 14:16) — no code yet
Add a UMM sub-option under the creeping-borders settings, **default enabled**:
`HostileClaimsBlockCreep` (name TBD).

- **Enabled:** rewrite `ClaimAdjacentUnclaimedRegions` so the seed set = owned
  regions whose claim is non-hostile. Vanilla makes any region gained without a
  pre-existing friendly claim hostile by default, so this covers all gains
  (conquest, unification, grants, breakaway release) uniformly. Hostile-claimed
  owned regions do NOT seed further claims. Matches the canonical creep example (14:05).
- **Disabled:** legacy behaviour — claims seed from any owned region regardless
  of claim hostility.

Owner ruling (14:18): vanilla behaviour is that ANY region gained without a
pre-existing friendly claim is hostile by default. Therefore there is no
"never-hostile unclaimed" case — unification, grant, and breakaway-release gains
are all hostile initially and do NOT seed creep until legitimised, same as any
other hostile claim. Sub-question closed; the enabled-option rule is simply:
seed only from regions whose claim is in `nonHostileClaims`.

### Scope
The contiguity pipeline has exactly ONE consumer: the cohesion malus
(`Patch_CohesionRestState_BaseValue` → `GetDiscontiguityImpactOnCohesion`).
Vanilla is never touched: `IsAdjacentToNation`, `TerrestrialAdjacencyType`, and
the `adjacentNations` dictionary are NOT patched. The "declarative national
states replacing vanilla adjacency" idea is CANCELLED — C4 does not rewire
vanilla adjacency.

### Session-4 commits (owner machine)
6ff403f thresholds per spec · 9e65b22 spec corrections (no island-bridge,
Full-source distance passes) · 8ea0b23 island-gated distance pass ·
67f9e84 allied traversal with degradation · c522d5e degradation per allied
nation. The manager bundled in this package (`PolygonalRegionConnectivityManager.cs`)
is rewritten to the locked spec, including island-internal BFS seed propagation
and the continental FC-bridge within X from FC islands only. Re-verify against
the locked spec on the owner machine before shipping (VM work, not owner-machine
commits).

## Build (2 commands, from repo root)
```
export DOTNET_ROOT=$HOME/dotnet; export PATH=$HOME/dotnet:$PATH
export FrameworkPathOverride=$HOME/.nuget/packages/microsoft.netframework.referenceassemblies.net48/1.0.3/build/.NETFramework/v4.8/
dotnet build
```
`restore-build.sh` (repo root) does the same. Full details: `Docs/Build Setup.md`.

## Deployment
Debug_Toggle.bat / Deploy.bat work as before. Check `modinfo.json` version bump
before shipping.

## Open questions — RESOLVED this session (recorded for the next session)
1. Thresholds → RESOLVED by owner pseudocode + commit 3dec515 (X = ClaimIslandsDistanceKM). See locked spec above.
2. Island chain gating → RESOLVED by owner pseudocode + 8ea0b23 (distance pass is island-gated). See locked spec above.
3. C4 scope → RESOLVED: declarative national states do NOT replace vanilla adjacency; contiguity is mod-internal (cohesion malus only). See locked spec above.

## Open items still outstanding
1. **HostileClaimsBlockCreep sub-option** (D44) — implement the seed-gating
   rewrite of `ClaimAdjacentUnclaimedRegions`; default enabled. First code task
   of the next session.
2. **Verify island-internal BFS + FC-bridge code** in the bundled manager
   against the locked spec on the owner machine (package copy builds clean but
   owner-machine commits are the source of truth).
3. **C5 rising threat narrative** — not started.
4. **Cultural Inertia plan (rev 8)** — fully designed (see Cultural Inertia Plan.md),
   zero code written. Hooks identified: OnUnityPriorityComplete, AbsorbNation,
   DailySecessionCheck, SecessionChance.
5. **Less-invasive policy refactor** — proposal ready (Docs/Less Invasive Policy
   Options Refactor.md); apply to GitHub master after a fresh pull, never to the
   bundled pre-fix snapshot.
6. **Git push** — no PAT on this VM; pushes happen from the owner machine.
7. **Map-data flags** (for the map author, not code): does Norway's polygon intend
   to cover Svalbard? Franz Josef Land missing entirely; Arctic ocean-route
   interaction with the border-distance cache needs a look.
