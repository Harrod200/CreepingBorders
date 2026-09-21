# ShipsInFleetListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/ShipsInFleetListItemController.cs`.*


## Class `ShipsInFleetListItemController`

```csharp
public class ShipsInFleetListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `ship` | private TISpaceShipState |
| `shipName` | public TMP_Text |
| `shipClass` | public TMP_Text |
| `DV` | public TMP_Text |
| `propellantResources` | public TMP_Text |
| `acceleration` | public TMP_Text |
| `councilorGrid` | public ListManagerBase |
| `shipTip` | public TooltipTrigger |

### Methods

```csharp
public void SetListItem(TISpaceShipState shipState)
```

```csharp
public void UpdateDVData(TISpaceShipState shipState)
```

```csharp
public void OnShipsInFleetListItemClicked()
```
