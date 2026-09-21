# RotationTrajectory

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/RotationTrajectory.cs`.*


## Class `RotationTrajectory`

```csharp
public sealed class RotationTrajectory : HoldTrajectory
```

### Fields

| Name | Type |
|---|---|
| `MIN_ANGLE_FOR_THRUSTER_ACTIVATION` | private const float |
| `_angularAcceleration` | private readonly float |
| `_maxAngularAcceleration` | private readonly float |
| `_idleTime` | private readonly float |
| `_accelerationTime` | private readonly float |
| `_rotationAxis` | private readonly Vector3 |
| `_targetRotation` | private readonly Quaternion |

### Methods

```csharp
public RotationTrajectory(IPreviousTrajectory start, IWaypoint end, float angularAcceleration, float maxAngularVelocity)
```

```csharp
public RotationTrajectory(IPreviousTrajectory start, IWaypoint end, float availableTime, float angularAcceleration, float maxAngularVelocity)
```

```csharp
public static float TimeRequiredForHeadingRotation(Quaternion currentRotation, Quaternion requiredRotation, float angularAcceleration, float maxAngularVelocity)
```

```csharp
public static float TimeRequiredForHeadingRotationLimitedByTime(Quaternion currentRotation, Quaternion requiredRotation, float angularAcceleration, float maxAngularVelocity, float availableTime)
```

```csharp
public static float TopAngularVelocityForHeadingRotationLimitedByTime(Quaternion currentRotation, Quaternion requiredRotation, float angularAcceleration, float maxAngularVelocity, float availableTime)
```

```csharp
private bool IsUsingRightThruster(TIDateTime time)
```

```csharp
private bool IsUsingLeftThruster(TIDateTime time)
```

```csharp
private bool IsUsingUpThruster(TIDateTime time)
```

```csharp
private bool IsUsingDownThruster(TIDateTime time)
```

```csharp
private bool IsUsingRollRightThruster(TIDateTime time)
```

```csharp
private bool IsUsingRollLeftThruster(TIDateTime time)
```

```csharp
public override bool IsAcceleratingRight(TIDateTime time)
```

```csharp
public override bool IsAcceleratingLeft(TIDateTime time)
```

```csharp
public override bool IsAcceleratingUp(TIDateTime time)
```

```csharp
public override bool IsAcceleratingDown(TIDateTime time)
```

```csharp
public override bool IsAcceleratingRollRight(TIDateTime time)
```

```csharp
public override bool IsAcceleratingRollLeft(TIDateTime time)
```

```csharp
protected override Quaternion RotationAt(float elapsedTime)
```

```csharp
protected override Vector3 HeadingAt(float elapsedTime)
```

```csharp
protected override float AngularVelocityAt(float elapsedTime)
```

```csharp
private float TotalAngularDisplacementInDegreesAtTime(float elapsedTime)
```

```csharp
public override List<ValueTuple<TIDateTime, bool>> GetBurnTimings()
```
