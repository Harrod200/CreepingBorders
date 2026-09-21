# LaunchProbeOperation

*Decompiled from `LaunchProbeOperation.cs`.*


## Class `LaunchProbeOperation`

```csharp
public class LaunchProbeOperation : TISpaceBodyOperationTemplate
```

### Methods

```csharp
public override OperationTiming GetOperationTiming()
```

```csharp
public override int SortOrder()
```

```csharp
public override Type GetTargetingMethod()
```

```csharp
public override bool UseResourceCostDuration()
```

```csharp
public override string GetDescription(TIGameState actorState = null, TIGameState target = null)
```

```csharp
private float probeBasePayloadMass_tons(TISpaceBodyState body)
```

```csharp
private float ScanDuration_days(TIFactionState faction, TISpaceBodyState target)
```

```csharp
public TIResourcesCost SpaceCost(TIFactionState faction, TIGameState target)
```

```csharp
public TIResourcesCost EarthCost(TIFactionState faction, TIGameState target)
```

```csharp
public override bool OpVisibleToActor(TIGameState actorState, TIGameState targetState = null)
```

```csharp
public override bool ActorCanPerformOperation(TIGameState actorState, TIGameState target)
```

```csharp
public override bool HasResourceCost()
```

```csharp
public override List<TIResourcesCost> ResourceCostOptions(TIFactionState faction, TIGameState target, TIGameState actor, bool checkCanAfford = true)
```

```csharp
public override float GetDuration_days(TIGameState actorState, TIGameState target, Trajectory trajectory = null)
```

```csharp
public override List<TIGameState> GetPossibleTargets(TIGameState actorState, TIGameState defaultTarget = null)
```

```csharp
public override bool OnOperationConfirm(TIGameState actorState, TIGameState target, TIResourcesCost resourcesCost, Trajectory trajectory)
```

```csharp
public override void ExecuteOperation(TIGameState actorState, TIGameState target)
```
