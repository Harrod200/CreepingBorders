# Handover Notes v6 — Creeping Borders (session 2026-10-07 evening)

Continues Handover Notes v5. READ ORDER unchanged (see Docs/Efficiency Instructions for Future Instances.md). Everything below is committed to master; nothing lives only in this note.

## Committed this session (oldest to newest)

- a758a52 Incident 4: PolygonalRegionConnectivityManager wired into GetTrueContiguousRegionsWithExtended (was dead code)
- 006fc14 Incident 5: ShortestBorderDistance_km + PrecomputeAllPairs unified on GeographicPolygonMath; island NextHopDistance real
- 6a104da Docs/Contiguity Model - British Isles.md (desk-check)
- f7f6afe Incident 6: island next-hop ranks by distance-to-capital (kills Medan-Banda Aceh loops)
- 7193cec Incident 6b: BFS-contiguous regions never show island route (gated on !CanReachCapitalThroughAdjacencies)
- 2d1682b Incident 6c: adjacency BFS ownership filter - foreign land routes do not grant contiguity; Partial via distance bridging
- f0b6921 Incident 6d: physically-reachable-from-capital (ownership-agnostic) regions capped at Partial - broken-but-physical BFS routes max out at Partial
- 90b0097 Incident 7: claim propagation limited to Full-contiguous regions only
- a8a7afc Docs/Contiguity Model - Australia.md (desk-check: Jakarta-Moresby-Brisbane chain)
- 841a5f8 Incident 8: next-hop picker requires reachable candidate (<=X) before homeward ranking (Biak shows Ambon, not Jakarta)
- a258a1e X user-adjustable: UMM slider ClaimDistanceKm 0-2000 km, 50 km steps; X_km property + Invalidate() on change
- 885aab9 Incident 9: IslandRangeKm unified into ClaimDistanceKm (removed)

## Semantic rules now in force (normative)

1. Contiguity levels come from PolygonalRegionConnectivityManager: Full <= X km to capital (or BFS), Partial <= 3X.
2. Adjacency BFS never crosses foreign territory (6c). Regions physically reachable but politically severed cap at Partial (6d) - they may NOT get Full via distance bridging.
3. Claim propagation requires Full. Partials are visible/encircled but not annexable.
4. Island next-hop: only candidates <= X km from the region, ranked by distance-to-capital (toward home), never for regions with a domestic adjacency path.
5. X drives everything (contiguity gates, hop reachability, C13 island budgets). Defaults 300 km; X=0 disables distance bridging.

## Verified by desk-check, NOT yet in-game

Incidents 6/6b/6c/6d, 7, 8, the X slider, and the X unification all compile green; no in-game load test has been run this session.

## Known open items

- NoPopulationMalus option: traced this session, NOT the culture mechanics (culture postfix only subtracts). Vanilla rest-state getter is patched; if it still misbehaves in-game, suspect the save-load path or a third consumer. Unresolved - pick up here.
- RegionController.polyLatLons live geometry path is used for cache misses; untested in-game (Ambon/Biak worked from disk cache).
- Pattern: Incidents 6-9 all stem from stale or symmetric assumptions in the next-hop/contiguity surface - when changing one, re-read GetTrueContiguousRegionsWithExtended, FindClosestContiguousRegion, CanReachCapitalThroughAdjacencies and the tooltip branch together.

## Reference

- Docs/Contiguity Model - British Isles.md and Docs/Contiguity Model - Australia.md hold worked examples (distance matrices, pass traces) - use them as regression checks after any change to X semantics.
- Region display-name to ID rule (column C of PolygonCache REGION rows) is normative; see Incident 4 entry in the Troubleshooting Log.
