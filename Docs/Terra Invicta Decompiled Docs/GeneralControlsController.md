# GeneralControlsController

*Decompiled from `PavonisInteractive/TerraInvicta/GeneralControlsController.cs`.*


## Class `GeneralControlsController`

```csharp
public class GeneralControlsController : CanvasControllerBase, IHud, ICanvas
```

### Fields

| Name | Type |
|---|---|
| `finderLargeUIScaleHeightFactor` | private float |
| `finderMaxItems` | private int |
| `targetingPanelMaxItems` | private int |
| `ChatAnimatorIsPlaying` | private bool |
| `showMonthlyIncomes` | private static bool |
| `alienThreatTip` | public string |
| `factionIcon` | public Image |
| `objectivesTooltipTrigger` | public TooltipTrigger |
| `mainHUDTutorialController` | public UITutorialController |
| `introTutorialNewController` | public UITutorialController |
| `sellResourcesTutorialController` | public UITutorialController |
| `fakeTutorialWindow` | public GameObject |
| `introOptinHighlightDummy` | public GameObject |
| `incomeInfoText` | public TMP_Text |
| `moneyTooltipTrigger` | public TooltipTrigger |
| `influenceInfoText` | public TMP_Text |
| `influenceTooltipTrigger` | public TooltipTrigger |
| `operationInfoText` | public TMP_Text |
| `opsTooltipTrigger` | public TooltipTrigger |
| `researchInfoText` | public TMP_Text |
| `researchTooltipTrigger` | public TooltipTrigger |
| `controlPointImage` | public Image |
| `controlPointMaintenanceText` | public TMP_Text |
| `controlPointMaintenanceTrigger` | public TooltipTrigger |
| `boostInfoText` | public TMP_Text |
| `boostTooltipTrigger` | public TooltipTrigger |
| `missionControlInfoText` | public TMP_Text |
| `missionControlTooltipTrigger` | public TooltipTrigger |
| `waterInfoText` | public TMP_Text |
| `waterTooltipTrigger` | public TooltipTrigger |
| `volatilesInfoText` | public TMP_Text |
| `volatilesTooltipTrigger` | public TooltipTrigger |
| `baseMetalsInfoText` | public TMP_Text |
| `baseMetalsTooltipTrigger` | public TooltipTrigger |
| `nobleMetalsInfoText` | public TMP_Text |
| `nobleMetalsTooltipTrigger` | public TooltipTrigger |
| `fissilesInfoText` | public TMP_Text |
| `fissilesTooltipTrigger` | public TooltipTrigger |
| `antimatterInfoText` | public TMP_Text |
| `antimatterTooltipTrigger` | public TooltipTrigger |
| `exoticsInfoText` | public TMP_Text |
| `exoticsTooltipTrigger` | public TooltipTrigger |
| `waterPanel` | public Transform |
| `volatilesPanel` | public Transform |
| `baseMetalsPanel` | public Transform |
| `nobleMetalsPanel` | public Transform |
| `fissilesPanel` | public Transform |
| `antimatterPanel` | public Transform |
| `exoticsPanel` | public Transform |
| `resourcesDataDirty` | private bool |
| `earthButtonTooltip` | public TooltipTrigger |
| `spaceButtonTooltip` | public TooltipTrigger |
| `councilButtonTooltip` | public TooltipTrigger |
| `nationsButtonTooltip` | public TooltipTrigger |
| `habsButtonTooltip` | public TooltipTrigger |
| `fleetsButtonTooltip` | public TooltipTrigger |
| `researchButtonTooltip` | public TooltipTrigger |
| `intelButtonTooltip` | public TooltipTrigger |
| `eventSummaryButtonTooltipExpand` | public TooltipTrigger |
| `eventSummaryButtonTooltipMinimize` | public TooltipTrigger |
| `techWinnerLights` | public Image[] |
| `techWinnerIndicators` | public Image[] |
| `timeText` | public TMP_Text |
| `dateText` | public TMP_Text |
| `speedText` | public TMP_Text |
| `speedPausedText` | public TMP_Text |
| `TimePipsList` | public ListManagerBase |
| `speedTooltipTrigger` | public TooltipTrigger |
| `pauseBlockedImage` | public Image |
| `displayedSimTime` | private DateTime |
| `finderCanvas` | public Canvas |
| `finderRootCanvas` | public Canvas |
| `finderTransform` | public RectTransform |
| `finderViewport` | public RectTransform |
| `finderContent` | public RectTransform |
| `finderListAdapter` | public FinderListAdapter |
| `finderListModels` | public List<FinderListItemModel> |
| `mapModeDropdown` | public TMP_Dropdown |
| `mapColorDescText` | public TMP_Text |
| `finderTitleText` | public TMP_Text |
| `mapColorControlPanel` | public GameObject |
| `MapModeFlagObject` | public GameObject |
| `MapModeEarthObject` | public GameObject |
| `MapModeFlagSprite` | public Image |
| `finderMinimizeButton` | public Button |
| `finderCouncilorsButton` | public Button |
| `finderArmiesButton` | public Button |
| `finderHabsButton` | public Button |
| `finderFleetsButton` | public Button |
| `finderFilterOffSprite` | public Sprite |
| `finderFilterOnSprite` | public Sprite |
| `finderSelectedIndex` | private int |
| `showFinderCouncilors` | private bool |
| `showFinderArmies` | private bool |
| `showFinderHabs` | private bool |
| `showFinderFleets` | private bool |
| `finderEditModeEnabled` | private bool |
| `storedFinderStatus` | private bool |
| `finderDataDirty` | private bool |
| `finderToggleExclusive` | private bool |
| `finderInit` | private bool |
| `targetingPanel` | public Canvas |
| `targetingPanelTransform` | public RectTransform |
| `targetingHeaderString` | public TMP_Text |
| `targetingHeaderTargetString` | public TMP_Text |
| `targetingList` | public ListManagerBase |
| `originalTarget` | private TIGameState |
| `currentTarget` | private TIGameState |
| `targetListForLocation` | private List<TIGameState> |
| `showAssignedCouncilorsInTargetingPanel` | private bool |
| `showAssignedCouncilorsText` | public TMP_Text |
| `notificationQueue` | private TINotificationQueueState |
| `councilorChatAnimator` | public Animator |
| `councilorChatImage` | public Image |
| `councilorChatText` | public TMP_Text |
| `resourceSalePanel` | public GameObject |
| `resourceSaleHeader` | public TMP_Text |
| `confirmSaleButtonText` | public TMP_Text |
| `resetButtonText` | public TMP_Text |
| `cancelButtonText` | public TMP_Text |
| `totalSaleText` | public TMP_Text |
| `totalSaleValueText` | public TMP_Text |
| `proposedResourceSales` | private Dictionary<FactionResource, int> |
| `resourceSalesList` | public ListManagerBase |
| `confirmSaleButton` | public Button |
| `alienThreatUITutorialController` | public UITutorialController |
| `alienThreatPanel` | public GameObject |
| `alienAlertAlienIcon` | public Image |
| `alienAlertLights` | public Image[] |
| `alienAlertTip` | public TooltipTrigger |
| `searchObject` | public GameObject |
| `globalSearchTextTitle` | public TMP_Text |
| `globalSearchListAdapter` | public GlobalSearchListAdapter |
| `globalSearchListItemModels` | public List<GlobalSearchListItemModel> |
| `searchInputField` | public TMP_InputField |
| `PauseButton` | public GameObject |
| `PlayButton` | public GameObject |
| `playButtonComponent` | public Button |
| `missionPhaseReportButtonExpand` | public GameObject |
| `missionPhaseReportButtonMinimize` | public GameObject |
| `milestonePanel` | public GameObject |
| `milestoneIcon` | public Image |
| `milestoneText` | public TMP_Text |
| `milestoneTooltip` | public TooltipTrigger |
| `openTutorialObject` | public List<GameObject> |
| `tutorialDescriptorText` | public List<TMP_Text> |
| `SystemClockObject` | public GameObject |
| `SystemClockText` | public TMP_Text |
| `notifications` | private NotificationScreenController |
| `heldTutorialItem` | public List<GeneralControlsController.HeldTutorialItem> |
| `isHoldingTutorial` | public bool |
| `mapColorationStyle` | public static MapColorationStyle |
| `infoScreenOpen` | private bool |
| `cameraManager` | private CameraManager |
| `comparer` | private static readonly GeneralControlsController.FinderItemComparer |
| `suppressCycleMapModeAudio` | private bool |
| `fewSecs` | private readonly WaitForSeconds |
| `finderPanelBaseSize` | private const int |
| `finderItemHeight` | private const int |
| `targetingPanelBaseSize` | private const int |
| `targetingPanelItemHeight` | private const int |
| `finderMaxHeightUltraWideReduction` | private const int |
| `finderMinMaxHeightToShutOff` | private const float |
| `finderMaxMaxHeight` | private const float |
| `finderMaxHeight` | public float |
| `frameCheckedStoredFinderStatus` | private int |
| `alarmPanel` | public GameObject |
| `alarmPanelHeader` | public TMP_Text |
| `alarmMinuteDropdown` | public TMP_Dropdown |
| `alarmHourDropdown` | public TMP_Dropdown |
| `alarmDayDropdown` | public TMP_Dropdown |
| `alarmMonthDropdown` | public TMP_Dropdown |
| `alarmYearDropdown` | public TMP_Dropdown |
| `resetProposedAlarmTimeButtonText` | public TMP_Text |
| `confirmAlarmAndCloseButtonText` | public TMP_Text |
| `confirmAlarmAndDoAnotherButtonText` | public TMP_Text |
| `cancelAlarmButtonText` | public TMP_Text |
| `confirmCloseButton` | public Button |
| `confirmContinueButton` | public Button |
| `decreaseMinuteButton` | public Button |
| `increaseMinuteButton` | public Button |
| `decreaseHourButton` | public Button |
| `increaseHourButton` | public Button |
| `decreaseDayButton` | public Button |
| `increaseDayButton` | public Button |
| `decreaseMonthButton` | public Button |
| `increaseMonthButton` | public Button |
| `decreaseYearButton` | public Button |
| `increaseYearButton` | public Button |
| `openCalendarButton` | public Button |
| `openCalendarButtonText` | public TMP_Text |
| `proposedAlarmTime` | private TIDateTime |
| `proposedAlarmText` | public TMP_InputField |
| `placeholderText` | public TMP_Text |
| `HeldTutorialItem` | public class |
| `heldTutorialController` | public UITutorialController |
| `heldTutorialMilestone` | public CampaignMilestone |
| `heldTutorialOverrideMilestone` | public bool |
| `heldTutorialNextFrame` | public bool |

### Properties

- `public static bool UIPlayerInTargetingMode`
- `public static TITargeting UITargetingMode`
- `public static TIGameState UISelectedAssetState`
- `public static TIGameState UIOtherSelectedState`
- `public static TIGameState UITargetedState`
- `public static GeneralControlsController Singleton`
- `public static Sprite redReticle`
- `public static Sprite cyanReticle`
- `public static Sprite greenReticle`

### Methods

```csharp
public override void Initialize()
```

```csharp
private void UpdateMapColorDropDownOptions()
```

```csharp
public override void UpdateActivePlayerUIElements(bool startup)
```

```csharp
public void OnStartupComplete(StartupComplete e)
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
public void Cleanup()
```

```csharp
public static bool ActivePlayerAsset(TIGameState state)
```

```csharp
private static bool SelectableState(TIGameState state)
```

```csharp
public static void SetSelectedState(TIGameState state, bool setTargetAsOther)
```

```csharp
public static void SetUIGlobalTargetingMode(TIGameState state, TITargeting targetingMode)
```

```csharp
public static void ShutdownUIGlobalTargetingMode(TIFactionState faction)
```

```csharp
public static void ConditionalCancelSelectedAsset(TIGameState state)
```

```csharp
public static void SetUISelectedAssetState(TIGameState state)
```

```csharp
public static void ConditionalCancelSelectedOtherState(TIGameState state)
```

```csharp
public static void SetUIOtherSelectedState(TIGameState state)
```

```csharp
public static void SetUITargetedState(TIGameState state)
```

```csharp
public static void UpdateBlockedPause()
```

```csharp
public static bool CurrentlyTargetingStateType(Type stateType)
```

```csharp
public static bool CurrentValidTarget(TIGameState state)
```

```csharp
public static bool IsMapColorationStyleNationMapMode(MapColorationStyle style)
```

```csharp
public void MainMenu()
```

```csharp
public void SolarSystem()
```

```csharp
public void PoliticalMap()
```

```csharp
public void Nations()
```

```csharp
public void Councilors()
```

```csharp
public void Research()
```

```csharp
public void Intel()
```

```csharp
public void Habitats()
```

```csharp
public void Fleets()
```

```csharp
public void Objectives()
```

```csharp
public void PauseSpeed()
```

```csharp
private IEnumerator DelayedUnpauseAssignmentPhaseEnd()
```

```csharp
public void PauseSpeedNoToggle()
```

```csharp
public void SetSpeed(int speedIndex)
```

```csharp
public void IncreaseSpeed()
```

```csharp
public void DecreaseSpeed()
```

```csharp
private bool NotificationDelayingSpeedChange()
```

```csharp
private void OnGameTimeSpeedChanged(GameTimeSpeedChanged e)
```

```csharp
private void OnBlockingPromptUpdated(BlockingPromptUpdated e)
```

```csharp
private void OnPromptQueueCleared(PromptQueueCleared e)
```

```csharp
private void OnHabConstructionStatusChanged(HabModuleConstructionStatusChange e)
```

```csharp
private IEnumerator CheckSellResourcesTutorialStartup()
```

```csharp
private void UpdateSpeed(SpeedSetting speed)
```

```csharp
private void UpdateSpeedText()
```

```csharp
private string SetSpeedTooltipTrigger()
```

```csharp
public void ToggleFPSWidget()
```

```csharp
public void ToggleMapColorControlPanel()
```

```csharp
public void CycleRecolorEarthMap(bool forward = true)
```

```csharp
private void RecolorEarthMap(MapColorationStyle colorMode)
```

```csharp
public void OnDropdownChangedMapColorMode(int mapMode)
```

```csharp
private void UpdateMapDropDownValue(int mapMode)
```

```csharp
public void SetColorMapByNation()
```

```csharp
public void SetColorMapByTerrain()
```

```csharp
public void SetColorMapByExecutiveFaction()
```

```csharp
public void SetColorMapByFactionPopularity()
```

```csharp
public void SetColorMapByPopulation()
```

```csharp
public void SetColorMapByInvestmentPoints()
```

```csharp
public void SetColorMapByPerCapitaGDP()
```

```csharp
public void SetColorMapByControlPoints()
```

```csharp
public void SetColorMapByMilitaryTechLevel()
```

```csharp
public void SetColorMapByBoostIncome()
```

```csharp
public void SetColorMapByUnrest()
```

```csharp
public void SetColorMapByDemocracy()
```

```csharp
public void SetColorMapBySustainability()
```

```csharp
public void SetColorMapByXenoformingLevel()
```

```csharp
public void SetColorMapByIsFederatedNation()
```

```csharp
public void SetColorMapBySelectedNationAlliances()
```

```csharp
public void SetColorMapBySelectedNationClaims()
```

```csharp
public void SetColorMapBySelectedNationFederation()
```

```csharp
public void SetColorMapBySelectedNationCanJoinFederation()
```

```csharp
public void SetSelectedNationFlag(TINationState nation)
```

```csharp
private void MapViewChanged(MapActivationChangedEvent e)
```

```csharp
public void ToggleOrbitTrails()
```

```csharp
public void ToggleDistantSymbols()
```

```csharp
public void ToggleProspectData()
```

```csharp
public void ToggleShowAllColonizedNames()
```

```csharp
public void OnClickResources()
```

```csharp
private bool IsButtonClickable(Button button)
```

```csharp
public void CheckKeys()
```

```csharp
public void DebugToggleUI()
```

```csharp
public void RestoreHiddenUI()
```

```csharp
private void OnInfoScreenOpened(InfoScreenOpened e)
```

```csharp
private void OnInfoScreenClosed(InfoScreenClosed e)
```

```csharp
private void OnCouncilCompositionChanged(CouncilCompositionChanged e)
```

```csharp
private void OnCouncilorMissionAssigned(CouncilorMissionAssigned e)
```

```csharp
private void OnArmyAssignedToFaction(ArmyAssignedToFaction e)
```

```csharp
private void OnSectorAssignedToFaction(SectorAssignedToFaction e)
```

```csharp
private void OnFleetCoreStatusChanged(FleetCoreStatusChange e)
```

```csharp
private void OnMissionOptionsForTargetRequested(MissionOptionsForTargetRequested e)
```

```csharp
public void OnFinderButtonSelected()
```

```csharp
public void RefreshMilestoneUI()
```

```csharp
public void OnMilestoneCompleted(MilestoneComplete e)
```

```csharp
public void OnOpenTutorialClicked(int index)
```

```csharp
public void OnCloseTutorialClicked(int index)
```

```csharp
public void HoldUITutorial(UITutorialController controller, CampaignMilestone milestone, bool overrideMilestone, bool nextFrame)
```

```csharp
public void ClearHeldTutorial(UITutorialController controller)
```

```csharp
private void RefreshHeldTutorialTooltips()
```

```csharp
public void Tutorial_HighlightIntroOptin()
```

```csharp
public void EnableFinderCanvas(bool setting)
```

```csharp
public void OpenFinderCanvas()
```

```csharp
private void OnMissionPhaseStart(TimeEventStart e)
```

```csharp
private IEnumerator WaitFiveAndCall()
```

```csharp
private void OnMissionPhaseComplete(TimeEventComplete e)
```

```csharp
public void OnClickToggleMissionPhaseReport()
```

```csharp
public void SetSummaryLogReportButton()
```

```csharp
private void OnSellSpaceResourcesRequested(SellSpaceResourcesRequested e)
```

```csharp
private void UpdateResourceData(FactionResourcesUpdated e)
```

```csharp
private void UpdateResourceData(HabModuleConstructionStatusChange e)
```

```csharp
private void UpdateResourceData(ShipConstructionCompleted e)
```

```csharp
private void UpdateResourceData()
```

```csharp
public void OnAssetPanelOpened(MyAssetPanelOpened e)
```

```csharp
public void OnAssetPanelClosed(MyAssetPanelEntirelyClosed e)
```

```csharp
public void OnAssetPanelResized(MyActiveAssetPanelResized e)
```

```csharp
private void OnGameStateArchived(GameStateArchived e)
```

```csharp
public static bool IsCurrentlySelectedGameState(TIGameState state)
```

```csharp
public void OnGameStateNameChanged(GameStateNameChanged e)
```

```csharp
private void CouncilorChat()
```

```csharp
public void OnChatButtonClicked()
```

```csharp
private IEnumerator SendQuicksaveNotification()
```

```csharp
private string AssembleFivePointReport(TIFactionState faction, FactionResource resourceType, string summaryTooltipPath, string detailTooltipPath, string incomeTooltipPath)
```

```csharp
private string AssembleResearchReport(TIFactionState faction)
```

```csharp
private string AssembleMissionControlReport(TIFactionState faction)
```

```csharp
private string AssembleProjectsReport(TIFactionState faction)
```

```csharp
public static string ResourceReportString(TIFactionState faction, FactionResource resourceType)
```

```csharp
private void SetSpaceResourceValuesInBar(TIFactionState faction, FactionResource resourceType, TMP_Text reportText, Transform panel)
```

```csharp
private string AssembleControlPointMaintenanceTooltip(TIFactionState faction)
```

```csharp
private string AssembleSpaceResourceTooltip(TIFactionState faction, FactionResource resourceType, string detailTooltipPath)
```

```csharp
public static string ControlPointMaintenanceString(TIFactionState faction)
```

```csharp
private void SetResourceTooltipDelegates(TIFactionState faction)
```

```csharp
private void UpdateResourceData(TIFactionState faction)
```

```csharp
private void UpdateResearchLeadersLights()
```

```csharp
public void ActivateTargetingPanel(List<MissionOption> missionOptions, TIGameState baseTarget)
```

```csharp
public void RefreshTargetingPanel()
```

```csharp
public void ToggleShowAssignedCouncilorsInTargetingPanel()
```

```csharp
private List<TIGameState> GetTargetableGameStatesInRegion(TIRegionState selectedRegion)
```

```csharp
private void GetNextTargetableGameStateInRegion(List<TIGameState> targetListForRegion)
```

```csharp
public void DisableTargetingPanel()
```

```csharp
private void InitializeFinderList()
```

```csharp
private IEnumerator UpdateFinderWithDelay()
```

```csharp
public void UpdateFinderList()
```

```csharp
public void OnToggleFinderEditMode()
```

```csharp
public void UpdateFinderMaxHeight()
```

```csharp
public override void UpdateUIScaling()
```

```csharp
private void UpdateFinderToggleSprites()
```

```csharp
public void ToggleFinderCouncilors(bool onlyThis = false)
```

```csharp
public void ToggleFinderArmies(bool onlyThis = false)
```

```csharp
public void ToggleFinderHabs(bool onlyThis = false)
```

```csharp
public void ToggleFinderFleets(bool onlyThis = false)
```

```csharp
private void ToggleAllFinderFiltersOn()
```

```csharp
private void FinderFilterExclusiveArmies()
```

```csharp
private void FinderFilterExclusiveCouncilors()
```

```csharp
private void FinderFilterExclusiveHabs()
```

```csharp
private void FinderFilterExclusiveFleets()
```

```csharp
public void FinderCycleForward()
```

```csharp
public void FinderCycleBackward()
```

```csharp
public void SetFinderIndex(TIGameState gameState)
```

```csharp
public void HighlightFinderItem(bool reset = false)
```

```csharp
private int VisibleFinderItems()
```

```csharp
public List<TIGameState> FinderItems(bool init = true)
```

```csharp
public void InitSortOverrides(List<TIGameState> gameStates)
```

```csharp
public void CleanFinderSortIndices(List<TIGameState> gameStates)
```

```csharp
private IEnumerator HideSearchAfterInit()
```

```csharp
public void ShowGlobalSearchPanel()
```

```csharp
public void HideGlobalSearchPanel(bool playAudio = true)
```

```csharp
public void OnGlobalSearchInputUpdated()
```

```csharp
public void SetGlobalSearchListModelData(List<TIGameState> gameStates)
```

```csharp
public bool CanDisplaySearchableGameStateWithIntel(TIGameState gameState)
```

```csharp
private void ShowResourcesPanel()
```

```csharp
private void UpdateResourcesPanel()
```

```csharp
private void ResetResourcesPanel()
```

```csharp
public void OnSelectInputField()
```

```csharp
public void OnDeSelectInputField()
```

```csharp
public void ChangeProposedSale(FactionResource resource, int value, bool increment = true)
```

```csharp
public void OnResetSaleClicked()
```

```csharp
public void OnConfirmSaleClicked()
```

```csharp
public void OnCloseSellResourcesPanelClicked()
```

```csharp
public void RefreshAlienThreatPanel(AlienThreatUpdated e)
```

```csharp
public void RefreshAlienThreatPanel()
```

```csharp
private void InitializeAlarmPanel()
```

```csharp
public void OpenAlarmPanel(TIDateTime setTime, string defaultString = "")
```

```csharp
public void OnResetAlarmPanelTime()
```

```csharp
public void OnOpenAlarmPanel()
```

```csharp
private void ProposeAlarm(TIDateTime setTime)
```

```csharp
public void ProposeAlarmFromSettings()
```

```csharp
public void OnAlarmDropdownChanged()
```

```csharp
private int SetDayDropdown(int month, int year)
```

```csharp
public void OnOpenCalendarFromAlarmPanel()
```

```csharp
public void OnCloseAlarmPanel()
```

```csharp
public void OnConfirmAlarm(bool alsoClose)
```

```csharp
public void CycleMinute(bool forward)
```

```csharp
public void CycleHour(bool forward)
```

```csharp
public void CycleDay(bool forward)
```

```csharp
public void CycleMonth(bool forward)
```

```csharp
public void CycleYear(bool forward)
```

```csharp
public override void SetUltraWideScaling()
```

```csharp
public int Compare(TIGameState a, TIGameState b)
```

```csharp
private static int Weight(TIGameState state)
```
