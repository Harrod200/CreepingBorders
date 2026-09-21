# AllArmiesPathHomeOperation

*Decompiled from `AllArmiesPathHomeOperation.cs`.*


## Class `AllArmiesPathHomeOperation`

```csharp
public class AllArmiesPathHomeOperation : TIArmyOperationTemplate
```

### Fields

| Name | Type |
|---|---|
| `isConvenienceOperation` | public override bool |

### Methods

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
public override float GetDuration_days(TIGameState actorState, TIGameState target, Trajectory trajectory = null)
```

```csharp
private List<TIArmyState> EligibleArmies(TIArmyState army)
```

```csharp
public override bool OpVisibleToActor(TIGameState actorState, TIGameState targetState = null)
```

```csharp
public override bool ActorCanPerformOperation(TIGameState actorState, TIGameState target)
```

```csharp
public override List<TIGameState> GetPossibleTargets(TIGameState actorState, TIGameState defaultTarget = null)
```

```csharp
public override void ExecuteOperation(TIGameState actorState, TIGameState target)
```
