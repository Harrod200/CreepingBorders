# DockedShipListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/DockedShipListItemController.cs`.*


## Class `DockedShipListItemController`

```csharp
public class DockedShipListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `controller` | private FleetsScreenController |
| `shipName` | public TMP_Text |
| `shipClassName` | public TMP_Text |
| `role` | public TMP_Text |
| `location` | public TMP_Text |
| `design` | private TISpaceShipTemplate |
| `shipState` | public TISpaceShipState |
| `defaultButtonSprite` | public Sprite |
| `shipDisplayName` | private string |
| `idleButtonImage` | public Image |
| `button` | public Button |

### Methods

```csharp
public void Init(FleetsScreenController controller, TISpaceShipTemplate design, TISpaceShipState shipState, string shipDisplayName)
```

```csharp
public void UpdateListItem()
```

```csharp
public void OnListItemClicked()
```

```csharp
public void HighlightButtonAfterSelection(TISpaceShipState shipToRefit)
```

```csharp
public void HighlightButtonAfterSelection(List<TISpaceShipState> multiSelectedShips)
```

```csharp
public void DeSelectButton()
```
