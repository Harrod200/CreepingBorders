# CombatantListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/UI/CombatantListItemController.cs`.*


## Class `CombatantListItemController`

```csharp
public abstract class CombatantListItemController : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
```

### Fields

| Name | Type |
|---|---|
| `masterController` | protected SpaceCombatCanvasController |
| `spaceCombat` | protected SpaceCombatManager |
| `shipName` | public TMP_Text |
| `className` | public TMP_Text |
| `noseImage` | public Image |
| `lateralImage` | public Image |
| `tailImage` | public Image |
| `driveImage` | public Image |
| `radiatorImage` | public Image |
| `noseArmorImage` | public Image |
| `portArmorImage` | public Image |
| `starboardArmorImage` | public Image |
| `tailArmorImage` | public Image |
| `button` | public Button |
| `frameImage` | public Image |
| `personnelIconGrid` | public ListManagerBase |
| `hitReportObject` | public GameObject |
| `rawDamageTxt` | public TMP_Text |
| `absorbedDamageTxt` | public TMP_Text |
| `penetratedDamageTxt` | public TMP_Text |
| `radiationDamageText` | public TMP_Text |
| `critText` | public TMP_Text |
| `highlightObject` | public GameObject |
| `radiationDamageImage` | public Image |
| `maneuverTargetImage` | public Image |
| `redDamageColor` | public Color |
| `normalDamageColor` | public Color |
| `shipSummaryTip` | public TooltipTrigger |
| `rawDamageTip` | public TooltipTrigger |
| `absorbedDamageTip` | public TooltipTrigger |
| `penetratedDamageTip` | public TooltipTrigger |
| `radiationDamageTip` | public TooltipTrigger |
| `maneuverTargetTip` | public TooltipTrigger |
| `_clickCount` | private float |
| `_lastClickTime` | private float |
| `_doubleClickWindow` | private float |
| `_shipTooltipMinWidth` | private int |
| `shipState` | protected TISpaceShipState |
| `habModuleState` | protected TIHabModuleState |
| `delay8` | private static WaitForSeconds |

### Properties

- `public int position`
- `public CombatantController combatantController`
- `public IDamageableType combatantType`

### Methods

```csharp
public virtual void Init(SpaceCombatCanvasController masterController, CombatantController combatantController, int position)
```

```csharp
public void UpdateListItem()
```

```csharp
public void OnArmorHit(ShipArmorFacingStruckInCombat e)
```

```csharp
public virtual void OnArmorHit(ArmorFacing facing, float rawDamage, float penetratedDamage, float radiationDamage)
```

```csharp
private IEnumerator FlashArmorFacing(Image facing, Color color)
```

```csharp
private IEnumerator ShowHitData(float rawDamage, float penetratedDamage, float radiationDamage)
```

```csharp
public virtual void OnHabModuleHit(HabModuleDamagedInCombat e)
```

```csharp
private void SetRadiatorImageOn(CompleteExtendRadiatorsEvent e)
```

```csharp
private static void SetRadiatorImageOn(TISpaceShipState shipState, Image radiatorImage)
```

```csharp
private void SetRadiatorImageOff(CompleteRetractRadiatorsEvent e)
```

```csharp
private static void SetRadiatorImageOff(TISpaceShipState shipState, Image radiatorImage)
```

```csharp
private void OnShipPartDamageChange(ShipPartDamageChange e)
```

```csharp
public static void SetRadiatorImage(TISpaceShipTemplate template, Image radiatorImage)
```

```csharp
public static void SetRadiatorImage(TISpaceShipState shipState, Image radiatorImage)
```

```csharp
public static void SetDriveImage(TISpaceShipTemplate template, Image driveImage)
```

```csharp
public static void SetDriveImage(TISpaceShipState shipState, Image driveImage)
```

```csharp
public static void SetHabImage(TIHabState habState, Image habImage)
```

```csharp
private void OnShipSystemDamageChange(ShipSystemDamageChange e)
```

```csharp
public static void SetNoseImage(TISpaceShipTemplate template, Image noseImage)
```

```csharp
public static void SetNoseImage(TISpaceShipState shipState, Image noseImage)
```

```csharp
public static void SetMidImage(TISpaceShipTemplate template, Image lateralImage)
```

```csharp
public static void SetMidImage(CombatHabModuleController controller, Image lateralImage)
```

```csharp
public static void SetMidImage(TISpaceShipState shipState, Image lateralImage)
```

```csharp
public static void SetTailImage(TISpaceShipTemplate template, Image tailImage)
```

```csharp
public static void SetTailImage(TISpaceShipState shipState, Image tailImage)
```

```csharp
public void OnShipOfficerKilled(ShipOfficerKilled e)
```

```csharp
public void UpdatePersonnelList()
```

```csharp
protected virtual void UpdateShipListItem()
```

```csharp
protected virtual void UpdateHabModuleListItem()
```

```csharp
private static string CombatModuleUIPath(TIHabModuleState habModule)
```

```csharp
public static string BuildRawDamageTooltip()
```

```csharp
public static string BuildAbsorbedDamageTooltip()
```

```csharp
public static string BuildPenetratedDamageTooltip()
```

```csharp
public static string BuildRadiationDamageTooltip()
```

```csharp
public void OnManeuverTargetSelected()
```

```csharp
public void ClearManeuverTarget()
```

```csharp
public void OnPointerClick(PointerEventData e)
```

```csharp
public virtual void OnDoubleClick()
```

```csharp
public void OnPointerEnter(PointerEventData e)
```

```csharp
public void OnPointerExit(PointerEventData e)
```

```csharp
private void RemoveListeners()
```

```csharp
public virtual void OnDisable()
```

```csharp
public virtual void OnDestroy()
```
