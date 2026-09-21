# CouncilorMissionCanvasController

*Decompiled from `PavonisInteractive/TerraInvicta/CouncilorMissionCanvasController.cs`.*


## Class `CouncilorMissionCanvasController`

```csharp
public class CouncilorMissionCanvasController : CanvasControllerBase, ICanvas
```

### Fields

| Name | Type |
|---|---|
| `missionTemplate` | private TIMissionTemplate |
| `modifierPanesOpen` | public bool |
| `MissionHasCost` | private bool |
| `UseResourceSlider` | private bool |
| `UseFixedResourceCost` | private bool |
| `myCouncilorPanel` | public Canvas |
| `myCouncilorPanelGraphicRaycaster` | public GraphicRaycaster |
| `myCouncilorHeader` | public TMP_Text |
| `councilorName` | public TMP_Text |
| `councilorCurrentMission` | public TMP_Text |
| `councilorType` | public TMP_Text |
| `councilorBackgroundImage` | public Image |
| `myCouncilorVideo` | public VideoPlayer |
| `myCouncilorStillImage` | public Image |
| `factionIcon` | public Image |
| `per` | public TMP_Text |
| `inv` | public TMP_Text |
| `esp` | public TMP_Text |
| `cmd` | public TMP_Text |
| `adm` | public TMP_Text |
| `sci` | public TMP_Text |
| `sec` | public TMP_Text |
| `loy` | public TMP_Text |
| `perTitle` | public TMP_Text |
| `invTitle` | public TMP_Text |
| `espTitle` | public TMP_Text |
| `cmdTitle` | public TMP_Text |
| `admTitle` | public TMP_Text |
| `sciTitle` | public TMP_Text |
| `secTitle` | public TMP_Text |
| `loyTitle` | public TMP_Text |
| `myLoyaltyTip` | public TooltipTrigger |
| `statusIcon` | public Image |
| `statusText` | public TMP_Text |
| `statusIconTooltip` | public TooltipTrigger |
| `statusTextTooltip` | public TooltipTrigger |
| `myCouncilorBackgroundImageInitialPosition` | private Vector3 |
| `myCouncilorDataDirty` | private bool |
| `trackingMePanel` | public GameObject |
| `trackingMeList` | public ListManagerBase |
| `trackingMeTip` | public TooltipTrigger |
| `councilorXPText` | public TMP_Text |
| `automateButtonText` | public TMP_Text |
| `automateTooltip` | public TooltipTrigger |
| `actionsPanel` | public GameObject |
| `actionList` | public ListManagerBase |
| `missionInfoPanel` | public GameObject |
| `missionDisplayName` | public TMP_Text |
| `missionDescription` | public TMP_Text |
| `namePanel` | public GameObject |
| `clockPips` | public PipListItemController[] |
| `actionOptionsPanel` | public GameObject |
| `originalTargetingColor` | private Color |
| `cancelTargettingColor` | public Color |
| `missionName` | public TMP_Text |
| `confirmButton` | public Button |
| `missionArrowLeft` | public GameObject |
| `missionArrowRight` | public GameObject |
| `costPanel` | private Transform |
| `resourcesType` | public TMP_Text |
| `resourcesSlider` | public Slider |
| `resourceValue` | public TMP_Text |
| `fixedResourcesType` | public TMP_Text |
| `resourcesSliderObject` | public GameObject |
| `targetDropdown` | public TMP_Dropdown |
| `successOrFailurePanel` | public GameObject |
| `successOrFailureText` | public TMP_Text |
| `successOrFailureValue` | public TMP_Text |
| `bonusList` | public ListManagerBase |
| `penaltyList` | public ListManagerBase |
| `councilorHeaderText` | public TMP_Text |
| `targetHeaderText` | public TMP_Text |
| `activeButton` | private CouncilorMissionButtonController |
| `myCouncilor` | private TICouncilorState |
| `nextCouncilor` | private TICouncilorState |
| `currentTargeting` | private TIMissionTargeting |
| `currentTarget` | private TIGameState |
| `resourcesSpend` | private float |
| `enemyCouncilorInfoPanel` | public Canvas |
| `enemyCouncilorGraphicRaycaster` | public GraphicRaycaster |
| `enemyCouncilorHeader` | public TMP_Text |
| `enemyCouncilorName` | public TMP_Text |
| `enemyCouncilorCurrentMission` | public TMP_Text |
| `enemyCouncilorType` | public TMP_Text |
| `enemyCouncilorBackgroundImage` | public Image |
| `enemyCouncilorVideo` | public VideoPlayer |
| `enemyCouncilorStillImage` | public Image |
| `enemyFactionIcon` | public Image |
| `enemyPer` | public TMP_Text |
| `enemyInv` | public TMP_Text |
| `enemyEsp` | public TMP_Text |
| `enemyCmd` | public TMP_Text |
| `enemyAdm` | public TMP_Text |
| `enemySci` | public TMP_Text |
| `enemySec` | public TMP_Text |
| `enemyLoy` | public TMP_Text |
| `enemyPerTitle` | public TMP_Text |
| `enemyInvTitle` | public TMP_Text |
| `enemyEspTitle` | public TMP_Text |
| `enemyCmdTitle` | public TMP_Text |
| `enemyAdmTitle` | public TMP_Text |
| `enemySciTitle` | public TMP_Text |
| `enemySecTitle` | public TMP_Text |
| `enemyLoyTitle` | public TMP_Text |
| `enemyCouncilorHometownObject` | public GameObject |
| `enemyCouncilorHometown` | public TMP_Text |
| `enemyCouncilorAgeObject` | public GameObject |
| `enemyCouncilorAge` | public TMP_Text |
| `enemyCouncilorTraitsListHeader` | public GameObject |
| `enemyCouncilorTraitsHeader` | public TMP_Text |
| `enemyLoyaltyTip` | public TooltipTrigger |
| `enemyCouncilorStatusIcon` | public Image |
| `enemyCouncilorStatusText` | public TMP_Text |
| `enemyCouncilorIconStatusTooltip` | public TooltipTrigger |
| `enemyCouncilorTextStatusTooltip` | public TooltipTrigger |
| `turnedEnemyCouncilorFailurePanel` | public GameObject |
| `turnedEnemyCouncilorFailureText` | public TMP_Text |
| `turnedEnemyCouncilorSlider` | public Slider |
| `enemyCouncilorBackgroundImageInitialPosition` | private Vector3 |
| `enemyCouncilorDataDirty` | private bool |
| `_modifierAnimator` | private Animator |
| `enemyCouncilorDataPanel` | public GameObject |
| `enemyCouncilorMissionsButton` | public GameObject |
| `enemyCouncilorOrgsButton` | public GameObject |
| `enemyCouncilorTraitsButton` | public GameObject |
| `enemyCouncilorTraitsList` | public ListManagerBase |
| `enemyCouncilorOrgsList` | public ListManagerBase |
| `enemyCouncilorMissionsList` | public ListManagerBase |
| `enemyCouncilorTabManager` | public TabbedPaneManager |
| `traitsTabController` | public TabbedPaneController |
| `orgsTabController` | public TabbedPaneController |
| `missionsTabController` | public TabbedPaneController |
| `traitsTabText` | public TMP_Text |
| `orgsTabText` | public TMP_Text |
| `missionsTabText` | public TMP_Text |
| `missionPhaseControlsCanvas` | public Canvas |
| `confirmAssignmentsButton` | public Button |
| `councilProgressListItemPrefab` | public GameObject |
| `councilStatusPanel` | public GameObject |
| `councilProgressContent` | public Transform |
| `confirmAssignmentsText` | public TMP_Text |
| `unassignedWarningPanel` | public GameObject |
| `unassignedWarningHeader` | public TMP_Text |
| `unassignedWarningPrompt` | public TMP_Text |
| `unassignedWarningConfirmButton` | public TMP_Text |
| `unassignedWarningDeclineButton` | public TMP_Text |
| `showCouncilList` | private bool |
| `AIPlayerCount` | private int |
| `assignmentsArrowLeft` | public GameObject |
| `assignmentsArrowRight` | public GameObject |
| `abortButtonGameObject` | public GameObject |
| `abortButtonText` | public TMP_Text |
| `abortConfirmUI` | public GameObject |
| `abortWarningHeader` | public TMP_Text |
| `abortWarningBody` | public TMP_Text |
| `abortConfirmButtonText` | public TMP_Text |
| `abortCancelButtonText` | public TMP_Text |
| `CouncilorMissionCanvasUITutorial` | public UITutorialController |
| `SelectCouncilorTutorialController` | public UITutorialController |
| `confirmFlashOnTime` | public float |
| `confirmFlashOffTime` | public float |
| `_confirmAssignmentsNextFlashTime` | private float |
| `_isConfirmAssignmentsHovered` | private bool |
| `_isConfirmAssignmentsFlashOn` | private bool |
| `needToForceCouncilorSelection` | private bool |
| `forceAllowMissions` | public bool |
| `clearingMyCouncilorVideo` | private bool |
| `maxMissionsWidth` | private const int |
| `targetOptionData` | private Dictionary<int, TIGameState> |
| `reverseTargetOptionData` | private Dictionary<TIGameState, int> |
| `orgTargetingCanvas` | public Canvas |
| `orgTargetingCanvasRaycaster` | public GraphicRaycaster |
| `orgMaximizeListButton` | public Button |
| `orgListManager` | public ListManagerBase |
| `orgTargetModels` | public List<OrgTargetingListItemModel> |
| `orgTargetingListAdapter` | public OrgTargetingListAdapter |
| `orgListHeader` | public TMP_Text |
| `orgToHitColumnHeader` | public TMP_Text |
| `orgNameColumnHeader` | public TMP_Text |
| `orgTechColumnHeader` | public TMP_Text |
| `orgTargetingToHitTip` | public TooltipTrigger |
| `orgTargetingCouncilorCantGainTip` | public TooltipTrigger |
| `orgTargetingCouncilorTip` | public TooltipTrigger |
| `orgTargetingTierTip` | public TooltipTrigger |
| `orgTargetingOrgNameTip` | public TooltipTrigger |
| `orgTargetingPersuasionTip` | public TooltipTrigger |
| `orgTargetingInvestigationTip` | public TooltipTrigger |
| `orgTargetingEspionageTip` | public TooltipTrigger |
| `orgTargetingCommandTip` | public TooltipTrigger |
| `orgTargetingAdministrationTip` | public TooltipTrigger |
| `orgTargetingScienceTip` | public TooltipTrigger |
| `orgTargetingSecurityTip` | public TooltipTrigger |
| `orgTargetingMoneyTip` | public TooltipTrigger |
| `orgTargetingInfluenceTip` | public TooltipTrigger |
| `orgTargetingOperationsTip` | public TooltipTrigger |
| `orgTargetingResearchTip` | public TooltipTrigger |
| `orgTargetingBoostTip` | public TooltipTrigger |
| `orgTargetingMissionControlGrantTip` | public TooltipTrigger |
| `orgTargetingProjectsTip` | public TooltipTrigger |
| `orgTargetingEconomyTip` | public TooltipTrigger |
| `orgTargetingWelfareTip` | public TooltipTrigger |
| `orgTargetingEnvironmentTip` | public TooltipTrigger |
| `orgTargetingKnowledgeTip` | public TooltipTrigger |
| `orgTargetingGovernmentTip` | public TooltipTrigger |
| `orgTargetingUnityTip` | public TooltipTrigger |
| `orgTargetingMilitaryTip` | public TooltipTrigger |
| `orgTargetingOppressionTip` | public TooltipTrigger |
| `orgTargetingFundingTip` | public TooltipTrigger |
| `orgTargetingSpoilsTip` | public TooltipTrigger |
| `orgTargetingSpaceflightTip` | public TooltipTrigger |
| `orgTargetingMissionControlPriorityTip` | public TooltipTrigger |
| `orgTargetingSpaceMiningTip` | public TooltipTrigger |
| `orgTargetingTechBonusTip` | public TooltipTrigger |
| `orgTargetingMissionsTip` | public TooltipTrigger |
| `orgEntries` | private Dictionary<TIOrgState, TargetOrgListItemController> |
| `orgSortAscending` | private bool |
| `orgTargetMaxCount` | private int |
| `OrgSortColumn` | private enum |

### Properties

- `public TICouncilorState enemyCouncilor`

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
private void RestoreCouncilorActionCanvas(InfoScreenClosed e)
```

```csharp
private void ResetOnStart(MissionPhaseRestart e)
```

```csharp
private void ResetOnStart(TimeEventStart e)
```

```csharp
private void ResetOnComplete(TimeEventComplete e)
```

```csharp
private void UpdateCouncilorStatus(CouncilorMissionUpdated e)
```

```csharp
public void UpdateMyCouncilorPanel(CouncilorValuesChanged e)
```

```csharp
public void UpdateMyCouncilorPanel(CouncilorMissionUpdated e)
```

```csharp
public void UpdateMyCouncilorPanel(CouncilorVisibilityChanged e)
```

```csharp
public void UpdateEnemyCouncilorPanel(CouncilorValuesChanged e)
```

```csharp
public void UpdateEnemyCouncilorPanel(CouncilorMissionUpdated e)
```

```csharp
public void UpdateEnemyCouncilorPanel(CouncilorVisibilityChanged e)
```

```csharp
public void OnNaturalSpaceObjectSelected(SpaceBodySelectedEvent e)
```

```csharp
public void OnNaturalSpaceObjectSelected(LagrangePointSelectedEvent e)
```

```csharp
public void OnNaturalSpaceObjectSelected(TINaturalSpaceObjectState spaceObject)
```

```csharp
private void CouncilorSelected(CouncilorMapItemSelected e)
```

```csharp
private void CouncilorSelected(CouncilorSelectedOffMap e)
```

```csharp
public void OnDeTargetCouncilors(DeTargetCouncilors e)
```

```csharp
public void OnCouncilCompositionChanged(CouncilCompositionChanged e)
```

```csharp
public void OnFactionFinalizesMissions(FactionFinalizesMissions e)
```

```csharp
public void CheckReleaseUIToPlayer()
```

```csharp
private void StartMissionPhase(bool initial = false)
```

```csharp
public void PlayerConfirmsMissionAssignments()
```

```csharp
private void CheckForCloseCanvas()
```

```csharp
public void OnCompleteAssignmentsClick()
```

```csharp
public void OnCompleteAssignmentsMouseEnter()
```

```csharp
public void OnCompleteAssignmentsMouseExit()
```

```csharp
public void OnConfirmGoForwardClicked()
```

```csharp
public void OnDeclineGoForwardClicked()
```

```csharp
public void OnGotoMyCouncilorClicked()
```

```csharp
public void OnGotoEnemyCouncilorClicked()
```

```csharp
public void ItemSelected()
```

```csharp
public void OnClickCloseMyCouncilorPanel()
```

```csharp
public void OnClickExitEnemyCouncilorPanel()
```

```csharp
public void OnClickCloseTargetSelectionButton()
```

```csharp
public void OnClickAbortMissionButtion()
```

```csharp
public void OnClickAbortConfirmButtion()
```

```csharp
public void OnClickCancelAbortButton()
```

```csharp
private void OnCouncilorAutomationStatusChanged(CouncilorChangesAutoDefenseMode e)
```

```csharp
public void OnClickAutomateButton()
```

```csharp
private void SetAutomateButtonText()
```

```csharp
private string SetAutomateCouncilorTooltip()
```

```csharp
private void ForcePlayerNewCouncilor()
```

```csharp
private void ForcePlayerNewCouncilorAndFocusCamera()
```

```csharp
public void CouncilorSelected(TICouncilorState councilor)
```

```csharp
public void SetMyCouncilor(TICouncilorState councilor)
```

```csharp
public void SetEnemyCouncilor(TICouncilorState councilor)
```

```csharp
public void ReverseSelectionTriggered(TIMissionTemplate mission, TICouncilorState councilor, TIGameState target)
```

```csharp
private void ResetMissionDisplayElements()
```

```csharp
private void AddMyCouncilorListeners()
```

```csharp
private void RemoveMyCouncilorListeners()
```

```csharp
private void SetMyCouncilorPanel()
```

```csharp
private void AddEnemyCouncilorListeners()
```

```csharp
private void RemoveEnemyCouncilorListeners()
```

```csharp
private void SetEnemyCouncilorPanel()
```

```csharp
private void ResetDisplay()
```

```csharp
private void UpdateMyCouncilorPanel()
```

```csharp
private void UpdateEnemyCouncilorPanel()
```

```csharp
private void UpdateMyCouncilorBackground(CouncilorView councilorView)
```

```csharp
private IEnumerator UpdateCouncilorBackgroundNextFrame(CouncilorView councilorView, bool isEnemyCouncilor)
```

```csharp
private void UpdateEnemyCouncilorBackground(CouncilorView councilorView)
```

```csharp
private IEnumerator PlayVideoWhenPrepared(VideoPlayer videoPlayer)
```

```csharp
public static string LoyaltyTip(TIFactionState activePlayer, TICouncilorState viewedCouncilor)
```

```csharp
public void CloseMyCouncilorPanel()
```

```csharp
public void CloseEnemyCouncilorPanel()
```

```csharp
private void ShowMissionDetails(bool active = true)
```

```csharp
private void SetMissionInfo(TIMissionTemplate missionType)
```

```csharp
private void ShowMissionIcons(bool active = true)
```

```csharp
private CouncilorMissionButtonController FindActionButton(TIMissionTemplate mission)
```

```csharp
private void UpdateCouncilorActionBar()
```

```csharp
public void OnMissionSelected(CouncilorMissionButtonController button, TIGameState forcedTarget = null)
```

```csharp
public void OnMissionPointerEnter(CouncilorMissionButtonController button)
```

```csharp
public void OnMissionPointerExit(CouncilorMissionButtonController button)
```

```csharp
private void OnFactionResourcesUpdated(FactionResourcesUpdated e)
```

```csharp
private void UpdateResourcePanel()
```

```csharp
private void SetResourceAmount(float newValue)
```

```csharp
public void OnResourceSliderChangedValue(float newValue)
```

```csharp
private void InitTargetSelection(TIGameState forcedTarget = null)
```

```csharp
private void UpdateAllMissionData(bool populateTargets)
```

```csharp
public void ShutdownTargetSelection(bool reset)
```

```csharp
private void OnNewMissionTarget(MissionTargettedEvent e)
```

```csharp
private void FillOutTargetDropdown(IList<TIGameState> targets)
```

```csharp
private void SetDropdownCaption()
```

```csharp
public void OnTargetDropDownChanged()
```

```csharp
public void InitializeOrgList()
```

```csharp
public void OpenOrgTargetingPanel()
```

```csharp
public void CloseOrgTargetingPanel()
```

```csharp
public void SetOrgTargetPanel(IList<TIGameState> targets)
```

```csharp
public void OnMinimizeOrgTargetingPanel()
```

```csharp
public void OnMaximizeOrgTargetingPanel()
```

```csharp
public void OnConfirmOrgTarget()
```

```csharp
public void SortOrgTargetTable(int sortTarget)
```

```csharp
public TICouncilorState GetNextMissionlessCouncilor(TICouncilorState councilor)
```

```csharp
public void OnConfirmMissionClick()
```

```csharp
public void OnMissionConfirmHover()
```

```csharp
public void OnMissionConfirmStopHover()
```

```csharp
protected void ShowMissionOutome(bool active = true)
```

```csharp
public void ModifierToggleClicked()
```

```csharp
public void UpdateMissionModifiers()
```

```csharp
private void UpdateModifierList(List<TIMissionModifier> modifierList, ListManagerBase uiList, bool hidden, float total = 0f)
```

```csharp
public void SetAutoFailText()
```

```csharp
public void OnTurnedSliderChangedValue()
```

```csharp
private void HideTutorials()
```

```csharp
private void UpdateCouncilList()
```

```csharp
private void AdjustListLength(int desiredLength, Transform listTransform, GameObject prefab)
```

```csharp
public override void OnDestroy()
```
