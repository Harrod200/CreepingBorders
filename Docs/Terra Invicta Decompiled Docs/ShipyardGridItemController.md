# ShipyardGridItemController

*Decompiled from `PavonisInteractive/TerraInvicta/ShipyardGridItemController.cs`.*


## Class `ShipyardGridItemController`

```csharp
public class ShipyardGridItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `allowPayFromEarth` | public bool |
| `refitting` | private bool |
| `selectedQueueItem` | public ShipConstructionQueueItem |
| `selectedItemIndex` | public int |
| `CanMoveDownInQueue` | public bool |
| `CanMoveUpInQueue` | public bool |
| `CanRemoveFromQueue` | public bool |
| `controller` | public FleetsScreenController |
| `habName` | public TMP_Text |
| `habLocation` | public TMP_Text |
| `shipyardDetails` | public TMP_Text |
| `shipyardTier` | public Image |
| `currentConstructionTitle` | public TMP_Text |
| `constructionQueueTitle` | public TMP_Text |
| `currentConstruction` | public TMP_Text |
| `moduleImage` | public Image |
| `shipyardIdx` | public TIHabModuleState |
| `backgroundFactionGradient` | public Image |
| `AddToQueueButtonText` | public TMP_Text |
| `ClearQueueButtonText` | public TMP_Text |
| `queueList` | public ListManagerBase |
| `shipQueueScrollRect` | public ScrollRect |
| `AddShipButton` | public Button |
| `RemoveShipButton` | public Button |
| `ClearQueueButton` | public Button |
| `MoveUpinQueueButton` | public Button |
| `MoveDownInQueueButton` | public Button |
| `allowPayFromEarthToggle` | public Toggle |
| `payFromEarthTooltip` | public TooltipTrigger |
| `gravity_gs` | public TMP_Text |
| `gravityTip` | public TooltipTrigger |
| `defaultButtonSprite` | private Sprite |

### Methods

```csharp
public void Init(FleetsScreenController controller, TIHabModuleState shipyardIdx)
```

```csharp
public void UpdateGridItem()
```

```csharp
public void UpdateShipyardTierPips()
```

```csharp
private string GravityText(string str)
```

```csharp
public void UpdateGravityIcon()
```

```csharp
public void UpdateConstructionQueue()
```

```csharp
private void SetAddClearShipButtons()
```

```csharp
public void SetButtons()
```

```csharp
public void SetSelectedQueueItem(ShipConstructionQueueItem item)
```

```csharp
public bool CanAddShip()
```

```csharp
public void OnAddToQueueButtonClicked()
```

```csharp
public void OnNewClassSelectedInFleetController()
```

```csharp
public void OnNewConstructionQueueItemSelected()
```

```csharp
public void ToggleUseEarthResources()
```

```csharp
public void OnClearQueueButtonClicked()
```

```csharp
public void OnHabModuleClicked()
```

```csharp
public void OnMoveUpInQueueClicked()
```

```csharp
public void OnMoveDowninQueueClicked()
```

```csharp
public void OnRemoveFromQueueClicked()
```

```csharp
private IEnumerator SetQueueScrollRect(bool enable)
```
