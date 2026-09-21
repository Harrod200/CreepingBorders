# SpaceObjectPositioning

*Decompiled from `PavonisInteractive/TerraInvicta/Systems/SolarSystem/SpaceObjectPositioning.cs`.*


## Class `SpaceObjectPositioning`

```csharp
public class SpaceObjectPositioning : StrategyLayerComponentSystem
```

### Fields

| Name | Type |
|---|---|
| `spaceObjectGroup` | private SpaceObjectPositioning.SpaceObjectGroup |
| `lagrangePointGroup` | private SpaceObjectPositioning.NavigableGroup |
| `fleetTransfers` | private SpaceObjectPositioning.FleetTransferGroup |
| `fleet` | private SpaceObjectPositioning.FleetGroup |
| `gameTime` | private GameTimeManager |
| `cameraManager` | private CameraManager |
| `forceUpdate` | private bool |
| `oldSpaceObjectGroupLength` | private int |
| `oldTransfersLength` | private int |
| `oldFleetGroupLength` | private int |
| `now` | private TIDateTime |
| `lastUpdateDate` | private TIDateTime |
| `arrivals` | private Dictionary<TISpaceFleetState, TIDateTime> |
| `SpaceObjectGroup` | private struct |
| `Length` | public readonly int |
| `Orbit` | public ComponentArray<OrbitComponent> |
| `SpaceObject` | public ComponentArray<SpaceObjectComponent> |
| `_` | private SubtractiveComponent<NavigableComponent> |
| `_transferPlan` | private SubtractiveComponent<TransferPlanComponent> |
| `NavigableGroup` | private struct |
| `Length` | public readonly int |
| `Orbit` | public ComponentArray<OrbitComponent> |
| `Navigable` | public ComponentArray<NavigableComponent> |
| `SpaceObject` | public ComponentArray<SpaceObjectComponent> |
| `FleetTransferGroup` | private struct |
| `Length` | public readonly int |
| `GameObject` | public GameObjectArray |
| `TransferPlan` | public ComponentArray<TransferPlanComponent> |
| `SpaceObject` | public ComponentArray<SpaceObjectComponent> |
| `FleetGroup` | private struct |
| `Length` | public readonly int |
| `FleetObject` | public ComponentArray<FleetComponent> |
| `SpaceObject` | public ComponentArray<SpaceObjectComponent> |

### Methods

```csharp
public void ResetCounts()
```

```csharp
public void TriggerForceUpdate()
```

```csharp
protected override void OnUpdate()
```

```csharp
private static double EaseInOutSine(double value, double start = 0.0, double end = 0.0)
```
