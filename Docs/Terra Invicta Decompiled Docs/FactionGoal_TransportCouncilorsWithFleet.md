# FactionGoal_TransportCouncilorsWithFleet

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_TransportCouncilorsWithFleet.cs`.*


## Class `FactionGoal_TransportCouncilorsWithFleet`

```csharp
public class FactionGoal_TransportCouncilorsWithFleet : FactionGoal_FleetCouncilorGoal
```

### Fields

| Name | Type |
|---|---|
| `incompatibleGoals` | public override List<GoalType> |
| `fleetOperations` | public override List<Type> |
| `buildFleetsSequentially` | public override bool |
| `WantsAdditionalCouncilors` | public override bool |
| `preferredShipRoles` | private readonly Dictionary<ShipRole, float> |

### Properties

- `public static readonly List<Type> fleetOps = new List<Type>(FactionGoal_Fleet.coreFleetOpsList)`

### Methods

```csharp
public FactionGoal_TransportCouncilorsWithFleet()
```

```csharp
public FactionGoal_TransportCouncilorsWithFleet(TIFactionState faction, int importance, List<TICouncilorState> councilors, TIGameState destination)
```

```csharp
public static FactionGoal_TransportCouncilorsWithFleet CreateGoal(FactionGoal_TransportCouncilorsWithFleet p)
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
public override bool ValidNewGoal()
```

```csharp
public override bool IsDuplicate(TIFactionGoalState testGoal, TIGameState testTarget)
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
public override bool RequiresFleet()
```

```csharp
public override void ChangeTarget(TIGameState newTarget)
```

```csharp
public override List<TIFactionGoalState> BuildSubsequentGoals()
```

```csharp
public override ShipRole GetPrimaryShipRole()
```

```csharp
public override Dictionary<ShipRole, float> GetSecondaryShipRoles()
```

```csharp
public override bool ReadyForTransferToTarget(TISpaceFleetState fleet)
```

```csharp
public override float ComputeDesiredFleetCombatValue()
```

```csharp
public override float GetDesiredAssaultCombatValue()
```

```csharp
public override void DailyGoalMaintenance()
```

```csharp
public override bool ShouldUnassignCouncilor(TICouncilorState councilor)
```

```csharp
public override IEnumerable<ValueTuple<TIMissionTemplate, TIGameState>> GetMissionOptions(TICouncilorState councilor)
```
