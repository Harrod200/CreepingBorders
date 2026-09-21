# LandOnSurfaceOperation

*Decompiled from `LandOnSurfaceOperation.cs`.*


## Class `LandOnSurfaceOperation`

```csharp
public class LandOnSurfaceOperation : TISpaceFleetOperationTemplate
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
public override bool CancelUponCombat()
```

```csharp
private bool CanLandOnSurface(TIGameState actorState)
```

```csharp
public override bool ActorCanPerformOperation(TIGameState actorState, TIGameState target)
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
public override Type GetTargetingMethod()
```

```csharp
public override void ExecuteOperation(TIGameState actorState, TIGameState target)
```
