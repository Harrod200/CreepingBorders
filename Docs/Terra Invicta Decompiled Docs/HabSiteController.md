# HabSiteController

*Decompiled from `PavonisInteractive/TerraInvicta/HabSiteController.cs`.*


## Class `HabSiteController`

```csharp
public class HabSiteController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `radius_gameUnits` | public float |
| `sitePosition` | public Vector3 |
| `primaryCanvas` | public Canvas |
| `habSiteMarker` | public Image |
| `habSiteMarkerModel` | public Image |
| `habSiteTooltip` | public TooltipTrigger |
| `selectionAnim` | public Animator |
| `selectionRenderer` | public SpriteRenderer |
| `selectionAnimatorController` | private RuntimeAnimatorController |
| `sectorImage` | public Image[] |
| `sectorImagesCanvasGroup` | public CanvasGroup |
| `habSiteMarkerCanvasGroup` | public CanvasGroup |
| `initialized` | private bool |
| `activePlayer` | private TIFactionState |
| `habClassificationImage` | public Image |
| `myCouncilorGrid` | public ListManagerBase |
| `enemyCouncilorGrid` | public ListManagerBase |
| `landedFleetGrid` | public ListManagerBase |
| `myCouncilors` | private List<CouncilorView> |
| `enemyCouncilors` | private List<CouncilorView> |
| `particleEffectsContainer` | public GameObject |
| `launchFX` | public ParticleSystem |
| `explosionFX` | public ParticleSystem |
| `modelRoot` | public GameObject |
| `selectionHighlightObject` | public GameObject |
| `hoverHighlightObject` | public GameObject |
| `surfaceModelController` | public SurfaceBaseModelController |
| `spaceObjectSelection` | private SpaceObjectSelection |
| `groundFireControllers` | private Dictionary<TIHabModuleState, GroundFireController> |
| `gameTimeManager` | private GameTimeManager |
| `mainCam` | private Camera |
| `cameraMgr` | private CameraManager |
| `initializedForGroundFire` | private bool |

### Properties

- `public TIHabSiteState site`

### Methods

```csharp
public void Awake()
```

```csharp
public void SetActivePlayer(bool startup)
```

```csharp
public void Initialize(TIGameState state, SpaceBodyController parentBodyController)
```

```csharp
public void OnEnable()
```

```csharp
private void OnSpaceBodyProspected(SpaceBodyProspected e)
```

```csharp
private void UpdateSiteMarker(SectorAssignedToFaction e)
```

```csharp
private void UpdateSiteMarker(FleetUndocks e)
```

```csharp
private void UpdateSiteMarker(FactionExplorationRangeChanged e)
```

```csharp
private void UpdateSiteMarker(FleetArrivesAtDestination e)
```

```csharp
private void OnHabCreated(HabCreated e)
```

```csharp
private void OnHabDestroyed(HabDestroyed e)
```

```csharp
private void OnFleetDisbanded(FleetDisbanded e)
```

```csharp
private void UpdateCouncilors(CouncilorPositionUpdated e)
```

```csharp
private void UpdateCouncilors(CouncilorVisibilityChanged e)
```

```csharp
private void UpdateCouncilors(CouncilorDepartsHab e)
```

```csharp
private void OnLaunchRocketFromHabEvent(LaunchRocketFromHabEvent e)
```

```csharp
private void OnHabSymbolAssigned(HabSymbolAssigned e)
```

```csharp
private void OnHabModuleDestroyed(HabModuleDestroyed e)
```

```csharp
public void TriggerExplosion()
```

```csharp
public void TriggerLaunch()
```

```csharp
public void OnClickHabSite()
```

```csharp
public void OnClickSector(int value)
```

```csharp
public static string GetInlineResourceOutputIcon(FactionResource resource, TIMiningProfileTemplate template, float value)
```

```csharp
public static string BuildOutputString(TIHabSiteState site)
```

```csharp
public void SetCouncilorData()
```

```csharp
public void SetFleetData()
```

```csharp
public string BuildMarkerTooltip()
```

```csharp
public static Sprite GetEmptyHabSiteIcon(TIHabSiteState site, TIFactionState faction)
```

```csharp
public void SetMarkerData()
```

```csharp
public void ToggleSurfaceModel(bool show)
```

```csharp
public Vector3 GlobalPosition(TIDateTime time)
```

```csharp
private void OnBeginBombardment(BeginBombardment e)
```

```csharp
private void OnEndBombardment(EndBombardment e)
```

```csharp
private void InitializeForGroundFire()
```

```csharp
public void DisplayBeam(TIHabModuleState shooter, TISpaceShipState target, TIDateTime time)
```

```csharp
private void CeaseBeamFire(TimeEventStart e)
```

```csharp
public void CeaseBeamFire(TIHabModuleState module)
```

```csharp
public void OnCombatStarts(CombatStarts e)
```

```csharp
private void Update()
```

```csharp
private void LateUpdate()
```
