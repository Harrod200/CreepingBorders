# FactionGoal_WarOnFaction

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_WarOnFaction.cs`.*


## Class `FactionGoal_WarOnFaction`

```csharp
public class FactionGoal_WarOnFaction : FactionGoal_Faction
```

### Fields

| Name | Type |
|---|---|
| `missionPayoffMultipliersAgainstTarget` | public override Dictionary<string, float> |
| `armyOperations` | public override List<Type> |
| `policiesAtTarget` | public override List<PolicyType> |
| `factionLevelPoliciesAtTarget` | public override List<PolicyType> |
| `incompatibleGoals` | public override List<GoalType> |
| `AlienTotalWarHateThreshold` | public static float |
| `missionModifiers` | private static readonly Dictionary<string, float> |
| `incompatibleGoalsForFaction` | private static readonly List<GoalType> |
| `firstMaintenanceCompleted` | private bool |

### Properties

- `public bool IsTotalWar`

### Methods

```csharp
public FactionGoal_WarOnFaction()
```

```csharp
public FactionGoal_WarOnFaction(TIFactionState faction, int importance, TIFactionState enemyFaction, TIObjectiveTemplate objective = null)
```

```csharp
public static FactionGoal_WarOnFaction CreateGoal(FactionGoal_WarOnFaction prospectiveGoal)
```

```csharp
public override void RemoveState()
```

```csharp
public override bool NationMissionModifyingGoal()
```

```csharp
public override bool FactionMissionModifyingGoal()
```

```csharp
public override bool PoliciesAtTargetNationGoal()
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
public override bool InProgress()
```

```csharp
public override bool ShouldDiscardGoal()
```

```csharp
public override bool GoalFulfilled()
```

```csharp
public override void OnGoalAssigned()
```

```csharp
public override void DailyGoalMaintenance()
```
