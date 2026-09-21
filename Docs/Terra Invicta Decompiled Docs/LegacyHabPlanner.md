# LegacyHabPlanner

*Decompiled from `PavonisInteractive/TerraInvicta/Tasks/LegacyHabPlanner.cs`.*


## Class `LegacyHabPlanner`

```csharp
public abstract class LegacyHabPlanner : HabPlanner
```

### Fields

| Name | Type |
|---|---|
| `habModuleSelections` | private Dictionary<TIFactionState, Dictionary<TIHabState, string>> |
| `SectorSlot` | private struct |
| `sector` | public int |
| `slot` | public int |

### Methods

```csharp
public override void FoundHabs(TIFactionState faction)
```

```csharp
public override void ManageHabs(TIFactionState faction)
```

```csharp
public void BuildHabModules(TIFactionState faction)
```

```csharp
private TIHabModuleTemplate GetTargetedModuleForHab(TIFactionState faction, TIHabState hab, TIFactionGoalState goal, IEnumerable<TIHabModuleTemplate> allowedModules, IEnumerable<TIHabModuleState> shipyardsAtHab)
```

```csharp
private TIHabModuleTemplate SelectHabModuleForBuilding(TIFactionState faction, TIHabState hab, FactionGoal_BuildHab goal, List<TIHabState> shipyardHabs, List<HabModuleSpecialRule> maxxedOutSpecialRules, List<TechCategory> maxxedOutTechCategories)
```

```csharp
public static TIHabSiteState SelectHabSiteForDevelopment(TIFactionState faction, float lowDist_AU, float highDist_AU, List<TIHabSiteState> sitesToSkip, bool forcePlanetarySystem = false, bool forceSunOrbitingAsteroid = false, bool forceBest = false, TISpaceBodyState skipThis = null, int requiredMaxTier = 1, bool usePercentChangeScoring = false, Func<FactionResource, float> GetCurrentMonthlyIncome = null)
```

```csharp
public static TIHabSiteState SelectHabSiteForDevelopment(TIFactionState faction, TISpaceBodyState spaceBody, List<TIHabSiteState> sitesToSkip, bool system = false, bool forceBest = false, int requiredMaxTier = 1, bool usePercentChangeScoring = false, Func<FactionResource, float> GetCurrentMonthlyIncome = null)
```

```csharp
public static TIHabSiteState SelectHabSiteForDevelopment(TIFactionState faction, IEnumerable<TIHabSiteState> habSites, bool forceBest = false, bool usePercentChangeScoring = false, Func<FactionResource, float> GetCurrentMonthlyIncome = null)
```
