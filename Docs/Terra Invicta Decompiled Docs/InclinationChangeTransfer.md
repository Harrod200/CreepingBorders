# InclinationChangeTransfer

*Decompiled from `PavonisInteractive/TerraInvicta/InclinationChangeTransfer.cs`.*


## Class `InclinationChangeTransfer`

```csharp
public class InclinationChangeTransfer : TrajectorySolver
```

### Fields

| Name | Type |
|---|---|
| `intermediateBurnTime` | public TIDateTime |
| `intermediate_burn_DV` | public double |
| `outgoingOrbit` | public OrbitalElementsState |
| `incomingOrbit` | public OrbitalElementsState |

### Methods

```csharp
public TransferResult Solve(TIDateTime startTime, double durationInDestinationOrbits, ITransferTarget iOrigin, ITransferTarget iDestination, TINaturalSpaceObjectState commonBarycenter, double fleetAcceleration_mps2, bool anyMeanAnomalyAtArrival, double? startMeanAnomalyChangePerSecond_radPerSec = null, double? endMeanAnomalyChangePerSecond_radPerSec = null, bool iterating = false)
```

```csharp
public TransferResult Solve(TIDateTime startTime, double durationInDestinationOrbits, OrbitalElementsState origin, OrbitalElementsState destination, TINaturalSpaceObjectState commonBarycenter, double fleetAcceleration_mps2, bool anyMeanAnomalyAtArrival, double? startMeanAnomalyChangePerSecond_radPerSec = null, double? endMeanAnomalyChangePerSecond_radPerSec = null, bool iterating = false)
```

```csharp
private double eccentricity(double apoapsis, double periapsis)
```
