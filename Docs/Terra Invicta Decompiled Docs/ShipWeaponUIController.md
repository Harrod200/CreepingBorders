# ShipWeaponUIController

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/UI/ShipWeaponUIController.cs`.*


## Class `ShipWeaponUIController`

```csharp
public class ShipWeaponUIController : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
```

### Fields

| Name | Type |
|---|---|
| `weaponTemplate` | private TIShipWeaponTemplate |
| `primaryFrame` | public Image |
| `weaponIcon` | public Image |
| `weaponStatusIcon` | public Image |
| `ammoIcon` | public Image |
| `weaponName` | public TMP_Text |
| `ammo` | public TMP_Text |
| `weaponModeText` | public TMP_Text |
| `tooltip` | public TooltipTrigger |
| `button` | public Button |
| `energyUsagePanel` | public GameObject |
| `ammoPanel` | public GameObject |
| `weapon` | private Weapon |
| `ship` | private TISpaceShipState |
| `controller` | private SpaceCombatCanvasController |
| `shipUIController` | private ShipUIController |
| `cShipController` | private CombatShipController |
| `reticlesToHide` | private List<ShipUIController> |
| `_addedCombatSecondListener` | private bool |
| `_weaponWasDamaged` | private bool |
| `_showingBollixed` | private bool |
| `lastStatusUpdate` | private float |
| `ChangeWeaponClickMode` | public enum |

### Methods

```csharp
public void Initialize(Weapon weapon, SpaceCombatCanvasController controller)
```

```csharp
public void UpdateGridItem()
```

```csharp
public void UpdateAmmoText()
```

```csharp
public void UpdateStatus(CombatSecond e)
```

```csharp
public void UpdateStatus()
```

```csharp
public void UpdateFireMode()
```

```csharp
private string UpdateTooltip()
```

```csharp
public void SetGridItem()
```

```csharp
private ShipWeaponUIController.ChangeWeaponClickMode CheckKeysDownForBatchChange(out SpaceCombatCanvasController.ChangeCommandScopeMode mode)
```

```csharp
private void ChangeFireMode(IFireMode newFireMode)
```

```csharp
public void OnButtonPressed()
```

```csharp
public void OnRightButtonPressed()
```

```csharp
public void OnPointerEnter(PointerEventData eventData)
```

```csharp
public void OnPointerExit(PointerEventData eventData)
```

```csharp
private void OnDestroy()
```
