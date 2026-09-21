# LaunchMultipleProbesOperation

*Decompiled from `LaunchMultipleProbesOperation.cs`.*


## Class `LaunchMultipleProbesOperation`

```csharp
public abstract class LaunchMultipleProbesOperation : TISpaceBodyOperationTemplate
```

### Methods

```csharp
public override OperationTiming GetOperationTiming()
```

```csharp
public override Type GetTargetingMethod()
```

```csharp
public override float GetDuration_days(TIGameState actorState, TIGameState target, Trajectory trajectory = null)
```

```csharp
public override bool HasResourceCost()
```

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
public override List<TIResourcesCost> ResourceCostOptions(TIFactionState faction, TIGameState target, TIGameState actor, bool checkCanAfford = true)
```

```csharp
public override void ExecuteOperation(TIGameState actorState, TIGameState target)
```
