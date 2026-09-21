# FactionGoal_DefendWithFleet

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_DefendWithFleet.cs`.*


## Class `FactionGoal_DefendWithFleet`

```csharp
public class FactionGoal_DefendWithFleet : FactionGoal_Fleet
```

### Fields

| Name | Type |
|---|---|
| `fleetOperations` | public override List<Type> |
| `incompatibleGoals` | public override List<GoalType> |
| `IsPrimarySystemDefender` | public bool |
| `desiredFlagshipHull` | public override TIShipHullTemplate |
| `incompatibleFleetGoals` | private static readonly List<GoalType> |
| `fleetOps` | public static readonly List<Type> |
| `preferredRoles` | private static readonly Dictionary<ShipRole, float> |
| `desiredFleetCombatValue_sansEarmarked` | private float |

### Properties

- `public TIGameState defendTarget`
- `public string forceHullTemplateName`
- `public int EarmarkedFleetMC`

### Methods

```csharp
public FactionGoal_DefendWithFleet()
```

```csharp
public FactionGoal_DefendWithFleet(TIFactionState faction, int importance, TIGameState defendTarget, string forceHullTemplateName = "")
```

```csharp
public static FactionGoal_DefendWithFleet CreateGoal(FactionGoal_DefendWithFleet p)
```

```csharp
public override void RemoveState()
```

```csharp
public override GoalType GetGoalType()
```

```csharp
public override TIGameState actor()
```

```csharp
public override TIGameState target()
```

```csharp
public override TIGameState location()
```

```csharp
public override TIGameState goalProduct()
```

```csharp
public override bool RequiresFleet()
```

```csharp
public override bool ValidNewGoal()
```

```csharp
public override bool InProgress()
```

```csharp
public override bool ShouldDiscardGoal()
```

```csharp
public override bool GoalFulfilled()
```

```csharp
public override bool SpaceCombatGoal()
```

```csharp
public override ShipRole GetPrimaryShipRole()
```

```csharp
public override Dictionary<ShipRole, float> GetSecondaryShipRoles()
```

```csharp
public override void ChangeTarget(TIGameState newTarget)
```

```csharp
public override List<TIFactionGoalState> BuildSubsequentGoals()
```

```csharp
public override float ComputeDesiredFleetCombatValue()
```

```csharp
public IEnumerable<TISpaceFleetState> GetCampers()
```

```csharp
public float GetStrengthNeededToDealWithCampers()
```

```csharp
public override float GetForcePursueFleetCombatValue(TISpaceFleetState enemyFleet, TIHabState hab)
```

```csharp
public override float GetMaximumFleetCombatValueRatio()
```

```csharp
public override bool ReadyForTransferToTarget(TISpaceFleetState fleet)
```

```csharp
public override bool LeaveMyFleetAlone()
```

```csharp
public override float GetDesiredAssaultCombatValue()
```
