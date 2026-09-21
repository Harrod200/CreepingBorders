# CombatShipController

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/CombatShipController.cs`.*


## Class `CombatShipController`

```csharp
public class CombatShipController : CombatantShipController
```

### Fields

| Name | Type |
|---|---|
| `damageableType` | public override IDamageableType |
| `CanWaypointsBeAdjusted` | public bool |
| `TimeOfNextWaypoint` | public TIDateTime |
| `ref_shipController` | public override CombatShipController |
| `heading` | public Vector3 |
| `rotation` | public Quaternion |
| `angular_acceleration_rads2` | public float |
| `max_angular_velocity_rads_s` | public float |
| `acceleration` | public float |
| `cruiseAcceleration` | public float |
| `activePlayerShip` | public bool |
| `velocityVector_kps` | public override Vector3 |
| `primaryTargetState` | public CombatTargetableState |
| `sections` | public IList<IHullSection> |
| `InCollisionAvoidanceManeuver` | public bool |
| `accelerationVector` | public override Vector3 |
| `accelerationVector_kps` | public override Vector3 |
| `weapons` | public IEnumerable<IWeapon> |
| `BoundingBoxSize` | public Vector3 |
| `initialized` | private bool |
| `gameTime` | private GameTimeManager |
| `StrategyShipControllerTransform` | private Transform |
| `shipVisualizerTransform` | private Transform |
| `localScaleToRestore` | private Vector3 |
| `localPositionToRestore` | private Vector3 |
| `horizontalAccelerationState` | private AxisState |
| `verticalAccelerationState` | private AxisState |
| `rollAccelerationState` | private AxisState |
| `acceleratingRight` | private bool |
| `acceleratingLeft` | private bool |
| `acceleratingUp` | private bool |
| `acceleratingDown` | private bool |
| `acceleratingRollRight` | private bool |
| `acceleratingRollLeft` | private bool |
| `visualizationOff` | private bool |
| `departed` | public bool |
| `timeOfDeath` | private TIDateTime |
| `positionOfDeath` | private Vector3 |
| `initialVelocity` | private Vector3 |
| `_spinPortRotation` | private Quaternion |
| `_spinStarboardRotation` | private Quaternion |
| `_spinVentralRotation` | private Quaternion |
| `_spinDorsalRotation` | private Quaternion |
| `rootCollider` | private Collider |
| `_handledManeuvers` | private List<CombatManeuver> |
| `_waypointNavigationController` | public WaypointNavigationController |
| `controlGroups` | public List<int> |
| `inDefensiveManuever` | private bool |
| `nextDefensiveManueverUpdateTime` | private TIDateTime |
| `cachedFaction` | private TIFactionState |
| `AI_IsMissileBoat` | public bool |
| `_cachedAccelerationVector` | private Vector3 |
| `_boundingBoxSize` | private Vector3? |
| `lastTimeChecked` | private TIDateTime |
| `killer` | private TIGameState |
| `killerFaction` | private TIFactionState |
| `killerWeapon` | private TIShipWeaponTemplate |
| `onDestructionCompleteAlreadyCalled` | private bool |

### Properties

- `public ShipVisController visualizationController`
- `public override ShipModelController ModelController`
- `public override Vector3 velocityVector`
- `public float angularVelocity_kps`
- `public bool thrusting`
- `public IHull hull`
- `public override List<Collider> hitColliders`
- `public override TISpaceShipState ShipState`
- `public CombatantController primaryTarget`
- `public CombatantController oldPrimaryTarget`
- `public CombatantController maneuverTarget`
- `public CombatantController oldManeuverTarget`

### Methods

```csharp
public override IDamageableType GetCombatantType()
```

```csharp
public override Vector3 positionAtTime(DateTime currentTime)
```

```csharp
public Vector3 headingAtTime(DateTime currentTime)
```

```csharp
public Vector3 velocityAtTime(DateTime currentTime)
```

```csharp
public Vector3 accelerationAtTime(DateTime currentTime)
```

```csharp
public override CombatTargetableState GetCombatantState()
```

```csharp
public override SpaceCombatAssetUIController UIController()
```

```csharp
public float GetDVConservingAceleration_kps2(bool isProactiveBurn)
```

```csharp
public float GetDVConservingAceleration_unity(bool isProactiveBurn)
```

```csharp
public AccelerationConstraints GetAccelerationConstraints()
```

```csharp
public AccelerationConstraints GetDVConservingAccelerationConstraints(bool isProactiveBurn)
```

```csharp
private void Start()
```

```csharp
private void OnDestroy()
```

```csharp
public void Initialize(TISpaceShipState state, Vector3 initialVelocity)
```

```csharp
private void SetupListeners(TISpaceShipState state)
```

```csharp
private void RemoveListeners()
```

```csharp
public void SetAccelerationVector()
```

```csharp
public void SetInitialVelocityVector(Vector3 newInitialVelocity)
```

```csharp
private void InitializeWaypoints(GameStateID id)
```

```csharp
public void ReinitializeWaypoints()
```

```csharp
public void EnableRootCollider()
```

```csharp
public bool AlwaysShowWaypoints()
```

```csharp
public void SetWaypointVisualization(bool setActive)
```

```csharp
public void ToggleWaypointVisualization()
```

```csharp
public void ToggleEnemyShipDetailedPathRendering()
```

```csharp
private void UpdateWaypoints(TIDateTime currentTime)
```

```csharp
public void ProposePath(Vector3[] path, ProposedWaypoint end, AccelerationConstraints constraints)
```

```csharp
public void ProposeRotation(Quaternion rotation)
```

```csharp
public void ProposeWaypoint(ProposedWaypoint proposed)
```

```csharp
public void ProposePlacement(Vector3 position)
```

```csharp
public void ResetWaypoints()
```

```csharp
public bool TryToKeepNoseTowardsThreat(List<ProjectileController> threateningProjectiles)
```

```csharp
public bool TryAssignDefensivePosition(List<ProjectileController> threateningProjectiles, AccelerationConstraints constraints)
```

```csharp
public void BeginDefensiveManuevers()
```

```csharp
public void CancelDefensiveManuevers()
```

```csharp
public float GetShipEffectiveScaledCombatRange()
```

```csharp
public float GetShipMaxScaledCombatRange()
```

```csharp
public List<ProjectileController> GetAllThreateningProjectiles()
```

```csharp
private List<MissileController> GetAllMissilesTargetingMe()
```

```csharp
public void FilterForImminentImpactThreats(ref List<ProjectileController> projectiles)
```

```csharp
public bool IsProjectileContested(ProjectileController projectile)
```

```csharp
protected void UpdateIsMissileSaturated()
```

```csharp
private float EstimateShipKillDamageThreshold()
```

```csharp
public int EstimatedMaxProjectilesPointDefenseCanHandle()
```

```csharp
public float EstimatedIncomingMissileDamage(List<MissileController> incomingMissiles)
```

```csharp
public override float ApplyDamage(DamageSource source)
```

```csharp
public void ApplyDamageVisualization(Vector3 hitPoint, DamageType damageType, float damageValue)
```

```csharp
private void OnShipHeatChange(ShipHeatChange e)
```

```csharp
private void OnShipDeltaVChange(ShipDeltaVChange e)
```

```csharp
private void OnPropulsionValuesUpdated(CombatShipPropulsionValuesUpdated e)
```

```csharp
public void ShipDepartureCleanup()
```

```csharp
public void TriggerShipDestruction(TIGameState killerCombatanat, TIShipWeaponTemplate killerWeapon)
```

```csharp
private void HandleShipBeingDestroyed()
```

```csharp
private void DestroyShipVisualization()
```

```csharp
private void OnDestructionComplete()
```

```csharp
public void FinishUpImmediately()
```

```csharp
private void ToggleExplosions()
```

```csharp
private IEnumerator Boom(ParticleSystem explosion, float delay)
```

```csharp
private void DestroyShipParts()
```

```csharp
private IEnumerator RemoveShipObject()
```

```csharp
public void ReturnToStrategyLayerFleet()
```

```csharp
public void UpdateShip()
```

```csharp
private void HandleShipStandardUpdate(bool destructionTriggered)
```

```csharp
private Dictionary<CombatManeuver, bool> GetManeuverStates()
```

```csharp
private void HandleActiveShipManeuvers()
```

```csharp
private void UpdateThrusterVisuals(TIDateTime currentTime)
```

```csharp
private void HandleRightLeftAcceleration(TIDateTime currentTime)
```

```csharp
private bool EvaluateRightLeftDrift(TIDateTime currentTime)
```

```csharp
private bool EvaluateRightLeftRotation(TIDateTime currentTime)
```

```csharp
private void HandleUpDownAcceleration(TIDateTime currentTime)
```

```csharp
private bool EvaluateUpDownDrift(TIDateTime currentTime)
```

```csharp
private bool EvaluateUpDownRotation(TIDateTime currentTime)
```

```csharp
private void HandleRollAcceleration(TIDateTime currentTime)
```

```csharp
private bool EvaluateRollRotation(TIDateTime currentTime)
```

```csharp
private void UpdateShipPositioning(TIDateTime currentTime)
```

```csharp
public void UpdateActiveWaypointPlacementSegment()
```

```csharp
public void ClearActiveWaypointPlacementSegment()
```

```csharp
public SegmentProximityData FindNearestSegment()
```

```csharp
public bool UpdateWaypointPlacementLocation()
```

```csharp
public void FinalizeWaypointPlacement()
```

```csharp
public string GetGroupMembershipString()
```

```csharp
public void SetPrimaryTarget(CombatantController newPrimaryTarget)
```

```csharp
public void SetManeuverTarget(CombatantController newManeuverTarget)
```

```csharp
private void OnTriggerEnter(Collider other)
```

```csharp
private void OnTriggerExit(Collider other)
```

```csharp
private void OnCollisionEnter(Collision other)
```
