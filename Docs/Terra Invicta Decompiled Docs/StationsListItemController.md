# StationsListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/StationsListItemController.cs`.*


## Class `StationsListItemController`

```csharp
public class StationsListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `station` | private TIHabState |
| `habName` | public TMP_Text |
| `CPImage` | public Image[] |
| `orbitAltitude` | public TMP_Text |
| `tip` | public TooltipTrigger |
| `controller` | private SpaceObjectDetailController |

### Methods

```csharp
public void UpdateListItem(TIHabState hab, TINaturalSpaceObjectState selectedObject, bool victoryAsset, SpaceObjectDetailController controller)
```

```csharp
public void OnStationButtonClicked()
```

```csharp
public void OnStationIconButtonClicked()
```
