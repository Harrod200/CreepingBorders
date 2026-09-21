# SpaceObjectRenderingLOD

*Decompiled from `PavonisInteractive/TerraInvicta/Systems/SolarSystem/SpaceObjectRenderingLOD.cs`.*


## Class `SpaceObjectRenderingLOD`

```csharp
public class SpaceObjectRenderingLOD : StrategyLayerComponentSystem
```

### Fields

| Name | Type |
|---|---|
| `SatelliteSymbolRadiusRatio_Sun` | private static readonly double |
| `SatelliteSymbolRadiusRatio_Other` | private static readonly double |
| `ModelRadiusRatio` | private static readonly double |
| `MapRadiusRatio` | private static readonly double |
| `speedToSwapToOrbitTrails` | private const int |
| `spaceObjects` | private SpaceObjectRenderingLOD.SpaceObjectGroup |
| `navigables` | private SpaceObjectRenderingLOD.NavigableGroup |
| `selection` | private SpaceObjectSelection |
| `camera` | private CameraManager |
| `gameTime` | private GameTimeManager |
| `politicalView` | private bool |
| `wasTimeFlowingLastFrame` | private bool |
| `SpaceObjectGroup` | private struct |
| `Length` | public readonly int |
| `GameObject` | public GameObjectArray |
| `LOD` | public ComponentArray<SpaceObjectLODComponent> |
| `SpaceObject` | public ComponentArray<SpaceObjectComponent> |
| `Controller` | public ComponentArray<SpaceObjectController> |
| `Orbit` | public ComponentArray<OrbitComponent> |
| `NavigableGroup` | private struct |
| `Length` | public readonly int |
| `GameObject` | public GameObjectArray |
| `LOD` | public ComponentArray<SpaceObjectLODComponent> |
| `SpaceObject` | public ComponentArray<SpaceObjectComponent> |
| `Controller` | public ComponentArray<SpaceObjectController> |
| `Orbit` | public ComponentArray<OrbitComponent> |
| `Navigable` | public ComponentArray<NavigableComponent> |
| `LagrangePoint` | public ComponentArray<LagrangePointComponent> |

### Methods

```csharp
protected override void OnUpdate()
```

```csharp
private void DetermineLOD(ref Orbit orbit, ref SpaceObject spaceObject, ref SpaceObjectLOD LOD, SpaceObjectController controller, GameObject gameObject, bool politicalView)
```

```csharp
private bool ShouldDisplayModel(ref SpaceObject spaceObject, SpaceObjectController controller)
```

```csharp
private bool ShouldDisplaySurface(ref SpaceObject spaceObject, GameObject gameObject)
```

```csharp
private bool ShouldDisplaySymbol(ref SpaceObject spaceObject, ref Orbit orbit, SpaceObjectController controller, GameObject gameObject, bool fullSpeedCheck, ref bool ShouldDisplaySymbolName)
```

```csharp
private bool ShouldDisplayOrbitTrail(ref SpaceObject spaceObject, ref SpaceObjectLOD LOD, ref Orbit orbit, GameObject gameObject, SpaceObjectController controller, bool politicalView)
```
