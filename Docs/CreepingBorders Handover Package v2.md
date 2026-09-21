# CreepingBorders Mod — Handover Notes v2 (supersedes v1)

For the next dev picking this up. This package is fully up to date with GitHub master. Read this **before** the v1 notes in the old zip — the v1 caveats are resolved (see below).

## What changed since v1

1. **The stale-snapshot problem is gone.** The working copy is now a real git clone of `Harrod200/CreepingBorders`, branch `master`, at commit `b21f1d0`. A fresh PAT worked; all of v1's caveat commits (a92417b, e997aa0, 66e2302, 3dec515, 3599634) are present, plus two new ones:
   - `858408e` — **Invasive UI patch replaced.** The old reflection-heavy `NotificationScreenController.PopulatePolicyOptions` postfix is gone. Options are now registered the same way vanilla does it: patched `PolicyManager.Initialize` and `PolicyManager.policies.Add(...)` for both custom types. This kills the every-other-popup alternation bug at the root — no manual child-trimming, no `SetListSize` reflection (`TrimListChildrenToSize` is no longer in the source; it's unnecessary).
   - `b21f1d0` — same refactor completed for `LegitimiseClaim`, plus the shared influence gate/constant now used by both options.
2. **E2E verification is done.** `Docs/Creeping Borders E2E Verification.md` covers all 17 patch targets + every method, checked against real decompiled vanilla bodies (reference corpus in `TI Decompiled/`). Verdict: PASS. Two design-intent notes in §6 (cohesion clamp saturation at high base values; double-transfer guard on occupation+policy both being active) — neither is a bug.
3. **The mod now compiles in this VM.** Build setup, stub projects and output are documented in `Docs/Build Environment.md` — see below.

## Build environment (reproducible)

- .NET SDK: `$HOME/dotnet` — install with: `curl -sSL https://dot.net/v1/dotnet-install.sh | bash -s -- --channel 8.0 --install-dir $HOME/dotnet`
- Project: `/scratch/u10000/cbbuild` — `build.csproj` (net48, references `Assembly-CSharp.dll` from the repo) + `stubs/` for UnityEngine.CoreModule and UnityModManager (compile-time only) + `AssemblyInfo.cs`, `Strings.en`.
- Build: `$HOME/dotnet/dotnet build -c Release` → output `out/build.dll`. Confirmed green at `b21f1d0`.
- Stubs are compile-time only — the real game and UMM assemblies are used at runtime.

## Repo layout
- `CreepingBordersCls.cs` — single-file mod (~2,820 lines): lifecycle, settings UI, Harmony patches, policy options, contiguity/landmass BFS, border-distance math.
- `Strings.en`, `modinfo.json`, `Deploy.bat` (paths still hardcode the original author's machine — reconfigure before using).
- `TI Decompiled/` — decompiled vanilla reference corpus used for E2E verification.
- `Cached Data/` — **see v1 caveat #2, still open:** `BorderDistanceCache.csv` is in a 6-column format the parser doesn't read (it expects 3 columns), so it loads zero entries. Decide: fix the parser or regenerate the cache; also confirm `PrecomputeAllPairs()` doesn't auto-run on load (it's an O(N²) dev tool).

## Known-open items for the next dev
1. Cache CSV format mismatch (v1 finding #2 — still present at `b21f1d0`).
2. `Deploy.bat` / `Debug_Toggle.bat` paths and the "What's Yours Is Mine" folder name look stale — do not run without checking targets (v1 finding #5).
3. Verbose debug logging in `LegitimiseClaim`/`RegionSelector` should be `#if DEBUG`-gated for release builds (v1 finding #4).
4. Consider regenerating the border-distance cache with the full map loaded so all pairs have real polygon distances instead of centroid fallbacks.

## Docs in this package
- `Docs/Creeping Borders E2E Verification.md` — the full method-by-method proof.
- `Docs/Less Invasive Policy Options Refactor.md` — the review that motivated 858408e/b21f1d0.
- `Docs/Handover Notes v2.md` — this file.
