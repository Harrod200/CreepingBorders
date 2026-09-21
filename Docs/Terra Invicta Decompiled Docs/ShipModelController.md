# ShipModelController

*Decompiled from `PavonisInteractive/TerraInvicta/ShipModelController.cs`.*


## Class `ShipModelController`

```csharp
public abstract class ShipModelController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `frontRightVectorThrusterEffect` | private ParticleSystem |
| `frontLeftVectorThrusterEffect` | private ParticleSystem |
| `backRightVectorThrusterEffect` | private ParticleSystem |
| `backLeftVectorThrusterEffect` | private ParticleSystem |
| `frontDorsalVectorThrusterEffect` | private ParticleSystem |
| `frontVentralVectorThrusterEffect` | private ParticleSystem |
| `backDorsalVectorThrusterEffect` | private ParticleSystem |
| `backVentralVectorThrusterEffect` | private ParticleSystem |
| `forwardRollRightThrusterEffect` | private ParticleSystem |
| `forwardRollLeftThrusterEffect` | private ParticleSystem |
| `rearRollRightThrusterEffect` | private ParticleSystem |
| `rearRollLeftThrusterEffect` | private ParticleSystem |
| `forwardCounterRollRightThrusterEffect` | private ParticleSystem |
| `forwardCounterRollLeftThrusterEffect` | private ParticleSystem |
| `rearCounterRollRightThrusterEffect` | private ParticleSystem |
| `rearCounterRollLeftThrusterEffect` | private ParticleSystem |
| `allWeaponControllers` | public List<ShipWeaponVisController> |
| `ship` | protected TISpaceShipState |
| `_shipModalPhysicsColliders` | public Collider[] |
| `thrusterModel` | public GameObject |
| `thrusterLocations` | public GameObject[] |
| `thrusterEffectContainers` | private List<MultiEffectContainer> |
| `vectorThrusterGOs` | public List<GameObject> |
| `vectorThrusterEffect` | private ParticleSystem[] |
| `initVectorThrusters` | private bool |
| `vectorThrusterFXPath` | private string |
| `eventInstance` | public EventInstance |
| `noseWeaponControllers` | public List<ShipWeaponVisController> |
| `dorsalHullWeaponControllers` | public List<ShipWeaponVisController> |
| `ventralHullWeaponControllers` | public List<ShipWeaponVisController> |
| `gameTime` | private GameTimeManager |
| `radiator12` | public GameObject |
| `radiator130` | public GameObject |
| `radiator3` | public GameObject |
| `radiator4` | public GameObject |
| `radiator430` | public GameObject |
| `radiator6` | public GameObject |
| `radiator730` | public GameObject |
| `radiator8` | public GameObject |
| `radiator9` | public GameObject |
| `radiator1030` | public GameObject |
| `radiatorAnimators` | protected List<Animator> |
| `radiatorEmissivesFx` | protected List<ColorAnimationEffect> |
| `SpeedChangeEvent` | public static UnityEvent |
| `thrusters` | protected int |
| `mainHullDestroyed` | public bool |
| `selectionAnimObject` | public GameObject |
| `selectionAnim` | public Animator |
| `selectionRenderer` | public SpriteRenderer |
| `selectionAnimatorController` | private RuntimeAnimatorController |
| `selectionAnimating` | public bool |
| `groupSelectionAnimObject` | public GameObject |
| `groupSelectionAnim` | public Animator |
| `groupSelectionRenderer` | public SpriteRenderer |
| `groupSelectionAnimating` | public bool |
| `padlockIconObject` | public GameObject |
| `baseScale` | private Vector3 |
| `modScale` | private float |
| `mainCamT` | private Transform |
| `destructionEffectController` | public AbstractEffectController |
| `damageLayer` | public DamageLayer |
| `onDestructionCompleteAlreadyCalled` | private bool |

### Properties

- `public bool RadiatorsEmitting`
- `public bool RadiatorsExtended`
- `public MarkerController.MarkerAnimations currentSelectionAnimation`
- `public List<ParticleSystem> smallExplosionParticleSystems`
- `public ParticleSystem destructionExplosionParticleSystem`
- `public virtual int MaxShipBuildSteps`

### Methods

```csharp
public abstract void SetRadiators(TISpaceShipTemplate ship)
```

```csharp
public abstract List<GameObject> WhichRadiators(TISpaceShipTemplate ship)
```

```csharp
public abstract void SetSkin(TISpaceShipTemplate ship)
```

```csharp
public abstract int SlotToWeaponMountIndex(int slot, Mount mount)
```

```csharp
public Vector3 GetMouseColliderDimensions(TIShipHullTemplate hull)
```

```csharp
public void UpdateReticle()
```

```csharp
public void ResetManeuverCommandUI()
```

```csharp
public void InitDamageLayer()
```

```csharp
public TISpaceShipState GetRefShipState()
```

```csharp
public void ActivateThrusters(bool playAudio)
```

```csharp
public void DeactivateThrusters(bool alsoObjects = false)
```

```csharp
public void PlayThrusterAudio()
```

```csharp
public void StopThrusterAudio()
```

```csharp
public ParticleSystem ActivateRandomThruster()
```

```csharp
public void ActivateLeftTurnVectorThrusters()
```

```csharp
public void DeactivateLeftTurnVectorThrusters()
```

```csharp
public void ActivateRightTurnVectorThrusters()
```

```csharp
public void DeactivateRightTurnVectorThrusters()
```

```csharp
public void ActivatePitchDownVectorThrusters()
```

```csharp
public void DeactivatePitchDownVectorThrusters()
```

```csharp
public void ActivatePitchUpVectorThrusters()
```

```csharp
public void DeactivatePitchUpVectorThrusters()
```

```csharp
public void ActivateSlideLeftVectorThrusters()
```

```csharp
public void DeactivateSlideLeftVectorThrusters()
```

```csharp
public void ActivateSlideRightVectorThrusters()
```

```csharp
public void DeactivateSlideRightVectorThrusters()
```

```csharp
public void ActivateSlideDownVectorThrusters()
```

```csharp
public void DeactivateSlideDownVectorThrusters()
```

```csharp
public void ActivateSlideUpVectorThrusters()
```

```csharp
public void DeactivateSlideUpVectorThrusters()
```

```csharp
public void ActivateRollRightVectorThrusters()
```

```csharp
public void DeactivateRollRightVectorThrusters()
```

```csharp
public void ActivateRollLeftVectorThrusters()
```

```csharp
public void DeactivateRollLeftVectorThrusters()
```

```csharp
public void DeactivateAllVectorThrusters()
```

```csharp
public void StartDestructionSequence()
```

```csharp
public void AddExplosions()
```

```csharp
public void OnDestructionStart()
```

```csharp
public void OnDestructionComplete()
```

```csharp
public void ApplyDamageVisualizations(Vector3 hitPoint, DamageType damageType, float damageValue)
```

```csharp
public void SetRadiatorsActive(TISpaceShipTemplate ship, bool active)
```

```csharp
public void SetWeaponsActive(bool active)
```

```csharp
public void SetDrive(string resource, GameObject targetObject, int thrusters, TIDriveTemplate drive, TIFactionState faction, bool variableMaterial, int hullAppearanceIndex, bool simpleHull)
```

```csharp
public void SetVectorThrusters(TIDriveTemplate drive, TIFactionState faction)
```

```csharp
public static void SetShipPart(string resource, GameObject targetObject)
```

```csharp
public static void SetWeapon(string resource, ShipVisController parentController, ShipWeaponVisController targetController, ModuleDataEntry moduleDataEntry, bool forVisualizationOnly)
```

```csharp
public void BuildShip(ShipVisController parentController, TISpaceShipTemplate ship, TISpaceShipState shipState = null, bool buildVectorThrusters = false)
```

```csharp
private void BuildDrives(TISpaceShipTemplate ship)
```

```csharp
private void BuildVectorThrusters(TISpaceShipTemplate ship)
```

```csharp
private void BuildWeapons(ShipVisController parentController, TISpaceShipTemplate ship, TISpaceShipState shipState = null)
```

```csharp
private void SetShadows(bool off)
```

```csharp
public void SetShipCopy(TISpaceShipState ship)
```

```csharp
public void OnWeaponsRepaired()
```

```csharp
public void SetRadiatorEmissiveKelvinRange(double low, double high)
```

```csharp
public Color ConvertKelvinToRGB(double kelvin)
```

```csharp
public void EnableRadiatorEmissives()
```

```csharp
public void DisableRadiatorEmissives()
```

```csharp
public void ResetRadiatorEmissives()
```

```csharp
private void OnRetractRadiatorsInitiate(InitiateRetractRadiatorsEvent e)
```

```csharp
private void OnExtendRadiatorsInitiate(InitiateExtendRadiatorsEvent e)
```

```csharp
private void OnGameTimeSpeedChanged(GameTimeSpeedChanged e)
```

```csharp
private void OnPadlockStateChanged(ShipPadlockStateChanged e)
```

```csharp
private void AdjustAnimTime(float targetAnimTime, float speed)
```

```csharp
private void AdjustRadiatorExplosionsTiming(float speed)
```

```csharp
private void AdjustWeaponExplosionsTiming(float speed)
```

```csharp
private void AdjustThrusterVFXTiming(float speed)
```

```csharp
private void OnRadiatorDestroyed(ShipRadiatorDestroyed e)
```

```csharp
public void OnRadiatorRepaired()
```

```csharp
public void AssignAnimationToSelectionSprite(MarkerController.MarkerAnimations animationValue)
```

```csharp
public void StartSelectionAnimation()
```

```csharp
public void StopSelectionAnimation()
```

```csharp
public void StartGroupSelectionAnimation()
```

```csharp
public void StopGroupSelectionAnimation()
```

```csharp
public SpaceCouncilorController AddCouncilorMarker(TICouncilorState councilor, TISpaceShipState ship, int idx)
```

```csharp
private void Awake()
```

```csharp
private void OnDisable()
```

```csharp
private void OnDestroy()
```

```csharp
private void OnEnable()
```
