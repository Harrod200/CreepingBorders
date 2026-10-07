# Troubleshooting Log — Creeping Borders

Append-only. Newest at bottom. One entry per incident: date, symptom, root cause, fix, status.
Update `/space/creepingborders/project-state.json` pickup line when a session's work lands.

---

## 2026-10-07 — session obu8ve (pickup zip `CreepingBorders Pickup 2026-10-07`)

### Incident 1 — InvalidProgramException at patch time
- **Symptom:** `[CreepingBorders] [Error] Failed to apply patches: HarmonyLib.HarmonyException: Patching exception in method null ---> System.InvalidProgramException: Invalid IL in method ... IL_0010: call 0x00000001`. Mod loads but `PatchAll` aborts → zero patches applied.
- **Root cause:** C13 prefix in `CulturalInertia.cs` (`OnUnityPriorityComplete`) used `ref bool __runOriginal` as an injectable prefix parameter. That is a **HarmonyX** feature. This project uses **Lib.Harmony 2.3.6 (pardeike)**, whose argument injector emits broken IL for that parameter → invalid dynamic wrapper.
- **Fix:** Replaced prefix with a plain replacing prefix: `if (!enabled) return true; RunCompletion(__instance); return false;` Semantics unchanged.
- **Status:** Fixed, confirmed by next load reaching Incident 2.

### Incident 2 — "Undefined target method" for Patch_PeriodicNationUpdateTask
- **Symptom:** `HarmonyException: Patching exception in method null ---> ArgumentException: Undefined target method for patch method static System.Void CreepingBorders.Patch_PeriodicNationUpdateTask::Postfix(TINationState __instance)`.
- **Root cause:** Patch attribute targeted `typeof(TINationState)` with method name `"PeriodicNationUpdateTask"`. That method is actually private on `PavonisInteractive.TerraInvicta.Systems.PeriodicUpdates.NationPeriodicUpdate` (namespace confirmed from Assembly-CSharp.dll strings; class/method documented in `Terra Invicta Class & Method Reference.md` §NationPeriodicUpdate). Name lookup on the wrong type → null → exception aborts all of `PatchAll`.
- **Fix:** `CulturalInertiaAI.cs`: added `using ...Systems.PeriodicUpdates;`, retargeted `[HarmonyPatch(typeof(NationPeriodicUpdate), "PeriodicNationUpdateTask")]`, postfix binds the instance's `TINationState nation` parameter by name and aliases it to `__instance`.
- **Status:** Fixed. Full patch-target audit done against the verified reference — all other targets exist (TINationState getters/properties, GameControl, GameStateManager, PolicyManager, UI controllers, AIDailyFactionPlanner). Build green: 0 errors, 1 pre-existing warning.

## Environment notes (VM, not incidents)
- No .NET SDK preinstalled. Installed SDK 8.0 to `$HOME/dotnet` via dotnet-install.sh. Build command:
  `PATH=$HOME/dotnet:$PATH DOTNET_CLI_TELEMETRY_OPTOUT=1 FrameworkPathOverride=$HOME/.nuget/packages/microsoft.netframework.referenceassemblies.net48/1.0.3/build/.NETFramework/v4.8/ dotnet build -c Release -v q`
- Zip did not include `nuget-packages-local/`; the csproj's net48 reference-assemblies path only materialises after `dotnet restore`. If a fresh checkout fails with `CS0006: Metadata file '/mscorlib.dll' could not be found`, run `dotnet restore` first.
- pythonnet can't load Assembly-CSharp (no mono runtime on VM); use `strings` on the ref-dlls or the verified docs instead. `dnfile` OOMs on this dll (~490 MB RAM limit) — don't retry.

### Doc consolidation (2026-10-07, session obu8ve)
- RESUME.sh created then removed on owner instruction; pickup orientation is via Docs read-order + this log instead.
- Canonical Docs/ folder only. Deleted as stale/superseded: Docs/BUILD NOTES.md (older copy; stale paths), Docs/Handover Notes v2.md, Docs/Handover Notes v3.md (superseded by v5), Docs/Cultural Inertia Implementation Plan.md (pseudocode plan; C13 implemented, normative docs are CI Handover v1 + Plan rev 9), Docs/CreepingBorders Handover Package v2.md (actually old Handover Notes v2 under a wrong name).
- Root duplicates removed; root-only docs moved into Docs/ (Build Setup.md, Cultural Inertia Plan.md). Docs copies of E2E Verification and Less Invasive refactor were identical to root.
- Handover Notes v5 task entry updated: Cultural Inertia rev 8 designed -> rev 9 implemented (see CI Handover Package v2).
- Efficiency Instructions amended: pickup-path variant documented; Troubleshooting Log referenced in golden rules; /rool-drive/CB path rule generalized.
- Pushed to GitHub master @ 13d3640 (from be0a902): patch fixes + doc consolidation. Note: GitHub PAT was shared in chat; owner should revoke and rotate it. Push used a transient /tmp clone (deleted after push) — no state parked there.

## 2026-10-07 — Incident 3: Undefined target method — AIDailyFactionPlanner.Update
- Symptom: `Patch_AIDailyFactionPlanner::Postfix` → "Undefined target method"; PatchAll aborts, mod not loaded.
- Root cause: AIDailyFactionPlanner is a MonoBehaviour that never declares Update() — Unity magic methods aren't real methods on the type. Also would have fired at frame-rate, not daily.
- Fix: retarget to `AIDailyFactionPlanner.FactionOperations0000` — the once-per-day planning pass, invoked by FactionPeriodicUpdate.OnDaily0000Update (Systems.PeriodicUpdates). FactionOperations(bool) runs 7x/day, so it is NOT a daily hook.
- Status: FIXED, build green. Full patch-target audit against decomp passed (all remaining targets exist). Awaiting in-game load test.

## Incident 4 — 2026-10-07: Loc audit false positives (vanilla-supplied keys)
- Symptom: diffing mod `Loc.T` keys against mod Strings.en flagged 14 cohesion-reststate keys as missing.
- Root cause: those keys are vanilla strings (TI Decompiled/Strings/en/UINation.en); the C13 `CohesionRestStateDetail` replication patch intentionally reuses vanilla keys per Docs/Creeping Borders E2E Verification.md.
- Resolution: keys removed from mod Strings.en. AUDIT RULE: any key present under `TI Decompiled/Strings/en/*.en` is vanilla-supplied — do not add it to the mod's Strings.en. Only mod-original keys (UI.Region.Tooltip.*, CreepingBorders.*, UI.Notifications.CreepingBorders.*) belong there.

## 2026-10-07 — Incident 4: Distance bridging never ran (dead-code manager)
- Symptom: Indonesia (all-island regions) gained no contiguity from distance bridging; log showed only island-bridge BFS, 5 discontiguous regions.
- Root cause: `PolygonalRegionConnectivityManager` (Pass A/B/C fixpoint) had ZERO callers — `GetTrueContiguousRegionsWithExtended` ran its own adjacency-only BFS + legacy island pass. The manager was dead code.
- Also corrected: name→ID mapping. Ambon=2003_MoluccasandSulawesi, Biak=2003_NewGuinea. Both ARE in PolygonCache/BorderDistanceCache. Rule: resolve display names via REGION row column C ("in the X region"), never guess from ID substrings.
- Verified numbers (cache, X=300/3X=900): Ambon↔Makassar 5.8 km (FULL), Biak↔Ambon 33.6 km (FULL), Samarinda↔Medan 209 km (FULL), Denpasar↔Jakarta 3 km (FULL). Replication of GeographicPolygonMath matches BorderDistanceCache to 2dp.
- Gotcha: PolygonCache.csv lon/lat are RADIANS — do not double-convert.
- Fix: `GetTrueContiguousRegionsWithExtended` now sources levels from `PolygonalRegionConnectivityManager.Get(nation)` (Full→FullyContiguous, Partial→ExtendedDistance/AllContiguous), legacy island pass retained as additive-only fallback. Expected Indonesia result: all owned regions Full, penalty → 0.
- Status: build green; awaiting in-game load test.

## Incident 5 — Divergent distance paths / missing island hop distance (2026-10-07)
- Tooltip verification found the FullyContiguousIsland branch set NextHopRegion but never NextHopDistance (rendered "0 km").
- ShortestBorderDistance_km had its own vertex-to-vertex computation + centroid fallback, diverging from GeographicPolygonMath's edge-to-arc algorithm used by the manager. Per owner ruling: no centroid fallback.
- Fix: ShortestBorderDistance_km now delegates to GeographicPolygonMath.GetRegionPairDistance (Unknown/Beyond3X → float.MaxValue); PrecomputeAllPairs delegates likewise (appends misses to the shared CSV); removed dead PrecomputedTable/EnsureTableLoaded/PairKey from Cls; InvalidateCache now calls GeographicPolygonMath.ReloadTable.
- Rule: one algorithm, one cache (GeographicPolygonMath/BorderDistanceCache.csv) — never fork distance logic.

## Incident 6 (2026-10-07) — Island next-hop picked symmetric nearest neighbour, not route to capital
**Symptom:** Medan showed "Island route via Banda Aceh (0 km)" while Banda Aceh showed
"Island route via Medan (0 km)"; Makassar<->Ambon showed the mutual 6 km pair. Each
region pointed at the other instead of along the path to Jakarta.
**Cause:** FindClosestContiguousRegion ranked candidates by distance to SELF. The
geometrically nearest full region is a symmetric neighbour (Banda Aceh for Medan,
Ambon for Makassar), producing two-way loops.
**Fix:** Rank candidates by polygon distance TO THE CAPITAL (ascending), tie-break by
distance to self. Next hop now always points homeward: Medan->Jakarta,
Banda Aceh->Medan, Ambon->Makassar, Makassar->Jakarta.

## Incident 6b (2026-10-07) — BFS-contiguous regions wrongly given island next-hop
**Symptom:** Glasgow (Full via BFS adjacency chain through Birmingham) showed
"Island route via Birmingham". Belfast correctly showed "Island route via Glasgow
(22 km)". Any region in trueContiguousRegions flagged LandmassType.Island got a
next-hop, even when it had a direct adjacency path to the capital.
**Cause:** the FullyContiguous branch only tested GetLandmassType()==Island, which
is true for any region without naval adjacency — including land-connected Britain.
**Fix:** gate the island next-hop on !CanReachCapitalThroughAdjacencies(region,
nation). Adjacency-reachable regions keep PathType DirectBFS with no hop; only
distance-bridged islands (Belfast, Ambon, Banda Aceh) show a route.

## Incident 6c (2026-10-07) — CanReachCapitalThroughAdjacencies crossed foreign territory
**Scenario:** if the Midlands (Birmingham) ceased to be UK, Glasgow's only land path
to London ran through foreign territory, but the BFS had no ownership test and
upgraded Glasgow to DirectBFS / fully contiguous.
**Fix:** ownership filter (neighbor.nation != nation -> skip) in the BFS. Consequence:
Glasgow falls through to Pass B distance bridging (London 318.3 km -> Partial),
matching the design intent of partial naval route contiguity for interrupted BFS
routes. Belfast's bridge recomputes to nearest-to-capital Full region (Wales,
116.27 km) instead of Glasgow (22 km, now non-Full).
**Note:** distance bridging is deliberately ownership-blind (naval semantics); the
filter guards BFS routes only.

## Incident 6d (2026-10-07) — Full cap for physically reachable but politically severed regions
**Scenario:** with the Midlands foreign, Glasgow (318 km to London) would sit just
over the 300 km Full gate; had it been under it, it would regain FULL contiguity
purely from geometry despite a politically broken land route.
**Rule (owner):** if a physical BFS route to the capital exists (ownership-agnostic),
distance-based contiguity for that region is capped at Partial. Geography permits
connection; politics breaks it; Partial is the ceiling.
**Fix:** ownership-agnostic BFS from capital over AdjacentRegions(false) precomputed
as physicallyReachable; Pass B caps Full->Partial for such regions.
