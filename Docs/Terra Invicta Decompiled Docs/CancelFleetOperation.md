# CancelFleetOperation

*Decompiled from `CancelFleetOperation.cs`.*


## Class `CancelFleetOperation`

```csharp
public class CancelFleetOperation : TISpaceFleetOperationTemplate
```

### Methods

```csharp
public override int SortOrder()
```

```csharp
public override bool OpVisibleToActor(TIGameState actorState, TIGameState targetState = null)
```

```csharp
public override bool ActorCanPerformOperation(TIGameState actorState, TIGameState target)
```

```csharp
public override bool OperationConfirmed(TIGameState actor, TIGameState target, TIDateTime opCompleteDate)
```

```csharp
public override void ExecuteOperation(TIGameState actorState, TIGameState target)
```

```csharp
public override OperationTiming GetOperationTiming()
```

```csharp
public override Type GetTargetingMethod()
```

```csharp
public override float GetDuration_days(TIGameState actorState, TIGameState target, Trajectory trajectory = null)
```

```csharp
public override List<TIGameState> GetPossibleTargets(TIGameState actorState, TIGameState defaultTarget = null)
```
