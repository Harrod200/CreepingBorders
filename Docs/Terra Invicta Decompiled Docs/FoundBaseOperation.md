# FoundBaseOperation

*Decompiled from `FoundBaseOperation.cs`.*


## Class `FoundBaseOperation`

```csharp
public abstract class FoundBaseOperation : FoundHabOperation
```

### Methods

```csharp
public override bool OpVisibleToActor(TIGameState actorState, TIGameState targetState = null)
```

```csharp
public override List<TIGameState> GetPossibleTargets(TIGameState actorState, TIGameState defaultTarget = null)
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
