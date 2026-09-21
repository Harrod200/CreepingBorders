# StrategyShipController

*Decompiled from `PavonisInteractive/TerraInvicta/StrategyShipController.cs`.*


## Class `StrategyShipController`

```csharp
public class StrategyShipController : CombatantShipController
```

### Fields

| Name | Type |
|---|---|
| `damageableType` | public override IDamageableType |
| `ModelController` | public override ShipModelController |
| `set` | protected |
| `GetDamageableTransform` | public override Transform |
| `Accelerate_Thrusters_Phase` | private const int |
| `Deccelerate_Thrusters_Phase` | private const int |
| `Idle_Thrusters_Phase` | private const int |
| `cameraManager` | private CameraManager |
| `dataDirty` | private bool |
| `initializedUiOnly` | private bool |
| `_stratLayerThrusterPhase` | private int |
| `inPreviousBurn` | private bool |
| `inPreviousCounterBurn` | private bool |
| `previousManeuver` | private ITrajectory |
| `visualizationOff` | private bool |
| `FleetVisController` | public FleetVisController |
| `councilorControllers` | public Dictionary<SpaceCouncilorController, int> |

### Properties

- `public Hull hull`
- `public override List<Collider> hitColliders`
- `public override TISpaceShipState ShipState`
- `public ShipVisController VisController`
- `public override Vector3 velocityVector`
- `public override Vector3 velocityVector_kps`
- `public override Vector3 accelerationVector`
- `public override Vector3 accelerationVector_kps`

### Methods

```csharp
public override CombatTargetableState GetCombatantState()
```

```csharp
public override IDamageableType GetCombatantType()
```

```csharp
public override SpaceCombatAssetUIController UIController()
```

```csharp
public override Vector3 positionAtTime(DateTime currentTime)
```

```csharp
public void Initialize(GameObject visPrefab, TISpaceShipState shipState, FleetVisController fleetVisController, bool uiOnly = false)
```

```csharp
public static Hull CreateHull(TISpaceShipState ship)
```

```csharp
public void DisableStratController()
```

```csharp
private void AddListeners()
```

```csharp
private void RemoveListeners()
```

```csharp
public void OnShipVisualizationDataDirty(ShipVisualizationDataDirty e)
```

```csharp
public void EnterCombat(ShipEntersCombat e)
```

```csharp
public void PostCombat(ShipLeavesCombat e)
```

```csharp
private void UpdateManeuverThrusterFX(TIDateTime currentTime)
```

```csharp
private void UpdateFleetOffsetFX(TIDateTime currentTime)
```

```csharp
public void SetAllCouncilorsActive(bool active)
```

```csharp
public void UpdateAllCouncilors(CouncilorPositionUpdated e)
```

```csharp
public void UpdateAllCouncilors(CouncilorDepartsShip e)
```

```csharp
public void UpdateAllCouncilors(TICouncilorState conditionalCouncilor = null)
```

```csharp
public override float ApplyDamage(DamageSource source)
```

```csharp
private void TriggerShipDestruction()
```

```csharp
private void OnShipDestroyedByHeat(ShipDestroyedByHeat e)
```

```csharp
private void DestroyShipVisualization()
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
private void Update()
```

```csharp
public void SetDirty()
```

```csharp
private void OnEnable()
```

```csharp
private void OnDisable()
```

```csharp
private void OnDestroy()
```
