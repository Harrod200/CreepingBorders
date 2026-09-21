# RepairFleetOperation

*Decompiled from `RepairFleetOperation.cs`.*


## Class `RepairFleetOperation`

```csharp
public class RepairFleetOperation : FixUpFleetOperation
```

### Methods

```csharp
public override int SortOrder()
```

```csharp
public override List<TIGameState> GetPossibleTargets(TIGameState actorState, TIGameState defaultTarget = null)
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
public static TIResourcesCost ExpectedCost(TISpaceFleetState fleet, TIHabState hab, bool checkAffordability, out Dictionary<TISpaceShipState, float> plannedMagazineRepairsMultiplier)
```

```csharp
public static TIResourcesCost ExpectedRefitShipRepairCost(TISpaceShipState refitShip, TIHabState hab, TIFactionState designingFaction, out Dictionary<TISpaceShipState, int> plannedMagazineRepairs)
```

```csharp
public TIResourcesCost SetRepair(TISpaceFleetState fleet)
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
