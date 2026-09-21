# FactionGoal_CaptureNation_Clean

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_CaptureNation_Clean.cs`.*


## Class `FactionGoal_CaptureNation_Clean`

```csharp
public class FactionGoal_CaptureNation_Clean : FactionGoal_CaptureNation
```

### Fields

| Name | Type |
|---|---|
| `policiesAtTarget` | public override List<PolicyType> |
| `factionLevelPoliciesAtTarget` | public override List<PolicyType> |
| `missionPayoffMultipliersAgainstTarget` | public override Dictionary<string, float> |
| `prioritiesAsNation` | public override Dictionary<PriorityType, int> |
| `incompatibleGoals` | public override List<GoalType> |
| `missionModifiers` | private static readonly Dictionary<string, float> |
| `incompatibleGoalsForTarget` | private static readonly List<GoalType> |

### Properties

- `private static readonly Dictionary<PriorityType, int> prioritySettings = new Dictionary<PriorityType, int>`

### Methods

```csharp
public FactionGoal_CaptureNation_Clean()
```

```csharp
public FactionGoal_CaptureNation_Clean(TIFactionState faction, int importance, TINationState nation, GoalType manageNationGoal, TIObjectiveTemplate objective = null)
```

```csharp
public override void RemoveState()
```

```csharp
public static FactionGoal_CaptureNation_Clean CreateGoal(FactionGoal_CaptureNation_Clean prospectiveGoal)
```

```csharp
public override GoalType GetGoalType()
```

```csharp
public override List<TIFactionGoalState> BuildSubsequentGoals()
```
