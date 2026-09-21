# FactionGoal_BuildHab

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_BuildHab.cs`.*


## Class `FactionGoal_BuildHab`

```csharp
public abstract class FactionGoal_BuildHab : TIFactionGoalState
```

### Fields

| Name | Type |
|---|---|
| `ref_hab` | public override TIHabState |
| `GrantMissionControlIndulgence` | public override bool |
| `specialModules` | protected List<TIHabModuleTemplate> |
| `incompatibleGoals` | public override List<GoalType> |
| `specialtyModuleDataNames` | public List<string> |

### Properties

- `public TIHabState hab`

### Methods

```csharp
public override TIGameState actor()
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
public override bool InProgress()
```

```csharp
public override bool BuildHabGoal()
```

```csharp
public override void ChangeTarget(TIGameState newTarget)
```

```csharp
public override List<TIFactionGoalState> BuildSubsequentGoals()
```

```csharp
public virtual List<TIHabModuleTemplate> RequiredModules()
```

```csharp
public virtual List<TIHabModuleTemplate> allowedModules()
```

```csharp
public override TIDataTemplate SavingForTemplate(TIFactionState faction, out bool alreadyOrdered, out TIHabModuleState shipyard)
```

```csharp
public override bool ValidNewGoal()
```

```csharp
public override bool ShouldDiscardGoal()
```

```csharp
public override bool GoalFulfilled()
```
