# StartMenuController

*Decompiled from `StartMenuController.cs`.*


## Class `StartMenuController`

```csharp
public class StartMenuController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `selectedFaction` | private TIFactionTemplate |
| `continueSaveFilepath` | public static string |
| `exitSaveFilePath` | public static string |
| `autoSaveFilepath` | public static string |
| `oldAutoSaveFilepath` | public static string |
| `oldestAutoSaveFilepath` | public static string |
| `quickSaveFilepath` | public static string |
| `combatAutoSaveFilepath` | public static string |
| `ImportedShipTemplates` | public List<TISpaceShipTemplate> |
| `canvasGroup` | public CanvasGroup |
| `buttonsCanvasGroup` | public CanvasGroup |
| `newGamePrimaryPanelTransform` | public RectTransform |
| `loadGamePrimaryPanelTransform` | public RectTransform |
| `settingsPrimaryPanelTransform` | public RectTransform |
| `moddingPrimaryPanelTransform` | public RectTransform |
| `skirmishPrimaryPanelTransform` | public RectTransform |
| `creditsPrimaryPanelTransform` | public RectTransform |
| `continueButtonText` | public TMP_Text |
| `newGameText` | public TMP_Text |
| `loadGameText` | public TMP_Text |
| `optionsText` | public TMP_Text |
| `skirmishModeText` | public TMP_Text |
| `modsText` | public TMP_Text |
| `creditsText` | public TMP_Text |
| `exitText` | public TMP_Text |
| `TICredits` | public TMP_Text |
| `TICreditsList` | public List<TMP_Text> |
| `TICreditsStrings` | public List<string> |
| `modMenuButton` | public Button |
| `loadingScreen` | public GameObject |
| `loadingText` | public TMP_Text |
| `sceneManager` | private SceneManager |
| `currentStartOptions` | private Dictionary<string, string> |
| `DarkSkiesPromoObject` | public GameObject |
| `DarkSkiesStoreLogoSteam` | public GameObject |
| `DarkSkiesStoreLogoGog` | public GameObject |
| `DarkSkiesStoreLogoEpic` | public GameObject |
| `DarkSkiesStoreLogoMicrosoft` | public GameObject |
| `applicationVersionText` | public TMP_Text |
| `patchNotesText` | public TMP_Text |
| `dlcDateText` | public TMP_Text |
| `continueButton` | public Button |
| `continueButtonTooltip` | public TooltipTrigger |
| `menuManager` | public MenuManager |
| `optionsController` | public OptionsMenuController |
| `graphicsController` | public GraphicsMenuController |
| `audioController` | public AudioMenuController |
| `gameplayController` | public OptionsMenuController |
| `controlsController` | public ControlsMenuController |
| `loadMenuController` | public LoadMenuController |
| `skirmishMenuController` | public SkirmishMenuController |
| `modMenuController` | public ModMenuController |
| `newCampaignOptionList` | public Transform |
| `newCampaignOptionPanel` | public GameObject |
| `newGamePanelHeader` | public TMP_Text |
| `newGameStartButtonText` | public TMP_Text |
| `StartAcceleratedCampaignButtonText` | public TMP_Text |
| `newGameSummaryText` | public TMP_Text |
| `regularScenario` | private FullScenario |
| `startLongCampaignButton` | public Button |
| `startAcceleratedCampaignButton` | public Button |
| `previousCampaignSettingsButton` | public Button |
| `tutorial` | private bool |
| `selectFactionDropdownHeader` | public TMP_Text |
| `tutorialToggle` | public Toggle |
| `tutorialToggleText` | public TMP_Text |
| `skirmishTutorialToggle` | public Toggle |
| `skirmishTutorialToggleText` | public TMP_Text |
| `candidateFactionDataNames` | private List<string> |
| `newCampaignChooseFactionDropdown` | public TMP_Dropdown |
| `selectedFactionDescription` | public TMP_Text |
| `selectedFactionGradient` | public Image |
| `selectedFactionIconBold` | public Image |
| `selectedFactionIconFaded` | public Image |
| `currentAllowedFactions` | private List<TIFactionTemplate> |
| `factionsInScenario` | private List<TIFactionTemplate> |
| `nationsInScenario` | private List<TINationTemplate> |
| `allProfessions` | private List<TICouncilorTypeTemplate> |
| `selectedFactionDataName` | private string |
| `selectDifficultyHeader` | public TMP_Text |
| `selectDifficultyDropdown` | public TMP_Dropdown |
| `firstGameTutorialObject` | public GameObject |
| `recommendTutorialDescText` | public TMP_Text |
| `recommendTutorialButtonText` | public TMP_Text |
| `factionCustomizationObject` | public GameObject |
| `factionCustomizeButton` | public TMP_Text |
| `factionCustomizeDefaultButton` | public TMP_Text |
| `factionCustomizeHeader` | public TMP_Text |
| `factionCustomizeDisplayName` | public TMP_Text |
| `factionCustomizeAdjective` | public TMP_Text |
| `factionCustomizeLeaderAddress` | public TMP_Text |
| `factionCustomizeFleet` | public TMP_Text |
| `customDisplayNameInput` | public TMP_InputField |
| `customAdjectiveInput` | public TMP_InputField |
| `customLeaderAddressInput` | public TMP_InputField |
| `customFleetInput` | public TMP_InputField |
| `newGameCustomizationMainHeaderText` | public TMP_Text |
| `campaignOptionsDifficultyHeaderText` | public TMP_Text |
| `campaignOptionsFactionHeaderText` | public TMP_Text |
| `campaignOptionsFactionNamesHeaderText` | public TMP_Text |
| `researchSpeedMultiplierSlider` | public Slider |
| `alienProgressionMultiplierSlider` | public Slider |
| `miningProductivityMultiplierSlider` | public Slider |
| `controlPointFreebieBonusSlider` | public Slider |
| `controlPointAIFreebieBonusSlider` | public Slider |
| `missionControlFreebieBonusSlider` | public Slider |
| `missionControlAIFreebieBonusSlider` | public Slider |
| `nationalIPModifierSlider` | public Slider |
| `averageMonthlyEventsModifierSlider` | public Slider |
| `miningRatePlayerSlider` | public Slider |
| `miningRateHumanAISlider` | public Slider |
| `miningRateAlienSlider` | public Slider |
| `habConstructionSpeedPlayerSlider` | public Slider |
| `habConstructionSpeedHumanAISlider` | public Slider |
| `habConstructionSpeedAlienSlider` | public Slider |
| `shipConstructionSpeedPlayerSlider` | public Slider |
| `shipConstructionSpeedHumanAISlider` | public Slider |
| `shipConstructionSpeedAlienSlider` | public Slider |
| `researchSpeedTitle` | public TMP_Text |
| `researchSpeedValue` | public TMP_Text |
| `alienProgressionRateTitle` | public TMP_Text |
| `alienProgressionRateValue` | public TMP_Text |
| `miningProductivityTitle` | public TMP_Text |
| `miningProductivityValue` | public TMP_Text |
| `controlPointFreebieTitle` | public TMP_Text |
| `controlPointFreebieValue` | public TMP_Text |
| `controlPointAIFreebieTitle` | public TMP_Text |
| `controlPointAIFreebieValue` | public TMP_Text |
| `missionControlFreebieTitle` | public TMP_Text |
| `missionControlFreebieValue` | public TMP_Text |
| `missionControlAIFreebieTitle` | public TMP_Text |
| `missionControlAIFreebieValue` | public TMP_Text |
| `nationalIPModifierTitle` | public TMP_Text |
| `nationalIPModifierValue` | public TMP_Text |
| `averageMonthlyEventsModifierTitle` | public TMP_Text |
| `averageMonthlyEventsModifierValue` | public TMP_Text |
| `startingCouncilor1ProfessionText` | public TMP_Text |
| `startingCouncilor2ProfessionText` | public TMP_Text |
| `variableProjectUnlocksText` | public TMP_Text |
| `showtriggeredProjectsText` | public TMP_Text |
| `firstCouncilorHomeNationText` | public TMP_Text |
| `realismCombatScaleText` | public TMP_Text |
| `realismCombatDVMovementText` | public TMP_Text |
| `skirmishRealismCombatScaleText` | public TMP_Text |
| `skirmishRealismCombatDVMovementText` | public TMP_Text |
| `AddAlienAssaultFleetText` | public TMP_Text |
| `otherFactionStartingNationsText` | public TMP_Text |
| `canDisableFactionsText` | public TMP_Text |
| `randomizeMapText` | public TMP_Text |
| `randomizeMapSeedText` | public TMP_Text |
| `smallShipNameListIdxText` | public TMP_Text |
| `mediumShipNameListIdxText` | public TMP_Text |
| `largeShipNameListIdxText` | public TMP_Text |
| `habNameListIdxText` | public TMP_Text |
| `customStartingNationGroupText` | public TMP_Text |
| `miningRatePlayerTitle` | public TMP_Text |
| `miningRatePlayerValue` | public TMP_Text |
| `miningRateHumanAITitle` | public TMP_Text |
| `miningRateHumanAIValue` | public TMP_Text |
| `miningRateAlienTitle` | public TMP_Text |
| `miningRateAlienValue` | public TMP_Text |
| `habConstructionSpeedPlayerTitle` | public TMP_Text |
| `habConstructionSpeedPlayerValue` | public TMP_Text |
| `habConstructionSpeedHumanAITitle` | public TMP_Text |
| `habConstructionSpeedHumanAIValue` | public TMP_Text |
| `habConstructionSpeedAlienTitle` | public TMP_Text |
| `habConstructionSpeedAlienValue` | public TMP_Text |
| `shipConstructionSpeedPlayerTitle` | public TMP_Text |
| `shipConstructionSpeedPlayerValue` | public TMP_Text |
| `shipConstructionSpeedHumanAITitle` | public TMP_Text |
| `shipConstructionSpeedHumanAIValue` | public TMP_Text |
| `shipConstructionSpeedAlienTitle` | public TMP_Text |
| `shipConstructionSpeedAlienValue` | public TMP_Text |
| `factionCustomizationCancelButton` | public TMP_Text |
| `campaignCustomizationRapidPresetButtonText` | public TMP_Text |
| `campaignCustomizationLongPresetButtonText` | public TMP_Text |
| `campaignCustomizationPreviousCampaignText` | public TMP_Text |
| `startCustomCampaignButtonText` | public TMP_Text |
| `startingCouncilor1Profession` | public TMP_Dropdown |
| `startingCouncilor2Profession` | public TMP_Dropdown |
| `smallShipNameListIdxDropdown` | public TMP_Dropdown |
| `mediumShipNameListIdxDropdown` | public TMP_Dropdown |
| `largeShipNameListIdxDropdown` | public TMP_Dropdown |
| `habNameListIdxDropdown` | public TMP_Dropdown |
| `customStartingNationGroupDropdown` | public TMP_Dropdown |
| `variableProjectUnlocksToggle` | public Toggle |
| `showtriggeredProjectsToggle` | public Toggle |
| `firstCouncilorHomeNationToggle` | public Toggle |
| `realismCombatScaleToggle` | public Toggle |
| `realismCombatDVMovementToggle` | public Toggle |
| `skirmishRealismCombatScaleToggle` | public Toggle |
| `skirmishRealismCombatDVMovementToggle` | public Toggle |
| `addAlienAssaultFleetToggle` | public Toggle |
| `otherFactionStartingNations` | public Toggle |
| `canDisableFactionsToggle` | public Toggle |
| `randomizeMapToggle` | public Toggle |
| `randomizeMapSeedInputField` | public TMP_InputField |
| `factionToggleListManager` | public ListManagerBase |
| `difficultyWarningObject` | public GameObject |
| `difficultyWarningTooltip` | public TooltipTrigger |
| `difficultyWarningObjectOptions` | public GameObject |
| `difficultyWarningOptionsText` | public TMP_Text |
| `customStartingNationGroupGO` | public GameObject |
| `otherFactionStartingNationsGO` | public GameObject |
| `mapSeedInputGO` | public GameObject |
| `mapRandomizeToggleGO` | public GameObject |
| `difficultyWarningOptionsTooltip` | public TooltipTrigger |
| `CPFreebieTooltip` | public TooltipTrigger |
| `AICPFreebieTooltip` | public TooltipTrigger |
| `MCFreebieTooltip` | public TooltipTrigger |
| `AIMCFreebieTooltip` | public TooltipTrigger |
| `researchSpeedTooltip` | public TooltipTrigger |
| `miningProductivityTooltip` | public TooltipTrigger |
| `alienProgressionTooltip` | public TooltipTrigger |
| `variableProjectUnlocksTooltip` | public TooltipTrigger |
| `showtriggeredProjectsTooltip` | public TooltipTrigger |
| `firstCouncilorHomeNationTooltip` | public TooltipTrigger |
| `nationalIPModifierTooltip` | public TooltipTrigger |
| `averageMonthlyEventsModifierTooltip` | public TooltipTrigger |
| `longCampaignTooltip` | public TooltipTrigger |
| `acceleratedCampaignTooltip` | public TooltipTrigger |
| `longCampaignSettingsTooltip` | public TooltipTrigger |
| `acceleratedCampaignSettingsTooltip` | public TooltipTrigger |
| `realismCombatScaleTooltip` | public TooltipTrigger |
| `realismCombatDVMovementTooltip` | public TooltipTrigger |
| `skirmishRealismCombatScaleTooltip` | public TooltipTrigger |
| `skirmishRealismCombatDVMovementTooltip` | public TooltipTrigger |
| `addAlienAssaultFleetTooltip` | public TooltipTrigger |
| `miningRatePlayerTooltip` | public TooltipTrigger |
| `miningRateHumanAITooltip` | public TooltipTrigger |
| `miningRateAlienTooltip` | public TooltipTrigger |
| `habConstructionSpeedPlayerTooltip` | public TooltipTrigger |
| `habConstructionSpeedHumanAITooltip` | public TooltipTrigger |
| `habConstructionSpeedAlienTooltip` | public TooltipTrigger |
| `shipConstructionSpeedPlayerTooltip` | public TooltipTrigger |
| `shipConstructionSpeedHumanAITooltip` | public TooltipTrigger |
| `shipConstructionSpeedAlienTooltip` | public TooltipTrigger |
| `nationGroupTooltip` | public TooltipTrigger |
| `otherFactionStartingNationGroupTooltip` | public TooltipTrigger |
| `canDisableFactionsTooltip` | public TooltipTrigger |
| `randomizeMapTooltip` | public TooltipTrigger |
| `customDifficulty` | private bool |
| `skirmishScenario` | private SkirmishModeScenario |
| `skirmishModeHeaderText` | public TMP_Text |
| `skirmishModePlayer1HeaderText` | public TMP_Text |
| `skirmishModePlayer2HeaderText` | public TMP_Text |
| `skirmishModeLocationTitle` | public TMP_Text |
| `skirmishModeHabTitle` | public TMP_Text |
| `skirmishModeBeginText` | public TMP_Text |
| `skirmishModePlayer1AddShipsText` | public TMP_Text |
| `skirmishModePlayer2AddShipsText` | public TMP_Text |
| `skirmishModePlayer1CloseAddShipsText` | public TMP_Text |
| `skirmishModePlayer2CloseAddShipsText` | public TMP_Text |
| `skirmishModePlayer1FleetScore` | public TMP_Text |
| `skirmishModePlayer2FleetScore` | public TMP_Text |
| `factionFleetGradient` | public List<Image> |
| `factionFleetCenterGradient` | public List<Image> |
| `factionFleetIcon` | public List<Image> |
| `factionFleetBackgroundIcon` | public List<Image> |
| `habFactionText` | public TMP_Text |
| `selectedScenario` | private IScenario |
| `selectedMetaTemplateScenario` | private TIMetaTemplate |
| `creditsMenu` | public Menu |
| `hardwareWarningObject` | public GameObject |
| `hardwareWarningConfirmText` | public TMP_Text |
| `hardwareWarningTitleText` | public TMP_Text |
| `hardwareWarningDescriptionText` | public TMP_Text |
| `translationWarningObject` | public GameObject |
| `translationWarningDescription` | public TMP_Text |
| `gamepassWarningObject` | public GameObject |
| `gamepassWarningDescription` | public TMP_Text |
| `modLoaderWarningDialog` | public GameObject |
| `fatalErrorBG` | public GameObject |
| `modLoaderWarningConfirmText` | public TMP_Text |
| `modLoaderWarningHeaderText` | public TMP_Text |
| `modLoaderWarningDescriptionText` | public TMP_Text |
| `bankedModFailure` | private bool |
| `fatalStartupError` | public bool |
| `bankedModWarningHeaderLoc` | private string |
| `bankedModWarningDescLoc` | private string |
| `bankedModWarningLocArg1` | private string |
| `bankedModWarningLocArg2` | private string |
| `discordLinkText` | public TMP_Text |
| `wikiLinkText` | public TMP_Text |
| `startingCouncilorProfessionIndex` | private int |
| `sliderIncrementSmall` | private const float |
| `forceCredits` | private static bool |
| `CinematicScalingMode` | public static bool |
| `defaultMiningProductivity` | private int |
| `defaultFactionsInScenario` | private List<string> |
| `defaultCompletedProjectsInScenario` | private List<string> |
| `lastSelectedDifficulty` | private int |
| `lastSelectedFaction` | private int |
| `nameListsToAdd` | private Dictionary<string, string> |
| `skirmishLocationSettingDropdown` | public TMP_Dropdown |
| `locationDictionary` | private Dictionary<string, TIOrbitTemplate> |
| `skirmishFactionDropdown` | public TMP_Dropdown[] |
| `factionDictionary` | private Dictionary<string, TIFactionTemplate> |
| `skirmishShipLists` | public ListManagerBase[] |
| `skirmishShipListDropdowns` | public List<SkirmishShipListItemController> |
| `ships` | public List<TISpaceShipTemplate> |
| `shipDictionary` | public Dictionary<string, TISpaceShipTemplate> |
| `skirmishHabDropdown` | public TMP_Dropdown |
| `habDictionary` | private Dictionary<string, TIHabTemplate> |
| `importedShipTemplates` | private static List<TISpaceShipTemplate> |
| `CategoryWithPriority` | public struct |
| `category` | public string |
| `priority` | public float |

### Methods

```csharp
private static void RuntimeInit()
```

```csharp
private void Start()
```

```csharp
public void UpdateUIScaling()
```

```csharp
public void AdjustCampaignSettingsMenuOffsetWithScaling(bool open)
```

```csharp
private void EntryPoint()
```

```csharp
private void OnDestroy()
```

```csharp
public TIMetaTemplate GetSelectedScenarioMetaTemplate()
```

```csharp
public void SetLanguage()
```

```csharp
private void Initialize()
```

```csharp
public void OnLaunchLongCampaignClicked()
```

```csharp
public void OnLaunchAcceleratedCampaignClicked()
```

```csharp
public void OnLaunchCustomCampaignClicked()
```

```csharp
public void OnLaunchCampaignClicked()
```

```csharp
public void OnStartSkirmishModeClicked()
```

```csharp
public void OnToggleSkirmishModeRealismSettings(int which)
```

```csharp
private void StoreCampaignOptions()
```

```csharp
public void OnToggleTutorial()
```

```csharp
public void PlayOpenMenuAudio()
```

```csharp
public void PlayCloseMenuAudio()
```

```csharp
public void ToggleHardwareWarning(bool show)
```

```csharp
public void RefreshContinueButton()
```

```csharp
public void ContinueGame()
```

```csharp
public void ExitGame()
```

```csharp
public void OnOpenModMenu()
```

```csharp
public void OnClickCustomizeFaction()
```

```csharp
public void OnClickCancelCustomizeFaction()
```

```csharp
private void LoadFactionTextFields()
```

```csharp
private void SetCustomCampaignOptions(bool skirmish = false)
```

```csharp
private void InitializeCampaignStartControls()
```

```csharp
private void MatchChildListToCategories(int numCategories)
```

```csharp
private void MakeChildListSize(int newSize)
```

```csharp
public void UpdateStartOptions(string category, TIMetaTemplate template)
```

```csharp
public void UpdateTutorialOptions()
```

```csharp
public void UpdateFactionOptions()
```

```csharp
public void OnFactionOptionSelected()
```

```csharp
public void OnDifficultyChanged()
```

```csharp
private void OnFactionChanged()
```

```csharp
public void OnCouncilorProfessionDropDownChanged()
```

```csharp
public void ResetAllCustomizations()
```

```csharp
private void SetCouncilorProfessionOptions(bool retainSelection = false)
```

```csharp
private void SetStarterNationOptions()
```

```csharp
private void UpdateMapOptions(string templateName)
```

```csharp
public void ResetAdditionalCampaignOptions()
```

```csharp
private void ResetFactionOptions()
```

```csharp
private void ResetCampaignDifficultyOptions()
```

```csharp
private void ValidateCustomDifficultySettings()
```

```csharp
public void OnSelectCampaignPreset(float speedFactor = 2f)
```

```csharp
public void OnChangedNationGroup()
```

```csharp
public void UpdateAverageMonthlyEventsSlider()
```

```csharp
public void UpdateNationalIPModifierSlider()
```

```csharp
public void UpdateResearchSpeedSlider()
```

```csharp
public void UpdateAlienProgressionSpeedSlider()
```

```csharp
public void UpdateMiningProductivySpeedSlider(bool updateDifficulty = true)
```

```csharp
public void UpdateMiningRateSlider()
```

```csharp
public void UpdateHabConstructionSpeedSlider()
```

```csharp
public void UpdateShipConstructionSpeedSlider()
```

```csharp
public void UpdateControlPointFreebieSlider(bool updateDifficulty = true)
```

```csharp
public void UpdateControlPointAIFreebieSlider()
```

```csharp
public void UpdateMCFreebieSlider()
```

```csharp
public void UpdateMCAIFreebieSlider()
```

```csharp
public void OnToggleVariableProjectUnlocks()
```

```csharp
public void OnToggleShowTriggeredProjects()
```

```csharp
public void OnToggleRandomizeMapSetting()
```

```csharp
public void PlayNewGameToggleAudio()
```

```csharp
public void OnEndEditCustomFactionName(string newValue)
```

```csharp
public void OnEndEditCustomFactionAdjective(string newValue)
```

```csharp
public void OnEndEditCustomFactionLeaderAddress(string newValue)
```

```csharp
public void OnEndEditCustomFactionFleet(string newValue)
```

```csharp
private void UpdateAllowedFactions()
```

```csharp
public void ValidateFactionRequirements()
```

```csharp
private void EnableCustomDifficulty()
```

```csharp
private void DisableCustomDifficulty()
```

```csharp
public int GetTotalCPFreebieBonus()
```

```csharp
public int GetAdditionalCPFreebiesBonus()
```

```csharp
public int GetAICPFreebiesBonus()
```

```csharp
public int GetMCFreebiesBonus()
```

```csharp
public int GetAIMCFreebiesBonus()
```

```csharp
public float GetResearchSpeedMultiplier()
```

```csharp
public float GetAlienProgressionSpeedMultiplier()
```

```csharp
public float GetMiningProductivitySpeedMultiplier()
```

```csharp
public float GetSliderMultiplier(Slider slider, float rate)
```

```csharp
public float GetNationalIPMultiplier()
```

```csharp
private int CurrentlySelectedHumanFactionsForCampaign()
```

```csharp
private int baseFreebiesCount()
```

```csharp
private void UpdateBaseCPForDefaultFactions()
```

```csharp
public void OnClickSetDefaultCampaignOptions()
```

```csharp
public void OnClickSetAcceleratedCampaignOptions()
```

```csharp
public void OnClickSetPreviousCampaignOptions()
```

```csharp
private void SetPreviousCampaignOptions()
```

```csharp
private void SetDefaultCampaignOptions()
```

```csharp
public void OnClickCloseTutorialRecommendation()
```

```csharp
public void OnClickDiscordLink()
```

```csharp
public void OnClickWikiLink()
```

```csharp
public void OnClickPavonisLink()
```

```csharp
public void OnClickDarkSkiesLink()
```

```csharp
public static void ForceCredits()
```

```csharp
public void BuildCreditsStrings()
```

```csharp
public void BankModFailureWarning(string headerLoc, string descLoc, string locArg1, string locArg2)
```

```csharp
public void ShowModFailureDialog(string warningHeader, string warningDesc)
```

```csharp
public void OnClickCloseModLoaderWarningDialog()
```

```csharp
public void InitializeSkirmishMenu()
```

```csharp
public void UpdateImportedShips()
```

```csharp
public void PopulateSkirmishDropdowns()
```

```csharp
public void SetFleetScores(TISpaceFleetTemplate fleet1, TISpaceFleetTemplate fleet2)
```

```csharp
public void OnSkirmishLocationChanged()
```

```csharp
public void OnShipDropdownChanged()
```

```csharp
public void OnFactionDropdownChanged(int fleetNum)
```

```csharp
public void OnHabDropdownChanged()
```

```csharp
private void OnLanguageChangedEvent()
```
