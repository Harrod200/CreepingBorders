# BallisticProjectileController

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/BallisticProjectileController.cs`.*


## Class `BallisticProjectileController`

```csharp
public class BallisticProjectileController : ProjectileController
```

### Fields

| Name | Type |
|---|---|
| `gunTemplate` | protected TIGunTypeWeaponTemplate |
| `maximumDistance` | private float |
| `velocityVector_Magnitude` | private float |
| `hit` | private RaycastHit |
| `ProjectileDamageSource` | public class ProjectileDamage : |

### Methods

```csharp
public override void Fire(Vector3 originPosition, Vector3 targetPosition, IDamageable target = null)
```

```csharp
public override void UpdateController()
```

```csharp
protected override void OnPause()
```

```csharp
protected override void OnUnpause()
```

```csharp
public ProjectileDamage(Vector3 inboundVelocityVector, Vector3 hitPosition, CombatWeaponCarrierState attacker, IDamageable target, TIGunTypeWeaponTemplate weaponTemplate, TIFactionState attackerFaction, float projectileMass_kg)
```
