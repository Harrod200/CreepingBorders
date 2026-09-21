# RivalsGridItemController

*Decompiled from `PavonisInteractive/TerraInvicta/RivalsGridItemController.cs`.*


## Class `RivalsGridItemController`

```csharp
public class RivalsGridItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `rivalFlag` | public Image |
| `federationFlag` | public Image |
| `federationFlagBorder` | public Image |
| `rivalTTTrigger` | public TooltipTrigger |
| `nation` | public TINationState |
| `armyImage` | public Image |
| `nukesImage` | public Image |

### Methods

```csharp
public void ItemSelected()
```

```csharp
public void UpdateGridItem(TINationState viewedNation, TINationState rivalNationState)
```

```csharp
public string RivalTooltip(TINationState nation, TINationState rival)
```
