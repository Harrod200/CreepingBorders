# FoundPlatformFromFleetOperation

*Decompiled from `FoundPlatformFromFleetOperation.cs`.*


## Class `FoundPlatformFromFleetOperation`

```csharp
public abstract class FoundPlatformFromFleetOperation : FoundHabFromFleetOperation
```

### Methods

```csharp
public virtual bool DestroyShipOnExecute()
```

```csharp
public override Type GetTargetingMethod()
```

```csharp
public override bool ActorCanPerformOperation(TIGameState actorState, TIGameState target)
```

```csharp
public override List<TIGameState> GetPossibleTargets(TIGameState actorState, TIGameState defaultTarget = null)
```

```csharp
public override bool OnOperationConfirm(TIGameState actorState, TIGameState target, TIResourcesCost resourcesCost = null, Trajectory trajectory = null)
```

```csharp
public override void ExecuteOperation(TIGameState actorState, TIGameState target)
```
