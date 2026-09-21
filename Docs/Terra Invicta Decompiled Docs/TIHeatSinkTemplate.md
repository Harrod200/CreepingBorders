# TIHeatSinkTemplate

*Decompiled from `TIHeatSinkTemplate.cs`.*


## Class `TIHeatSinkTemplate`

```csharp
public class TIHeatSinkTemplate : TIShipModuleTemplate
```

### Fields

| Name | Type |
|---|---|
| `allowedSlots` | public override List<ShipModuleSlotType> |
| `ref_heatSink` | public override TIHeatSinkTemplate |
| `isHeatSink` | public override bool |
| `heatCapacity_GJ` | public float |

### Methods

```csharp
public override string GetDescriptionData(TISpaceShipState ship, TISpaceShipTemplate shipTemplate = null, bool prospective = false, ShipModuleSlotType slot = ShipModuleSlotType.None, bool splitFireModes = false)
```

```csharp
public string GetLocalizedCapacity()
```

```csharp
public override float AIScoringValueForResearch()
```
