# FactionGoal_JoinFleet

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_JoinFleet.cs`.*


## Class `FactionGoal_JoinFleet`

```csharp
public class FactionGoal_JoinFleet : FactionGoal_Fleet
```

### Fields

| Name | Type |
|---|---|
| `incompatibleGoals` | public override List<GoalType> |
| `fleetOperations` | public override List<Type> |
| `incompatibleFleetGoals` | private static readonly List<GoalType> |

### Properties

- `public TISpaceFleetState targetFleet`
- `public FactionGoal_Fleet targetFleetGoal`

### Methods

```csharp
public FactionGoal_JoinFleet()
```

```csharp
public FactionGoal_JoinFleet(TIFactionState faction, TISpaceFleetState targetFleet)
```

```csharp
public static FactionGoal_JoinFleet CreateGoal(FactionGoal_JoinFleet p)
```

```csharp
public override void AssignFleet(TISpaceFleetState fleet)
```

```csharp
public override void UnassignFleet()
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
public override List<TIFactionGoalState> BuildSubsequentGoals()
```

```csharp
public override float ComputeDesiredFleetCombatValue()
```

```csharp
public override bool ReadyForTransferToTarget(TISpaceFleetState fleet)
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
public override bool ValidNewGoal()
```

```csharp
public override bool GoalFulfilled()
```

```csharp
public override bool ShouldDiscardGoal()
```

```csharp
public override bool InProgress()
```

```csharp
public override void ChangeTarget(TIGameState newTarget)
```

```csharp
public override bool NeedsShipsOrdered()
```

```csharp
public override void OnGoalDiscarded()
```
