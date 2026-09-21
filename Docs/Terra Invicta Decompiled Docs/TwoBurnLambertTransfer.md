# TwoBurnLambertTransfer

*Decompiled from `PavonisInteractive/TerraInvicta/TwoBurnLambertTransfer.cs`.*


## Class `TwoBurnLambertTransfer`

```csharp
public class TwoBurnLambertTransfer : ImpulseTransfer
```

### Fields

| Name | Type |
|---|---|
| `s0` | private CartesianState |
| `s1` | private CartesianState |

### Properties

- `public Vector3d deltaV0`
- `public Vector3d deltaV1`

### Methods

```csharp
public TransferResult Solve(TIDateTime launchTime, TIDateTime arrivalTime, double transitDuration_s, ITransferTarget iOrigin, ITransferTarget iDestination, TINaturalSpaceObjectState transferBarycenter, double fleetAcceleration_mps2)
```

```csharp
public TransferResult Solve(TIDateTime launchTime, TIDateTime arrivalTime, double transitDuration_s, ITransferTarget iOrigin, TIOrbitState iDestination, double destinationMeanAnomaly_Rad, TINaturalSpaceObjectState transferBarycenter, double fleetAcceleration_mps2)
```

```csharp
public TransferResult SolveCartesian(TIDateTime launchTime, TIDateTime arrivalTime, double transitDuration_s, CartesianState sourceLocalToDestination, CartesianState destinationLocalToDestination, TINaturalSpaceObjectState transferBarycenter, double fleetAcceleration_mps2)
```

```csharp
public TransferResult ModifyDV(double additionalBoostDV_mps, double additionalDecelDV_mps, double fleetAcceleration_mps2)
```
