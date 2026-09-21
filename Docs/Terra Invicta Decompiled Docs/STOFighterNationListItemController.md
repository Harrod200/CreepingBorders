# STOFighterNationListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/STOFighterNationListItemController.cs`.*


## Class `STOFighterNationListItemController`

```csharp
public class STOFighterNationListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `controller` | private PrecombatController |
| `flag` | public Image |
| `nationName` | public TMP_Text |
| `numFighters` | public TMP_Text |
| `boostCost` | public TMP_Text |
| `missileDropdown` | public TMP_Dropdown |
| `missileDropdownScrollrect` | public ScrollRect |
| `copyLoadoutButton` | public Image |
| `copyLoadoutButtonTip` | public TooltipTrigger |
| `fighterReadoutTip` | public TooltipTrigger |
| `missileTip` | public TooltipTrigger |
| `plusButton` | public Button |
| `minusButton` | public Button |
| `missileList` | private Dictionary<int, TIShipWeaponTemplate> |
| `currentDesign` | private TISpaceShipTemplate |

### Properties

- `public TINationState nation`

### Methods

```csharp
public void SetListItem(TINationState nation, PrecombatController controller, List<TIShipWeaponTemplate> allowedMissiles)
```

```csharp
public void SetWeapon(TIShipWeaponTemplate missile)
```

```csharp
public void SetNumberFighters(int value)
```

```csharp
public void SetButtons()
```

```csharp
public void OnMissileDropdownChanged()
```

```csharp
public void OnHitPlus()
```

```csharp
public void OnHitMinus()
```

```csharp
public void OnHitApplyMissileToAll()
```

```csharp
public void ExternalMissileChange(TIShipWeaponTemplate newMissile)
```

```csharp
public void ExternalFighterCountChange(int newCount)
```
