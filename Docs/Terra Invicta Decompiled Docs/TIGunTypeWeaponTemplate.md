# TIGunTypeWeaponTemplate

*Decompiled from `TIGunTypeWeaponTemplate.cs`.*


## Class `TIGunTypeWeaponTemplate`

```csharp
public abstract class TIGunTypeWeaponTemplate : TIProjectileWeaponTemplate
```

### Fields

| Name | Type |
|---|---|
| `canBombardThroughAtmosphere` | public override bool |
| `ref_gunWeapon` | public override TIGunTypeWeaponTemplate |
| `isGunTypeWeapon` | public override bool |
| `EstimatedImpactVelocity_kps` | public override float |
| `muzzleVelocity_kps` | public float |
| `_shipVelocityFor1Damage_kps` | private float |

### Methods

```csharp
public override float BaseDamageAtRange_MJ(float range_km, bool applyChipping = true)
```

```csharp
public float MinVelocityFor1Damage_kps()
```

```csharp
public override float DamageAtRange_MJ(float range_km, float targetCrossSection_m, CombatWeaponCarrierState attacker = null, float finalVelocity_kps = 0f, float warheadMass_kg = 0f, bool applyChipping = true)
```

```csharp
public override string SpecificDescriptionData()
```

```csharp
public string GetLocalizedMuzzleVelocity()
```

```csharp
public override float GetSurfaceImpactVelocity_kps(TISpaceBodyState spaceBody, float altitude_km)
```

```csharp
public override float EffectiveRangeAgainstProjectiles_km()
```
