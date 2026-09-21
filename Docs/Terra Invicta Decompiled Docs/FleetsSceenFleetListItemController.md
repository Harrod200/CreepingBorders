# FleetsSceenFleetListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/FleetsSceenFleetListItemController.cs`.*


## Class `FleetsSceenFleetListItemController`

```csharp
public class FleetsSceenFleetListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `activePlayer` | private TIFactionState |
| `controller` | private FleetsScreenController |
| `fleet` | public TISpaceFleetState |
| `ship` | public TISpaceShipState |
| `faction` | private TIFactionState |
| `isGroupItem` | public bool |
| `fleetLineObject` | public GameObject |
| `fleetIcon` | public Image |
| `fleetName` | public TMP_Text |
| `fleetShipsCount` | public TMP_Text |
| `fleetShipsCombatScore` | public TMP_Text |
| `transferDataPanel` | public GameObject |
| `transferOriginIcon` | public Image |
| `transferDestinationIcon` | public Image |
| `transferDestinationDetailIcon` | public Image |
| `fleetTransferProgressLine` | public RectTransform |
| `fleetTransferSliderZeroPoint` | private float |
| `fleetTransferSliderRange` | private float |
| `transferProgressIcon` | public Image |
| `transferPendingCombatIcon` | public Image |
| `transferTextDetail` | public TMP_Text |
| `genericOpDetailPanel` | public GameObject |
| `genericOpImage` | public Image |
| `genericOpImageSmall` | public Image |
| `genericOpLine1` | public TMP_Text |
| `genericOpLine2` | public TMP_Text |
| `fleetHomeportObject` | public GameObject |
| `fleetHomeportText` | public TMP_Text |
| `setAlarmButtonObject` | public GameObject |
| `setAlarmTooltip` | public TooltipTrigger |
| `setAlarmText` | public TMP_Text |
| `accelerationText` | public TMP_Text |
| `deltaVText` | public TMP_Text |
| `fleetPendingCombat` | public Image |
| `damagedShipsInFleet` | public Image |
| `dvIcon` | public Image |
| `accelIcon` | public Image |
| `operationDetailBG` | public Image |
| `BGImage` | public Image |
| `gotoButton` | public GameObject |
| `editButton` | public GameObject |
| `o1` | private TIGameState |
| `o2` | private TIGameState |
| `d1` | private TIGameState |
| `d2` | private TIGameState |
| `fleetOperationsGrid` | public ListManagerBase |
| `fleetCouncilorIconGrid` | public ListManagerBase |
| `renameMyFleetPanel` | public GameObject |
| `saveNameText` | public TextMeshProUGUI |
| `revertNameText` | public TextMeshProUGUI |
| `nameInputField` | public TMP_InputField |
| `shipLineObject` | public GameObject |
| `nose` | public Image |
| `hull` | public Image |
| `tail` | public Image |
| `drive` | public Image |
| `radiator` | public Image |
| `shipName` | public TMP_Text |
| `shipClass` | public TMP_Text |
| `shipRole` | public TMP_Text |
| `shipCombatScore` | public TMP_Text |
| `shipAcceleration` | public TMP_Text |
| `shipDeltaV` | public TMP_Text |
| `shipCouncilorIconGrid` | public ListManagerBase |
| `shipSummaryTooltip` | public TooltipTrigger |
| `shipOfficerIconGrid` | public ListManagerBase |
| `fleetDataDirty` | private bool |

### Methods

```csharp
public void Init(FleetsScreenController controller)
```

```csharp
public static bool ShouldShowTransitData(TIGameState state)
```

```csharp
public void RefreshTransitData()
```

```csharp
private void AddFleetListeners()
```

```csharp
private void RemoveFleetListeners()
```

```csharp
private void OnMajorMyFleetUpdate(ShipsAddedToFleet e)
```

```csharp
private void OnMajorMyFleetUpdate(ShipsRemovedFromFleet e)
```

```csharp
private void OnMajorMyFleetUpdate(CombatEnds e)
```

```csharp
private void OnMyFleetUpdate(StartFleetOperation e)
```

```csharp
private void OnMyFleetUpdate(OperationExecuted e)
```

```csharp
private void OnMyFleetUpdate(FleetArrivesAtDestination e)
```

```csharp
private void OnMyFleetUpdate(CouncilorDepartsShip e)
```

```csharp
private void OnMyFleetUpdate(CouncilorVisibilityChanged e)
```

```csharp
private void OnMyFleetUpdate(CouncilorPositionUpdated e)
```

```csharp
private void OnMyFleetUpdate(ShipResupplied e)
```

```csharp
private void OnMyFleetUpdate(FleetUndocks e)
```

```csharp
private void OnMyFleetUpdate(FleetAvailabilityChange e)
```

```csharp
private void OnEnable()
```

```csharp
private void UpdateFleet()
```

```csharp
public void UpdateTransitData(TIGameState gameState)
```

```csharp
public void UpdateListItem(TIGameState gameState)
```

```csharp
public void OnClickToggleAlarm()
```

```csharp
public void CreateGroupItem(TIFactionState faction)
```

```csharp
private void ToggleCollapsed()
```

```csharp
public void OnGotoFleetButtonPressed()
```

```csharp
public void OnClickRename()
```

```csharp
public void OnClickRevertRename()
```

```csharp
public void RevertRename()
```

```csharp
public void OnClickSaveName()
```

```csharp
public void ShowRenameMyFleetPanel()
```

```csharp
public void OnSelectInputBox()
```

```csharp
public void OnDeSelectInputBox()
```

```csharp
public void OnOpenFleetButtonPressed()
```

```csharp
public void FleetButtonClicked()
```

```csharp
public void ShipButtonPressed()
```

```csharp
public void LocationButtonPressed()
```

```csharp
public void SmallLocationButtonPressed()
```

```csharp
public void BigDestinationButtonPressed()
```

```csharp
public void SmallDestinationButtonPressed()
```

```csharp
private void OnDestroy()
```
