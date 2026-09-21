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

## Git: reincluded working-state files (09:46)
- Reverted earlier too-aggressive cleanup; synced repo to the /rool-drive working state.
- Committed: local-build csproj (stubs + drive ref paths, net48 ref assemblies condition), C1 debug hook in Cls, GeoMath overlap-norm fix, TestDistanceLayer, plus BUILD NOTES / E2E Verification / plan & refactor docs.
- Deliberately NOT committed (binaries/created builds, not redistributable source): CompiledMod/, CreepingBorders-master-upstream/, CreepingBorders.dll, nuget-packages-local/.

## 2026-09-21 (cont.) — Transpolar route verification: Canada ↔ Russia

**Question:** what does the map look like for a transpolar crossing between Canada and Russia?

**Findings (all from BorderDistanceCache.csv + PolygonCache.csv, v2v recheck where noted):**

- **Dataset has no Svalbard/Jan Mayen; no Franz Josef Land.** Highest latitude of any region is Greenland 83.6°N. The high Arctic is empty above ~83°N — any "over the pole" route is pure ocean by definition of this map.
- **Genuinely transpolar pair: CanadianArctic ↔ Norilsk = 1,724 km.** Closest points: Canadian Arctic (83.19°N, 74.93°W — Ellesmere/Alert area) and Norilsk region (81.26°N, 95.63°E — Taymyr/Severnaya Zemlya area). Great-circle midpoint (88.8°N, 66.5°E) — this is a real over-the-north-pole route, ~500 km from the pole.
- **Closest Canada↔Russia gap overall = CanadianArctic ↔ Sakha at 2,166 km** (77.3°N −119.1°W ↔ 75.1°N 150.8°E, via 80.1°N −168.6°E — near Wrangel Island, not polar).
- **Alaska ↔ Russia (Kamchatka) = 83.85 km** at Bering Strait — this is the only narrow intercontinental gap on the whole map; everything Arctic is 1,700+ km of ocean.
- **Norway ↔ Norilsk = 1,148 km** (80.1°N 27.2°E ↔ 81.0°N 93.3°E) — the map's Norway polygon reaches Svalbard latitudes (80°N, 27°E) despite no Svalbard region existing; worth checking whether Norway's polygon is meant to include Svalbard (real-world Svalbard is 76–81°N, 10–35°E, so this fits) — flagged for the map author.
- Greenland–CanadianArctic 28.7 km and Greenland–Norway 443.9 km are consistent with real-world Nares Strait (~35 km) and Greenland–Svalbard (~400–450 km); Greenland's polygon also stops at 83.6°N like the real island.

**Gameplay implications:**
1. Canada↔Russia conventional invasion routes: either 2,100+ km of open Arctic (CanadianArctic↔Sakha) or the Bering Strait (Alaska↔Kamchatka, 84 km). The "creeping borders" mechanic over 1,724 km of Arctic ocean between CanadianArctic and Norilsk will behave like pure naval/ice movement, not border creep — recommend a dedicated look at how ocean distance interacts with the border-distance cache.
2. The CanadianArctic–Norilsk transpolar gap is the shortest Arctic Russia↔Canada link; any " Arctic route" gameplay will funnel through it.
3. No-polygon gaps: Svalbard (covered by Norway's polygon or missing entirely) and Franz Josef Land (missing) mean historical Arctic claims in those areas are unrepresentable; flag for map author.

**Status:** logged for later investigation. No cache changes made.

## 2026-09-21 (cont.) — Continental contiguity design decision

Owner decision: continental-to-continental regions should only inherit
contiguity **via an island**. There must be no continent-to-continent
distance-based contiguity anywhere in the connectivity manager.

Rationale (from today's verification work):
- Alaska–Kamchatka at 84 km and the Spain–Rabat / England–Nantes polygon
  overlaps (0 km) would otherwise make continents "connected" across water by
  raw distance alone.
- Cross-continental movement should require either true geometric adjacency or
  an island chain bridging the gap (e.g. Java→Sumatra, Bering Strait only if an
  island sits there — it does not in this dataset).

Implementation note: gate this in the manager's inheritance/BFS logic
(`isIsland` check), NOT by editing the distance layer or cache — the cache
remains a pure geometric distance table and stays reusable for other systems.
Added to Handover Notes v3 implementation plan as a bullet amendment.

## 2026-09-21 PM — Contiguity locked (no further code changes this session)

Decisions in order, each superseding the last on its point:
1. Continental regions do NOT inherit PC from islands. Islands inherit PC from
   a DC island or continental region within 2X. No region inherits PC from a PC
   region (distance passes project from Full sources only).
2. Refined: continental regions DO inherit FC from an FC island within X
   (FC only, never PC — cross-landmass). PC-to-PC passes only via vanilla
   land adjacency.
3. Distance logic is island-gated: if neither endpoint is an island, distance
   is never considered. Continental-to-continental linkage is Pass A adjacency
   only. `IsSameLandmass` and the landmassId map removed as dead code.
4. Allied BFS: allies are traversable but degrade the level once per distinct
   allied NATION crossed (Full→Partial→Disconnected), not per region. Foreign
   regions block; unowned do not block.
5. Island-internal propagation: on a multi-region island, the region closest
   to a Full source connects via distance logic; remaining island regions
   connect to it via normal BFS adjacency.
6. Clarification: a continental region with BFS-sourced PC can never upgrade
   to FC via an island bridge. Island-bridge FC applies only to regions that
   are otherwise disconnected (DC from Pass A).
7. Claim creep: only friendly claims propagate (seed from `nonHostileClaims`
   when the sub-option is enabled, default on; disabled = legacy seed from any
   owned region). Canonical example recorded in Handover Notes v5:
   A1→B3 hostile claim → legitimised → capture → creep B2 → capture → B2
   stays hostile in `hostileClaims` → creep to B1 blocked until legitimation.
8. Scenario ruling: two continental regions 500 km apart with an allied
   unaligned between them are Partial (one allied nation crossed), not Full —
   and under rule 3 the distance pass never applies anyway.

## Infra (session 5 close-out)
- Git history lost once to /scratch recycle; recovered by re-initing from the
  published v5 package and rebasing onto origin/master.
- Repo now lives at /rool-drive/CB/repo (durable), symlinked at ~/handover.
  Durable second copy: github.com/Harrod200/CreepingBorders, master.
  Rule 6 of the efficiency instructions mandates /rool-drive/CB for all work.
