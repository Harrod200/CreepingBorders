# SpaceObjectRendering

*Decompiled from `PavonisInteractive/TerraInvicta/Systems/Camera/SpaceObjectRendering.cs`.*


## Class `SpaceObjectRendering`

```csharp
public class SpaceObjectRendering : StrategyLayerComponentSystem
```

### Fields

| Name | Type |
|---|---|
| `spaceObjects` | private SpaceObjectRendering.SpaceObjectGroup |
| `cameraManager` | private CameraManager |
| `wasTimeFlowingLastFrame` | private bool |
| `SpaceObjectGroup` | private struct |
| `Length` | public readonly int |
| `SpaceObject` | public ComponentArray<SpaceObjectComponent> |
| `LOD` | public ComponentArray<SpaceObjectLODComponent> |
| `Transform` | public ComponentArray<Transform> |

### Methods

```csharp
protected override void OnUpdate()
```
