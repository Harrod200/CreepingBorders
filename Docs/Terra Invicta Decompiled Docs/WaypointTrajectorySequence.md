# WaypointTrajectorySequence

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/WaypointTrajectorySequence.cs`.*


## Class `WaypointTrajectorySequence`

```csharp
public class WaypointTrajectorySequence : ITrajectory, IPathDetail
```

### Fields

| Name | Type |
|---|---|
| `InvalidTrajectorySequence` | public static WaypointTrajectorySequence |
| `intendedLinearAcceleration` | public float |
| `linearAcceleration` | private float |
| `IsCoasting` | public bool |
| `TARGET_FADE_DURATION_SECONDS` | private const float |
| `s_InvalidTrajectorySequence` | private static WaypointTrajectorySequence |
| `_constraints` | private AccelerationConstraints |
| `_intendedLinearAcceleration` | private float |
| `_drift` | private DriftTrajectory |
| `_preBurn` | private RotationTrajectory |
| `_burn` | private BurnTrajectory |
| `_postBurn` | private RotationTrajectory |
| `_hold` | private HoldTrajectory |

### Properties

- `public bool IsTrajectoryValid`
- `private IPreviousTrajectory Start`
- `public IPreviousTrajectory End`

### Methods

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

```csharp
public bool IsAcceleratingRollRight(TIDateTime time)
```

```csharp
public bool IsAcceleratingRollLeft(TIDateTime time)
```

```csharp
public Vector3 PositionAt(TIDateTime time)
```

```csharp
public Vector3 VelocityAt(TIDateTime time)
```

```csharp
public Vector3 AccelerationAt(TIDateTime time)
```

```csharp
public float AngularVelocityAt_Rad(TIDateTime time)
```

```csharp
public Vector3 HeadingAt(TIDateTime time)
```

```csharp
public Quaternion RotationAt(TIDateTime time)
```

```csharp
public ITrajectory TrajectoryAt(TIDateTime time)
```

```csharp
public List<ValueTuple<TIDateTime, bool>> GetBurnTimings()
```

```csharp
public void UpdatePathNodes(TIDateTime timingCutoff, Camera cam, Vector3 shipPosition)
```

```csharp
private WaypointTrajectorySequence()
```

```csharp
private WaypointTrajectorySequence(IWaypoint start, IProposedWaypoint target, float desiredDisplacement, AccelerationConstraints constraints, float intendedAcceleration)
```

```csharp
private WaypointTrajectorySequence(IWaypoint start, IProposedWaypoint target, AccelerationConstraints constraints, float availableTime)
```

```csharp
private WaypointTrajectorySequence(IWaypoint start, float timingInterval, float targetAlphaBlendValue)
```

```csharp
public static WaypointTrajectorySequence CreateHoldTrajectory(IWaypoint start, float timingInterval, float targetAlpha)
```

```csharp
public static WaypointTrajectorySequence CreateConstrainedTrajectory(IWaypoint start, IProposedWaypoint target, AccelerationConstraints constraints, bool preserveRoll = false, bool useMaxThrust = false, float timeRequestedForPostBurn = 0f, float forceAcceleration = -1f)
```

```csharp
private static float TimeRequiredForDrift(Vector3 desiredDisplacementVector, float linearAcceleration)
```

```csharp
public static float TimeRequiredForHeadingRotation(Quaternion currentRotation, Quaternion requiredRotation, float angularAcceleration, float maxAngularVelocity)
```

```csharp
private static bool IsManeuveringPossible(AccelerationConstraints constraints)
```

```csharp
private static bool IsTargetReachable(float requiredDisplacement, float possibleDisplacement)
```

```csharp
private IPreviousTrajectory HandlePreBurnDrift(IPreviousTrajectory start, IProposedWaypoint target, float linearAcceleration)
```

```csharp
private IPreviousTrajectory HandlePreBurnDrift(IPreviousTrajectory start, IProposedWaypoint target, float availableTime, float linearAcceleration)
```

```csharp
private IPreviousTrajectory HandlePreBurnRotation(IPreviousTrajectory start, IProposedWaypoint target, float availableTime, float angularAcceleration, float maxAngularVelocity)
```

```csharp
private IPreviousTrajectory HandlePreBurnRotation(IPreviousTrajectory current, IProposedWaypoint target)
```

```csharp
private bool IsRotationRequired(Quaternion currentRotation, Quaternion targetRotation)
```

```csharp
private IPreviousTrajectory HandleBurn(IPreviousTrajectory current, IProposedWaypoint target, float desiredDisplacement)
```

```csharp
private IPreviousTrajectory HandleHold(IPreviousTrajectory current, float timingInterval, float targetAlphaBlendValue)
```

```csharp
private IPreviousTrajectory HandleHold(IPreviousTrajectory current, IProposedWaypoint target)
```

```csharp
public void AdjustEndHeading(IProposedWaypoint target, AccelerationConstraints constraints, bool useMaxThrust = false)
```
