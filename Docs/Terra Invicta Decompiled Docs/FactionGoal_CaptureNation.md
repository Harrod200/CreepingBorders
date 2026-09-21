# FactionGoal_CaptureNation

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_CaptureNation.cs`.*


## Class `FactionGoal_CaptureNation`

```csharp
public abstract class FactionGoal_CaptureNation : FactionGoal_Nation
```

### Fields

| Name | Type |
|---|---|
| `armyOperations` | public override List<Type> |
| `policiesAsNation` | public override List<PolicyType> |
| `factionLevelPoliciesAsNation` | public override List<PolicyType> |

### Methods

```csharp
public override bool NationPrioritiesGoal()
```

```csharp
public override bool NationMissionModifyingGoal()
```

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
public override bool ValidNewGoal()
```

```csharp
public override bool InProgress()
```

```csharp
public override bool ShouldDiscardGoal()
```

```csharp
public override bool GoalFulfilled()
```

```csharp
public override void OnGoalComplete()
```
