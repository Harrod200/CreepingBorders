# MarkerController

*Decompiled from `PavonisInteractive/TerraInvicta/MarkerController.cs`.*


## Class `MarkerController`

```csharp
public class MarkerController : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
```

### Fields

| Name | Type |
|---|---|
| `associatedState` | public TIGameState |
| `width` | public float |
| `scaledWidth` | public float |
| `height` | public float |
| `scaledHeight` | public float |
| `ModelSizeAdjustment` | private float |
| `IsArmyMarker` | public bool |
| `ArmyMarkerController` | public ArmyMarkerController |
| `SeaMarkerController` | public SeaMarkerController |
| `Army` | public TIArmyState |
| `rectTransform` | public RectTransform |
| `group` | public CanvasGroup |
| `missionTimerObject` | public GameObject |
| `missionTimerImage` | public Image |
| `armyMovementArrow` | public GameObject |
| `armyMovementArrowImage` | public Image |
| `armyPathPrefab` | public ArmyPathController |
| `armyPath` | private ArmyPathController |
| `prospectiveDestinationQueue` | public List<TIRegionState> |
| `topRightIconObject` | public GameObject |
| `topRightIcon` | public Image |
| `backgroundIconObject` | public GameObject |
| `backgroundIcon` | public Image |
| `useBackgroundIcon` | public bool |
| `backgroundColor` | public Color |
| `primaryCentralIconObject` | public GameObject |
| `centralIconAnimObject` | public GameObject |
| `centralIcon` | public Image |
| `centralButton` | public Button |
| `factionArmySprite` | public SpriteRenderer |
| `shadow` | public Shadow |
| `centralIconAnimator` | public Animator |
| `centralIconSpriteRenderer` | public SpriteRenderer |
| `centralIconAnimatorController` | private RuntimeAnimatorController |
| `animating` | public bool |
| `numberTextObject` | public GameObject |
| `numberText` | public TMP_Text |
| `factionImageObject` | public GameObject |
| `factionImage` | public Image |
| `armyFactionImageObject` | public GameObject |
| `factionArmyImage` | public Image |
| `nationImageObject` | public GameObject |
| `nationImage` | public Image |
| `percentageBGObject` | public GameObject |
| `percentBG` | public GameObject |
| `percentBar` | public Image |
| `toHitTextObject` | public GameObject |
| `toHitText_Centered` | public TMP_Text |
| `toHitText_Low` | public TMP_Text |
| `toHitText_Lowest` | public TMP_Text |
| `controlPoint6PanelObject` | public GameObject |
| `CPGrid` | public GridLayoutGroup |
| `controlPointObject` | public GameObject[] |
| `CP6Image` | public Image[] |
| `CP6Status` | public Image[] |
| `CP6Text` | public TMP_Text[] |
| `controlPoint6TextObject` | public GameObject[] |
| `controlPointAnimObject` | public GameObject[] |
| `controlPointAnimator` | public Animator[] |
| `selectionAnimObject` | public GameObject |
| `selectionAnim` | public Animator |
| `selectionRenderer` | public SpriteRenderer |
| `selectionAnimatorController` | private RuntimeAnimatorController |
| `selectionAnimating` | public bool |
| `hoverImageObject` | public GameObject |
| `hoverImage` | public Image |
| `markerTooltipTrigger` | public TooltipTrigger |
| `markerType` | public MarkerType |
| `markerCollider` | public CapsuleCollider |
| `location` | private TIGameState |
| `associatedState_` | private TIGameState |
| `highPriority` | public bool |
| `hasModel` | public bool |
| `model` | public GameObject |
| `cachedModel` | public GameObject |
| `modelAnimatorController` | public ModelAnimatorController |
| `hasBeenScaled` | public bool |
| `modelActive` | public bool |
| `relativeScaling` | public float |
| `particleEffectsContainer` | public GameObject |
| `explosionParticleSystem` | public ParticleSystem |
| `fireParticleSystem` | public ParticleSystem |
| `launchParticleSystem` | public ParticleSystem |
| `flashParticleSystem` | public ParticleSystem |
| `nukeLaunchParticleSystem` | public ParticleSystem |
| `nukeStrikeParticleSystem` | public ParticleSystem |
| `linearFireParticleSystem` | public ParticleSystem |
| `alienLightsParticleSystem` | public ParticleSystem |
| `alienGlowParticleSystem` | public ParticleSystem |
| `touchdownParticleSystem` | public ParticleSystem |
| `ambientSFX` | public EventInstance |
| `armyMarkerController` | private ArmyMarkerController |
| `seaMarkerController` | private SeaMarkerController |
| `lerpCoroutine` | private IEnumerator |
| `del` | private MarkerController.OnMarkerButtonPressed |
| `MarkerAnimations` | public enum |

### Properties

- `public MarkerController.MarkerAnimations currentSelectionAnimation`
- `public string cachedAnimTrigger`
- `public bool IsPointedAt`
- `public bool JustPointedAt`

### Methods

```csharp
public void Initialize(MarkerType mType, TIGameState location)
```

```csharp
private void Update()
```

```csharp
public void SetAmbientAudioClip(string path)
```

```csharp
public void SetHoverSprite(int setting)
```

```csharp
public void SetHoverSpriteByFaction(TIFactionState faction)
```

```csharp
public void OnPointerEnter(PointerEventData eventData)
```

```csharp
public void OnPointerExit(PointerEventData eventData)
```

```csharp
public void OnRightClick()
```

```csharp
public void OnButtonPressed()
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
private void SetCentralIconAnimating(bool setting)
```

```csharp
public void StartAnimations(string trigger)
```

```csharp
public void StopCentralIconAnimation()
```

```csharp
public void AssignAnimationToCentralIconSprite(TIArmyState army, bool firing, bool atSea = false)
```

```csharp
public void AssignAnimationToCentralIconSprite(TIMissionTemplate mission, bool pending)
```

```csharp
public void StartCPTargetingAnimation(int CP)
```

```csharp
public void StopCPTargetingAnimation(int CP)
```

```csharp
public void StopAllCPTargetingAnimations()
```

```csharp
public void TriggerAttacking()
```

```csharp
public void TriggerDestruction()
```

```csharp
public void TriggerExplosion()
```

```csharp
private IEnumerator TriggerExplosionWaiter()
```

```csharp
public void TriggerLaunch()
```

```csharp
public void TriggerGeneralFires()
```

```csharp
public void StopGeneralFires()
```

```csharp
public void TriggerArtilleryFlashes()
```

```csharp
public void StopArtilleryFlashes()
```

```csharp
public void TriggerNuclearLaunch()
```

```csharp
public void TriggerNuclearStrike()
```

```csharp
public void TriggerLinearFires()
```

```csharp
public void StopLinearFires()
```

```csharp
public void TriggerAlienLights(int intensity)
```

```csharp
public void StopAlienLights()
```

```csharp
public void TriggerAlienGlow(int intensity)
```

```csharp
public void StopAlienGlow()
```

```csharp
public void TriggerTouchdown(IMarkerControl marker)
```

```csharp
private void InitParticleEffect(ref ParticleSystem particleSystem, string path)
```

```csharp
public void SetButtonPressed(MarkerController.OnMarkerButtonPressed del)
```

```csharp
public void CPButtonPressed(int buttonPosition)
```

```csharp
public void SetActive(bool active)
```

```csharp
public void MoveMarker(Vector2 newPosition, float time = 0f)
```

```csharp
private IEnumerator LerpMarker(Vector3 source, Vector3 target, float overTime)
```

```csharp
private IEnumerator LerpMarkerWithAlpha(Vector3 startPosition, Vector3 endPosition, float startAlpha, float endAlpha, float overTime)
```

```csharp
public void SetMarkerModel(string ambientAudioPath = null)
```

```csharp
public void SetModelSFXVolume(float distance)
```

```csharp
public void SetCentralIcon(string imagePath)
```

```csharp
public void SetCentralIcon(Sprite image)
```

```csharp
public void TurnOn3dElements()
```

```csharp
public void TurnOff3dElements()
```

```csharp
public void TurnOffAmbientVolume()
```

```csharp
public void RemoveAmbientAudio()
```

```csharp
public void SetTopRightIcon(Sprite sprite = null, ClearFlag clear = ClearFlag.NoChange)
```

```csharp
public void SetCentralIconShadow(bool drawShadow)
```

```csharp
public void SetCPImages(TINationState nation = null, ClearFlag clear = ClearFlag.NoChange, bool activateButtons = true, TIFactionState targetingCouncil = null)
```

```csharp
public void SetPrimaryIconBackground(Sprite sprite, Color color, ClearFlag clear = ClearFlag.NoChange)
```

```csharp
public void SetCPToHitNumber(int CPvalue, string newValue = null, ClearFlag clear = ClearFlag.NoChange)
```

```csharp
public void SetNumber(string newValue, ClearFlag clear = ClearFlag.NoChange, bool richText = false)
```

```csharp
public void SetToHitNumber(string value = "", bool useAutomaticSymbols = true, ClearFlag clear = ClearFlag.NoChange, int position = 0)
```

```csharp
public void SetFactionImage(Sprite sprite = null, ClearFlag clear = ClearFlag.NoChange)
```

```csharp
public void SetArmyFactionImage(Sprite image = null, ClearFlag clear = ClearFlag.NoChange)
```

```csharp
public void SetNationImage(Sprite image = null, ClearFlag clear = ClearFlag.NoChange)
```

```csharp
public void SetPercentage(float newValue, ClearFlag clear = ClearFlag.NoChange)
```

```csharp
public void SetPercentColor(Color newColor)
```

```csharp
public void SetMissionTimer(TICouncilorState councilor)
```

```csharp
public string BuildTooltipText(string baseText, TIFactionState viewingCouncil, bool targeting = false, TIGameState target = null)
```

```csharp
public void SetTooltip(ParameterizedTextField.BuildStringOnTooltipHover del)
```

```csharp
public static string BuildInvalidTargetTooltip(List<string> reasons)
```

```csharp
public void UpdateArmyPathVisibility(bool forcePathUpdate = false)
```

```csharp
public void OnArmyPathChanged(ArmyPathChanged e)
```

```csharp
public void OnOperationTargetSelected(OperationTargettedEvent e)
```

```csharp
private void OnUIScaleChanged(UIScaleSettingChange e)
```

```csharp
private void UpdateUIScale()
```

```csharp
private void OnDestroy()
```

```csharp
public delegate void OnMarkerButtonPressed(MarkerController controller)
```
