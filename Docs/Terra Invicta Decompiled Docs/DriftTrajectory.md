# DriftTrajectory

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/DriftTrajectory.cs`.*


## Class `DriftTrajectory`

```csharp
public sealed class DriftTrajectory : HoldTrajectory
```

### Fields

| Name | Type |
|---|---|
| `_desiredDisplacementVector` | private readonly Vector3 |
| `_linearAcceleration` | private readonly float |
| `_timeToComplete` | private float |
| `_includeCounterBurn` | private bool |

### Methods

```csharp
public DriftTrajectory(IPreviousTrajectory start, IProposedWaypoint end, float linearAcceleration, bool includeCounterBurn = false)
```

```csharp
public DriftTrajectory(IPreviousTrajectory start, IProposedWaypoint end, float availableTime, float linearAcceleration, bool includeCounterBurn = false)
```

```csharp
private void InitializeDriftTrajectory(IPreviousTrajectory start, IProposedWaypoint end, float availableTime, bool includeCounterBurn)
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
private bool IsAcceleratingInRelativeDirection(TIDateTime time, Vector3 direction)
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
public static float TimeRequiredForDisplacement(Vector3 desiredDisplacementVector, float linearAcceleration, bool includeCounterBurn = false)
```

```csharp
protected override Vector3 PositionAt(float elapsedTime)
```

```csharp
protected override Vector3 VelocityAt(float elapsedTime)
```

```csharp
protected override Vector3 AccelerationAt(float elapsedTime)
```

```csharp
public override List<ValueTuple<TIDateTime, bool>> GetBurnTimings()
```
