# SpaceCombatCanvasController

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/UI/SpaceCombatCanvasController.cs`.*


## Class `SpaceCombatCanvasController`

```csharp
public class SpaceCombatCanvasController : CanvasControllerBase, IHud, ICanvas
```

### Fields

| Name | Type |
|---|---|
| `GroupConstraints` | public AccelerationConstraints |
| `combatMgr` | public SpaceCombatManager |
| `combatState` | public TISpaceCombatState |
| `spaceCombatUITutorialController` | public UITutorialController |
| `spaceCombat_ShipSelectedUITutorialController` | public UITutorialController |
| `waypointTutorialController` | public UITutorialController |
| `formationTutorialController` | public UITutorialController |
| `endBattleButton` | public Button |
| `endBattleButtonOffImage` | public Image |
| `endBattleTooltip` | public TooltipTrigger |
| `fleetCommandPanelObject` | public GameObject |
| `fleetManeuverPanel` | public GameObject |
| `fleetManuverButtonTooltip` | public TooltipTrigger |
| `fleetCommandTargetPanel` | public GameObject |
| `fleetCommandsTargetText` | public TMP_Text |
| `autoResolveButton` | public Button |
| `autoResolveTooltip` | public TooltipTrigger |
| `autoResolveConfirmationPanel` | public GameObject |
| `autoResolveQuery` | public TMP_Text |
| `autoResolveConfirm` | public TMP_Text |
| `autoResolveCancel` | public TMP_Text |
| `_wasGamePlayingWhenAutoresolveOpened` | private bool |
| `fleetCommandButtons` | public List<Button> |
| `fleetCommandTooltips` | public List<TooltipTrigger> |
| `groupSelectionButtonObjects` | public List<GameObject> |
| `selectedShipPanel` | public Canvas |
| `selectedShipHull` | public Image |
| `selectedShipRadiators` | public Image |
| `selectedShipDrive` | public Image |
| `selectedShipName` | public TMP_Text |
| `selectedShipNoseWeapons` | public ListManagerBase |
| `selectedShipHullWeapons` | public ListManagerBase |
| `weaponUIControllers` | private Dictionary<ModuleDataEntry, ShipWeaponUIController> |
| `selectedShipCurrentBatteryCharge` | public Image |
| `selectedShipCurrentBatteryCapacity` | public Image |
| `selectedShipCurrentHeat` | public Image |
| `selectedShipCurrentHeatCapacity` | public Image |
| `selectedShipHeatIcon` | public Image |
| `selectedShipCoolingIcon` | public Image |
| `selectedShipPrimaryTargetText` | public TMP_Text |
| `commandButtons` | public List<Button> |
| `commandTooltips` | public List<TooltipTrigger> |
| `shipCommandPanelObject` | public GameObject |
| `shipManeuverPanel` | public GameObject |
| `shipManeuverButtonTooltip` | public TooltipTrigger |
| `commandsTargetText` | public TMP_Text |
| `commandSpinnerLeft` | public Button |
| `commandSpinnerRight` | public Button |
| `maneuverList` | public ListManagerBase |
| `selectedShipPersonnelList` | public ListManagerBase |
| `selectedShipHeatAlert` | public Image |
| `selectedShipBatteryAlert` | public Image |
| `selectedShipDeltaVAlert` | public Image |
| `currentDeltaVText` | public TMP_Text |
| `currentDeltaVCoverImage` | public RectTransform |
| `currentDeltaVCoverMaxWidth` | private float |
| `heatTooltip` | public TooltipTrigger |
| `batteryTooltip` | public TooltipTrigger |
| `groupMembershipList` | public TMP_Text |
| `shipCommandsDataDirty` | private bool |
| `fleetCommandsDataDirty` | private bool |
| `accelerationText` | public TMP_Text |
| `velocityText` | public TMP_Text |
| `batteryYBottom` | private float |
| `selectedShipCurrentBatteryCharge_y` | private float |
| `selectedShipCurrentBatteryCapacity_y` | private float |
| `batteryYRange` | private float |
| `heatYBottom` | private float |
| `selectedShipCurrentHeat_y` | private float |
| `selectedShipCurrentHeatCapacity_y` | private float |
| `HeatYRange` | private float |
| `deltaVTooltip` | public TooltipTrigger |
| `masterDamageGridGroup` | public GridLayoutGroup |
| `masterDamageGridControllers` | private Dictionary<Vector2Int, SpaceCombatDamageGridItemController> |
| `moduleDamageGrid` | private Dictionary<ModuleDataEntry, SpaceCombatDamageGridItemController> |
| `systemDamageGrid` | private Dictionary<ShipSystem, SpaceCombatDamageGridItemController> |
| `selectedFriendlyShip` | public CombatShipController |
| `groupSelectedFriendlyShips` | public List<CombatShipController> |
| `_groupConstraints` | private AccelerationConstraints |
| `friendlyShipList` | public ListManagerBase |
| `enemyShipList` | public ListManagerBase |
| `friendlyShipListTransform` | public RectTransform |
| `enemyShipListTransform` | public RectTransform |
| `clockController` | public SpaceCombatSpeedController |
| `selectedFriendlyShipState` | public TISpaceShipState |
| `playerReinforcmentPanel` | public GameObject |
| `enemyReinforcmentPanel` | public GameObject |
| `playerReinforcmentButton` | public Button |
| `enemyReinforcmentButtonGO` | public GameObject |
| `playerReinforcementTotal` | public TMP_Text |
| `playerReinforcementReadyCount` | public TMP_Text |
| `enemyReinforcementQty` | public TMP_Text |
| `playerReinforcementTooltip` | public TooltipTrigger |
| `enemyReinforcementTooltip` | public TooltipTrigger |
| `playerReinforcementEntryText` | public TMP_Text |
| `aiReinforcementEntryText` | public TMP_Text |
| `playerReinforcementTimerText` | public TMP_Text |
| `aiReinforcementTimerText` | public TMP_Text |
| `ReinforcementEntryTextTime` | private float |
| `playerReinforcementEntryTextTimer` | private float |
| `aiReinforcementEntryTextTimer` | private float |
| `reinforcementReorderPanel` | public GameObject |
| `reinforcementReorderList` | public ListManagerBase |
| `reinforcementReorderPanelHeaderText` | public TMP_Text |
| `openReinforcementsReorderPanelButtonObject` | public GameObject |
| `closeReinforcementsReorderPanelButtonObject` | public GameObject |
| `commandIconCache` | private Dictionary<string, SpaceCombatCanvasController.CommandIconCacheItem> |
| `leftHandFleetController` | public CombatFleetController |
| `rightHandFleetController` | public CombatFleetController |
| `leftHandFaction` | private TIFactionState |
| `rightHandFaction` | private TIFactionState |
| `isDisplayingGroupCommands` | private bool |
| `isManeuverPanelOpen` | private bool |
| `isFleetManeuverPanelOpen` | private bool |
| `isFleetCommandCardPanelOpen` | private bool |
| `control` | private bool |
| `formationPanel` | public GameObject |
| `formationPanelCanvas` | public Canvas |
| `formationTitle` | public TMP_Text |
| `formationPatternDropdown` | public TMP_Dropdown |
| `formationFocusDropdown` | public TMP_Dropdown |
| `formationConcentrationDropdown` | public TMP_Dropdown |
| `formationSpreadDropdown` | public TMP_Dropdown |
| `formationDescription` | public TMP_Text |
| `initialVelocityText` | public TMP_Text |
| `formationInitialVelocitySlider` | public Slider |
| `formationInitialVelocityValue` | public TMP_Text |
| `formationHabPlacementPanel` | public GameObject |
| `formationHabPlacementText` | public TMP_Text |
| `formationHabPlacementToggle` | public Toggle |
| `confirmFormationButton` | public Button |
| `confirmFormationButtonText` | public TMP_Text |
| `shipSwapInstructionsText` | public TMP_Text |
| `formationReinforcementSwapPanel` | public GameObject |
| `formationReinforcementShipList` | public ListManagerBase |
| `formationSelectedShip1` | public TISpaceShipState |
| `reinforcementSelectedShip` | public TISpaceShipState |
| `formationPatterns` | private List<TIFormationTemplate> |
| `formationPatternDictionary` | private Dictionary<string, int> |
| `formationPatternReverseDictionary` | private Dictionary<int, string> |
| `battleLogController` | public BattleLogController |
| `openBattleLogButton` | public GameObject |
| `battleLogCanvas` | public Canvas |
| `ManeuverPanelIndex` | private const int |
| `SpecialManeuverPanelIndex` | private const int |
| `reinforcementListItems` | public Dictionary<TISpaceShipState, ReinforcementReorderListItemController> |
| `ChangeCommandScopeMode` | public enum |
| `CommandIconCacheItem` | private struct |
| `colorChange` | public bool |
| `commandSprite_on` | public Sprite |
| `commandSprite_off` | public Sprite |

### Properties

- `public IDictionary<CombatantController, FriendlyShipListItemController> leftHandCombatants`
- `public IDictionary<CombatantController, EnemyShipListItemController> rightHandCombatants`
- `public bool debugHideUI`

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
public void PostCombatCleanup()
```

```csharp
public void ToggleMainMenu()
```

```csharp
public void ToggleFPSWidget()
```

```csharp
public void ToggleDebugHideUI()
```

```csharp
private void SetupShipLists(List<CombatShipController> shipsToHighlight)
```

```csharp
private void OnHabModuleDestroyed(HabModuleDestroyedInCombat e)
```

```csharp
private void OnShipRemoved(ShipDestroyed e)
```

```csharp
private void OnCombatantRemoved(CombatTargetableState combatantState)
```

```csharp
private void OnFleetCommandExecuted(FleetCommandExecuted e)
```

```csharp
private void OnUIScaleChanged(UIScaleSettingChange e)
```

```csharp
private IEnumerator RefreshUIScale()
```

```csharp
private IEnumerator ShowMainTutorialDelayed()
```

```csharp
private void ShowMainTutorial()
```

```csharp
private void ShowShipSelectedTutorial()
```

```csharp
private void ShowFormationTutorial()
```

```csharp
private void UpdateReinforcementText()
```

```csharp
public void UpdateReinforcmentTimerText(float value, bool isPlayer)
```

```csharp
public void ShowReinforcementTimer(bool value, bool isPlayer)
```

```csharp
public void UpdateReinforcementUI(TIFactionState faction, CombatFleetController controller, List<CombatShipController> ships)
```

```csharp
private string UpdateReinforcementTooltip(IList<TISpaceShipState> reinforcingShips = null, int availableReinforcementCount = -1)
```

```csharp
private void UpdateReinforcementPanel(bool isPlayer, IList<TISpaceShipState> reinforcingShips = null, int availableReinforcementCount = -1)
```

```csharp
private void UpdateCombatShipList(List<CombatShipController> shipsToHighlight)
```

```csharp
public void OnReinforcementButtonPressed()
```

```csharp
public void OnPressOpenReorderReinforcementButton()
```

```csharp
private void OpenReinforcementReorderPanel()
```

```csharp
public void OnPressCloseReorderReinforcementButton()
```

```csharp
private void CloseReinforcementReorderPanel()
```

```csharp
public void SetReinforcementReorderList(bool startup)
```

```csharp
public void RepositionShipInReinforcements(TISpaceShipState ship, int order)
```

```csharp
private void OnCombatTargetableStateSelected(CombatTargetedableStateSelected e)
```

```csharp
private void OnCombatTargetableStateSwapped(CombatTargetedableStateSwap e)
```

```csharp
public void DeselectShip(CombatantController combatantController)
```

```csharp
private void NewFriendlyShipSelected(CombatantController combatantController, bool openPanel = true, bool isAddingFromBoxSelect = false, bool isGroupSelectPrimarySelection = false)
```

```csharp
private void SelectAllShipsOfClass(TISpaceShipState selectedShipState, bool clearPrevGroup = true)
```

```csharp
public void SelectPrimaryShip(CombatShipController shipController)
```

```csharp
public void OnCloseFriendlyShipButtonClicked()
```

```csharp
public void ClearShipUI(CombatShipController shipController)
```

```csharp
public void OnCloseFriendlyShipView(bool skipTutorial = false)
```

```csharp
private void HandleGroupSelect(CombatantController combatantController, CombatantController previousSelectedShip, bool isAddingFromBoxSelect)
```

```csharp
public void UpdateGroupSelectUI()
```

```csharp
public void ClearGroupSelect()
```

```csharp
private void RemoveShipFromGroupSelect(CombatantController combatantController)
```

```csharp
private void UpdateGroupConstraints()
```

```csharp
public List<TISpaceShipState> GetBatchofShips(TISpaceShipState ship, SpaceCombatCanvasController.ChangeCommandScopeMode inputType)
```

```csharp
private void AddFriendlyShipListeners()
```

```csharp
private void RemoveFriendlyShipListeners()
```

```csharp
public void SetBatteryCapacityPosition()
```

```csharp
public void SetPowerStoragePosition(ShipPowerSystemsChargeChange e)
```

```csharp
public void SetBatteryChargePosition()
```

```csharp
public void SetHeatPosition(ShipHeatChange e)
```

```csharp
public void SetHeatPosition()
```

```csharp
public void SetHeatCapacityPosition()
```

```csharp
public void UpdateVelocityValue()
```

```csharp
public void UpdateAccelerationValue()
```

```csharp
private string DeltaVTooltip()
```

```csharp
public void OnDeltaVChange(ShipDeltaVChange e)
```

```csharp
public void OnDeltaVChange()
```

```csharp
public void OnShipDamageControlRotationStatusChanged(ShipDamageControlRotationStatusChanged e)
```

```csharp
public void OnPrimaryTargetSelected(ShipPrimaryTargetSelected e)
```

```csharp
public void SetPrimaryTargetText()
```

```csharp
public static void SetHeatIcon(TISpaceShipState ship, Image icon, Image coolingIcon)
```

```csharp
public void UpdateForDamageChange(ShipSystemDamageChange e)
```

```csharp
public void UpdateForDamageChange(ShipPartDamageChange e)
```

```csharp
public void OnArmorHit(ShipArmorFacingStruckInCombat e)
```

```csharp
public void SetDamageControlIcons()
```

```csharp
public void OnPartBeingRepaired(ShipPartBeingRepaired e)
```

```csharp
public void OnPartNoLongerBeingRepaired(ShipPartNoLongerBeingRepaired e)
```

```csharp
public void OnSystemBeingRepaired(ShipSystemBeingRepaired e)
```

```csharp
public void OnSystemNoLongerBeingRepaired(ShipSystemNoLongerBeingRepaired e)
```

```csharp
public void OnAIControlChange(ShipAIControlChange e)
```

```csharp
public void OnWeaponModeChanged(ShipWeaponModeChanged e)
```

```csharp
public void OnWeaponFired(ShipWeaponFired e)
```

```csharp
public void OnCommandExecuted(ShipCommandExecuted e)
```

```csharp
public void OnCombatManeuverComplete(CombatManeuverComplete e)
```

```csharp
public void OnCollisionStatusUpdate(CombatCollisionAvoidanceStatusChange e)
```

```csharp
public void OnRadiatorsExtended(CompleteExtendRadiatorsEvent e)
```

```csharp
public void OnRadiatorsRetracted(CompleteRetractRadiatorsEvent e)
```

```csharp
public void SetSelectedShipRadiators()
```

```csharp
public void OnPropulsionValuesUpdated(CombatShipPropulsionValuesUpdated e)
```

```csharp
public static Vector2Int GetModuleDamageControllerPosition(TISpaceShipState ship, ModuleDataEntry module)
```

```csharp
public static Vector2Int GetSystemDamageControllerPosition(TISpaceShipState ship, ShipSystem shipSystem)
```

```csharp
public void UpdateCommandPanel(bool groupSelected)
```

```csharp
private void UpdateCommandPanelForSingleShip()
```

```csharp
private void UpdateCommandPanelForGroup()
```

```csharp
public void ToggleTargetForCommandButtonPanel()
```

```csharp
public void ToggleShipManeuverPanel()
```

```csharp
public void ToggleFleetManeuverPanel()
```

```csharp
public void ToggleFleetCommandCard()
```

```csharp
public static void UpdateManeuverList(TISpaceShipState shipState, CombatShipController shipController, ListManagerBase maneuverList)
```

```csharp
public void OnShipOfficerKilled(ShipOfficerKilled e)
```

```csharp
public void UpdatePersonnelList()
```

```csharp
public void SetSelectedShipPanel()
```

```csharp
private void SetShipGroupMembershipString()
```

```csharp
private void OnShipGroupChanged(CombatShipGroupChange e)
```

```csharp
public void UpdateFleetCommandPanel()
```

```csharp
public void PlayFleetCommandButtonAudio()
```

```csharp
public void PlayFleetManuverCommandButtonAudio()
```

```csharp
public void SetEndBattleToggleSprite(EndCombatStanceChanged e)
```

```csharp
public void SetEndBattleToggleSprite()
```

```csharp
public void OnEndBattleToggleSelected()
```

```csharp
public string EndBattleTooltip()
```

```csharp
public void OnCombatEndTriggered(CombatEndTriggered e)
```

```csharp
public void OnAutoResolveBattleSelected()
```

```csharp
public void OnAutoResolveConfirmed()
```

```csharp
public void OnAutoResolveCanceled()
```

```csharp
public string AutoResolveTooltip()
```

```csharp
public void ConfigureAutoResolvePanel()
```

```csharp
public string BuildHeatTooltip(TISpaceShipState state)
```

```csharp
public string BuildBatteryTooltip(TISpaceShipState state)
```

```csharp
public void OnMouseEnterShipList()
```

```csharp
public void OnMouseExitShipList()
```

```csharp
public void OnMouseEnterDropDown()
```

```csharp
public void SetGroupSelectionButtons(bool forceAllOff = false)
```

```csharp
public void OnControlGroupButtonPressed(int buttonIdx)
```

```csharp
private void OpenFormationUI()
```

```csharp
public void ConfirmFormation()
```

```csharp
private void SetFormation()
```

```csharp
private void SetFormationVelocity(float value_mps)
```

```csharp
public void OnFormationTemplateDropdownChanged()
```

```csharp
public void OnFormationSpacingDropdownChanged()
```

```csharp
public void OnFormationConcentrationDropdownChanged()
```

```csharp
public void OnFormationFocusDropdownChanged()
```

```csharp
public void OnVelocitySliderValueChanged()
```

```csharp
public void OnFormationVelocityChanged()
```

```csharp
public void ToggleFormationHabPlacement()
```

```csharp
private void InitializeFormationSelectionReinforcementList()
```

```csharp
private void UpdateInteractableFormationReinforcementButtons()
```

```csharp
private void OnShipSelectedDuringFormationSetting(ShipSelectedDuringFormationSetting e)
```

```csharp
public void FormationSetting_SwapShipToReinforcements()
```

```csharp
public void OnFormationSettingReinforcementShipSelected(TISpaceShipState ship)
```

```csharp
public void OpenBattleLog()
```

```csharp
public void CloseBattleLog()
```

```csharp
public CommandIconCacheItem(bool colorChange, Sprite commandSprite_on, Sprite commandSprite_off)
```
