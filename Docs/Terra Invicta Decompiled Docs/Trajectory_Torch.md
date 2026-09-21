# Trajectory_Torch

*Decompiled from `PavonisInteractive/TerraInvicta/Trajectory_Torch.cs`.*


## Class `Trajectory_Torch`

```csharp
public class Trajectory_Torch : Trajectory
```

### Fields

| Name | Type |
|---|---|
| `accelerationVector_normal` | public Vector3d |
| `decelerationVector_normal` | public Vector3d |
| `boostDV_mps` | public override double |
| `set` | protected |
| `decelDV_mps` | public override double |
| `set` | protected |
| `GetTrajectoryModel` | public override TrajectoryModel |
| `initialVelocityVector_mps` | public Vector3d |
| `arrivalVelocityVector_mps` | public Vector3d |
| `coastVelocityVector_mps` | public Vector3d |
| `accelerationVector_mps2` | public Vector3d |
| `decelerationVector_mps2` | public Vector3d |

### Methods

```csharp
public override List<ValueTuple<TIDateTime, Trajectory.TrajectoryDomain>> GetTrajectoryDomainsOverTime()
```

```csharp
public override bool CantManeuver(TIDateTime time = null)
```

```csharp
public override string GetDisplayName()
```

```csharp
public override void BuildSingleTrajectory(IMobileAsset fleet, TISpaceGameState destination, ITransferTarget originValue, ITransferTarget destinationValue, TINaturalSpaceObjectState commonBarycenter, TrajectorySolver solver, double fleetCruiseAcceleration_mps2)
```

```csharp
public override bool isPlausible()
```

```csharp
public override CartesianState ToGlobalCartesianStateAtTime(TIDateTime timeToCheck)
```

```csharp
public override OrbitalElementsState GetOrbitalElementsAtTime(TIDateTime time, TISpaceAssetState.MeanAnomalyPrecision precision)
```

```csharp
public override double getDistFromBarycenterAtTime_m(TIDateTime timeToCheck, out TINaturalSpaceObjectState barycenter)
```

```csharp
public override Vector3d PositionAtTime(TIDateTime timeToCheck, bool setPosition, out bool arrived)
```

```csharp
public override string deepDump()
```
