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
