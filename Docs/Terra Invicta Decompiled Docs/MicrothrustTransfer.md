# MicrothrustTransfer

*Decompiled from `PavonisInteractive/TerraInvicta/MicrothrustTransfer.cs`.*


## Class `MicrothrustTransfer`

```csharp
internal class MicrothrustTransfer : TrajectorySolver
```

### Fields

| Name | Type |
|---|---|
| `arrivalTime` | public override TIDateTime |

### Properties

- `public double initialOrbit_m`
- `public double destinationOrbit_m`
- `public double initialInclination_rad`
- `public double destinationInclination_rad`
- `public bool ascending`
- `public double initialVelocity_mps`
- `public double boostDuration_s`
- `public double decelDuration_s`
- `public TINaturalSpaceObjectState commonBarycenter`

### Methods

```csharp
public void Solve(TIDateTime launchTime, ITransferTarget originValue, OrbitalElementsState destinationOrbit, TINaturalSpaceObjectState commonBarycenter, double fleetAcceleration_mps2)
```

```csharp
public void Solve(TIDateTime launchTime, ITransferTarget originValue, ITransferTarget destinationValue, TINaturalSpaceObjectState commonBarycenter, double fleetAcceleration_mps2, TIDateTime earliestArrivalTime)
```

```csharp
public void Solve(TIDateTime launchTime, ITransferTarget originValue, OrbitalElementsState destinationOrbit, double? destinationMeanAnomalyAtEarliestArrivalTime_rad, TINaturalSpaceObjectState commonBarycenter, double fleetAcceleration_mps2, TIDateTime earliestArrivalTime)
```
