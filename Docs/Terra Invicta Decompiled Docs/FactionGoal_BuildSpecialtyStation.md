# FactionGoal_BuildSpecialtyStation

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_BuildSpecialtyStation.cs`.*


## Class `FactionGoal_BuildSpecialtyStation`

```csharp
public class FactionGoal_BuildSpecialtyStation : FactionGoal_BuildStation
```

### Fields

| Name | Type |
|---|---|
| `incompatibleGoals` | public override List<GoalType> |
| `setAsPrimaryHab` | public bool |
| `incompatibleGoalsForTarget` | private static readonly List<GoalType> |

### Methods

```csharp
public FactionGoal_BuildSpecialtyStation()
```

```csharp
public FactionGoal_BuildSpecialtyStation(TIFactionState faction, int importance, TIHabState hab, List<TIHabModuleTemplate> specialtyModules, bool setAsPrimaryHab, TIObjectiveTemplate objective = null)
```

```csharp
public static FactionGoal_BuildSpecialtyStation CreateGoal(FactionGoal_BuildSpecialtyStation p)
```

```csharp
public override void RemoveState()
```

```csharp
public override GoalType GetGoalType()
```

```csharp
public override bool ShouldDiscardGoal()
```

```csharp
public override bool GoalFulfilled()
```

```csharp
public override List<TIHabModuleTemplate> RequiredModules()
```

```csharp
public override List<TIHabModuleTemplate> allowedModules()
```
