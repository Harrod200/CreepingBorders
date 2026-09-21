# IntelScreenController

*Decompiled from `PavonisInteractive/TerraInvicta/IntelScreenController.cs`.*


## Class `IntelScreenController`

```csharp
public class IntelScreenController : CanvasControllerBase, IInfoScreen, ICanvas
```

### Fields

| Name | Type |
|---|---|
| `Singleton` | public static IntelScreenController |
| `TransferPlanner` | public TransferPlanner |
| `headerText` | public TMP_Text |
| `primaryPanelTransform` | public RectTransform |
| `alienTab` | public TabbedPaneController |
| `factionTab` | public TabbedPaneController |
| `globalTab` | public TabbedPaneController |
| `spaceBodyTab` | public TabbedPaneController |
| `transferTab` | public TabbedPaneController |
| `habSiteTab` | public TabbedPaneController |
| `sitesTabButtonObject` | public GameObject |
| `alienTabUITutorialController` | public UITutorialController |
| `factionTabUITutorialController` | public UITutorialController |
| `globalTabUITutorialController` | public UITutorialController |
| `spaceTabUITutorialController` | public UITutorialController |
| `transferPlannerUITutorialController` | public UITutorialController |
| `prospectingUITutorialController` | public UITutorialController |
| `factionsList` | public ListManagerBase |
| `factionListControllers` | public List<IntelFactionGridItemController> |
| `allSpacebodies` | public List<TISpaceBodyState> |
| `spacebodyModels` | public List<IntelScreenSpacebodyListItemModel> |
| `spacebodyListAdapter` | public IntelScreenSpacebodyListAdapter |
| `allHabSites` | public List<TIHabSiteState> |
| `habSiteModels` | public List<IntelScreenHabSiteListItemModel> |
| `habSiteListAdapter` | public IntelScreenHabSiteListAdapter |
| `filterProspected` | public Toggle |
| `factionsDropdowns` | public List<TMP_Dropdown> |
| `locationDropdowns_High` | public List<TMP_Dropdown> |
| `factionDropdownLookup` | private Dictionary<int, TIFactionState> |
| `highLocationDropdownLookup` | private Dictionary<int, TISpaceBodyState> |
| `spaceBody_filterForFaction` | private TIFactionState |
| `spaceBody_filterHumanFactionsOnly` | private bool |
| `spaceBody_filterNoFactionsOnly` | private bool |
| `spaceBody_highFilterForSpaceBody` | private List<TISpaceBodyState> |
| `spaceBody_filterNameInputField` | public TMP_InputField |
| `spaceBody_nameFilterForSpacebody` | private string |
| `habSite_filterForFaction` | private TIFactionState |
| `habSite_filterHumanFactionsOnly` | private bool |
| `habSite_filterNoFactionsOnly` | private bool |
| `habSite_highFilterForSpaceBody` | private List<TISpaceBodyState> |
| `habSite_filterNameInputField` | public TMP_InputField |
| `habSite_nameFilterForHabSite` | private string |
| `filterProspectedText` | public TMP_Text |
| `sortAscend` | public bool |
| `lastSort` | private int |
| `currentSpaceSort` | private SortSpaceDataBy |
| `cachedKnownStationsList` | public List<TIHabState> |
| `cachedKnownHabsList` | public List<TIHabState> |
| `sortSitesAscend` | public bool |
| `lastSitesSort` | private int |
| `currentHabSiteSort` | private SortSpaceDataBy |
| `tabManager` | public TabbedPaneManager |
| `alienTabText` | public TMP_Text |
| `factionTabText` | public TMP_Text |
| `globalTabText` | public TMP_Text |
| `spaceBodyTabText` | public TMP_Text |
| `transferPlannerTabText` | public TMP_Text |
| `habSiteTabText` | public TMP_Text |
| `globalPublicOpinionHeader` | public TMP_Text |
| `globalPublicOpinionBreakdown` | public TMP_Text |
| `globalPublicOpinionList` | public ListManagerBase |
| `globalEnvironmentalDamageHeader` | public TMP_Text |
| `globalEnvironmentalDamage_GTA` | public TMP_Text |
| `globalEnvironmentalDamage_GSLA` | public TMP_Text |
| `globalEnvironmentalDamage_MAGDPI` | public TMP_Text |
| `globalEnvironmentalDamage_ACD` | public TMP_Text |
| `globalEnvironmentalDamage_ACDC` | public TMP_Text |
| `globalEnvironmentalDamage_ACDS` | public TMP_Text |
| `globalEnvironmentalDamage_ACDY` | public TMP_Text |
| `globalEnvironmentalDamage_AM` | public TMP_Text |
| `globalEnvironmentalDamage_AMC` | public TMP_Text |
| `globalEnvironmentalDamage_AMS` | public TMP_Text |
| `globalEnvironmentalDamage_AMY` | public TMP_Text |
| `globalEnvironmentalDamage_ANO` | public TMP_Text |
| `globalEnvironmentalDamage_ANOC` | public TMP_Text |
| `globalEnvironmentalDamage_ANOS` | public TMP_Text |
| `globalEnvironmentalDamage_ANOY` | public TMP_Text |
| `globalEnvironmentalDamage_ESA` | public TMP_Text |
| `globalEnvironmentalDamage_ESAC` | public TMP_Text |
| `globalCommodityPricesHeader` | public TMP_Text |
| `globalCommodityPricesHeaderDescription` | public TMP_Text |
| `globalCommodityPricesText_Water` | public TMP_Text |
| `globalCommodityPricesText_Volatiles` | public TMP_Text |
| `globalCommodityPricesText_Metals` | public TMP_Text |
| `globalCommodityPricesText_NobleMetals` | public TMP_Text |
| `globalCommodityPricesText_Fissiles` | public TMP_Text |
| `globalCommodityPricesText_Antimatter` | public TMP_Text |
| `globalCommodityPricesText_Exotics` | public TMP_Text |
| `globalWarsHeader` | public TMP_Text |
| `globalWarsList` | public ListManagerBase |
| `globalIdeologyPortions` | public List<Image> |
| `globalAtrocitiesHeader` | public TMP_Text |
| `atrocitiesGrid` | public ListManagerBase |
| `globalDataHeader` | public TMP_Text |
| `globalDataData` | public TMP_Text |
| `globalData_EarthPop` | public TMP_Text |
| `globalData_SpacePop` | public TMP_Text |
| `globalData_GDP` | public TMP_Text |
| `globalData_PerCapitaGDP` | public TMP_Text |
| `enviroTip` | public TooltipTrigger |
| `alienCouncilorsHeaderText` | public TMP_Text |
| `alienEventsHeaderText` | public TMP_Text |
| `alienSitesHeaderText` | public TMP_Text |
| `alienFleetsHeaderText` | public TMP_Text |
| `alienHabsHeaderText` | public TMP_Text |
| `leaderBioDimmerObject` | public GameObject |
| `leaderBioPanelObject` | public GameObject |
| `mediumFactionIcon` | public Image |
| `smallFactionIcon` | public Image |
| `leaderPanelFactionName` | public TMP_Text |
| `leaderName` | public TMP_Text |
| `leaderAddress` | public TMP_Text |
| `leaderBirth` | public TMP_Text |
| `leaderJob` | public TMP_Text |
| `leaderAgenda` | public TMP_Text |
| `leaderBackground` | public TMP_Text |
| `leaderQuote` | public TMP_Text |
| `leaderVideo` | public VideoPlayer |
| `leaderBioPortrait` | public Image |
| `spacebodyHeaderName` | public TMP_Text |
| `spacebodyHeaderDescription` | public TMP_Text |
| `spacebodyHeaderMiningDescription` | public TMP_Text |
| `spacebodyHeaderOrbit` | public TMP_Text |
| `spacebodyHeaderDimensions` | public TMP_Text |
| `habSiteHeaderName` | public TMP_Text |
| `habSiteHeaderDescription` | public TMP_Text |
| `habSiteHeaderSpacebodyName` | public TMP_Text |
| `habSiteHeaderHabName` | public TMP_Text |
| `basesHeaderName` | public TMP_Text |
| `stationsHeaderName` | public TMP_Text |
| `spacebodyLaunchWindowHeader` | public TMP_Text |
| `habSiteLaunchWindowHeader` | public TMP_Text |
| `spaceBodyTagWindowHeader` | public TMP_Text |
| `OnExit` | public IntelScreenController.OnExitCallback |
| `probeAllButton` | public Button |
| `probeAllButtonText` | public TMP_Text |
| `probeAllButtonCost` | public TMP_Text |
| `alienCouncilorsList` | public ListManagerBase |
| `alienEarthAssetsList` | public ListManagerBase |
| `alienEventsList` | public ListManagerBase |
| `alienFleetsList` | public ListManagerBase |
| `alienHabsList` | public ListManagerBase |
| `alienSkipEventsValue` | private int |
| `forwardInTimeButton` | public Button |
| `backInTimeButton` | public Button |

### Methods

```csharp
public override void Initialize()
```

```csharp
public void SetSpacebodyListModelData()
```

```csharp
public void UpdateSpaceBodyListModelData()
```

```csharp
public void UpdateSpaceBodyListSortTag()
```

```csharp
public void SetHabSiteListModelData()
```

```csharp
public void UpdateHabSiteListModelData()
```

```csharp
public void UpdateHabSiteListSortTag()
```

```csharp
public override void UpdateActivePlayerUIElements(bool startup)
```

```csharp
private void PopulatePermanentDropdowns()
```

```csharp
private void OverrideDropdownMultiselectLabels()
```

```csharp
public override void Show()
```

```csharp
public override void Hide()
```

```csharp
public void RefreshAll()
```

```csharp
public override void Refresh()
```

```csharp
public void CloseInfoScreen(bool toggle = false)
```

```csharp
public override void UpdateUIScaling()
```

```csharp
public void RefreshActiveTab(bool includingSpaceBodies)
```

```csharp
public void ForceActiveTab(TIGameState stateForTab)
```

```csharp
public void Close()
```

```csharp
public void OnExitButtonClicked()
```

```csharp
public void OnCloseAndPlayButtonSelected()
```

```csharp
public void CleanUpDisplay()
```

```csharp
public void RefreshFactionTab()
```

```csharp
public void RefreshGlobalTab()
```

```csharp
public void RefreshSpaceBodies()
```

```csharp
public void RefreshHabSites()
```

```csharp
public void SetProbeAllButton()
```

```csharp
public void OnProbeAllClicked()
```

```csharp
public void RefreshAlienTab()
```

```csharp
public void RefreshTransferTab()
```

```csharp
public void ShowAllCouncilorTabs()
```

```csharp
public void ShowAllResourcesTabs()
```

```csharp
public void ShowAllObjectivesTabs()
```

```csharp
public void ShowAllRelationsTabs()
```

```csharp
public void ShowAllProjectsTabs()
```

```csharp
public void UpdateAlienEvents()
```

```csharp
public void AlienEventsBackInTime()
```

```csharp
public void AlienEventsForwardInTime()
```

```csharp
public void OnClickSpaceSortButton(int sortValue)
```

```csharp
public void OnChangeSpaceSort(int sortBy)
```

```csharp
public void UpdateSpaceBodySort()
```

```csharp
public void OnFactionDropdownChanged(bool spacebody)
```

```csharp
public void OnLocationDropdownChanged(bool spacebody)
```

```csharp
public void OnUpdateNameSortFilterToggle(bool spacebody)
```

```csharp
public void UpdateNameSortFilter(bool spacebody)
```

```csharp
public void UpdateSpaceBodiesListVisibility()
```

```csharp
public void UpdateHabSitesListVisibility()
```

```csharp
public void OnSelectInputBox()
```

```csharp
public void OnDeSelectInputBox(bool spacebody)
```

```csharp
public void UpdateProspectedFilter()
```

```csharp
public void OnClickHabSortButton(int sortValue)
```

```csharp
public void OnChangeHabSiteSort(int sortBy)
```

```csharp
public void UpdateHabSiteSort()
```

```csharp
public void UpdateLeaderPopup(TIFactionState faction)
```

```csharp
public void OnCloseLeaderPopupClicked()
```

```csharp
public void ShowAlienTabUITutorial()
```

```csharp
public void ShowFactionTabUITutorial()
```

```csharp
public void ShowGlobalTabUITutorial()
```

```csharp
public void ShowSpaceTabUITutorial()
```

```csharp
public void ShowTransferPlannerTabUITutorial()
```

```csharp
public void ShowProspectingTabUITutorial()
```

```csharp
private void HideTutorials()
```

```csharp
public void Tutorial_ConfigureExampleTransfer()
```

```csharp
public delegate void OnExitCallback()
```
