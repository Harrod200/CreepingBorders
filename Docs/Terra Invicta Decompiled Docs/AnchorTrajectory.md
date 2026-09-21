# AnchorTrajectory

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/AnchorTrajectory.cs`.*


## Class `AnchorTrajectory`

```csharp
public class AnchorTrajectory : BasicWaypoint, IPreviousTrajectory, ITrajectory, IPathDetail, IWaypoint
```

### Fields

| Name | Type |
|---|---|
| `_nextTrajectory` | private ITrajectory |

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
public AnchorTrajectory(IWaypoint waypoint)
```

```csharp
public void UpdatePathNodes(TIDateTime timingStart, Camera cam, Vector3 shipPosition)
```

```csharp
public void SetNextTrajectory(ITrajectory nextTrajectory)
```

```csharp
public List<ValueTuple<TIDateTime, bool>> GetBurnTimings()
```
