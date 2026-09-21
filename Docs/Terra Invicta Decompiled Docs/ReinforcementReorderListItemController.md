# ReinforcementReorderListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/ReinforcementReorderListItemController.cs`.*


## Class `ReinforcementReorderListItemController`

```csharp
public class ReinforcementReorderListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `shipName` | public TMP_Text |
| `shipClass` | public TMP_Text |
| `shipTip` | public TooltipTrigger |
| `fleetIcon` | public FleetShipGridItemController |
| `controller` | private SpaceCombatCanvasController |
| `Up1StepButton` | public Button |
| `UpAllStepsButton` | public Button |
| `Down1StepButton` | public Button |
| `DownAllStepsButton` | public Button |

### Properties

- `public TISpaceShipState ship`

### Methods

```csharp
public void SetListItem(TISpaceShipState ship, SpaceCombatCanvasController controller)
```

```csharp
public void SetReorderButtonsInteractable()
```

```csharp
public void OnPress_Up1StepButton()
```

```csharp
public void OnPress_UpAllStepsButton()
```

```csharp
public void OnPress_Down1StepButton()
```

```csharp
public void OnPress_DownAllStepsButton()
```
