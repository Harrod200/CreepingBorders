# TransferOfficersOperation

*Decompiled from `TransferOfficersOperation.cs`.*


## Class `TransferOfficersOperation`

```csharp
public class TransferOfficersOperation : TISpaceFleetOperationTemplate
```

### Fields

| Name | Type |
|---|---|
| `plannedShipToShipTransfers` | public Dictionary<TIOfficerState, OfficerCarrierState> |

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
public static List<TIResourcesCost> ResourceCostOptions(Dictionary<TIOfficerState, OfficerCarrierState> plannedShipToShipTransfers)
```

```csharp
public override string GetDescription(TIGameState actorState = null, TIGameState target = null)
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
public override List<TIGameState> GetPossibleTargets(TIGameState actorState, TIGameState defaultTarget = null)
```

```csharp
public override void ExecuteOperation(TIGameState actorState, TIGameState target)
```
