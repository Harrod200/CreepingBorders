# ShipConstructionQueueListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/ShipConstructionQueueListItemController.cs`.*


## Class `ShipConstructionQueueListItemController`

```csharp
public class ShipConstructionQueueListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `gridController` | private ShipyardGridItemController |
| `earthImage` | public Image |
| `className` | public TMP_Text |
| `item` | private ShipConstructionQueueItem |
| `idleButtonImage` | public Image |
| `defaultButtonSprite` | private Sprite |
| `button` | public Button |

### Methods

```csharp
public void Init(ShipyardGridItemController gridController, Sprite defaultSprite)
```

```csharp
public void UpdateListItem(ShipConstructionQueueItem item, int position)
```

```csharp
public void OnClickLine()
```

```csharp
public void HighlightButtonAfterSelection(ShipConstructionQueueItem selectedItem)
```
