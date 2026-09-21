# TIPowerPlantTemplate

*Decompiled from `TIPowerPlantTemplate.cs`.*


## Class `TIPowerPlantTemplate`

```csharp
public class TIPowerPlantTemplate : TIShipPartTemplate
```

### Fields

| Name | Type |
|---|---|
| `allowedSlots` | public override List<ShipModuleSlotType> |
| `ref_powerPlant` | public override TIPowerPlantTemplate |
| `isPowerPlant` | public override bool |
| `PowerPlantClassStr` | public string |
| `fissionPlant` | public bool |
| `magneticFusionPlant` | public bool |
| `exoFighterPart` | public override bool |
| `maxOutput_GW` | public float |
| `specificPower_tGW` | public float |
| `powerPlantClass` | public PowerPlantRequirement |
| `efficiency` | public float |

### Methods

```csharp
public override float buildMass_tons(float power_GW, float value2 = 0f, float value3 = 0f, float value4 = 0f, bool bValue = false)
```

```csharp
public override TIResourcesCost buildCost(float power_GW, float value2 = 0f)
```

```csharp
public float WasteHeat_GW(bool openCycleDriveCooling, float drivePowerRequirement_GW, float systemsAndWeaponsRequirement_GW)
```

```csharp
public bool IsCompatible(TIDriveTemplate drive)
```

```csharp
public bool IsValidRefitPart(TISpaceShipTemplate originalShipTemplate)
```

```csharp
public override string GetDescriptionData(TISpaceShipState ship, TISpaceShipTemplate shipTemplate = null, bool prospective = false, ShipModuleSlotType slot = ShipModuleSlotType.None, bool splitFireModes = false)
```

```csharp
public override float AIScoringValueForResearch()
```

```csharp
public string GetLocalizedPowerPlantType()
```

```csharp
public string GetLocalizedOutput(TISpaceShipTemplate shipTemplate)
```

```csharp
public string GetLocalizedMass(TISpaceShipTemplate shipTemplate)
```

```csharp
public string GetLocalizedWasteHeat(TISpaceShipTemplate shipTemplate)
```

```csharp
public string GetLocalizedEfficiency()
```

```csharp
public string GetLocalizedSpecificPower()
```

```csharp
public string GetLocalizedMaximumOutput()
```

```csharp
public string GetLocalizedCost(TISpaceShipTemplate shipTemplate)
```

```csharp
public string GetLocalizedCostPerGW()
```
