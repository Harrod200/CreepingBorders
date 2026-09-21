# ModelRendering

*Decompiled from `PavonisInteractive/TerraInvicta/Systems/SolarSystem/ModelRendering.cs`.*


## Class `ModelRendering`

```csharp
public class ModelRendering : StrategyLayerComponentSystem
```

### Fields

| Name | Type |
|---|---|
| `camera` | private CameraManager |
| `spaceObjects` | private ModelRendering.SpaceObjectGroup |
| `gameTime` | private GameTimeManager |
| `selection` | private SpaceObjectSelection |
| `SpaceObjectGroup` | private struct |
| `Length` | public readonly int |
| `SpaceObject` | public ComponentArray<SpaceObjectComponent> |
| `LOD` | public ComponentArray<SpaceObjectLODComponent> |
| `Controller` | public ComponentArray<SpaceObjectController> |

### Methods

```csharp
protected override void OnUpdate()
```
