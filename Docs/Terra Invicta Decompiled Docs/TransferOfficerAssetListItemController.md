# TransferOfficerAssetListItemController

*Decompiled from `TransferOfficerAssetListItemController.cs`.*


## Class `TransferOfficerAssetListItemController`

```csharp
internal class TransferOfficerAssetListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `assetName` | public TMP_Text |
| `assetDescription` | public TMP_Text |
| `officerListTip` | public TooltipTrigger |
| `officerIcons` | public Image[] |
| `selectAssetButton` | public Button |
| `selectedAssetButtonDefaultSprite` | private Sprite |
| `controller` | private OperationCanvasController |
| `giver` | private bool |
| `fleetIcon` | public FleetShipGridItemController |

### Properties

- `public OfficerCarrierState state`

### Methods

```csharp
private string OfficerTip(OfficerCarrierState state)
```

```csharp
public void SetListItem(OfficerCarrierState state, bool giver, OperationCanvasController controller)
```

```csharp
public void OnShipClicked()
```

```csharp
public void HighlightButtonAfterSelection()
```
