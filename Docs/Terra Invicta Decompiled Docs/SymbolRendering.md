# SymbolRendering

*Decompiled from `PavonisInteractive/TerraInvicta/Systems/SolarSystem/SymbolRendering.cs`.*


## Class `SymbolRendering`

```csharp
public class SymbolRendering : StrategyLayerComponentSystem
```

### Fields

| Name | Type |
|---|---|
| `cameraMgr` | private CameraManager |
| `spaceObjects` | private SymbolRendering.SpaceObjectGroup |
| `updatedSymbols` | private List<SpaceObjectSymbolController> |
| `wasTimeFlowingLastFrame` | private bool |
| `SpaceObjectGroup` | private struct |
| `Length` | public readonly int |
| `SpaceObject` | public ComponentArray<SpaceObjectComponent> |
| `Orbit` | public ComponentArray<OrbitComponent> |
| `LOD` | public ComponentArray<SpaceObjectLODComponent> |
| `Controller` | public ComponentArray<SpaceObjectController> |

### Methods

```csharp
protected override void OnUpdate()
```
