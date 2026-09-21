# TransferOperation

*Decompiled from `TransferOperation.cs`.*


## Class `TransferOperation`

```csharp
public class TransferOperation : TISpaceFleetOperationTemplate
```

### Methods

```csharp
public override OperationTiming GetOperationTiming()
```

```csharp
public override int SortOrder()
```

```csharp
public override bool OpVisibleToActor(TIGameState actorState, TIGameState targetState = null)
```

```csharp
public override bool UpdatePropulsionOnComplete()
```

```csharp
public override bool ActorCanPerformOperation(TIGameState actorState, TIGameState targetState = null)
```

```csharp
public override Type GetTargetingMethod()
```

```csharp
public override bool RequiresThrustProfile()
```

```csharp
public override bool UseAbsoluteCompletionDateFromTrajectory()
```

```csharp
public bool ValidTransferDestinationForFleet(TISpaceFleetState fleet, TIGameState dest)
```

```csharp
public override List<TIGameState> GetPossibleTargets(TIGameState actorState, TIGameState defaultTarget = null)
```

```csharp
public override float GetDuration_days(TIGameState actorState, TIGameState target, Trajectory selectedTrajectory)
```

```csharp
public override bool OnOperationConfirm(TIGameState actorState, TIGameState target, TIResourcesCost resourcesCost, Trajectory trajectory)
```

```csharp
public override void OnOperationCancel(TIGameState actorState, TIGameState target, TIDateTime opCompleteDate)
```

```csharp
public override void ExecuteOperation(TIGameState actorState, TIGameState target)
```

```csharp
public override bool CanCancel()
```
