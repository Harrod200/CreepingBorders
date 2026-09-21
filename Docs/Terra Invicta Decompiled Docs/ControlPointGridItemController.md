# ControlPointGridItemController

*Decompiled from `PavonisInteractive/TerraInvicta/ControlPointGridItemController.cs`.*


## Class `ControlPointGridItemController`

```csharp
public class ControlPointGridItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `controller` | private NationInfoController |
| `controlPoint` | private TIControlPoint |
| `armyPanel` | public GameObject |
| `armyCount` | public TMP_Text |
| `crackdownStatusPanel` | public Image |
| `defendStatusPanel` | public Image |
| `executiveStatusPanel` | public Image |
| `controlPointTooltip` | public TooltipTrigger |
| `controlPointImage` | public Image |
| `armyImage` | public Image |
| `CPButton` | public Button |
| `toHitText` | public TMP_Text |

### Methods

```csharp
public void SetGridItem(NationInfoController controller, TINationState nationState, TIControlPoint controlPoint, Image flagImage)
```

```csharp
private void SetControlPointButton()
```

```csharp
public void DisableControlPoint()
```

```csharp
public void OnControlPointButtonClicked()
```
