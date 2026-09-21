# TIDriveTemplate

*Decompiled from `TIDriveTemplate.cs`.*


## Class `TIDriveTemplate`

```csharp
public class TIDriveTemplate : TIShipPartTemplate
```

### Fields

| Name | Type |
|---|---|
| `ref_drive` | public override TIDriveTemplate |
| `isDrive` | public override bool |
| `internalSize` | public override int |
| `allowedSlots` | public override List<ShipModuleSlotType> |
| `thrustPower_GW` | public float |
| `nozzleStr` | public string |
| `selfPowered` | public bool |
| `powerRequirement_GW` | public float |
| `nozzle` | public Nozzle |
| `massFlow_kgs` | public float |
| `openCycleCooling` | public bool |
| `singleThrusterTemplate` | public TIDriveTemplate |
| `singleThrusterTemplateName` | public string |
| `maxThrustersTemplateName` | public string |
| `exoFighterPart` | public override bool |
| `driveTypeName` | public string |
| `Variations` | public IEnumerable<TIDriveTemplate> |
| `thrustRating` | public float |
| `EVRating` | public float |
| `nuclearThermalDrive` | public bool |
| `antimatterOrNuclearDrive` | public bool |
| `fissionDrive` | public bool |
| `fusionDrive` | public bool |
| `magneticFusionDrive` | public bool |
| `pulsedDrive` | public bool |
| `description` | public override string |
| `thrusters` | public int |
| `driveClassification` | public DriveClassification |
| `thrust_N` | public float |
| `EV_kps` | public float |
| `specificPower_kgMW` | public float |
| `flatMass_tons` | public float |
| `thrustCap` | public float |
| `efficiency` | public float |
| `requiredPowerPlant` | public PowerPlantRequirement |
| `propellant` | public Propellant |
| `freeISRU` | public bool |
| `helium3Fuel` | public bool |
| `notes` | public string |
| `perTankPropellantMaterials` | public ResourceCostBuilder |
| `cooling` | public CoolingCycle |
| `powerGen` | public PowerGenerationType |
| `_thrustRating` | private float |
| `_EVRating` | private float |
| `log1000` | private float |

### Methods

```csharp
public string combatUIPath_OK(TIShipHullTemplate hull, int idx)
```

```csharp
public string combatUIPath_Damaged(TIShipHullTemplate hull, int idx)
```

```csharp
public string combatUIPath_Destroyed(TIShipHullTemplate hull, int idx)
```

```csharp
public string largeCombatUIPath(TIShipHullTemplate hull, int idx)
```

```csharp
public string driveUIResourcePath(TIShipHullTemplate hull, int idx)
```

```csharp
public new string modelResource(TIShipHullTemplate hull, int appearanceIndex = 0)
```

```csharp
public static string propellantStr(Propellant propellant)
```

```csharp
public string MainThrusterFXResource(bool alien)
```

```csharp
public string VectorThrusterFXResource(bool alien)
```

```csharp
public override float buildMass_tons(float value1 = 0f, float value2 = 0f, float value3 = 0f, float value4 = 0f, bool bValue = false)
```

```csharp
public override TIResourcesCost buildCost(float value = 0f, float value2 = 0f)
```

```csharp
public string GetMaterialPath(TIFactionState faction, int hullAppearanceIndex)
```

```csharp
public TIDriveTemplate GetVariation(int thrusterCount)
```

```csharp
public TIDriveTemplate AddThruster(TISpaceShipTemplate ship, int amount = 1)
```

```csharp
public TIDriveTemplate RemoveThruster(TISpaceShipTemplate ship, int amount = 1)
```

```csharp
public bool IsCompatible(TIPowerPlantTemplate powerPlant)
```

```csharp
public bool IsValidRefitPart(TISpaceShipTemplate oldShipTemplate)
```

```csharp
public bool IsSameDriveWithDifferentThrusterCount(TIDriveTemplate other)
```

```csharp
public override string GetDescriptionData(TISpaceShipState ship, TISpaceShipTemplate shipTemplate = null, bool prospective = false, ShipModuleSlotType slot = ShipModuleSlotType.None, bool splitFireModes = false)
```

```csharp
public string GetLocalizedRequiredPowerPlant()
```

```csharp
public string GetLocalizedRequiredPower()
```

```csharp
public string GetLocalizedThrust()
```

```csharp
public string GetLocalizedCombatThrust(TISpaceShipState ship)
```

```csharp
public string GetLocalizedExhaustVelocity()
```

```csharp
public string GetLocalizedEfficiency()
```

```csharp
public string GetLocalizedShipPowerRule()
```

```csharp
public string GetLocalizedPropellantType()
```

```csharp
public string GetLocalizedPropellantMaterials(TIFactionState faction)
```

```csharp
public string GetLocalizedClassification()
```

```csharp
public string PropellantIcons(bool iconsOnly, TIFactionState faction)
```

```csharp
public ResourceCostBuilder GetPerTankPropellantMaterials(TIFactionState faction)
```
