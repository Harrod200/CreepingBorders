# FarmDecision

*Decompiled from `PavonisInteractive/TerraInvicta/Tasks/FarmDecision.cs`.*


## Class `FarmDecision`

```csharp
internal class FarmDecision : ArchetypeDecision
```

### Fields

| Name | Type |
|---|---|
| `cachedFactionMonthlyProduction` | private static Dictionary<FactionResource, float> |
| `factionMonthlyIncomeCachedFrame` | private static int |
| `factionMonthlyIncomeCachedFaction` | private static TIFactionState |
| `cachedBestFarms` | private static Dictionary<ValueTuple<TIFactionState, TISpaceBodyState, int>, TIHabModuleTemplate> |
| `bestFarmsCachedFrame` | private static int |

### Methods

```csharp
public FarmDecision()
```

```csharp
public override IEnumerable<TIHabModuleTemplate> Decide(TIFactionState faction, TIGameState location, HabSchematicOrder order)
```

```csharp
private TIHabModuleTemplate GetBestFarm_Internal(TIFactionState faction, TIGameState location, HabSchematicOrder order)
```

```csharp
public static TIHabModuleTemplate GetBestFarm(TIFactionState faction, TIGameState location, IEnumerable<TIHabModuleTemplate> existingModules = null)
```
