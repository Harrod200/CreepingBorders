# FactionGoal_MilitarizeNation

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_MilitarizeNation.cs`.*


## Class `FactionGoal_MilitarizeNation`

```csharp
public class FactionGoal_MilitarizeNation : FactionGoal_Nation
```

### Fields

| Name | Type |
|---|---|
| `armyOperations` | public override List<Type> |
| `missionPayoffMultipliersAgainstTarget` | public override Dictionary<string, float> |
| `policiesAsNation` | public override List<PolicyType> |
| `factionLevelPoliciesAtTarget` | public override List<PolicyType> |
| `policiesAtTarget` | public override List<PolicyType> |
| `factionLevelPoliciesAsNation` | public override List<PolicyType> |
| `prioritiesAsNation` | public override Dictionary<PriorityType, int> |
| `incompatibleGoals` | public override List<GoalType> |
| `missionModifiers` | private static readonly Dictionary<string, float> |
| `prioritySettings` | private static readonly Dictionary<PriorityType, int> |
| `incompatibleGoalsForTarget` | private static readonly List<GoalType> |

### Methods

```csharp
public FactionGoal_MilitarizeNation()
```

```csharp
public FactionGoal_MilitarizeNation(TIFactionState faction, int importance, TINationState nation)
```

```csharp
public static FactionGoal_MilitarizeNation CreateGoal(FactionGoal_MilitarizeNation p)
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
