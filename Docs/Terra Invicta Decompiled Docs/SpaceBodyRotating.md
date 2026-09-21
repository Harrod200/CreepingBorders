# SpaceBodyRotating

*Decompiled from `PavonisInteractive/TerraInvicta/Systems/SolarSystem/SpaceBodyRotating.cs`.*


## Class `SpaceBodyRotating`

```csharp
public class SpaceBodyRotating : StrategyLayerComponentSystem
```

### Fields

| Name | Type |
|---|---|
| `spaceBodies` | private SpaceBodyRotating.SpaceBodyGroup |
| `gameTime` | private GameTimeManager |
| `camera` | private CameraManager |
| `SpaceBodyGroup` | private struct |
| `Length` | public readonly int |
| `Rotation` | public ComponentArray<SpaceBodyRotationComponent> |
| `SpaceObject` | public ComponentArray<SpaceObjectComponent> |
| `LOD` | public ComponentArray<SpaceObjectLODComponent> |
| `Controller` | public ComponentArray<SpaceObjectController> |

### Methods

```csharp
protected override void OnUpdate()
```

```csharp
public static void CenterSpaceObject(TISpaceObjectState spaceObjectState)
```

```csharp
private static void RotateTransform(Transform transform, ref SpaceObject spaceObject, ref SpaceBodyRotation rotation, DateTime now)
```

```csharp
public static double GetSurfaceRotation(ref SpaceObject spaceObject, ref SpaceBodyRotation rotation, DateTime time)
```

```csharp
public static double GetSurfaceRotation(SpaceObjectController spaceObjectController)
```
