# ArmyListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/ArmyListItemController.cs`.*


## Class `ArmyListItemController`

```csharp
public class ArmyListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `controller` | private NationInfoController |
| `army` | private TIArmyState |
| `armyControllingFaction` | public Image |
| `armyControllingFactionBackground` | public Image |
| `armyControllingFactionIcon` | public Image |
| `armyTooltip` | public TooltipTrigger |
| `armyName` | public TMP_Text |
| `armyDeploymentTypeImage` | public Image |
| `armyStrength` | public TMP_Text |
| `armyHomeRegion` | public TMP_Text |
| `armyCurrentRegion` | public TMP_Text |
| `armyTechLevel` | public TMP_Text |
| `armyStandingOrdersIcon` | public Image |
| `eventName` | private string |

### Methods

```csharp
public void ItemSelected()
```

```csharp
public string GetArmyTooltip(TIArmyState army, string strengthStr)
```

```csharp
public void Initialize(TIArmyState army, NationInfoController controller)
```

```csharp
private void OnEnable()
```

```csharp
public void UpdateListItem()
```

```csharp
private void OnArmyStatusUpdate(ArmyStatusUpdate e)
```

```csharp
public void RemoveListener()
```

```csharp
private void OnDisable()
```

```csharp
private void OnDestroy()
```
