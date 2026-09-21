# HabitatsScreenController

*Decompiled from `PavonisInteractive/TerraInvicta/HabitatsScreenController.cs`.*


## Class `HabitatsScreenController`

```csharp
public class HabitatsScreenController : CanvasControllerBase, IHabitatsPreviewer, IInfoScreen, ICanvas
```

### Fields

| Name | Type |
|---|---|
| `selectedModule` | public HabGridCell |
| `PlayerHab` | public bool |
| `habBuilder` | private HabBuilding |
| `HabScreenMainUITutorialController` | public UITutorialController |
| `HabScreenManagementUITutorialController` | public UITutorialController |
| `habsMainPanel` | public GameObject |
| `habListItemPrefab` | public GameObject |
| `moduleListItemPrefab` | public GameObject |
| `habListItemSelectedColor` | public Color |
| `habDisplayCellSizeMin` | public float |
| `habDisplayCellSizeMax` | public float |
| `exitButton` | private Button |
| `habToDisplay` | public TIHabState |
| `habModels` | public List<HabScreenHabListItemModel> |
| `habListAdapter` | public HabScreenHabListAdapter |
| `currentHabSort` | private HabitatsScreenController.SortHabDataBy |
| `reverseHabSort` | private bool |
| `selectedHabList` | public List<TIHabState> |
| `habModuleTemplates` | private TIHabModuleTemplate[] |
| `habModuleDictionary` | private Dictionary<string, TIHabModuleTemplate> |
| `showAvailableModules` | private bool |
| `installedModulesTabButtonImage` | public Image |
| `installedModulesTabButtonRT` | public RectTransform |
| `availableModulesTabButtonImage` | public Image |
| `availableModulesTabButtonRT` | public RectTransform |
| `originalButtonSprite` | public Sprite |
| `habList_FilterForHabIcon` | private string |
| `habList_FilterForFaction` | private TIFactionState |
| `habList_FilterForSpaceObject` | private TISpaceBodyState |
| `habList_FilterHumanFactionsOnly` | private bool |
| `habList_FilterForHabType` | private HabType |
| `habIconFilterDropdown` | public TMP_Dropdown |
| `factionsDropdown` | public TMP_Dropdown |
| `locationDropdown` | public TMP_Dropdown |
| `factionDropdownLookup` | private Dictionary<int, TIFactionState> |
| `locationDropdownLookup` | private Dictionary<int, TISpaceBodyState> |
| `applyingMassTemplates` | public bool |
| `habList_FilterForTemplate` | private TIHabTemplate |
| `massTemplatesDropdown` | public TMP_Dropdown |
| `massTemplatesHeaderText` | public TMP_Text |
| `massTemplatesHabIconSelectionDropdown` | public TMP_Dropdown |
| `quickTemplatesDropdown` | public TMP_Dropdown |
| `stationsToggle` | public Toggle |
| `basesToggle` | public Toggle |
| `sortButtons` | public List<Button> |
| `antimatterSortButtonObject` | public GameObject |
| `exoticsSortButtonObject` | public GameObject |
| `habListScrollHeader` | public Image |
| `habListScrollBar` | public GameObject |
| `selectedHabInfoContainerRT` | public RectTransform |
| `gravityDisplayObject` | public GameObject |
| `selectedHabGravity` | public TMP_Text |
| `selectedHabCrewDisplayObject` | public GameObject |
| `selectedHabCrew` | public TMP_Text |
| `councilorGridPanel` | public GameObject |
| `councilorGrid` | public ListManagerBase |
| `primaryHabitatsCanvas` | public Canvas |
| `secondaryHabitatsCanvas` | public Canvas |
| `habListMasterObject` | public GameObject |
| `habPreviewInfoPanel` | public GameObject |
| `moduleSelectionPanel` | public GameObject |
| `nextHabButtonsContainer` | public GameObject |
| `previousHabButtonsContainer` | public GameObject |
| `nextHabButton` | public Button |
| `nextSmartHabButton` | public Button |
| `nextIconHabButton` | public Button |
| `nextIconHabButtonImage` | public Image |
| `previousHabButton` | public Button |
| `previousSmartHabButton` | public Button |
| `previousIconHabButton` | public Button |
| `previousIconHabButtonImage` | public Image |
| `displayModuleSector` | private int |
| `displayModuleSlot` | private int |
| `managingHab` | private bool |
| `habDisplayDataDirty` | private bool |
| `habinfoIconDropdown` | public TMP_Dropdown |
| `habIconPaths` | private List<string> |
| `habInfoListItems` | private HabInfoListItem[] |
| `habNoneSelected` | private HabInfoListItem |
| `habTier` | private HabInfoListItem |
| `habLocation` | private HabInfoListItem |
| `PowerAllButton` | public Button |
| `PowerAllFillerButtonObject` | public GameObject |
| `DecommissionHabButton` | public Button |
| `DecommissionModuleButton` | public Button |
| `PowerAllButtonText` | public TMP_Text |
| `DecommissionHabButtonText` | public TMP_Text |
| `DecommissionModuleButtonText` | public TMP_Text |
| `lastSort` | private int |
| `habs_filterNameInputField` | public TMP_InputField |
| `habs_nameFilterForHabs` | private string |
| `modules_filterNameInputField` | public TMP_InputField |
| `modules_nameFilterForModules` | private string |
| `availableModuleDictionary` | private Dictionary<TIHabModuleTemplate, HabModuleListItem> |
| `installedModuleDictionary` | private Dictionary<TIHabModuleState, HabModuleListItem> |
| `availableModuleListItems` | private List<HabModuleListItem> |
| `installedModuleListItems` | private List<HabModuleListItem> |
| `availableModuleListObject` | public GameObject |
| `moduleInfoListItems` | private HabInfoListItem[] |
| `moduleNoneSelected` | private HabInfoListItem |
| `moduleEmpty` | private HabInfoListItem |
| `moduleName` | private HabInfoListItem |
| `moduleTier` | private HabInfoListItem |
| `moduleUpgrade` | private HabInfoListItem |
| `modulePower` | private HabInfoListItem |
| `moduleCrew` | private HabInfoListItem |
| `modulePowerToggle` | private Button |
| `habManageButton` | public Button |
| `closeHabManageButton` | public Button |
| `habGotoButton` | public Button |
| `zoomContainer` | public GameObject |
| `habManageButtonText` | public TMP_Text |
| `closeHabManageButtonText` | public TMP_Text |
| `habDisplayScrollView` | private ScrollRect |
| `habitatsScreenPreviewMouseOverTracker` | private UIPointerHoverTracker |
| `habScrollViewRectTransform` | private RectTransform |
| `habDisplayZoomSlider` | private Slider |
| `habDisplayRectTransform` | private RectTransform |
| `noHabSelected` | private GameObject |
| `noHabSelectedText` | public TMP_Text |
| `powerReportTextObject` | public GameObject |
| `powerReportText` | public TMP_Text |
| `powerReportTip` | public TooltipTrigger |
| `mainHeaderText` | public TMP_Text |
| `listHeaderText` | public TMP_Text |
| `availableModulesHeaderText` | public TMP_Text |
| `installedModulesHeaderText` | public TMP_Text |
| `habMapHeaderText` | public TMP_Text |
| `habSubtitleObject` | public GameObject |
| `habMapTypeText` | public TMP_Text |
| `habMapLocationIcon` | public Image |
| `habMapLocationText` | public TMP_Text |
| `habZoomText` | public TMP_Text |
| `connectors` | public Dictionary<string, Sprite> |
| `connectorSwaps` | public Dictionary<string, string> |
| `stationDisplayCanvas` | private Canvas |
| `stationDisplayGridLayout` | private GridLayoutGroup |
| `torusGrid` | private GridLayoutGroup |
| `torus1_2` | private Image |
| `torus2_3` | private Image |
| `torus3_4` | private Image |
| `torus4_1` | private Image |
| `stationDisplayGridRectTransform` | private RectTransform |
| `torusGridRectTransform` | private RectTransform |
| `stationGridCells` | private StationGridCell[] |
| `stationCellDictionary` | private Dictionary<string, StationGridCell> |
| `selectedStationModule` | private HabGridCell |
| `baseDisplayCanvas` | private Canvas |
| `baseDisplayRectTransform` | private RectTransform |
| `baseDisplayGridLayout` | private GridLayoutGroup |
| `baseDisplayGridRectTransform` | private RectTransform |
| `baseSurfaceImage` | private Image |
| `baseSurfaceRectTransform` | private RectTransform |
| `baseGridCells` | private BaseGridCell[] |
| `baseCellDictionary` | private Dictionary<string, BaseGridCell> |
| `selectedBaseModule` | private HabGridCell |
| `habSiteProductivityPanel` | public GameObject |
| `siteWater` | public TMP_Text |
| `siteVolatiles` | public TMP_Text |
| `siteMetals` | public TMP_Text |
| `siteNobles` | public TMP_Text |
| `siteFissiles` | public TMP_Text |
| `siteSolar` | public TMP_Text |
| `confirmModulePopupCanvas` | private Canvas |
| `confirmModuleQuery` | public TMP_Text |
| `confirmModulePurchaseEarth` | private GameObject |
| `confirmModulePurchaseEarthButton` | private Button |
| `confirmModulePurchaseEarthCostText` | public TMP_Text |
| `confirmModulePurchaseSpace` | private GameObject |
| `confirmModulePurchaseSpaceButton` | private Button |
| `confirmModulePurchaseSpaceCostText` | public TMP_Text |
| `confirmModulePurchaseFailure` | private GameObject |
| `confirmModulePurchaseFailureButton` | private Button |
| `confirmModulePurchaseFailureButtonText` | public TMP_Text |
| `cancelModulePurchase` | private GameObject |
| `cancelModulePurchaseButton` | private Button |
| `cancelModulePurchaseButtonText` | public TMP_Text |
| `proposedModuleTemplate` | private TIHabModuleTemplate |
| `proposedModuleState` | private TIHabModuleState |
| `earthCost` | private TIResourcesCost |
| `spaceCost` | private TIResourcesCost |
| `moduleToPlaceIsUpgrade` | private bool |
| `moduleToPlaceIsBuildOver` | private bool |
| `sectorToPlace` | private int |
| `moduleSlotToPlace` | private int |
| `quickBuildToggle` | public Toggle |
| `quickBuildText` | public TMP_Text |
| `quickBuildTooltip` | public TooltipTrigger |
| `quickBuildWithBoostToggle` | public Toggle |
| `quickBuildWithBoostText` | public TMP_Text |
| `renameMyHabPanel` | public GameObject |
| `saveNameText` | public TextMeshProUGUI |
| `revertNameText` | public TextMeshProUGUI |
| `nameInputField` | public TMP_InputField |
| `editNameButton` | public GameObject |
| `editNameIcon` | public GameObject |
| `connectorSpritePaths` | private readonly List<string> |
| `lastResourceUpdateCheck` | private TIDateTime |
| `resourceSummaryTitleLine` | public TMP_Text |
| `summaryTitleLine` | public TMP_Text |
| `summaryResourceGrid` | public ListManagerBase |
| `summaryResourceGridLayout` | public CenteredGridLayoutGroup |
| `managementQueryObject` | public GameObject |
| `managementQueryText` | public TMP_Text |
| `managementQueryConfirmButton` | public Button |
| `managementQueryConfirmButtonObject` | public GameObject |
| `managementQueryConfirmButtonText` | public TMP_Text |
| `managementQueryCancelButton` | public Button |
| `managementQueryCancelButtonObject` | public GameObject |
| `managementQueryCancelButtonText` | public TMP_Text |
| `managementQueryTemplateDropdownObject` | public GameObject |
| `managementQueryTemplateDropdown` | public TMP_Dropdown |
| `managementQuerySelectedHabDropdownObject` | public GameObject |
| `managementQuerySelectedHabDropdown` | public TMP_Dropdown |
| `managementQueryToggleObject` | public GameObject |
| `managementQueryToggle` | public Toggle |
| `managementQueryToggleText` | public TMP_Text |
| `maxTierIcon` | public Image |
| `maxTierTooltip` | public TooltipTrigger |
| `queryDecommissionModule` | public bool |
| `modulePanelHeaderText` | public TMP_Text |
| `sectorOwnerGO` | public GameObject |
| `sectorOwner` | public Image |
| `sectorText` | public TMP_Text |
| `moduleIcon` | public Image |
| `summaryPanel` | public GameObject |
| `summaryScrollViewContainer` | public RectTransform |
| `tierText` | public TMP_Text |
| `tierFrame` | public Image |
| `tierFrameSprites` | public Sprite[] |
| `crewText` | public TMP_Text |
| `massText` | public TMP_Text |
| `incomeGrid` | public ListManagerBase |
| `incomeDataPanel` | public GameObject |
| `incomeGridHeader` | public TMP_Text |
| `constructionCostHeader` | public TMP_Text |
| `supportCostHeader` | public TMP_Text |
| `constructionDataPanel` | public GameObject |
| `constructionCostString` | public TMP_Text |
| `supportDataPanel` | public GameObject |
| `supportCostString` | public TMP_Text |
| `upgradePanel` | public GameObject |
| `upgradeHeader` | public TMP_Text |
| `upgradeModuleName` | public TMP_Text |
| `upgradeModuleButtonText` | public TMP_Text |
| `moduleUpgradeButton` | public Button |
| `moduleUpgradeAllOfTypeButton` | public Button |
| `moduleUpgradeAllOfTypeButtonText` | public TMP_Text |
| `powerPanel` | public GameObject |
| `powerButton` | public Button |
| `powerPanelTitle` | public TMP_Text |
| `powerPanelValue` | public TMP_Text |
| `powerPanelOnOffButtonText` | public TMP_Text |
| `shipyardButton` | public Button |
| `prospectiveModule` | public TIHabModuleTemplate |
| `moduleUpgradeDataName` | private string |
| `moduleInstalledPanel` | public GameObject |
| `moduleInstalledText` | public TMP_Text |
| `moduleUnderConstructionPanel` | public GameObject |
| `moduleCompletionDateText` | public TMP_Text |
| `globalRebuildButtonObject` | public GameObject |
| `globalRebuildButtonText` | public TMP_Text |
| `globalRebuildButtonFillerObject` | public GameObject |
| `globalUpgradeButtonObject` | public GameObject |
| `globalUpgradeButtonText` | public TMP_Text |
| `globalUpgradeButtonFillerObject` | public GameObject |
| `habTemplateTitleText` | public TMP_Text |
| `habTemplateNameText` | public TMP_Text |
| `saveHabButton` | public Button |
| `saveHabButtonText` | public TMP_Text |
| `manageHabTemplatesButton` | public Button |
| `manageHabTemplatesButtonText` | public TMP_Text |
| `manageHabTemplatesHeader` | public TMP_Text |
| `manageHabTemplatesPanel` | public GameObject |
| `manageHabTemplatesList` | public ListManagerBase |
| `habTemplateDropdown` | private Dictionary<int, string> |
| `habSelectionDropdown` | private Dictionary<int, string> |
| `massHabTemplateDropdown` | private Dictionary<int, string> |
| `quickHabTemplateDropdown` | private Dictionary<int, string> |
| `cachedButtonSprite` | public Sprite |
| `allTiersButtonText` | public TMP_Text |
| `allBenefitsButtonText` | public TMP_Text |
| `tierFilter` | public int |
| `tierButtons` | public Button[] |
| `benefitFilter` | public HabitatsScreenController.AvailableModuleFilters |
| `benefitButtons` | public Button[] |
| `moduleListAntimatterSortButtonObject` | public GameObject |
| `oldModule` | private TIHabModuleTemplate |
| `IncomeEntry` | private struct |
| `iconResourcePath` | public string |
| `value` | public string |
| `AvailableModuleFilters` | public enum |
| `SortHabDataBy` | public enum |

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
private bool IsMousedOverPreviewScrollRect()
```

```csharp
public void CloseInfoScreen(bool toggle = false)
```

```csharp
public override void UpdateUIScaling()
```

```csharp
private void OnHabDetailRequested(HabDetailRequested e)
```

```csharp
private void CacheComponents()
```

```csharp
private void CacheHabDisplay()
```

```csharp
private void CacheStationDisplay()
```

```csharp
private void CacheBaseDisplay()
```

```csharp
private void CacheModuleListItems()
```

```csharp
private void CacheModuleManagementPanel()
```

```csharp
private void AddListeners()
```

```csharp
private void SetDataDirty(HabModuleConstructionStatusChange e)
```

```csharp
private void SetDataDirty(SectorAssignedToFaction e)
```

```csharp
private void SetDataDirty(HabPowerManagementUpdated e)
```

```csharp
private void SetDataDirty(HabModuleDestroyed e)
```

```csharp
private void SetDataDirty(BeginHabAssault e)
```

```csharp
private void SetDataDirty(EndHabAssault e)
```

```csharp
private void SetDataDirty(BeginBombardment e)
```

```csharp
private void SetDataDirty(EndBombardment e)
```

```csharp
private void SetDataDirty()
```

```csharp
private void OnHabDestroyed(HabDestroyed e)
```

```csharp
private void OnFactionResourcesUpdated(FactionResourcesUpdated e)
```

```csharp
private void OnHabModuleUnlocked(HabModuleUnlocked e)
```

```csharp
public HabitatsScreenController GetController()
```

```csharp
public void OnHabZoomSlider()
```

```csharp
public void OnHabZoomSliderIncrease()
```

```csharp
public void OnHabZoomSliderDecrease()
```

```csharp
private void OnHabZoomSliderSet()
```

```csharp
private void UpdateHabFrameTransforms(Vector2 sizeDelta = default(Vector2))
```

```csharp
private void ResetHabDisplayZoom()
```

```csharp
public void OnResetTutorialClicked()
```

```csharp
public void OnCloseAndPlayClicked()
```

```csharp
private void OnExitButtonClick()
```

```csharp
private void UpdateHabLists()
```

```csharp
private IEnumerator DelayedHabListHeaderUpdate()
```

```csharp
private void UpdateHabModelData()
```

```csharp
private void SetHabModelData(TIHabState destroyedHab = null)
```

```csharp
public void OnClickHabSortButton(Button clickedButton)
```

```csharp
public void UpdateHabSort(int sortBy)
```

```csharp
public void OnStationsToggleClicked(bool playSound = true)
```

```csharp
public void OnBasesToggleClicked(bool playSound = true)
```

```csharp
public void OnHabIconFilterDropdownChanged()
```

```csharp
public void OnFactionDropdownChanged()
```

```csharp
public void OnLocationDropdownChanged()
```

```csharp
public void HighlightSelectedHab(TIHabState hab)
```

```csharp
public void UnHighlightAllHabs()
```

```csharp
public void SetMenuToSelectedModule(HabModuleListItem module)
```

```csharp
public void SelectHabFromMenu(TIHabState hab)
```

```csharp
public void Tutorial_SelectFirstPlayerHab()
```

```csharp
public bool IsManaging()
```

```csharp
public void ManageHab()
```

```csharp
private void SetManageButtonStatusAndText()
```

```csharp
private void SetToPreviewView()
```

```csharp
private void SetToManagementView()
```

```csharp
public void OnClickHabManage()
```

```csharp
public void OnClickCloseHabManagement()
```

```csharp
public void CloseHabManagement()
```

```csharp
public void OnHabIconChanged()
```

```csharp
public IEnumerator ShowHabManagementTutorial()
```

```csharp
private void PreviewHab()
```

```csharp
private void RefreshCanvas()
```

```csharp
private void RefreshManagementView(bool canDeselectCurrentModule = false)
```

```csharp
private void SetEmptyHabView()
```

```csharp
public static string GetExtendedHabName(TIHabState hab)
```

```csharp
private void BuildHabSummary(TIHabState hab)
```

```csharp
private void UpdateHabInfoIconDropdown()
```

```csharp
public void OnGotoBarycenterButtonPressed()
```

```csharp
public void OnGotoHabButtonPressed()
```

```csharp
private List<TIHabState> GetDistanceSortedPlayerHabs()
```

```csharp
private List<TIHabState> GetDistanceSortedPlayerHabsPivotedAroundDisplayHab(bool displayHabAtStart)
```

```csharp
private List<TIHabState> GetDistanceSortedPlayerHabsPivotedAroundDisplayHabNeedingAttention(bool displayHabAtStart)
```

```csharp
private List<TIHabState> GetDistanceSortedPlayerHabsPivotedAroundDisplayHabWithMatchingIcon(bool displayHabAtStart)
```

```csharp
private void DisplayNextValidHab(bool next, List<TIHabState> playerHabs)
```

```csharp
private void RefreshHabCycleButtonsNavigation()
```

```csharp
private void RefreshHabIconCycleButtonsNavigation(List<TIHabState> habs = null)
```

```csharp
public void OnSwapHabButtonPressed(bool next)
```

```csharp
public void OnSmartSwapHabButtonPressed(bool next)
```

```csharp
public void OnIconSwapHabButtonPressed(bool next)
```

```csharp
public void OnPowerAllButtonPressed()
```

```csharp
public void OnDecommissionModulePressed()
```

```csharp
public void OnConfirmDecommissionModule()
```

```csharp
public void OnDecommissionHabPressed()
```

```csharp
public void OnConfirmDecommissionHab()
```

```csharp
public void OnCancelHabManagementButtonPressed()
```

```csharp
public void OnCancelHabManagementButtonPressed(bool skipAudio)
```

```csharp
private void UpdateHabPreviewDisplay()
```

```csharp
private void UpdatePowerReport(TIHabState hab)
```

```csharp
private static string PowerReport(TIHabState hab)
```

```csharp
private float TotalPotentialPowerConsumption(TIHabState hab)
```

```csharp
private float TotalPotentialAvailablePower(TIHabState hab)
```

```csharp
private float TotalCurrentAvailablePower(TIHabState hab)
```

```csharp
private void UpdateCouncilorGrid()
```

```csharp
private void PreviewStation()
```

```csharp
private void PreviewStationModule(string resourceName, int sector, int moduleSlot, TIHabModuleState habModule, bool playerControlled, bool alien, TIHabState hab)
```

```csharp
private string BaseModuleResourceName(TIHabModuleState moduleState, int sector, int module)
```

```csharp
private void SetMineProductivityValues()
```

```csharp
private void PreviewBase()
```

```csharp
private void PreviewBaseModule(string resourceName, int sector, int module, bool playerControlled)
```

```csharp
public void SelectModule(HabGridCell item)
```

```csharp
public void UpdateModulePreviewText(bool viewProspectiveModule, bool clear = false)
```

```csharp
private string ModuleSupportIconList(TIHabModuleTemplate module, bool showPower, float power, float missionControl)
```

```csharp
public void OnShipyardButtonPressed()
```

```csharp
public void OnRebuildAllSelected()
```

```csharp
public void OnRebuildAllConfirmed()
```

```csharp
public void OnUpgradeAllSelected()
```

```csharp
public void OnUpgradeAllConfirmed()
```

```csharp
private void UpgradeAllModulesSelected(List<TIHabModuleState> modules)
```

```csharp
public void OnUpgradeAllOfTypeSelected()
```

```csharp
public void OnUpgradeAllOfTypeConfirmed()
```

```csharp
private void SetShowCopySaveHabTemplateButtons()
```

```csharp
private bool CanSaveHab()
```

```csharp
public void OnSaveHabTemplateSelected()
```

```csharp
public void OnCopyHabButtonPressed()
```

```csharp
public void OnHabTemplateSelected()
```

```csharp
public void OnHabManagementQueryToggleChanged()
```

```csharp
public bool PopulateHabTemplateDropdown()
```

```csharp
public void SetSelectedTemplateInDropdown(TIHabTemplate toSelect)
```

```csharp
public bool PopulateSelectedHabDropdown()
```

```csharp
public bool PopulateMassHabTemplateDropdown()
```

```csharp
public void OnSelectMassHabTemplateDropdown(int selected)
```

```csharp
public void SelectHabForMassTemplateInfoDisplay(int selected)
```

```csharp
public void MassHabTemplateUpdateManagementQuery()
```

```csharp
public void OnClickMassHabTemplateCancel()
```

```csharp
public void SetSelectedStatus(TIHabState habState, bool value, bool delayUpdate = false)
```

```csharp
private void DeselectAllHabsForMassTemplate()
```

```csharp
public void OnMassTemplateHabIconSelectionDropdownChanged(int selected)
```

```csharp
public bool PopulateQuickHabTemplateDropdown()
```

```csharp
public void OnSelectQuickHabTemplateDropdown(int selected)
```

```csharp
public void ResetQuickHabTemplateDropdown()
```

```csharp
private TIResourcesCost CostWithNecessaryBoost(TIFactionState faction, TIResourcesCost baseLineCost, TIHabState habState = null)
```

```csharp
public void OnConfirmApplyHabTemplateSelected()
```

```csharp
public void OnConfirmApplyMassHabTemplateSelected()
```

```csharp
public void OnOpenHabTemplateManager()
```

```csharp
public void RefreshHabTemplateManagerList()
```

```csharp
public void OnClickCloseHabTemplateManager()
```

```csharp
public void CloseHabTemplateManager()
```

```csharp
public bool ModuleFilterConditionMet(TIHabModuleTemplate module, HabitatsScreenController.AvailableModuleFilters moduleFilter)
```

```csharp
public void UpdateFilterButtons()
```

```csharp
public void SetTierFilter(int tier)
```

```csharp
public void OnFilterModuleTier(int tier)
```

```csharp
public void SetBenefitFilter(int filter)
```

```csharp
public void OnFilterModuleBenefit(int filter)
```

```csharp
private void UpdateModuleList(HabType habType)
```

```csharp
private void UpdateAvailableModuleList(HabType habType)
```

```csharp
private void UpdateInstalledModuleList(HabType habType)
```

```csharp
private void OnModuleUpgrade()
```

```csharp
public void OnModulePowerToggle()
```

```csharp
private void UpdateModulePowerStatus()
```

```csharp
private void SetModuleToPlace(TIHabModuleTemplate newModule)
```

```csharp
public void StartModulePlacement(TIHabModuleTemplate newModule, int sector, int moduleSlot)
```

```csharp
public void GetEmptyModuleSlot(out int sector, out int moduleSlot, bool mine)
```

```csharp
private void QuickBuildModule()
```

```csharp
private void PopupModuleManagement()
```

```csharp
private bool IsLegalDrop()
```

```csharp
private TIResourcesCost GetEarthCost(bool moduleToPlaceIsUpgrade)
```

```csharp
private TIResourcesCost GetSpaceCost(bool moduleToPlaceIsUpgrade, TIHabModuleState moduleToUpgrade)
```

```csharp
private void OnConfirmBuildModuleEarth()
```

```csharp
private void OnConfirmBuildModuleSpace()
```

```csharp
private void OnConfirmModuleFailure()
```

```csharp
private void OnCancelBuildModule()
```

```csharp
private void CloseModuleBuildPanel()
```

```csharp
private void AssignModule(TIResourcesCost cost)
```

```csharp
private void SetupModuleBuild(TIResourcesCost cost)
```

```csharp
private void BuildHab()
```

```csharp
private void SetModulesInteractable(HabType habType, HabGridCell excludeItem = null)
```

```csharp
public void OnClickRename()
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
public void OnClickChangeModuleMode(bool available)
```

```csharp
public void ChangeModuleMode(bool available)
```

```csharp
public void OnToggleQuickBuildModules()
```

```csharp
public void OnToggleQuickBuildWithBoost()
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
public void UpdateHabNameSortFilter()
```

```csharp
public void UpdateModuleNameSortFilter()
```

```csharp
public override void OnDestroy()
```

```csharp
private void RemoveListeners()
```

```csharp
public IncomeEntry(string ip, string v)
```
