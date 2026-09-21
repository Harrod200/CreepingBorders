# TIRadiatorTemplate

*Decompiled from `TIRadiatorTemplate.cs`.*


## Class `TIRadiatorTemplate`

```csharp
public class TIRadiatorTemplate : TIShipPartTemplate
```

### Fields

| Name | Type |
|---|---|
| `allowedSlots` | public override List<ShipModuleSlotType> |
| `ref_radiator` | public override TIRadiatorTemplate |
| `isRadiator` | public override bool |
| `hasModel` | public override bool |
| `specificMass_tonsm2` | public float |
| `tonsPerGW` | public float |
| `exoFighterPart` | public override bool |
| `radiatorType` | public RadiatorType |
| `operatingTemp_K` | public float |
| `specificMass_2s_kgm2` | public float |
| `specificPower_2s_KWkg` | public float |
| `vulnerability` | public int |
| `collector` | public bool |

### Methods

```csharp
public string combatUIPath_On_OK(TIShipHullTemplate hull, int idx)
```

```csharp
public string combatUIPath_Off_OK(TIShipHullTemplate hull, int idx)
```

```csharp
public string combatUIPath_On_Damaged(TIShipHullTemplate hull, int idx)
```

```csharp
public string combatUIPath_Off_Damaged(TIShipHullTemplate hull, int idx)
```

```csharp
public string combatUIPath_On_Destroyed(TIShipHullTemplate hull, int idx)
```

```csharp
public string combatUIPath_Off_Destroyed(TIShipHullTemplate hull, int idx)
```

```csharp
public string largecombatUI_On(TIShipHullTemplate hull, int idx)
```

```csharp
public string largecombatUI_Off(TIShipHullTemplate hull, int idx)
```

```csharp
public string radiatorUIResourcePath(TIShipHullTemplate hull, int idx)
```

```csharp
public float radiatorSurfaceArea_m2(float wasteHeat_GW)
```

```csharp
public float radiatorArea_m2(float wasteHeat_GW)
```

```csharp
public float buildMass_kg(float wasteHeat_GW)
```

```csharp
public override float buildMass_tons(float wasteHeat_GW, float value2 = 0f, float value3 = 0f, float value4 = 0f, bool bValue = false)
```

```csharp
public override TIResourcesCost buildCost(float wasteHeat_GW, float value2 = 0f)
```

```csharp
public override string GetDescriptionData(TISpaceShipState ship, TISpaceShipTemplate shipTemplate = null, bool prospective = false, ShipModuleSlotType slot = ShipModuleSlotType.None, bool splitFireModes = false)
```

```csharp
public override float AIScoringValueForResearch()
```

```csharp
public string GetLocalizedMass(TISpaceShipTemplate shipTemplate)
```

```csharp
public string GetLocalizedCost(TISpaceShipTemplate shipTemplate)
```

```csharp
public string GetLocalizedVulnerability()
```

```csharp
public string GetLocalizedTonsPerGW()
```

```csharp
public string GetLocalizedCostPerGW()
```
