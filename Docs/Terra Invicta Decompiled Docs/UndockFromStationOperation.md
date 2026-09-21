# UndockFromStationOperation

*Decompiled from `UndockFromStationOperation.cs`.*


## Class `UndockFromStationOperation`

```csharp
public class UndockFromStationOperation : TISpaceFleetOperationTemplate
```

### Fields

| Name | Type |
|---|---|
| `UndockFromStationDuration_days` | public const float |

### Methods

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
public override Type GetTargetingMethod()
```

```csharp
public override int SortOrder()
```

```csharp
private bool CanUndock(TIGameState actorState)
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
public override bool OperationConfirmed(TIGameState actor, TIGameState target, TIDateTime opCompleteDate)
```

```csharp
public override void ExecuteOperation(TIGameState actorState, TIGameState target)
```
