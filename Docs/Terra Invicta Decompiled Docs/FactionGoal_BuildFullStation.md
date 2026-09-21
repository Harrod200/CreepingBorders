# FactionGoal_BuildFullStation

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_BuildFullStation.cs`.*


## Class `FactionGoal_BuildFullStation`

```csharp
public class FactionGoal_BuildFullStation : FactionGoal_BuildStation
```

### Fields

| Name | Type |
|---|---|
| `incompatibleGoalsForTarget` | private static readonly List<GoalType> |

### Methods

```csharp
public FactionGoal_BuildFullStation()
```

```csharp
public FactionGoal_BuildFullStation(TIFactionState faction, int importance, TIHabState hab)
```

```csharp
public static FactionGoal_BuildFullStation CreateGoal(FactionGoal_BuildFullStation p)
```

```csharp
public override void RemoveState()
```

```csharp
public override List<TIHabModuleTemplate> RequiredModules()
```

```csharp
public override List<TIHabModuleTemplate> allowedModules()
```
