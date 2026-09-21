# FactionGoal_CaptureNation_Dirty

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_CaptureNation_Dirty.cs`.*


## Class `FactionGoal_CaptureNation_Dirty`

```csharp
public class FactionGoal_CaptureNation_Dirty : FactionGoal_CaptureNation
```

### Fields

| Name | Type |
|---|---|
| `policiesAtTarget` | public override List<PolicyType> |
| `factionLevelPoliciesAtTarget` | public override List<PolicyType> |
| `prioritiesAsNation` | public override Dictionary<PriorityType, int> |
| `missionPayoffMultipliersAgainstTarget` | public override Dictionary<string, float> |
| `incompatibleGoals` | public override List<GoalType> |
| `missionModifiers` | private static readonly Dictionary<string, float> |
| `incompatibleGoalsForTarget` | private static readonly List<GoalType> |

### Properties

- `private static readonly Dictionary<PriorityType, int> prioritySettings = new Dictionary<PriorityType, int>`

### Methods

```csharp
public FactionGoal_CaptureNation_Dirty()
```

```csharp
public FactionGoal_CaptureNation_Dirty(TIFactionState faction, int importance, TINationState nation, GoalType manageNationGoal, TIObjectiveTemplate objective = null)
```

```csharp
public static FactionGoal_CaptureNation_Dirty CreateGoal(FactionGoal_CaptureNation_Dirty prospectiveGoal)
```

```csharp
public override void RemoveState()
```

```csharp
public override GoalType GetGoalType()
```

```csharp
public override List<TIFactionGoalState> BuildSubsequentGoals()
```
