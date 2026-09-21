# AdjustableWaypoint

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/AdjustableWaypoint.cs`.*


## Class `AdjustableWaypoint`

```csharp
public class AdjustableWaypoint : BasicWaypoint, IPreviousWaypoint, IWaypoint, INextWaypoint, IPathDetail, IMovableWaypoint
```

### Fields

| Name | Type |
|---|---|
| `OnPositionRotationChange` | public event Action |
| `_intendedAcceleration` | private float |
| `IsCoastOnly` | public bool |
| `ValidTrajectorySequence` | public ITrajectory |
| `PreviousWaypoint` | public IPreviousWaypoint |
| `UID` | public int |
| `IsRecursivelyLocked` | public bool |
| `_UIDGenerator` | private static int |
| `_uid` | private int |
| `_constraints` | private AccelerationConstraints |
| `_changeProposal` | private ProposedWaypoint |
| `_proposedTrajectorySequence` | private WaypointTrajectorySequence |
| `_activeTrajectorySequence` | private WaypointTrajectorySequence |
| `_previousWaypoint` | private IPreviousWaypoint |
| `_nextWaypoint` | private INextWaypoint |
| `_isProposalSource` | private bool |
| `IPathDetail` | private class EndlessTrajectory : HoldTrajectory, INextWaypoint, |
| `IsRecursivelyLocked` | public bool |
| `ValidTrajectorySequence` | public ITrajectory |

### Properties

- `public bool IsInputLocked`
- `public bool IsCoreWaypoint`
- `public bool RenderTrajectoryLines`
- `public bool PadlockEnabled`
- `public bool AllStopEnabled`
- `public bool MatchVelocityEnabled`
- `public bool DefensiveManueversEnabled`
- `public bool CollisionWarningNeeded`

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
public Vector3 HeadingAt(TIDateTime time)
```

```csharp
public Quaternion RotationAt(TIDateTime time)
```

```csharp
public float AngularVelocityAt_Rad(TIDateTime time)
```

```csharp
public HoldTrajectory TrajectoryAt(TIDateTime time)
```

```csharp
public List<ValueTuple<TIDateTime, bool>> GetBurnTimings()
```

```csharp
public void UpdatePathRender(TIDateTime timingStart, Camera cam, Vector3 shipPosition)
```

```csharp
public void UpdateAccelerationConstraints(AccelerationConstraints constraints)
```

```csharp
public float LinearAcceleration()
```

```csharp
public AdjustableWaypoint(AccelerationConstraints constraints)
```

```csharp
public AdjustableWaypoint(IPreviousWaypoint previousWaypoint, AccelerationConstraints constraints, float alphaValue)
```

```csharp
public void SetPreviousWaypoint(IPreviousWaypoint previousWaypoint)
```

```csharp
public void EstablishDesiredPreviousPoint(IPreviousWaypoint previousWaypoint)
```

```csharp
public void ResetCurrentWaypointSequence()
```

```csharp
public void ResetNextWaypointSequence()
```

```csharp
public void ResetLocksRecursive()
```

```csharp
public void RecalculateTrajectoryPathRecursive()
```

```csharp
public void ResumePreviousTargetPosition(Vector3 targetDisplacement)
```

```csharp
public void CacheWaypointOrientation()
```

```csharp
public void CacheWaypointOrientationRecursively()
```

```csharp
public bool ProposeTrajectory(WaypointTrajectorySequence sequence)
```

```csharp
public void AdjustPlacement(ProposedWaypoint start, ProposedWaypoint end, Vector3 targetDisplacement)
```

```csharp
public void AllignToTrajectoryPathRecursively(WaypointTrajectorySequence sequence, TIDateTime endTime, Vector3 targetDisplacement)
```

```csharp
public void HoldRecursively()
```

```csharp
public bool ProposeWaypoint(ProposedWaypoint proposedWaypoint, AccelerationConstraints overrideConstraints = null)
```

```csharp
public bool ProposePlacement(Vector3 position, AccelerationConstraints overrideConstraints = null, bool preserveRoll = false, float forceAcceleration = -1f)
```

```csharp
public bool ProposePlacement(Vector3 position, TIDateTime timing, AccelerationConstraints overrideConstraints = null, bool preserveRoll = false, float forceAcceleration = -1f)
```

```csharp
public bool ProposeHeading(Vector3 heading)
```

```csharp
public bool ProposeRotation(Quaternion rotation, AccelerationConstraints overrideConstraints = null)
```

```csharp
public bool AdjustRotation(Quaternion rotation, AccelerationConstraints overrideConstraints = null)
```

```csharp
public bool IsRecursiveStartChangeViable(IWaypoint startProposal)
```

```csharp
private bool RecursiveRotationHandler(ProposedWaypoint startProposal, INextWaypoint nextWaypoint)
```

```csharp
private bool IsChangeProposalValidForNextWaypoints()
```

```csharp
private bool IsChangeProposalValidForNextWaypoints(Func<ProposedWaypoint, INextWaypoint, bool> evaluator)
```

```csharp
private void GenerateConstrainedTrajectoryProposal(IWaypoint start, AccelerationConstraints overrideConstraints = null, bool preserveRoll = false, float forceAcceleration = -1f)
```

```csharp
private void GenerateHoldTrajectoryProposal(IWaypoint start)
```

```csharp
private void AdoptProposedChanges()
```

```csharp
public void SetNextWaypoint(INextWaypoint nextWaypoint)
```

```csharp
public void InsertBefore(AdjustableWaypoint waypoint)
```

```csharp
public bool RequestRemoval()
```

```csharp
private void RemoveWaypoint()
```

```csharp
public override Vector3 PositionAt(TIDateTime time)
```

```csharp
public override Vector3 VelocityAt(TIDateTime time)
```

```csharp
public override float AngularVelocityAt_Rad(TIDateTime time)
```

```csharp
public override Vector3 HeadingAt(TIDateTime time)
```

```csharp
public override Quaternion RotationAt(TIDateTime time)
```

```csharp
public void SetPreviousWaypoint(IPreviousWaypoint previousWaypoint)
```

```csharp
public void RecalculateTrajectoryPathRecursive()
```

```csharp
public void ResumePreviousTargetPosition(Vector3 targetDisplacement)
```

```csharp
public void CacheWaypointOrientationRecursively()
```

```csharp
public void AllignToTrajectoryPathRecursively(WaypointTrajectorySequence sequence, TIDateTime endTime, Vector3 targetDisplacement)
```

```csharp
public void HoldRecursively()
```

```csharp
public void UpdatePathRender(TIDateTime timingStart, Camera cam, Vector3 shipPosition)
```

```csharp
public EndlessTrajectory(IWaypoint previousWaypoint)
```

```csharp
public bool IsRecursiveStartChangeViable(IWaypoint changeProposal)
```

```csharp
public void ResetLocksRecursive()
```
