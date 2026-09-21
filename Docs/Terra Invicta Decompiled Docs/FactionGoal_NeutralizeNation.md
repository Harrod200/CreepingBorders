# FactionGoal_NeutralizeNation

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_NeutralizeNation.cs`.*


## Class `FactionGoal_NeutralizeNation`

```csharp
public class FactionGoal_NeutralizeNation : FactionGoal_Nation
```

### Fields

| Name | Type |
|---|---|
| `missionPayoffMultipliersAgainstTarget` | public override Dictionary<string, float> |
| `armyOperations` | public override List<Type> |
| `policiesAsNation` | public override List<PolicyType> |
| `factionLevelPoliciesAsNation` | public override List<PolicyType> |
| `policiesAtTarget` | public override List<PolicyType> |
| `factionLevelPoliciesAtTarget` | public override List<PolicyType> |
| `prioritiesAsNation` | public override Dictionary<PriorityType, int> |
| `incompatibleGoals` | public override List<GoalType> |
| `missionModifiers` | private static readonly Dictionary<string, float> |
| `prioritySettings` | private static readonly Dictionary<PriorityType, int> |
| `armyOps` | private static readonly List<Type> |
| `incompatibleGoalsForTarget` | private static readonly List<GoalType> |

### Methods

```csharp
public FactionGoal_NeutralizeNation()
```

```csharp
public FactionGoal_NeutralizeNation(TIFactionState faction, int importance, TINationState nation, TIObjectiveTemplate objective = null)
```

```csharp
public static FactionGoal_NeutralizeNation CreateGoal(FactionGoal_NeutralizeNation prospectiveGoal)
```

```csharp
public override void RemoveState()
```

```csharp
public override bool NationMissionModifyingGoal()
```

```csharp
public override bool NationPrioritiesGoal()
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
public override List<TIFactionGoalState> BuildSubsequentGoals()
```

```csharp
public static bool ShouldNeutralizeNation(TIFactionState faction, TINationState enemy)
```

```csharp
public override void DailyGoalMaintenance()
```

```csharp
public override void OnGoalRemoved()
```
