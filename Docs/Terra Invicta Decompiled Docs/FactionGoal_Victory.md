# FactionGoal_Victory

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_Victory.cs`.*


## Class `FactionGoal_Victory`

```csharp
public class FactionGoal_Victory : TIFactionGoalState
```

### Fields

| Name | Type |
|---|---|
| `objective` | public override TIObjectiveTemplate |
| `victoryTemplate` | public TIVictoryTemplate |
| `incompatibleGoals` | public override List<GoalType> |
| `victoryMissionTarget` | public TIGameState |
| `victoryTemplateName` | public string |
| `_victoryTemplate` | private TIVictoryTemplate |
| `victoryObjectiveTemplateName` | public string |

### Methods

```csharp
public FactionGoal_Victory()
```

```csharp
public FactionGoal_Victory(TIFactionState faction, TIVictoryTemplate victoryTemplate, TIObjectiveTemplate victoryObjective)
```

```csharp
public static FactionGoal_Victory CreateGoal(FactionGoal_Victory p)
```

```csharp
public override GoalType GetGoalType()
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
public override void RemoveState()
```

```csharp
public override bool ValidNewGoal()
```

```csharp
public override bool IsDuplicate(TIFactionGoalState testGoal, TIGameState testTarget)
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
public override TIGameState goalProduct()
```

```csharp
public override List<TIFactionGoalState> BuildSubsequentGoals()
```

```csharp
public override void ChangeTarget(TIGameState newTarget)
```

```csharp
public override void DailyGoalMaintenance()
```

```csharp
public void ManageCouncilorTransport()
```

```csharp
public void ManageAttacks()
```

```csharp
public IEnumerable<TIGameState> GetAttackTargets()
```
