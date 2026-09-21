# FactionGoal_FoundStation

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_FoundStation.cs`.*


## Class `FactionGoal_FoundStation`

```csharp
public class FactionGoal_FoundStation : FactionGoal_FoundHab
```

### Fields

| Name | Type |
|---|---|
| `fleetOperations` | public override List<Type> |
| `incompatibleGoals` | public override List<GoalType> |
| `spaceOperations` | public override List<Type> |
| `fleetOps` | public static readonly List<Type> |
| `spaceOps` | private static readonly List<Type> |

### Properties

- `public TIOrbitState orbit`

### Methods

```csharp
public FactionGoal_FoundStation()
```

```csharp
public FactionGoal_FoundStation(TIFactionState faction, int importance, TIOrbitState orbit, GoalType buildStationGoal, List<TIHabModuleTemplate> requiredModules, GoalType defendGoal)
```

```csharp
public static FactionGoal_FoundStation CreateGoal(FactionGoal_FoundStation p)
```

```csharp
public override TIGameState target()
```

```csharp
public override TIGameState location()
```

```csharp
public override bool ValidNewGoal()
```

```csharp
public override bool GoalFulfilled()
```

```csharp
public override bool ShouldDiscardGoal()
```

```csharp
public override void ChangeTarget(TIGameState newTarget)
```

```csharp
public override List<TIFactionGoalState> BuildSubsequentGoals()
```

```csharp
public override void RemoveState()
```

```csharp
public override GoalType GetGoalType()
```

```csharp
public virtual IEnumerable<TIOrbitState> GetAlternativeOrbits()
```

```csharp
public override void DailyGoalMaintenance()
```
