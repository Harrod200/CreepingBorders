# TIParticleWeaponTemplate

*Decompiled from `TIParticleWeaponTemplate.cs`.*


## Class `TIParticleWeaponTemplate`

```csharp
public class TIParticleWeaponTemplate : TIBeamWeaponTemplate
```

### Fields

| Name | Type |
|---|---|
| `weaponClass` | public override WeaponClass |
| `canBombardThroughAtmosphere` | public override bool |
| `ref_particleWeapon` | public override TIParticleWeaponTemplate |
| `isParticleWeapon` | public override bool |
| `dispersionModel` | public ParticleBeamDispersionModel |
| `doublingRange_km` | public float |
| `emittance_mrad` | public float |
| `lensRadius_cm` | public float |
| `heatFraction` | public float |
| `xRayFraction` | public float |
| `baryonFraction` | public float |
| `BARYONIC_DAMAGE_MULTIPLIER` | public const float |

### Methods

```csharp
public override float DamageAtRange_MJ(float range_km, float targetCrossSectionArea_m2, CombatWeaponCarrierState attacker, float finalVelocity_kps = 0f, float warheadMass_kg = 0f, bool applyChipping = true)
```

```csharp
public float SpotSurfaceArea_m2(float range_km)
```

```csharp
public override float BaseDamageAtRange_MJ(float range_km, bool applyChipping = true)
```

```csharp
public override float RangeToDoDamage_km(float desiredDamage_Points, TISpaceShipState ship)
```

```csharp
public override float chipping(float range_km = 0f)
```

```csharp
public override string SpecificDescriptionData()
```

```csharp
public string GetLocalizedDamageBreakdown()
```

```csharp
public override string GetLocalizedPowerAndDamageAtRange(float range)
```

```csharp
public override DamageType GetDamageType()
```

```csharp
public override bool CanOnlyDefensivelyTargetMissiles()
```
