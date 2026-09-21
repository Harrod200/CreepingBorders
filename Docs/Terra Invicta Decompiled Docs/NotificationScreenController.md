# NotificationScreenController

*Decompiled from `PavonisInteractive/TerraInvicta/NotificationScreenController.cs`.*


## Class `NotificationScreenController`

```csharp
public class NotificationScreenController : CanvasControllerBase
```

### Fields

| Name | Type |
|---|---|
| `OkayToPushNextNotification` | private bool |
| `newsList` | public ListManagerBase |
| `backgroundImage` | public Image |
| `notificationCanvas` | public Canvas |
| `newsFeedLayout` | public VerticalLayoutGroup |
| `showText` | private bool |
| `closeAllNewsFeedButton` | public Button |
| `newsFeedTransform` | public RectTransform |
| `newsFeedCanvas` | public Canvas |
| `alertPanelCanvas` | public Canvas |
| `timerPanelObject` | public GameObject |
| `timerList` | public ListManagerBase |
| `singleAlertBox` | public GameObject |
| `singleAlertBoxBody` | public GameObject |
| `minimizeSingleAlertBodyButton` | public Button |
| `corePanel` | public GameObject |
| `alertLeftImage` | public Image |
| `alertLeftImageBackground` | public Image |
| `alertRightImage` | public Image |
| `alertRightImagePanelObject` | public GameObject |
| `alertRightAnimatedImage` | public Image |
| `alertRightImageAnimator` | public ImageAnimator |
| `hammerText` | public TMP_Text |
| `alertHeadline` | public GameObject |
| `alertHeadlineText` | public TMP_Text |
| `alertBodyText` | public TMP_Text |
| `alertBodyTextScrollObject` | public GameObject |
| `alertBodyScrollText` | public TMP_Text |
| `alertBodyTextScrollContent` | public GameObject |
| `alertBodyTextScrollRect` | public ScrollRect |
| `okayButtonObject` | public GameObject |
| `okayButton` | public Button |
| `okayButtonText` | public TMP_Text |
| `gotoButtonObject` | public GameObject |
| `gotoButton` | public Button |
| `gotoButtonText` | public TMP_Text |
| `closeButtonObject` | public GameObject |
| `closeButton` | public Button |
| `closeButtonText` | public TMP_Text |
| `exitButton` | public Button |
| `customDelegatePanelObject` | public GameObject |
| `customDelegatePanelObject2` | public GameObject |
| `customDelegateButton` | public Button[] |
| `customDelegateButtonText` | public TMP_Text[] |
| `customDelegateButtonSprite` | public Image[] |
| `customDelegateTooltip` | public TooltipTrigger[] |
| `customDropdownDelegatePanelObject` | public GameObject |
| `customDelegateDropdown` | public TMP_Dropdown |
| `customDelegateDropdownToggle` | public Toggle |
| `customDelegateDropdownToggleText` | public TMP_Text |
| `customDropdownDelegateApplyButtonIndex` | private int |
| `templateTargetHab` | private TIHabState |
| `controlPointPanel` | public GameObject |
| `oldControlPointPanel` | public GameObject |
| `oldControlPointTextHeader` | public TMP_Text |
| `newControlPointPanel` | public GameObject |
| `newControlPointTextHeader` | public TMP_Text |
| `oldControlPointImages` | public Image[] |
| `newControlPointImages` | public Image[] |
| `exitButtonObject` | public GameObject |
| `alertButtonsPanel` | public GameObject |
| `narrativeEventButtonsPanel` | public GameObject |
| `heldNewsItems` | private List<NotificationQueueItem> |
| `currentItem` | private NotificationQueueItem |
| `illustrationObject` | public GameObject |
| `illustration` | public Image |
| `illustrationObjectBackgroundImage` | public Image |
| `maskedIllustrationObject` | public GameObject |
| `maskedIllustrationImage` | public Image |
| `leftVideoSmallImage` | public Image |
| `leftVideoSmallImageBackground` | public Image |
| `rightVideoSmallImage` | public Image |
| `notificationVideo` | public VideoPlayer |
| `notificationCamera` | public GameObject |
| `cameraViewObject` | public GameObject |
| `cameraRenderTextureImage` | public RawImage |
| `notificationCameraInstance` | private GameObject |
| `previewPosition` | private GameObject |
| `modelInstance` | private GameObject |
| `originalPreviewPosition` | private Vector3 |
| `originalPreviewRotation` | private Vector3 |
| `masterPolicyPanelObject` | public GameObject |
| `masterPolicyHeader` | public TMP_Text |
| `masterPolicyFlag` | public Image |
| `selectPolicyBodyPanelObject` | public GameObject |
| `selectPolicyPanelObject` | public GameObject |
| `selectPolicyTargetPanelObject` | public GameObject |
| `confirmPanelObject` | public GameObject |
| `minimizePolicyBodyButton` | public Button |
| `confirmPanelText` | public TMP_Text |
| `confirmButtonText` | public TMP_Text |
| `cancelButtonText` | public TMP_Text |
| `backButtonObject` | public GameObject |
| `backButtonText` | public TMP_Text |
| `responsePanelObject` | public GameObject |
| `responsePanelNationName` | public TMP_Text |
| `responsePanelText` | public TMP_Text |
| `responseConfirmButtonText` | public TMP_Text |
| `responseDeclineButtonText` | public TMP_Text |
| `policyOptionsList` | public ListManagerBase |
| `policyTargetsList` | public ListManagerBase |
| `callAllyResponseObject` | public GameObject |
| `callAllyPrompt` | public TMP_Text |
| `allyAcceptButtonText` | public TMP_Text |
| `allyDeclineButtonText` | public TMP_Text |
| `promptQueue` | private TIPromptQueueState |
| `newsQueue` | private TINotificationQueueState |
| `removeArmiesPromptObject` | public GameObject |
| `removeArmiesPromptText` | public TMP_Text |
| `proposeAllianceButtonText` | public TMP_Text |
| `declareWarButtonText` | public TMP_Text |
| `sendArmiesHomeButtonText` | public TMP_Text |
| `removeArmies_proposeAllianceButton` | public Button |
| `removeArmies_declareWarButton` | public Button |
| `removeArmies_myNationFlag` | public Image |
| `removeArmies_myFactionIcon` | public Image |
| `removeArmies_theirNationFlag` | public Image |
| `removeArmies_theirFactionIcon` | public Image |
| `missionTargetingUIHeaderText` | public TMP_Text |
| `missionTargetingUIObject` | public GameObject |
| `missionTargetingUIList` | public ListManagerBase |
| `missionTargetConfirmButtonText` | public TMP_Text |
| `missionTargetText` | public TMP_Text |
| `missionTargetCancelButtonText` | public TMP_Text |
| `missionTargetButton` | public Button |
| `diplomacyController` | public DiplomacyController |
| `factionDiplomacyGreetingUIObject` | public GameObject |
| `factionDiplomacyGreetingTitleText` | public TMP_Text |
| `factionDiplomacyGreetingVideoPlayer` | public VideoPlayer |
| `factionDiplomacyGreetingLeaderTorsoPortrait` | public Image |
| `factionDiplomacyGreetingHeadlineText` | public TMP_Text |
| `factionDiplomacyGreetingBodyText` | public TMP_Text |
| `factionDiplomacyGreetingContinueButton` | public Button |
| `factionDiplomacyGreetingContinueButtonText` | public TMP_Text |
| `factionDiplomacyFactionIconL` | public Image |
| `factionDiplomacyFactionIconR` | public Image |
| `factionDiplomacyGreetingIconCenter` | public Image |
| `factionDiplomacyGreetingGradientLeft` | public Image |
| `factionDiplomacyGreetingGradientRight` | public Image |
| `factionDiplomacyTradeUIObject` | public GameObject |
| `factionDiplomacyTradePlayerObject` | public GameObject |
| `factionDiplomacyTradeOtherObject` | public GameObject |
| `factionDiplomacyTradePlayerVideoPlayer` | public VideoPlayer |
| `factionDiplomacyTradeOtherVideoPlayer` | public VideoPlayer |
| `factionDiplomacyTradePlayerPortraitImage` | public Image |
| `factionDiplomacyTradeOtherPortraitImage` | public Image |
| `factionDiplomacyTradeCancelButton` | public Button |
| `factionDiplomacyTradeContinueButton` | public Button |
| `aiOffer` | public bool |
| `diploMission` | public TIMissionState |
| `contactedFaction` | public TIFactionState |
| `interfactionDiplomacyTradeTutorialController` | public UITutorialController |
| `cinematicObject` | public GameObject |
| `cinematicVideoPlayer` | public VideoPlayer |
| `newsFeedTutorial` | public UITutorialController |
| `_tutorialNewsItemCounter` | private int |
| `reportBugPanel` | public GameObject |
| `reportBugHeader` | public TMP_Text |
| `reportBugBody` | public TMP_Text |
| `reportBugCopyErrorCodeButtonText` | public TMP_Text |
| `reportBugDiscordButtonText` | public TMP_Text |
| `reportBugContinueButtonText` | public TMP_Text |
| `alertOptionHeader` | public TMP_Text |
| `newsFeedOptionHeader` | public TMP_Text |
| `timerFeedOptionHeader` | public TMP_Text |
| `summaryFeedOptionHeader` | public TMP_Text |
| `currentNotificationOptionName` | public TMP_Text |
| `notificationOptionsPanel` | public GameObject |
| `openNotificationOptionPanelButton` | public Button |
| `altOpenNotificationOptionPanelButton` | public Button |
| `currentNotificationSettingTooltip` | public TooltipTrigger |
| `altCurrentNotificationSettingTooltip` | public TooltipTrigger |
| `alertsNotificationSettingTooltip` | public TooltipTrigger |
| `newsFeedNotificationSettingTooltip` | public TooltipTrigger |
| `timerFeedNotificationSettingTooltip` | public TooltipTrigger |
| `summaryFeedNotificationSettingTooltip` | public TooltipTrigger |
| `currentNotificationOptionItem` | public NotificationOptionListItem |
| `voEventInstance` | private EventInstance |
| `currentNarrativeEvent` | private CurrentNarrativeEventData |
| `notificationPushTime` | public float |
| `customButtonAction` | private NotificationScreenController.CustomButtonPressed[] |
| `maxCustomNotificationButtons` | public const int |
| `selectionDropdownDict` | private Dictionary<int, string> |
| `maxNewsListItems` | private const int |
| `maxTimerListItems` | private const int |
| `maxEventOptions` | private const int |
| `optionButtons` | public Button[] |
| `optionButtonText` | public TMP_Text[] |
| `optionButtonDetail` | public TooltipTrigger[] |
| `currentPolicyCouncilor` | private TICouncilorState |
| `currentPolicy` | private TIPolicyOption |
| `currentNation` | private TINationState |
| `currentPolicyTarget` | private TIGameState |
| `currentPrompt` | private Prompt |
| `respondingNation` | private TINationState |
| `promptingNation` | private TINationState |
| `relatedGameState` | private TIGameState |
| `policyPromptingResponse` | private TIPolicyOption |
| `promptName` | private string |
| `callingNation` | private TINationState |
| `calledAlly` | private TINationState |
| `war` | private TIWarState |
| `nationWithArmies` | private TINationState |
| `nationAskingArmiesToLeave` | private TINationState |
| `targetOrg` | private TIOrgState |
| `targetProject` | private TIProjectTemplate |
| `activeMission` | private TIMissionState |
| `currentMissionPrompt` | private Prompt |
| `diplomacyMissionState` | private TIMissionState |
| `diplomacyCouncilorState` | private TICouncilorState |
| `summaryLogReportObject` | public GameObject |
| `summaryLogHeaderText` | public TMP_Text |
| `summaryLogs` | public List<ListManagerBase> |
| `factionMissionListIcon` | public Image |
| `summaryTabManager` | public TabbedPaneManager |
| `summaryLogsTabPanes` | public List<TabbedPaneController> |
| `seenBugMessages` | private HashSet<string> |
| `DiplomacyWindowText` | private enum |

### Properties

- `public static NotificationScreenController singleton`
- `private readonly int[] maxSummaryListItems = new int[]`

### Methods

```csharp
public override void Initialize()
```

```csharp
public override void UpdateActivePlayerUIElements(bool startup)
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
private void UpdateNewsFeed(NewsItemCreated e)
```

```csharp
private void UpdateLogs(RapidLogItemCreated e)
```

```csharp
private void PushNextAlert()
```

```csharp
private void PrepAlert(NotificationQueueItem newsItem)
```

```csharp
private IEnumerator HandleNotificationTextScrollview(int maxTextHeight)
```

```csharp
public void OnClickToggleNotificationOptionPanel()
```

```csharp
public void ToggleNotificationOptionPanel(bool show)
```

```csharp
private void SetOpenNotificationButtonSprites()
```

```csharp
public void ToggleBodyScrollText(bool show, float heightToSet = 0f)
```

```csharp
public IEnumerator ResetScrollbarPosition()
```

```csharp
private IEnumerator UpdateRenderTexture()
```

```csharp
public void UpdateCameraImage(TISpaceObjectState spaceObjectState)
```

```csharp
private void StopLeaderVO()
```

```csharp
public void CleanUp(NotificationQueueItem forceItem = null)
```

```csharp
public void CleanupTextures()
```

```csharp
public void OkayButtonPressed()
```

```csharp
public void CloseButtonPressed()
```

```csharp
public void GotoButtonPressed()
```

```csharp
public void MinimizeNotificationWindowPressed()
```

```csharp
private void MaximizeNotificationWindow()
```

```csharp
public void MinimizePolicyWindowPressed()
```

```csharp
private void UpdateNotificationWindowMinimizeStatus()
```

```csharp
private void UpdateCustomNotificationButtons(SpaceCombatInitiated e)
```

```csharp
private void UpdateCustomNotificationButtons(ShipsRemovedFromFleet e)
```

```csharp
private void UpdateCustomNotificationButtons(HabDestroyed e)
```

```csharp
private void UpdateCustomNotificationButtons(CouncilCompositionChanged e)
```

```csharp
private void UpdateCustomNotificationButtons(HabDesignTemplateModified e)
```

```csharp
private void SetCustomNotificationButtons(NotificationQueueItem item)
```

```csharp
private void DisableAllDelegatePanelObjects()
```

```csharp
private bool PopulateDropdownWithHabTemplateSelection(TIHabState hab)
```

```csharp
private TIResourcesCost CostWithNecessaryBoost(TIFactionState faction, TIResourcesCost baseLineCost, TIHabState hab)
```

```csharp
public void OnHabTemplateSelected(int selected)
```

```csharp
public void OnCustomButtonPressed(int buttonNum)
```

```csharp
public void ToggleExpandedNewsFeed()
```

```csharp
private void ExpandedNewsFeedSettings()
```

```csharp
private void ExpandNewsFeed(InfoWindowEntirelyClosed e)
```

```csharp
private void ContractNewsFeed(InfoPanelOpened e)
```

```csharp
private void UpdateNewsList(TIFactionState activePlayer, NotificationSummaryItem item)
```

```csharp
private void SetTimerList(TIFactionState activePlayer)
```

```csharp
private void UpdateTimerList(TIFactionState activePlayer, NotificationSummaryItem item)
```

```csharp
private void SetNewsList(TIFactionState activePlayer)
```

```csharp
public void SetCloseAllButton(bool setting)
```

```csharp
public void OnClickCloseAllNewsFeed()
```

```csharp
private void OnResourcesUpdatedWhileNarrativeEventActive(FactionResourcesUpdated e)
```

```csharp
public void FillOutOptionButtons(TINarrativeEventTemplate template, TIGameState target, TIGameState secondaryTarget = null, Dictionary<TIGameState, TIGameState> allTargetsandSeconds = null)
```

```csharp
private IEnumerator EnableNarrativeButtonWithDelay(Button buttonToEnable)
```

```csharp
private IEnumerator EnableNarrativeButtonHotkeysWithDelay()
```

```csharp
public void OnOptionButtonPressed(int value)
```

```csharp
private void OnSetPolicyMission(TICouncilorState councilor)
```

```csharp
private void UpdatePolicyOptions(NationRelationsChange e)
```

```csharp
private void PopulatePolicyOptions()
```

```csharp
public void PolicySelected(TIPolicyOption policy)
```

```csharp
private void PopulatePolicyTargets()
```

```csharp
public void PolicyTargetSelected(TIGameState target)
```

```csharp
public void OnClickBackButton()
```

```csharp
private void ConfirmDialog()
```

```csharp
public void OnConfirmPolicy()
```

```csharp
private void ShutdownPolicyPanels()
```

```csharp
public void OnCancelPolicy()
```

```csharp
public void PushPromptResponse(BlockingPromptOnStartup e)
```

```csharp
public void PushNationPromptResponse()
```

```csharp
private void NationPromptPolicyResponse(Prompt prompt)
```

```csharp
public void OnReponseConfirm()
```

```csharp
public void OnResponseDecline()
```

```csharp
private void OnNationLeavesMyDarkFederation_Violent(Prompt prompt)
```

```csharp
private void AllyCalledToOffensiveWar(TINationState calledAlly, TINationState callingNation, TIWarState war)
```

```csharp
public void JoinWarButton()
```

```csharp
public void DeclineWarButton()
```

```csharp
private void OnNationAsksRemoveArmiesPrompt(Prompt prompt)
```

```csharp
public void removeArmies_ProposeAlliancePressed()
```

```csharp
public void removeArmies_DeclareWarPressed()
```

```csharp
public void removeArmies_GoHomePressed()
```

```csharp
public void PushMissionPromptResponse(Prompt currentMissionPrompt)
```

```csharp
public void PushOperationPromptResponse(Prompt currentPrompt)
```

```csharp
public void BuildSabotageProjectMissionTargetList(TIMissionState mission)
```

```csharp
public void BuildStealProjectMissionTargetList(TIMissionState mission)
```

```csharp
public void StartPromptChangeTrajectory(TIFactionState faction, TISpaceFleetState maneuveringFleet, TISpaceFleetState targetFleet, Trajectory[] validTrajectories = null)
```

```csharp
private void UpdateMissionTargetText(TIMissionState mission)
```

```csharp
public void MissionTargetSelected(TIOrgState org)
```

```csharp
public void MissionTargetSelected(TIProjectTemplate project)
```

```csharp
public void OnClickMissionTargetConfirm()
```

```csharp
public void OnClickMissionTargetCancel()
```

```csharp
private void StartDiplomacyMission(TIMissionState mission, TICouncilorState targetCouncilor)
```

```csharp
public void StartAIToPlayerDiplomacyMission(TradeToPlayerInitiated e)
```

```csharp
public void StartAIToPlayerDiplomacyMission(TIMissionState mission, TICouncilorState targetCouncilor, TIFactionState contacted_Faction)
```

```csharp
private void OpenDiplomacyGreetingUI(TICouncilorState targetCouncilor)
```

```csharp
private void OpenDiplomacyTradeUI()
```

```csharp
public void OnDiplomacyGreetingContinueButton()
```

```csharp
public void OnDiplomacyCloseButton()
```

```csharp
public void DiplomacyClose()
```

```csharp
private void CleanUpDiplomacy()
```

```csharp
public void CompletedTrade(bool aiOffer)
```

```csharp
private Dictionary<NotificationScreenController.DiplomacyWindowText, string> GetDiplomacyWindowText(TICouncilorState targetCouncilor)
```

```csharp
public void ToggleSummaryLogPanel(SummaryCategory defaultCategory = SummaryCategory.None, bool audio = false)
```

```csharp
public void CloseSummaryReportPanel()
```

```csharp
public bool IsSummaryPanelOpen()
```

```csharp
public void SetSummaryLogReport(SummaryCategory category)
```

```csharp
private void UpdateSummaryLogReport(TIFactionState activePlayer, NotificationSummaryItem item)
```

```csharp
public void LaunchIntroCinematic()
```

```csharp
public IEnumerator PlayVideoWhenPrepared(VideoPlayer videoPlayer)
```

```csharp
public void PromptPlayerForBugReport(string message, bool recommendReload)
```

```csharp
public void CopyErrorCodeToClipboard()
```

```csharp
public void OpenDiscord()
```

```csharp
public void CloseReportBugPrompt()
```

```csharp
public delegate void CustomButtonPressed()
```
