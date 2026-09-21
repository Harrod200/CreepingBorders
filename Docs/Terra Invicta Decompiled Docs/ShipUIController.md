# ShipUIController

*Decompiled from `PavonisInteractive/TerraInvicta/ShipUIController.cs`.*


## Class `ShipUIController`

```csharp
public class ShipUIController : SpaceCombatAssetUIController
```

### Fields

| Name | Type |
|---|---|
| `ship` | public TISpaceShipState |
| `combatShipController` | private CombatShipController |
| `mouseCollider` | public CapsuleCollider |
| `shipVisController` | private ShipVisController |
| `modelController` | private ShipModelController |
| `UIcanvas` | public Canvas |
| `canvasScaler` | public CanvasScaler |
| `groupNumber` | public TMP_Text |
| `shipName` | public TMP_Text |
| `shipClass` | public TMP_Text |
| `shipImagePanel` | public GameObject |
| `noseImage` | public Image |
| `lateralImage` | public Image |
| `tailImage` | public Image |
| `driveImage` | public Image |
| `radiatorImage` | public Image |
| `weaponRangeSphere` | public GameObject |
| `weaponRangeCone` | public GameObject |
| `sphere_Material` | public Material |
| `cone_Material` | public Material |
| `activePlayerShip` | private bool |
| `mainCamera` | private Camera |
| `shipNameYOffset` | private float |
| `shipClassYOffset` | private float |
| `shipImageYOffset` | private float |
| `formationModeShipNameYOffset` | private float |
| `formationModeClassNameYOffset` | private float |
| `shipGroupXOffset` | private const float |
| `shipGroupYOffset` | private const float |
| `_selectingAltWaypoint` | private bool |
| `_doubleClickCount` | private int |
| `_lastClickTime` | private float |
| `_doubleClickWindow` | private float |

### Methods

```csharp
public void Initialize(ShipVisController shipVisController)
```

```csharp
public override void InitializeForCombat(CombatantController combatShipController, CombatantListItemController listItemController)
```

```csharp
public void DisableWeaponRangeVisualizations()
```

```csharp
public bool IsShipDestroyed()
```

```csharp
public void SetShipDamageImages()
```

```csharp
private void ShipDamaged(ShipSystemDamageChange e)
```

```csharp
private void ShipDamaged(ShipPartDamageChange e)
```

```csharp
private void RemoveCombatListeners(CombatEnds e)
```

```csharp
private void OnUIScaleChanged(UIScaleSettingChange e)
```

```csharp
private void UpdateUIScale()
```

```csharp
public void TurnOffRangeVisuals()
```

```csharp
public void OnShipGroupChange(CombatShipGroupChange e)
```

```csharp
public void OnShipGroupChange()
```

```csharp
private void OnMouseEnter()
```

```csharp
private void OnMouseExit()
```

```csharp
private void OnMouseDown()
```

```csharp
private void OnMouseUpAsButton()
```

```csharp
private void RemoveListeners()
```

```csharp
private void OnDisable()
```

```csharp
private void OnDestroy()
```

```csharp
private void LateUpdate()
```
