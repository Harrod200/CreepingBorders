# WarGridItemController

*Decompiled from `PavonisInteractive/TerraInvicta/WarGridItemController.cs`.*


## Class `WarGridItemController`

```csharp
public class WarGridItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `warFlag` | public Image |
| `warGridTrigger` | public TooltipTrigger |
| `nation` | public TINationState |
| `armyImage` | public Image |
| `nukesImage` | public Image |

### Methods

```csharp
public void ItemSelected()
```

```csharp
public void UpdateGridItem(TINationState viewNation, TINationState warNationState)
```

```csharp
private string WarTooltip(TINationState viewNation, TINationState warEnemy)
```
