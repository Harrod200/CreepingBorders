# FactionGoal_AttackWithFleet

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_AttackWithFleet.cs`.*


## Class `FactionGoal_AttackWithFleet`

```csharp
public class FactionGoal_AttackWithFleet : FactionGoal_Fleet
```

### Fields

| Name | Type |
|---|---|
| `bombardmentGoal` | public bool |
| `fleetOperations` | public override List<Type> |
| `incompatibleGoals` | public override List<GoalType> |
| `requiresWar` | public bool |
| `incompatibleFleetGoals` | private static readonly List<GoalType> |
| `preferredRoles_spaceTarget` | private Dictionary<ShipRole, float> |
| `preferredRoles_bombardment` | private Dictionary<ShipRole, float> |
| `fleetOps` | public static readonly List<Type> |

### Properties

- `public TIGameState attackTarget`
- `public TIFactionState enemyFaction`
- `public TIGameState colonizationTarget`

### Methods

```csharp
public FactionGoal_AttackWithFleet()
```

```csharp
public FactionGoal_AttackWithFleet(TIFactionState faction, int importance, TIGameState attackTarget, bool requiresWar = false, TIObjectiveTemplate objective = null, bool colonizeAfterwards = false)
```

```csharp
public static FactionGoal_AttackWithFleet CreateGoal(FactionGoal_AttackWithFleet p)
```

```csharp
public override void RemoveState()
```

```csharp
public override void OnGoalComplete()
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
public override bool LeaveMyFleetAlone()
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
public static float ComputeDesiredFleetCombatValueForAttack(TIFactionState faction, TIGameState target, bool onlyConsiderTarget = false, bool isReinforcement = false)
```

```csharp
public override float ComputeDesiredFleetCombatValue()
```

```csharp
public override float GetMaximumFleetCombatValueRatio()
```

```csharp
public static float ComputeKillValue(TIFactionState faction, TIGameState target)
```

```csharp
public static float GetResourceBasedMaximumFleetSize(TIFactionState faction, TIGameState target, float relativeImportance = 1f, float timeCost_days = 0f, float dvCost_kps = 0f, IEnumerable<TISpaceShipTemplate> exampleShips = null, int hypotheticalShipCount = -1, float hypotheticalFleetStrength = -1f)
```

```csharp
public float GetResourceBasedMaximumFleetSize()
```

```csharp
public static float GetDesiredBombardmentValue(TIFactionState bombardingFaction, TIGameState target, int failedAttackCount = 0)
```

```csharp
public float GetDesiredBombardmentValue()
```

```csharp
public bool HasEnoughBombardmentValue(TISpaceFleetState fleet)
```

```csharp
public override bool NeedsShipsOrdered()
```

```csharp
public override float GetDesiredAssaultCombatValue()
```

```csharp
public override bool ReadyForTransferToTarget(TISpaceFleetState fleet)
```
