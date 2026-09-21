# OperationTargetListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/OperationTargetListItemController.cs`.*


## Class `OperationTargetListItemController`

```csharp
public class OperationTargetListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `locationSelector` | public TargetSelectionTool |
| `targetDisplayName` | public TMP_Text |
| `operationDetailString` | public TMP_Text |
| `tooltipTrigger` | public TooltipTrigger |
| `icon` | public Image |
| `supplyIcon` | public Image |
| `shipyardIcon` | public Image |
| `isTransferingIcon` | public Image |
| `target` | private TIGameState |
| `detailTextObject` | public GameObject |
| `detailGridObject` | public GameObject |
| `gridLayout` | public GridLayoutGroup |
| `detailGridList` | public ListManagerBase |
| `disableGoto` | private bool |
| `disableUnexploredSelection` | private bool |

### Methods

```csharp
public void SetListItem(IOperation operation, TIGameState target, bool inIntelScreen = false)
```

```csharp
public void OnOperationTargetButtonPressed()
```

```csharp
public void OnRightClickTransferTarget()
```
