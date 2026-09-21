# SpaceCombatManager

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombatManager.cs`.*


## Class `SpaceCombatManager`

```csharp
public class SpaceCombatManager : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `modelScalingFactor` | public float |
| `projectileScalingFactor` | public float |
| `promptQueue` | public TIPromptQueueState |
| `container` | public GameObjectDictionary<string> |
| `IsHandlingWaypointInput` | public bool |
| `IsInFormationSelectionMode` | public bool |
| `IsDragSelecting` | public bool |
| `scaledDepartureRange` | private float |
| `combatDuration_s` | public double |
| `INITIAL_COMBAT_OFFSET_MODIFIER_CONFRONTATION` | private const float |
| `INITIAL_COMBAT_OFFSET_MODIFIER_CHASE` | private const float |
| `INITIAL_FORMATION_OFFSET_MIN_km` | private const float |
| `INITIAL_FORMATION_OFFSET_MAX_km` | private const float |
| `EXTREME_COMBAT_DISTANCE_km` | public const float |
| `REENGAGE_COMBAT_DISTANCE_km` | public const float |
| `waypointTimeDelta` | public float |
| `waypointCount` | public int |
| `shipPrefab` | public Transform |
| `shipModelPrefab` | public Transform |
| `waypointPrefab` | public Transform |
| `enemyWaypointPrefab` | public Transform |
| `combatGridPrefab` | public Transform |
| `fleetMarkerPrefab` | public Transform |
| `ships` | public List<CombatShipController> |
| `activeShips` | public List<CombatShipController> |
| `fleetControllers` | public List<CombatFleetController> |
| `combatHabModuleControllers` | public List<CombatHabModuleController> |
| `combatSpaceBodies` | private List<GameObject> |
| `combatantLookup` | public Dictionary<CombatTargetableState, CombatantController> |
| `_shipToNearestSegment` | private Dictionary<CombatShipController, SegmentProximityData> |
| `_combatAIController` | private CombatAIController |
| `gameTime` | private GameTimeManager |
| `setup` | public CombatSetup |
| `initialized` | public bool |
| `timeOfLastShotFired` | public TIDateTime |
| `liveMissiles` | public Dictionary<TIFactionState, int> |
| `liveBallistics` | public Dictionary<TIFactionState, int> |
| `waypointsVisible` | public bool |
| `spaceCombatFarClipPlane` | private readonly float |
| `originalFarClipPlane` | private float |
| `_isSegmentSelectionComplete` | private bool |
| `_isChangePending` | private bool |
| `_initialFrameChangeRequest` | private float |
| `_pendingWaypointPlacementShip` | private CombatShipController |
| `_pendingNearestSegmentWaypointId` | private int |
| `_activeWaypointPlacementShip` | private CombatShipController |
| `_activeNearestSegmentWaypointId` | private int |
| `shotFired` | private bool |
| `shipDestroyed` | private bool |
| `storedStratCameraPosition` | private Vector3 |
| `storedStratCameraRotation` | private Quaternion |
| `UNIT_SCALING_FACTOR` | public const float |
| `_cachedScalingAdjustmentFactor` | private static float |
| `endCombatTime` | private double |
| `forceEndCombatTime` | private double |
| `forceEndCombatDuration_s` | private readonly double |
| `endCombatDuration_s` | private readonly double |
| `prevSkirmishSettings` | public SkirmishModeSettings |
| `_controlDoubleClickCount` | private int |
| `_lastClickTime` | private float |
| `_controlDoubleClickWindow` | private float |
| `scaledSecondFleetOffset` | private Vector3 |
| `secondFleetOffset` | private Vector3 |
| `backgroundCamera` | private Camera |
| `backgroundCameraTransform` | private Transform |
| `_container` | public GameObjectDictionary<string> |
| `_waypointInputDragging` | private bool |
| `_fleetMarker` | public GameObject |
| `_opposingFleetMarker` | public GameObject |
| `_inFormationSelectionMode` | private bool |
| `_controlGroups` | private Dictionary<int, List<TISpaceShipState>> |
| `hit` | private RaycastHit |
| `_dragSelectValid` | private bool |
| `_isDragSelecting` | private bool |
| `_boxSelectStartPosition` | private Vector3 |
| `_boxSelectEndPosition` | private Vector3 |
| `_boxColor` | private Color |
| `_boxSelectedUIControllers` | public List<ShipUIController> |
| `_selectionBox` | private MeshCollider |
| `_selectionMesh` | private Mesh |
| `_corners` | private Vector2[] |
| `_verts` | private Vector3[] |
| `_vecs` | private Vector3[] |
| `_projectileContainer` | public GameObject |
| `_projectileJobContainer` | private ProjectileJobContainer |
| `_projectiles` | public Dictionary<TISpaceCombatProjectileState, ProjectileController> |
| `_reverseProjectiles` | public Dictionary<ProjectileController, TISpaceCombatProjectileState> |
| `combatPathLines` | public List<SpaceCombatManager.CombatPathLine> |
| `minimumDistanceToPrimarySaceBody` | private float |
| `initialMainCameraCullingMask` | private int |
| `combatCameraBlendEffect` | private Material |
| `combatCameraBlend` | private SpaceCombatCameraBlend |
| `primarySpaceBody` | private GameObject |
| `initialCameraClearFlags` | private CameraClearFlags |
| `priorIntensity` | private float |
| `_reinforcementCount` | private Dictionary<TIFactionState, int> |
| `_maxShipsInBattle` | private Dictionary<TISpaceFleetState, int> |
| `_sendInPlayerReinforcements` | private bool |
| `_playerRandomReinforcementPosition` | private Vector3 |
| `_opposingRandomReinforcementPosition` | private Vector3 |
| `briefWait` | private readonly WaitForSeconds |
| `strategyHabObject` | private GameObject |
| `habModelObject` | private GameObject |
| `habModelController` | public HabModelController |
| `strategyHabModelLocalPosition` | private Vector3 |
| `strategyHabModelLocalRotation` | private Quaternion |
| `strategyHabModelLocalScale` | private Vector3 |
| `stratLayerHabActiveStatus` | private Dictionary<TIHabState, bool> |
| `combatStartDateTime` | private TIDateTime |
| `shipsToDisengage` | private List<CombatShipController> |
| `timeOfLastUpdate_s` | private double |
| `timeOfLastSecondUpdate_s` | private double |
| `timeOfLastQuarterSecondUpdate_s` | private double |
| `dateTimeofLastQuarterSecondUpdateLoop` | private DateTime |
| `quarterSecondCounter` | private int |
| `kount` | private int |
| `CombatPathLine` | public class |
| `start` | public Vector3 |
| `end` | public Vector3 |
| `endCap` | public LineEndCap |
| `color` | public Color |

### Properties

- `public CombatGrid combatGrid`
- `public TISpaceCombatState combatState`
- `public SpaceCombatCanvasController combatHUD`
- `public SpaceCombatCameraController combatCamera`
- `public Camera mainCamera`
- `public Transform mainCameraTransform`
- `public bool combatEndTriggered`
- `public bool combatEnded`

### Methods

```csharp
public static float GetScalingAdjustmentFactor()
```

```csharp
public static void SetScalingAdjustmentFactor()
```

```csharp
public static float GetFormationScalingFactor()
```

```csharp
public void SetWaypointDragging(bool value)
```

```csharp
public static Vector3 km_to_scale_vec3(Vector3 distance_km)
```

```csharp
public static float km_to_scale(float distance_km)
```

```csharp
public static float kps_to_scale(float velocity_kps)
```

```csharp
public static float scale_to_kps(float velocity)
```

```csharp
public static float scale_to_km(float distance)
```

```csharp
public static Vector3 scale_to_km_vec3(Vector3 value)
```

```csharp
public static Vector3 vector_km_to_scale(Vector3 vector_km)
```

```csharp
public static float g_to_kps2(float gs)
```

```csharp
public static float kps2_to_scale(float accel_kps2)
```

```csharp
public static float g_to_scale(float gs)
```

```csharp
public static float scale_to_kps2(float acceleration)
```

```csharp
public static float kps2_to_g(float acceleration_kps2)
```

```csharp
public static float acceleration_kps(Vector3 oldVector, Vector3 newVector)
```

```csharp
public static float DVconsumption_kps(Vector3 oldVector, Vector3 newVector, TISpaceShipState ship, float acceleration, float massPriorToBurn_kg)
```

```csharp
public void SetCombat(TISpaceCombatState combat)
```

```csharp
public bool HasActiveState()
```

```csharp
private void InitializeProjectilePool(int count)
```

```csharp
private TISpaceCombatProjectileState GetAvailableProjectileState(ShipWeaponVisController visController)
```

```csharp
public ProjectileController SetProjectile(ShipWeaponVisController visController)
```

```csharp
public void AddPath(Vector3 start, Vector3 end, LineEndCap endCap, Color color)
```

```csharp
public void SetPathEndPointToShipPosition(Vector3 newPosition)
```

```csharp
public void RenderLines(Camera cam)
```

```csharp
private void ApplyCombatCameraEffect()
```

```csharp
private void RemoveCombatCameraEffect()
```

```csharp
public void Initialize()
```

```csharp
public void LockSegmentSelection()
```

```csharp
public void FinalizeWaypointPlacement()
```

```csharp
public void EndWaypointPlacementHandling()
```

```csharp
public void ToggleWaypointVisibility()
```

```csharp
private void HandleAddWaypointInput()
```

```csharp
private void SelectNearestSegment()
```

```csharp
private void SetActiveWaypointPlacementShip()
```

```csharp
private void SelectNearestPlacementForSegment()
```

```csharp
public void SendInPlayerReinforcements()
```

```csharp
public int GetAvailableReinforcementsCount(TIFactionState faction)
```

```csharp
private void GetReinforcementPositionAndVelocity(CombatFleetController fleetController, out Vector3 spawnPosition, out Vector3 velocity)
```

```csharp
private bool TryReinforceFleet(TIFactionState faction, int numReinforcingShips, Vector3 reinforcementSpawnPosition, Vector3 reinforcementVelocityVector, out List<CombatShipController> addedReinforcements)
```

```csharp
private CombatShipController CreateShip(Vector3 position, Vector3 velocity, TISpaceShipState shipState)
```

```csharp
public void Precombat_SwapShipPositions(CombatShipController ship1, CombatShipController ship2)
```

```csharp
public void Precombat_SwapShipToReinforcements(CombatShipController activeShip, TISpaceShipState reinforcementShip)
```

```csharp
public void PreRemoveShip(CombatShipController ship)
```

```csharp
public void PreDestroyHabModule(CombatHabModuleController habModule)
```

```csharp
public void OnShipDestroyed(ShipDestroyed e)
```

```csharp
public void DestroyShip(CombatShipController ship, TIGameState killer, TIFactionState killerFaction, TIShipWeaponTemplate killerWeapon)
```

```csharp
public void RemoveShipFromCombat(CombatShipController ship)
```

```csharp
public void DestroyHabModule(TIFactionState destroyer, CombatHabModuleController module)
```

```csharp
private void FullEndCombatCheck()
```

```csharp
private void CheckEndCombatAfterDestruction(CombatantController controller)
```

```csharp
private void CheckEndCombatAfterDestruction(TISpaceShipState state)
```

```csharp
public void InvokeEndCombat()
```

```csharp
public void EndCombatWithAutoresolve()
```

```csharp
public void EndCombat(bool autoresolve = false)
```

```csharp
private void CombatInit(SpaceCombatInitiated e)
```

```csharp
private void StanceSubmitted(CombatStanceSelected e)
```

```csharp
private void OnPrecombatComplete(PrecombatComplete e)
```

```csharp
public void AutoresolveRejected()
```

```csharp
private IEnumerator WaitForCombatReady()
```

```csharp
private void TriggerCombatEnd()
```

```csharp
private void OnEndCombatStanceChanged(EndCombatStanceChanged e)
```

```csharp
private void OnGameTimeSpeedChanged(GameTimeSpeedChanged e)
```

```csharp
private void StartCombat()
```

```csharp
private void OnDestroy()
```

```csharp
public void ResetCombatManager()
```

```csharp
public void SetupEventListener()
```

```csharp
private void RemoveEventListener()
```

```csharp
private void ShowHab(TIHabState hab, List<CombatFleetController> fleetControllers)
```

```csharp
private void ConfigureHabCollisionObjectsForCombat()
```

```csharp
private void ReturnHabToStrategyLayer()
```

```csharp
private GameObject ShowSpaceBody(TISpaceBodyState spaceBody, float realDistance, float maxDistance, out float maxInnerDistance, out float radius)
```

```csharp
private void OnEnable()
```

```csharp
private void OnDisable()
```

```csharp
public void CombatQuarterSecond(DateTime currentTime, int kounter, bool updateUI)
```

```csharp
public void CombatSecond(bool updateUI)
```

```csharp
public void CombatFractionalSecond(double timeElapsed_s)
```

```csharp
private void Update()
```

```csharp
private void LateUpdate()
```

```csharp
private void UpdateShipControllers(double deltaTime_s)
```

```csharp
private void UpdateCombatHabModuleControllers()
```

```csharp
private void HandleControlGroupInputs()
```

```csharp
private void SetControlGroup(int groupNumber, List<CombatShipController> ships)
```

```csharp
private void SetControlGroup(int groupNumber, CombatShipController ship)
```

```csharp
private void RemoveShipFromControlGroups(TISpaceShipState ship)
```

```csharp
public void SelectControlGroup(int groupNumber)
```

```csharp
public Dictionary<int, List<TISpaceShipState>> GetControlGroups()
```

```csharp
public void ArrangePlayerFleetInFormation(CombatFleetController playerFleet, bool spawnInFrontOfHabIfPresent)
```

```csharp
private void TurnOnFormationSelectionMode()
```

```csharp
public void TurnOffFormationSelectionMode()
```

```csharp
private Formation SetAIFormation(TISpaceFleetState fleetState)
```
