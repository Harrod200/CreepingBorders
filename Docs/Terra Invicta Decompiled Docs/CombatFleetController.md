# CombatFleetController

*Decompiled from `PavonisInteractive/TerraInvicta/CombatFleetController.cs`.*


## Class `CombatFleetController`

```csharp
public class CombatFleetController
```

### Fields

| Name | Type |
|---|---|
| `IsActivePlayerFleet` | public bool |
| `IsFleetDestroyed` | public bool |
| `FleetID` | public string |
| `IsUnderAIControl` | public bool |
| `activeShipControllers` | public IList<CombatShipController> |
| `reinforcements` | public IList<TISpaceShipState> |
| `disengagedShips` | public IList<CombatShipController> |
| `FleetIndex` | public int |
| `InitialVelocty` | public float |
| `CombatRating` | public float |
| `AvgFleetManeuverabilityRatingPerCombatScore` | public float |
| `faction` | public TIFactionState |
| `HasFleetFiredThisCombat` | public bool |
| `_isUnderAIControl` | private bool |

### Properties

- `public TISpaceFleetState fleetState`
- `public GameObject strategyFleetObject`

### Methods

```csharp
private CombatFleetController()
```

```csharp
public CombatFleetController(int fleetIndex, float velocity, TISpaceFleetState fleetState, TIFactionState faction, List<CombatShipController> shipControllers, List<TISpaceShipState> reinforcements, GameObject strategyFleetObject)
```

```csharp
public void EndCombatCleanUp()
```

```csharp
public void UpdateCombatRating()
```

```csharp
public void UpdateAvgFleetManeuverabilityRatingPerCombatScore()
```

```csharp
public Vector3 GetCenterOfMass()
```

```csharp
public Vector3 GetAveragePosition()
```

```csharp
public Vector3 GetFleetVelocityVector()
```

```csharp
public bool AllActiveShipsDestroyed()
```

```csharp
public void AddFleetListeners()
```

```csharp
public void RemoveFleetListeners()
```

```csharp
private void OnShipRemoved(ShipDestroyed e)
```

```csharp
private void OnShipWeaponFired(ShipWeaponFired e)
```

```csharp
private void OnFleetAIControlChanged(FleetAIControlChanged e)
```
