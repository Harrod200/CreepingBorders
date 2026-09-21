# AlliesGridItemController

*Decompiled from `PavonisInteractive/TerraInvicta/AlliesGridItemController.cs`.*


## Class `AlliesGridItemController`

```csharp
public class AlliesGridItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `allyFlag` | public Image |
| `federationFlag` | public Image |
| `federationFlagBorder` | public Image |
| `allyTrigger` | public TooltipTrigger |
| `nation` | public TINationState |
| `armyImage` | public Image |
| `nukesImage` | public Image |

### Methods

```csharp
public void ItemSelected()
```

```csharp
public void UpdateGridItem(TINationState viewedNation, TINationState allyNationState)
```

```csharp
public string AllyTooltip(TINationState nation, TINationState ally)
```
