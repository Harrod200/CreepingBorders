# TILaserWeaponTemplate

*Decompiled from `TILaserWeaponTemplate.cs`.*


## Class `TILaserWeaponTemplate`

```csharp
public class TILaserWeaponTemplate : TIBeamWeaponTemplate
```

### Fields

| Name | Type |
|---|---|
| `weaponClass` | public override WeaponClass |
| `isLaserWeapon` | public override bool |
| `canBombardThroughAtmosphere` | public override bool |
| `ref_laserWeapon` | public override TILaserWeaponTemplate |
| `mirrorDiameter_m` | private float |
| `mirrorRadius_m` | private float |
| `wavelength_m` | private float |
| `mirrorRadius_cm` | public int |
| `wavelength_nm` | public int |
| `beam_quality` | public float |
| `jitter_Rad` | public float |
| `ExpectedArmorHistogram` | private static Dictionary<int, float> |
| `_SpotDiameterPreciseFactor_m` | private float |

### Methods

```csharp
public float ModifyArmorValueForLaserShot(float range_km, float baseArmorValue, float armorEffectiveness = -1f)
```

```csharp
public float ArmorEffectivenessAtRange(float range_km)
```

```csharp
public override float RangeToDoDamage_km(float desiredDamage_Points, TISpaceShipState ship)
```

```csharp
public float EstimatedDamageAtRange_MJ(float range_km, float targetCrossSection_m, CombatWeaponCarrierState attackingShip)
```

```csharp
public override float DamageAtRange_MJ(float range_km, float targetCrossSectionalArea_m2, CombatWeaponCarrierState attackingShip, float finalVelocity_kps = 0f, float warheadMass_kg = 0f, bool applyChipping = true)
```

```csharp
public override float BaseDamageAtRange_MJ(float range_km, bool applyChipping = true)
```

```csharp
public override float chipping(float range_km)
```

```csharp
public override float EffectiveRangeAgainstProjectiles_km()
```

```csharp
private float SpotDiameterPrecise_m(float range_km)
```

```csharp
private float SpotAreaPrecise_m2(float range_km)
```

```csharp
public override string SpecificDescriptionData()
```

```csharp
public string GetLocalizedWaveLength()
```

```csharp
public override string GetLocalizedPowerAndDamageAtRange(float range)
```

```csharp
public string GetLocalizedArmorEffectivenessAtRange(float range)
```

```csharp
public static TILaserWeaponTemplate GetBestHeavyDefenseLaser(TIFactionState faction, TISpaceBodyState spaceBody, int tier)
```

```csharp
public override DamageType GetDamageType()
```

```csharp
public override float EstimateDPS(float expectedRange, TISpaceShipTemplate target, bool applyOverkillPenalty)
```
