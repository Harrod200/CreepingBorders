# SelectorScaling

*Decompiled from `PavonisInteractive/TerraInvicta/Systems/SolarSystem/SelectorScaling.cs`.*


## Class `SelectorScaling`

```csharp
public class SelectorScaling : StrategyLayerComponentSystem
```

### Fields

| Name | Type |
|---|---|
| `spaceObjects` | private SelectorScaling.SpaceObjectGroup |
| `camera` | private CameraManager |
| `gameTime` | private GameTimeManager |
| `SpaceObjectGroup` | private struct |
| `Length` | public readonly int |
| `GameObject` | public GameObjectArray |
| `SpaceObject` | public ComponentArray<SpaceObjectComponent> |
| `LOD` | public ComponentArray<SpaceObjectLODComponent> |
| `Controller` | public ComponentArray<SpaceObjectController> |

### Methods

```csharp
protected override void OnUpdate()
```
