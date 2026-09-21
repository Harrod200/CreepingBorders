# RefitClassListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/RefitClassListItemController.cs`.*


## Class `RefitClassListItemController`

```csharp
public class RefitClassListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `controller` | private FleetsScreenController |
| `shipName` | public TMP_Text |
| `shipClassName` | public TMP_Text |
| `role` | public TMP_Text |
| `constructionCost` | public TMP_Text |
| `design` | private TISpaceShipTemplate |
| `oldDesign` | private TISpaceShipTemplate |
| `defaultButtonSprite` | private Sprite |
| `idleButtonImage` | public Image |
| `button` | public Button |
| `shipToRefit` | public TISpaceShipState |

### Methods

```csharp
public void Init(FleetsScreenController controller, TISpaceShipTemplate design, TISpaceShipTemplate newDesign, TISpaceShipState shipToRefit)
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
