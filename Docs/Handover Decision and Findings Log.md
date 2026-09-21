# Handover Decision and Findings Log (bake session, 2026-09-21)

Running log of decisions and findings made while building the offline polygon
distance bake. To be attached to the final handover.

## Findings

- F1. `BorderDistanceCache.csv` on disk is 6-column (per v2 caveat #2, still open).
  Runtime parser (`GeographicPolygonMath.EnsureTableLoaded`) requires exactly
  3 columns (`parts.Length != 3 → continue`), so the current file loads ZERO
  entries. The bake rewrites the file in 3-column `A,B,distance` format,
  resolving the mismatch. Decision needed post-bake: keep or remove the extra
  columns from any archived copy (they look like lat/lon/bbox metadata).
- F2. Verified geometry completeness: PolygonCache.csv declares 363 regions,
  89,679 vertices declared across REGION lines; 89,679 VERTEX lines present.
  363 regions → 65,703 unique unordered pairs (matches v3 notes).
- F3. Vertex convention confirmed: values are (lon, lat) in RADIANS
  (e.g. Afghanistan 1.2383 rad ≈ 70.9°E, 0.6711 rad ≈ 38.5°N), matching
  `GetBorderLonLat`. Multi-polygon regions are stored with (polyIdx, vertIdx);
  the C# concatenates all polygons into ONE list and closes the loop with
  `j+1 mod count` — including across polygon boundaries. The bake mirrors this
  exactly (no per-polygon closure), since that's what the runtime math sees.
- F4. Full bake supersedes the bbox sentinel: `BoundingBoxesCouldOverlap` pads
  by `3 × max(claimDistanceKm, 1)` km capped at `maxDistanceKm`, both runtime
  parameters the bake cannot know. Decision: compute TRUE edge-to-edge distance
  for ALL pairs in the bake. A real distance in the cache is equivalent-or-
  better than a `-1` sentinel: `Classify()` returns Known with the same value
  live computation would produce, and the O(n·m) sweep is skipped entirely.
  Sentinel `-1` rows will still be produced by runtime for cache misses that
  fail the bbox test, appended as usual.
- F5. Precision note: the bake runs float64; runtime live computation is
  float32 (Unity Vector3). Near-boundary pairs (distance within millimetres of
  a claim threshold) could classify differently than a live float32 recompute.
  Accepted risk; the cache value is treated as authoritative once loaded.
  Radius: bake uses hardcoded 6371.0 (runtime default when
  `regionA.spaceBody` is null); if any scene uses a non-Earth radius, those
  pairs recompute live and append — the bake row remains as an Earth-radius
  approximation. Flagged for the next dev if non-Earth bodies matter.
- F6. Mirror checklist for the bake (from `GeographicPolygonMath.cs`):
  unit vector = (cosLat·cosLon, cosLat·sinLon, sinLat); point-to-arc via
  cross(a0,a1) normal, projection onto plane, hemisphere check
  `Dot(p, closest) > 0`, `OnArc` orientation test, endpoint fallback for
  degenerate/far arcs; early exit when shortest <= 0.
- F7. Smoke test result: bake's Java–Sumatra = 24.8867 km vs handover addendum's
  24.86 km (0.1% apart) and ~24 km real-world Sunda Strait. Confirms the v3
  addendum: the old 7.68 km cache value came from the column-parsing bug; the
  new vertex-to-edge math is the accurate one. Handover's C1 verify line
  ("Java–Sumatra ≈7.68 km") is superseded by the addendum status note.
- F8. Engineering constraints hit during C2 (explains the credit overrun vs
  the ~60 estimate): (a) the committed cache was built on a parsing bug, so C2
  required re-implementing the geometry from scratch, not just re-running it;
  (b) this VM's 512 MB RAM OOM-killed the naive vectorized sweep repeatedly —
  Canadian Arctic alone has 5,257 vertices — fixed via chunked sweeping
  (CHUNK=128), float32 vectors (matching Unity's runtime float32), and fixing
  a broadcasting bug where `closest @ E0.T` fanned out to (m,n,n) instead of
  (m,n) — that bug was itself the OOM source. The expensive part is done; the
  remaining 65,703-pair bake is mechanical compute.
- F9. Deviation from plan: C2's verify step ("spot-check 3 pairs vs Python
  reference") is tautological since the Python IS the bake. Substituted:
  spot-checks against the handover's own reference values and real-world
  geography (Java–Sumatra 24.8867 vs 24.86 recorded). Further spot-checks:
  Ahvaz–Isfahan must be 0.0 (touching); Alaska–Siberia should land near the
  recorded ~450 km.
- F10. Spot-check results: Ahvaz–Isfahan = 0.0000 km exactly (touching), pass.
  Alaska–"Siberia" = 3,231.5 km: F9's "~450 km" expectation was wrong (invented
  from Bering Strait intuition). EasternSiberia is the Irkutsk region polygon
  (95–122°E), which is genuinely ~3,200 km from Alaska. Cross-checked with an
  independent vertex-vertex nearest-point calc: 3,235.2 km vs edge-to-edge
  3,231.5 km — agreement within edge refinement, so the result is real
  geometry, not a math bug. The old 90-row island-only cache has no Alaska
  row, so there is no like-for-like reference for this pair. Consider adding
  a true Chukotka/Bering pair to the region set if a near-miss check matters.

## Git push complete (09:44)
- Repo re-initialised in the working copy (it had no `.git`), remote set to `Harrod200/CreepingBorders`, origin/master fetched.
- Staged only real work: new 3-col `BorderDistanceCache.csv`, `Tools/BakeBorderDistanceCache.py`, `Docs/Handover Decision and Findings Log.md`. Reverted incidental local edits to csproj (local ref paths), Cls.cs debug hook, GeoMath comment, and v2 notes before committing so upstream stays clean.
- Pushed commit `99ccdaf` to `origin/master` (96fd0d7..99ccdaf). Push verified.
- Note for next dev: csproj in this VM points references at local paths (/tmp/stubs, /rool-drive); do NOT commit that version upstream.
