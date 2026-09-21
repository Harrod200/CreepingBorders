# CouncilorAugmentationListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/CouncilorAugmentationListItemController.cs`.*


## Class `CouncilorAugmentationListItemController`

```csharp
public class CouncilorAugmentationListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `option` | private CouncilorAugmentationOption |
| `councilor` | private TICouncilorState |
| `controller` | private CouncilGridController |
| `selectButton` | public Button |
| `augmentationName` | public TMP_Text |
| `augmentationDescription` | public TMP_Text |
| `augmentationCost` | public TMP_Text |
| `augmentationDetails` | public TooltipTrigger |
| `backgroundImage` | public Image |
| `defaultBackground` | public Sprite |
| `selectedBackground` | public Sprite |

### Methods

```csharp
public void Init(CouncilGridController controller, TICouncilorState councilor, CouncilorAugmentationOption option)
```

```csharp
public void UpdateListItem()
```

```csharp
public void OnAugmentButtonPressed()
```

```csharp
public void SetSelected(bool selected)
```
