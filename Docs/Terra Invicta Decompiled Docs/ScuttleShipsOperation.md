# ScuttleShipsOperation

*Decompiled from `ScuttleShipsOperation.cs`.*


## Class `ScuttleShipsOperation`

```csharp
public class ScuttleShipsOperation : TISpaceFleetOperationTemplate
```

### Methods

```csharp
public override OperationTiming GetOperationTiming()
```

```csharp
public override int SortOrder()
```

```csharp
public override bool UpdatePropulsionOnComplete()
```

```csharp
public override bool IsBlockingOperation()
```

```csharp
public override bool OpVisibleToActor(TIGameState actorState, TIGameState targetState = null)
```

```csharp
public override float GetDuration_days(TIGameState actorState, TIGameState target, Trajectory trajectory = null)
```

```csharp
public override bool ActorCanPerformOperation(TIGameState actorState, TIGameState target)
```

```csharp
public override Type GetTargetingMethod()
```

```csharp
public override void ExecuteOperation(TIGameState actorState, TIGameState target)
```

```csharp
public override bool OnOperationConfirm(TIGameState actorState, TIGameState target, TIResourcesCost resourcesCost = null, Trajectory trajectory = null)
```

```csharp
public override List<TIGameState> GetPossibleTargets(TIGameState actorState, TIGameState defaultTarget = null)
```

```csharp
public static void ScuttleShipsFromFleet(TISpaceFleetState fleet, List<TISpaceShipState> shipsToScuttle)
```
