# TIMissileTemplate

*Decompiled from `TIMissileTemplate.cs`.*


## Class `TIMissileTemplate`

```csharp
public class TIMissileTemplate : TIProjectileWeaponTemplate
```

### Fields

| Name | Type |
|---|---|
| `ref_missileWeapon` | public override TIMissileTemplate |
| `weaponClass` | public override WeaponClass |
| `isMissileWeapon` | public override bool |
| `staticLauncher` | public override bool |
| `canBombardThroughAtmosphere` | public override bool |
| `ammoIconPath` | public override string |
| `acceleration_mps2` | public float |
| `AOEWeapon` | public bool |
| `EstimatedImpactVelocity_kps` | public override float |
| `selfPowered` | public override bool |
| `acceleration_g` | public float |
| `deltaV_kps` | public float |
| `rotation_degps` | public float |
| `thrustRamp_s` | public float |
| `turnRamp_s` | public float |
| `maneuver_angle` | public float |
| `warheadClass` | public WarheadClass |
| `shapedChargeAngle` | public float |
| `shapedChargeEfficiency` | public const float |

### Methods

```csharp
protected override List<FireMode> GetAllowedFireModes()
```

```csharp
public override DamageType GetDamageType()
```

```csharp
public override float EstimateChanceToHit(float range_km, TISpaceShipState targetState = null, TISpaceShipTemplate targetTemplate = null, float overrideTargetAcceleration_mps2 = -1f)
```

```csharp
public override float EstimateDPS(float expectedRange_km, TISpaceShipTemplate target, bool applyOverkillPenalty)
```

```csharp
public override float EnergyUsage_GJ(float extraInput_MW = 0f)
```

```csharp
public override float HeatGeneration_GJ(float extraInput_MJ = 0f)
```

```csharp
protected override float KineticEnergyDamage_MJ(float finalVelocity_kps, float warheadMass_kg)
```

```csharp
public override float DamageAtRange_MJ(float range_km, float targetCrossSection_m, CombatWeaponCarrierState attacker, float finalVelocity_kps = 0f, float warheadMass_kg = 0f, bool applyChipping = true)
```

```csharp
public override float BaseDamageAtRange_MJ(float range_km, bool applyChipping = true)
```

```csharp
public float RangeAtOneDamage_km(WarheadClass warheadClass)
```

```csharp
public override Damage GetComplexDamage(float range_km, IDamageableType targetType, float targetCrossSectionalArea_m2, float relativeVelocity_kps = -1f, CombatWeaponCarrierState attacker = null, TIFactionState attackingFaction = null, float warheadMassOverride_kg = -1f)
```

```csharp
public override string SpecificDescriptionData()
```

```csharp
public string GetLocalizedWarheadTypeAndChipping()
```

```csharp
public string GetLocalizedWarheadType()
```

```csharp
public string GetLocalizedAcceleration()
```

```csharp
public string GetLocalizedDV()
```

```csharp
public string GetLocalizedShapeChargeAngle()
```

```csharp
public string GetLocalizedEffectiveAOE()
```

```csharp
public override float GetSurfaceImpactVelocity_kps(TISpaceBodyState spaceBody, float altitude_km)
```

```csharp
public override bool CanOnlyDefensivelyTargetMissiles()
```

```csharp
public override float EffectiveRangeAgainstProjectiles_km()
```
