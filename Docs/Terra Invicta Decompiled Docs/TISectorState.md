# TISectorState

*Decompiled from `PavonisInteractive/TerraInvicta/TISectorState.cs`.*


## Class `TISectorState`

```csharp
public class TISectorState : TIGameState
```

### Fields

| Name | Type |
|---|---|
| `ref_faction` | public override TIFactionState |
| `ref_hab` | public override TIHabState |
| `ref_habSite` | public override TIHabSiteState |
| `ref_orbit` | public override TIOrbitState |
| `ref_spaceBody` | public override TISpaceBodyState |
| `ref_spaceObject` | public override TISpaceObjectState |
| `ref_naturalSpaceObject` | public override TINaturalSpaceObjectState |
| `ref_spaceAsset` | public override TISpaceAssetState |
| `hasMapObject` | public override bool |
| `inSpace` | public override bool |
| `active` | public bool |
| `coreSector` | public bool |
| `shortSectorString` | public string |
| `iconResource` | public string |
| `numFunctionalModules` | public int |
| `SectorPowerGeneration` | public int |
| `controlPointCapacityValue` | public int |
| `sectorNum` | public int |
| `hab` | public TIHabState |
| `habModules` | public List<TIHabModuleState> |
| `slots` | public int |

### Properties

- `public TIFactionState faction`

### Methods

```csharp
public List<TIHabModuleState> AllModules()
```

```csharp
public List<TIHabModuleState> CompletedModules()
```

```csharp
public List<TIHabModuleState> OkayModules()
```

```csharp
public List<TIHabModuleState> FunctionalModules()
```

```csharp
public List<TIHabModuleState> ActiveModules()
```

```csharp
public List<TIHabModuleState> UnpoweredModules()
```

```csharp
public List<TIHabModuleState> ActiveCombatModules()
```

```csharp
public static int sectorDisplayNum(int sectorNum, HabType habType)
```

```csharp
public void SetDisplayName()
```

```csharp
public void SetFaction(TIFactionState newFaction)
```

```csharp
public bool ValidModuleForSlot(TIHabModuleTemplate module, int slot)
```

```csharp
public bool HasAnyModules()
```

```csharp
public bool HasAnyFunctionalModules(bool skipCoreModule = false)
```

```csharp
public bool HasAnyOuterRingModules()
```

```csharp
public bool HasAnyWingModules()
```

```csharp
public static TIHabModuleState UpdateModuleConnectorMap(TIHabState hab, TIHabModuleState m)
```

```csharp
public int SectorNetPowerValue(bool includeUnderConstruction, bool includeDeactivated)
```

```csharp
public bool HasIncome(FactionResource resourceType)
```

```csharp
public float GetNetDailyIncomeForDisplay(FactionResource resource)
```

```csharp
public float GetNetMonthlyIncomeForDisplay(FactionResource resource)
```

```csharp
private float GetNetYearlyIncomeForDisplay(FactionResource resourceType)
```

```csharp
public bool AllowsResupply_Display(bool includeInactives)
```

```csharp
public bool AllowsShipConstruction_Display(bool includeInactives)
```

```csharp
public float SectorCombatValue_Display(bool includeInactives)
```

```csharp
public float GetNetScienceBonus_Display(bool includeInactives, TechCategory category)
```

```csharp
public float GetModuleConstructionTimeModifier_Display(bool includeInactives = false)
```
