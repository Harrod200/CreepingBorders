# NationInfoController

*Decompiled from `PavonisInteractive/TerraInvicta/NationInfoController.cs`.*


## Class `NationInfoController`

```csharp
public class NationInfoController : CanvasControllerBase
```

### Fields

| Name | Type |
|---|---|
| `policyChangeInfluenceCost` | private float |
| `currentlyNuclearTargeting` | private bool |
| `nationPanelCanvas` | public Canvas |
| `NationInfoCanvasUITutorialController` | public UITutorialController |
| `NationInfoCanvasPrioritiesUITutorialController` | public UITutorialController |
| `ExofightersUITutorialController` | public UITutorialController |
| `constructExofighterPriorityHighlightDummy` | public GameObject |
| `nationNameText` | public TMP_Text |
| `regionNameText` | public TMP_Text |
| `regionIconsText` | public TMP_Text |
| `regionNameTooltipTrigger` | public TooltipTrigger |
| `regionIconsTooltipTrigger` | public TooltipTrigger |
| `flagImage` | public Image |
| `executiveLeaderImageObject` | public GameObject |
| `executiveLeaderImage` | public Image |
| `executiveLeaderBackground` | public Image |
| `executiveLeaderTooltipTrigger` | public TooltipTrigger |
| `executiveLeaderRelationsButton` | public Button |
| `executiveLeaderConsolidatedVisualization` | public Image |
| `executiveLeaderCountdown` | public TMP_Text |
| `nukeButtonPanel` | public GameObject |
| `nukeChevrons` | public GameObject |
| `nukeButton` | public Button |
| `overviewHeaderText` | public TMP_Text |
| `militaryHeaderText` | public TMP_Text |
| `developmentHeaderText` | public TMP_Text |
| `peopleHeaderText` | public TMP_Text |
| `publicOpinionText` | public TMP_Text |
| `specialRelationshipPanelObject` | public GameObject |
| `specialRelationshipImage` | public Image |
| `specialRelationshipName` | public TMP_Text |
| `specialRelationshipTooltipTrigger` | public TooltipTrigger |
| `headerBackground` | public Image |
| `breakawayColor` | public Color |
| `policyTooltipTrigger` | public TooltipTrigger |
| `democracyText` | public TMP_Text |
| `democracyTooltipTrigger` | public TooltipTrigger |
| `stabilityText` | public TMP_Text |
| `stabilityTooltipTrigger` | public TooltipTrigger |
| `GDPValue` | public TMP_Text |
| `GDPTooltipTrigger` | public TooltipTrigger |
| `conflictStatusImage` | public Image |
| `conflictStatusTooltipTrigger` | public TooltipTrigger |
| `milTechText` | public TMP_Text |
| `milTechTooltipTrigger` | public TooltipTrigger |
| `numNukesValue` | public TMP_Text |
| `nukesTooltipTrigger` | public TooltipTrigger |
| `navalStatusIcon` | public Image |
| `navalScoreText` | public TMP_Text |
| `navalScoreTooltipTrigger` | public TooltipTrigger |
| `numArmiesText` | public TMP_Text |
| `numSTOsIconObject` | public GameObject |
| `numArmiesTooltipTrigger` | public TooltipTrigger |
| `numSTOsText` | public TMP_Text |
| `numSTOsObject` | public GameObject |
| `numSTOFightersTooltipTrigger` | public TooltipTrigger |
| `tinyControlPointImage` | public Image[] |
| `tinyControlPointTooltip` | public TooltipTrigger[] |
| `tinyControlPointButton` | public Button[] |
| `GDPPerCapitaValue` | public TMP_Text |
| `GDPPerCapitaTooltipTrigger` | public TooltipTrigger |
| `inequalityText` | public TMP_Text |
| `inequalityTooltipTrigger` | public TooltipTrigger |
| `populationValueText` | public TMP_Text |
| `populationTooltipTrigger` | public TooltipTrigger |
| `nationIdeologyPortions` | public List<Image> |
| `publicOpinionTooltipTrigger` | public TooltipTrigger |
| `cohesionText` | public TMP_Text |
| `cohesionTooltipTrigger` | public TooltipTrigger |
| `educationText` | public TMP_Text |
| `educationTooltipTrigger` | public TooltipTrigger |
| `sustainabilityIcon` | public Image |
| `sustainabilityText` | public TMP_Text |
| `sustainabilityTooltipTrigger` | public TooltipTrigger |
| `statsFlagImage` | public Image |
| `statsFederationImageObject` | public GameObject |
| `statsFederationImage` | public Image |
| `statsCouncilImage` | public Image |
| `developmentSummaryTooltipTrigger` | public TooltipTrigger |
| `federationValuesObject` | public GameObject |
| `spaceFundingNationValue` | public TMP_Text |
| `spaceFundingFederationValue` | public TMP_Text |
| `spaceFundingCouncilValue` | public TMP_Text |
| `spaceFundingTooltipTrigger` | public TooltipTrigger |
| `investmentNationValue` | public TMP_Text |
| `investmentCouncilValue` | public TMP_Text |
| `investmentNationTooltipTrigger` | public TooltipTrigger |
| `scienceNationValue` | public TMP_Text |
| `scienceCouncilValue` | public TMP_Text |
| `scienceNationTooltipTrigger` | public TooltipTrigger |
| `boostNationValue` | public TMP_Text |
| `boostFederationValue` | public TMP_Text |
| `boostCouncilValue` | public TMP_Text |
| `boostNationTooltipTrigger` | public TooltipTrigger |
| `missionControlNationValue` | public TMP_Text |
| `missionControlCouncilValue` | public TMP_Text |
| `missionControlNationTooltipTrigger` | public TooltipTrigger |
| `nationTabManager` | public TabbedPaneManager |
| `armiesTabController` | public TabbedPaneController |
| `policiesTabController` | public TabbedPaneController |
| `regionsTabController` | public TabbedPaneController |
| `councilorsTabController` | public TabbedPaneController |
| `prioritiesTabController` | public TabbedPaneController |
| `relationsTabController` | public TabbedPaneController |
| `prioritiesTabButtonObject` | public GameObject |
| `policyTabButtonObject` | public GameObject |
| `regionsTabButtonObject` | public GameObject |
| `relationsTabButtonObject` | public GameObject |
| `armyTabButtonObject` | public GameObject |
| `councilorsTabButtonObject` | public GameObject |
| `relationsButton1` | public Button |
| `manageRelationsButtonText` | public TMP_Text |
| `manageRelationsButtonTooltipTrigger` | public TooltipTrigger |
| `armiesTabText` | public TMP_Text |
| `prioritiesTabText` | public TMP_Text |
| `regionsTabText` | public TMP_Text |
| `policiesTabText` | public TMP_Text |
| `councilorsTabText` | public TMP_Text |
| `relationsTabText` | public TMP_Text |
| `armyList` | public ListManagerBase |
| `regionListItemModels` | public List<NationInfoRegionListItemModel> |
| `nationInfoRegionListAdapter` | public NationInfoRegionListAdapter |
| `councilorList` | public ListManagerBase |
| `priorityList` | public ListManagerBase |
| `policyList` | public ListManagerBase |
| `policyHeaderText` | public TMP_Text |
| `armyTabTooltipTrigger` | public TooltipTrigger |
| `prioritiesTabTooltipTrigger` | public TooltipTrigger |
| `policiesTabTooltipTrigger` | public TooltipTrigger |
| `regionTabTooltipTrigger` | public TooltipTrigger |
| `councilorTabTooltipTrigger` | public TooltipTrigger |
| `relationsTabTooltipTrigger` | public TooltipTrigger |
| `abductionsHeader` | public Image |
| `populationHeaderText` | public TMP_Text |
| `claimsHeaderText` | public TMP_Text |
| `occupationHeaderTooltipTrigger` | public TooltipTrigger |
| `boostHeaderTooltipTrigger` | public TooltipTrigger |
| `MCHeaderTooltipTrigger` | public TooltipTrigger |
| `claimsHeaderTooltipTrigger` | public TooltipTrigger |
| `prioritiesTab` | public TabbedPaneController |
| `priorityPresetDropdown` | public TMP_Dropdown |
| `priorityPresetDictionary` | private Dictionary<TIPriorityPresetTemplate, int> |
| `priorityHeader1` | public TMP_Text |
| `priorityHeader2` | public TMP_Text |
| `directInvestButtonText` | public TMP_Text |
| `proportionColumnButtonText` | public TMP_Text |
| `allyGrid` | public GameObject |
| `allyGridItem` | public GameObject |
| `rivalGrid` | public GameObject |
| `rivalGridItem` | public GameObject |
| `warGrid` | public GameObject |
| `warGridItem` | public GameObject |
| `alliesHeader` | public TMP_Text |
| `rivalsHeaders` | public TMP_Text |
| `warsHeader` | public TMP_Text |
| `controlPointGrid` | public ListManagerBase |
| `weightStr` | public static readonly string[] |
| `weightSprite` | public static readonly Sprite[] |
| `mapObjectDetailCanvas` | public Canvas |
| `mapObjectDetailIllustration` | public Image |
| `mapObjectFlag` | public Image |
| `mapObjectDetailHeader` | public TMP_Text |
| `statPanelObject` | public GameObject |
| `statPanelIcon` | public Image |
| `statPanelValueText` | public TMP_Text |
| `statPanelObject2` | public GameObject |
| `statPanelIcon2` | public Image |
| `statPanelValueText2` | public TMP_Text |
| `mapObjectDetailMainHeadline` | public TMP_Text |
| `mapObjectDetailLocation` | public TMP_Text |
| `mapObjectDetailExplainerText` | public TMP_Text |
| `mapObjectButtonPanelObject` | public GameObject |
| `mapObjectButtonPanelObject2` | public GameObject |
| `mapObjectButtonPanelButton` | public Button |
| `mapObjectButtonPanelButton2` | public Button |
| `mapObjectButtonText` | public TMP_Text |
| `mapObjectButtonText2` | public TMP_Text |
| `displayedRegionLocationState` | private TIRegionEntityState |
| `targetingOwnedCPs` | public bool |
| `targetingNeutralCP` | public bool |
| `currentMission` | public TIMissionTemplate |
| `currentMissionCouncilor` | public TICouncilorState |
| `timeToNextUpdate_s` | private float |
| `updateDelta_s` | private const float |
| `wasActive` | private bool |
| `region` | private TIRegionState |
| `nationDataDirty` | private bool |
| `councilorListDataDirty` | private bool |
| `playDropdownAudio` | private static bool |
| `directInvestPanel` | public GameObject |
| `directInvestListManager` | public ListManagerBase |
| `directInvestPanelHeader` | public TMP_Text |
| `DIHeader_PriorityName` | public TMP_Text |
| `DIHeader_PerIPCost` | public TMP_Text |
| `DIHeader_CurrentSetting` | public TMP_Text |
| `DIHeader_PlannedCost` | public TMP_Text |
| `DIHeader_CompletionOutcome` | public TMP_Text |
| `confirmButton` | public Button |
| `directInvestConfirmButtonText` | public TMP_Text |
| `directInvestResetButtonText` | public TMP_Text |
| `directInvestCancelButtonText` | public TMP_Text |
| `directInvestTotalSpendText` | public TMP_Text |
| `directInvestTotalSpendValue` | public TMP_Text |
| `directInvestAnnualText` | public TMP_Text |
| `directInvestAnnualIPs` | public TMP_Text |
| `freeInfluenceHeadsUp` | public TMP_Text |
| `plannedDirectInvestments` | public Dictionary<PriorityType, float> |
| `DesignPresetUITutorialController` | public UITutorialController |
| `designPresetPanel` | public GameObject |
| `designPresetPanelButtonText` | public TMP_Text |
| `proposedPriorityPreset` | private TIPriorityPresetTemplate |
| `duplicatedPreset` | private TIPriorityPresetTemplate |
| `presetBuilderHeaderText` | public TMP_Text |
| `inputPresetName` | public TMP_InputField |
| `inputPresetDefaultText` | public TMP_Text |
| `designPriorityPresetDropdownLabel` | public TMP_Text |
| `savePresetButtonText` | public TMP_Text |
| `resetPresetButtonText` | public TMP_Text |
| `setAsDefaultPresetButtonText` | public TMP_Text |
| `applyPresetGloballyButtonText` | public TMP_Text |
| `savePresetButton` | public Button |
| `resetPresetButton` | public Button |
| `deletePresetButton` | public Button |
| `setAsDefaultPresetButton` | public Button |
| `applyGloballyButton` | public Button |
| `designPriorityPresetDropdown` | public TMP_Dropdown |
| `designPriorityPresetDictionary` | private Dictionary<int, TIPriorityPresetTemplate> |
| `designPriorityPresetListManager` | public ListManagerBase |
| `applyGloballyTip` | public TooltipTrigger |
| `setAsDefaultTip` | public TooltipTrigger |
| `deleteTooltip` | public TooltipTrigger |
| `deleteTooltipText` | private string |
| `disableControlPointsButton` | public Button |
| `disableControlPointsButtonText` | public TMP_Text |
| `confirmDisableControlPointPanel` | public GameObject |
| `confirmDisableControlPointHeaderText` | public TMP_Text |
| `confirmDisableControlPointBodyText` | public TMP_Text |
| `confirmDisableControlConfirmButtonText` | public TMP_Text |
| `confirmDisableControlCancelButtonText` | public TMP_Text |
| `disbaleControlPointsTip` | public TooltipTrigger |
| `autoAbandonToggleText` | public TMP_Text |
| `autoAbandonToggle` | public Toggle |
| `nationRelationsManagerPanel` | public GameObject |
| `maxFactions` | private const int |
| `proposedRelationsChanges` | public Dictionary<TINationState, RelationChange> |
| `tabManager` | public TabbedPaneManager |
| `nationRelationsHeader` | public TMP_Text |
| `costProposalText` | public TMP_Text |
| `massChangesText` | public TMP_Text |
| `unalignedNationsTabText` | public TMP_Text |
| `acceptChangesButton` | public Button |
| `relations_acceptButtonText` | public TMP_Text |
| `relations_resetButtonText` | public TMP_Text |
| `relations_closeButtonText` | public TMP_Text |
| `improveRelationsColumnHeaderText` | public TMP_Text |
| `allyText` | public TMP_Text |
| `normalText` | public TMP_Text |
| `rivalText` | public TMP_Text |
| `warText` | public TMP_Text |
| `relationsTabIndices` | public Dictionary<int, TIFactionState> |
| `relationsTabButtonObjects` | public List<GameObject> |
| `relationsTabImages` | public List<Image> |
| `factionRelationsPaneControllers` | public List<NationRelationsPaneController> |
| `AllyAllToggle` | public Toggle |
| `AllyToNormalAllToggle` | public Toggle |
| `RivalToNormalAllToggle` | public Toggle |
| `RivalAllToggle` | public Toggle |
| `AllyAllCheckmark` | public Image |
| `AllyToNormalAllCheckmark` | public Image |
| `RivalToNormalAllCheckmark` | public Image |
| `RivalAllCheckmark` | public Image |
| `relationshipChangesCost` | public TIResourcesCost |
| `ignoreToggles` | private bool |
| `nuclearWeaponsPanel` | public GameObject |
| `nuclearWeaponsPanelHeader` | public TMP_Text |
| `nuclearWeaponsPanelText` | public TMP_Text |
| `nuclearWeaponsTargetText` | public TMP_Text |
| `nuclearConfirmButtonText` | public TMP_Text |
| `nuclearCancelButtonText` | public TMP_Text |
| `currentNuclearTarget` | public TIRegionState |
| `nuclearConfirmButton` | public Button |
| `nationFlag` | public Image |
| `nationFlag2` | public Image |
| `nukingNation` | private TINationState |
| `nuclearTargeting` | private TIOperationTargeting_Region |
| `WhatIsGood` | public enum |
| `TrackedValue` | public enum |

### Properties

- `public int proportionColumnSetting`
- `public TINationState nation`

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
public bool CloseAnySecondaryPanels(GameObject exceptPanel, bool allowGeneric)
```

```csharp
public void ForceShowNationPanel(TIRegionState region)
```

```csharp
private void ShowNationPanel(ControlPointTargetSelected e)
```

```csharp
private void ShowNationPanel(RegionStateSelected e)
```

```csharp
private void ShowRegionMapObjectPanel(SpaceFacilityMapObjectSelected e)
```

```csharp
private void ShowRegionMapObjectPanel(AlienRegionMapEntitySelected e)
```

```csharp
private void UpdateNationPanel(NationDataUpdated e)
```

```csharp
private void UpdateNationPanel(ControlPointDataUpdated e)
```

```csharp
private void UpdateNationPanel(CustomPriorityPresetsChanged e)
```

```csharp
private void UpdateCouncilorList(CouncilCompositionChanged e)
```

```csharp
private void UpdateCouncilorList(CouncilorMissionUpdated e)
```

```csharp
private void UpdateCouncilorList(CouncilorPositionUpdated e)
```

```csharp
private void UpdateCouncilorList(CouncilorDepartsRegion e)
```

```csharp
private void UpdateMapObjectPanel(RegionDataUpdated e)
```

```csharp
private void AutocloseNationPanel(InfoScreenOpened e)
```

```csharp
private void AutocloseMapObjectPanel(InfoScreenOpened e)
```

```csharp
private void RestoreNationPanel(InfoScreenClosed e)
```

```csharp
private void RestoreMapObjectPanel(InfoScreenClosed e)
```

```csharp
private void OnTargetControlPoints(TargetControlPoints e)
```

```csharp
private void OnDeTargetControlPoints(DeTargetControlPoints e)
```

```csharp
private void OnTargetOpenControlPoint(TargetOpenControlPoint e)
```

```csharp
private void OnDeTargetOpenControlPoints(DeTargetOpenControlPoint e)
```

```csharp
private void OnNationIPManagerRequested(NationIPManagerRequested e)
```

```csharp
public void FlagClicked()
```

```csharp
public void EarthClicked()
```

```csharp
public void ExitButtonClicked()
```

```csharp
private void CheckforMainCanvasClose()
```

```csharp
private void AddNationPanelListeners()
```

```csharp
private void RemoveNationPanelListeners()
```

```csharp
private void ShowNationPanel(TIRegionState region)
```

```csharp
private void CloseNationPanel()
```

```csharp
private void UpdateNationPanel()
```

```csharp
private string warTip()
```

```csharp
private void UpdatePrimaryDisplayElements()
```

```csharp
public string TinyControlPointTooltip(TIControlPoint controlPoint)
```

```csharp
public void UpdateTinyControlPoints()
```

```csharp
private void AssignControlPoints()
```

```csharp
public void OnTinyControlPointClicked(int CPValue)
```

```csharp
public static string numberToArrow(double delta, NationInfoController.WhatIsGood whatIsGood, float baseValue = 0f, float midValue = 5f)
```

```csharp
private static string numberToColor(double delta, NationInfoController.WhatIsGood whatIsGood, float baseValue = 0f, float midValue = 5f)
```

```csharp
public static string ExecutiveLeaderTooltip(TIFactionState faction, TINationState nation)
```

```csharp
public static string LesserExecutiveLeaderTooltip(TIFactionState faction, TINationState nation)
```

```csharp
public static string ControlPointTooltip(TINationState nationState, TIControlPoint controlPoint)
```

```csharp
private static string requiredIPSummaryText(TINationState nation, PriorityType priority)
```

```csharp
public static string BuildPublicOpinionLine(TINationState nation, FactionIdeology ideology, bool region = false)
```

```csharp
public static string BuildPublicOpinionTooltip(TINationState nationState)
```

```csharp
private static string ChangeString_Sustainability(TINationState nation, float changeValue, bool useColor)
```

```csharp
private static string ChangeString(string stat, float changeValue, bool useColor, NationInfoController.WhatIsGood whatIsGood, bool dollars = false, bool pop = false, float baseValue = 0f)
```

```csharp
private static string RestStateString(string stat, float currentValue, float restStateValue, float movementCap, NationInfoController.WhatIsGood whatIsGood = NationInfoController.WhatIsGood.upOrMiddleIsGood)
```

```csharp
public static string BuildSpecialRelationshipTooltip(TINationState nation)
```

```csharp
public static string BuildRegionDataTooltip(TIRegionState region, TIFactionState faction, TINationState viewingNation)
```

```csharp
public static string BuildNukesTooltip(TINationState nation)
```

```csharp
public static string BuildnumArmiesTooltip(TINationState nation)
```

```csharp
public static string BuildSTOFightersTooltip(TINationState nation)
```

```csharp
public static string BuildEducationTooltip(TINationState nation)
```

```csharp
public static string BuildCohesionTooltip(TINationState nation)
```

```csharp
public static string BuildInequalityTooltip(TINationState nation)
```

```csharp
public static string BuildUnrestTooltip(TINationState nation)
```

```csharp
public static string BuildDemocracyTooltip(TINationState nation)
```

```csharp
public static string BuildPopulationTooltip(TINationState nation)
```

```csharp
public static string BuildMiltechTooltip(TINationState nation)
```

```csharp
public static string BuildPerCapitaGDPTooltip(TINationState nation)
```

```csharp
public static string BuildGDPTooltip(TINationState nation)
```

```csharp
public static string BuildSustainabilityTooltip(TINationState nation)
```

```csharp
public static string BuildInvestmentTooltip(TINationState nation)
```

```csharp
public static string BuildSpaceFundingTooltip(TINationState nation)
```

```csharp
public static string BuildResearchTooltip(TINationState nation)
```

```csharp
public static string BuildBoostTooltip(TINationState nation)
```

```csharp
public static string BuildMissionControlTooltip(TINationState nation)
```

```csharp
public static string BuildPoliciesTooltip(TINationState nation, bool includeDescription = true)
```

```csharp
public static string BuildNavalTooltip(TINationState nation)
```

```csharp
public static string GetTrackedValueAtCell(TINationState nation, NationInfoController.TrackedValue value, string cellName)
```

```csharp
public void SetTableTipDelegates(TooltipTrigger tip, NationInfoController.TrackedValue whatTracking)
```

```csharp
public static void SetGHGTableTipDelegates(TooltipTrigger tip)
```

```csharp
private void SetTooltips()
```

```csharp
private void HideTooltips()
```

```csharp
public void OnArmyMajorStatusUpdate(ArmyMajorStatusUpdate e)
```

```csharp
protected void UpdateArmyList()
```

```csharp
protected void UpdatePoliciesPanel()
```

```csharp
public void UpdatePriorityList()
```

```csharp
public static string GenericPriorityTipStr(PriorityType priority)
```

```csharp
public static TIPriorityPresetTemplate GlobalPlayerPresetSetting(TINationState nation, out bool playerCPPresent)
```

```csharp
public static void UpdatePriorityPresetFromChanges(TMP_Dropdown priorityPresetDropdown, TINationState nation, Dictionary<TIPriorityPresetTemplate, int> priorityPresetDictionary = null)
```

```csharp
public static void PopulateNationPriorityDropdown(TMP_Dropdown priorityPresetDropdown, TINationState nation, TIFactionState faction, ref Dictionary<TIPriorityPresetTemplate, int> priorityPresetDictionary)
```

```csharp
public void OnPriorityTemplateChanged()
```

```csharp
public static string PrioritySummaryString(PriorityType priority, TINationState nation, bool includeIPSymbol = true)
```

```csharp
private void SetPriorityValueColumnButtonText()
```

```csharp
public void CyclePriorityValueColumn()
```

```csharp
public void OpenDirectInvestPanel()
```

```csharp
public void CloseDirectInvestPanel()
```

```csharp
private void OnFactionResourcesUpdated(FactionResourcesUpdated e)
```

```csharp
private void InitializeDirectInvestPanel()
```

```csharp
private void UpdateDirectInvestList(TINationState nation)
```

```csharp
private void ResetDirectInvestPanel(TINationState nation)
```

```csharp
public void IncreaseDirectInvestment(PriorityType priority, int amount = 1)
```

```csharp
public void DecreaseDirectInvestment(PriorityType priority, float amount = 1f)
```

```csharp
private void UpdateDirectInvestSummaryData()
```

```csharp
public TIResourcesCost TotalDirectInvestmentCosts()
```

```csharp
public TIResourcesCost ProspectiveDirectInvestmentCosts(TIResourcesCost proposedCost)
```

```csharp
public TIResourcesCost CurrentSingleDirectInvestmentCost(PriorityType priority)
```

```csharp
public void ResetDirectInvestments()
```

```csharp
public void OnClickDirectInvestConfirmButton()
```

```csharp
public void OnClickDirectInvestResetButton()
```

```csharp
public void OnClickDirectInvestExitButton()
```

```csharp
public void OnClickCancelDirectInvestButton()
```

```csharp
public void OnDesignPresetButtonSelected()
```

```csharp
private void InitializeDesignPresetPanel()
```

```csharp
private void UpdateDesignPresetPanel(bool updateList = true, bool init = false)
```

```csharp
private void ResetCurrentPresets()
```

```csharp
private void DuplicateSelectedPreset(TIPriorityPresetTemplate presetToDuplicate)
```

```csharp
private int SetChangeValue(int initialValue, int valueChange)
```

```csharp
public void ChangePresetValue(PriorityType preset, int valueChange)
```

```csharp
public void OnSavePresetButtonPressed()
```

```csharp
public void OnResetPresetButtonPressed()
```

```csharp
public void DeletePresetButtonPressed()
```

```csharp
public void OnPresetDropdownChanged(bool playAudio = true)
```

```csharp
public void OnSetPresetAsDefaultButtonPressed()
```

```csharp
public void OnApplyPresetToAllButtonPressed()
```

```csharp
public void OnNewPresetNameEntered()
```

```csharp
public void TextEntryMode_Enter()
```

```csharp
public void TextEntryMode_End()
```

```csharp
private string GetDeleteTooltip()
```

```csharp
private void BuildDeleteButtonTooltip(bool canDeleteTemplate)
```

```csharp
public void OnClickCloseDesignPresetPanel()
```

```csharp
public void CloseDesignPresetPanel()
```

```csharp
private void UpdateRegionList()
```

```csharp
public void UpdateCouncilorList()
```

```csharp
public void UpdateAllyGrid()
```

```csharp
public void UpdateWarGrid()
```

```csharp
public void UpdateRivalryGrid()
```

```csharp
public void OpenSelfDisablePanel()
```

```csharp
public void CloseSelfDisablePanel()
```

```csharp
public void ConfirmSelfDisableControlPoints()
```

```csharp
public void OnToggleAutoAbandon()
```

```csharp
private void ShowMapObjectPanel(TIRegionEntityState regionEntity)
```

```csharp
private void CloseMapObjectPanel()
```

```csharp
private void UpdateMapObjectPanel(TIRegionEntityState regionEntity)
```

```csharp
public string RegionSTOFightersTip(TIRegionState region)
```

```csharp
public void OnRegionEntityUpdated(AlienRegionEntityUpdated e)
```

```csharp
public void OnMapObjectLaunchButtonPressed()
```

```csharp
public void OnMapObjectLaunchButton2Pressed()
```

```csharp
public void OnMapObjectPanelExitSelected()
```

```csharp
public void OnMapObjectFlagSelected()
```

```csharp
public void OnGotoMapObjectSelected()
```

```csharp
public void InitializeRelationsPanel()
```

```csharp
public void OpenRelationsPanel()
```

```csharp
public void UpdateRelationsPanel()
```

```csharp
public void UpdateRelationsList()
```

```csharp
public void ResetProposedChanges()
```

```csharp
public void AddProposedRelationshipChange(TINationState nation, RelationChange change)
```

```csharp
public void RemoveProposedRelationshipChange(TINationState nation)
```

```csharp
public void OnClickAllyAllToggle()
```

```csharp
public void OnClickAllyToNormalAllToggle()
```

```csharp
public void OnClickRivalToNormalAllToggle()
```

```csharp
public void OnClickRivalAllToggle()
```

```csharp
public void OnClickAcceptRelationsChangesButton()
```

```csharp
public void OnClickResetRelationsButton()
```

```csharp
public void OnClickCloseRelationsPanel()
```

```csharp
public void CloseRelationsPanel()
```

```csharp
private void InitNuclearOption()
```

```csharp
public void OnNuclearWeaponsSelected()
```

```csharp
public void NewNuclearTarget(OperationTargettedEvent e)
```

```csharp
public void OnConfirmLaunch()
```

```csharp
public void OnCancelLaunch()
```

```csharp
public void CloseNuclearWeaponsPanel()
```

```csharp
public void StartPrioritiesTutorial()
```

```csharp
public void StartNationPanelTutorial()
```

```csharp
public void StartBuildExofighterTutorial()
```

```csharp
public void StartDesignPresetTutorial()
```

```csharp
public void HidePrioritiesTutorial()
```

```csharp
public void HideTutorials()
```

```csharp
public void OpenPrioritiesTab()
```

```csharp
public void OpenPolicyTab()
```

```csharp
public void OpenRegionsTab()
```

```csharp
public void OpenRelationsTab()
```

```csharp
public void OpenArmiesTab()
```

```csharp
public void OpenCouncilorsTab()
```

```csharp
public void Tutorial_TargetConstructOrbitalFightersPriority()
```
