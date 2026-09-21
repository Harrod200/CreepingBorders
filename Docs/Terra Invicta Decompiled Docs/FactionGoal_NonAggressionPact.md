# FactionGoal_NonAggressionPact

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_NonAggressionPact.cs`.*


## Class `FactionGoal_NonAggressionPact`

```csharp
public class FactionGoal_NonAggressionPact : FactionGoal_FriendlyRelations
```

### Fields

| Name | Type |
|---|---|
| `missionPayoffMultipliersAgainstTarget` | public override Dictionary<string, float> |
| `armyOperations` | public override List<Type> |
| `policiesAtTarget` | public override List<PolicyType> |
| `factionLevelPoliciesAtTarget` | public override List<PolicyType> |
| `incompatibleGoals` | public override List<GoalType> |
| `missionModifiers` | private static readonly Dictionary<string, float> |
| `incompatibleGoalsForFaction` | private static readonly List<GoalType> |
| `policies_faction` | private static readonly List<PolicyType> |

### Properties

- `private static readonly List<PolicyType> policies_SetPolicy = new List<PolicyType>`

### Methods

```csharp
public FactionGoal_NonAggressionPact()
```

```csharp
public FactionGoal_NonAggressionPact(TIFactionState faction, int importance, TIFactionState enemyFaction)
```

```csharp
public static FactionGoal_NonAggressionPact CreateGoal(FactionGoal_NonAggressionPact p)
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
public override void DailyGoalMaintenance()
```

```csharp
public override void OnGoalComplete()
```

```csharp
public override void OnGoalRemoved()
```
