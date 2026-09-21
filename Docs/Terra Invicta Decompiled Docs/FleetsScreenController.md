# FleetsScreenController

*Decompiled from `PavonisInteractive/TerraInvicta/FleetsScreenController.cs`.*


## Class `FleetsScreenController`

```csharp
public class FleetsScreenController : CanvasControllerBase, IInfoScreen, ICanvas
```

### Fields

| Name | Type |
|---|---|
| `humanOnlyDesignerTest` | private bool |
| `fullDesignerTest` | private bool |
| `CanSaveCurrentDesign` | public bool |
| `TransferPlanner` | private TransferPlanner |
| `fleetsScreenTitle` | public TMP_Text |
| `primaryPanelTransform` | public RectTransform |
| `tabbedPaneManager` | public TabbedPaneManager |
| `fleetsListTab` | public TabbedPaneController |
| `classListTab` | public TabbedPaneController |
| `shipDetailTab` | public TabbedPaneController |
| `shipDesignerTab` | public TabbedPaneController |
| `constructionTab` | public TabbedPaneController |
| `shipDetailTabButtonObject` | public GameObject |
| `shipDesignerTabButtonObject` | public GameObject |
| `fleetsListTabText` | public TMP_Text |
| `classListTabText` | public TMP_Text |
| `shipDetailTabText` | public TMP_Text |
| `shipDesignerTabText` | public TMP_Text |
| `constructionTabText` | public TMP_Text |
| `ShipClassUITutorialController` | public UITutorialController |
| `ShipConstructionUITutorialController` | public UITutorialController |
| `FleetScreenUITutorialController` | public UITutorialController |
| `ShipDetailUITutorialController` | public UITutorialController |
| `ShipDesignerUITutorialController` | public UITutorialController |
| `fleetsTutorialLock` | private bool |
| `ShipDesignerCanvas` | public Canvas |
| `shipModuleIconPrefab` | public ShipModuleListItem |
| `shipModuleRowPrefab` | public ShipModuleListItem |
| `dVwarningObject` | public GameObject |
| `modulesTabPaneManager` | public TabbedPaneManager |
| `weaponsTabPaneManager` | public TabbedPaneManager |
| `weaponPaneManagerCanvas` | public Canvas |
| `weaponsTabPane` | public ShipWeaponTabPane |
| `gunsTabPane` | public ShipWeaponTabPane |
| `missilesTabPane` | public ShipWeaponTabPane |
| `magneticWeaponsTabPane` | public ShipWeaponTabPane |
| `plasmaWeaponsTabPane` | public ShipWeaponTabPane |
| `lasersTabPane` | public ShipWeaponTabPane |
| `particleWeaponsTabPane` | public ShipWeaponTabPane |
| `utilitiesTabPane` | public ShipModuleTabPane |
| `radiatorsTabPane` | public ShipModuleTabPane |
| `batteriesTabPane` | public ShipModuleTabPane |
| `powerPlantsTabPane` | public ShipModuleTabPane |
| `drivesTabPane` | public ShipModuleTabPane |
| `armorTabPane` | public ShipModuleTabPane |
| `noseModulesTabPane` | public TabbedPaneController |
| `hullModulesTabPane` | public TabbedPaneController |
| `noseModulesTabText` | public TMP_Text |
| `hullModulesTabText` | public TMP_Text |
| `dVWarningText` | public TMP_Text |
| `weaponTabAllSubTabButton` | public Button |
| `noseWeaponsTooltip` | public TooltipTrigger |
| `hullWeaponsTooltip` | public TooltipTrigger |
| `utilityModulesTooltip` | public TooltipTrigger |
| `radiatorsTooltip` | public TooltipTrigger |
| `batteriesTooltip` | public TooltipTrigger |
| `powerPlantsTooltip` | public TooltipTrigger |
| `drivesTooltip` | public TooltipTrigger |
| `armorTooltip` | public TooltipTrigger |
| `allWeaponsTooltip` | public TooltipTrigger |
| `gunsTooltip` | public TooltipTrigger |
| `missilesTooltip` | public TooltipTrigger |
| `magneticWeaponsTooltip` | public TooltipTrigger |
| `plasmaWeaponsTooltip` | public TooltipTrigger |
| `lasersTooltip` | public TooltipTrigger |
| `particleWeaponsTooltip` | public TooltipTrigger |
| `TransferButtonText` | public TMP_Text |
| `TransferDurationText` | public TMP_Text |
| `TransferPlanText` | public TMP_Text |
| `renameMyShipPanel` | public GameObject |
| `nameInputField` | public TMP_InputField |
| `allShipPartTemplates` | private List<TIShipPartTemplate> |
| `shipModuleListItems` | private List<ShipModuleListItem> |
| `shipModuleListItemsB` | private List<ShipModuleListItem> |
| `shipModuleSlotGrid` | private GridLayoutGroup |
| `moduleDragDestinations` | private ShipModuleDragDestination[] |
| `shipModuleSlotDictionary` | private Dictionary<Vector2Int, ShipModuleDragDestination> |
| `newShipTemplate` | public TISpaceShipTemplate |
| `designShipButton_FleetList` | public Button |
| `ShowObsoletePartsToggle` | public Toggle |
| `ShowObsoletePartsText` | public TMP_Text |
| `partsSortShowObsolete` | private bool |
| `first` | private bool |
| `gotoDesigner` | public static bool |
| `gotoConstructionManager` | public static bool |
| `MIN_DELTA_V_FOR_EARTH` | private const int |
| `MIN_DELTA_V_FOR_MARS` | private const int |
| `MIN_DELTA_V_FOR_BEYOND` | private const int |
| `MIN_FUNCTIONAL_ACCEL` | private const float |
| `MIN_AGILE_ACCEL` | private const float |
| `showShipPartsAsIcons` | public bool |
| `fleetsList` | public ListManagerBase |
| `fleetScreenFleetListAdapter` | public FleetScreenFleetListAdapter |
| `fleetScreenFleetListModels` | public List<FleetScreenFleetListItemModel> |
| `fleetListCanvas` | public Canvas |
| `fleetListToClassListButtonText` | public TMP_Text |
| `fleetListToShipDesignerButtonText` | public TMP_Text |
| `fleetListConstructionManagerButtonText` | public TMP_Text |
| `fleetListSortNameText` | public TMP_Text |
| `fleetListSortAlertLevelText` | public TMP_Text |
| `fleetListSortArrivalTimeText` | public TMP_Text |
| `fleetListSortOperationsText` | public TMP_Text |
| `fleetOpenedStatus` | public Dictionary<TIGameState, bool> |
| `showEnemyFleets` | public bool |
| `fleetList_FilterHumanFactionsOnly` | private bool |
| `hiddenFactions` | private List<TIFactionState> |
| `fleetListDirty` | public bool |
| `fleets_filterForFaction` | private TIFactionState |
| `fleets_HighFilterForSpaceBody` | private List<TISpaceBodyState> |
| `fleets_SpecificFilterForNaturalSpaceObject` | private List<TINaturalSpaceObjectState> |
| `factionsDropdown` | public TMP_Dropdown |
| `locationDropdown_High` | public TMP_Dropdown |
| `locationDropdown_Specific` | public TMP_Dropdown |
| `locationDropdown_Specific_EntryLimit` | private int |
| `factionDropdownLookup` | private Dictionary<int, TIFactionState> |
| `highLocationDropdownLookup` | private Dictionary<int, TISpaceBodyState> |
| `specificLocationDropdownLookup` | private Dictionary<int, TINaturalSpaceObjectState> |
| `currentFleetSort` | private SortFleetDataBy |
| `initFleetsList` | private bool |
| `classListHeader` | public TMP_Text |
| `classListFactionGradient` | public Image |
| `classListFactionIcon` | public Image |
| `classListHideObsoleteText` | public TMP_Text |
| `classListHideObsoleteToggle` | public Toggle |
| `shipClassListCanvas` | public Canvas |
| `shipClassList` | public ListManagerBase |
| `fleetClassListSortNameText` | public TMP_Text |
| `fleetClassListSortHullText` | public TMP_Text |
| `fleetClassListSortRoleText` | public TMP_Text |
| `fleetClassListSortMassText` | public TMP_Text |
| `fleetClassListSortBuildCostText` | public TMP_Text |
| `currentFleetClassSort` | private SortFleetClassDataBy |
| `showObsoleteClasses` | private bool |
| `invertFleetClassSort` | private bool |
| `individualShipCanvas` | public Canvas |
| `selectedShip` | public TISpaceShipState |
| `shipsList` | public ListManagerBase |
| `ShipDetailShipListAdapter` | public ShipDetailShipListAdapter |
| `ShipDetailShipListModels` | public List<ShipDetailShipListItemModel> |
| `showAllShipsToggleText` | public TMP_Text |
| `showOnlyShipsInSelectedFleetToggleText` | public TMP_Text |
| `valuesHeader` | public TMP_Text |
| `systemsHeader` | public TMP_Text |
| `missionSystemsHeader` | public TMP_Text |
| `damageHeader` | public TMP_Text |
| `selectedSystemHeader` | public TMP_Text |
| `selectedMissionSystemHeader` | public TMP_Text |
| `indiv_ShipName` | public TMP_Text |
| `indiv_LocationText` | public TMP_Text |
| `indiv_CrewText` | public TMP_Text |
| `indiv_DryMassText` | public TMP_Text |
| `indiv_WetMassText` | public TMP_Text |
| `indiv_CurrentMassText` | public TMP_Text |
| `indiv_DeltaVText` | public TMP_Text |
| `indiv_CruiseAccelerationText` | public TMP_Text |
| `indiv_CombatAccelerationText` | public TMP_Text |
| `indiv_TurnRateText` | public TMP_Text |
| `indiv_LengthText` | public TMP_Text |
| `indiv_BeamText` | public TMP_Text |
| `indiv_DriveText` | public TMP_Text |
| `indiv_RoleText` | public TMP_Text |
| `indiv_PowerPlantText` | public TMP_Text |
| `indiv_BatteryText` | public TMP_Text |
| `indiv_RadiatorsText` | public TMP_Text |
| `indiv_HeatSinkCapacityText` | public TMP_Text |
| `indiv_ShipClass` | public TMP_Text |
| `invid_RefuelCost` | public TMP_Text |
| `noseWeaponsList` | public ListManagerBase |
| `hullWeaponsList` | public ListManagerBase |
| `utilityModulesList` | public ListManagerBase |
| `indiv_noseWeaponsHeader` | public TMP_Text |
| `indiv_hullWeaponsHeader` | public TMP_Text |
| `indiv_utilityWeaponsHeader` | public TMP_Text |
| `indiv_NoseArmorMaterial` | public TMP_Text |
| `indiv_NoseArmorRating` | public TMP_Text |
| `indiv_LateralArmorMaterial` | public TMP_Text |
| `indiv_LateralArmorRating` | public TMP_Text |
| `indiv_TailArmorMaterial` | public TMP_Text |
| `indiv_TailArmorRating` | public TMP_Text |
| `officersList` | public ListManagerBase |
| `shipModelViewer` | public ShipModelViewer |
| `primarySystem` | public int |
| `leftSystemDetail` | public TMP_Text |
| `leftHandDetailPanel` | public GameObject |
| `leftHandDetailPanelHeader` | public TMP_Text |
| `rightSystemDetail` | public TMP_Text |
| `rightHandDetailPanel` | public GameObject |
| `rightHandDetailPanelHeader` | public TMP_Text |
| `hullDamageControlImage` | public Image |
| `radiatorDamageControlImage` | public Image |
| `driveDamageControlImage` | public Image |
| `shipListInitialized` | private bool |
| `showEnemyShipsOnList` | private bool |
| `showEnemyShipsToggle` | public Toggle |
| `showOnlyShipsInSelectedFleet` | private bool |
| `showOnlyShipsInSelectedFleetToggle` | public Toggle |
| `damageControlPanel` | public GameObject |
| `masterDamageGridGroup` | public GridLayoutGroup |
| `masterDamageGridControllers` | private Dictionary<Vector2Int, SpaceCombatDamageGridItemController> |
| `moduleDamageGrid` | private Dictionary<ModuleDataEntry, SpaceCombatDamageGridItemController> |
| `systemDamageGrid` | private Dictionary<ShipSystem, SpaceCombatDamageGridItemController> |
| `individualShipCameraPrefab` | public GameObject |
| `individualShipCameraObject` | private GameObject |
| `individualShipCamera` | private Camera |
| `hideCrew` | private bool |
| `hidePowerPlant` | private bool |
| `hideBattery` | private bool |
| `hideRadiator` | private bool |
| `hideHeatSink` | private bool |
| `hideArmor` | private bool |
| `hideWeapons` | private bool |
| `indivPreviewPosition` | private GameObject |
| `indivShipVisObject` | private GameObject |
| `hullSelectionDropdown` | public TMP_Dropdown |
| `fullShipClassName` | public TMP_Text |
| `designerShipDataClassName` | public TMP_Text |
| `designerShipDataClassNose` | public Image |
| `designerShipDataClassHull` | public Image |
| `designerShipDataClassTail` | public Image |
| `designerShipDataClassDrive` | public Image |
| `designerShipDataClassRadiator` | public Image |
| `roleSelectionDropdown` | public TMP_Dropdown |
| `classNameInputField` | public TMP_InputField |
| `classNamePlaceholder` | public TMP_Text |
| `classNameText` | public TMP_Text |
| `hullDropdownValues` | private Dictionary<int, TIShipHullTemplate> |
| `reverseHullDropdownValues` | private Dictionary<string, int> |
| `designerCoreDataHeader` | public TMP_Text |
| `designerShipDataHeader` | public TMP_Text |
| `designerMassBreakdownToolTipText` | public TooltipTrigger |
| `designerCrewToolTipText` | public TooltipTrigger |
| `designerCruiseAccelToolTipText` | public TooltipTrigger |
| `designerCombatAccelToolTipText` | public TooltipTrigger |
| `designerCruiseDeltaVToolTipText` | public TooltipTrigger |
| `designerTurnRateToolTipText` | public TooltipTrigger |
| `designerHeatSinkCapacityToolTipText` | public TooltipTrigger |
| `designerBatteryCapacityToolTipText` | public TooltipTrigger |
| `designerConstructionCostToolTipText` | public TooltipTrigger |
| `designerConstructionTimeToolTipText` | public TooltipTrigger |
| `designerSupportToolTipText` | public TooltipTrigger |
| `designerResetDesignButtonText` | public TMP_Text |
| `designerSaveDesignButton` | public Button |
| `designerSaveDesignButtonText` | public TMP_Text |
| `designerAutoDesignButton` | public Button |
| `designerAutoDesignButtonText` | public TMP_Text |
| `designerConfirmationHeaderText` | public TMP_Text |
| `designerValidRefitText` | public TMP_Text |
| `validRefitNotificationObject` | public GameObject |
| `refitTooltipText` | public TooltipTrigger |
| `designerSaveTooltipText` | public TooltipTrigger |
| `selectedHullIndex` | private int |
| `maxHullIndex` | private int |
| `altHullTooltip` | public TooltipTrigger |
| `changesMadeToExistingClass` | public bool |
| `shipDesignInProgress` | private bool |
| `hideShipRoles` | private readonly List<ShipRole> |
| `loadingExistingTemplate` | private bool |
| `roleOptions` | private Dictionary<ShipRole, int> |
| `reverseRoleOptions` | private Dictionary<int, ShipRole> |
| `automateRoleButtonTip` | public TooltipTrigger |
| `roleTip` | public TooltipTrigger |
| `previousRole` | private ShipRole |
| `nameAttempts` | private int |
| `designerCombatScoreText` | public TMP_Text |
| `designerWetMassTabText` | public TMP_Text |
| `designerWetMassText` | public TMP_Text |
| `designerCrewTabText` | public TMP_Text |
| `designerCrewText` | public TMP_Text |
| `designerCruiseAccelerationTabText` | public TMP_Text |
| `designerCruiseAccelerationText` | public TMP_Text |
| `designerCombatAccelerationTabText` | public TMP_Text |
| `designerCombatAccelerationText` | public TMP_Text |
| `designerCruiseDeltaVTabText` | public TMP_Text |
| `designerCruiseDeltaVText` | public TMP_Text |
| `designerTurnRateTabText` | public TMP_Text |
| `designerTurnRateText` | public TMP_Text |
| `designerHeatSinkCapacityTabText` | public TMP_Text |
| `designerHeatSinkCapacity` | public TMP_Text |
| `designerBatteryCapacityTabText` | public TMP_Text |
| `designerBatteryCapacity` | public TMP_Text |
| `designerConstructionCostTabText` | public TMP_Text |
| `designerConstructionCostText` | public TMP_Text |
| `designerConstructionTimeTabText` | public TMP_Text |
| `designerConstructionTimeText` | public TMP_Text |
| `designerMaintenanceCostTabText` | public TMP_Text |
| `designerMaintenanceCostText` | public TMP_Text |
| `lastSCVUpdateFrame` | private static int |
| `fleetCamera` | public GameObject |
| `cameraViewObject` | public GameObject |
| `shipImageSpaceBackground` | public RectTransform |
| `shipPrefab` | public GameObject |
| `fleetSceneCameraInstance` | private GameObject |
| `previewPosition` | private GameObject |
| `shipVisObject` | private GameObject |
| `moduleDataContainer` | public RectTransform |
| `selectedModulesCompareToggle` | public Toggle |
| `selectedModuleCompareHeaderText` | public TMP_Text |
| `installedModulesCompareToggle` | public Toggle |
| `installedModuleCompareHeaderText` | public TMP_Text |
| `comparingModules` | private bool |
| `selectedModuleDataContainer` | public RectTransform |
| `selectedModuleScrollbar` | public Scrollbar |
| `selectedModuleHeaderText` | public TMP_Text |
| `selectedModuleObsoleteToggle` | public Toggle |
| `selectedModuleObsoleteHeaderText` | public TMP_Text |
| `selectedModuleHeaderContainer` | public RectTransform |
| `selectedModuleDataIcon` | public Image |
| `selectedModuleDataHeaderText` | public TMP_Text |
| `selectedModuleSecondaryHeader` | public TMP_Text |
| `selectedModulePreTableText` | public TMP_Text |
| `selectedModuleTableList` | public ListManagerBase |
| `selectedModulePostTableText` | public TMP_Text |
| `selectedModuleLayoutElement` | public LayoutElement |
| `currentlySelectedModule` | private TIShipPartTemplate |
| `selectedModuleDataDisplay` | private bool |
| `selectedModuleDataButtonsContainer` | public GameObject |
| `installModuleButton` | public Button |
| `installModuleButtonText` | public TMP_Text |
| `installedModuleDataContainer` | public RectTransform |
| `installedModuleScrollbar` | public Scrollbar |
| `installedModuleHeaderText` | public TMP_Text |
| `installedModuleObsoleteToggle` | public Toggle |
| `installedModuleObsoleteHeaderText` | public TMP_Text |
| `installedModuleHeaderContainer` | public RectTransform |
| `installedModuleDataIcon` | public Image |
| `installedModuleDataHeaderText` | public TMP_Text |
| `installedModuleSecondaryHeader` | public TMP_Text |
| `installedModulePreTableText` | public TMP_Text |
| `installedModuleTableList` | public ListManagerBase |
| `installedModulePostTableText` | public TMP_Text |
| `installedModuleLayoutElement` | public LayoutElement |
| `currentlyInstalledModule` | private TIShipPartTemplate |
| `installedModuleDataDisplay` | private bool |
| `installedModuleDataButtonsContainer` | public GameObject |
| `installedDeleteModuleButton` | public Button |
| `installedDeleteModuleButtonText` | public TMP_Text |
| `installedFireModeButton` | public Button |
| `installedFireModeButtonText` | public TMP_Text |
| `installedFireModeIcon` | public Image |
| `installedFireModeTooltip` | public TooltipTrigger |
| `_fireModeIndex` | private int |
| `constructionManagerCanvas` | public Canvas |
| `restoreCanvas` | private Canvas |
| `shipyardGridList` | public ListManagerBase |
| `constructionShipClassList` | public ListManagerBase |
| `noShipyardsPanel` | public GameObject |
| `noShipyardsText` | public TMP_Text |
| `noShipyardsButtonText` | public TMP_Text |
| `addToFastestQueueButtonText` | public TMP_Text |
| `noShipClassSelectedText` | public TMP_Text |
| `noShipDesignsText` | public TMP_Text |
| `shipyardGrid` | public GameObject |
| `selectedShipClassHeader` | public TMP_Text |
| `selectedShipClassDetailObject` | public GameObject |
| `selectedShipClassNose` | public Image |
| `selectedShipClassHull` | public Image |
| `selectedShipClassTail` | public Image |
| `selectedShipClassDrive` | public Image |
| `selectedShipClassRadiator` | public Image |
| `selectedShipConstructionTime` | public TMP_Text |
| `selectedShipClassAccel` | public TMP_Text |
| `selectedShipClassDV` | public TMP_Text |
| `selectedShipClassCombatValue` | public TMP_Text |
| `selectedShipClassConstructionCost` | public TMP_Text |
| `selectedShipClassSelectedLabel` | public TMP_Text |
| `selectedShipClassRoleValue` | public TMP_Text |
| `selectedShipClassArmorTab` | public TMP_Text |
| `selectedShipClassArmorValue` | public TMP_Text |
| `selectedShipClassNoseWeaponList` | public ListManagerBase |
| `selectedShipClassHullWeaponList` | public ListManagerBase |
| `selectedShipClassUtilityModuleList` | public ListManagerBase |
| `selectedShipClassTabbedPaneManager` | public TabbedPaneManager |
| `selectedShipClassNoseTabController` | public TabbedPaneController |
| `selectedShipClassHullTabController` | public TabbedPaneController |
| `selectedShipClassUtilTabController` | public TabbedPaneController |
| `selectedShipClassNoseButtonObject` | public GameObject |
| `selectedShipClassHullButtonObject` | public GameObject |
| `selectedShipClassUtilitiesButtonObject` | public GameObject |
| `constructionFilterDropdown_EntryLimit` | private int |
| `constructionFilterDropdown` | public TMP_Dropdown |
| `constructScrollViewObject` | public GameObject |
| `refitScrollviews` | public GameObject |
| `refitRefuelCostWarningObject` | public GameObject |
| `dockedShipsList` | public ListManagerBase |
| `validRefitClassesList` | public ListManagerBase |
| `constructTabText` | public TMP_Text |
| `refitTabText` | public TMP_Text |
| `dockedShipsText` | public TMP_Text |
| `refitClassesText` | public TMP_Text |
| `refitRefuelCostTooltip` | public TooltipTrigger |
| `constructTabButton` | public Button |
| `refitTabButton` | public Button |
| `oldShipTemplate` | public TISpaceShipTemplate |
| `designToRefitTo` | public TISpaceShipTemplate |
| `originalShipTemplate` | public TISpaceShipTemplate |
| `shipSelectedForRefit` | public TISpaceShipState |
| `showRefitFeature` | private bool |
| `refitting` | private bool |
| `hasDockedFleet` | private bool |
| `dockedShipsCount` | private int |
| `dockedShips` | private List<TISpaceShipState> |
| `construction_ShipListButton` | public TMP_Text |
| `construction_ShipDesignerButton` | public TMP_Text |
| `construction_FleetListButton` | public TMP_Text |
| `construction_ShipDesignerButtonBtn` | public Button |
| `construction_AddToFastestQueueButton` | public Button |
| `constructionManagerSelectedDesign` | public TISpaceShipTemplate |
| `constructionManagerSelectedQueueItem` | public ShipConstructionQueueItem |
| `constructionBodies` | private List<TINaturalSpaceObjectState> |
| `refitBodies` | private List<TINaturalSpaceObjectState> |
| `multiSelectedRefitShips` | public List<TISpaceShipState> |
| `WeaponMountLocation` | public class |
| `mountSize` | public List<int> |
| `weaponClass` | public List<WeaponClass> |
| `isNose` | public List<bool> |

### Properties

- `public ShipModuleDragDestination selectedDragDestination`
- `public TIShipPartTemplate selectedShipPart`

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
public override bool Visible()
```

```csharp
private void OnFleetCoreStatusChanged(FleetCoreStatusChange e)
```

```csharp
private void OnShipsRemovedFromFleet(ShipsRemovedFromFleet e)
```

```csharp
private void OnFleetOpComplete(FleetOperationWithDurationComplete e)
```

```csharp
private void OnFleetDetailRequested(FleetDetailRequested e)
```

```csharp
private void OnShipDetailRequested(ShipDetailRequested e)
```

```csharp
private void OnShipConstructionUpdated(ShipConstructionUpdated e)
```

```csharp
private void OnShipyardRequested(ShipyardUIRequested e)
```

```csharp
private void OnHabModuleDestroyed(HabModuleDestroyed e)
```

```csharp
public void CloseInfoScreen(bool toggle = false)
```

```csharp
public override void UpdateUIScaling()
```

```csharp
public void OnClassListButtonClicked()
```

```csharp
public void OnConstructionManagerButtonClicked()
```

```csharp
public void OpenConstructionManager()
```

```csharp
public void OnDesignShipButtonFromFleetListClicked()
```

```csharp
public void OnDesignShipButtonFromConstructionManagerClicked()
```

```csharp
public void OnClassListButtonFromConstructionManagerClicked()
```

```csharp
public void OnExitButtonClicked()
```

```csharp
public void OnCloseAndPlaySelected()
```

```csharp
public void ShowFleetListTutorial()
```

```csharp
public void ShowClassListTutorial()
```

```csharp
public void ShowConstructionTutorial()
```

```csharp
public void ShowDesignerTutorial()
```

```csharp
public void ShowShipDetailTutorial()
```

```csharp
public void HideTutorials()
```

```csharp
public void Tutorial_ExpandFirstFleet()
```

```csharp
public void Tutorial_UnExpandFirstFleet()
```

```csharp
private void Tutorial_ChangeFirstFleetExpandState(bool expand)
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
public void ShowRenameMyFleetPanel()
```

```csharp
public void OnSelectInputBox()
```

```csharp
public void OnDeSelectInputBox()
```

```csharp
public void ToggleFactionFleets(TIFactionState faction)
```

```csharp
public void OnFactionDropdownChanged()
```

```csharp
public void OnHighLocationDropdownChanged()
```

```csharp
public void OnSpecificLocationDropdownChanged()
```

```csharp
private void PopulatePermanentDropdowns()
```

```csharp
private void PopulateLocalDropdown()
```

```csharp
public IEnumerator InitFleetsList()
```

```csharp
public void UpdateFleetsList()
```

```csharp
public void SetFleetListModelData(List<TIGameState> fleetsAndShips)
```

```csharp
private void ValidateFleetScreenGameStateModels()
```

```csharp
public void OnClickFleetSort(int sortBy)
```

```csharp
public List<TISpaceFleetState> SortFleetsList(List<TISpaceFleetState> fleetStateList)
```

```csharp
public void UpdateShipClassListScreen()
```

```csharp
public void OnClickFleetClassSort(int sortBy)
```

```csharp
public List<TISpaceShipTemplate> SortFleetClassList(List<TISpaceShipTemplate> fleetClassList)
```

```csharp
public void OnCloseShipClassListScreenButtonClicked()
```

```csharp
public void OnDesignShipButtonClicked()
```

```csharp
public void ShowShipDesigner()
```

```csharp
public void OnCloseIndividualShipDataScreen()
```

```csharp
public void SetIndividualShipList()
```

```csharp
public void UpdateShipNames()
```

```csharp
public void ShowIndividualShipList()
```

```csharp
public void OnToggleShipList()
```

```csharp
public void OnToggleShowOnlyShipsInSelectedFleet()
```

```csharp
public void ShowIndividualDataScreen(TISpaceShipState selectedShip, bool togglePane = true)
```

```csharp
public void ShowIndividualDataScreenFromTab()
```

```csharp
public void ChangeViewAngleDragDown()
```

```csharp
public void ChangeViewAngleDragUp()
```

```csharp
public static string dualAccelerationStr(TISpaceShipTemplate ship)
```

```csharp
public static string dualAccelerationStr(TISpaceShipState ship)
```

```csharp
public static string accelerationStr(double accel_gs, bool combat, bool expandedText, bool abbreviate = false)
```

```csharp
public void UpdateIndividualDataScreen(TISpaceShipState selectedShip)
```

```csharp
public void OnClickUpdateLeftDetailPanel(int primarySystem)
```

```csharp
public void UpdateLeftDetailPanel(int primarySystem)
```

```csharp
public void OnClickUpdateRightDetailPanel(int systemType, int systemIndex)
```

```csharp
public void UpdateRightDetailPanel(int systemType, int systemIndex)
```

```csharp
public void OnClickCycleSelectedShipDetail(bool forward)
```

```csharp
private void InitializeShipDesigner()
```

```csharp
private void UpdateShipModuleToggles()
```

```csharp
private void CacheAllShipModules()
```

```csharp
private IEnumerator CacheAllShipModulesGradual()
```

```csharp
public void OnClickCloseShipDesigner()
```

```csharp
private void OnExitShipDesigner()
```

```csharp
private void HideEmptyWeaponTabButtons()
```

```csharp
public void OnNoseHardPointsTabButtonLeftClicked()
```

```csharp
public void UpdateWeaponTabAllSubtabInteractive()
```

```csharp
public void OnHullHardPointsTabButtonLeftClicked()
```

```csharp
public void OnNonWeaponTabButtonClicked()
```

```csharp
public static bool CanDesignShips(TIFactionState faction, bool ignoreTech = false)
```

```csharp
private static List<TIShipHullTemplate> AllowedShipHulls(TIFactionState faction, bool ignoreTech = false)
```

```csharp
private void OnCreateNewShipClicked()
```

```csharp
private void OnShipPartUnlocked(ShipPartUnlocked e)
```

```csharp
public void ResetDesigner(string hullName, string forceClassName = "", ShipRole forceRole = ShipRole.NoRole)
```

```csharp
public void OnResetShipClicked()
```

```csharp
public void OnSaveDesignClicked()
```

```csharp
public void SaveDesign()
```

```csharp
public void ShowDVWarning()
```

```csharp
public void OnClickDVWarningNo()
```

```csharp
public void OnClickDVWarningYes()
```

```csharp
private void ResetShip(string hullName, string forceClassName = "", ShipRole forceRole = ShipRole.NoRole)
```

```csharp
private void FilterAvailableShipModules()
```

```csharp
private void RefreshModuleTableWidths()
```

```csharp
private void SetupDesignerLayout()
```

```csharp
private void UpdateAllArmorSlots()
```

```csharp
public void RemoveModuleFromSlot(Vector2Int coordinates, bool updateRole = true, bool suppressSCVUpdate = false)
```

```csharp
public void SetModuleInSlot(TIShipPartTemplate module, ShipModuleDragDestination dropDestination, bool updateModelAndDropdowns = true)
```

```csharp
public void SetSelectedDragDestination(ShipModuleDragDestination destination)
```

```csharp
public void SetSelectedShipPartFromMenu(TIShipPartTemplate part)
```

```csharp
public void HighlightLegalPartDestinations()
```

```csharp
public void LoadShipTemplateIntoUI(TISpaceShipTemplate ship)
```

```csharp
public void LoadExistingShipTemplate(TISpaceShipTemplate ship)
```

```csharp
public void RefitExistingShipTemplate(TISpaceShipTemplate ship)
```

```csharp
public void UpdateTransferInfo()
```

```csharp
public void UpdateTransferPlannerParameters()
```

```csharp
public void OnTransferButtonClicked()
```

```csharp
public ShipModuleDragDestination GetBestDropDestinationForModule(TIShipPartTemplate module)
```

```csharp
public ShipModuleDragDestination FindModuleLocation(TIShipPartTemplate module)
```

```csharp
public void OnDropModuleInSlot(ShipModuleDragDestination dropDestination)
```

```csharp
private void PopulateClassSelectionDropdown(TIShipHullTemplate forceTemplate = null)
```

```csharp
public void OnClassSelectionDropdownChanged()
```

```csharp
private void GetMaxHullIndex(TISpaceShipTemplate ship)
```

```csharp
public void OnCycleAltHull(int index)
```

```csharp
public void SetAltHull(int index)
```

```csharp
private void PopulateRoleDropdown(ShipRole forceRole)
```

```csharp
public string SetAutomateButtonTip()
```

```csharp
public string SetRoleTip()
```

```csharp
public void OnAutomateRoleClicked()
```

```csharp
private void UpdateRoleSelection(ShipRole role)
```

```csharp
public void OnRoleSelectionDropdownChanged()
```

```csharp
public void TextEntryMode_Enter()
```

```csharp
public void TextEntryMode_End()
```

```csharp
public void OnDesignerClassNameChanged()
```

```csharp
public void OnEndEditClassName()
```

```csharp
private string GetNextRefitName(string name)
```

```csharp
public void OnAutodesignSelected()
```

```csharp
public void OnShowObsoletePartsToggle()
```

```csharp
public void OnPartObsoleteToggle(TIShipPartTemplate template, bool isOn)
```

```csharp
public string DesignerMassBreakdown(TISpaceShipTemplate ship)
```

```csharp
public string BuildMassToolTip()
```

```csharp
public string BuildCrewToolTip()
```

```csharp
public string BuildCruiseAccelerationToolTip()
```

```csharp
public string BuildCombatAccelerationToolTip()
```

```csharp
public string BuildCruiseDeltaVToolTip()
```

```csharp
public string BuildTurnRateToolTip()
```

```csharp
public string BuildHeatSinkCapacityToolTip()
```

```csharp
public string BuildBatteryCapactiyToolTip()
```

```csharp
public string BuildConstructionCostToolTip()
```

```csharp
public string BuildConstructionTimeToolTip()
```

```csharp
public string BuildSupportToolTip()
```

```csharp
public string HullConstructionTimeBreakdown(TIShipHullTemplate hullTemplate, bool symbol)
```

```csharp
public void UpdateShipDesignDataPanelAndImage(bool updateImage, bool updateSpaceBackground = true, bool suppressSCVUpdate = false)
```

```csharp
public void UpdateConstructionCameraImage(TISpaceShipTemplate template, bool updateSpaceBackground = true)
```

```csharp
public void UpdateIndivCameraImage(TISpaceShipState ship)
```

```csharp
private int WhichPowerUnit(float powerValue)
```

```csharp
public void UpdateModuleDataPanel(bool isSelected, TIShipPartTemplate partTemplate, bool prospective, ShipModuleSlotType slotType = ShipModuleSlotType.None)
```

```csharp
public void UpdateModuleObsoleteToggles()
```

```csharp
public void OnSelectedCompareModulesToggle(bool toggleValue)
```

```csharp
public void SelectedCompareModulesChanged(bool toggleValue)
```

```csharp
public void OnInstalledCompareModulesToggle(bool toggleValue)
```

```csharp
public void InstalledCompareModulesChanged(bool toggleValue)
```

```csharp
public void OnSelectedModuleObsoleteToggle(bool toggleValue)
```

```csharp
public void OnInstalledModuleObsoleteToggle(bool toggleValue)
```

```csharp
public void ClearSlot(Vector2Int slotCoordinates)
```

```csharp
public void OnClickInstallModuleButton()
```

```csharp
public void OnClickDeleteModuleButton()
```

```csharp
public void OnClickFireModeButton(bool leftClick)
```

```csharp
private void UpdateFireModeUI(TIShipWeaponTemplate weapon, FireMode fireMode, Image gridCornerIcon)
```

```csharp
private string FireModeTooltip(string fireModeName)
```

```csharp
public void OnClickExitConstructionManager()
```

```csharp
public void OnClickGotoHabScreen()
```

```csharp
public void OnClickHideObsoleteToggle(bool toggleValue)
```

```csharp
public void OnClickRefitTab()
```

```csharp
public void ShowRefitTab()
```

```csharp
public void ShowRefitTabWithFleetSelection(TISpaceFleetState fleet)
```

```csharp
public void OnClickConstructTab()
```

```csharp
public void ShowConstructTab()
```

```csharp
public void RefreshRefitTab(bool allowRefit = false)
```

```csharp
public void UpdateConstructionManager(TISpaceShipTemplate presetDesign = null)
```

```csharp
public void RefreshConstructionManager()
```

```csharp
public void RefreshShipyards(bool refit = false, TISpaceShipState shipToRefit = null)
```

```csharp
public void SetConstructionFilterList()
```

```csharp
public void SetRefitFilterList()
```

```csharp
public void FilterShipLists()
```

```csharp
public void SetConstructionFilter(TISpaceBodyState spaceBody)
```

```csharp
public void FillOutSelectedDesignPanel(TISpaceShipTemplate design)
```

```csharp
public void SetSelectedShipClassFromClassList(TISpaceShipTemplate design, bool refit = false, TISpaceShipState shipToRefit = null, bool shiftPressed = false)
```

```csharp
private void DisplayValidRefits(TISpaceShipTemplate design, TISpaceShipState shipToRefit)
```

```csharp
public void SetSelectedConstructionQueueItem(ShipConstructionQueueItem item)
```

```csharp
public void OnClickAddToFastestQueue()
```

```csharp
private void RefreshAddToFastestQueueButton()
```

```csharp
public void DeSelectConstructionClasses()
```

```csharp
public void DeSelectRefitClasses()
```

```csharp
public override void OnDestroy()
```

```csharp
public void CleanupTextures()
```
