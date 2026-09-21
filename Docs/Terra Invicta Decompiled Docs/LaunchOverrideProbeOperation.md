# LaunchOverrideProbeOperation

*Decompiled from `LaunchOverrideProbeOperation.cs`.*


## Class `LaunchOverrideProbeOperation`

```csharp
public class LaunchOverrideProbeOperation : LaunchProbeOperation
```

### Methods

```csharp
public override bool OpVisibleToActor(TIGameState actorState, TIGameState targetState = null)
```

```csharp
public override List<TIResourcesCost> ResourceCostOptions(TIFactionState faction, TIGameState target, TIGameState actor, bool checkCanAfford = true)
```

```csharp
public override string GetDescription(TIGameState actorState = null, TIGameState target = null)
```

```csharp
public override bool OnOperationConfirm(TIGameState actorState, TIGameState target, TIResourcesCost resourcesCost, Trajectory trajectory)
```
