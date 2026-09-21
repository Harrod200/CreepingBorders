# HoldTrajectory

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/HoldTrajectory.cs`.*


## Class `HoldTrajectory`

```csharp
public class HoldTrajectory : BasicWaypoint, IPreviousTrajectory, ITrajectory, IPathDetail, IWaypoint
```

### Fields

| Name | Type |
|---|---|
| `_renderNodesCount` | private int |
| `_totalDuration_s` | protected float |
| `_pathRenderNodes` | protected List<Vector3> |
| `_pathLineColor` | protected Color32 |
| `_alphaRange` | protected Vector2 |
| `_previousWaypoint` | protected readonly IWaypoint |
| `_nextTrajectory` | protected ITrajectory |
| `_mainCamera` | protected Camera |

### Methods

```csharp
protected HoldTrajectory(IWaypoint previousWaypoint)
```

```csharp
protected HoldTrajectory(IPreviousTrajectory previousWaypoint)
```

```csharp
public HoldTrajectory(IPreviousTrajectory start, IWaypoint end)
```

```csharp
protected void InitializePathList()
```

```csharp
public void UpdatePathNodes(TIDateTime currentTime, Camera cam, Vector3 shipPosition)
```

```csharp
protected float ElapsedTimeInSeconds(TIDateTime time)
```

```csharp
public bool InCounterBurn(TIDateTime time)
```

```csharp
public virtual bool IsInBurn(TIDateTime time)
```

```csharp
public virtual bool IsAcceleratingRight(TIDateTime time)
```

```csharp
public virtual bool IsAcceleratingLeft(TIDateTime time)
```

```csharp
public virtual bool IsAcceleratingUp(TIDateTime time)
```

```csharp
public virtual bool IsAcceleratingDown(TIDateTime time)
```

```csharp
public virtual bool IsAcceleratingRollRight(TIDateTime time)
```

```csharp
public virtual bool IsAcceleratingRollLeft(TIDateTime time)
```

```csharp
public virtual Vector3 PositionAt(TIDateTime time)
```

```csharp
public virtual Vector3 VelocityAt(TIDateTime time)
```

```csharp
public virtual Vector3 AccelerationAt(TIDateTime time)
```

```csharp
public virtual float AngularVelocityAt_Rad(TIDateTime time)
```

```csharp
public virtual Vector3 HeadingAt(TIDateTime time)
```

```csharp
public virtual Quaternion RotationAt(TIDateTime time)
```

```csharp
public virtual ITrajectory TrajectoryAt(TIDateTime time)
```

```csharp
protected virtual Vector3 PositionAt(float elapsedTime)
```

```csharp
protected virtual Vector3 VelocityAt(float elapsedTime)
```

```csharp
protected virtual Vector3 AccelerationAt(float elapsedTime)
```

```csharp
protected virtual float AngularVelocityAt(float elapsedTime)
```

```csharp
protected virtual Vector3 HeadingAt(float heading)
```

```csharp
protected virtual Quaternion RotationAt(float elapsedTime)
```

```csharp
public void SetNextTrajectory(ITrajectory nextTrajectory)
```

```csharp
public virtual List<ValueTuple<TIDateTime, bool>> GetBurnTimings()
```
