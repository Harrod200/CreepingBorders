# TIShipArmorTemplate

*Decompiled from `TIShipArmorTemplate.cs`.*


## Class `TIShipArmorTemplate`

```csharp
public class TIShipArmorTemplate : TIShipPartTemplate
```

### Fields

| Name | Type |
|---|---|
| `ref_armor` | public override TIShipArmorTemplate |
| `isArmor` | public override bool |
| `exoFighterPart` | public override bool |
| `allowedSlots` | public override List<ShipModuleSlotType> |
| `mass_damagePoint_kg` | public float |
| `volume_damagePoint_m3` | public float |
| `plate_thickness_m` | public float |
| `single_armor_point_mass_tons` | public float |
| `plateArea_m2` | public const float |
| `damagePoint_MJ` | public const float |
| `density_kgm3` | public float |
| `heatofVaporization_MJkg` | public float |
| `xRayHalfValue_cm` | public float |
| `baryonicHalfValue_cm` | public float |
| `specialties` | public List<ArmorSpecialties> |
| `CINEMATIC_LATERAL_ARMOR_VOLUME_SCALING` | public const float |
| `REALISTIC_CAP_ARMOR_ANGLE_MULTIPLIER` | public const float |
| `REALISTIC_CAP_ARMOR_ANGLE_VOLUME_MULTIPLIER` | public const float |

### Methods

```csharp
public float armor_section_thickness_m(float armorPoints)
```

```csharp
public float armor_section_volume(float armorPoints, float hullLength_m, float hullWidth_m, float lateralArmorDepth_m, bool lateral)
```

```csharp
public float GetSpecialtyModifiers(ArmorSpecialty specialty)
```

```csharp
public override float buildMass_tons(float shipLateralArmorDepth_m, float armorPoints, float hullLength_m, float hullWidth_m, bool lateral)
```

```csharp
public override TIResourcesCost buildCost(float armor_facing_mass_tons, float value2 = 0f)
```

```csharp
public override string GetDescriptionData(TISpaceShipState ship, TISpaceShipTemplate shipTemplate = null, bool prospective = false, ShipModuleSlotType slot = ShipModuleSlotType.None, bool splitFireModes = false)
```

```csharp
public override float AIScoringValueForResearch()
```

```csharp
public string GetLocalizedMaximums(TISpaceShipTemplate ship, ShipModuleSlotType slot, bool prospective = false)
```

```csharp
public string GetLocalizedMass(TISpaceShipTemplate shipTemplate, ShipModuleSlotType slot)
```

```csharp
public string GetLocalizedDepth()
```

```csharp
public string GetLocalizedCost(TISpaceShipTemplate shipTemplate, ShipModuleSlotType slot)
```

```csharp
public string GetLocalizedSpecialties()
```

```csharp
public string GetLocalizedXRayValue()
```

```csharp
public string GetLocalizedBaryonicValue()
```

```csharp
public string GetLocalizedFrontBackTonsPerPoint(TISpaceShipTemplate shipTemplate)
```

```csharp
public string GetLocalizedLateralTonsPerPoint(TISpaceShipTemplate shipTemplate)
```

```csharp
public string GetLocalizedTonsPerSquareMeterPerPoint()
```

```csharp
public string GetLocalizeCostPerTon()
```
