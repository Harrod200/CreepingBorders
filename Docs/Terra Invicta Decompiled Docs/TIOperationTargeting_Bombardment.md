# TIOperationTargeting_Bombardment

*Decompiled from `TIOperationTargeting_Bombardment.cs`.*


## Class `TIOperationTargeting_Bombardment`

```csharp
public class TIOperationTargeting_Bombardment : TIOperationTargeting
```

### Fields

| Name | Type |
|---|---|
| `forceMap` | public override bool |
| `spaceBody` | private TISpaceBodyState |
| `faction` | private TIFactionState |
| `fleet` | private TISpaceFleetState |

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
public override TIGameState GetDefaultTarget()
```

```csharp
private void HabSelectedForTargeting(HabSelectedEvent e)
```

```csharp
private void FleetSelectedForTargeting(FleetTargetSelectedEvent e)
```

```csharp
private void ArmySelectedForTargeting(ArmyMapItemSelected e)
```

```csharp
private void AlienAssetSelectedForTargeting(AlienAssetTargetSelected e)
```

```csharp
private void RegionSelectedForTargeting(RegionStateSelected e)
```

```csharp
private void SpaceFacilitySelectedForTargeting(SpaceFacilityMapObjectSelected e)
```
