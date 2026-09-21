# FuelSharingListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/FuelSharingListItemController.cs`.*


## Class `FuelSharingListItemController`

```csharp
internal class FuelSharingListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `shipName` | public TMP_Text |
| `baselinePropellant_tons` | public TMP_Text |
| `baselineDV` | public TMP_Text |
| `proposedPropellantChange` | public TMP_Text |
| `proposedNewDV` | public TMP_Text |
| `mainButton` | public Button |
| `upperButton` | public Button |
| `lowerButton` | public Button |
| `upperButtonImage` | public Image |
| `fleetIcon` | public FleetShipGridItemController |
| `column` | private int |
| `controller` | private OperationCanvasController |

### Properties

- `public TISpaceShipState ship`

### Methods

```csharp
public void SetListItem(TISpaceShipState ship, int column, OperationCanvasController controller)
```

```csharp
private string Tooltip()
```

```csharp
public void UpdateForProposedTransfers()
```

```csharp
public void OnMainButtonSelected()
```

```csharp
public void OnTopButtonPressed()
```

```csharp
public void OnBottomButtonPressed()
```
