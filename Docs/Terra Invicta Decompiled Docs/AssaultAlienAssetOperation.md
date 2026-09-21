# AssaultAlienAssetOperation

*Decompiled from `AssaultAlienAssetOperation.cs`.*


## Class `AssaultAlienAssetOperation`

```csharp
public class AssaultAlienAssetOperation : TIArmyOperationTemplate, IContestedOperation
```

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
public string targetStr(TIGameState target)
```

```csharp
public override string GetSuccessHeadline(TIArmyState army, TIGameState target)
```

```csharp
public override string GetFailureHeadline(TIArmyState army, TIGameState target)
```

```csharp
public override string GetSuccessSummary(TIArmyState army, TIGameState target)
```

```csharp
public override string GetFailureSummary(TIArmyState army, TIGameState target)
```

```csharp
public override string GetSuccessDetail(TIArmyState army, TIGameState target)
```

```csharp
public override string GetFailureDetail(TIArmyState army, TIGameState target)
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
public override float GetDuration_days(TIGameState actorState, TIGameState target, Trajectory trajectory = null)
```

```csharp
public float GetSuccessChance(TIGameState actor, TIGameState defender)
```

```csharp
public override bool OperationConfirmed(TIGameState actor, TIGameState target, TIDateTime opCompleteDate)
```

```csharp
public override void ExecuteOperation(TIGameState actorState, TIGameState target)
```

```csharp
public override bool Repeatable()
```
