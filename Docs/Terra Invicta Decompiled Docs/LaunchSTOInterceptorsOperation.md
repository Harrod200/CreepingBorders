# LaunchSTOInterceptorsOperation

*Decompiled from `LaunchSTOInterceptorsOperation.cs`.*


## Class `LaunchSTOInterceptorsOperation`

```csharp
public class LaunchSTOInterceptorsOperation : TISpaceBodyOperationTemplate
```

### Methods

```csharp
public override OperationTiming GetOperationTiming()
```

```csharp
public override int SortOrder()
```

```csharp
public override bool ActorCanPerformOperation(TIGameState actorState, TIGameState target)
```

```csharp
public override bool OpVisibleToActor(TIGameState actorState, TIGameState targetState = null)
```

```csharp
public override List<TIGameState> GetPossibleTargets(TIGameState actorState, TIGameState defaultTarget = null)
```

```csharp
public override bool HasResourceCost()
```

```csharp
public override Type GetTargetingMethod()
```

```csharp
public override float GetDuration_days(TIGameState actorState, TIGameState target, Trajectory trajectory = null)
```

```csharp
public override bool OnOperationConfirm(TIGameState actorState, TIGameState target, TIResourcesCost resourcesCost = null, Trajectory trajectory = null)
```

```csharp
public override bool OperationConfirmed(TIGameState actor, TIGameState target, TIDateTime opCompleteDate)
```

```csharp
public override void ExecuteOperation(TIGameState actorState, TIGameState target)
```

```csharp
public override string GetDescription(TIGameState actorState = null, TIGameState target = null)
```

```csharp
public override bool WarnTarget(TIGameState target)
```
