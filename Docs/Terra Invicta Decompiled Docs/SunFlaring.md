# SunFlaring

*Decompiled from `PavonisInteractive/TerraInvicta/Systems/SolarSystem/SunFlaring.cs`.*


## Class `SunFlaring`

```csharp
public class SunFlaring : StrategyLayerComponentSystem
```

### Fields

| Name | Type |
|---|---|
| `FlareScale` | private const double |
| `FlareMinBrightness` | private const double |
| `FlareMaxBrightness` | private const double |
| `camera` | private CameraManager |
| `suns` | private SunFlaring.SunGroup |
| `flare` | private LensFlare |
| `sun` | private SpaceObject |
| `SunGroup` | private struct |
| `Length` | public readonly int |
| `Entity` | public GameObjectArray |
| `SpaceObject` | public ComponentArray<SpaceObjectComponent> |
| `_` | private SubtractiveComponent<OrbitComponent> |

### Methods

```csharp
protected override void OnUpdate()
```
