# ResearchScreenController

*Decompiled from `PavonisInteractive/TerraInvicta/ResearchScreenController.cs`.*


## Class `ResearchScreenController`

```csharp
public class ResearchScreenController : CanvasControllerBase, IInfoScreen, ICanvas
```

### Fields

| Name | Type |
|---|---|
| `primaryResearchPanel` | public Canvas |
| `primaryPanelTransform` | public RectTransform |
| `researchUITutorialController` | public UITutorialController |
| `archivesUITutorialController` | public UITutorialController |
| `techTreeUITutorialController` | public UITutorialController |
| `modifiersUITutorialController` | public UITutorialController |
| `researchPanelGrid` | public ResearchPanelController[] |
| `tabbedPaneManager` | public TabbedPaneManager |
| `researchTab` | public TabbedPaneController |
| `techTreeTab` | public TabbedPaneController |
| `researchTabText` | public TMP_Text |
| `archiveTabText` | public TMP_Text |
| `techTreeTabText` | public TMP_Text |
| `researchPanelHeader` | public TMP_Text |
| `globalResearchHeader` | public TMP_Text |
| `councilEngineeringHeader` | public TMP_Text |
| `mainGridObject` | public GameObject |
| `orgProjectBackground` | public Image |
| `orgProjectRequiredExplainer` | public TMP_Text |
| `habProjectBackground` | public Image |
| `habProjectRequiredExplainer` | public TMP_Text |
| `rightButtonOverlayPanel` | public Canvas |
| `archivesOverlayPanel` | public Canvas |
| `archivedTechsList` | public ListManagerBase |
| `archiveTechDetailScrollRect` | public ScrollRect |
| `archiveHeadline` | public TMP_Text |
| `archiveCategory` | public TMP_Text |
| `archiveSummary` | public TMP_Text |
| `archiveBody` | public TMP_Text |
| `archiveCategoryIcon` | public Image |
| `archiveCategoryDescription` | public TMP_Text |
| `archiveTechIcon` | public Image |
| `selectedArchiveEntry` | private string |
| `archiveOverlayTitle` | public TMP_Text |
| `archiveSearchTitle` | public TMP_Text |
| `archiveSearchInput` | public TMP_InputField |
| `selectProjectOverlay` | public Canvas |
| `selectProjectOverlayTitle` | public TMP_Text |
| `changingProjectSlot` | private int |
| `availableProjectsList` | public ListManagerBase |
| `selectProjectTextDetailScrollRect` | public ScrollRect |
| `availableProjectHeadline` | public TMP_Text |
| `availableProjectSummary` | public TMP_Text |
| `availableProjectBody` | public TMP_Text |
| `availableProjectTechCategoryName` | public TMP_Text |
| `availableProjectTechCategoryIcon` | public Image |
| `availableProjectTechCategoryText` | public TMP_Text |
| `availableProjectImage` | public Image |
| `selectProjectButtonText` | public TMP_Text |
| `selectProjectTechTreeButton` | public Button |
| `selectedProjectEntry` | private string |
| `sortProjectDropdown` | public TMP_Dropdown |
| `projectSortAscendToggle` | public Toggle |
| `projectSortObsoleteToggle` | public Toggle |
| `projectSortByText` | public TMP_Text |
| `projectSortAscendText` | public TMP_Text |
| `projectSortObsoleteText` | public TMP_Text |
| `currentProjectSort` | private ResearchScreenController.SortProjectDataBy |
| `lastProjectSort` | private int |
| `projectSortAscend` | private bool |
| `projectSortShowObsolete` | private bool |
| `selectTechOverlay` | public Canvas |
| `selectTechSlot` | private int |
| `availableTechsList` | public ListManagerBase |
| `selectTechTextDetailScrollRect` | public ScrollRect |
| `availableTechHeadline` | public TMP_Text |
| `availableTechSummary` | public TMP_Text |
| `availableTechBody` | public TMP_Text |
| `availableTechImage` | public Image |
| `selectTechOverlayTitle` | public TMP_Text |
| `selectTechButtonText` | public TMP_Text |
| `availableTechTechCategoryName` | public TMP_Text |
| `availableTechTechCategoryIcon` | public Image |
| `availableTechTechCategoryText` | public TMP_Text |
| `selectTechTechTreeButton` | public Button |
| `selectedTechEntry` | private string |
| `sortTechDropdown` | public TMP_Dropdown |
| `techSortAscendToggle` | public Toggle |
| `techSortByText` | public TMP_Text |
| `techSortAscendText` | public TMP_Text |
| `currentTechSort` | private ResearchScreenController.SortTechDataBy |
| `lastTechSort` | private int |
| `techSortAscend` | private bool |
| `effectsTabText` | public TMP_Text |
| `effectsBreakdownCanvas` | public Canvas |
| `effectsContextList` | public ListManagerBase |
| `effectsSearchInput` | public TMP_InputField |
| `effectsSearchTitle` | public TMP_Text |
| `effectsHeaderText` | public TMP_Text |
| `effectsGeneralExplainerText` | public TMP_Text |
| `selectedContextNameText` | public TMP_Text |
| `primarySelectedEffectListingText` | public TMP_Text |
| `totalEffectListingText` | public TMP_Text |
| `selectedContext` | private Context |
| `initProjectSortSettings` | private bool |
| `initTechSortSettings` | private bool |
| `globalResearchState` | private TIGlobalResearchState |
| `techTreeMasterObject` | public GameObject |
| `techTreeTitle` | public TMP_Text |
| `selectedTechPanel` | public GameObject |
| `selectedTech` | private TIGenericTechTemplate |
| `selectedTechName` | public TMP_Text |
| `selectedTechStatus` | public TMP_Text |
| `selectedTechDetail` | public TMP_Text |
| `selectedTechIcon` | public Image |
| `prereq1MasterPanel` | public GameObject |
| `prereq1TechName` | public TMP_Text |
| `prereq1Status` | public TMP_Text |
| `prereq1Icon` | public Image |
| `orText` | public TMP_Text |
| `orPanel` | public GameObject |
| `altPrereq1Panel` | public GameObject |
| `altPrereq1TechName` | public TMP_Text |
| `altPrereq1Status` | public TMP_Text |
| `altPrereq1Icon` | public Image |
| `prereq2MasterPanel` | public GameObject |
| `prereq2TechName` | public TMP_Text |
| `prereq2Status` | public TMP_Text |
| `prereq2Icon` | public Image |
| `prereq3MasterPanel` | public GameObject |
| `prereq3TechName` | public TMP_Text |
| `prereq3Status` | public TMP_Text |
| `prereq3Icon` | public Image |
| `prereq4MasterPanel` | public GameObject |
| `prereq4TechName` | public TMP_Text |
| `prereq4Status` | public TMP_Text |
| `prereq4Icon` | public Image |
| `otherRequirementsMasterPanel` | public GameObject |
| `otherRequirementsList` | public TMP_Text |
| `childTechsGrid` | public ListManagerBase |
| `prereqArrow` | public Image |
| `childArrow` | public Image |
| `usingFullTechTree` | private bool |
| `addProjects` | private bool |
| `isFullTechTreeInit` | private bool |
| `isFullTechTreeInitNP` | private bool |
| `selectedTechPanelObject` | public GameObject |
| `selectedTechPanelTopGradient` | public Image |
| `selectedTechPanelStatusGradient` | public Image |
| `selectedTechPanelCategoryIcon` | public Image |
| `selectedTechPanelTechName` | public TMP_Text |
| `selectedTechPanelTechCategory` | public TMP_Text |
| `selectedTechPanelTechStatus` | public TMP_Text |
| `selectedTechPanelTechCostLabel` | public TMP_Text |
| `selectedTechPanelTechPathCostLabel` | public TMP_Text |
| `selectedTechPanelTechCost` | public TMP_Text |
| `selectedTechPanelTechPathCost` | public TMP_Text |
| `selectedTechPanelTechSummary` | public TMP_Text |
| `selectedTechPanelRequiresHeaderText` | public TMP_Text |
| `selectedTechPanelUnlocksHeaderText` | public TMP_Text |
| `selectedTechPanelRequirementList` | public ListManagerBase |
| `selectedTechPanelUnlocksList` | public ListManagerBase |
| `selectedLongTermTechButton` | public Button |
| `selectedTechPanelLongTermButtonText` | public TMP_Text |
| `selectedTechPanelLongTermButtonTooltip` | public TooltipTrigger |
| `fullTechTreeOn` | public static bool |
| `techTreeHeader` | public TMP_Text |
| `treeSwapButtonText` | public TMP_Text |
| `treeSimpleButtonText` | public TMP_Text |
| `closeSelectiveTreeButtonText` | public TMP_Text |
| `fullTechTreeObject` | public GameObject |
| `fullTechTreeContent` | public RectTransform |
| `FullTechTreeGridManager` | public ListManagerBase |
| `techTreeItemPrefab` | public GameObject |
| `prereqLineContainer` | public GameObject |
| `selectedFullTech` | public GameObject |
| `nodeContainer` | public GameObject |
| `fullTechTreeCanvas` | public Canvas |
| `FullTechTreeScrollRect` | public ScrollRect |
| `techTreeHeaderNP` | public TMP_Text |
| `fullTechTreeObjectNP` | public GameObject |
| `fullTechTreeContentNP` | public RectTransform |
| `fullTechTreeGridManagerNP` | public ListManagerBase |
| `prereqLineContainerNP` | public GameObject |
| `nodeContainerNP` | public GameObject |
| `fullTechTreeCanvasNP` | public Canvas |
| `FullTechTreeScrollRectNP` | public ScrollRect |
| `selectiveTechTreeHeader` | public TMP_Text |
| `selectiveTechTreeObject` | public GameObject |
| `selectiveTechTreeContent` | public RectTransform |
| `selectiveTechTreeGridManager` | public ListManagerBase |
| `selectiveTechTreePrereqLineContainer` | public GameObject |
| `selectiveNodeContainer` | public GameObject |
| `selectiveTechTreeCanvas` | public Canvas |
| `SelectiveTechTreeScrollRect` | public ScrollRect |
| `controllerForSelectiveTree` | public ChildTechGridItemController |
| `treeNodes` | public List<GameObject> |
| `selectiveTechList` | public List<ChildTechGridItemController> |
| `mainTechObjectList` | public List<ChildTechGridItemController> |
| `noProjectTechList` | public List<ChildTechGridItemController> |
| `currentTechContent` | private RectTransform |
| `currentListManager` | private ListManagerBase |
| `currentPrereqLineContainer` | public GameObject |
| `currentNodeContainer` | private GameObject |
| `techTreeContentToScale` | private Transform |
| `currentTechTreeViewed` | public ResearchScreenController.techTreeType |
| `techTreeZoomObject` | public GameObject |
| `techTreeZoomSlider` | public Slider |
| `techTreeZoomText` | public TMP_Text |
| `searchFieldTechs` | public TMP_InputField |
| `searchResultsTechs` | public ListManagerBase |
| `searchPanelTechs` | public RectTransform |
| `searchFieldProjects` | public TMP_InputField |
| `searchResultsProjects` | public ListManagerBase |
| `searchPanelProjects` | public RectTransform |
| `searchPanelHeaderTechs` | public TMP_Text |
| `searchPanelHeaderProjects` | public TMP_Text |
| `searchPanelHeaderFullTechs` | public TMP_Text |
| `searchPanelHeaderFullProjects` | public TMP_Text |
| `fullSearchTechs` | public Toggle |
| `fullSearchProjects` | public Toggle |
| `researchTargetText` | public TMP_Text |
| `researchTargetObject` | public GameObject |
| `selectiveMode` | private bool |
| `sortedTechList` | public List<ChildTechGridItemController> |
| `techVisited` | private List<bool> |
| `totalVisited` | private int |
| `lastNode` | private int |
| `endGameTechs` | private int |
| `nodeCountLimit` | private readonly int |
| `nodeCounts` | private List<int> |
| `contentHeight` | private float |
| `contentWidth` | private float |
| `openingSelectiveTree` | public bool |
| `normalConnectionLineWidth` | public float |
| `highlightedConnectionLineWidth` | public float |
| `techNameColorSelected` | public Color32 |
| `techNameColorDeSelected` | public Color32 |
| `connectionColorNeutral` | public Color32 |
| `connectionColorDeSelected` | public Color32 |
| `connectionColorDownstream` | public Color32 |
| `connectionColorUpstream` | public Color32 |
| `connectionColorResearched` | public Color32 |
| `connectionColorOrPrereq` | public Color32 |
| `techStatusGradient` | public List<Sprite> |
| `techStatusIconColors` | public List<Color32> |
| `techStatusColor` | private static readonly Color32[] |
| `lerpFrames` | private int |
| `moving` | private bool |
| `cachedSelectedTech` | private TIGenericTechTemplate |
| `cachedItemController` | private ChildTechGridItemController |
| `techTreeType` | public enum |
| `SortProjectDataBy` | public enum |
| `SortTechDataBy` | public enum |

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
public override void HideNoCache()
```

```csharp
public override void Refresh()
```

```csharp
public override bool Visible()
```

```csharp
public void CloseInfoScreen(bool toggle = false)
```

```csharp
public override void UpdateUIScaling()
```

```csharp
public void ShowResearchTutorial()
```

```csharp
public void ShowArchivesTutorial()
```

```csharp
public void ShowTechTreeTutorial()
```

```csharp
public void ShowModifiersTutorial()
```

```csharp
public void HideTutorials()
```

```csharp
public void OnArchiveButtonSelected()
```

```csharp
public void OnSelectProjectButtonSelected()
```

```csharp
public void OnSelectTechButtonSelected()
```

```csharp
public void ExitResearchScreen()
```

```csharp
public void OnSelectCloseandPlay()
```

```csharp
public void ExitRightPanel()
```

```csharp
public void SetSelectedArchiveEntry(string dataName)
```

```csharp
public void HighlightSelectedArchiveEntry(string entryDataName = "")
```

```csharp
public void ExitArchivePanel()
```

```csharp
public void ExitSelectProjectPanel()
```

```csharp
public void ExitSelectTechPanel()
```

```csharp
private int GetFirstRequiredSlot(TIFactionState faction)
```

```csharp
private int GetLowestTechFactionWon(TIFactionState faction)
```

```csharp
private void OnProjectSelectedRemotely(ProjectSelectedFromRemoteUI e)
```

```csharp
private void PushProjectSelection(ForceProjectSelectionUI e)
```

```csharp
private void PushTechSelection(ForceTechSelectionUI e)
```

```csharp
private void ProjectUIOptionsUpdated(ProjectUIOptionsChanged e)
```

```csharp
private void ResetAllPanels()
```

```csharp
private void UpdateResearchValues(ResearchUpdated e)
```

```csharp
private void UpdateResearchValues()
```

```csharp
public void UpdateResearchLists(TIFactionState faction)
```

```csharp
public void UpdateArchivesPanel()
```

```csharp
public void UpdateArchivesPanel(TIFactionState faction)
```

```csharp
public void UpdateArchiveSearch()
```

```csharp
public void UpdateEffectsSearch()
```

```csharp
private string CategoryDescriptionAndBonus(TIFactionState faction, TIGenericTechTemplate template)
```

```csharp
public void FillOutArchiveData()
```

```csharp
public void UpdateSelectProjectPanel(TIFactionState councilState, int currentSlot)
```

```csharp
public void SetSelectedProjectEntry(string dataName)
```

```csharp
public void HighlightSelectedProjectEntry(string entryDataName = "")
```

```csharp
public void OnClickSetNewLongTermTech()
```

```csharp
public void OnChangeProjectAscendSort()
```

```csharp
public void OnChangeProjectObsoleteSort()
```

```csharp
public void OnProjectObsoleteToggle(bool isOn, string projectDataName)
```

```csharp
public void OnProjectFavoriteToggle(bool isOn, string projectDataName)
```

```csharp
public void ChangeProjectSelectionSort()
```

```csharp
public void UpdateSortedProjectList(List<GameObject> projectList)
```

```csharp
public void SetChangingProjectSlot(int slot)
```

```csharp
public void FillOutProjectData()
```

```csharp
public void UpdateSelectTechPanel(TIFactionState councilState)
```

```csharp
public void SetSelectedTechEntry(string dataName)
```

```csharp
public void HighlightSelectedTechEntry(string entryDataName = "")
```

```csharp
public void OnChangeTechAscendSort()
```

```csharp
public void OnClickChangeTechSelectionSort()
```

```csharp
public IEnumerator ChangeTechSelectionSort()
```

```csharp
public void UpdateSortedTechList(List<GameObject> techList)
```

```csharp
public void SetChangingTechSlot(int slot)
```

```csharp
public void FillOutTechData()
```

```csharp
private static string TechName(TIGenericTechTemplate genericTechTemplate)
```

```csharp
private static string TechStatusString(TIGenericTechTemplate genericTechTemplate, TIFactionState faction)
```

```csharp
private static Color TechStatusColor(TIGenericTechTemplate genericTechTemplate, TIFactionState faction)
```

```csharp
public static int GetTechStatusAppearanceIndex(TIGenericTechTemplate genericTechTemplate, TIFactionState faction)
```

```csharp
public void OnTechinTreeClicked(int value)
```

```csharp
public void OnTechSearchToggle(bool projects)
```

```csharp
public void UpdateTechSearch(bool projects = false)
```

```csharp
public void GotoSearchItem(ChildTechGridItemController techItem, ResearchScreenController.techTreeType treeType)
```

```csharp
public IEnumerator GotoSearchItemNextFrame(ChildTechGridItemController techItem, ResearchScreenController.techTreeType treeType)
```

```csharp
public IEnumerator LerpTechTreeToItem(ChildTechGridItemController techItem, ResearchScreenController.techTreeType treeType)
```

```csharp
public static string TechTreeTooltip(TIFactionState faction, TIGenericTechTemplate tech, bool simple)
```

```csharp
public static void ShowTech(TIFactionState faction, TIGenericTechTemplate tech, GameObject panel, TMP_Text techName, TMP_Text techStatus, Image icon)
```

```csharp
public void DisplayTechTree(TIGenericTechTemplate genericTech)
```

```csharp
public void InitializeFullTechTree(bool selectiveTree = false, string selectiveTech = "", bool noProjectTree = false, bool selectiveFromFull = true)
```

```csharp
private void BuildTree(List<ChildTechGridItemController> techList, bool selectiveTree = false)
```

```csharp
public void InitializeSelectiveTechTree(string dataName, string displayName, bool fullTree)
```

```csharp
public void InitializeNoProjectTechTree()
```

```csharp
private void PlaceTechsBehindPrereqs()
```

```csharp
private void PlaceTechsBehindLowerCosts()
```

```csharp
public void HandleEndGameTechs()
```

```csharp
private IEnumerator ToggleTechVisibility(bool fullTree = false)
```

```csharp
private void ToggleTechLineVisibility()
```

```csharp
public void PlaceTechsBehindSameTierPrereqs()
```

```csharp
public IEnumerator SetGridParent()
```

```csharp
public IEnumerator SetupSpacing()
```

```csharp
private void AlignTechsToPrereqs()
```

```csharp
private void AlignTechsToUnlocks()
```

```csharp
private void AlignTechsWithNoPrereqToUnlocks()
```

```csharp
private void AlignProjectsToUnlocks()
```

```csharp
private void SetContentHeight()
```

```csharp
private void PushTechsAway()
```

```csharp
private void SpaceTechBranches()
```

```csharp
public IEnumerator SetupConnections()
```

```csharp
public void DrawConnections(ChildTechGridItemController controller, TIGenericTechTemplate tech, bool altReq0 = false, bool altReq1 = false)
```

```csharp
public void ResetAllConnectionColors()
```

```csharp
public void OnClickShowFullTechTree()
```

```csharp
public void ShowFullTechTree()
```

```csharp
public void CloseFullTechTree()
```

```csharp
public void OnClickShowNoProjectTechTree()
```

```csharp
public void ShowNoProjectTechTree()
```

```csharp
public void CloseNoProjectTechTree()
```

```csharp
public void ShowSelectiveTechTree()
```

```csharp
public void OnClickCloseSelectiveTechTree()
```

```csharp
public void CloseSelectiveTechTree()
```

```csharp
private void ClearSelectiveTechTreeData()
```

```csharp
public void RefreshTechTreeStatuses()
```

```csharp
public void UpdateSelectedTechPanel(TIGenericTechTemplate tech, ChildTechGridItemController itemController)
```

```csharp
public void UpdateLongTermTechTargetButtonText()
```

```csharp
public void OnClickCloseSelectedTechPanel(bool clearName)
```

```csharp
public void CloseSelectedTechPanel(bool clearName = true)
```

```csharp
public void UpdateTechTreeZoomSlider()
```

```csharp
public void UpdateResearchTargetText()
```

```csharp
public void UpdateTechTreeZoom()
```

```csharp
public void IncreaseTechTreeZoom()
```

```csharp
public void DecreaseTechTreeZoom()
```

```csharp
private void ToggleTechTreeMoveScrolling(bool allow)
```

```csharp
public static string EffectContextToString(Context context)
```

```csharp
private void InitializeEffectsBreakdownScreen()
```

```csharp
private void UpdateEffectsBreakdownScreen()
```

```csharp
public void OnEffectContextButtonPressed(Context context)
```

```csharp
public void HighlightSelectedEffectsEntry(Context entryContext = Context.None)
```
