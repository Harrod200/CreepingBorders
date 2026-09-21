# FoundStationOperation

*Decompiled from `FoundStationOperation.cs`.*


## Class `FoundStationOperation`

```csharp
public abstract class FoundStationOperation : FoundHabOperation
```

### Methods

```csharp
public override bool OpVisibleToActor(TIGameState actorState, TIGameState targetState = null)
```

```csharp
public override List<TIGameState> GetPossibleTargets(TIGameState actorState, TIGameState defaultTarget)
```

```csharp
public override Type GetTargetingMethod()
```

```csharp
public override bool OnOperationConfirm(TIGameState actorState, TIGameState target, TIResourcesCost resourcesCost, Trajectory trajectory = null)
```

```csharp
public override void ExecuteOperation(TIGameState actorState, TIGameState target)
```
