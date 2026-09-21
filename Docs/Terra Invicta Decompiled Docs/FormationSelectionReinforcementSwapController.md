# FormationSelectionReinforcementSwapController

*Decompiled from `PavonisInteractive/TerraInvicta/FormationSelectionReinforcementSwapController.cs`.*


## Class `FormationSelectionReinforcementSwapController`

```csharp
internal class FormationSelectionReinforcementSwapController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `shipName` | public TMP_Text |
| `shipClass` | public TMP_Text |
| `button` | public Button |
| `shipTip` | public TooltipTrigger |
| `fleetIcon` | public FleetShipGridItemController |
| `buttonDefaultSprite` | private Sprite |
| `controller` | private SpaceCombatCanvasController |

### Properties

- `public TISpaceShipState ship`

### Methods

```csharp
public void SetListItem(TISpaceShipState ship, SpaceCombatCanvasController controller)
```

```csharp
public void SetButtonInteractable(bool setting)
```

```csharp
public void OnButtonPressed()
```

```csharp
public void HighlightButtonAfterSelection(bool highlighted)
```
