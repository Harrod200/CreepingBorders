# SelectedTechListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/SelectedTechListItemController.cs`.*


## Class `SelectedTechListItemController`

```csharp
public class SelectedTechListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `techNameText` | public TMP_Text |
| `techUnlockChanceText` | public TMP_Text |
| `lockIcon` | public Image |
| `xIcon` | public Image |
| `checkIcon` | public Image |
| `leftXIcon` | public Image |
| `leftCheckIcon` | public Image |
| `leftCompletionObject` | public GameObject |
| `leftCompletionRT` | public RectTransform |
| `projectIcon` | public GameObject |
| `backgroundGradient` | public Image |
| `leftBackgroundGradient` | public Image |
| `techTooltip` | public TooltipTrigger |
| `leftCompleteSprite` | public Sprite |
| `leftIncompleteSprite` | public Sprite |
| `controller` | private ResearchScreenController |
| `techTreeLink` | private ChildTechGridItemController |

### Methods

```csharp
public void UpdateData(TIGenericTechTemplate tech, ResearchScreenController controller, ChildTechGridItemController techTreeObjectLink, bool prereqList, TIGenericTechTemplate[] altPrereq0 = null, TIGenericTechTemplate[] altPrereq1 = null, int altPrereqIndex = -1)
```

```csharp
public void OnClickItem()
```
