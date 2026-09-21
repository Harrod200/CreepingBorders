# TIProjectileWeaponTemplate

*Decompiled from `TIProjectileWeaponTemplate.cs`.*


## Class `TIProjectileWeaponTemplate`

```csharp
public abstract class TIProjectileWeaponTemplate : TIShipWeaponTemplate
```

### Fields

| Name | Type |
|---|---|
| `ammoIconPath` | public virtual string |
| `minDamageForPDToFire` | public virtual float |
| `magazineMass_kg` | public float |
| `magazineMass_tons` | public float |
| `ref_projectileWeapon` | public override TIProjectileWeaponTemplate |
| `isProjectileWeapon` | public override bool |
| `emptyWeaponCost` | public TIResourcesCost |
| `magazine` | public int |
| `ammoMaterials` | public ResourceCostBuilder |
| `ammoMass_kg` | public float |
| `warheadMass_kg` | public float |
| `flatChipping` | public float |
| `noseSurfaceArea_m2` | protected const float |
| `dragCoefficient` | protected const float |
| `shotModelResource` | public string |
| `impactVisualFXResource` | public string |
| `impactSoundFXResource` | public string |
| `_baseDamageAtRange_Points_WithChipping` | private float |
| `_baseDamageATRange_Points_NoChipping` | private float |

### Properties

- `public abstract float EstimatedImpactVelocity_kps`

### Methods

```csharp
public override float BaseDamageAtRange_points(float range_km, bool applyChipping = true)
```

```csharp
public float EstimatedBaseDamageAtRange_points(float range_km, bool applyChipping = true)
```

```csharp
public override bool hasMagazine()
```

```csharp
public int FullAmmoCount_Max(TISpaceShipTemplate ship)
```

```csharp
public int FullAmmoCount_Current(TISpaceShipState ship)
```

```csharp
public int FullAmmoCount_PendingRepairs(TISpaceShipState ship, float pendingRepairedMagazinesMultiplier)
```

```csharp
public override float buildMass_tons(float shipMagazineMultiplier = 0f, float value2 = 0f, float value3 = 0f, float value4 = 0f, bool bValue = false)
```

```csharp
public override TIResourcesCost buildCost(float magazineMultiplier = 0f, float value2 = 0f)
```

```csharp
public virtual TIResourcesCost magazineCost(float magazineMultiplier)
```

```csharp
public override float chipping(float range_km = 0f)
```

```csharp
protected virtual float KineticEnergyDamage_MJ(float finalVelocity_kps, float warheadMass_kg)
```

```csharp
public override Damage GetComplexDamage(float range_km, IDamageableType targetType, float targetCrossSectionalArea_m2, float relativeVelocity_kps = -1f, CombatWeaponCarrierState attacker = null, TIFactionState attackingFaction = null, float warheadMassOverride_kg = -1f)
```

```csharp
public override string SpecificDescriptionData()
```

```csharp
public string GetLocalizedWarheadMass()
```

```csharp
public override string GetLocalizedPowerAndDamageAtRange(float range)
```

```csharp
public abstract float GetSurfaceImpactVelocity_kps(TISpaceBodyState spaceBody, float altitude_km)
```

```csharp
public override float EstimateChanceToHit(float range_km, TISpaceShipState targetState = null, TISpaceShipTemplate targetTemplate = null, float overrideTargetAcceleration_mps2 = -1f)
```
