# FactionGoal_BuildFullBase

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_BuildFullBase.cs`.*


## Class `FactionGoal_BuildFullBase`

```csharp
public class FactionGoal_BuildFullBase : FactionGoal_BuildBase
```

### Fields

| Name | Type |
|---|---|
| `incompatibleGoals` | public override List<GoalType> |
| `incompatibleHabGoals` | private static readonly List<GoalType> |

### Methods

```csharp
public FactionGoal_BuildFullBase()
```

```csharp
public FactionGoal_BuildFullBase(TIFactionState faction, int importance, TIHabState hab)
```

```csharp
public static FactionGoal_BuildFullBase CreateGoal(FactionGoal_BuildFullBase p)
```

```csharp
public override void RemoveState()
```

```csharp
public override GoalType GetGoalType()
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
