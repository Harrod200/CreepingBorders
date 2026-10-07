# Build Setup (Creeping Borders)

Reproducible in ~2 commands. Home is wiped on VM boot, so the SDK and NuGet
cache must be restored each session.

## 1. Restore the .NET SDK
```
wget -q https://dot.net/v1/dotnet-install.sh -O dotnet-install.sh
bash dotnet-install.sh --channel 8.0 --install-dir $HOME/dotnet
```
(Only needed once per session; $HOME/dotnet persists until the VM recycles.)

## 2. Restore reference assemblies + build
```
export PATH=$HOME/dotnet:$PATH
export FrameworkPathOverride=$HOME/.nuget/packages/microsoft.netframework.referenceassemblies.net48/1.0.3/build/.NETFramework/v4.8/
dotnet restore && dotnet build
```
If `dotnet restore` produces no assets file (offline NuGet), the
reference-assemblies package is already cached in this zip under
`ref-dlls/nuget-cache/` — copy it to `$HOME/.nuget/packages/` and build again.

## Common pitfalls
- **HintPath errors**: the csproj HintPaths point at the owner's Steam folder.
  If the build fails with "metadata ... could not be found", fix paths to
  `ref-dlls/` in this zip (already done for v4's csproj, but re-check after
  re-zipping).
- **Old-style net48 project**: this is an SDK-managed build using
  `FrameworkPathOverride`; do not try to convert to an SDK-style csproj unless
  the owner asks.
- **Missing `AllRegions`**: use `GameStateManager.AllRegions()`, not
  `TIRegionState.AllRegions()` (easy mistake, cost a build cycle in C3).

## Build outputs
`CreepingBorders.dll` lands in `bin/Debug/`. Deploy with `Deploy.bat`
(copy into the mod folder, bump `modinfo.json` version).
