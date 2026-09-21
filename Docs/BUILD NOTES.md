# Creeping Borders — Build Notes (this machine)

## Status
- Builds clean with `dotnet build` — zero errors, zero warnings.
- Output: `CreepingBorders.dll` (70,656 bytes) copied to project root.

## How to build here
```
export PATH=$HOME/dotnet:$PATH
cd "/rool-drive/CreepingBorders Handover v3"
dotnet build
```
Note: `$HOME/dotnet` (SDK 8.0.425) is wiped on VM recycle — reinstall SDK to that path if missing.

## References
- Assembly-CSharp.dll — real decompiled-game assembly, kept in project root (the original vanilla one; can also be copied from the game's Managed folder).
- ref-dlls/ (persistent, survives VM recycles):
  - UnityModManager.dll, 0Harmony.dll (NuGet: UnityModManager 0.32.3 / Lib.Harmony 2.x)
  - UnityEngine.CoreModule, IMGUIModule, InputLegacyModule, UI, JSONSerializeModule, UnityEngine.dll (facade) — from Unity 2020.3.49f1 reference packages
- HintPaths for the original Steam paths were restored (don't rewrite them; they're correct on the owner's machine).

## Latest change
- CulturalInertia.cs: LoadState now guarded by stateLoadedThisSession (prevents double-load within a session; reset via ResetInMemoryState on new game/load hook). ResetInMemoryState is already called from CreepingBordersCls.cs GameLoad postfix.
