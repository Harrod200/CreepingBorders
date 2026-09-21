# DeployArmiesOperation

*Decompiled from `DeployArmiesOperation.cs`.*


## Class `DeployArmiesOperation`

```csharp
public class DeployArmiesOperation : TIArmyOperationTemplate
```

### Fields

| Name | Type |
|---|---|
| `isConvenienceOperation` | public override bool |
| `allowJournies` | private readonly bool |

### Methods

```csharp
public DeployArmiesOperation(bool allowJournies_ = false)
```

```csharp
public override OperationTiming GetOperationTiming()
```

```csharp
public override int SortOrder()
```

```csharp
public override Type GetTargetingMethod()
```

```csharp
public override bool IsCombatOperation()
```

```csharp
public override bool OpVisibleToActor(TIGameState actorState, TIGameState targetState = null)
```

```csharp
public override float GetDuration_days(TIGameState actorState, TIGameState target, Trajectory trajectory = null)
```

```csharp
public override List<TIGameState> GetPossibleTargets(TIGameState actorState, TIGameState defaultTarget = null)
```

```csharp
public static List<TIArmyState> GetEligibleArmies(TIArmyState army)
```

```csharp
public override bool OperationConfirmed(TIGameState actor, TIGameState target, TIDateTime opCompleteDate)
```

```csharp
public override void ExecuteOperation(TIGameState actorState, TIGameState target)
```
