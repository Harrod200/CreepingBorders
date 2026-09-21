# OperationCanvasController

*Decompiled from `PavonisInteractive/TerraInvicta/OperationCanvasController.cs`.*


## Class `OperationCanvasController`

```csharp
public class OperationCanvasController : CanvasControllerBase
```

### Fields

| Name | Type |
|---|---|
| `currentOperationTemplate` | private IOperation |
| `SelectedOperation` | public IOperation |
| `IsVisible` | public bool |
| `IsInTargetSelectionMode` | public bool |
| `ProspectiveTarget` | public TIGameState |
| `selectedPropellantGroup` | private PropellantGroup |
| `sharingFleet` | private TISpaceFleetState |
| `freeTakers` | public List<TISpaceShipState> |
| `actorState` | private TIGameState |
| `masterOperationCanvas` | public Canvas |
| `iconsPanel` | public GameObject |
| `iconsGridManager` | public ListManagerBase |
| `hollowNamePanel` | public GameObject |
| `operationName` | public TMP_Text |
| `operationDescription` | public TMP_Text |
| `operationMasterPanel` | public Canvas |
| `operationInfoPanel` | public GameObject |
| `confirmPanel` | public GameObject |
| `confirmOperationName` | public TMP_Text |
| `targetDisplayName` | public TMP_Text |
| `confirmButton` | public Button |
| `paymentDropdownObject` | public GameObject |
| `paymentDropdown` | public TMP_Dropdown |
| `targetNameObject` | public GameObject |
| `targetDropdownObject` | public GameObject |
| `targetDropdown` | public TMP_Dropdown |
| `durationReportObject` | public GameObject |
| `durationText` | public TMP_Text |
| `selectingTarget` | private bool |
| `currentTargeting` | private TIOperationTargeting |
| `currentTarget` | private TIGameState |
| `currentTargetArmyMoveFinalDestination` | private TIGameState |
| `resourceCostOptions` | private List<TIResourcesCost> |
| `selectedResourceCostOption` | private TIResourcesCost |
| `activeButton` | private OperationButtonController |
| `targetDropdownTemplateHeight` | private float |
| `maximizeButtonGameObject` | public GameObject |
| `currentFleetName` | public TMP_Text |
| `newFleetText` | public TMP_Text |
| `fleetSplitPanel` | public GameObject |
| `fleetSplitPanelHeader` | public TMP_Text |
| `originFleetList` | public ListManagerBase |
| `newFleetList` | public ListManagerBase |
| `possibleTransitOrbit` | public GameObject |
| `changeTrajectoryCanvas` | public Canvas |
| `changeTrajectoryPromptHeaderText` | public TMP_Text |
| `changeTrajectoryPromptMEssageText` | public TMP_Text |
| `changeTrajectoryPromptConfirmText` | public TMP_Text |
| `changeTrajectoryPromptCancelText` | public TMP_Text |
| `changeTrajectoryConfirmButton` | public Button |
| `changeTrajectoryCancelButton` | public Button |
| `changingInvalidTrajectory` | public bool |
| `changeTrajectoryFaction` | private TIFactionState |
| `changeTrajectoryFleet` | private TIGameState |
| `changeTrajectoryTargetFleet` | private TIGameState |
| `armiesUITutorialController` | public UITutorialController |
| `spacebodyUITutorialController` | public UITutorialController |
| `fleetOperationsUITutorialController` | public UITutorialController |
| `fleetTransferTutorialController` | public UITutorialController |
| `launchExofighterTutorialController` | public UITutorialController |
| `launchExofighterHighlightDummy` | public GameObject |
| `operationTemplateForced` | private IOperation |
| `targetSelectionTool` | public TargetSelectionTool |
| `thrustProfileTool` | public ThrustProfileTool |
| `QueuedTargets` | public List<TIGameState> |
| `prospectiveQueuedTargets` | public List<List<TIGameState>> |
| `prospectiveQueuedTargetsDictionary` | public Dictionary<TIArmyState, List<TIRegionState>> |
| `operationControlsDirty` | private bool |
| `targetOptionData` | private Dictionary<int, TIGameState> |
| `reverseTargetOptionData` | private Dictionary<TIGameState, int> |
| `originFleetShips` | private List<TISpaceShipState> |
| `newFleetShips` | private List<TISpaceShipState> |
| `splitAllDamagedButton` | public Button |
| `resetSplitFleetPanelButton` | public Button |
| `splitAllDamagedButtonText` | public TMP_Text |
| `resetSplitFleetButtonText` | public TMP_Text |
| `propellantsInFleet` | private List<PropellantGroup> |
| `selectedPropellantGroupIdx` | private int |
| `propellantSharingPanel` | public GameObject |
| `propellantTypeList` | public ListManagerBase |
| `availableGiversList` | public ListManagerBase |
| `selectedTakersList` | public ListManagerBase |
| `availableTakersList` | public ListManagerBase |
| `ResetTakersButton` | public Button |
| `EqualizeDistributionButton` | public Button |
| `ResetTakersButtonTip` | public TooltipTrigger |
| `EqualizeDistributionButtonTip` | public TooltipTrigger |
| `propellantSharingHeader` | public TMP_Text |
| `selectPropellantHeader` | public TMP_Text |
| `giverColumnHeader` | public TMP_Text |
| `selectedTakerColumnHeader` | public TMP_Text |
| `availableTakerColumnHeader` | public TMP_Text |
| `sharePropellantInstructions` | public TMP_Text |
| `resetTakersButtonText` | public TMP_Text |
| `equalDistroButtonText` | public TMP_Text |
| `availableGivers` | public List<TISpaceShipState> |
| `selectedTakers` | public List<TISpaceShipState> |
| `lockedTakers` | public List<TISpaceShipState> |
| `availableTakers` | public List<TISpaceShipState> |
| `propellantSharingEvents` | public List<PropellantSharingEvent> |
| `transferOfficersCanvas` | public Canvas |
| `givingAssetList` | public ListManagerBase |
| `selectedAssetOfficerList` | public ListManagerBase |
| `receivingAssetOfficerList` | public ListManagerBase |
| `receivingAssetList` | public ListManagerBase |
| `transferOfficerCanvasHeader` | public TMP_Text |
| `givingAssetHeader` | public TMP_Text |
| `givingOfficerHeader` | public TMP_Text |
| `receivingOfficerHeader` | public TMP_Text |
| `receivingAssetHeader` | public TMP_Text |
| `givingAssetOfficerCapacity` | public TMP_Text |
| `receivingAssetOfficerCapacity` | public TMP_Text |
| `transferOfficersConfirmButtonText` | public TMP_Text |
| `transferOfficersResetButtonText` | public TMP_Text |
| `plannedOfficerTransfers` | private Dictionary<TIOfficerState, OfficerCarrierState> |
| `officerTransferAssets` | private List<OfficerCarrierState> |
| `selectedOfficerGiver` | public OfficerCarrierState |
| `selectedOfficerReceiver` | public OfficerCarrierState |
| `givingSideOfficerListItems` | private Dictionary<TIOfficerState, TransferOfficerListItemController> |
| `receivingSideOfficerListItems` | private Dictionary<TIOfficerState, TransferOfficerListItemController> |
| `multiSelectArmyCanvas` | public Canvas |
| `multiSelectArmyHeaderText` | public TMP_Text |
| `armyList` | public ListManagerBase |
| `armyGroup` | public List<TIArmyState> |

### Properties

- `public static OperationCanvasController Singleton`
- `public TIGameState targetBase`
- `public OperationActorState operationType`

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
private IEnumerator ForceTargetSelectLayoutRefresh()
```

```csharp
private void AddListeners()
```

```csharp
private void RemoveListeners()
```

```csharp
public override void OnDestroy()
```

```csharp
public void Shutdown()
```

```csharp
private void OnInfoScreenOpened(InfoScreenOpened e)
```

```csharp
public override void UpdateUIScaling()
```

```csharp
public void CloseForReverseSelection()
```

```csharp
private void RestoreOperationsControlsCanvas(InfoScreenClosed e)
```

```csharp
private void UpdateCanvas(TIGameState actingState, bool globalForceUpdate = false)
```

```csharp
private void UpdateCanvas(StartArmyOperation e)
```

```csharp
private void UpdateCanvas(StartFleetOperation e)
```

```csharp
private void UpdateCanvas(FleetArrivesAtDestination e)
```

```csharp
private void UpdateCanvas(StartFactionOperation e)
```

```csharp
private void UpdateCanvas(OperationExecuted e)
```

```csharp
private void UpdateCanvas(FleetOperationWithDurationComplete e)
```

```csharp
private void ArmySelected(ArmyMapItemSelected e)
```

```csharp
private void FleetSelected(FleetSelectedEvent e)
```

```csharp
private void NaturalSpaceObjectSelected(SpaceBodySelectedEvent e)
```

```csharp
private void NaturalSpaceObjectSelected(LagrangePointSelectedEvent e)
```

```csharp
private void OnCouncilorSelected(CouncilorMapItemSelected e)
```

```csharp
private void OnCouncilorSelected(CouncilorSelectedOffMap e)
```

```csharp
private void OnCouncilorSelected(TICouncilorState councilor)
```

```csharp
private void OnResourcesUpdated(FactionResourcesUpdated e)
```

```csharp
private void OnMapActivationChanged(MapActivationChangedEvent e)
```

```csharp
private void ArmyUpdated(ArmyStatusUpdate e)
```

```csharp
private void OnArmyAssignedToFaction(ArmyAssignedToFaction e)
```

```csharp
private void OnFleetAvailabilityChange(FleetAvailabilityChange e)
```

```csharp
private void OnFleetCoreStatusChange(FleetCoreStatusChange e)
```

```csharp
private void OnSpaceCombatInitiated(SpaceCombatInitiated e)
```

```csharp
private void OnNarrativeEventFired(NarrativeEventPushedToPlayer e)
```

```csharp
private void OnPolicyMenuFired(PolicyMenuPushedToPlayer e)
```

```csharp
private void OnReverseArmyDestinationTriggered(DeployArmyToRegionRequested e)
```

```csharp
private void OnForceTrajectorySelectionUI_NoCurrentTrajectory(ForceTrajectorySelectionUI_NoCurrentTrajectory e)
```

```csharp
private void OnForceFleetOperation(ForceFleetOperation e)
```

```csharp
public void DisableCurrentOperation(bool fullShutdown = false)
```

```csharp
private void OnDisableMyFleetPanel()
```

```csharp
private void OnDisableMyArmyPanel()
```

```csharp
private void OnDisableSpaceOpPanel()
```

```csharp
private void OnStartNewMissionPhase(TimeEventStart e)
```

```csharp
private void FleetSelected(TISpaceFleetState fleet, bool forceRefresh = false)
```

```csharp
private void OnForceTrajectorySelectionUI(ForceTrajectorySelectionUI e)
```

```csharp
public void OnConfirmTrajectoryChange()
```

```csharp
public void OnCancelTrajectoryChange()
```

```csharp
private void CleanupTrajectoryChange()
```

```csharp
private bool EligibleTransferChangeSelected()
```

```csharp
private void CheckAndRemoveArmyListener()
```

```csharp
private void ArmySelected(TIArmyState army)
```

```csharp
private void NaturalSpaceObjectSelected(TINaturalSpaceObjectState spaceObject)
```

```csharp
private void AddCanvasToStack()
```

```csharp
private void UpdateOperationControls()
```

```csharp
private OperationButtonController FindOperationButton(TIOperationTemplate operation)
```

```csharp
private void HideTutorials()
```

```csharp
public void Tutorial_HighlightLaunchExofighterOp()
```

```csharp
public void OnClickCloseActionPanel(bool fullShutdown)
```

```csharp
public void CloseActionPanel(bool fullShutdown)
```

```csharp
public void OnOperationSelected(OperationButtonController button, TIGameState forceTarget = null)
```

```csharp
public void OnOperationSelected(TIOperationTemplate operation, TIGameState forceTarget = null)
```

```csharp
private void UpdateOperationBar()
```

```csharp
public void OnOperationConfirmHover()
```

```csharp
private void InitTargetSelection(TIGameState forceTarget = null)
```

```csharp
public bool AttemptSetNewTargetBase(TINaturalSpaceObjectState newTargetBase)
```

```csharp
private void NewOperationTargetBase(TIGameState newTargetBase)
```

```csharp
private void NewOperationTarget(OperationTargettedEvent e)
```

```csharp
private void NewOperationTarget(TIGameState newTarget)
```

```csharp
private void UpdateDurationLabel()
```

```csharp
private void UpdateTargetData()
```

```csharp
public void OnCostDropdownChanged()
```

```csharp
public void OnTargetSelectionToolElementClicked(TIGameState targetState)
```

```csharp
private void OnNavigationButtonClicked(TIGameState gameState)
```

```csharp
private void FillOutTargetDropdown(IList<TIGameState> targets, TIGameState initialTarget, bool contested, Dictionary<TIGameState, float> successChances)
```

```csharp
public void OnTargetDropDownChanged()
```

```csharp
private void ShutdownTargetSelection()
```

```csharp
private void OpenThrustProfileTool()
```

```csharp
private void CloseThrustProfileTool()
```

```csharp
public void OnConfirmOperation()
```

```csharp
public void SetOperationInfo(IOperation operationType)
```

```csharp
private void UpdateOperationInfo()
```

```csharp
public void OnOperationPointerEnter(OperationButtonController button)
```

```csharp
public void OnOperationPointerExit(OperationButtonController button)
```

```csharp
public void InitiateTargetOrbits(TargetOrbits e)
```

```csharp
public void EndTargetOrbits(DeTargetOrbits e)
```

```csharp
public void InitiateTargetHabSites(TargetHabSites e)
```

```csharp
public void EndTargetHabSites(DeTargetHabSites e)
```

```csharp
public void MinimizeTargetPanel()
```

```csharp
public void MaximizeTargetPanel()
```

```csharp
public void OnFleetSplitProposed(TargetShipsForFleetSplit e)
```

```csharp
public void OnFleetSplitConcluded(DetargetShipForFleetSplit e)
```

```csharp
public void CloseSplitFleetPanel()
```

```csharp
public void InitializeSplitFleetPanel()
```

```csharp
public void UpdateSplitFleetPanel()
```

```csharp
public void OnClickMoveAllDamaged()
```

```csharp
public void OnClickResetSplitFleet()
```

```csharp
public void SwapItem(TISpaceShipState ship, bool fromOriginFleet)
```

```csharp
public void OnClickExitSplitFleetPanel()
```

```csharp
public void OnClickCancelSplitFleet()
```

```csharp
public void OnSharePropellantProposed(InitiateSharePropellant e)
```

```csharp
private bool ValidGiver(TISpaceShipState ship)
```

```csharp
private bool ValidTaker(TISpaceShipState ship)
```

```csharp
public void OnBeginPropellantSharing()
```

```csharp
public void OnPropellantSelected(int idx, bool force)
```

```csharp
public void UpdateAllSharingLists()
```

```csharp
public void SetSharingButtions()
```

```csharp
public void OnTakerAdded(TISpaceShipState ship)
```

```csharp
public void OnTakerRemoved(TISpaceShipState ship)
```

```csharp
public void LockTaker(TISpaceShipState taker)
```

```csharp
public void UnlockTaker(TISpaceShipState taker)
```

```csharp
public float SetPropellantSharingEvent(TISpaceShipState giver, TISpaceShipState taker, float amount_tons)
```

```csharp
public float ProposedTake(TISpaceShipState ship)
```

```csharp
public float ProposedGive(TISpaceShipState ship)
```

```csharp
public float NeededTake(TISpaceShipState ship)
```

```csharp
public float AvailableGive(TISpaceShipState ship)
```

```csharp
public void AttemptGivePropellant(TISpaceShipState giver, float amount_tons)
```

```csharp
public float ReturnPropellantToGiver(TISpaceShipState giver, TISpaceShipState taker, float amount_tons)
```

```csharp
public void ResetPropellantGiver(TISpaceShipState ship)
```

```csharp
public void ResetPropellantTaker(TISpaceShipState ship)
```

```csharp
public void OnResetReceiversClicked()
```

```csharp
public void OnEqualDistroPropellantPressed()
```

```csharp
public void OnCloseSharePropellant()
```

```csharp
private string AssetOfficerCapacityString(OfficerCarrierState asset)
```

```csharp
public void OnTransferOfficersProposed(InitiateTransferOfficers e)
```

```csharp
public void InitializeOfficerTransferCanvas()
```

```csharp
public void ConfirmTransferOfficersPressed()
```

```csharp
public bool StartTransferOfficersOperation()
```

```csharp
public void ResetTransferOfficersPressed()
```

```csharp
public void CloseOfficerTransferCanvas()
```

```csharp
public void SetupTransferOperation(TISpaceFleetState actingFleet)
```

```csharp
public void SetOfficerTransferListItemsValid(ListManagerBase officerList, OfficerCarrierState officerListCarrier, OfficerCarrierState otherOfficerCarrier)
```

```csharp
public void SetSelectedGiver(OfficerCarrierState selectedGiver)
```

```csharp
public void SetSelectedReciever(OfficerCarrierState selectedReceiver)
```

```csharp
public void ProposeOfficerTransfer(TIOfficerState officer, bool fromGivers)
```

```csharp
public void OnMultiSelectArmiesSelected(MultiSelectArmiesSelected e)
```

```csharp
public void UpdateSelectedArmies()
```

```csharp
public List<TIArmyState> GetSelectedArmies()
```

```csharp
public void AddArmyToMultiSelectGroup(TIArmyState armyToAdd)
```

```csharp
public void RemoveArmyFromMultiSelectGroup(TIArmyState armyToRemove)
```

```csharp
private void UpdateMultiSelectedArmies()
```

```csharp
public void OnClickCloseMultiArmyPanel()
```

```csharp
public void CloseMultiArmyPanel()
```

```csharp
public void OpenMultiArmyPanel()
```

```csharp
public bool CanSelectArmyGroup()
```
