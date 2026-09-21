# CouncilGridController

*Decompiled from `PavonisInteractive/TerraInvicta/CouncilGridController.cs`.*


## Class `CouncilGridController`

```csharp
public class CouncilGridController : CanvasControllerBase, IInfoScreen, ICanvas
```

### Fields

| Name | Type |
|---|---|
| `MasterCanvas` | public Canvas |
| `councilTabsManager` | public TabbedPaneManager |
| `councilTabButtonText` | public TMP_Text |
| `councilGridTabController` | public TabbedPaneController |
| `recruitTabButtonText` | public TMP_Text |
| `recruitTabController` | public TabbedPaneController |
| `ledgerTabButtonText` | public TMP_Text |
| `ledgerTabController` | public TabbedPaneController |
| `orgManagementTabButtonText` | public TMP_Text |
| `orgManagementTabController` | public TabbedPaneController |
| `calendarTabButtonText` | public TMP_Text |
| `calendarTabController` | public TabbedPaneController |
| `councilGridUITutorial` | public UITutorialController |
| `councilorSingleUITutorial` | public UITutorialController |
| `councilorRecruitingUITutorial` | public UITutorialController |
| `orgManagementUITutorial` | public UITutorialController |
| `ledgerUITutorial` | public UITutorialController |
| `calendarUITutorial` | public UITutorialController |
| `alarmClockHighlightDummy` | public GameObject |
| `orgMarketplaceButton` | public Button |
| `unassignedOrgsButton` | public Button |
| `orgTabsManager` | public TabbedPaneManager |
| `orgMarketplaceTabController` | public TabbedPaneController |
| `unassignedOrgsTabController` | public TabbedPaneController |
| `councilGridCanvas` | public Canvas |
| `helpPanel` | public GameObject |
| `CouncilName` | public TMP_Text |
| `councilorGrid` | public ListManagerBase |
| `council` | public TIFactionState |
| `BackgroundImage` | public Image[] |
| `councilSize5Notice` | public TMP_Text |
| `councilSize6Notice` | public TMP_Text |
| `turnedSlotNotice1` | public TMP_Text |
| `turnedSlotNotice2` | public TMP_Text |
| `size5Project` | private TIProjectTemplate |
| `size6Project` | private TIProjectTemplate |
| `recruitingCanvas` | public Canvas |
| `candidatesText` | public TMP_Text |
| `recruitCandidateButtonText` | public TMP_Text |
| `candidateList` | public ListManagerBase |
| `selectedCandidate` | public TICouncilorState |
| `candidateDetailCanvas` | public Canvas |
| `recruitMissionHeaderText` | public TMP_Text |
| `recruitAttributesHeaderText` | public TMP_Text |
| `recruitTraitsHeaderText` | public TMP_Text |
| `recruitIncomesHeaderText` | public TMP_Text |
| `candidateName` | public TMP_Text |
| `candidateJob` | public TMP_Text |
| `candidateLocationTitle` | public TMP_Text |
| `candidateLocation` | public TMP_Text |
| `candidateAgeTitle` | public TMP_Text |
| `candidateAge` | public TMP_Text |
| `candidateHomeRegionTitle` | public TMP_Text |
| `candidateHomeRegion` | public TMP_Text |
| `recruitCostTitle` | public TMP_Text |
| `recruitCost` | public TMP_Text |
| `candidatePersuasionText` | public TMP_Text |
| `candidatePersuasion` | public TMP_Text |
| `candidateInvestigationText` | public TMP_Text |
| `candidateInvestigation` | public TMP_Text |
| `candidateEspionageText` | public TMP_Text |
| `candidateEspionage` | public TMP_Text |
| `candidateCommandText` | public TMP_Text |
| `candidateCommand` | public TMP_Text |
| `candidateAdministrationText` | public TMP_Text |
| `candidateAdministration` | public TMP_Text |
| `candidateScienceText` | public TMP_Text |
| `candidateScience` | public TMP_Text |
| `candidateSecurityText` | public TMP_Text |
| `candidateSecurity` | public TMP_Text |
| `candidateApparentLoyaltyText` | public TMP_Text |
| `candidateLoyalty` | public TMP_Text |
| `candidateMoneyIncome` | public TMP_Text |
| `candidateMoneyText` | public TMP_Text |
| `candidateInfluenceIncome` | public TMP_Text |
| `candidateInfluenceText` | public TMP_Text |
| `candidateOpsIncome` | public TMP_Text |
| `candidateOpsText` | public TMP_Text |
| `candidateResearchIncome` | public TMP_Text |
| `candidateResearchText` | public TMP_Text |
| `candidateBoostIncome` | public TMP_Text |
| `candidateBoostText` | public TMP_Text |
| `candidateMissionControlIncome` | public TMP_Text |
| `candidateMissionControlText` | public TMP_Text |
| `candidateProjectsIncome` | public TMP_Text |
| `candidateProjectsText` | public TMP_Text |
| `candidatePersuasionTooltip` | public TooltipTrigger |
| `candidateInvestigationTooltip` | public TooltipTrigger |
| `candidateEspionageTooltip` | public TooltipTrigger |
| `candidateCommandTooltip` | public TooltipTrigger |
| `candidateAdministrationTooltip` | public TooltipTrigger |
| `candidateScienceTooltip` | public TooltipTrigger |
| `candidateSecurityTooltip` | public TooltipTrigger |
| `candidateLoyaltyTooltip` | public TooltipTrigger |
| `candidateJobTooltip` | public TooltipTrigger |
| `recruitVideo` | public VideoPlayer |
| `recruitCouncilorStillImage` | public Image |
| `recruitCandidateButton` | public Button |
| `candidateBackgroundImage` | public Image |
| `candidateBackgroundImageInitialPosition` | private Vector3 |
| `selectCandidateCanvas` | public Canvas |
| `selectCandidateWarningText` | public TMP_Text |
| `confirmRecruitBox` | public GameObject |
| `confirmRecruitDialog` | public TMP_Text |
| `confirmRecruitConfirmButtonText` | public TMP_Text |
| `confirmRecruitDeclineButtonText` | public TMP_Text |
| `candidateTraitsList` | public ListManagerBase |
| `candidateMissionsList` | public ListManagerBase |
| `councilorSingleCanvas` | public Canvas |
| `councilorSingleGameObject` | public GameObject |
| `councilorName` | public TMP_Text |
| `councilorJob` | public TMP_Text |
| `jobTooltip` | public TooltipTrigger |
| `councilorMissionTitle` | public TMP_Text |
| `councilorMission` | public TMP_Text |
| `councilorCurrentLocationTitle` | public TMP_Text |
| `councilorCurrentLocation` | public TMP_Text |
| `councilorHomeRegionTitle` | public TMP_Text |
| `councilorHomeRegion` | public TMP_Text |
| `councilorAgeTitle` | public TMP_Text |
| `councilorAge` | public TMP_Text |
| `attributesHeaderText` | public TMP_Text |
| `persuasionText` | public TMP_Text |
| `persuasion` | public TMP_Text |
| `persuasionTooltip` | public TooltipTrigger |
| `investigationText` | public TMP_Text |
| `investigation` | public TMP_Text |
| `investigationTooltip` | public TooltipTrigger |
| `espionageText` | public TMP_Text |
| `espionage` | public TMP_Text |
| `espionageTooltip` | public TooltipTrigger |
| `commandText` | public TMP_Text |
| `command` | public TMP_Text |
| `commandTooltip` | public TooltipTrigger |
| `administrationText` | public TMP_Text |
| `administration` | public TMP_Text |
| `administrationTooltip` | public TooltipTrigger |
| `scienceText` | public TMP_Text |
| `science` | public TMP_Text |
| `scienceTooltip` | public TooltipTrigger |
| `securityText` | public TMP_Text |
| `security` | public TMP_Text |
| `securityTooltip` | public TooltipTrigger |
| `LoyaltyText` | public TMP_Text |
| `apparentLoyalty` | public TMP_Text |
| `loyaltyTooltip` | public TooltipTrigger |
| `incomesHeaderText` | public TMP_Text |
| `moneyIncome` | public TMP_Text |
| `moneyText` | public TMP_Text |
| `influenceIncome` | public TMP_Text |
| `influenceText` | public TMP_Text |
| `opsIncome` | public TMP_Text |
| `opsText` | public TMP_Text |
| `researchIncome` | public TMP_Text |
| `researchText` | public TMP_Text |
| `boostIncome` | public TMP_Text |
| `boostText` | public TMP_Text |
| `mCIncome` | public TMP_Text |
| `MCText` | public TMP_Text |
| `projectsIncome` | public TMP_Text |
| `projectsText` | public TMP_Text |
| `councilorInfoObject` | public GameObject |
| `statusIcon` | public Image |
| `statusText` | public TMP_Text |
| `councilorBackgroundImage` | public Image |
| `councilorBackgroundImageInitialPosition` | private Vector3 |
| `statusTooltip` | public TooltipTrigger |
| `statusTooltipCopy` | public TooltipTrigger |
| `missionListObject` | public GameObject |
| `automateMissionsToggle` | public Toggle |
| `automateMissionsToggleText` | public TMP_Text |
| `missionsHeaderText` | public TMP_Text |
| `missionsList` | public ListManagerBase |
| `traitsHeaderText` | public TMP_Text |
| `traitsList` | public ListManagerBase |
| `councilorVideo` | public VideoPlayer |
| `singleCouncilorStillImage` | public Image |
| `councilorFactionImage` | public Image |
| `councilorFactionGradient` | public Image |
| `XPTitle` | public TMP_Text |
| `XP` | public TMP_Text |
| `XPTip` | public TooltipTrigger |
| `dismissButton` | public Button |
| `dismissButtonText` | public TMP_Text |
| `customizeButtonText` | public TMP_Text |
| `dismissPanel` | public GameObject |
| `dismissKeepButton` | public GameObject |
| `dismissSellButton` | public GameObject |
| `dismissQueryText` | public TMP_Text |
| `dismissKeepButtonText` | public TMP_Text |
| `dismissSellButtonText` | public TMP_Text |
| `dismissCancelText` | public TMP_Text |
| `councilorOrgGridTitle` | public TMP_Text |
| `factionOrgsHeaderText` | public TMP_Text |
| `marketOrgsHeaderText` | public TMP_Text |
| `councilorOrgGrid` | public ListManagerBase |
| `councilOrgGrid` | public ListManagerBase |
| `availableOrgGrid` | public ListManagerBase |
| `orgsTooltip` | public TooltipTrigger |
| `orgMarketplaceTooltip` | public TooltipTrigger |
| `unassignedOrgsTooltip` | public TooltipTrigger |
| `confirmMovePanel` | public GameObject |
| `confirmMoveQueryText` | public TMP_Text |
| `confirmPurchase` | public GameObject |
| `confirmPurchaseText` | public TMP_Text |
| `orgCostText` | public TMP_Text |
| `confirmSell` | public GameObject |
| `confirmSellText` | public TMP_Text |
| `sellValueText` | public TMP_Text |
| `cancelMoveOrg` | public GameObject |
| `moveFailureOk` | public GameObject |
| `confirmFailOKText` | public TMP_Text |
| `oKText` | public TMP_Text |
| `cancelText` | public TMP_Text |
| `infoMyOrgHeader` | public TMP_Text |
| `infoEquipOrgHeader` | public TMP_Text |
| `infoMyOrgTitle` | public TMP_Text |
| `infoEquipOrgTitle` | public TMP_Text |
| `infoMyOrgOwned` | public TMP_Text |
| `infoEquipOrgCost` | public TMP_Text |
| `infoMyOrgGradient` | public Image |
| `infoEquipOrgGradient` | public Image |
| `infoMyOrgTier` | public TMP_Text |
| `infoEquipOrgTier` | public TMP_Text |
| `infoMyOrgDesc` | public TMP_Text |
| `infoEquipOrgDesc` | public TMP_Text |
| `infoMyOrgIcon` | public Image |
| `infoEquipOrgIcon` | public Image |
| `myOrgGridRect` | public RectTransform |
| `equipOrgGridRect` | public RectTransform |
| `infoMyOrgInfoPanel` | public GameObject |
| `infoEquipInfoPanel` | public GameObject |
| `selectedOrgTop` | public OrgItemView |
| `selectedOrgBottom` | public OrgItemView |
| `orgActionButtonTextBottom` | public TMP_Text |
| `orgActionButtonTextBottom2` | public TMP_Text |
| `orgActionButtonTextTop` | public TMP_Text |
| `orgActionButtonTextTop2` | public TMP_Text |
| `orgActionButtonBottom2` | public Button |
| `orgActionButtonTop` | public Button |
| `currentCouncilor` | public TICouncilorState |
| `spendXPButton` | public Button |
| `spendXPButtonText` | public TMP_Text |
| `spendXPPanel` | public GameObject |
| `closeSpendXPButtonText` | public TMP_Text |
| `spendXPPanelHeaderText` | public TMP_Text |
| `confirmSpendXPSelectionPanel` | public GameObject |
| `confirmSpendXPPrompt` | public TMP_Text |
| `confirmSpendXPSelectionButtonText` | public TMP_Text |
| `cancelSpendXPSelectionButtonText` | public TMP_Text |
| `augmentationList` | public ListManagerBase |
| `selectedAugmentation` | private CouncilorAugmentationOption |
| `customizeCouncilorButton` | public Button |
| `customizeCouncilorButtonText` | public TMP_Text |
| `customizeCouncilorPanel` | public GameObject |
| `customizeCouncilorHeaderText` | public TMP_Text |
| `customizeCouncilorCloseButton` | public TMP_Text |
| `cycleCouncilorLeftButton` | public Button |
| `cycleCouncilorRightButton` | public Button |
| `voicePreviewCoroutine` | private Coroutine |
| `councilorDragDestination` | public DragDestination |
| `councilDragDestination` | public DragDestination |
| `availableDragDestination` | public DragDestination |
| `orgCouncilTabActive` | public bool |
| `equipOrgGrid` | public GameObject |
| `purchaseOrgAction` | private PurchaseOrgAction |
| `transferOrgAction` | private TransferOrgToFactionPoolAction |
| `sellOrgAction` | private SellOrgAction |
| `sb` | private StringBuilder |
| `eventManager` | private EventManager |
| `hasBeenShown` | private bool |
| `lookingAtTurnedCouncilor` | public bool |
| `councilorAppearanceGrid` | public ListManagerBase |
| `councilorImage` | public Image |
| `confirmChangeBioButton` | public Button |
| `filterForGender` | private CouncilorGender |
| `filterForAncestry` | private CouncilorAncestry |
| `filterForJob` | private TICouncilorTypeTemplate |
| `filterForDuplicates` | private bool |
| `proposedGivenName` | private string |
| `proposedFamilyName` | private string |
| `proposedCouncilorAppearance` | private TICouncilorAppearanceTemplate |
| `councilorPortraitsCached` | private bool |
| `councilorNameText` | public TMP_Text |
| `councilorProfessionText` | public TMP_Text |
| `councilorHomeRegionText` | public TMP_Text |
| `ancestryFilterHeader` | public TMP_Text |
| `ancestryFilterSetting` | public TMP_Text |
| `genderFilterHeader` | public TMP_Text |
| `genderFilterSetting` | public TMP_Text |
| `jobFilterHeader` | public TMP_Text |
| `jobFilterSetting` | public TMP_Text |
| `duplicateFilterHeader` | public TMP_Text |
| `duplicateFilterSetting` | public TMP_Text |
| `voiceAccentFilterHeader` | public TMP_Text |
| `voiceAccentFilterSetting` | public TMP_Text |
| `voiceIndexSelectorHeader` | public TMP_Text |
| `voiceIndexFilterSetting` | public TMP_Text |
| `confirmChangesButtonText` | public TMP_Text |
| `givenNameText` | public TMP_Text |
| `familyNameText` | public TMP_Text |
| `confirmChangeBioText` | public TMP_Text |
| `cancelChangeBioText` | public TMP_Text |
| `ancestrySettings` | private Dictionary<CouncilorAncestry, string> |
| `genderSettings` | private Dictionary<CouncilorGender, string> |
| `duplicateSettings` | private Dictionary<bool, string> |
| `proposedVoice` | private TICouncilorVoiceTemplate |
| `ancestrySetting` | private int |
| `genderSetting` | private int |
| `jobSetting` | private int |
| `accentSetting` | private int |
| `voiceIndexSetting` | private int |
| `jobTemplates` | private List<TICouncilorTypeTemplate> |
| `voiceTemplates` | private List<TICouncilorVoiceTemplate> |
| `allAccentOptions` | private Dictionary<int, string> |
| `currentAccentOptions` | private Dictionary<int, TICouncilorVoiceTemplate> |
| `testVoiceTemplate` | private readonly TIMissionTemplate |
| `givenNameEntry` | public TMP_InputField |
| `familyNameEntry` | public TMP_InputField |
| `ledger` | public Canvas |
| `ledgerRaycaster` | public GraphicRaycaster |
| `ledgerListManager` | public ListManagerBase |
| `ledgerDataModels` | private List<LedgerListItemModel> |
| `ledgerCollapseAllButtonText` | public TMP_Text |
| `ledgerExpandAllButtonText` | public TMP_Text |
| `ledgerAdapter` | public LedgerListAdapter |
| `lastLedgerSort` | private int |
| `ledgerSortDescending` | private bool |
| `orgManagementCanvas` | public Canvas |
| `orgManagementUnnassignedHeaderText` | public TMP_Text |
| `orgManagementPoolHeaderText` | public TMP_Text |
| `orgManagementCostHeaderText` | public TMP_Text |
| `orgManagementCostText` | public TMP_Text |
| `orgManagementUnnassignedOrgsCountText` | public TMP_Text |
| `orgManagementFeedbackText` | public TMP_Text |
| `orgManagementFeedbackObject` | public GameObject |
| `orgManagementCouncilorListManager` | public ListManagerBase |
| `orgManagementFactionUnnassignedOrgsListManager` | public ListManagerBase |
| `orgManagementFactionOrgPoolListManager` | public ListManagerBase |
| `orgManagementFactionUnnassignedDragDestination` | public DragDestination |
| `orgManagementFactionOrgPoolDragDestination` | public DragDestination |
| `unnassignedOrgsContainer` | public OrganizerCouncilorListItem |
| `factionPoolContainer` | public OrganizerCouncilorListItem |
| `revertOrgChangesButton` | public Button |
| `confirmOrgChangesButton` | public Button |
| `revertOrgChangesButtonText` | public TMP_Text |
| `confirmOrgChangesButtonText` | public TMP_Text |
| `orgManagementFactionIcon` | public Image |
| `orgManagementMarketIcon` | public Image |
| `tempFactionCouncilorOrgs` | public Dictionary<TIOrgState, TICouncilorState> |
| `tempFactionOrgs` | public List<TIOrgState> |
| `tempMarketPoolOrgs` | public List<TIOrgState> |
| `orgManagementChangesPending` | public bool |
| `pendingOrgChangesCost` | public TIResourcesCost |
| `calendar` | public Canvas |
| `calendarRaycaster` | public GraphicRaycaster |
| `selectedDate` | private TIDateTime |
| `visibleMonthGridList` | public ListManagerBase |
| `currentMonthDropdown` | public TMP_Dropdown |
| `currentYearDropdown` | public TMP_Dropdown |
| `cycleMonthBackwardButton` | public Button |
| `cycleYearBackwardButton` | public Button |
| `cycleMonthForwardButton` | public Button |
| `cycleYearForwardButton` | public Button |
| `resetCalendarToNowButton` | public Button |
| `resetToNowButtonText` | public TMP_Text |
| `MAX_CALENDAR_YEARS` | public const int |
| `generatedAdvice` | public Dictionary<TICouncilorState, List<TIFactionState.AdviceData>> |

### Methods

```csharp
public override void Initialize()
```

```csharp
public override void UpdateActivePlayerUIElements(bool startup)
```

```csharp
public override void UpdateUIScaling()
```

```csharp
public override void Show()
```

```csharp
public override void Hide()
```

```csharp
public override bool Visible()
```

```csharp
public void CleanUpDisplay()
```

```csharp
private void UpdateSingleCouncilorInfo(CouncilorDetailRequested e)
```

```csharp
public void CloseInfoScreen(bool toggle = false)
```

```csharp
private void UpdateCouncilScreenForValueChange(CouncilorValuesChanged e)
```

```csharp
private void UpdateCouncilorScreenForMonthlyOrgChanges(CouncilOrgsChanged e)
```

```csharp
private void UpdateDismissCouncilorButton(FactionFinalizesMissions e)
```

```csharp
private void UpdateCouncilGrid(CouncilCompositionChanged e)
```

```csharp
private void DisableCouncilorGrid()
```

```csharp
public void UpdateCouncilorGridIfAlreadyShown()
```

```csharp
public void UpdateCouncilorGrid()
```

```csharp
private void UpdateSingleCouncilorInGrid(TICouncilorState councilor)
```

```csharp
private void UpdateGridPrimaryDisplayElements()
```

```csharp
public void OnClickCouncilGridItem(TICouncilorState councilor)
```

```csharp
public void OnClickGridRecruitButton()
```

```csharp
public void OnExitCouncilorGrid()
```

```csharp
public void OnCloseandPlaySelected()
```

```csharp
public void OnHelpPanelOpenClick()
```

```csharp
public void OnHelpPanelCloseClick()
```

```csharp
public void OnResetTutorialClicked()
```

```csharp
public void HideAllTutorials()
```

```csharp
public void Tutorial_InitializeSingleCouncilorScreen()
```

```csharp
public void Tutorial_InitializeCouncilRecruitScreen()
```

```csharp
public void Tutorial_OpenOrgMarketplace()
```

```csharp
public void Tutorial_OpenUnassignedOrgs()
```

```csharp
public void Tutorial_SelectFirstCandidate()
```

```csharp
public void Tutorial_InitOrgManager()
```

```csharp
public void Tutorial_HighlightFirstCalendarClock()
```

```csharp
public IEnumerator PlayVideoWhenPrepared(VideoPlayer videoPlayer)
```

```csharp
private void DisableRecruitingCanvas()
```

```csharp
private void OnCouncilorRecruitListUpdated(RecruitListsUpdated e)
```

```csharp
private void DisableRecruitDetailCanvas()
```

```csharp
public void RecruitSelectedCandidateButtonClicked()
```

```csharp
public void OnDeclineRecruitButtonClicked()
```

```csharp
public void OnConfirmRecruitButtonClicked()
```

```csharp
public void UpdateRecruitingPrimaryDisplayElements()
```

```csharp
private void UpdateCandidatesList(TIFactionState councilState)
```

```csharp
public void UpdateCandidateDetail(TICouncilorState councilor)
```

```csharp
public void SelectCandidateListItem(CouncilorRecruitListItemController listItem)
```

```csharp
public void UpdateCandidateMissionsList(TICouncilorState councilorState)
```

```csharp
private void UpdateMissionsList(ListManagerBase listManager, TICouncilorState councilorState)
```

```csharp
private Dictionary<TIMissionTemplate, int> GetCouncilTotalMissionCountDictionary()
```

```csharp
public void UpdateCandidateTraitsList(TICouncilorState councilorState)
```

```csharp
private void DisableSingleCouncilorScreen()
```

```csharp
public void OnExitCouncilorPage()
```

```csharp
public void OnClickSpendXPButton()
```

```csharp
public void GotoButtonClicked()
```

```csharp
public void CycleRightButtonClicked()
```

```csharp
public void CycleLeftButtonClicked()
```

```csharp
public void CustomizeButtonClicked()
```

```csharp
public void FirstDismissButtonClicked()
```

```csharp
public void ConfirmDismissAndSellButtonClicked()
```

```csharp
public void ConfirmDismissAndKeepButtonClicked()
```

```csharp
public void DismissCancelButtonClicked()
```

```csharp
public void MoveOrgCancelButtonClicked()
```

```csharp
public void MoveOrgCancel()
```

```csharp
public void MoveOrgOkButtonClicked()
```

```csharp
public void MoveOrgPurchaseConfirmClicked()
```

```csharp
public void MoveOrgSellConfirmClicked()
```

```csharp
private void CloseMoveOrgPanel()
```

```csharp
public void StartOrgPurchase(TIOrgState org)
```

```csharp
private void RaiseConfirmPurchaseOrg()
```

```csharp
private void CompletePurchaseOrg()
```

```csharp
private bool CouncilorOwnsOrg(TIOrgState org)
```

```csharp
private void OrgActionFailure(string text)
```

```csharp
public void StartMoveToCouncilOrgs(TIOrgState org)
```

```csharp
private void RaiseTransferToCouncilOrgs()
```

```csharp
public void StartSellOrg(TIOrgState org, bool useSellButton = false)
```

```csharp
private void RaiseSellOrg()
```

```csharp
private void CompleteSellOrg()
```

```csharp
private string SetStatValue(CouncilorAttribute attribute, CouncilorView councilorView)
```

```csharp
public static string StatDetail(TICouncilorState councilor, CouncilorAttribute attribute)
```

```csharp
private void SetCouncilorInfo()
```

```csharp
public static void SetCouncilorXPText(TICouncilorState councilor, TMP_Text xpText, bool withXPText = false)
```

```csharp
public void ShowInfoMyOrg(string name, string desc, Sprite icon, string tier)
```

```csharp
public void ShowInfoEquipOrg(string name, string cost, string desc, Sprite icon, string tier, bool marketplace = false)
```

```csharp
public void OnHideInfoMyOrgClicked()
```

```csharp
public void OnHideInfoEquipOrgClicked()
```

```csharp
public void HideInfoMyOrg()
```

```csharp
public void HideInfoEquipOrg()
```

```csharp
public void OnClickOrgActionBottom()
```

```csharp
public void OnClickOrgActionBottom2()
```

```csharp
public void OnClickOrgActionTop()
```

```csharp
public void OnClickOrgActionTopSell()
```

```csharp
public void UpdateMissionsList(TICouncilorState councilorState)
```

```csharp
public void OnToggleAutomateModeSettingsClicked()
```

```csharp
public void UpdateTraitsList(TICouncilorState councilorState)
```

```csharp
private void UpdateOrgGrids(TICouncilorState councilorState)
```

```csharp
private void UpdateOrgGrid(ListManagerBase orgGrid, IReadOnlyList<TIOrgState> orgs)
```

```csharp
public void SetOrgSelected(OrgItemView toSelect, bool isEquipped)
```

```csharp
public void SetOrgCouncilTab()
```

```csharp
public void SetOrgAvailableTab()
```

```csharp
private void OnFactionResourcesUpdated(FactionResourcesUpdated e)
```

```csharp
private void SetAugmentationPanel()
```

```csharp
public void OnAugmentationSelected(CouncilorAugmentationOption option, CouncilorAugmentationListItemController listItem)
```

```csharp
private void SelectAugementationListItem(CouncilorAugmentationListItemController listItem)
```

```csharp
public void OnAugmentationButtonConfirmed()
```

```csharp
public void OnAugmentationButtonDeclined()
```

```csharp
public void OnExitAugmentationMenuSelected()
```

```csharp
public void OnCloseCustomizeCouncilorClicked()
```

```csharp
private void CacheCouncilorPortraits()
```

```csharp
public void InitializeCustomizationOptions()
```

```csharp
public void UpdateNameSettings()
```

```csharp
public void UpdateFilteredCouncilorAppearanceGrid()
```

```csharp
public void OnNewAppearanceSelected(TICouncilorAppearanceTemplate proposedTemplate)
```

```csharp
public void OnCycleAncestryFilterRight()
```

```csharp
public void OnCycleAncestryFilterLeft()
```

```csharp
public void OnCycleGenderFilterRight()
```

```csharp
public void OnCycleGenderFilterLeft()
```

```csharp
public void OnCycleJobFilterRight()
```

```csharp
public void OnCycleJobFilterLeft()
```

```csharp
public void OnCycleDuplicateFilterRight()
```

```csharp
public void OnCycleDuplicateFilterLeft()
```

```csharp
private void PlayCouncilorSample()
```

```csharp
private IEnumerator PlayCouncilorSampleAfterDelay()
```

```csharp
private void SetCurrentAccentOptions(bool playVoicePreview = true)
```

```csharp
public void OnCycleAccentLeft()
```

```csharp
public void OnCycleAccentRight()
```

```csharp
public void OnCycleVoiceIndexLeft()
```

```csharp
public void OnCycleVoiceIndexRight()
```

```csharp
public void SetProposedVoice(bool playVoicePreview = true)
```

```csharp
public void OnCouncilorVOClicked()
```

```csharp
public void OnEndEditGivenName()
```

```csharp
public void OnEndEditFamilyName()
```

```csharp
public void OnConfirmCustomizationSelected()
```

```csharp
private void InitializeLedgerCanvas()
```

```csharp
public void OpenLedger()
```

```csharp
public void CloseLedger()
```

```csharp
public void UpdateLedger(bool collapseAll = true)
```

```csharp
public void LedgerOnSortClicked(int sortCategory)
```

```csharp
public void LedgerCollapseAllClicked()
```

```csharp
public void LedgerExpandAllClicked()
```

```csharp
public void LedgerCollapseListItem(TIGameState clickedState)
```

```csharp
public void RefreshOrgManagementUI()
```

```csharp
public void UpdateOrgManagementUI()
```

```csharp
public void UpdateDraggableOrgAreas(TIOrgState org)
```

```csharp
public void UpdateBordersForValidCouncilors()
```

```csharp
public void ResetDraggableOrgAreas()
```

```csharp
public bool CanConfirmOrgChanges(out string reason)
```

```csharp
public void OnClickConfirmOrgChanges()
```

```csharp
public void OnClickRevertOrgManagementChanges()
```

```csharp
public void LeaveOrgManagement()
```

```csharp
public void EnterOrgManagement()
```

```csharp
private void InitializeCalendarCanvas()
```

```csharp
public void OpenCalendar()
```

```csharp
public void ForceOpenCalendar()
```

```csharp
public void CloseCalendar()
```

```csharp
private void OnAlarmAdded(AlarmAdded e)
```

```csharp
private void SetCalendar(TIDateTime dateForCalendar)
```

```csharp
public void OnDateDropdownChanged()
```

```csharp
public void CycleMonthForward()
```

```csharp
public void CycleMonthBackward()
```

```csharp
public void CycleYearForward()
```

```csharp
public void CycleYearBackward()
```

```csharp
public void OnResetCalendarToNow()
```

```csharp
public void CloseAllAdvicePanels()
```

```csharp
public void GenerateAdviceForAllPanels()
```
