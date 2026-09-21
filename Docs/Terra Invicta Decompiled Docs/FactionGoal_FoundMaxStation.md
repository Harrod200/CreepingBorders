# FactionGoal_FoundMaxStation

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_FoundMaxStation.cs`.*


## Class `FactionGoal_FoundMaxStation`

```csharp
public class FactionGoal_FoundMaxStation : FactionGoal_FoundStation
```

### Fields

| Name | Type |
|---|---|
| `spaceOperations` | public override List<Type> |
| `spaceOps` | private static readonly List<Type> |

### Methods

```csharp
public FactionGoal_FoundMaxStation()
```

```csharp
public FactionGoal_FoundMaxStation(TIFactionState faction, int importance, TIOrbitState orbit, GoalType buildStationGoal, List<TIHabModuleTemplate> requiredModules, GoalType defendGoal, bool setAsPrimaryHab = false, TIObjectiveTemplate objective = null)
```

```csharp
public static FactionGoal_FoundMaxStation CreateGoal(FactionGoal_FoundMaxStation p)
```

```csharp
public override void RemoveState()
```

```csharp
public override GoalType GetGoalType()
```
