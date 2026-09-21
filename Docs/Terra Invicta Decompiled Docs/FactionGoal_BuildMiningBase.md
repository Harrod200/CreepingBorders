# FactionGoal_BuildMiningBase

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_BuildMiningBase.cs`.*


## Class `FactionGoal_BuildMiningBase`

```csharp
public class FactionGoal_BuildMiningBase : FactionGoal_BuildBase
```

### Fields

| Name | Type |
|---|---|
| `incompatibleGoals` | public override List<GoalType> |
| `incompatibleHabGoals` | private static readonly List<GoalType> |

### Methods

```csharp
public FactionGoal_BuildMiningBase()
```

```csharp
public FactionGoal_BuildMiningBase(TIFactionState faction, int importance, TIHabState hab)
```

```csharp
public static FactionGoal_BuildMiningBase CreateGoal(FactionGoal_BuildMiningBase p)
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
