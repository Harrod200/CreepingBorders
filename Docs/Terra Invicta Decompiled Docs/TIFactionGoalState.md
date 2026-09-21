# TIFactionGoalState

*Decompiled from `PavonisInteractive/TerraInvicta/TIFactionGoalState.cs`.*


## Class `TIFactionGoalState`

```csharp
public abstract class TIFactionGoalState : TIGameState
```

### Fields

| Name | Type |
|---|---|
| `Age_days` | public float |
| `Age_months` | public float |
| `Age_years` | public float |
| `objective` | public virtual TIObjectiveTemplate |
| `objectiveGoal` | public bool |
| `skipGoal` | public bool |
| `PoliciesAsFactionActor` | public virtual bool |
| `isFleetGoal` | public virtual bool |
| `ref_fleetGoal` | public virtual FactionGoal_Fleet |
| `GrantMissionControlIndulgence` | public virtual bool |
| `description` | public string |
| `forceDiscardGoalImportance` | public const int |
| `minimalGoalImportance` | public const int |
| `lowGoalImportance` | public const int |
| `regularGoalImportance` | public const int |
| `highGoalImportance` | public const int |
| `maxGoalImportance` | public const int |
| `IdealFleetSuperiorityFactor` | public const float |
| `faction` | public TIFactionState |
| `assignedDate` | public TIDateTime |
| `objectiveTemplateName` | private string |
| `_objective` | private TIObjectiveTemplate |
| `subsequentGoals` | public List<GoalType> |
| `FoundStationGoals` | public static readonly List<GoalType> |
| `FoundHabGoals` | public static readonly List<GoalType> |
| `BuildHabGoals` | public static readonly List<GoalType> |
| `CaptureNationGoals` | public static readonly List<GoalType> |
| `NationMissionModifyingGoals` | public static readonly List<GoalType> |
| `FactionMissionModifyingGoals` | public static readonly List<GoalType> |
| `FactionOnFactionGoals` | public static readonly List<GoalType> |
| `NationPriorityModifyingGoals` | public static readonly List<GoalType> |
| `NationManagementGoals` | public static readonly List<GoalType> |
| `BenevolentNationManagementGoals` | public static readonly List<GoalType> |
| `UnificationAllowedManagementGoals` | public static readonly List<GoalType> |
| `OffensiveFleetGoals` | public static readonly List<GoalType> |

### Properties

- `public int importance`
- `public abstract List<GoalType> incompatibleGoals`
- `public virtual List<PolicyType> policiesAsNation`
- `public virtual List<PolicyType> factionLevelPoliciesAsNation`
- `public virtual List<PolicyType> policiesAtTarget`
- `public virtual List<PolicyType> factionLevelPoliciesAtTarget`
- `public virtual Dictionary<string, float> missionPayoffMultipliersAgainstTarget`

### Methods

```csharp
public abstract GoalType GetGoalType()
```

```csharp
public abstract void RemoveState()
```

```csharp
public abstract TIGameState actor()
```

```csharp
public abstract TIGameState target()
```

```csharp
public abstract TIGameState location()
```

```csharp
public abstract bool ValidNewGoal()
```

```csharp
public virtual bool IsDuplicate(TIFactionGoalState testGoal, TIGameState testTarget = null)
```

```csharp
public abstract bool InProgress()
```

```csharp
public abstract bool ShouldDiscardGoal()
```

```csharp
public virtual bool ShouldPauseGoal()
```

```csharp
public abstract bool GoalFulfilled()
```

```csharp
public abstract TIGameState goalProduct()
```

```csharp
public abstract List<TIFactionGoalState> BuildSubsequentGoals()
```

```csharp
public abstract void ChangeTarget(TIGameState newTarget)
```

```csharp
public virtual TIDataTemplate SavingForTemplate(TIFactionState faction, out bool alreadyOrdered, out TIHabModuleState shipyard)
```

```csharp
public TIFactionGoalState()
```

```csharp
public virtual void OnGoalAssigned()
```

```csharp
public virtual void DailyGoalMaintenance()
```

```csharp
public virtual void OnGoalRemoved()
```

```csharp
public virtual void OnGoalDiscarded()
```

```csharp
public virtual void OnGoalComplete()
```

```csharp
public void SetImportance(int importance_)
```

```csharp
public void ChangeImportance(int delta, int min = 1, int max = 20)
```

```csharp
public float FractionalImportance(float minValue = 0f)
```

```csharp
public override void SetDisplayName(string name)
```

```csharp
public float GetMissionPayoffMultiplier(TIMissionTemplate mission, float defaultMultiplier = 1f)
```

```csharp
public virtual bool FoundHabGoal()
```

```csharp
public virtual bool BuildHabGoal()
```

```csharp
public virtual bool NationMissionModifyingGoal()
```

```csharp
public virtual bool FactionMissionModifyingGoal()
```

```csharp
public virtual bool PoliciesAsNationGoal()
```

```csharp
public virtual bool PoliciesAtTargetNationGoal()
```

```csharp
public virtual bool NationPrioritiesGoal()
```
