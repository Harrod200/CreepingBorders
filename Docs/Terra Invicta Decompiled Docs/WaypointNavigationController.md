# WaypointNavigationController

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/WaypointNavigationController.cs`.*


## Class `WaypointNavigationController`

```csharp
public class WaypointNavigationController
```

### Fields

| Name | Type |
|---|---|
| `CanWaypointsBeAdjusted` | public bool |
| `WaypointContainer` | public GameObject |
| `PadlockEnabled` | public bool |
| `AllStopEnabled` | public bool |
| `MatchVelocityEnabled` | public bool |
| `DefensiveManueversEnabled` | public bool |
| `PrimaryTarget` | public CombatantController |
| `ManeuverTarget` | public CombatantController |
| `EnrouteIntentionalCollision` | public bool |
| `WaypointTimeDelta` | private float |
| `TimeOfFirstWaypoint` | public TIDateTime |
| `maxClosestApproachDistance` | private float |
| `WAYPOINT_CONTAINER_NAME_SUFFIX` | private const string |
| `PATH` | private const string |
| `MIN_TIME_IN_SECONDS_BETWEEN_WAYPOINTS` | private const float |
| `MAX_INTERIM_WAYPOINTS_BETWEEN_CORE_WAYPOINTS` | private const int |
| `waypointGreenLine` | public static Color32 |
| `eventInstance` | private EventInstance |
| `_name` | private string |
| `_waypointCount` | private int |
| `_waypointSharedData` | private WaypointSharedData |
| `_shipState` | private TISpaceShipState |
| `_spaceCombatCameraController` | private SpaceCombatCameraController |
| `_gameTime` | private GameTimeManager |
| `_canWaypointsBeAdjusted` | private bool |
| `_isOutOfCombatDV` | private bool |
| `_accelerationEffectiveness` | private WaypointNavigationController.AccelerationEffectiveness |
| `_accelerationEffectivenessRatio` | private float |
| `_collisionBoxSize` | private Vector3 |
| `_agentShipControllers` | private List<CombatShipController> |
| `_habModuleControllers` | private Dictionary<HabModuleController, Collider> |
| `_targetTrajectoryPath` | private LinkedList<WaypointTrajectorySequence> |
| `_recalculateAvoidancePath` | private bool |
| `_allStopCalculatedThisCycle` | private bool |
| `_matchVelocityCalculatedThisCycle` | private bool |
| `_defensiveManueversCalculatedThisCycle` | private bool |
| `cached_acceleration` | private float |
| `cached_cruise_acceleration` | private float |
| `cached_angular_acceleration_rads2` | private float |
| `cached_max_angular_velocity_rads2` | private float |
| `_propulsionValuesDirty` | private bool |
| `_propulsionValuesImproved` | private bool |
| `_waypointContainer` | private GameObjectDictionary<string> |
| `_padlockEnabled` | private bool |
| `_allStopEnabled` | private bool |
| `_matchVelocityEnabled` | private bool |
| `_defensiveManueversEnabled` | private bool |
| `_thisCombatant` | private CombatantController |
| `_primaryTarget` | private CombatantController |
| `_maneuverTarget` | private CombatantController |
| `_waypoints` | private AdjustableWaypoint[] |
| `_waypointControllers` | private Dictionary<AdjustableWaypoint, WaypointController> |
| `_activeInputHandlingController` | private static WaypointController |
| `_appendWaypointRotation` | private Quaternion |
| `_initialWaypoint` | private WaypointNavigationController.InitialWaypoint |
| `_mainCamera` | private Camera |
| `_activeSegmentTimingForPlacement` | private TIDateTime |
| `_waypointPlacementVisual` | private static WaypointVisual |
| `_pendingSegment` | private SegmentProximityData |
| `_pendingSegmentWaypointIndex` | private int |
| `_activeSegment` | private SegmentProximityData |
| `_activeSegmentWaypointIndex` | private int |
| `TimeOfNextCollisionCheck` | private TIDateTime |
| `_maxClosestApproachDistance` | private float |
| `_isActiveSegmentWaypointPlacementViable` | private bool |
| `MAX_STEP_COUNT` | private const int |
| `STEP_TIME_LENGTH` | private readonly float |
| `AccelerationEffectiveness` | private enum |
| `IWaypoint` | private class InitialWaypoint : BasicWaypoint, IPreviousWaypoint, |

### Properties

- `private AccelerationConstraints _accelerationConstraints`
- `public bool _allowPathDrawing`
- `public TIDateTime TimeOfCollisionPassed`

### Methods

```csharp
public WaypointNavigationController(string name, int waypointCount, Vector3 currentVelocity, Vector3 currentPosition, TIDateTime currentTime, WaypointSharedData sharedData, TISpaceShipState shipState, Vector3 collisionBoxSize, Camera mainCamera, CombatShipController combatant)
```

```csharp
private void InitializeWaypointCollections(Vector3 initialPosition, Vector3 initialVelocity, TIDateTime initialTime, bool isPlayer)
```

```csharp
public void OnShipDestructionTriggered()
```

```csharp
public void CachePropulsionValues(float new_acceleration, float new_cruise_acceleration, float new_angular_acceleration_rads2, float new_max_angular_velocity_rads2)
```

```csharp
public void UpdatePropulsionValues()
```

```csharp
public void SetAppendWaypointRotation(Quaternion rotation)
```

```csharp
public void ProposePath(TIDateTime currentTime, Vector3[] path, ProposedWaypoint target, AccelerationConstraints constraints)
```

```csharp
public void ProposeWaypoint(ProposedWaypoint proposed)
```

```csharp
public void ProposeRotation(Quaternion newRotation)
```

```csharp
public void ProposePlacement(Vector3 position)
```

```csharp
public void ResetWaypoints()
```

```csharp
public bool IsEffectivelyStopped()
```

```csharp
public void AllStop(AccelerationConstraints accelerationConstraints)
```

```csharp
public void CancelAllStop()
```

```csharp
public void SetBreakingTrajectory(AccelerationConstraints accelerationConstraints)
```

```csharp
public void FullSpeedAhead(AccelerationConstraints accelerationConstraints)
```

```csharp
public void BurnAlongCurrentVelocity(AccelerationConstraints accelerationConstraints)
```

```csharp
public void InterceptCourse(AccelerationConstraints accelerationConstraints)
```

```csharp
public void MatchVelocity()
```

```csharp
public void CancelMatchVelocity()
```

```csharp
public void BeginDefensiveManeuvers()
```

```csharp
public void CancelDefensiveManeuvers()
```

```csharp
public bool RotateToFaceTarget()
```

```csharp
public void FaceVelocityVector()
```

```csharp
public void MatchRelativeTrajectory(WaypointNavigationController controllerToMatch, AccelerationConstraints constraints, out bool hasMatchedTrajectory)
```

```csharp
public void FollowControllerTrajectory(WaypointNavigationController controllerToMatch, AccelerationConstraints constraints)
```

```csharp
private void RedrawWaypointPath(TIDateTime timingCutoff, Camera cam, Vector3 shipPosition)
```

```csharp
private void HandleOnWaypointReadyForInput(WaypointController controller)
```

```csharp
private bool CanBeginInputHandling()
```

```csharp
private void BeginInputHandling(WaypointController controller)
```

```csharp
public void ToggleHeightLines(bool shouldShow)
```

```csharp
public void ToggleDVCost(bool shouldShow)
```

```csharp
private void HandleOnWaypointEndingInput(WaypointController controller)
```

```csharp
private bool CanEndInputHandling(WaypointController controller)
```

```csharp
private void EndInputHandling()
```

```csharp
private void HandleOnWaypointRemovalRequested(AdjustableWaypoint adjustableWaypoint)
```

```csharp
private void OnPreRenderCallback(Camera cam)
```

```csharp
public void UpdateWaypointNavigation(TIDateTime currentTime)
```

```csharp
private void ClearWaypointCollisionWarnings()
```

```csharp
private void ShowNeededWaypointCollisionWarnings()
```

```csharp
private void UpdateWaypointEngineEffectivenessState()
```

```csharp
private void UpdateWaypointAdjustmentState()
```

```csharp
private void ToggleControllerIsSystemFailureLocked(bool isSystemFailureLocked)
```

```csharp
private void SetControllerIsDvLocked(bool isDvLocked)
```

```csharp
private bool HasNextWaypointBeenReached(TIDateTime currentTime)
```

```csharp
private void AdvanceWaypoints()
```

```csharp
private void CycleWaypoints()
```

```csharp
private void ControllerCoreWaypointRotation()
```

```csharp
private void UpdateWaypoints()
```

```csharp
public void ToggleWaypointVisualization()
```

```csharp
private void ToggleWaypointRenderers()
```

```csharp
public void TogglePathRenderer()
```

```csharp
public void SetWaypointVisualization(bool setActive)
```

```csharp
private void SetWaypointRenderers(bool setActive)
```

```csharp
public void SetPathRenderer(bool setActive)
```

```csharp
public void CleanUpWaypoints()
```

```csharp
private void ClearAllWaypoints()
```

```csharp
public void ResetLocksRecursive()
```

```csharp
public HoldTrajectory GetTrajectoryAtTime(TIDateTime time)
```

```csharp
private AdjustableWaypoint GetNextWaypoint(TIDateTime time)
```

```csharp
public bool IsInBurn(TIDateTime currentTime)
```

```csharp
public bool IsAcceleratingRight(TIDateTime currentTime)
```

```csharp
public bool IsAcceleratingLeft(TIDateTime currentTime)
```

```csharp
public bool IsAcceleratingUp(TIDateTime currentTime)
```

```csharp
public bool IsAcceleratingDown(TIDateTime currentTime)
```

```csharp
public bool IsAcceleratingRollRight(TIDateTime currentTime)
```

```csharp
public bool IsAcceleratingRollLeft(TIDateTime currentTime)
```

```csharp
public Vector3 PositionAtTime(TIDateTime currentTime)
```

```csharp
public Vector3 VelocityAtTime(TIDateTime currentTime)
```

```csharp
public Vector3 AccelerationAtTime(TIDateTime currentTime)
```

```csharp
public Vector3 HeadingAtTime(TIDateTime currentTime)
```

```csharp
public float CurrentAcceleration()
```

```csharp
public Quaternion RotationAtTime(TIDateTime currentTime)
```

```csharp
public float AngularVelocityAt_Rad(TIDateTime currentTime)
```

```csharp
public SegmentProximityData FindNearestSegment()
```

```csharp
public bool UpdateWaypointPlacementLocation()
```

```csharp
private SegmentProximityData EvaluateDistanceToSegment(AdjustableWaypoint currentWaypoint, AdjustableWaypoint previousWaypoint, bool shouldCheckForEarlyAbort = true)
```

```csharp
public void FinalizeWaypointPlacement()
```

```csharp
private float CalculateRelativeDistanceAlongCoreToCoreSegment(float initialDistanceAlongSegment, float initialFullDistanceAlongSegment)
```

```csharp
public void UpdateActiveWaypointPlacementSegment()
```

```csharp
public void ClearActiveWaypointPlacementSegment()
```

```csharp
public void AddAgentShipController(CombatShipController ctrl)
```

```csharp
public void RemoveAgentShipController(CombatShipController ctrl)
```

```csharp
public void AddHabModuleController(HabModuleController ctrl, Collider col)
```

```csharp
public void RemoveHabModuleController(HabModuleController ctrl)
```

```csharp
public void GetDVCost(float availDV_kps)
```

```csharp
public static Vector3 EstimateFutureEnemyPosition(CombatShipController enemyShip, DateTime fromTime, float futureTime_s)
```

```csharp
private List<ValueTuple<TIDateTime, bool>> Simplify([TupleElementNames(new string[]
```

```csharp
private List<ValueTuple<TIDateTime, bool>> Consolidate([TupleElementNames(new string[]
```

```csharp
private List<ValueTuple<TIDateTime, bool>> GetBurnTimings()
```

```csharp
private TIDateTime ClosestApproachTime(TIDateTime startTime, TIDateTime endTime, CombatShipController otherShip)
```

```csharp
private float LinearClosestApproach(Vector3 relativeVelocity, Vector3 relativeStartPosition, float duration)
```

```csharp
private float AcceleratingClosestApproach(Vector3 relativeAcceleration, Vector3 relativeStartVelocity, Vector3 relativeStartPosition, float duration)
```

```csharp
private float CollisionDistance(CombatShipController ship)
```

```csharp
private ValueTuple<TIDateTime, Vector3, CombatShipController> DetectCollisions(TIDateTime currentTime)
```

```csharp
private void CheckForCollisions(TIDateTime currentTime, out bool continueChecking)
```

```csharp
private bool Intersects(Bounds a, Bounds b)
```

```csharp
private void AssignAvoidanceReposition(Vector3 averageCollisionDirection, float minDistToAvoidCollision, Vector3 relativeVelocityAtCollision, TIDateTime timeAt, TIDateTime currentTime)
```

```csharp
public WaypointController GetWaypointControllerByColor(int baseColorIndex)
```

```csharp
public void ClearWaypointGizmos()
```

```csharp
public InitialWaypoint(Vector3 position, Vector3 velocity, Quaternion rotation, TIDateTime timing, float alphaBlendValue)
```

```csharp
public void SetNextWaypoint(INextWaypoint nextWaypoint)
```

```csharp
public void ResetNextWaypointSequence()
```
