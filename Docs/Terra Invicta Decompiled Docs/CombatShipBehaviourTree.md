# CombatShipBehaviourTree

*Decompiled from `PavonisInteractive/TerraInvicta/GamePlayScript/AI/CombatShipBehaviourTree.cs`.*


## Class `CombatShipBehaviourTree`

```csharp
public abstract class CombatShipBehaviourTree
```

### Fields

| Name | Type |
|---|---|
| `_rootNode` | protected RootNode |
| `_localData` | protected CombatShipBehaviourTree.LocalBehaviourData |
| `ConditionResponse` | public enum |
| `SharedBehaviourData` | public class |
| `PathFinder` | public Pathfinding |
| `FleetController` | public CombatFleetController |
| `OpposingFleetController` | public CombatFleetController |
| `SecondsBetweenWaypoints` | public float |
| `Priority` | public CombatShipBehaviourTree.SharedBehaviourData.FleetPriority |
| `CurrentTime` | public TIDateTime |
| `FactionState` | public TIFactionState |
| `ShipController` | public CombatShipController |
| `HabModuleControllers` | public CombatHabModuleController[] |
| `MinimumDVThreshold` | public float |
| `FleetPriority` | public enum |
| `LocalBehaviourData` | public class |
| `TargetShip` | public CombatShipController |
| `TargetModule` | public CombatHabModuleController |
| `SquadronController` | public CombatSquadronController |
| `MinimumScaledCombatRange` | public float |
| `TargetType` | public CombatTargetPriority |
| `CombatReady` | public bool |
| `IsRammingTargetShip` | public bool |
| `IsDisengaging` | public bool |
| `SecondsPerTrajectoryUpdate` | public int |
| `TargetHeadingTestAngle` | public float |

### Properties

- `public CombatShipBehaviourTree.SharedBehaviourData SharedData`

### Methods

```csharp
protected CombatShipBehaviourTree()
```

```csharp
public CombatShipBehaviourTree(Pathfinding pathfinder, CombatFleetController fleetController, [Nullable(2)] CombatFleetController opposingFleetController, float secondsBetweenWaypoints, CombatShipBehaviourTree.SharedBehaviourData.FleetPriority priority, TIDateTime time, CombatShipController shipController, CombatHabModuleController[] habControllers)
```

```csharp
public void Update(TIDateTime time)
```

```csharp
protected abstract void CreateTree()
```
