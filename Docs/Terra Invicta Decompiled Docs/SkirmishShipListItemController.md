# SkirmishShipListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/SkirmishShipListItemController.cs`.*


## Class `SkirmishShipListItemController`

```csharp
public class SkirmishShipListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `isAddShipButton` | private bool |
| `shipTemplate` | private TISpaceShipTemplate |
| `skirmishMenu` | public SkirmishMenuController |
| `importString` | private static string |
| `shipDropdown` | public TMP_Dropdown |
| `masterController` | private StartMenuController |
| `fleetTemplate` | private TISpaceFleetTemplate |
| `shipIndex` | private int |
| `fleetIdx` | private int |
| `noseImage` | public Image |
| `lateralImage` | public Image |
| `tailImage` | public Image |
| `driveImage` | public Image |
| `radiatorImage` | public Image |
| `shipSummaryTip` | public TooltipTrigger |
| `dropdownItems` | private SkirmishAddShipDropdownItem[] |
| `selectImportedDesign` | private bool |
| `previousShipDropdownValue` | private int |
| `suppressMasterNotify` | private static bool |
| `factions` | private static Dictionary<string, TIFactionState> |

### Methods

```csharp
public void Initialize(StartMenuController masterController, TISpaceFleetTemplate fleetTemplate, int idx, int fleetIdx)
```

```csharp
private void SetShipDamageImages()
```

```csharp
public void PopulateShipDropdown()
```

```csharp
public void OnShipDropdownChanged()
```

```csharp
public static void InsertImportedDesigns(Dictionary<string, TISpaceShipTemplate> shipDictionary, List<TISpaceShipTemplate> ships)
```

```csharp
private void SetTooltipDelegate()
```

```csharp
public void SetAddShipButtonDropdownTooltipDelegates()
```

```csharp
public void OnTrashSelected()
```

```csharp
public void AddShipSelected()
```

```csharp
public void AddSpecificShip(TISpaceFleetTemplate.ShipFleetDefinition NewShip)
```

```csharp
public void DuplicateShip()
```
