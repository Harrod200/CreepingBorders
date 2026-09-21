# FriendlyShipListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/UI/FriendlyShipListItemController.cs`.*


## Class `FriendlyShipListItemController`

```csharp
public class FriendlyShipListItemController : CombatantListItemController
```

### Fields

| Name | Type |
|---|---|
| `targetingImage` | public Image |
| `heatImage` | public Image |
| `coolingImage` | public Image |
| `AIControlIcon` | public Image |
| `DVStaticImage` | public Image |
| `warningIcon_None` | public Image |
| `warningIcon_Warn` | public Image |
| `warningIcon_Alert` | public Image |
| `rotationStatus_Icon` | public Image |
| `systemStatus_Icon` | public Image |
| `weaponStatus_Icon` | public Image |
| `damConStatus_Icon` | public Image |
| `damConDisabled_Icon` | public Image |
| `selectedHighlight` | public Image |
| `defaultFrameImage` | public Sprite |
| `groupSelectedFrameImage` | public Sprite |
| `warningNoAmmoTooltip` | public TooltipTrigger |
| `warningWarnTooltip` | public TooltipTrigger |
| `warningAlertTooltip` | public TooltipTrigger |
| `rotationStatusTooltip` | public TooltipTrigger |
| `systemStatusTooltip` | public TooltipTrigger |
| `weaponStatusTooltip` | public TooltipTrigger |
| `targetingTooltip` | public TooltipTrigger |
| `damConTooltip` | public TooltipTrigger |
| `heatTooltip` | public TooltipTrigger |
| `deltaVValue` | public TMP_Text |
| `maneuverList` | public ListManagerBase |
| `ySize` | public const float |
| `batteryWarningIcon` | public Image |
| `noseWeaponComponents` | private IWeapon[] |
| `hullWeaponComponents` | private IWeapon[] |
| `groupMembershipString` | public TMP_Text |
| `alertWeaponNoAmmo` | private bool |
| `alertWeaponNoTarget` | private bool |
| `alertShipNoThrust` | private bool |
| `alertShipAvoiding` | private bool |
| `alertShipDisengaging` | private bool |
| `batteryColorDestroyed` | private Color32 |
| `batteryColorRed` | private Color32 |
| `batteryColorYellow` | private Color32 |
| `damConYellow` | private Color32 |
| `damConRed` | private Color32 |

### Methods

```csharp
public override void Init(SpaceCombatCanvasController masterController, CombatantController combatantController, int position)
```

```csharp
private void UpdateWeaponNoTargetAlert()
```

```csharp
private void UpdateWeaponOperationalStatus()
```

```csharp
private void UpdateCriticalShipSystemsStatus()
```

```csharp
private void UpdateDamConStatus(bool rotationDisabled = false)
```

```csharp
private void UpdateShipThrustStatus()
```

```csharp
private void UpdateShipRotationStatus()
```

```csharp
private void UpdateHeatStatus()
```

```csharp
private void UpdateAlerts()
```

```csharp
public void OnShipSystemDamaged(ShipSystemDamageChange e)
```

```csharp
private void OnShipPartDamaged(ShipPartDamageChange e)
```

```csharp
public void OnShipWeaponModeChanged(ShipWeaponModeChanged e)
```

```csharp
public void OnShipDisengageChange(ShipDisengageChange e)
```

```csharp
public void OnShipPrimaryTargetDestroyed(ShipPrimaryTargetDestroyed e)
```

```csharp
public void OnShipWeaponFired(ShipWeaponFired e)
```

```csharp
public void OnShipDamageControlRotationStatusChanged(ShipDamageControlRotationStatusChanged e)
```

```csharp
public void OnClickListItem()
```

```csharp
public override void OnDoubleClick()
```

```csharp
private void OnHeatChange(ShipHeatChange e)
```

```csharp
public void OnAIControlChanged(ShipAIControlChange e)
```

```csharp
public void SetAIControl(bool AIControlled)
```

```csharp
public void OnShipDeltaVChange(ShipDeltaVChange e)
```

```csharp
public void SetDeltaVValue()
```

```csharp
public void OnShipPowerStorageChange(ShipPowerSystemsChargeChange e)
```

```csharp
public void UpdatePowerSystemStatus()
```

```csharp
private void OnShipCommandExecuted(ShipCommandExecuted e)
```

```csharp
private void OnCombatManenuverCompleted(CombatManeuverComplete e)
```

```csharp
private void OnCollisionAvoidanceActivated(CombatCollisionAvoidanceStatusChange e)
```

```csharp
public void SetGroupSelected(bool value)
```

```csharp
private void SetGroupMembershipString()
```

```csharp
private void OnUpdateGroupMembershipString(CombatShipGroupChange e)
```

```csharp
public void SetPrimarySelected(bool value)
```

```csharp
private void RemoveListeners()
```

```csharp
public override void OnDisable()
```

```csharp
public override void OnDestroy()
```
