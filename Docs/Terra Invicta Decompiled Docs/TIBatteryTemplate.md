# TIBatteryTemplate

*Decompiled from `TIBatteryTemplate.cs`.*


## Class `TIBatteryTemplate`

```csharp
public class TIBatteryTemplate : TIUtilityModuleTemplate
```

### Fields

| Name | Type |
|---|---|
| `allowedSlots` | public override List<ShipModuleSlotType> |
| `ref_battery` | public override TIBatteryTemplate |
| `isBattery` | public override bool |
| `exoFighterPart` | public override bool |
| `fighterVariantSizeReduction` | public const float |
| `energyCapacity_GJ` | public float |
| `rechargeRate_GJs` | public float |

### Methods

```csharp
public float GetTimeToFullCharge_minutes(bool fighterHull)
```

```csharp
public float GetCapacity(bool fighterHull)
```

```csharp
public override float buildMass_tons(float value1 = 0f, float value2 = 0f, float value3 = 0f, float value4 = 0f, bool bValue = false)
```

```csharp
public override string GetDescriptionData(TISpaceShipState ship, TISpaceShipTemplate shipTemplate = null, bool prospective = false, ShipModuleSlotType slot = ShipModuleSlotType.None, bool splitFireModes = false)
```

```csharp
public string GetLocalizedCapacity(bool fighterHull)
```

```csharp
public string GetLocalizedRechargeRateInMinutes(bool fighterHull)
```

```csharp
public override float AIScoringValueForResearch()
```
