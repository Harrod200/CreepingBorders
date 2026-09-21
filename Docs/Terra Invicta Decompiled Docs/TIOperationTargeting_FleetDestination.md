# TIOperationTargeting_FleetDestination

*Decompiled from `TIOperationTargeting_FleetDestination.cs`.*


## Class `TIOperationTargeting_FleetDestination`

```csharp
public class TIOperationTargeting_FleetDestination : TIOperationTargeting
```

### Fields

| Name | Type |
|---|---|
| `fleet` | private TISpaceFleetState |
| `faction` | private TIFactionState |

### Methods

```csharp
public override List<Type> TargetedGameStates()
```

```csharp
public override OperationTargetingUIType UIType()
```

```csharp
public override void Init(IOperation operationType, TIGameState actorState, TIGameState defaultTarget = null)
```

```csharp
public override void Activate(TIGameState forceTarget = null)
```

```csharp
public override void Shutdown()
```

```csharp
private void FleetSelectedForDestinationTargeting(FleetSelectedEvent e)
```

```csharp
private void HabSelectedForDestinationTargeting(HabSelectedEvent e)
```

```csharp
private void SpaceBodySelectedForDestinationTargeting(SpaceBodySelectedEvent e)
```

```csharp
private void LagrangePointSelectedForDestinationTargeting(LagrangePointSelectedEvent e)
```

```csharp
private void OrbitSelectedForTargeting(OrbitSelectedEvent e)
```

```csharp
public override TIGameState GetDefaultTarget()
```
