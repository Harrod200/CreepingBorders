# ShipWeaponVisController

*Decompiled from `PavonisInteractive/TerraInvicta/ShipWeaponVisController.cs`.*


## Class `ShipWeaponVisController`

```csharp
public class ShipWeaponVisController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `hasTarget` | public bool |
| `gameTime` | protected GameTimeManager |
| `baseObject` | public GameObject |
| `baseObjectTransform` | public Transform |
| `weaponObject` | public GameObject |
| `weaponObjectTransform` | public Transform |
| `firePoint` | public GameObject |
| `firePointTransform` | public Transform |
| `myTransform` | public Transform |
| `weaponModuleData` | public ModuleDataEntry |
| `weaponTemplate` | public TIShipWeaponTemplate |
| `shipVisController` | public ShipVisController |
| `combatHabModuleController` | public CombatHabModuleController |
| `weaponCarrierState` | private CombatWeaponCarrierState |
| `target` | public IDamageable |
| `stratLayerTarget` | public TIGameState |
| `targetPosition` | private Vector3 |
| `targetLongitude` | private float |
| `targetLatitude` | private float |
| `targetParentSpaceBody` | private Transform |
| `eventInstance` | private EventInstance |
| `eventPath` | protected string |
| `shotEffectInstance` | protected GameObject |
| `weaponExplosionInstance` | public GameObject |
| `updateTime` | private TIDateTime |
| `UIVisualizationOnly` | private bool |
| `beamController` | protected BeamWeaponController |
| `shotData` | protected RaycastHit |
| `muzzleFlashes` | protected ShipWeaponMuzzleFlashController[] |
| `projectileResource` | public string |
| `projectilePrefab` | public GameObject |
| `baselineTurretTrainingRate_degSec` | private const float |
| `turretTrainingRate_degsec` | private float |
| `_initialBaseObjectRotation` | private Transform |
| `_destroyedMaterial` | private Material |
| `_originalBaseMaterial` | private Material |
| `_originalWeaponMaterial` | private Material |
| `createdPrefabs` | private bool |
| `shotEffectPath` | private string |
| `CeaseBeamFireStr` | private const string |
| `ceaseBeamFireTime` | private TIDateTime |
| `combatBeamOnTime` | private const float |
| `habBeamScaling` | private readonly Vector3 |
| `TargetIndicator` | public GameObject |
| `UpIndicator` | public GameObject |
| `InitialBaseForwardIndicator` | public GameObject |
| `BaseForwardIndicator` | public GameObject |
| `WeaponForwardIndicator` | public GameObject |
| `ShowDebugVisualization` | public bool |

### Methods

```csharp
private void SetPrefabs()
```

```csharp
private void InitializeCommon(bool createPrefabs = true)
```

```csharp
public void Initialize(CombatHabModuleController controller, GameObject baseObject, TIShipWeaponTemplate weaponTemplate, int slot)
```

```csharp
public void Initialize(ShipVisController controller, ModuleDataEntry moduleData, bool forVisualizationOnly)
```

```csharp
public void OnDestroy()
```

```csharp
public void OnEnable()
```

```csharp
public void OnDisable()
```

```csharp
public void CreatePrefabs()
```

```csharp
public void SetTarget(IDamageable target, Vector3 targetPosition)
```

```csharp
private Vector3 GetTargetPosition(TIDateTime time = null)
```

```csharp
public void SetStratLayerTarget(TIGameState target, Vector3 targetPosition, float targetLongitude, float targetLatitude, Transform parentSpaceBody)
```

```csharp
public void ClearStratLayerTarget()
```

```csharp
public void ClearTarget()
```

```csharp
public bool OnTarget()
```

```csharp
public bool BombardmentTargetInLineOfSight(TIDateTime time)
```

```csharp
private void RotateToFoward()
```

```csharp
public void RotateToTarget(bool forceToForward = false)
```

```csharp
private bool Bombarding()
```

```csharp
public void Fire(bool truncated, TIDateTime time = null)
```

```csharp
public void CeaseBeamFire()
```

```csharp
public void CeaseGunFire()
```

```csharp
private void OnFireMissionOrder(FireMissionOrder e)
```

```csharp
private void EndFireMissionOrder(EndBombardment e)
```

```csharp
private void OnWeaponDestroyedExplosion(ShipDestroyedWeaponExplosion e)
```

```csharp
public void OnWeaponRepaired()
```

```csharp
public void OnGameTimePlay()
```

```csharp
public void OnGameTimePause()
```

```csharp
public void Update()
```
