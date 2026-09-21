# FleetShipGridItemController

*Decompiled from `PavonisInteractive/TerraInvicta/FleetShipGridItemController.cs`.*


## Class `FleetShipGridItemController`

```csharp
public class FleetShipGridItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `nose` | public Image |
| `hull` | public Image |
| `tail` | public Image |
| `radiators` | public Image |
| `drive` | public Image |
| `theresMoreText` | public TMP_Text |
| `tooltip` | public TooltipTrigger |
| `shipState` | private TISpaceShipState |

### Methods

```csharp
public string BuildShipTooltip(TISpaceShipState ship)
```

```csharp
public void SetGridItem(TISpaceShipState ship, TISpaceFleetState fleet, bool enableTip = true)
```

```csharp
public void SetGridItem_Alt(TISpaceShipState ship, ParameterizedTextField.BuildStringOnTooltipHover del, bool enableTip = true)
```

```csharp
public void OnClickItem()
```
