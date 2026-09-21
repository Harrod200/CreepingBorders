# FactionGoal_SurveilEarth

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_SurveilEarth.cs`.*


## Class `FactionGoal_SurveilEarth`

```csharp
public class FactionGoal_SurveilEarth : FactionGoal_Fleet
```

### Fields

| Name | Type |
|---|---|
| `fleetOperations` | public override List<Type> |
| `incompatibleGoals` | public override List<GoalType> |
| `preferredShipRoles` | private static readonly Dictionary<ShipRole, float> |

### Properties

- `public static readonly List<Type> fleetOps = new List<Type>(FactionGoal_Fleet.coreFleetOpsList)`

### Methods

```csharp
public FactionGoal_SurveilEarth()
```

```csharp
public FactionGoal_SurveilEarth(TIFactionState faction, int importance)
```

```csharp
public static FactionGoal_SurveilEarth CreateGoal(FactionGoal_SurveilEarth p)
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
public override bool IsDuplicate(TIFactionGoalState testGoal, TIGameState testTarget)
```

```csharp
public override bool ShouldDiscardGoal()
```

```csharp
public override bool GoalFulfilled()
```

```csharp
public override void ChangeTarget(TIGameState newTarget)
```

```csharp
public override float ComputeDesiredFleetCombatValue()
```

```csharp
public override float GetDesiredAssaultCombatValue()
```

```csharp
public override bool ReadyForTransferToTarget(TISpaceFleetState fleet)
```

```csharp
public override ShipRole GetPrimaryShipRole()
```

```csharp
public override Dictionary<ShipRole, float> GetSecondaryShipRoles()
```

```csharp
public override List<TIFactionGoalState> BuildSubsequentGoals()
```
