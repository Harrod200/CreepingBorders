# FactionGoal_CaptureHab

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_CaptureHab.cs`.*


## Class `FactionGoal_CaptureHab`

```csharp
public class FactionGoal_CaptureHab : FactionGoal_FleetCouncilorGoal
```

### Fields

| Name | Type |
|---|---|
| `accomplishWithoutFleet` | private bool |
| `assignedCouncilor` | public TICouncilorState |
| `fleetOperations` | public override List<Type> |
| `incompatibleGoals` | public override List<GoalType> |
| `missionPayoffMultipliersAgainstTarget` | public override Dictionary<string, float> |
| `missionModifiers` | private static readonly Dictionary<string, float> |
| `incompatibleFleetGoals` | private static readonly List<GoalType> |
| `preferredRoles` | private static readonly Dictionary<ShipRole, float> |

### Properties

- `public TIHabState captureTarget`
- `public static readonly List<Type> fleetOps = new List<Type>(FactionGoal_Fleet.coreFleetOpsList)`

### Methods

```csharp
public FactionGoal_CaptureHab()
```

```csharp
public FactionGoal_CaptureHab(TIFactionState faction, int importance, TIHabState captureTarget, GoalType habBuildGoal)
```

```csharp
public static FactionGoal_CaptureHab CreateGoal(FactionGoal_CaptureHab p)
```

```csharp
public override void RemoveState()
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
public override bool InProgress()
```

```csharp
public override bool GoalFulfilled()
```

```csharp
public override GoalType GetGoalType()
```

```csharp
public override bool RequiresFleet()
```

```csharp
public override bool SpaceCombatGoal()
```

```csharp
public override bool FactionMissionModifyingGoal()
```

```csharp
public override bool ReadyForTransferToTarget(TISpaceFleetState fleet)
```

```csharp
public override bool NeedsShipsOrdered()
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
public override float GetDesiredAssaultCombatValue()
```

```csharp
public override IEnumerable<TIMissionTemplate> GetUltimateMissionOptions()
```

```csharp
public override void DailyGoalMaintenance()
```

```csharp
public override bool ShouldDiscardGoal()
```
