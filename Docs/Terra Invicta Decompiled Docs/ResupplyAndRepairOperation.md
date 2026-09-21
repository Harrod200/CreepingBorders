# ResupplyAndRepairOperation

*Decompiled from `ResupplyAndRepairOperation.cs`.*


## Class `ResupplyAndRepairOperation`

```csharp
public class ResupplyAndRepairOperation : RepairFleetOperation
```

### Fields

| Name | Type |
|---|---|
| `resupply` | private ResupplyOperation |
| `repair` | private RepairFleetOperation |

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
public override string GetDescription(TIGameState actorState = null, TIGameState target = null)
```

```csharp
public override List<TIResourcesCost> ResourceCostOptions(TIFactionState faction, TIGameState target, TIGameState actor, bool checkCanAfford = true)
```

```csharp
public override bool OnOperationConfirm(TIGameState actorState, TIGameState target, TIResourcesCost resourcesCost = null, Trajectory trajectory = null)
```
