# CombatSquadronController

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/CombatSquadronController.cs`.*


## Class `CombatSquadronController`

```csharp
public class CombatSquadronController
```

### Fields

| Name | Type |
|---|---|
| `SquadLeader` | public CombatShipController |
| `ManeuverConstraints` | public AccelerationConstraints |
| `SquadronReadyToManeuver` | public bool |
| `shipControllers` | private List<CombatShipController> |
| `squadLeaderController` | private CombatShipController |
| `maneuverabilityConstraints` | private AccelerationConstraints |
| `trajectoryMatchedShips` | private List<CombatShipController> |

### Methods

```csharp
public CombatSquadronController(List<CombatShipController> ships)
```

```csharp
private void SortSquadronListLargestFirst()
```

```csharp
public bool ShipIsTrajectoryMatched(CombatShipController ship)
```

```csharp
public void UpdateTrajectoryMatchedShips(CombatShipController ship, bool hasMatchedTrajectory)
```

```csharp
public bool RemoveShipFromSquadron(TISpaceShipState removedShipState)
```

```csharp
private void OnShipDestroyed(ShipDestroyed e)
```

```csharp
private void OnPropulsionValuesUpdated(CombatShipPropulsionValuesUpdated e)
```
