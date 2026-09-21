# FleetsScreenShipListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/FleetsScreenShipListItemController.cs`.*


## Class `FleetsScreenShipListItemController`

```csharp
public class FleetsScreenShipListItemController : MonoBehaviour
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
public void UpdateTransitData(TIGameState gameState)
```

```csharp
public void UpdateListItem(TIGameState gameState)
```

```csharp
private void UpdateFleet()
```

```csharp
private void ToggleCollapsed()
```

```csharp
public void OnGotoFleetButtonPressed()
```

```csharp
public void OnOpenFleetButtonPressed()
```

```csharp
public void ShipButtonPressed()
```

```csharp
private void OnDestroy()
```
