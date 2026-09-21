# Trajectory_Impulse

*Decompiled from `PavonisInteractive/TerraInvicta/Trajectory_Impulse.cs`.*


## Class `Trajectory_Impulse`

```csharp
public class Trajectory_Impulse : Trajectory_WithOrbitalElements
```

### Fields

| Name | Type |
|---|---|
| `GetTrajectoryModel` | public override TrajectoryModel |
| `freeDVTransfer` | private bool |
| `boost` | private BurnBezierDescription |
| `decel` | private BurnBezierDescription |

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
private void GenerateBurnParameters(ImpulseTransfer impulseSolver)
```

```csharp
public override bool isPlausible()
```

```csharp
public override TINaturalSpaceObjectState GetBarycenterAtTime(TIDateTime time)
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
public override Vector3d PositionAtTime(TIDateTime timeToCheck, bool setPosition, out bool arrived)
```

```csharp
private CartesianState TransferOrbitCartesianStateAtTime(TIDateTime time)
```

```csharp
private void UpdateDVconsumed(double DVconsumed_mps)
```

```csharp
public override TIDateTime getOrbitEndTime()
```

```csharp
public override bool isInImpulse(TIDateTime time = null)
```

```csharp
public override string deepDump()
```
