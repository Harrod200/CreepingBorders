# ConstructionShipClassListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/ConstructionShipClassListItemController.cs`.*


## Class `ConstructionShipClassListItemController`

```csharp
public class ConstructionShipClassListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `controller` | private FleetsScreenController |
| `shipClassName` | public TMP_Text |
| `role` | public TMP_Text |
| `constructionCost` | public TMP_Text |
| `design` | private TISpaceShipTemplate |
| `defaultButtonSprite` | private Sprite |
| `idleButtonImage` | public Image |
| `button` | public Button |

### Methods

```csharp
public void Init(FleetsScreenController controller, TISpaceShipTemplate design)
```

```csharp
public void UpdateListItem()
```

```csharp
public void OnListItemClicked()
```

```csharp
public void HighlightButtonAfterSelection(TISpaceShipTemplate selectedDesign)
```

```csharp
public void DeSelectButton()
```
