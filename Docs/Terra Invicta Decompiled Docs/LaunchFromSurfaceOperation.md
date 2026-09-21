# LaunchFromSurfaceOperation

*Decompiled from `LaunchFromSurfaceOperation.cs`.*


## Class `LaunchFromSurfaceOperation`

```csharp
public class LaunchFromSurfaceOperation : TISpaceFleetOperationTemplate
```

### Methods

```csharp
public override int SortOrder()
```

```csharp
public override OperationTiming GetOperationTiming()
```

```csharp
public override bool IsBlockingOperation()
```

```csharp
public override bool OpVisibleToActor(TIGameState actorState, TIGameState targetState = null)
```

```csharp
public override bool ActorCanPerformOperation(TIGameState actorState, TIGameState target)
```

```csharp
public override float GetDuration_days(TIGameState actorState, TIGameState target, Trajectory trajectory = null)
```

```csharp
public override List<TIGameState> GetPossibleTargets(TIGameState actorState, TIGameState defaultTarget = null)
```

```csharp
public override Type GetTargetingMethod()
```

```csharp
public override void ExecuteOperation(TIGameState actorState, TIGameState target)
```
