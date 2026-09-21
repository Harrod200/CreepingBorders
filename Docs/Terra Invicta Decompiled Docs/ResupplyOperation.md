# ResupplyOperation

*Decompiled from `ResupplyOperation.cs`.*


## Class `ResupplyOperation`

```csharp
public class ResupplyOperation : FixUpFleetOperation
```

### Fields

| Name | Type |
|---|---|
| `MinRefuelTime_days` | private const float |

### Methods

```csharp
public override bool OpVisibleToActor(TIGameState actorState, TIGameState targetState = null)
```

```csharp
public override int SortOrder()
```

```csharp
public override string GetDescription(TIGameState actorState = null, TIGameState target = null)
```

```csharp
public override bool ActorCanPerformOperation(TIGameState actorState, TIGameState target)
```

```csharp
public override List<TIResourcesCost> ResourceCostOptions(TIFactionState faction, TIGameState target, TIGameState actor, bool checkCanAfford = true)
```

```csharp
public static TIResourcesCost ExpectedShipRefuelCost(TISpaceShipState ship, TIFactionState faction, TISpaceShipTemplate refitTemplate)
```

```csharp
private float RefuelTankAtHabDuration(TISpaceShipState ship, TIHabState hab)
```

```csharp
private float RearmWeaponAtHabDuration(TISpaceShipState ship, TIHabState hab)
```

```csharp
public TIResourcesCost PlanResupply(TISpaceFleetState fleet, bool prospectiveOnly, out bool freeRefueling, Dictionary<TISpaceShipState, float> pendingRepairedMagazines = null, TIResourcesCost committedRepairCost = null, bool checkCanAfford = true)
```

```csharp
public override bool OnOperationConfirm(TIGameState actorState, TIGameState target, TIResourcesCost resourcesCost = null, Trajectory trajectory = null)
```

```csharp
public override void ExecuteOperation(TIGameState actorState, TIGameState target)
```

```csharp
public override void OnOperationCancel(TIGameState actorState, TIGameState target, TIDateTime opCompleteDate)
```
