# CreepingBorders Mod — Handover Notes v3 (supersedes v2)

For the next dev picking this up. Read this **before** the v2 notes.

## Session summary (2026-09-21)

1. **Vanilla code removed from the repo.** `TI Decompiled/`, `Cached Data` game
   assets and `Assembly-CSharp.dll` are local-only now (in this handover folder,
   not on GitHub). `.gitignore` updated.
2. **`Cached Data/` reintroduced** (commit `153eee3`) — these are the mod's own
   outputs, not vanilla assets:
   - `BorderDistanceCache.csv` — region-pair border distances (3-column `A,B,distance`, parser-compatible)
   - `PolygonCache.csv` — pre-computed region polygon vertex data (~90k lines)
3. **Border distance cache regenerated** (commit `99ccdaf`) with the edge-to-edge
   methodology (`PolygonProximity.FindClosestGeoPoints`: closest-point-on-segment
   between polygon edges, then haversine). 65,703 unique pairs across 363 regions
   (= C(363,2), no duplicates, no missing pairs). 3-column parser-compatible format.
   Bake took ~17 min on the VM; zero runtime OOM after NumPy einsum fix.
4. **Verification against real-world data (updated 2026-09-21):** Java–Sumatra =
   24.89 km in the cache vs addendum-confirmed 24.86 km (0.1% match; real-world
   Sunda Strait ~24 km — the low-poly polygons get it right, the old 7.68 km cache
   was the parse bug). Alaska–Kamchatka = 83.85 km vs real Bering Strait ~82 km.
   Ahvaz–Isfahan = 0.0 km. Conclusion: game geometry is trustworthy post-fix; any
   threshold tuning should use game numbers.
5. **AdjacentRegions vs Neighbors resolved.** From the decompiled source
   (`TIRegionState.cs`):
   - `AdjacentRegions(bool invading)` — geometry-based, from `adjacencies` dict.
     Pass `false` to include `FriendlyCrossingOnly` edges.
   - `Neighbors` — template-based physical adjacency (`BilateralRelationType.PhysicalAdjacency`),
     lazily cached; what armies use.
   - `ConnectedRegions` — `Neighbors` plus, for `onTheWater` regions, *all*
     `CoastalRegions`. Vanilla's own permissive island rule.
   - Decision: connectivity manager uses `AdjacentRegions(false)`; claims/expansion
     keep `Neighbors` to match vanilla army movement.

## Implementation plan (approved 2026-09-21): Polygonal Region Connectivity Manager v2

Implement the attached design (vertex-to-edge pair distance, connectivity levels
Capital > FC > PC > DC, fixpoint BFS, island↔continental inheritance) with these
modifications:

- Keep the repo's radians-based math (NOT raw degrees) and the game's
  `meanRadius_km` (NOT hardcoded 6371.0).
- Delete the single-point fallback — regions without geometry get
  `DistanceUnknown` → DC, never pseudo-connected.
- Disk cache: reuse `PrecomputedTable` / `BorderDistanceCache.csv`, 3-column
  format. Sentinels: `>=0` real km; `-1` = bbox-filtered out (>3X, not computed).
  Cache misses computed lazily at runtime and appended to the CSV.
- `PairKey` deduplication — one row per unordered pair.
- Bounding-box pre-filter: pad by `3 × X` degrees latitude; longitude pad divided
  by `max(cos(latA), cos(latB))` (conservative). Pairs failing the test never
  reach the O(n·m) sweep.
- Island detection via `region.template.isIsland`.
- Rival/at-war blocking in the BFS.
- Keep `BFSWithPathScoring` until its `regionsByCost` consumers are remapped to
  `UnANationsCrossed`, then remove.
- Islands grant continental regions contiguity (attachment behaviour) — this
  reverses the old "continental regions cannot inherit from islands" rule.
  Flagged as a gameplay change.
- **Amendment (2026-09-21):** continental-to-continental contiguity may only be
  *inherited* via an island — two continental regions that are neither adjacent
  nor island-bridged must never become contiguous through distance-based levels
  (e.g. Alaska–Kamchatka at 84 km, or Spain–Rabat at 0 km via the polygon
  overlap, must not auto-connect). Distance-based contiguity applies within a
  continent only; cross-continental links require either geometric adjacency or
  an island chain in between. Implement in the connectivity manager as a gate on
  the inheritance rule, not by altering the distance layer.

### Checkpoints

| # | Deliverable | Verify | Est. credits | Status |
|---|---|---|---|---|
| C1 | Distance layer in radians + PairKey dedup + bbox filter + cache read/append (-1 sentinel) + result enum (`Known(km)` / `Beyond3X` / `Unknown`) | Builds; Java–Sumatra ≈24.86 km; dedup rows; cache round-trip | ~120 | **done** (`7a78218`) |
| C2 | Bake script: full 65,703-pair bake incl. -1 bbox entries | Spot-check 3 pairs vs Python reference | ~60 | **done** (`99ccdaf`; bake tool at `Tools/BakeBorderDistanceCache.py`) |
| C3 | `PolygonalRegionConnectivityManager.cs`: fixpoint BFS on `AdjacentRegions(false)`, levels, rival blocking, two polygon passes gated by cache | Builds; level-distribution log dump | ~140 | pending |
| C4 | Integration: wire into hooks, remap `BFSWithPathScoring` consumers, claims keep `Neighbors` | Builds; debug-logging toggle works | ~100 | pending |
| C5 | Tests + docs updated, push to git | Green build; pushed | ~60 | pending |

Total ≈ 480 credits. Each checkpoint leaves the build green and the repo pushable.

### Runtime environment note

The VM pauses after ~75 tool steps per run; work resumes cleanly on "continue"
since all files live on `/rool-drive`. Checkpoints are sized to fit inside one run.

## Docs in this package
- `Docs/Handover Notes v3.md` — this file.

## Local-only vanilla files (excluded from git, present in this folder)

These exist here so a fresh machine can rebuild/verify without the game install.
They are deliberately NOT in the GitHub repo (vanilla game code must not be
redistributed) — `.gitignore` blocks them.

| Item | Size | Contents |
|---|---|---|
| `TI Decompiled/` | 38 MB | Decompiled vanilla reference corpus (`GameAnalysis/Assembly-CSharp/...` incl. `PavonisInteractive/TerraInvicta/` sources, `Poly2Tri`, `Vectrosity`, templates). Used for E2E verification and API lookups (e.g. the AdjacentRegions/Neighbors resolution). |
| `Assembly-CSharp.dll` | 6.8 MB | Vanilla game assembly — required reference for `dotnet build` (see csproj hint path). |
| `ref-dlls/` | 3.4 MB | Reference DLLs for Unity (facade + modules incl. `JSONSerializeModule` for `JsonUtility`), UMM, Harmony, etc. — persistent copies so VM recycles (/tmp) don't break builds. |
| `Claude/`, `CompiledMod/` | — | Build/deploy working dirs. |

If cloning the repo fresh elsewhere, copy these from this handover package (or the
game install) before building; the csproj expects `Assembly-CSharp.dll` nearby.
- `Docs/Handover Notes v2.md` — prior version (build env, E2E verification links).
- `Docs/Creeping Borders E2E Verification.md` — full method-by-method proof.
- `Docs/Less Invasive Policy Options Refactor.md` — UI refactor review.
- `ref-dlls/` — persistent reference DLLs (survives VM recycles; /tmp does not).
- `BUILD NOTES.md` — see v2 for build environment; status header updated per session.

## Addendum (2026-09-21): Cultural Inertia completion — checkpoints C6–C12

Gap analysis of `CulturalInertia.cs` vs plan rev 8 found only the first five of
~13 elements implemented (seed-on-capture 0%, cohesion malus, Unity
assimilation, absorption recognition, persistence). The following checkpoints
add the rest. Each leaves the build green and is pushable.

**Cross-cutting requirement (applies to C6 onward):** retune the cohesion malus
so it scales in proportion with vanilla's own population-size and distribution
maluses — the current flat `foreignShare × popWeight × max` ignores how vanilla
weights unrest penalties by region population share. Bring the mod's malus
magnitude into line with the vanilla unrest/instability penalties it sits
alongside (audit vanilla `cohesionRestState` and unrest modifiers first, then
recalibrate `CulturalMismatchMax` default and slider range accordingly).

| # | Deliverable | Verify | Est. credits |
|---|---|---|---|
| C6 | **Breakaway malus relief ×0.5** — regions whose seeded/owner culture matches state culture get the cohesion malus halved (breakaway-relief flag in `CohesionMalus`) | Unit-style in-game check; build green | ~60 |
| C7 | **Culture-weighted defection** — patch `DailySecessionCheck` so secession chance weights by foreign culture share; regions with majority state culture rarely defect | Log dump of weighted vs vanilla chances | ~100 |
| C8 | **Breakaway 50/50 spawn** — breakaway nations form with ~50/50 cultural composition between parent and local culture | Formation event check | ~80 |
| C9 | **Secession frequency ×3** — `SecessionChance` multiplier setting (default 3×, slider) | Config round-trip | ~40 |
| C10 | **Friendly-claim 30% threshold** — `ClaimWillBeHostile` / `WillBeHostileExplanation` patches; claims by nations with ≥30% shared culture are non-hostile | Claim tooltip check | ~90 |
| C11 | **Cultural Outreach policy** — `PolicyManager` hook, influence cost, targeted assimilation boost on the target region | Policy visible + effect on composition | ~120 |
| C12 | **UI + polish** — culture-breakdown region tooltip, "Assimilation: X%" line, claim recoloring, defunct-nation frozen display names, settings sliders for breakaway freq + friendly threshold; malus recalibration note above | In-game visual pass | ~130 |

Estimated remaining: **~620 credits** (plus C2/C3/C4/C5 from the distance plan,
~300, still pending). Note C6–C9 form one coherent breakaway cluster; C10–C11
depend on culture-share queries from C6; C12 last.

### Status note (updated 2026-09-21)
C1 **complete and pushed** (`7a78218`). C2 **complete and pushed** (`99ccdaf`,
script `Tools/BakeBorderDistanceCache.py`): full 65,703-pair bake, validated on
Java–Sumatra (24.89 km vs 24.86 km reference), Ahvaz–Isfahan (0.0), and
CanadaArctic–Norilsk (1,724 km, independently rechecked as real geometry).
**Next: C3/C4**, which are now unblocked. Two design amendments since the plan
was written: (1) cultural-malus relief applies to rebel breakaways permanently
(`breakawayParent != null`) and to peacefully released regions as a 2-year
timestamp grace period; (2) no continent-to-continent distance-based contiguity
— cross-continental inheritance requires an island bridge (see C6/C8 amendments
and the connectivity-plan bullet above). Map-data findings logged: England
polygon includes Gibraltar; England×Nantes overlap at Cotentin; Spain×Rabat
overlap near Melilla; Calais unowned. See `Handover Decision and Findings Log.md`
for the full session record (`7a78218`, `99ccdaf`, `ee8d730`, `aecf1c1`,
`01ef0f2`, `2848ff5`).
