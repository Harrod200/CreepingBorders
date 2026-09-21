# HabCouncilorGridItemController

*Decompiled from `PavonisInteractive/TerraInvicta/HabCouncilorGridItemController.cs`.*


## Class `HabCouncilorGridItemController`

```csharp
public class HabCouncilorGridItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `heldCouncilor` | private TICouncilorState |
| `heldFaction` | private TIFactionState |
| `councilorIcon` | public Image |
| `councilorTooltip` | public TooltipTrigger |
| `councilorIconBackground` | public Image |

### Methods

```csharp
public void UpdateGridItem(TIFactionState viewingFaction, TICouncilorState councilor)
```

```csharp
public void UpdateGridItem(List<TIOfficerState> officers)
```

```csharp
public void onClickHabCouncilorGridItem()
```
