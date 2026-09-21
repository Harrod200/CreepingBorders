# FactionGoal_BuildSpecialtyBase

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_BuildSpecialtyBase.cs`.*


## Class `FactionGoal_BuildSpecialtyBase`

```csharp
public class FactionGoal_BuildSpecialtyBase : FactionGoal_BuildBase
```

### Fields

| Name | Type |
|---|---|
| `incompatibleGoals` | public override List<GoalType> |
| `setAsPrimaryHab` | public bool |
| `incompatibleHabGoals` | private static readonly List<GoalType> |

### Methods

```csharp
public FactionGoal_BuildSpecialtyBase()
```

```csharp
public FactionGoal_BuildSpecialtyBase(TIFactionState faction, int importance, TIHabState hab, List<TIHabModuleTemplate> specialtyModules, bool setAsPrimaryHab, TIObjectiveTemplate objective = null)
```

```csharp
public static FactionGoal_BuildSpecialtyBase CreateGoal(FactionGoal_BuildSpecialtyBase p)
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
