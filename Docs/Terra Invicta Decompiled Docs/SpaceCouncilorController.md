# SpaceCouncilorController

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCouncilorController.cs`.*


## Class `SpaceCouncilorController`

```csharp
public class SpaceCouncilorController : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
```

### Fields

| Name | Type |
|---|---|
| `cameraManager` | private CameraManager |
| `councilor` | public TICouncilorState |
| `activePlayer` | private TIFactionState |
| `spaceObjectSelection` | private SpaceObjectSelection |
| `habModelController` | private HabModelController |
| `parentState` | private TIGameState |
| `primaryCanvas` | public Canvas |
| `councilorIcon` | public Image |
| `councilorBackground` | public Image |
| `councilorName` | public TMP_Text |
| `tohitValue` | public TMP_Text |
| `factionIcon` | public Image |
| `markerTooltipTrigger` | public TooltipTrigger |
| `centralIconAnimObject` | public GameObject |
| `centralIconAnimator` | public Animator |
| `centralIconSpriteRenderer` | public SpriteRenderer |
| `centralIconAnimatorController` | private RuntimeAnimatorController |
| `centralIconAnimating` | public bool |
| `selectionAnim` | public Animator |
| `selectionRenderer` | public SpriteRenderer |
| `selectionAnimatorController` | private RuntimeAnimatorController |
| `selectionAnimating` | public bool |
| `selectionAnimObject` | public GameObject |
| `cachedAnimTrigger` | private string |
| `councilorDataDirty` | private bool |
| `hoverImage` | public Image |
| `parentMesh` | public MeshRenderer |
| `currentlyActive` | public bool |
| `tier` | public int |

### Properties

- `public MarkerController.MarkerAnimations currentSelectionAnimation`

### Methods

```csharp
public void Awake()
```

```csharp
private void InitializeCommon()
```

```csharp
public void Initialize(HabModelController modelController, TIHabState habState)
```

```csharp
public void Initialize(ShipModelController modelController, TISpaceShipState shipState)
```

```csharp
public void UpdateController(TICouncilorState councilor)
```

```csharp
public void ClearListeners()
```

```csharp
public void ClearCouncilor()
```

```csharp
public void OnDestroy()
```

```csharp
private void UpdateMarker(CouncilorPositionUpdated e)
```

```csharp
private void UpdateMarker(CouncilCompositionChanged e)
```

```csharp
private void UpdateMarker(CouncilorVisibilityChanged e)
```

```csharp
private void UpdateMarker(CouncilorMissionUpdated e)
```

```csharp
public void OnPointerEnter(PointerEventData eventData)
```

```csharp
public void OnPointerExit(PointerEventData eventData)
```

```csharp
public void OnClicked()
```

```csharp
public void SetTooltip(ParameterizedTextField.BuildStringOnTooltipHover del)
```

```csharp
private string SetStackTooltip(TICouncilorState councilor)
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
public void AssignAnimationToCentralIconSprite(TIMissionTemplate mission, bool pending)
```

```csharp
public void StartCentralIconAnimation(string trigger)
```

```csharp
public void StopCentralIconAnimation()
```

```csharp
private void OnCouncilorAssetDeselected(CurrentAssetDeSelected e)
```

```csharp
private void OnCouncilorOtherStateDeselected(CurrentOtherStateDeselected e)
```

```csharp
public void SetHoverSprite(int setting)
```

```csharp
public void SetHoverSpriteByFaction(TIFactionState faction)
```

```csharp
public void Update()
```
