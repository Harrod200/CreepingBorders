# OperationsArmyListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/OperationsArmyListItemController.cs`.*


## Class `OperationsArmyListItemController`

```csharp
public class OperationsArmyListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `army` | public TIArmyState |
| `armyControllingFaction` | public Image |
| `armyControllingFactionBackground` | public Image |
| `armyControllingFactionIcon` | public Image |
| `armyName` | public TMP_Text |
| `armyDeploymentTypeImage` | public Image |
| `armyStrength` | public TMP_Text |
| `armyHomeRegion` | public TMP_Text |
| `armyCurrentRegion` | public TMP_Text |
| `armyTechLevel` | public TMP_Text |
| `armyTravelTime` | public TMP_Text |
| `armyStandingOrdersIcon` | public Image |
| `selectArmyToggle` | public Toggle |
| `validDestinationImageColor` | public Image |
| `cachedArmyToggle` | private bool |

### Methods

```csharp
public void ItemSelected()
```

```csharp
public void Initialize(TIArmyState army)
```

```csharp
public void UpdateListItem(TIRegionState destination = null)
```

```csharp
public void OnUpdateArmyToggle()
```
