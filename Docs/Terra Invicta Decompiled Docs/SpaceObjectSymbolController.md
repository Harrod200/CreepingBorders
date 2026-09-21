# SpaceObjectSymbolController

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceObjectSymbolController.cs`.*


## Class `SpaceObjectSymbolController`

```csharp
public class SpaceObjectSymbolController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `spaceObject` | private TISpaceObjectState |
| `station` | private TIHabState |
| `fleet` | private TISpaceFleetState |
| `lagrangePoint` | private TILagrangePointState |
| `spaceBody` | private TISpaceBodyState |
| `primaryCanvas` | public Canvas |
| `primaryCanvasRaycaster` | public GraphicRaycaster |
| `selectionAnimObject` | public GameObject |
| `selectionAnim` | public Animator |
| `selectionRenderer` | public SpriteRenderer |
| `selectionAnimatorController` | private RuntimeAnimatorController |
| `hoverImage` | public Image |
| `buttonImage` | public Image |
| `objectName` | public TMP_Text |
| `tooltip` | public TooltipTrigger |
| `selectionAnimating` | private bool |
| `outline` | public Outline |
| `fleetsPanel` | public GameObject |
| `councilorsPanel` | public GameObject |
| `stationsPanel` | public GameObject |
| `basesPanel` | public GameObject |
| `fleetsList` | public ListManagerBase |
| `councilorsList` | public ListManagerBase |
| `stationsList` | public ListManagerBase |
| `basesList` | public ListManagerBase |
| `habSectorsPanel` | public GameObject |
| `leftSectorPanel` | public GameObject |
| `leftSectorImage` | public Image |
| `leftSectorConnector` | public GameObject |
| `topSectorPanel` | public GameObject |
| `topSectorConnector` | public GameObject |
| `topSectorImage` | public Image |
| `rightSectorPanel` | public GameObject |
| `rightSectorConnector` | public GameObject |
| `rightSectorImage` | public Image |
| `bottomSectorPanel` | public GameObject |
| `bottomSectorConnector` | public GameObject |
| `bottomSectorImage` | public Image |
| `probeImage` | public Image |
| `habClassificationIconImage` | public Image |
| `assaultCarrierIcon` | public Image |
| `playerTagImage` | public Image |
| `parentSpaceObjectController` | private SpaceObjectController |
| `selection` | private SpaceObjectSelection |
| `activePlayer` | private TIFactionState |
| `symbolType` | private SpaceObjectSymbolType |
| `initialized` | private bool |
| `_activePlayerKnownFleets` | private static List<TISpaceFleetState> |
| `fleetCache` | private static int |
| `PlanetTagRed` | public static readonly Color |
| `PlanetTagGreen` | public static readonly Color |

### Properties

- `public bool visible`
- `public float scaleSize`

### Methods

```csharp
public void InitializeSymbol(TISpaceObjectState spaceObject, SpaceObjectController parentController)
```

```csharp
private void OnDestroy()
```

```csharp
private void OnDisable()
```

```csharp
public void SetVisible(bool displaySymbol)
```

```csharp
public void VisibilityChange()
```

```csharp
private void SetListeners()
```

```csharp
private void RemoveListeners()
```

```csharp
public bool ShouldShowDisplayName()
```

```csharp
public void ShowDisplayName()
```

```csharp
public void HideDisplayName()
```

```csharp
public void SetDisplayName()
```

```csharp
public void SetHoverImage()
```

```csharp
private bool anyVisibleBases(TISpaceBodyState spaceBody)
```

```csharp
private bool anyVisibleStations(TINaturalSpaceObjectState naturalSpaceSpaceobject)
```

```csharp
private IEnumerable<TICouncilorState> visibleCouncilors(TISpaceFleetState fleet)
```

```csharp
private IEnumerable<TICouncilorState> visibleCouncilors(TIHabState hab)
```

```csharp
private bool ShouldShowSymbol()
```

```csharp
public void SetActivePlayer()
```

```csharp
private void SetPrimaryImage()
```

```csharp
private void SetTooltip()
```

```csharp
private void SetAllSymbolInformation()
```

```csharp
private void AssetInfoUpdate(SpaceAssetDetected e)
```

```csharp
private void FleetInfoUpdate(FleetArrivesAtDestination e)
```

```csharp
private void FleetInfoUpdate(ShipsAddedToFleet e)
```

```csharp
private void FleetInfoUpdate(ShipsRemovedFromFleet e)
```

```csharp
private void FleetInfoUpdate(FleetSymbolVisibilityChange e)
```

```csharp
private void FleetInfoUpdate(FleetCoreStatusChange e)
```

```csharp
private void FleetInfoUpdate(FleetUndocks e)
```

```csharp
private void FleetInfoUpdate(TISpaceFleetState updatedFleet)
```

```csharp
private void CouncilorInfoUpdate()
```

```csharp
private void SpaceBodyInfoUpdate(MoonSymbolVisibilityChange e)
```

```csharp
private void HabInfoUpdate(SectorAssignedToFaction e)
```

```csharp
private void HabInfoUpdate(HabSymbolAssigned e)
```

```csharp
private void HabInfoUpdate(StationSymbolVisibilityChange e)
```

```csharp
private void OnHabDestroyed(HabDestroyed e)
```

```csharp
private void HabInfoUpdate(TIHabState updatedHab)
```

```csharp
private void SetStationSymbol()
```

```csharp
public void OnSectorClicked(int sectorValue)
```

```csharp
private void UpdateFleetsWithinObjectBounds()
```

```csharp
private void UpdateCouncilorsWithinObjectBounds()
```

```csharp
private void UpdateHabsWithinObjectBounds()
```

```csharp
public void SetSelected(bool selected)
```

```csharp
public void AssignAnimationToHighlightSprite(int animationValue)
```

```csharp
public void StartHighlightAnimation()
```

```csharp
public void StopHighlightAnimation()
```

```csharp
public void SetButtonTexture(Sprite newTexture)
```

```csharp
private float GetCanvasScaleSize()
```

```csharp
private void OnUIScaleChanged(UIScaleSettingChange e)
```

```csharp
private void UpdateUIScale()
```

```csharp
private void OnFireMissionOrderReceived(FireMissionOrder e)
```

```csharp
private void SetProspectedStatusIcon(FactionExplorationRangeChanged e)
```

```csharp
private void SetProspectedStatusIcon(ProspectingBody e)
```

```csharp
private void SetProspectedStatusIcon(SpaceBodyProspected e)
```

```csharp
private void SetProspectedStatusIcon(ResetProspectSymbols e)
```

```csharp
private void SetShowName(ResetShowAllColonizedNames e)
```

```csharp
private void SetPlayerTagIcon(SpaceBodyTagChanged e)
```

```csharp
private void SetPlayerTagIcon()
```

```csharp
private void SetProspectedStatusIcon()
```

```csharp
private void UpdateAssaultCarrierIcon()
```
