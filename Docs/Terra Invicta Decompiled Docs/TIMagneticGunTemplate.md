# TIMagneticGunTemplate

*Decompiled from `TIMagneticGunTemplate.cs`.*


## Class `TIMagneticGunTemplate`

```csharp
public class TIMagneticGunTemplate : TIGunTypeWeaponTemplate
```

### Fields

| Name | Type |
|---|---|
| `weaponClass` | public override WeaponClass |
| `canBombardThroughAtmosphere` | public override bool |
| `isMagneticGunWeapon` | public override bool |
| `minDamageForPDToFire` | public override float |

### Methods

```csharp
public override float EnergyUsage_GJ(float extraInput_MW = 0f)
```

```csharp
protected override float KineticEnergyDamage_MJ(float finalVelocity_kps, float warheadMass_kg)
```

```csharp
public override float HeatGeneration_GJ(float extraInput_MJ = 0f)
```

```csharp
public override float DamageAtRange_MJ(float range_km, float targetCrossSection_m, CombatWeaponCarrierState attacker = null, float finalVelocity_kps = 0f, float warheadMass_kg = 0f, bool applyChipping = true)
```

```csharp
public override DamageType GetDamageType()
```
