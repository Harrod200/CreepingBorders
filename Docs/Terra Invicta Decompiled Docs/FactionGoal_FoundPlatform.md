# FactionGoal_FoundPlatform

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_FoundPlatform.cs`.*


## Class `FactionGoal_FoundPlatform`

```csharp
public class FactionGoal_FoundPlatform : FactionGoal_FoundStation
```

### Fields

| Name | Type |
|---|---|
| `spaceOperations` | public override List<Type> |

### Properties

- `private static readonly List<Type> spaceOps = new List<Type>`

### Methods

```csharp
public FactionGoal_FoundPlatform()
```

```csharp
public FactionGoal_FoundPlatform(TIFactionState faction, int importance, TIOrbitState orbit, GoalType buildStationGoal, List<TIHabModuleTemplate> requiredModules, GoalType defendGoal)
```

```csharp
public static FactionGoal_FoundPlatform CreateGoal(FactionGoal_FoundPlatform p)
```

```csharp
public override void RemoveState()
```

```csharp
public override GoalType GetGoalType()
```
