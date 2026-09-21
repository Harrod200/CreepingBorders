# PatchedTransfer

*Decompiled from `PavonisInteractive/TerraInvicta/PatchedTransfer.cs`.*


## Class `PatchedTransfer`

```csharp
public class PatchedTransfer : TrajectorySolver
```

### Fields

| Name | Type |
|---|---|
| `launchTime` | public override TIDateTime |
| `set` | protected |
| `arrivalTime` | public override TIDateTime |
| `set` | protected |
| `transitDuration_s` | public override double |
| `set` | protected |
| `InternalTransferType` | public enum |

### Properties

- `public List<IPatchedTransferSegment> transferSegments`

### Methods

```csharp
public TransferResult Solve(TIDateTime launchTime, TIDateTime arrivalTime, ITransferTarget originValue, OrbitalElementsState destinationOrbitElements, TINaturalSpaceObjectState destinationBarycenter, TINaturalSpaceObjectState commonBarycenter, double fleetAcceleration_mps2, bool anyMeanAnomalyAtArrival, PatchedTransfer.InternalTransferType internalTransferType, TIDateTime earliestArrivalTimeForMicrothrustOnly = null)
```

```csharp
private TransferResult SolveSingleBarycenter(TIDateTime launchTime, TIDateTime targetArrivalTime, ITransferTarget originValue, OrbitalElementsState destinationOrbitElements, double fleetAcceleration_mps2, bool anyMeanAnomalyAtArrival, PatchedTransfer.InternalTransferType internalTransferType, TIDateTime earliestArrivalTimeForMicrothrustOnly = null)
```

```csharp
private TransferResult SolveMultiBarycenter(TIDateTime launchTime, TIDateTime arrivalTime, ITransferTarget originValue, OrbitalElementsState destinationOrbitElements, TINaturalSpaceObjectState destinationBarycenter, TINaturalSpaceObjectState commonBarycenter, double fleetAcceleration_mps2, bool anyMeanAnomalyAtArrival, PatchedTransfer.InternalTransferType internalTransferType)
```

```csharp
private double GravityTaxForTorch_mps(double coastSpeedAroundCommonBarycenter_mps, double distanceFromLocalBarycenter_m, TINaturalSpaceObjectState localBarycenter, TINaturalSpaceObjectState commonBarycenter, TIDateTime burnTime)
```

```csharp
private double GravityTaxForLambert_mps(double speedAroundCommonBarycenterAfterBurn_mps, double distanceFromLocalBarycenter_m, TINaturalSpaceObjectState localBarycenter, TINaturalSpaceObjectState commonBarycenter, TIDateTime burnTime)
```

```csharp
private double TotalGravityTaxForLambertSquared_m2ps2(double speedAroundCommonBarycenterAfterBurn_mps, double distanceFromLocalBarycenter_m, TINaturalSpaceObjectState localBarycenter, TINaturalSpaceObjectState commonBarycenter, TIDateTime burnTime)
```

```csharp
private TransferResult SolveMultiBarycenterMicrothrustOnly(TIDateTime launchTime, TIDateTime arrivalTime, ITransferTarget originValue, OrbitalElementsState destinationOrbitElements, TINaturalSpaceObjectState destinationBarycenter, TINaturalSpaceObjectState commonBarycenter, double fleetAcceleration_mps2, bool anyMeanAnomalyAtArrival)
```

```csharp
private ValueTuple<double, double, double> CalculateMicrothrustLERPcorrections(OrbitalElementsState microthrustOrbit, CartesianState actualCartesian, TIDateTime timeOfJunction, TINaturalSpaceObjectState barycenter)
```

```csharp
private static double Cubed(double a)
```

```csharp
public static void MoveCartesianStateOutOneBarycenter(ref CartesianState cartesianState, TINaturalSpaceObjectState currentBarycenter, TIDateTime time)
```

```csharp
private double AdditionalVelocityNeededForEscape_mps(ITransferTarget originValue, TINaturalSpaceObjectState relevantBarycenter, TIDateTime launchTime)
```

```csharp
private double AdditionalVelocityNeededForEscape_mps(OrbitalElementsState orbit, TINaturalSpaceObjectState orbitBarycenter, TINaturalSpaceObjectState relevantBarycenter, TIDateTime time)
```

```csharp
private double AdditionalVelocityNeededForEscape_mps(CartesianState relevantState, TINaturalSpaceObjectState relevantBarycenter, TIDateTime time)
```
