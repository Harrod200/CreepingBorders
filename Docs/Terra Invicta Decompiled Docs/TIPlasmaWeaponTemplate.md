# TIPlasmaWeaponTemplate

*Decompiled from `TIPlasmaWeaponTemplate.cs`.*


## Class `TIPlasmaWeaponTemplate`

```csharp
public class TIPlasmaWeaponTemplate : TIGunTypeWeaponTemplate
```

### Fields

| Name | Type |
|---|---|
| `canBombardThroughAtmosphere` | public override bool |
| `weaponClass` | public override WeaponClass |
| `isPlasmaWeapon` | public override bool |
| `chargingEnergy_GJ` | public float |

### Methods

```csharp
public override TIResourcesCost magazineCost(float magazines)
```

```csharp
public override bool magazineRequiresResources()
```

```csharp
public override float EnergyUsage_GJ(float extraInput_MW = 0f)
```

```csharp
public override float HeatGeneration_GJ(float extraInput_MJ = 0f)
```

```csharp
public override TIResourcesCost buildCost(float value = 0f, float value2 = 0f)
```

```csharp
public string GetLocalizedChargingEnergy()
```

```csharp
public override DamageType GetDamageType()
```

```csharp
public override float GetSurfaceImpactVelocity_kps(TISpaceBodyState spaceBody, float altitude_km)
```

```csharp
public override float EffectiveRangeAgainstProjectiles_km()
```
