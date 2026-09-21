# TransferOfficerListItemController

*Decompiled from `TransferOfficerListItemController.cs`.*


## Class `TransferOfficerListItemController`

```csharp
internal class TransferOfficerListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `officerIcon` | public Image |
| `officerName` | public TMP_Text |
| `officerDescription` | public TMP_Text |
| `officerEffects` | public TooltipTrigger |
| `transferOfficerButton` | public Button |
| `buttonBackground` | public Image |
| `giver` | private bool |
| `controller` | private OperationCanvasController |

### Properties

- `public TIOfficerState officer`

### Methods

```csharp
private string OfficerTip(TIOfficerState officer, int rankToShow, OfficerCarrierState otherAsset)
```

```csharp
public void SetListItem(TIOfficerState officer, OperationCanvasController controller, bool giver, bool initialHide, OfficerCarrierState asset)
```

```csharp
public void OnOfficerButtonPressed()
```

```csharp
public void Colorize(Color color)
```
