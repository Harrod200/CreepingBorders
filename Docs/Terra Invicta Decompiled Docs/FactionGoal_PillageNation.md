# FactionGoal_PillageNation

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_PillageNation.cs`.*


## Class `FactionGoal_PillageNation`

```csharp
public class FactionGoal_PillageNation : FactionGoal_Nation
```

### Fields

| Name | Type |
|---|---|
| `policiesAsNation` | public override List<PolicyType> |
| `factionLevelPoliciesAsNation` | public override List<PolicyType> |
| `policiesAtTarget` | public override List<PolicyType> |
| `factionLevelPoliciesAtTarget` | public override List<PolicyType> |
| `armyOperations` | public override List<Type> |
| `missionPayoffMultipliersAgainstTarget` | public override Dictionary<string, float> |
| `prioritiesAsNation` | public override Dictionary<PriorityType, int> |
| `incompatibleGoals` | public override List<GoalType> |
| `missionModifiers` | private static readonly Dictionary<string, float> |
| `executivepolicies_SetPolicy` | private static readonly List<PolicyType> |
| `prioritySettings` | private static readonly Dictionary<PriorityType, int> |
| `incompatibleGoalsForTarget` | private static readonly List<GoalType> |

### Methods

```csharp
public FactionGoal_PillageNation()
```

```csharp
public FactionGoal_PillageNation(TIFactionState faction, int importance, TINationState nation)
```

```csharp
public static FactionGoal_PillageNation CreateGoal(FactionGoal_PillageNation p)
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
