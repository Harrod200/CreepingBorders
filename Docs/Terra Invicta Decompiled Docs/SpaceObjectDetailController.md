# SpaceObjectDetailController

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceObjectDetailController.cs`.*


## Class `SpaceObjectDetailController`

```csharp
public class SpaceObjectDetailController : CanvasControllerBase
```

### Fields

| Name | Type |
|---|---|
| `UIOtherSelectedState` | private TIGameState |
| `UISelectedAssetState` | private TIGameState |
| `DisplayExtendedFleetUI` | public static bool |
| `selectionCamera` | public GameObject |
| `mySelectedObjectCamera` | public GameObject |
| `selectedSpaceObject` | private TIGameState |
| `selectedAsset` | private TISpaceFleetState |
| `naturalBodyPanel` | public Canvas |
| `enemySpaceFleetPanel` | public Canvas |
| `mySpaceFleetPanel` | public Canvas |
| `habPanel` | public Canvas |
| `lagrangePointPanel` | public Canvas |
| `spacebodyUITutorialController` | public UITutorialController |
| `lagrangeUITutorialController` | public UITutorialController |
| `habUITutorialController` | public UITutorialController |
| `enemyFleetUITutorialController` | public UITutorialController |
| `spaceBodyName` | public TMP_Text |
| `gotoButton` | public Button |
| `backButtonNaturalSpacebodyDetail` | public GameObject |
| `naturalSpaceBodyBackgroundImage` | public Image |
| `gotoParentButton` | public GameObject |
| `parentIcon` | public Image |
| `naturalSpaceBodyQuickDescription` | public TMP_Text |
| `naturalSpaceBodyMiningProfile` | public TMP_Text |
| `naturalSpaceBodyDiameter` | public TMP_Text |
| `naturalSpaceBodyOrbit` | public TMP_Text |
| `naturalSpaceBodyLaunchWindow` | public TMP_Text |
| `naturalSpaceBodyEscapeVelocity` | public TMP_Text |
| `naturalSpaceBodySurfaceGravity` | public TMP_Text |
| `naturalSpaceBodyOrbitPeriod` | public TMP_Text |
| `diameterTip` | public TooltipTrigger |
| `orbitTip` | public TooltipTrigger |
| `gravityTip` | public TooltipTrigger |
| `escapeVelocityTip` | public TooltipTrigger |
| `orbitPeriodTip` | public TooltipTrigger |
| `satellitesButton` | public Button |
| `baseSitesButton` | public Button |
| `orbitsButton` | public Button |
| `councilorsButton` | public Button |
| `fleetsButton` | public Button |
| `stationsButton` | public Button |
| `satellitesTabHeader` | public TMP_Text |
| `baseSitesTabHeader` | public TMP_Text |
| `orbitsTabHeader` | public TMP_Text |
| `stationsTabHeader` | public TMP_Text |
| `councilorsTabHeader` | public TMP_Text |
| `fleetsTabHeader` | public TMP_Text |
| `solarIcon` | public Image |
| `solarTip` | public TooltipTrigger |
| `atmoIcon` | public Image |
| `atmoTip` | public TooltipTrigger |
| `waterIcon` | public Image |
| `volatilesIcon` | public Image |
| `metalsIcon` | public Image |
| `noblesIcon` | public Image |
| `fissilesIcon` | public Image |
| `solarPotential` | public Image |
| `waterPotential` | public Image |
| `volatilesPotential` | public Image |
| `metalsPotential` | public Image |
| `noblesPotential` | public Image |
| `fissilesPotential` | public Image |
| `solarPotentialObject` | public GameObject |
| `waterPotentialObject` | public GameObject |
| `volatilesPotentialObject` | public GameObject |
| `metalsPotentialObject` | public GameObject |
| `noblesPotentialObject` | public GameObject |
| `fissilesPotentialObject` | public GameObject |
| `naturalBodyTabContainer` | public GameObject |
| `naturalBodyTabManager` | public TabbedPaneManager |
| `orbitsTab` | public TabbedPaneController |
| `moonsTab` | public TabbedPaneController |
| `councilorsTab` | public TabbedPaneController |
| `sitesTab` | public TabbedPaneController |
| `fleetsTab` | public TabbedPaneController |
| `stationsTab` | public TabbedPaneController |
| `moonsHeaderName` | public TMP_Text |
| `moonsHeaderType` | public TMP_Text |
| `moonsHeaderBases` | public TMP_Text |
| `showSiteNames` | private bool |
| `sitesHeaderName` | public TMP_Text |
| `natural_orbitHeaderName` | public TMP_Text |
| `natural_orbitHeaderAltitude` | public TMP_Text |
| `stationHeaderName` | public TMP_Text |
| `stationHeaderAltitude` | public TMP_Text |
| `stationHeaderControlPoints` | public TMP_Text |
| `moonList` | public ListManagerBase |
| `siteList` | public ListManagerBase |
| `orbitsList` | public ListManagerBase |
| `stationList` | public ListManagerBase |
| `fleetList` | public ListManagerBase |
| `councilorList` | public ListManagerBase |
| `councilorHeaderName` | public TMP_Text |
| `councilorHeaderLocation` | public TMP_Text |
| `fleetName` | public TMP_Text |
| `fleetAltitude` | public TMP_Text |
| `fleetDVHeader` | public TMP_Text |
| `fleetSmallShipsHeader` | public TMP_Text |
| `fleetMediumShipsHeader` | public TMP_Text |
| `fleetLargeShipsHeader` | public TMP_Text |
| `natural_orbitHeaderGs` | public TooltipTrigger |
| `natural_amatHeader` | public TooltipTrigger |
| `probeDataPanel` | public GameObject |
| `probeIcon` | public Image |
| `probeArrivalDate` | public TMP_Text |
| `populationPanel` | public GameObject |
| `populationValue` | public TMP_Text |
| `maxTierIcon` | public Image |
| `maxTierTip` | public TooltipTrigger |
| `habSiteHohmannTip` | public TooltipTrigger |
| `playerTagButtonImage` | public Image |
| `enemyFleetHeader` | public TMP_Text |
| `enemyFleetName` | public TMP_Text |
| `enemyFleetFactionIcon` | public Image |
| `enemyFleetFactionGradient` | public Image |
| `backButtonEnemyFleetDetail` | public GameObject |
| `enemyFleetSize` | public TMP_Text |
| `enemyFleetAcceleration` | public TMP_Text |
| `enemyFleetDeltaV` | public TMP_Text |
| `enemyFleetCombatScore` | public TMP_Text |
| `enemyFleetAssaultScore` | public TMP_Text |
| `enemyFleetTransferProgressLine` | public RectTransform |
| `enemyFleetTransferSliderRange` | private float |
| `enemyFleetTransferSliderZeroPoint` | private float |
| `enemyTransferOriginIcon` | public Image |
| `enemyTransferDestinationIcon` | public Image |
| `enemyTransferDestinationDetailIcon` | public Image |
| `enemyTransferProgressIcon` | public Image |
| `enemyTransferPendingCombatIcon` | public Image |
| `enemyTransferTextDetail` | public TMP_Text |
| `enemyGenericOpImage` | public Image |
| `enemyGenericOpSmallImage` | public Image |
| `enemyGenericOpLine1` | public TMP_Text |
| `enemyGenericOpLine2` | public TMP_Text |
| `enemyTransferObject` | public GameObject |
| `enemyGenericOpDetailObject` | public GameObject |
| `enemyFleetShipsGridList` | public ListManagerBase |
| `enemyFleetShipsTabButtonText` | public TMP_Text |
| `enemyFleetRawCameraImageObject` | public GameObject |
| `enemyFleetBackgroundImage` | public Image |
| `enemyFleetShipListOpen` | private bool |
| `eo1` | private TIGameState |
| `eo2` | private TIGameState |
| `ed1` | private TIGameState |
| `ed2` | private TIGameState |
| `enemyShipListObject` | public GameObject |
| `enemyFleetUpperPanelTransform` | public RectTransform |
| `enemyShipListTransform` | public RectTransform |
| `enemyFleetCouncilorsGrid` | public ListManagerBase |
| `enemyFleetDetailList` | public ListManagerBase |
| `alertFleetButtonContainerObject` | public GameObject |
| `alertFleetButtonText` | public TMP_Text |
| `alertFleetButtonTip` | public TooltipTrigger |
| `myFleetHeader` | public TMP_Text |
| `myFleetAcceleration` | public TMP_Text |
| `myFleetDeltaV` | public TMP_Text |
| `myFleetSize` | public TMP_Text |
| `myFleetCombatScore` | public TMP_Text |
| `myFleetAssaultScore` | public TMP_Text |
| `myFleetMissionControlConsumption` | public TMP_Text |
| `myFleetHomeportObject` | public GameObject |
| `myFleetHomeport` | public TMP_Text |
| `myFleetName` | public TMP_Text |
| `myFleetCouncilIcon` | public Image |
| `myFleetCouncilGradient` | public Image |
| `myFleetRefitButton` | public Button |
| `myFleetRefitButtonText` | public TMP_Text |
| `validRefitFleet` | private TISpaceFleetState |
| `transferObject` | public GameObject |
| `transferOriginIcon` | public Image |
| `transferDestinationIcon` | public Image |
| `transferDestinationDetailIcon` | public Image |
| `myFleetTransferProgressLine` | public RectTransform |
| `myFleetTransferSliderZeroPoint` | private float |
| `myFleetTransferSliderRange` | private float |
| `transferProgressIcon` | public Image |
| `transferPendingCombatIcon` | public Image |
| `transferTextDetail` | public TMP_Text |
| `genericOpDetailObject` | public GameObject |
| `genericOpImage` | public Image |
| `genericOpSmallImage` | public Image |
| `genericOpLine1` | public TMP_Text |
| `genericOpLine2` | public TMP_Text |
| `fleetStandingOrderObject` | public GameObject |
| `myFleetShipsGridList` | public ListManagerBase |
| `myFleetShipsTabButtonText` | public TMP_Text |
| `myFleetShipsFullList` | public ListManagerBase |
| `playerFleetShipListOpen` | private bool |
| `pusherObject` | public GameObject |
| `pusherTransform` | public RectTransform |
| `upperPanelTransform` | public RectTransform |
| `shipListObject` | public GameObject |
| `shipListTransform` | public RectTransform |
| `myFleetRawCameraImageObject` | public GameObject |
| `myFleetBackgroundImage` | public Image |
| `myFleetCouncilorsGrid` | public ListManagerBase |
| `d1` | private TIGameState |
| `d2` | private TIGameState |
| `o1` | private TIGameState |
| `o2` | private TIGameState |
| `renameMyFleetPanel` | public GameObject |
| `saveNameText` | public TextMeshProUGUI |
| `revertNameText` | public TextMeshProUGUI |
| `nameInputField` | public TMP_InputField |
| `habHeaderText` | public TMP_Text |
| `habName` | public TMP_Text |
| `gotoHabParentButton` | public Button |
| `sellSpaceResourcesButton` | public Button |
| `backButtonHabDetail` | public GameObject |
| `habParentIcon` | public Image |
| `habCoreDefendInterest` | public GameObject |
| `habSizeDescriptor` | public TMP_Text |
| `habOrbitDescriptor` | public TMP_Text |
| `habSectorsTabButtonText` | public TMP_Text |
| `habCouncilorsTabButtonText` | public TMP_Text |
| `habDockedfleetsTabButtonText` | public TMP_Text |
| `habCouncilorsTabButtonObject` | public GameObject |
| `habDockedFleetsTabButtonObject` | public GameObject |
| `habSectorFactionImages` | public Image[] |
| `activePlayerShipyard` | public GameObject |
| `activePlayerResupply` | public GameObject |
| `activePlayerConstruction` | public GameObject |
| `activePlayerSellResourcesButtonObject` | public GameObject |
| `baseIllustrationObject` | public GameObject |
| `habCombatScore` | public TMP_Text |
| `habAssaultScore` | public TMP_Text |
| `assaultCombatTip` | public TooltipTrigger |
| `habBackgroundImage` | public Image |
| `S0M0` | public Image |
| `S0M1` | public Image |
| `S0M2` | public Image |
| `S0M3` | public Image |
| `S0M4` | public Image |
| `S1M0` | public Image |
| `S1M1` | public Image |
| `S1M2` | public Image |
| `S1M3` | public Image |
| `S2M0` | public Image |
| `S2M1` | public Image |
| `S2M2` | public Image |
| `S2M3` | public Image |
| `S3M0` | public Image |
| `S3M1` | public Image |
| `S3M2` | public Image |
| `S3M3` | public Image |
| `S4M0` | public Image |
| `S4M1` | public Image |
| `S4M2` | public Image |
| `S4M3` | public Image |
| `C034T` | public Image |
| `C04T` | public Image |
| `C03T` | public Image |
| `C24C` | public Image |
| `C13C` | public Image |
| `habRawImageObject` | public GameObject |
| `sectorsList` | public ListManagerBase |
| `habCouncilorsListManager` | public ListManagerBase |
| `habFleetsListManager` | public ListManagerBase |
| `habPaneManager` | public TabbedPaneManager |
| `sectorsPaneController` | public TabbedPaneController |
| `habCouncilorsPaneController` | public TabbedPaneController |
| `habFleetsPaneController` | public TabbedPaneController |
| `habSectorHeaderName` | public TMP_Text |
| `habCouncilorHeaderLocation` | public TMP_Text |
| `hab_fleetName` | public TMP_Text |
| `hab_fleetAltitudeHeader` | public TMP_Text |
| `hab_fleetDVHeader` | public TMP_Text |
| `hab_fleetSmallShipsHeader` | public TMP_Text |
| `hab_fleetMediumShipsHeader` | public TMP_Text |
| `hab_fleetLargeShipsHeader` | public TMP_Text |
| `habGravityPanel` | public GameObject |
| `localgravity_gs` | public TMP_Text |
| `localGravityTip` | public TooltipTrigger |
| `renameHabPanel` | public GameObject |
| `saveHabNameText` | public TextMeshProUGUI |
| `revertHabNameText` | public TextMeshProUGUI |
| `habNameInputField` | public TMP_InputField |
| `lagrangePointName` | public TMP_Text |
| `lagrangeOrbitRadius` | public TMP_Text |
| `lagrangeDescription` | public TMP_Text |
| `lagrangeDescriptionLine2` | public TMP_Text |
| `lagrangePointNextLaunchWindow` | public TMP_Text |
| `lagrangeOrbitsList` | public ListManagerBase |
| `lagrangeStationsList` | public ListManagerBase |
| `lagrangeCouncilorsList` | public ListManagerBase |
| `lagrangeFleetsList` | public ListManagerBase |
| `lagrangeStationsTabHeader` | public TMP_Text |
| `lagrangeOrbitsTabHeader` | public TMP_Text |
| `lagrangeCouncilorsTabHeader` | public TMP_Text |
| `lagrangeFleetsTabHeader` | public TMP_Text |
| `lagrangeOrbitsTabButton` | public Button |
| `lagrangeFleetsTabButton` | public Button |
| `lagrangeCouncilorsTabButton` | public Button |
| `lagrangeStationsTabButton` | public Button |
| `backButtonLagrangeDetail` | public GameObject |
| `lagrangeTabbedPaneManager` | public TabbedPaneManager |
| `lagrangeOrbitsTab` | public TabbedPaneController |
| `lagrangeFleetsTab` | public TabbedPaneController |
| `lagrangeCouncilorsTab` | public TabbedPaneController |
| `lagrangeStationsTab` | public TabbedPaneController |
| `gotoLagrangeParentButton` | public Button |
| `gotoLagrangeSecondaryButton` | public Button |
| `lagrangeParentIcon` | public Image |
| `lagrangeSecondaryIcon` | public Image |
| `lagrangeOrbitTooltip` | public TooltipTrigger |
| `lagrange_orbitHeaderName` | public TMP_Text |
| `lagrange_orbitHeaderAltitude` | public TMP_Text |
| `lagrange_orbitHeaderGs` | public TooltipTrigger |
| `lagrange_orbitHeaderAMAT` | public TooltipTrigger |
| `lagrange_stationHeaderName` | public TMP_Text |
| `lagrange_stationHeaderAltitude` | public TMP_Text |
| `lagrange_stationHeaderControlPoints` | public TMP_Text |
| `lagrange_councilorHeaderName` | public TMP_Text |
| `lagrange_councilorHeaderLocation` | public TMP_Text |
| `lp_fleetName` | public TMP_Text |
| `lp_fleetAltitudeHeader` | public TMP_Text |
| `lp_fleetDVHeader` | public TMP_Text |
| `lp_fleetSmallShipsHeader` | public TMP_Text |
| `lp_fleetMediumShipsHeader` | public TMP_Text |
| `lp_fleetLargeShipsHeader` | public TMP_Text |
| `lp_populationPanel` | public GameObject |
| `lp_populationValue` | public TMP_Text |
| `lp_maxTierIcon` | public Image |
| `lp_maxTierTip` | public TooltipTrigger |
| `lagrangeSolarPotential` | public Image |
| `lagrangeSolarTip` | public TooltipTrigger |
| `selectionCameraInstance` | private GameObject |
| `previewPosition` | private GameObject |
| `modelInstance` | private GameObject |
| `originalPreviewPosition` | private Vector3 |
| `originalPreviewRotation` | private Vector3 |
| `modelRotationRate` | private float |
| `modelRotationAxis` | private Vector3 |
| `infoPanelImageState` | private TIGameState |
| `assetCameraInstance` | private GameObject |
| `assetPosition` | private GameObject |
| `assetModelInstance` | private GameObject |
| `originalAssetPreviewPosition` | private Vector3 |
| `originalAssetPreviewRotation` | private Vector3 |
| `assetPanelImageState` | private TIGameState |
| `previousSpacebodies` | private List<TISpaceObjectState> |
| `myFleetDataDirtyMajor` | private bool |
| `myFleetDataDirtyMinor` | private bool |
| `enemyFleetDataDirtyMajor` | private bool |
| `enemyFleetDataDirtyMinor` | private bool |
| `spaceBodyDataDirtyMajor` | private bool |
| `spaceBodyDataDirtyMinor` | private bool |
| `habDataDirtyMajor` | private bool |
| `habDataDirtyMinor` | private bool |
| `lagrangeDataDirtyMinor` | private bool |
| `DebugPanel` | public GameObject |
| `DebugText` | public TMP_Text |

### Methods

```csharp
public override void Initialize()
```

```csharp
public override void Show()
```

```csharp
public override void Hide()
```

```csharp
public override void Refresh()
```

```csharp
private void OnInfoScreenOpened(InfoScreenOpened e)
```

```csharp
private void RestoreSpaceObjectDetailCanvas(InfoScreenClosed e)
```

```csharp
private void OnGameStateArchived(GameStateArchived e)
```

```csharp
private void SetAllDirty()
```

```csharp
private void OnMajorMyFleetUpdate(ShipsAddedToFleet e)
```

```csharp
private void OnMajorMyFleetUpdate(ShipsRemovedFromFleet e)
```

```csharp
private void OnMajorMyFleetUpdate(CombatEnds e)
```

```csharp
private void OnMyFleetUpdate(StartFleetOperation e)
```

```csharp
private void OnMyFleetUpdate(OperationExecuted e)
```

```csharp
private void OnMyFleetUpdate(FleetArrivesAtDestination e)
```

```csharp
private void OnMyFleetUpdate(CouncilorDepartsShip e)
```

```csharp
private void OnMyFleetUpdate(CouncilorVisibilityChanged e)
```

```csharp
private void OnMyFleetUpdate(CouncilorPositionUpdated e)
```

```csharp
private void OnMyFleetUpdate(ShipResupplied e)
```

```csharp
private void OnMyFleetUpdate(FleetUndocks e)
```

```csharp
private void OnMyFleetUpdate(FleetAvailabilityChange e)
```

```csharp
private void OnMyFleetUpdate(FleetOperationWithDurationComplete e)
```

```csharp
private void OnMyFleetUpdate(ShipSystemDamageChange e)
```

```csharp
public void AddMyFleetListeners()
```

```csharp
public void RemoveMyFleetListeners()
```

```csharp
private void OnMajorEnemyFleetUpdate(ShipsAddedToFleet e)
```

```csharp
private void OnMajorEnemyFleetUpdate(ShipsRemovedFromFleet e)
```

```csharp
private void OnMajorEnemyFleetUpdate(CombatEnds e)
```

```csharp
private void OnEnemyFleetUpdate(StartFleetOperation e)
```

```csharp
private void OnEnemyFleetUpdate(OperationExecuted e)
```

```csharp
private void OnEnemyFleetUpdate(FleetArrivesAtDestination e)
```

```csharp
private void OnEnemyFleetUpdate(CouncilorDepartsShip e)
```

```csharp
private void OnEnemyFleetUpdate(CouncilorVisibilityChanged e)
```

```csharp
private void OnEnemyFleetUpdate(CouncilorPositionUpdated e)
```

```csharp
private void OnEnemyFleetUpdate(ShipResupplied e)
```

```csharp
private void OnEnemyFleetUpdate(FleetUndocks e)
```

```csharp
private void OnEnemyFleetUpdate(FleetAvailabilityChange e)
```

```csharp
private void OnEnemyFleetUpdate(FleetOperationWithDurationComplete e)
```

```csharp
private void OnEnemyFleetShipDamaged(ShipSystemDamageChange e)
```

```csharp
private void AddEnemyFleetListeners()
```

```csharp
private void RemoveEnemyFleetListeners()
```

```csharp
private void OnSpaceBodyUpdate(HabCreated e)
```

```csharp
private void OnSpaceBodyUpdate(HabDestroyed e)
```

```csharp
private void OnSpaceBodyUpdate(HabModuleConstructionStatusChange e)
```

```csharp
private void OnSpaceBodyUpdate(SectorAssignedToFaction e)
```

```csharp
private void OnSpaceBodyUpdate(HabModuleDestroyed e)
```

```csharp
private void OnSpaceBodyUpdate(CouncilorVisibilityChanged e)
```

```csharp
private void OnSpaceBodyUpdate(CouncilorPositionUpdated e)
```

```csharp
private void OnSpaceBodyUpdate(ProspectingBody e)
```

```csharp
private void OnSpaceBodyUpdate(SpaceBodyProspected e)
```

```csharp
private void OnSpaceBodyUpdate(FleetArrivesAtDestination e)
```

```csharp
private void OnSpaceBodyUpdate(ShipsAddedToFleet e)
```

```csharp
private void OnSpaceBodyUpdate(ShipsRemovedFromFleet e)
```

```csharp
private void OnSpaceBodyUpdate(FleetUndocks e)
```

```csharp
private void OnSpaceBodyUpdate(SpaceBodyTagChanged e)
```

```csharp
private void OnSpaceBodyUpdate(BeginBombardment e)
```

```csharp
private void OnSpaceBodyUpdate(EndBombardment e)
```

```csharp
private void OnSpaceBodyUpdate(BeginHabAssault e)
```

```csharp
private void OnSpaceBodyUpdate(EndHabAssault e)
```

```csharp
private void AddNaturalSpaceBodyListeners()
```

```csharp
private void RemoveNaturalSpaceBodyListeners()
```

```csharp
private void OnHabStructureUpdate(HabModuleConstructionStatusChange e)
```

```csharp
private void OnHabStructureUpdate(HabModuleDestroyed e)
```

```csharp
private void OnHabStructureUpdate(HabDestroyed e)
```

```csharp
private void OnHabUpdate(FleetArrivesAtDestination e)
```

```csharp
private void OnHabUpdate(FleetUndocks e)
```

```csharp
private void OnHabUpdate(FleetDisbanded e)
```

```csharp
private void OnHabUpdate(SectorAssignedToFaction e)
```

```csharp
private void OnHabUpdate(CouncilorDepartsHab e)
```

```csharp
private void OnHabUpdate(CouncilorVisibilityChanged e)
```

```csharp
private void OnHabUpdate(CouncilorPositionUpdated e)
```

```csharp
private void OnHabUpdate(HabDefendInterestsUpdated e)
```

```csharp
private void OnHabUpdate(BeginBombardment e)
```

```csharp
private void OnHabUpdate(EndBombardment e)
```

```csharp
private void OnHabUpdate(BeginHabAssault e)
```

```csharp
private void OnHabUpdate(EndHabAssault e)
```

```csharp
private void AddHabListeners()
```

```csharp
private void RemoveHabListeners()
```

```csharp
private void OnLagrangePointUpdate(HabCreated e)
```

```csharp
private void OnLagrangePointUpdate(HabDestroyed e)
```

```csharp
private void OnLagrangePointUpdate(HabModuleConstructionStatusChange e)
```

```csharp
private void OnLagrangePointUpdate(SectorAssignedToFaction e)
```

```csharp
private void OnLagrangePointUpdate(HabModuleDestroyed e)
```

```csharp
private void OnLagrangePointUpdate(CouncilorVisibilityChanged e)
```

```csharp
private void OnLagrangePointUpdate(CouncilorPositionUpdated e)
```

```csharp
private void OnLagrangePointUpdate(FleetArrivesAtDestination e)
```

```csharp
private void OnLagrangePointUpdate(ShipsAddedToFleet e)
```

```csharp
private void OnLagrangePointUpdate(ShipsRemovedFromFleet e)
```

```csharp
private void OnLagrangePointUpdate(FleetUndocks e)
```

```csharp
private void OnLagrangePointUpdate(BeginHabAssault e)
```

```csharp
private void OnLagrangePointUpdate(EndHabAssault e)
```

```csharp
private void AddLagrangePointListeners()
```

```csharp
private void RemoveLagrangePointListeners()
```

```csharp
public void NaturalBodyExitButtonClicked()
```

```csharp
public void EnemyFleetExitButtonClicked()
```

```csharp
public void HabExitButtonClicked()
```

```csharp
public void LagrangePointExitButtonClicked()
```

```csharp
public void MyFleetExitButtonClicked()
```

```csharp
public void GotoOtherButtonClicked()
```

```csharp
public void GotoMyButtonClicked()
```

```csharp
public void GotoParentButtonClicked()
```

```csharp
public void GotoSecondaryButtonClicked()
```

```csharp
private void CheckForCloseCanvas()
```

```csharp
public void ViewSpaceObject(TISpaceObjectState spaceObject, bool updatePrevious = true)
```

```csharp
public void ViewSpaceObject(GameObject selectedObject)
```

```csharp
private void LaunchDetailPlayerFleet(TISpaceFleetState fleet)
```

```csharp
private void DisablePlayerFleetPanel()
```

```csharp
private void LaunchDetailEnemyFleet(TISpaceFleetState fleet)
```

```csharp
private void DisableEnemyFleetPanel()
```

```csharp
private void LaunchNaturalSpaceBodyDetail(TISpaceBodyState spaceBody)
```

```csharp
private void DisableNaturalSpaceBodyPanel()
```

```csharp
private void LaunchDetailLagrangePoint(TILagrangePointState lagrangePoint)
```

```csharp
private void DisableLagrangePointPanel()
```

```csharp
private void LaunchDetailHab(TIHabState hab)
```

```csharp
private void DisableHabPanel()
```

```csharp
public void HideTutorials()
```

```csharp
private void SetRotationRate()
```

```csharp
private Image BaseModuleIcon(int sector, int moduleNum)
```

```csharp
public static void TurnOffNaughtyShaderForUI(GameObject gameObject)
```

```csharp
private void UpdateInfoPanelImage(TISpaceObjectState spaceObjectState, bool forceUpdate = false)
```

```csharp
public void UpdateAssetPanelImage(TISpaceFleetState fleet, bool forceUpdate = false)
```

```csharp
public static Sprite GetParentBodyIconResource(TISpaceFleetState fleet, out TIGameState parentState)
```

```csharp
public void OnClickRename(int which)
```

```csharp
public void OnClickRevertRename()
```

```csharp
public void RevertRename()
```

```csharp
public void OnClickSaveName()
```

```csharp
public void ShowRenameMyFleetPanel()
```

```csharp
public void OnClickHabRename()
```

```csharp
public void OnClickRevertHabRename()
```

```csharp
public void RevertHabRename()
```

```csharp
public void OnClickSaveHabName()
```

```csharp
public void ShowRenameMyHabPanel()
```

```csharp
public void OnSelectInputBox()
```

```csharp
public void OnDeSelectInputBox()
```

```csharp
public void CleanupTextures()
```

```csharp
public static void UpdatePendingCombatIcon(Image icon, TISpaceFleetState fleet)
```

```csharp
private void UpdateEnemyFleetTransferData(TISpaceFleetState fleet)
```

```csharp
private void UpdateEnemyFleetObjectCanvas(TISpaceFleetState fleet)
```

```csharp
public void OnEnemyFleetImagePressed()
```

```csharp
public void OnPressEnemyFleetShipsDetailButton()
```

```csharp
public void OnEnemyFleetTransferOriginClicked()
```

```csharp
public void OnEnemyFleetDestinationClicked()
```

```csharp
public void OnEnemyFleetSpecificDestinationClicked()
```

```csharp
public void OnEnemyFleetOpLocationClicked()
```

```csharp
public void OnEnemyFleetSmallOpLocationClicked()
```

```csharp
public void OnAlertFleetClicked()
```

```csharp
public static bool CreateFleetAlarm(TIFactionState settingPlayer, TISpaceFleetState enemyFleet)
```

```csharp
public static string GetFleetAlarmText(TIFactionState settingPlayer, TISpaceFleetState enemyFleet)
```

```csharp
public void OnFleetAlarmTriggered(AlarmTriggered e)
```

```csharp
private void UpdatePlayerFleetTransferData(TISpaceFleetState playerFleet)
```

```csharp
private void UpdatePlayerFleetObjectCanvas(TISpaceFleetState playerFleet)
```

```csharp
public void RefitMyFleet()
```

```csharp
public static string FleetTransferTwoLiner(TISpaceFleetState fleet, bool obfuscate)
```

```csharp
public void OnPressPlayerFleetShipsDetailButton()
```

```csharp
public void CycleSiteHeader()
```

```csharp
public void OnMyFleetImageClicked()
```

```csharp
public void OnMyFleetTransferOriginClicked()
```

```csharp
public void OnMyFleetDestinationClicked()
```

```csharp
public void OnMyFleetSpecificDestinationClicked()
```

```csharp
public void OnMyFleetOpLocationClicked()
```

```csharp
public void OnMyFleetSmallOpLocationClicked()
```

```csharp
public void OnMyHomeportClicked()
```

```csharp
private void UpdateNaturalSpaceBodyCanvasTransientData(TISpaceBodyState spaceBody)
```

```csharp
private void UpdateNaturalSpaceObjectLaunchWindowData(TINaturalSpaceObjectState spaceObject, TMP_Text text)
```

```csharp
public static string SetTimePenaltyTip(TINaturalSpaceObjectState naturalObject)
```

```csharp
private void UpdateNaturalSpaceBodyCanvas(TISpaceBodyState spaceBody)
```

```csharp
private void AddClickedPreviousSpacebody(TISpaceObjectState spaceObject)
```

```csharp
public void OnClickNaturalSpacebodyBack()
```

```csharp
private void UpdateSpaceObjectBackButtons()
```

```csharp
private void SetPlanetTag()
```

```csharp
public void OnClickPlanetTag()
```

```csharp
private void UpdateLagrangePointCanvasTransientData(TILagrangePointState lagrangePoint)
```

```csharp
private void UpdateLagrangePointCanvas(TILagrangePointState lagrangePoint)
```

```csharp
public static string SpaceBodyDiameterText(TISpaceBodyState spaceBodyState)
```

```csharp
public static string OrbitAxisText(TISpaceBodyState spaceBodyState)
```

```csharp
public static string OrbitPeriodText(TISpaceBodyState spaceBody)
```

```csharp
private void UpdateMoonList(TISpaceBodyState spaceBodyState, List<TISpaceBodyState> moons)
```

```csharp
private void UpdateSiteList(List<TIHabSiteState> habSites)
```

```csharp
private void UpdateOrbitsList(ListManagerBase orbitsList, List<TIOrbitState> orbits)
```

```csharp
private void UpdateStationsList(ListManagerBase stationsList, List<TIHabState> stations)
```

```csharp
private void UpdateCouncilorsList(ListManagerBase councilorsList, List<TICouncilorState> councilors, List<TIOfficerState> officers, bool showProfession)
```

```csharp
private void UpdateFleetsList(ListManagerBase fleetsList, List<TISpaceFleetState> fleets)
```

```csharp
public void OnShipyardButtonClicked()
```

```csharp
public void OnSellSpaceResourcesClicked()
```

```csharp
private void UpdateHabCanvas(TIHabState hab)
```

```csharp
private static string SemimajorAxisTooltip(TISpaceBodyState spaceBodyState)
```

```csharp
private static string OrbitalPeriodTooltip(TISpaceBodyState body)
```

```csharp
private void UpdateHabSectorsList(TIHabState hab)
```

```csharp
public void HabImageClicked()
```

```csharp
public void HabSelectedFromSiteList(TIHabState hab)
```

```csharp
private void LateUpdate()
```

```csharp
public override void UpdateUIScaling()
```
