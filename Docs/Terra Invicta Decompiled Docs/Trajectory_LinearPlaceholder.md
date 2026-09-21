# Trajectory_LinearPlaceholder

*Decompiled from `PavonisInteractive/TerraInvicta/Trajectory_LinearPlaceholder.cs`.*


## Class `Trajectory_LinearPlaceholder`

```csharp
public class Trajectory_LinearPlaceholder : Trajectory
```

### Fields

| Name | Type |
|---|---|
| `GetTrajectoryModel` | public override TrajectoryModel |

### Methods

```csharp
public override string GetDisplayName()
```

```csharp
public override List<ValueTuple<TIDateTime, Trajectory.TrajectoryDomain>> GetTrajectoryDomainsOverTime()
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
public override Vector3d PositionAtTime(TIDateTime timeToCheck, bool setPosition, out bool arrived)
```

```csharp
public override string deepDump()
```
