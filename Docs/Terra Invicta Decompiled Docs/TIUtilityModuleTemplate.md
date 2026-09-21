# TIUtilityModuleTemplate

*Decompiled from `TIUtilityModuleTemplate.cs`.*


## Class `TIUtilityModuleTemplate`

```csharp
public class TIUtilityModuleTemplate : TIShipModuleTemplate
```

### Fields

| Name | Type |
|---|---|
| `marineOpsValue` | public float |
| `ECMValue` | public float |
| `targetingValue` | public float |
| `fleetMCValue` | public float |
| `thrustMultiplier` | public float |
| `EVMultiplier` | public float |
| `laserPowerBonus_MW` | public float |
| `shipSpaceScienceModuleResearchBonus` | public float |
| `salvageBonus` | public float |
| `armorMaxBonus` | public float |
| `componentArmorValue` | public float |
| `vectorThrustBonus` | public float |
| `particleBeamPowerBonus_MW` | public float |
| `magazineAmmoBonus` | public float |
| `requiresHydrogenPropellant` | public bool |
| `requiresNuclearDrive` | public bool |
| `requiresFissionDrive` | public bool |
| `requiresFusionDrive` | public bool |
| `requiresNonISRUDrive` | public bool |
| `allowedSlots` | public override List<ShipModuleSlotType> |
| `ref_utilityModule` | public override TIUtilityModuleTemplate |
| `isUtilityModule` | public override bool |
| `description` | public override string |
| `repairCostMultipler` | public override float |
| `grouping` | public int |
| `powerRequirement_MW` | public float |
| `specialModuleValue` | public float |
| `minConsTier` | public int |
| `specialModuleRules` | public List<SpecialModuleRule> |

### Methods

```csharp
public override float buildMass_tons(float value1 = 0f, float value2 = 0f, float value3 = 0f, float value4 = 0f, bool bValue = false)
```

```csharp
public override string GetDescriptionData(TISpaceShipState ship, TISpaceShipTemplate shipTemplate = null, bool prospective = false, ShipModuleSlotType slot = ShipModuleSlotType.None, bool splitFireModes = false)
```
