# FactionGoal_SendFleet

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_SendFleet.cs`.*


## Class `FactionGoal_SendFleet`

```csharp
public class FactionGoal_SendFleet : FactionGoal_Fleet
```

### Fields

| Name | Type |
|---|---|
| `incompatibleGoals` | public override List<GoalType> |
| `fleetOperations` | public override List<Type> |
| `incompatibleFleetGoals` | private static readonly List<GoalType> |

### Properties

- `public TIOrbitState destination`

### Methods

```csharp
public FactionGoal_SendFleet(TIFactionState faction, TIOrbitState destination)
```

```csharp
public FactionGoal_SendFleet()
```

```csharp
public static FactionGoal_SendFleet CreateGoal(FactionGoal_SendFleet p)
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
public override List<TIFactionGoalState> BuildSubsequentGoals()
```

```csharp
public override float ComputeDesiredFleetCombatValue()
```

```csharp
public override float GetDesiredAssaultCombatValue()
```

```csharp
public override ShipRole GetPrimaryShipRole()
```

```csharp
public override Dictionary<ShipRole, float> GetSecondaryShipRoles()
```

```csharp
public override bool IsDuplicate(TIFactionGoalState testGoal, TIGameState testTarget)
```

```csharp
public override void ChangeTarget(TIGameState newTarget)
```

```csharp
public override bool NeedsShipsOrdered()
```

```csharp
public override GoalType GetGoalType()
```

```csharp
public override bool ValidNewGoal()
```

```csharp
public override bool InProgress()
```

```csharp
public override bool GoalFulfilled()
```

```csharp
public override bool ShouldDiscardGoal()
```

```csharp
public override void RemoveState()
```

```csharp
public override void OnGoalDiscarded()
```

```csharp
public override bool LeaveMyFleetAlone()
```
