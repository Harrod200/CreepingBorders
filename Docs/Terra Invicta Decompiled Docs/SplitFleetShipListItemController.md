# SplitFleetShipListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/SplitFleetShipListItemController.cs`.*


## Class `SplitFleetShipListItemController`

```csharp
public class SplitFleetShipListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `controller` | private OperationCanvasController |
| `shipName` | public TMP_Text |
| `scuttleCost` | public TMP_Text |
| `ship` | private TISpaceShipState |
| `originFleetItem` | private bool |
| `singleTextLineItem` | public GameObject |
| `shipDataLineItem` | public GameObject |
| `combatScore` | public TMP_Text |
| `assaultScore` | public TMP_Text |
| `acceleration` | public TMP_Text |
| `DV` | public TMP_Text |
| `tooltip` | public TooltipTrigger |

### Methods

```csharp
public void SetListItem(OperationCanvasController controller, TISpaceShipState ship, bool originFleet, bool includeScuttleCost = false)
```

```csharp
public void OnClicked()
```

```csharp
public string GetTooltip(TISpaceShipState ship)
```
