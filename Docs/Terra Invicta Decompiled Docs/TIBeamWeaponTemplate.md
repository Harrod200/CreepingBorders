# TIBeamWeaponTemplate

*Decompiled from `TIBeamWeaponTemplate.cs`.*


## Class `TIBeamWeaponTemplate`

```csharp
public abstract class TIBeamWeaponTemplate : TIShipWeaponTemplate
```

### Fields

| Name | Type |
|---|---|
| `isBeamWeapon` | public override bool |
| `ref_beamWeapon` | public override TIBeamWeaponTemplate |
| `shortRange` | public float |
| `mediumRange` | public float |
| `longRange` | public float |
| `shotPower_MJ` | public int |
| `_damageMinRange` | protected Dictionary<float, float> |

### Methods

```csharp
public override bool hasMagazine()
```

```csharp
public override float EnergyUsage_GJ(float extraInput_MJ = 0f)
```

```csharp
public override float HeatGeneration_GJ(float extraInput_MJ = 0f)
```

```csharp
public override float buildMass_tons(float value1 = 0f, float value2 = 0f, float value3 = 0f, float value4 = 0f, bool bValue = false)
```

```csharp
public override TIResourcesCost buildCost(float value = 0f, float value2 = 0f)
```

```csharp
public string GetLocalizedShotPower()
```

```csharp
public override string GetLocalizedTargetingRange()
```

```csharp
public override string GetLocalizedDefenseTargetingRange(TISpaceShipTemplate template = null)
```

```csharp
public abstract float RangeToDoDamage_km(float desiredDamage, TISpaceShipState ship)
```

```csharp
public override float EffectiveRangeAgainstProjectiles_km()
```

```csharp
public override Damage GetComplexDamage(float range_km, IDamageableType targetType, float targetCrossSectionalArea_m2, float relativeVelocity_kps = -1f, CombatWeaponCarrierState attacker = null, TIFactionState attackingFaction = null, float warheadMassOverride_kg = -1f)
```
