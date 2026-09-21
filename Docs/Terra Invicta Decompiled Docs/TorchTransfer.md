# TorchTransfer

*Decompiled from `PavonisInteractive/TerraInvicta/TorchTransfer.cs`.*


## Class `TorchTransfer`

```csharp
public class TorchTransfer : TrajectorySolver
```

### Fields

| Name | Type |
|---|---|
| `coastDuration_s` | public double |
| `coastVelocity_mps` | public Vector3d |

### Properties

- `public double accelDuration_s`
- `public double decelDuration_s`
- `public Vector3d accelerationVector_mps2`
- `public Vector3d decelerationVector_mps2`
- `public Vector3d initialVelocityVector_mps`
- `public Vector3d arrivalVelocityVector_mps`
- `public CartesianState initialState`
- `public CartesianState finalState`
- `public TINaturalSpaceObjectState barycenter`

### Methods

```csharp
public double MinDistanceToTrajectory_m(Vector3d v, Vector3d s, Vector3d p)
```

```csharp
public TransferResult Solve(TIDateTime startTime, double transitDuration_s, double fleetInitialAcceleration_mps2, ITransferTarget iOrigin, ITransferTarget iDestination, TINaturalSpaceObjectState transferBarycenter, double fleetDV_mps, out bool possible)
```

```csharp
public TransferResult Solve(TIDateTime startTime, double transitDuration_s, double fleetInitialAcceleration_mps2, CartesianState originGlobalState, CartesianState destinationGlobalState, TINaturalSpaceObjectState transferBarycenter, double fleetDV_mps, out bool possible, bool allowImpossibleTrajectories = false)
```
