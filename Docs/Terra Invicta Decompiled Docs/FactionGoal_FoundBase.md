# FactionGoal_FoundBase

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_FoundBase.cs`.*


## Class `FactionGoal_FoundBase`

```csharp
public class FactionGoal_FoundBase : FactionGoal_FoundHab
```

### Fields

| Name | Type |
|---|---|
| `fleetOperations` | public override List<Type> |
| `spaceOperations` | public override List<Type> |
| `incompatibleGoals` | public override List<GoalType> |
| `spaceOps` | private static readonly List<Type> |
| `fleetOps` | private static readonly List<Type> |

### Properties

- `public TIHabSiteState site`

### Methods

```csharp
public FactionGoal_FoundBase()
```

```csharp
public FactionGoal_FoundBase(TIFactionState faction, int importance, TIHabSiteState site, GoalType buildBaseGoal, List<TIHabModuleTemplate> requiredModules, GoalType buildStationGoal, bool setAsPrimaryHab = false, TIObjectiveTemplate objective = null)
```

```csharp
public static FactionGoal_FoundBase CreateGoal(FactionGoal_FoundBase p)
```

```csharp
public override void RemoveState()
```

```csharp
public override List<TIFactionGoalState> BuildSubsequentGoals()
```

```csharp
public override GoalType GetGoalType()
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
public override bool ShouldDiscardGoal()
```

```csharp
public override void ChangeTarget(TIGameState newTarget)
```

```csharp
public override void DailyGoalMaintenance()
```
