# FactionGoal_InvadeEarth

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_InvadeEarth.cs`.*


## Class `FactionGoal_InvadeEarth`

```csharp
public class FactionGoal_InvadeEarth : FactionGoal_Fleet
```

### Fields

| Name | Type |
|---|---|
| `fleetOperations` | public override List<Type> |
| `incompatibleGoals` | public override List<GoalType> |
| `buildFleetsSequentially` | public override bool |
| `ProspectiveInvasionCombatValue` | public float |
| `preferredShipRoles` | private static readonly Dictionary<ShipRole, float> |

### Properties

- `public static readonly List<Type> fleetOps = new List<Type>(FactionGoal_Fleet.coreFleetOpsList)`

### Methods

```csharp
public FactionGoal_InvadeEarth()
```

```csharp
public FactionGoal_InvadeEarth(TIFactionState faction, int importance)
```

```csharp
public static FactionGoal_InvadeEarth CreateGoal(FactionGoal_InvadeEarth p)
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
public override List<TIFactionGoalState> BuildSubsequentGoals()
```

```csharp
public override void OnGoalComplete()
```

```csharp
public override ShipRole GetPrimaryShipRole()
```

```csharp
public override Dictionary<ShipRole, float> GetSecondaryShipRoles()
```

```csharp
public override bool NeedsPrimaryRoleOrdered(List<TISpaceShipTemplate> pendingShipTemplates)
```

```csharp
public override float ComputeDesiredFleetCombatValue()
```

```csharp
public override float GetDesiredAssaultCombatValue()
```

```csharp
private bool ShouldWaitToInvade()
```

```csharp
public override bool ReadyForTransferToTarget(TISpaceFleetState fleet)
```

```csharp
public override void DailyGoalMaintenance()
```
