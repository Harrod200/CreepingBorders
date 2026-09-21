# Vanilla API Cheat Sheet (Creeping Borders)

Grow this file. Every fact here was verified against decompiled source or
saved a session real time. If you had to derive something new, add it here
the same session.

## Regions & adjacency (verified 2026-09-21)

- `TIRegionState.AdjacentRegions(bool includeWater)` - fixpoint-friendly
  neighbour list. `false` = land-only adjacency (what contiguity logic wants).
- `TIRegionState.ThisAndAdjacentRegions` - includes the region itself.
- `TIRegionState.neighbors` - neighbour list keyed by adjacency type; prefer
  `AdjacentRegions` for region-graph walks.
- Adjacency is stored in a private `adjacencies` dict on `TIRegionState`;
  distance info is in a `_distanceToRegion` cache.

## Distance (verified 2026-09-21)

- `GeographicPolygonMath.GetRegionPairDistance(TIRegionState a,
  TIRegionState b, double claimDistanceX, double partialDistanceX)`
  (project class, ours) - returns distance in units of X multiples, using
  the baked `Cached Data/BorderDistanceCache.csv` via
  `GeographicPolygonMath.EnsureTableLoaded`.
- The on-disk cache must be exactly 3 columns: `A,B,distance`. The parser
  rejects any row whose `parts.Length != 3`.
- X is the mod's option "claim distance" - read it from mod settings at
  runtime, do not hard-code.

## Game state / lifecycle

- `TIGameState` is the abstract base for all persistent state objects
  (nations, regions, factions). It does NOT have Pre/PostTurnUpdate hooks -
  anything claiming so is a hallucinated summary. Update loops live in
  managers, not state classes.
- `TIGameState` instances are referenced by id; `GameStateID` is the type.

## Build (quick version)

```bash
bash PREFLIGHT.sh
```
Details in Build Setup.md. Old-style net48 csproj + modern SDK +
FrameworkPathOverride. HintPaths must point at ref-dlls/, not Steam.

## Session 5 additions (2026-09-21 PM) — contiguity locking + infra

- `TINationState.claims` / `hostileClaims` / `nonHostileClaims` are
  `List<TIRegionState>` on the nation. Any region gained without a
  pre-existing friendly claim is hostile by default in vanilla (conquest,
  unification, grants, breakaways all covered by one `nonHostileClaims`
  membership check).
- `PeacefulBreakupOption.OnPassage` splits into `ReleaseBreakaway(amicable:true)`
  (clears `breakawayParent`) and `ReleaseNation` (never sets it); `breakaway`
  is derived (`breakawayParent != null`), so any relief must be a timestamp
  (`culturalReliefUntil`) stamped at both paths, not a flag.
- Distance-layer cache stays a pure geometric table (`A,B,distance`, 3 cols,
  parser rejects extra). Island/continental gating belongs in the manager,
  never in the cache.
- `IsSameLandmass` was removed from the manager after the
  "distance is never continental-to-continental" ruling — don't reintroduce it.
- Ally traversal degradation is per **distinct allied nation crossed**
  (path-state `AlliedNationsCrossed` in the BFS frontier), not per region.

## Session 6 additions (2026-09-21 evening) — Unity, claims, secession patches

- Unity completion hook (C2): pay assimilation per **completion**, verified
  via decompile — hook the completion event path, not per-turn. Flat 0.5%/completion
  (setting slider, renamed from absorption wording).
- Absorption mechanic removal (C3-culture): vanilla has **no direct
  culture-blending on absorption**; the `AbsorptionRecognitionRate` setting and
  its culture effect were removed entirely (commit f3dff60). Only stale remnant
  was a UI label string — fixed in 83213a0. Don't re-derive this; it is settled.
- Duplicate patch-class hazard: a misplaced append can put patch classes after
  the namespace/class closing braces and even duplicate them (both happened in
  f3dff60; fixed in 1aa7e1e). After any append to a large file, run
  `grep -c "class Patch_"` and verify brace balance before building.
- Culture-weighted secession (C7): patch point is `DailySecessionCheck`
  (replacement, not prefix/postfix), verified against decompile; weight chance
  by foreign culture share.
- Breakaway 50/50 (C8): rewrite spawn composition at formation event; C9
  secession frequency is a postfix multiplier on the secession chance
  (`SecessionChance`, default 3x, slider).
- Friendly-claim threshold (C10): claims by nations with >=30% shared culture
  are non-hostile — prefix on `ClaimWillBeHostile` + postfix on
  `WillBeHostileExplanation` (tooltip text).
- Breakaway malus relief (C6/D47): halve cultural mismatch malus while
  `nation.breakaway` is set.
- Outreach (C11) research so far (incomplete, session ended before writing code):
  policy registration mirrors existing options in `CreepingBordersCls.cs`;
  Loc keys are `CreepingBorders.<ClassName>.*`;
  `TIPolicyOptionWithConfirm` is the **AI-approval** confirm, not player-target
  confirm — for C11's "confirm payment" prompt check vanilla
  `RequiresTargetConfirm` handling instead. Influence payment mirrors existing
  targeted policies; per-completion pay on the C2 hook. Claimability/targeting
  predicate: reuse the mod's contiguity/adjacency helpers
  (`TIRegionState.AdjacentRegions`, connectivity manager levels, not island-bridge
  FC). No C11 code was written yet.
