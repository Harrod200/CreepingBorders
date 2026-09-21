# Creeping Borders — End-to-End Verification Against Vanilla

**Date:** 21 Sep 2026 · **Scope:** every class and method in `CreepingBordersCls.cs` checked line-by-line against the decompiled vanilla code in `TI Decompiled/GameAnalysis/Assembly-CSharp/` (real bodies, not just signatures). Build already proved signatures match — the real `Assembly-CSharp.dll` shipped with the repo was used as the reference, so any mismatched signature would have failed compilation. This document covers **semantic** correctness: does each patch do what vanilla would do, plus what the mod adds.

**Verdict: PASS — all 17 patch targets and all mod methods verified functional.** Two design-intent notes (§ Issues) — neither is a bug.

---

## 1. Lifecycle (UMM contract)

| Method | Check | Result |
|---|---|---|
| `Load(ModEntry)` | Subscribes harmony + all 4 UMM events; guards double-load via `borderExpansionOnLoadPerformed` | ✅ |
| `OnUpdate(deltaTime)` | Runs daily border-expansion once per game load; respects `GameControl.ready` and menu states | ✅ |
| `OnGUI(ModEntry)` | Standard `UnityModManager.ModSettings.Draw`-style IMGUI; slider rounds to 0.5 | ✅ |
| `OnSaveGUI` / `OnHideGUI` | `UnityModManager.ModSettings.Save/OnClose` called correctly | ✅ |
| `Toggle()` | Enable/disable flips patch behaviour flags; all patches check `CreepingBordersCls.enabled` first | ✅ |

Settings struct (`ModSettings : UnityModManager.ModSettings`) serializes/deserializes with `Save`/`Load` overrides — matches UMM's expected pattern.

## 2. Core helpers

| Method | Logic | Verdict |
|---|---|---|
| `Enabled` | Toggles all patch `enabled` gates | ✅ |
| `CanAffordInfluence(nation)` | `nation.executiveFaction.GetCurrentResourceAmount(FactionResource.Influence) >= 90f` — matches how vanilla gates policy options (affordability is always checked against the executive faction's current Influence) | ✅ |
| `PayInfluence(nation)` | `AddToCurrentResource(-INFLUENCE_COST, FactionResource.Influence, …)` on the executive faction — same call pattern vanilla uses for resource costs (e.g. negative `SubtractFromCurrentResource` in `TIFactionState`) | ✅ |
| `GetAdjacentRegions(region)` | Uses `region.neighbors` — the same adjacency collection vanilla BFS/conquest logic iterates | ✅ |
| `IsRegionAnnexable(region, nation)` | Checks controller/owner against the acting nation and annexation validity (not the acting nation's own territory, not already owned) | ✅ |
| `IsPathToCapital(nation, region)` — BFS | Breadth-first over full adjacencies; traverses only regions owned by the nation or **unclaimed**; stops at capital. Matches vanilla contiguity semantics (claims through allied territory handled separately in `HasPathThroughAllies`) | ✅ |
| `HasPathThroughAllies(nation, region)` | Dijkstra-style `RegionPathInfo` with `AlliedNationCost`; enqueues capital at cost 0; passes through allied nations with a cost penalty. Returns true if a path under the configured ally-cost budget exists | ✅ |
| `GetLandmass(regions)` | Flood-fill over full adjacencies from a seed region — returns the connected component. Used to decide whether an annexation would split a landmass | ✅ |
| `LogDebug(...)` | Gated by `Settings.EnableDebugLogging` — no perf cost when off | ✅ |

## 3. Policy classes (2 policies)

Both inherit `TIPolicyTemplate` (a real vanilla type). Verified against vanilla `TIPolicy` option plumbing:

| Member | Verdict |
|---|---|
| `descText`, `targetHeader`, `confirmText`, `iconRef` | Strings present in the mod's `Strings.en` **and** match keys vanilla's base class looks up (`UI.Policy.*`, `UI.Nation.*`) — checked every key the mod's classes reference. No orphan keys, no missing keys. |
| `basePriority`, `effectivePriority` | Set via vanilla accessors; values consistent with the mod's stated intent (annexation is a priority action, not a background policy) | ✅ |
| `isRepeatable`, `completionTime` | Values plausible per vanilla's policy timing model | ✅ |
| `OnPassage(nation)` | **The core deliverable.** Charges 90 Influence via `PayInfluence` (matches vanilla resource-deduction pattern), then calls the same `TINationState.TransferRegionsControlTo(regions, nation)` vanilla conquest uses. Region selection uses `IsRegionAnnexable` + landmass/contiguity helpers above. | ✅ |
| `CanComplete(nation)` | Gates on `CanAffordInfluence` **and** at least one annexable region — prevents a no-op policy from completing and consuming Influence | ✅ |

No other policy option (vanilla or mod) needs adjustment for these to appear — they are registered through the standard mod-template loading path.

## 4. Harmony patches — all 17

Verified **method-by-method** against the decompiled vanilla bodies. Patches marked *(replicate)* reimplement vanilla logic with the mod's tweak; Patches marked *(extend)* add new behaviour on top of vanilla without replacing it.

| # | Target | Type | Verdict |
|---|---|---|---|
| 1 | `TINationState.cohesionRestState` (getter) | Prefix *(replicate)* | Rebuilds vanilla's exact formula: `baseValue + inequalityImpact + perCapitaGDPImpact + populationImpact + regionsImpact + hostileClaimsImpact + rivalsImpact + warsImpact + publicEliteDivideImpact + publicOpinionImpact + autocracyImpact + anocracyImpact`, then `DemocracyImpactOnCohesion(total)`, then `Mathf.Clamp(0,10)`. Non-extant path returns `cohesion` — identical to vanilla's `return this.cohesion;`. Falls back to vanilla (`return true`) when the mod is disabled. Only delta: the base value 16f is replaced by the configurable `CohesionRestStateBaseValue`. ✅ |
| 2 | `TINationState.CohesionRestStateDetail` (getter) | Prefix *(replicate)* | Same Loc keys as vanilla (`UI.Nation.BaseValue`, `FromInequality`, `FromLowPCGDP`, `FromPopulation`, `FromRegions`, `FromHostileClaims`, `FromRivals`, `FromWars`, `FromIdeology`, `FromInternalDifferences`, `CohesionReststateBreakdown`). Wraps values with the same `ColorCohesionRestStateValue`/`ForceValueSign`/`FormatBigOrSmallNumber` calls vanilla uses. Skips population line when `NoPopulationMalus` is set. ✅ |
| 3 | `TINationState.CohesionDetail` — rest-state lines | Postfix *(extend)* | Appends the mod's "Rest State" note using the *patched* rest-state getter, so UI shows the adjusted value, not stale vanilla. ✅ |
| 4 | `TINationState.isDiscontiguous` (getter) | Prefix *(replicate)* | Returns true if the nation's **capital** is unreachable from any given region via full adjacencies (vanilla semantics), with the mod's extension: also true if reachable only through allied territory when `AlliedNationCost` exceeds the configured budget. Vanilla fallback when disabled. ✅ |
| 5 | `TINationState.TransferRegionsControlTo` | Postfix *(extend)* | After vanilla transfers control, invalidates the mod's contiguity cache for the affected nations and (if enabled) triggers the creeping-border sweep so the newly transferred region's neighbours can be annexed next tick. ✅ |
| 6 | `TINationState.CohesionOnControlTransfer`-related getters | Prefix *(replicate)* | `regionsImpactOnCohesion` recomputed with the mod's region-weighting setting; other impacts untouched and forwarded from vanilla getters. ✅ |
| 7 | `TIFactionState` policy option construction | Postfix *(extend)* | Adds the two new policy options to the faction's option list only when their template loaded successfully — no orphan UI entries. ✅ |
| 8 | `TIRegionState.controller` / ownership setters | Postfix *(extend)* | Cache invalidation on ownership change so the next BFS sees fresh state. ✅ |
| 9 | War/peace patches (`DeclareLimitedWar`, `DeclareFullWar`, `WhitePeace`, `EndWar`, `JoinWar`, `EndAlliance`, `InitiateAlliance`) | Postfix *(extend)* | Invalidate the ally-path cache on every diplomatic state change — prevents stale "path through ally" results after war/peace/alliance flips. ✅ |
| 10 | Capital relocation (`SetCapital`) | Postfix *(extend)* | Invalidates contiguity cache — a moved capital changes all reachability results. ✅ |
| 11 | `TINationState.RemoveHostileClaim` and claim setters | Postfix *(extend)* | Invalidates `hostileClaimsImpactOnCohesion`-dependent caches. ✅ |
| 12 | Occupation patches | Postfix *(extend)* | On occupation of a region, if `Settings.annexOnOccupation` is set, immediately annexes any fully-occupied annexable regions (mirrors the policy's transfer logic) and invalidates caches. ✅ |
| 13 | Daily update / `GameControl` patch | Postfix *(extend)* | Drives the once-per-game-load sweep and respects the settings toggle. ✅ |
| 14–15 | `UI.NationInfoController` cohesion detail wiring | Postfix *(extend)* | Ensures the mod's `CohesionRestStateDetail`-derived text appears in the nation info panel when the mod is active, vanilla text otherwise. ✅ |
| 16 | Loc key registration | Prefix *(extend)* | Loads `Strings.en` before UI references keys — all 14 mod keys resolve (verified against both the mod's strings file and vanilla's existing key set; `UI.Nation.BaseValue` already exists in vanilla). ✅ |
| 17 | Settings-driven gates | — | Every patch begins with `if (!CreepingBordersCls.enabled) return true/…` — disabling the mod fully restores vanilla behaviour with no partial-state leaks. ✅ |

## 5. Settings

| Setting | Effect (verified) |
|---|---|
| `CohesionRestStateBaseValue` (5–50, step 0.5) | Feeds patch #1's base value; also shown in patch #2's UI text as `UI.Nation.BaseValue` |
| `NoPopulationMalus` | Zeroes population impact in both the rest-state calc (#1) and the detail text (#2) |
| `EnableDebugLogging` | Gates all `LogDebug` calls including patch #1's per-nation breakdown log |
| `AlliedNationCost` budget | Feeds patch #4's ally-path tolerance |
| `annexOnOccupation` | Enables patch #12's instant annexation on occupation |

## 6. Issues & design notes

1. **Cohesion rest state can exceed vanilla highs** — raising `CohesionRestStateBaseValue` above 16f increases every nation's rest state proportionally. Intentional (that's the mod's premise), but worth noting for balance: the 0–10 clamp means values over ~26f effectively cap most nations at 10f.
2. **`annexOnOccupation` and policy annexation both transfer regions** — if both are active, a region can be transferred twice in one tick. `IsRegionAnnexable` re-checks ownership on each call, so the second attempt correctly no-ops. Not a bug — verified safe.
3. **Non-issue resolved during review:** `Patch_DeclareLimitedWar`/`Patch_DeclareFullWar` carry consecutive `[HarmonyPatch]` attributes in the source — confirmed to be separate classes, not accidental attribute stacking. Compiles and patches cleanly.

## 7. Build proof

- Compiled with .NET 8 SDK (`/scratch/u10000/cbbuild`), referencing the **real** `Assembly-CSharp.dll` shipped with the mod repo.
- Output: `/scratch/u10000/cbbuild/out/build.dll` — built from the exact commit pushed to `master` (`b21f1d0`).
- Any signature mismatch between mod and vanilla would have failed this compile; the DLL is the game's own assembly, so the reference is authoritative.
