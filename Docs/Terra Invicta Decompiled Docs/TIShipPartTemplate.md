# TIShipPartTemplate

*Decompiled from `TIShipPartTemplate.cs`.*


## Class `TIShipPartTemplate`

```csharp
public abstract class TIShipPartTemplate : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `internalSize` | public virtual int |
| `hasModel` | public virtual bool |
| `hitPoints` | public float |
| `ref_drive` | public virtual TIDriveTemplate |
| `ref_powerPlant` | public virtual TIPowerPlantTemplate |
| `ref_battery` | public virtual TIBatteryTemplate |
| `ref_radiator` | public virtual TIRadiatorTemplate |
| `ref_heatSink` | public virtual TIHeatSinkTemplate |
| `ref_utilityModule` | public virtual TIUtilityModuleTemplate |
| `ref_armor` | public virtual TIShipArmorTemplate |
| `ref_weapon` | public virtual TIShipWeaponTemplate |
| `ref_beamWeapon` | public virtual TIBeamWeaponTemplate |
| `ref_laserWeapon` | public virtual TILaserWeaponTemplate |
| `ref_particleWeapon` | public virtual TIParticleWeaponTemplate |
| `ref_missileWeapon` | public virtual TIMissileTemplate |
| `ref_projectileWeapon` | public virtual TIProjectileWeaponTemplate |
| `ref_gunWeapon` | public virtual TIGunTypeWeaponTemplate |
| `isAlien` | public bool |
| `isDrive` | public virtual bool |
| `isPowerPlant` | public virtual bool |
| `isBattery` | public virtual bool |
| `isRadiator` | public virtual bool |
| `isHeatSink` | public virtual bool |
| `isUtilityModule` | public virtual bool |
| `isArmor` | public virtual bool |
| `isWeapon` | public virtual bool |
| `isBeamWeapon` | public virtual bool |
| `isLaserWeapon` | public virtual bool |
| `isParticleWeapon` | public virtual bool |
| `isMissileWeapon` | public virtual bool |
| `isProjectileWeapon` | public virtual bool |
| `isGunTypeWeapon` | public virtual bool |
| `isNavalGunWeapon` | public virtual bool |
| `isMagneticGunWeapon` | public virtual bool |
| `isPlasmaWeapon` | public virtual bool |
| `description` | public virtual string |
| `exoFighterPart` | public virtual bool |
| `repairCostMultipler` | public virtual float |
| `requiredProject` | public TIProjectTemplate |
| `requiredProjectName` | public string |
| `weightedBuildMaterials` | public ResourceCostBuilder |
| `crew` | public int |
| `iconResource` | public string |
| `modelResource` | public string |
| `combatUIpath` | public string |
| `noCombatRepair` | public bool |
| `hp` | public float? |
| `_cachedRequiredProject` | private TIProjectTemplate |
| `PrimaryRoleModules` | public static readonly SpecialModuleRule[] |

### Properties

- `public virtual List<ShipModuleSlotType> allowedSlots`

### Methods

```csharp
public abstract float buildMass_tons(float value1 = 0f, float value2 = 0f, float value3 = 0f, float value4 = 0f, bool bValue = false)
```

```csharp
public abstract TIResourcesCost buildCost(float value = 0f, float value2 = 0f)
```

```csharp
public virtual float AIScoringValueForResearch()
```

```csharp
public bool FactionCanBuild(TIFactionState faction)
```

```csharp
public string GetFullDescription(TISpaceShipState ship = null, TISpaceShipTemplate shipTemplate = null, bool prospective = false, ShipModuleSlotType slot = ShipModuleSlotType.None, bool splitFireModes = false)
```

```csharp
public abstract string GetDescriptionData(TISpaceShipState ship = null, TISpaceShipTemplate shipTemplate = null, bool prospective = false, ShipModuleSlotType slot = ShipModuleSlotType.None, bool splitFireModes = false)
```

```csharp
public virtual string GetLocalizedMass()
```

```csharp
public virtual string GetLocalizedCost()
```

```csharp
public string GetLocalizedCrew()
```

```csharp
public bool Explosive(TISpaceShipState ship, ModuleDataEntry moduleData)
```

```csharp
public bool Explosive()
```

```csharp
public bool HighlyExplosive(TISpaceShipState ship)
```
