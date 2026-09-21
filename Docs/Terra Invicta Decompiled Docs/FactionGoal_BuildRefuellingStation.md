# FactionGoal_BuildRefuellingStation

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_BuildRefuellingStation.cs`.*


## Class `FactionGoal_BuildRefuellingStation`

```csharp
public class FactionGoal_BuildRefuellingStation : FactionGoal_BuildStation
```

### Fields

| Name | Type |
|---|---|
| `incompatibleGoals` | public override List<GoalType> |
| `incompatibleGoalsForTarget` | private static readonly List<GoalType> |

### Methods

```csharp
public FactionGoal_BuildRefuellingStation()
```

```csharp
public FactionGoal_BuildRefuellingStation(TIFactionState faction, int importance, TIHabState hab)
```

```csharp
public static FactionGoal_BuildRefuellingStation CreateGoal(FactionGoal_BuildRefuellingStation p)
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
