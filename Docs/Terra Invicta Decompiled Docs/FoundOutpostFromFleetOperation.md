# FoundOutpostFromFleetOperation

*Decompiled from `FoundOutpostFromFleetOperation.cs`.*


## Class `FoundOutpostFromFleetOperation`

```csharp
public abstract class FoundOutpostFromFleetOperation : FoundHabFromFleetOperation
```

### Fields

| Name | Type |
|---|---|
| `fleet` | private TISpaceFleetState |

### Methods

```csharp
public override Type GetTargetingMethod()
```

```csharp
public override bool ActorCanPerformOperation(TIGameState actorState, TIGameState target)
```

```csharp
public override bool OnOperationConfirm(TIGameState actorState, TIGameState target, TIResourcesCost resourcesCost = null, Trajectory trajectory = null)
```

```csharp
public override List<TIGameState> GetPossibleTargets(TIGameState actorState, TIGameState defaultTarget = null)
```

```csharp
public override void ExecuteOperation(TIGameState actorState, TIGameState target)
```
