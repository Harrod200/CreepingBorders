# SellResourceListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/SellResourceListItemController.cs`.*


## Class `SellResourceListItemController`

```csharp
public class SellResourceListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `controller` | private GeneralControlsController |
| `resourceName` | public TMP_Text |
| `resourceIcon` | public Image |
| `numberToSellInput` | public TMP_InputField |
| `numberToSellText` | public TMP_Text |
| `totalSaleValueText` | public TMP_Text |
| `perUnitSaleValueText` | public TMP_Text |
| `increaseButton` | public Button |
| `decreaseButton` | public Button |

### Properties

- `public FactionResource resource`

### Methods

```csharp
public void Initialize(GeneralControlsController controller, FactionResource resource)
```

```csharp
public void UpdateListItem(int numberToSell)
```

```csharp
public void OnMinusButtonSelected()
```

```csharp
public void OnPlusButtonSelected()
```

```csharp
public void OnAmountChanged()
```
