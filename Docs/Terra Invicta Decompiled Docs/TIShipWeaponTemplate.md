# TIShipWeaponTemplate

*Decompiled from `TIShipWeaponTemplate.cs`.*


## Class `TIShipWeaponTemplate`

```csharp
public abstract class TIShipWeaponTemplate : TIShipPartTemplate
```

### Fields

| Name | Type |
|---|---|
| `staticLauncher` | public virtual bool |
| `canBombardThroughAtmosphere` | public virtual bool |
| `selfPowered` | public virtual bool |
| `combatIconResource` | public string |
| `ref_weapon` | public override TIShipWeaponTemplate |
| `isWeapon` | public override bool |
| `DefaultFireMode` | public virtual FireMode |
| `averageCooldown_s` | public float |
| `internalSize` | public override int |
| `allowedSlots` | public override List<ShipModuleSlotType> |
| `guardianMode` | public bool |
| `noseWeapon` | public bool |
| `hullWeapon` | public bool |
| `shipWeapon` | public bool |
| `multiSlot` | public bool |
| `exoFighterPart` | public override bool |
| `fighterOnlyWeapon` | public bool |
| `mount` | public Mount |
| `attackMode` | public bool |
| `defenseMode` | public bool |
| `baseWeaponMass_tons` | public float |
| `cooldown_s` | public float |
| `salvo_shots` | public int |
| `intraSalvoCooldown_s` | public float |
| `efficiency` | public float |
| `bombardmentValue` | public float |
| `flatDamage_MJ` | public float |
| `targetingRange_km` | public float |
| `pivotRange_deg` | public float |
| `isPointDefenseTargetable` | public bool |
| `_combatScore` | protected float |
| `_combatScoresForRoles` | protected Dictionary<ShipRole, float> |
| `effectResource` | public string |
| `fireSoundFXResource` | public string |
| `MIN_PD_TARGETING_RANGE` | protected const float |

### Properties

- `public abstract WeaponClass weaponClass`

### Methods

```csharp
public override float AIScoringValueForResearch()
```

```csharp
public abstract float EnergyUsage_GJ(float extraInput_MJ = 0f)
```

```csharp
public abstract float HeatGeneration_GJ(float extraInput_MJ = 0f)
```

```csharp
public abstract float chipping(float range_km = 0f)
```

```csharp
public abstract bool hasMagazine()
```

```csharp
public virtual bool magazineRequiresResources()
```

```csharp
public virtual bool CanOnlyDefensivelyTargetMissiles()
```

```csharp
public abstract float DamageAtRange_MJ(float range_km, float targetCrossSection_m, CombatWeaponCarrierState attacker, float finalVelocity_kps = 0f, float warheadMass_kg = 0f, bool applyChipping = true)
```

```csharp
public abstract float BaseDamageAtRange_MJ(float range_km, bool applyChipping = true)
```

```csharp
public abstract Damage GetComplexDamage(float range_km, IDamageableType targetType, float targetCrossSectionalArea_m2, float relativeVelocity_kps = -1f, CombatWeaponCarrierState attacker = null, TIFactionState attackingFaction = null, float warheadMassOverride_kg = -1f)
```

```csharp
public abstract float EffectiveRangeAgainstProjectiles_km()
```

```csharp
public float GetGffectiveRange_km(IDamageable target)
```

```csharp
protected virtual List<FireMode> GetAllowedFireModes()
```

```csharp
public abstract DamageType GetDamageType()
```

```csharp
public virtual float EstimateChanceToHit(float range_km, TISpaceShipState targetState = null, TISpaceShipTemplate targetTemplate = null, float overrideTargetAcceleration_mps2 = -1f)
```

```csharp
public virtual float EstimateDPS(float expectedRange_km, TISpaceShipTemplate target = null, bool applyOverkillPenalty = true)
```

```csharp
protected float ApplyOverkillPenalty(float damage)
```

```csharp
public float ScoreForRole(ShipRole role)
```

```csharp
public float GetCuratedDesignScore(ShipRole role, IEnumerable<TIShipWeaponTemplate> allOptions, bool willUseRandomWeightedSelection)
```

```csharp
public float GenericScore()
```

```csharp
public bool IsValidRefitPart(TIShipWeaponTemplate oldWeapon)
```

```csharp
public virtual DamageBreakdown DamageAtRange_points(float range_km, float defenderCrossSectionalArea_m2, CombatWeaponCarrierState attacker = null, float finalVelocity_kps = 0f, float warheadMass_kg = 0f, bool applyChipping = true)
```

```csharp
public virtual float BaseDamageAtRange_points(float range_km, bool applyChipping = true)
```

```csharp
public float GetLocalBombardmentValue(TISpaceBodyState spaceBody)
```

```csharp
public float GetLocalBombardmentValue(TISpaceBodyState spaceBody, float range_km)
```

```csharp
public abstract string SpecificDescriptionData()
```

```csharp
public List<FireMode> GetActualFireModes(bool includeIdle = false)
```

```csharp
public override string GetDescriptionData(TISpaceShipState ship = null, TISpaceShipTemplate shipTemplate = null, bool prospective = false, ShipModuleSlotType slot = ShipModuleSlotType.None, bool splitFireModes = false)
```

```csharp
public string GetTruncatedDescriptionData(TISpaceShipState ship = null, TISpaceShipTemplate shipTemplate = null, bool prospective = false, ShipModuleSlotType slot = ShipModuleSlotType.None)
```

```csharp
public string GetLocalizedMountType()
```

```csharp
public string GetLocalizedMass(TISpaceShipTemplate shipTemplate = null)
```

```csharp
public string GetLocalizedFireModes()
```

```csharp
public string GetLocalizedSplitFireModes()
```

```csharp
public virtual string GetLocalizedTargetingRange()
```

```csharp
public virtual string GetLocalizedDefenseTargetingRange(TISpaceShipTemplate template = null)
```

```csharp
public string GetLocalizedEnergyUsage()
```

```csharp
public string GetLocalizedMagazineMaxAmmoCount(TISpaceShipTemplate shipTemplate = null)
```

```csharp
public string GetLocalizedMagazineCost(TISpaceShipTemplate shipTemplate = null)
```

```csharp
public string GetLocalizedCooldown()
```

```csharp
public string GetCombinedSalvoData()
```

```csharp
public string GetLocalizedSalvoShotCount()
```

```csharp
public string GetLocalizedSalvoCooldown()
```

```csharp
public abstract string GetLocalizedPowerAndDamageAtRange(float range)
```

```csharp
public string GetLocalizedBombardmentDetail()
```
