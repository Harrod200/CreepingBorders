# FleetsInOrbitListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/FleetsInOrbitListItemController.cs`.*


## Class `FleetsInOrbitListItemController`

```csharp
public class FleetsInOrbitListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `fleet` | private TISpaceFleetState |
| `factionIcon` | public Image |
| `fleetName` | public TMP_Text |
| `smallShips` | public TMP_Text |
| `mediumShips` | public TMP_Text |
| `largeShips` | public TMP_Text |
| `orbitAltitude` | public TMP_Text |
| `DV_kps` | public TMP_Text |
| `operation` | public Image |
| `tip` | public TooltipTrigger |

### Methods

```csharp
public void UpdateListItem(TISpaceFleetState fleet, TINaturalSpaceObjectState viewedObject, bool victoryConditionTargetFleet)
```

```csharp
public void OnFleetButtonPressed()
```
