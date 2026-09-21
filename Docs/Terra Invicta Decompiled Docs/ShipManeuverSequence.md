# ShipManeuverSequence

*Decompiled from `PavonisInteractive/TerraInvicta/ShipManeuverSequence.cs`.*


## Class `ShipManeuverSequence`

```csharp
public class ShipManeuverSequence
```

### Fields

| Name | Type |
|---|---|
| `_constraints` | private AccelerationConstraints |
| `_preBurnDrift` | private DriftTrajectory |
| `_preBurnRotation` | private RotationTrajectory |
| `_burn` | private BurnTrajectory |
| `_midBurnRotation` | private RotationTrajectory |
| `_postBurnHold` | private HoldTrajectory |
| `_counterBurn` | private BurnTrajectory |
| `_postBurnRotation` | private RotationTrajectory |
| `_postBurnDrift` | private DriftTrajectory |

### Properties

- `public bool ValidSequence`
- `public IPreviousTrajectory Start`
- `public IPreviousTrajectory End`

### Methods

```csharp
private ShipManeuverSequence()
```

```csharp
public ShipManeuverSequence(float linearAcceleration, float cruiseAcceleration, float angularAcceleration, float maxAngualarAcceleration)
```

```csharp
public void CreateManeuverSequence(IProposedWaypoint start, Vector3 driftTarget, Vector3 burnTarget, IProposedWaypoint end)
```

```csharp
private IPreviousTrajectory HandlePreBurnDriftManeuver(IPreviousTrajectory start, IProposedWaypoint target, float availableTime, float linearAcceleration)
```

```csharp
private IPreviousTrajectory HandlePostBurnDriftManeuver(IPreviousTrajectory start, IProposedWaypoint target, float linearAcceleration)
```

```csharp
private IPreviousTrajectory HandlePreBurnRotationManeuver(IPreviousTrajectory start, IProposedWaypoint target, float availableTime, float angularAcceleration, float maxAngularVelocity)
```

```csharp
private IPreviousTrajectory HandleMidBurnRotationManeuver(IPreviousTrajectory start, IProposedWaypoint target, float availableTime, float angularAcceleration, float maxAngularVelocity)
```

```csharp
private IPreviousTrajectory HandlePostBurnRotationManeuver(IPreviousTrajectory start, IProposedWaypoint target, float availableTime, float angularAcceleration, float maxAngularVelocity)
```

```csharp
private IPreviousTrajectory HandleBurn(IPreviousTrajectory current, IProposedWaypoint target, float desiredDisplacement, float linearAcceleration)
```

```csharp
private IPreviousTrajectory HandleCounterBurn(IPreviousTrajectory current, IProposedWaypoint target, float desiredDisplacement, float linearAcceleration)
```

```csharp
private IPreviousTrajectory HandlePostBurnHold(IPreviousTrajectory current, IProposedWaypoint target)
```

```csharp
private static float TimeRequiredForDrift(Vector3 desiredDisplacementVector, float linearAcceleration)
```

```csharp
private static float TimeRequiredForHeadingRotation(Quaternion currentRotation, Quaternion requiredRotation, float angularAcceleration, float maxAngularVelocity)
```

```csharp
public ITrajectory TrajectoryAt(TIDateTime time)
```

```csharp
public void PositionAt(TIDateTime time, out Vector3 position)
```

```csharp
public void RotationAt(TIDateTime time, out Quaternion rotation)
```

```csharp
public void PositionAndRotationAt(TIDateTime time, out Vector3 position, out Quaternion rotation)
```

```csharp
public bool IsInBurn(TIDateTime time)
```

```csharp
public bool IsAcceleratingRight(TIDateTime time)
```

```csharp
public bool IsAcceleratingLeft(TIDateTime time)
```

```csharp
public bool IsAcceleratingUp(TIDateTime time)
```

```csharp
public bool IsAcceleratingDown(TIDateTime time)
```
