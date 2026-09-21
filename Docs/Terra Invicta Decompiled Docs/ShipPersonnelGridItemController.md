# ShipPersonnelGridItemController

*Decompiled from `PavonisInteractive/TerraInvicta/ShipPersonnelGridItemController.cs`.*


## Class `ShipPersonnelGridItemController`

```csharp
internal class ShipPersonnelGridItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `icon` | public Image |
| `kiaIcon` | public Image |
| `tooltip` | public TooltipTrigger |

### Methods

```csharp
public void UpdateGridItem(TIOfficerState officer, bool dead = false)
```

```csharp
public void UpdateGridItem(CouncilorView councilorView)
```

```csharp
private string OfficerTip(TIOfficerState officer)
```

```csharp
private string CouncilorTip(CouncilorView councilorView)
```
