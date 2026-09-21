# FactionGoal_ExpandNation

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_ExpandNation.cs`.*


## Class `FactionGoal_ExpandNation`

```csharp
public class FactionGoal_ExpandNation : FactionGoal_Nation
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
| `prioritySettings_war` | private static readonly Dictionary<PriorityType, int> |
| `prioritySettings_peaceful` | private static readonly Dictionary<PriorityType, int> |
| `incompatibleGoalsForNation` | private static readonly List<GoalType> |

### Methods

```csharp
public FactionGoal_ExpandNation()
```

```csharp
public FactionGoal_ExpandNation(TIFactionState faction, int importance, TINationState nation)
```

```csharp
public static FactionGoal_ExpandNation CreateGoal(FactionGoal_ExpandNation prospectiveGoal)
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
