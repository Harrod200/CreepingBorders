# OrbitPhasingTransfer

*Decompiled from `PavonisInteractive/TerraInvicta/OrbitPhasingTransfer.cs`.*


## Class `OrbitPhasingTransfer`

```csharp
public class OrbitPhasingTransfer : ImpulseTransfer
```

### Fields

| Name | Type |
|---|---|
| `originMicrothrustDuration_s` | public double |
| `destinationMicrothrustDuration_s` | public double |
| `burn_duration_s` | public double |
| `originGravityTax_s` | public double |
| `destinationGravityTax_s` | public double |
| `isGoingForward` | public bool |

### Methods

```csharp
public TransferResult Solve(TIDateTime startTime, int numOrbits, bool goForward, ITransferTarget iOrigin, ITransferTarget iDestination, TISpaceFleetState destinationFleet, TINaturalSpaceObjectState commonBarycenter, OrbitalElementsState originOrbit, OrbitalElementsState destinationOrbit, OrbitalElementsState originInitialOrbit, TINaturalSpaceObjectState originInitialBarycenter, OrbitalElementsState destFinalOrbit, TINaturalSpaceObjectState destFinalBarycenter, double fleetAcceleration_mps2)
```

```csharp
private static bool TryToGenerateDestinationOrbitGivenPossibleFleet(TIDateTime startTime, int numOrbits, ITransferTarget iOrigin, ITransferTarget iDestination, TISpaceFleetState destinationFleet, TINaturalSpaceObjectState commonBarycenter, out bool isTargetingDestinationFleetTransferDestination, out OrbitalElementsState destinationOrbit)
```

```csharp
public static double CalculateLongitudeDelta_Rad(OrbitalElementsState start, OrbitalElementsState end, double barycenterMass_kg)
```

```csharp
public static double CalculateLongitude_Rad(OrbitalElementsState orbit, double barycenterMass_kg)
```

```csharp
public static int CalculateMinOrbitsGivenAcceleration(OrbitalElementsState start, OrbitalElementsState end, TINaturalSpaceObjectState barycenter, double fleetAcceleration_mps2, bool isForward)
```

```csharp
public static int CalculateMinOrbitsGivenAcceleration(double orbitPeriod_s, double orbitRadius_m, double orbitSpeed_mps, double angleToTravel_Rad, double mu, double fleetAcceleration_mps, bool isForward)
```

```csharp
private ValueTuple<double, double> GetMicrothrustDurationAndGravityCost_s(TINaturalSpaceObjectState targetBarycenter, OrbitalElementsState targetOrbit, TINaturalSpaceObjectState phasingBarycenter, double fleetAcceleration_mps2)
```
