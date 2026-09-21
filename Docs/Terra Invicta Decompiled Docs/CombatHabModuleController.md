# CombatHabModuleController

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/CombatHabModuleController.cs`.*


## Class `CombatHabModuleController`

```csharp
public class CombatHabModuleController : CombatantController, IDamageable
```

### Fields

| Name | Type |
|---|---|
| `ref_habModuleController` | public override CombatHabModuleController |
| `combatTargetableState` | public override CombatTargetableState |
| `velocityVector_kps` | public override Vector3 |
| `damageableType` | public override IDamageableType |
| `accelerationVector` | public override Vector3 |
| `accelerationVector_kps` | public override Vector3 |
| `velocityVector` | public override Vector3 |
| `set` | protected |
| `hitColliders` | public override List<Collider> |
| `set` | protected |
| `habModuleController` | private HabModuleController |
| `habModelController` | private HabModelController |
| `hitPoints` | public float |
| `armor` | public float |
| `genericColliders` | private List<Collider> |
| `delay` | private readonly WaitForSeconds |

### Properties

- `public TIHabModuleState habModule`
- `public float baseHitPoints`
- `public TIShipArmorTemplate armorTemplate`
- `public List<SphereCollider> combatHitColliders`
- `public List<ModuleDataEntry> weaponDataEntries`
- `public List<IWeapon> weapons`
- `public List<ShipWeaponVisController> dorsalWeaponControllers`
- `public List<ShipWeaponVisController> ventralWeaponControllers`

### Methods

```csharp
public override IDamageableType GetCombatantType()
```

```csharp
public override SpaceCombatAssetUIController UIController()
```

```csharp
public override CombatTargetableState GetCombatantState()
```

```csharp
public override Vector3 positionAtTime(DateTime currentTime)
```

```csharp
public override float GetCrossSectionalArea_m2(float angle = -3.4028235E+38f)
```

```csharp
public void InitializeForCombat(TIHabModuleState habModule, HabModuleController habModuleController)
```

```csharp
public void DestroyHabModule(TIFactionState destroyer)
```

```csharp
private IEnumerator DestroyModuleDelayed(TIFactionState destroyer, TIHabModuleState state)
```

```csharp
public override float ApplyDamage(DamageSource source)
```

```csharp
public static float ApplyDamage(TIHabModuleTemplate moduleTemplate, DamageSource source, TIShipArmorTemplate armorTemplate, float baseHitPoints, float irradiatedMultiplier, ref float armor, ref float hitPoints, out float absorbedDamage, IEnumerable<IWeapon> weapons = null)
```

```csharp
public void UpdateHab()
```

```csharp
public float GetHabModuleEffectiveScaledCombatRange()
```

```csharp
protected void UpdateIsMissileSaturated()
```

```csharp
private float EstimateShipKillDamageThreshold()
```

```csharp
public int EstimatedMaxProjectilesPointDefenseCanHandle()
```

```csharp
public float EstimatedIncomingMissileDamage(List<MissileController> incomingMissiles)
```

```csharp
private List<MissileController> GetAllMissilesTargetingMe()
```
