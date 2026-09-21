# PrecombatController

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/UI/PrecombatController.cs`.*


## Class `PrecombatController`

```csharp
public class PrecombatController : CanvasControllerBase, IHud, ICanvas
```

### Fields

| Name | Type |
|---|---|
| `activePlayerHab` | private TIHabState |
| `side0HabOnly` | private bool |
| `side1HabOnly` | private bool |
| `activePlayerCombat` | public bool |
| `showFleet1FighterTemplates` | private bool |
| `showFleet2FighterTemplates` | private bool |
| `extendedPursuit` | private bool |
| `extensionStance` | private CombatStance |
| `activePlayerFleet` | private TISpaceFleetState |
| `otherFleet` | private TISpaceFleetState |
| `preCombatUIObject` | public GameObject |
| `preCombatBodyObject` | public GameObject |
| `preCombatCanvas` | public Canvas |
| `fleet1List` | public ListManagerBase |
| `fleet2List` | public ListManagerBase |
| `precombatHeader` | public TMP_Text |
| `fleet1Header` | public TMP_Text |
| `fleet2Header` | public TMP_Text |
| `fleet1Icon` | public Image |
| `fleet2Icon` | public Image |
| `fleet1ShipsCount` | public TMP_Text |
| `fleet2ShipsCount` | public TMP_Text |
| `fleet1CombatScore` | public TMP_Text |
| `fleet2CombatScore` | public TMP_Text |
| `fleet1Accel` | public TMP_Text |
| `fleet2Accel` | public TMP_Text |
| `fleet1DeltaV` | public TMP_Text |
| `fleet2DeltaV` | public TMP_Text |
| `stanceSelectionObject` | public GameObject |
| `enemyFighterNotesObject` | public GameObject |
| `enemyFighterNotes` | public TMP_Text |
| `engageButton` | public Button |
| `engageButtonText` | public TMP_Text |
| `engageButtonDescription` | public TMP_Text |
| `acceptButton` | public Button |
| `acceptButtonText` | public TMP_Text |
| `acceptButtonDescription` | public TMP_Text |
| `evadeButton` | public Button |
| `evadeButtonText` | public TMP_Text |
| `evadeButtonDescription` | public TMP_Text |
| `bidSelectionObject` | public GameObject |
| `bidHeader` | public TMP_Text |
| `bidDetail` | public TMP_Text |
| `deltaVBidSlider` | public Slider |
| `currentBidValue` | public TMP_Text |
| `maxBidValue` | public TMP_Text |
| `bidSubmitButtonText` | public TMP_Text |
| `biddingTip` | public TooltipTrigger |
| `sliderObject` | public GameObject |
| `maxBidInfoObject` | public GameObject |
| `resolutionSelectionObject` | public GameObject |
| `preCombatResults` | public TMP_Text |
| `autoResolveButtonText` | public TMP_Text |
| `playBattleButtonText` | public TMP_Text |
| `closeButtonText` | public TMP_Text |
| `autoResolveButton` | public GameObject |
| `liveResolveButton` | public GameObject |
| `closeButton` | public GameObject |
| `extendedPursuitObject` | public GameObject |
| `extendedPursuitText` | public TMP_Text |
| `extendedPursuitToggle` | public Toggle |
| `extendedPursuitToggleObject` | public GameObject |
| `extendedPursuitWarningRightIconObject` | public GameObject |
| `minimizePrecombatButton` | public Button |
| `addFightersButton` | public Button |
| `addFightersButtonText` | public TMP_Text |
| `addFightersButtonExplainer` | public TMP_Text |
| `cancelAttackButton` | public Button |
| `cancelAttackButtonText` | public TMP_Text |
| `cancelAttackButtonExplainer` | public TMP_Text |
| `STOFightersCanvasObject` | public GameObject |
| `STOFightersHeader` | public TMP_Text |
| `STOFightersExplainer` | public TMP_Text |
| `STOFightersTotalCount` | public TMP_Text |
| `STOFightersTotalBoostSpend` | public TMP_Text |
| `STOFightersCloseButtonText` | public TMP_Text |
| `STOFightersResetButtonText` | public TMP_Text |
| `STOFightersLaunchEverybodyButtonText` | public TMP_Text |
| `STONationsLaunchList` | public ListManagerBase |
| `postCombatUIObject` | public GameObject |
| `postCombatHeader` | public TMP_Text |
| `postCombatCloseButton` | public GameObject |
| `postCombatContinueText` | public TMP_Text |
| `postCombatCloseButtonText` | public TMP_Text |
| `postCombatGotoButtonText` | public TMP_Text |
| `postCombatReportText` | public TMP_Text |
| `postCombatFleet1Icon` | public Image |
| `postCombatFleet2Icon` | public Image |
| `postCombatFleet1List` | public ListManagerBase |
| `postCombatFleet2List` | public ListManagerBase |
| `postCombatFleet1Header` | public TMP_Text |
| `postCombatFleet2Header` | public TMP_Text |
| `postCombatButtonPanel` | public GameObject |
| `progressBar` | public RectTransform |
| `gotoSpaceObjectButton` | public GameObject |
| `gotoSpaceObject` | private TISpaceObjectState |
| `continueSpaceObjectButton` | public GameObject |
| `autoresoveButtonPanel` | public GameObject |
| `acceptAutoresolveButton` | public GameObject |
| `rejectAutoresolveButton` | public GameObject |
| `acceptAutoresolveButtonText` | public TMP_Text |
| `rejectAutoresolveButtonText` | public TMP_Text |
| `delayedCombatInitiationEvent` | private SpaceCombatInitiated |
| `maxDVBid_kps` | private float |
| `currentDVBid_kps` | private float |
| `envelop` | private bool |
| `attackerPursuitShipsToForceCombat` | private List<TISpaceShipState> |
| `STOFighterPlan` | public Dictionary<TINationState, PlannedFighters> |
| `combatProgress` | private float |

### Properties

- `public TISpaceCombatState combat`

### Methods

```csharp
public override void Initialize()
```

```csharp
public override void Refresh()
```

```csharp
private void OnCombatInitiated(SpaceCombatInitiated e)
```

```csharp
private void OnCombatStanceSelected(CombatStanceSelected e)
```

```csharp
private void OnCombatBidSelected(CombatBidSelected e)
```

```csharp
private void FillOutFleetValues(TISpaceFleetState fleet1, TISpaceFleetState fleet2, TIHabState hab1, TIHabState hab2, bool envelop = false, List<TISpaceShipState> overrideShips = null, int overrideShipsFleet = -1)
```

```csharp
public void FillOutCombatData()
```

```csharp
public void OpenStanceUI()
```

```csharp
public void OpenBiddingUI()
```

```csharp
public void OnDVSliderSet()
```

```csharp
public void OnExtendedPursuitToggleChanged()
```

```csharp
public void OpenResolutionUI()
```

```csharp
public void MinimizePreCombatButtonPressed()
```

```csharp
public void StanceSubmit(int stanceValue)
```

```csharp
public void BidSubmit()
```

```csharp
public void AutoresolveSelected()
```

```csharp
public void LiveResolveSelected()
```

```csharp
public void CloseResolveSelected()
```

```csharp
public void CancelAttackButton()
```

```csharp
private void EndPrecombatInteraction()
```

```csharp
public float AvailableBoostWithFighterPlan(TIFactionState faction)
```

```csharp
public void UpdateSTOFighterTotals()
```

```csharp
public void UpdateAllSTOFighterButtons()
```

```csharp
public void OnClick_OpenSTOFIghterControllerButton()
```

```csharp
public void OpenSTOFighterController(TIFactionState faction)
```

```csharp
public void InitSTOFighterController(TIFactionState faction)
```

```csharp
public void CloseSTOFighterController()
```

```csharp
public void OnClearAllFighterPlans()
```

```csharp
public void MaxOutAllFighterPlans()
```

```csharp
public void OnCombatSimulationUpdated(CombatSimulationUpdated e)
```

```csharp
public void OnCombatComplete(CombatEnds e)
```

```csharp
public void DisplayCombatResults(CombatRecord combatRecord, float progress, bool isSimulationResult)
```

```csharp
public void OnClosePostCombatButtonSelected()
```

```csharp
public void OnRejectAutoresolveSelected()
```

```csharp
public void OnAcceptAutoresolveSelected()
```

```csharp
public void OnGotoPostCombatButtonSelected()
```

```csharp
public void OnContinueButtonSelected()
```
