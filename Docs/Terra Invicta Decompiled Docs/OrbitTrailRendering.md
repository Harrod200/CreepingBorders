# OrbitTrailRendering

*Decompiled from `PavonisInteractive/TerraInvicta/Systems/SolarSystem/OrbitTrailRendering.cs`.*


## Class `OrbitTrailRendering`

```csharp
public class OrbitTrailRendering : StrategyLayerComponentSystem
```

### Fields

| Name | Type |
|---|---|
| `fixedOrbits` | private OrbitTrailRendering.FixedOrbitGroup |
| `transferOrbits` | private OrbitTrailRendering.TransferOrbitGroup |
| `cameraManager` | private CameraManager |
| `gameTime` | private GameTimeManager |
| `s_uniformOrbitBodyPos` | private static int |
| `wasTimeFlowingLastFrame` | private bool |
| `FixedOrbitGroup` | private struct |
| `Length` | public readonly int |
| `Orbit` | public ComponentArray<OrbitComponent> |
| `SpaceObject` | public ComponentArray<SpaceObjectComponent> |
| `LOD` | public ComponentArray<SpaceObjectLODComponent> |
| `_` | private SubtractiveComponent<TransferPlanComponent> |
| `_2` | private SubtractiveComponent<NavigableComponent> |
| `TransferOrbitGroup` | private struct |
| `Length` | public readonly int |
| `Plan` | public ComponentArray<TransferPlanComponent> |
| `SpaceObject` | public ComponentArray<SpaceObjectComponent> |
| `LOD` | public ComponentArray<SpaceObjectLODComponent> |

### Methods

```csharp
public void TriggerForceTransferUpdate(TISpaceFleetState fleet)
```

```csharp
protected override void OnUpdate()
```

```csharp
private void DrawCompleteOrbit(Orbit orbit, SpaceObject spaceObject, SpaceObjectLOD lod)
```

```csharp
private void DrawTransferOrbit(FleetTransferPlan plan, int segment, SpaceObjectLOD LOD)
```
