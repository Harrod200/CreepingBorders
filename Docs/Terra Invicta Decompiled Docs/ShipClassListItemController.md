# ShipClassListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/ShipClassListItemController.cs`.*


## Class `ShipClassListItemController`

```csharp
public class ShipClassListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `controller` | private FleetsScreenController |
| `className` | public TMP_Text |
| `hullName` | public TMP_Text |
| `shipDesign` | private TISpaceShipTemplate |
| `role` | public TMP_Text |
| `mass` | public TMP_Text |
| `acceleration` | public TMP_Text |
| `DV` | public TMP_Text |
| `buildCost` | public TMP_Text |
| `combatValue` | public TMP_Text |
| `assaultValue` | public TMP_Text |
| `numberInService` | public TMP_Text |
| `DeleteClassButton` | public Button |
| `buildButtonText` | public TMP_Text |
| `upgradeButtonText` | public TMP_Text |
| `obsoleteToggle` | public Toggle |
| `obsoleteIcon` | public Image |
| `obsolete_on` | public Sprite |
| `obsolete_off` | public Sprite |
| `nose` | public Image |
| `hull` | public Image |
| `tail` | public Image |
| `radiator` | public Image |
| `drive` | public Image |
| `altBackgroundObject` | public GameObject |

### Methods

```csharp
public void Init(FleetsScreenController controller, TISpaceShipTemplate shipDesign)
```

```csharp
public void UpdateListItem()
```

```csharp
public void OnDesignClicked()
```

```csharp
public void OnObsoleteDesignClicked()
```

```csharp
public void OnDeleteClassClicked()
```

```csharp
public void OnBuildClassClicked()
```
