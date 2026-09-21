# Trajectory_Microthrust

*Decompiled from `PavonisInteractive/TerraInvicta/Trajectory_Microthrust.cs`.*


## Class `Trajectory_Microthrust`

```csharp
public class Trajectory_Microthrust : Trajectory_WithOrbitalElements
```

### Fields

| Name | Type |
|---|---|
| `GetTrajectoryModel` | public override TrajectoryModel |
| `initialOrbit_m` | public double |
| `destinationOrbit_m` | public double |
| `initialEcc` | public double |
| `destinationEcc` | public double |
| `initialNode_rad` | public double |
| `destinationNode_rad` | public double |
| `initialInclination_rad` | public double |
| `destinationInclination_rad` | public double |
| `initialArgP_rad` | public double |
| `destinationArgP_rad` | public double |
| `ascending` | public bool |
| `initialVelocity_mps` | public double |
| `initialMeanAnomaly_rad` | public double |
| `destinationMeanAnomaly_rad` | public double |
| `initialOrbitalPeriod_s` | public double |
| `velocity` | public Vector3d |
| `initialEpoch` | public TIDateTime |

### Methods

```csharp
public override string GetDisplayName()
```

```csharp
public override List<ValueTuple<TIDateTime, Trajectory.TrajectoryDomain>> GetTrajectoryDomainsOverTime()
```

```csharp
public override bool CantManeuver(TIDateTime time = null)
```

```csharp
public override void BuildSingleTrajectory(IMobileAsset fleet, TISpaceGameState destination, ITransferTarget originValue, ITransferTarget destinationValue, TINaturalSpaceObjectState commonBarycenter, TrajectorySolver solver, double fleetCruiseAcceleration_mps2)
```

```csharp
public override bool isInMicrothrust(TIDateTime time = null)
```

```csharp
public override bool isPlausible()
```

```csharp
public override CartesianState ToGlobalCartesianStateAtTime(TIDateTime timeToCheck)
```

```csharp
public override OrbitalElementsState GetOrbitalElementsAtTime(TIDateTime timeToCheck, TISpaceAssetState.MeanAnomalyPrecision precision)
```

```csharp
public override double getDistFromBarycenterAtTime_m(TIDateTime timeToCheck, out TINaturalSpaceObjectState barycenter)
```

```csharp
public override double RemainingDVatTime_mps(TIDateTime time)
```

```csharp
public override Vector3d PositionAtTime(TIDateTime timeToCheck, bool setPosition, out bool arrived)
```

```csharp
private double FourthPower(double x)
```

```csharp
public override Vector3d DesiredOrientationVector_Acceleration()
```

```csharp
public override Vector3d DesiredOrientationVector_Deceleration()
```

```csharp
public override string deepDump()
```
