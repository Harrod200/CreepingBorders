# TIHabModuleTemplate

*Decompiled from `TIHabModuleTemplate.cs`.*


## Class `TIHabModuleTemplate`

```csharp
public class TIHabModuleTemplate : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `slotsProvided` | public int |
| `weaponMounts` | public int |
| `constructionModule` | public bool |
| `EnablesLocalFounding` | public bool |
| `IsSolarPower` | public bool |
| `IsNonSolarPower` | public bool |
| `IsFarm` | public bool |
| `FarmValue` | public float |
| `dimension_m` | public float |
| `StationModuleArmorPoints` | public float |
| `AlienDetectionBonus` | public float |
| `HumanDetectionBonus` | public float |
| `PropandaStrengthBonus` | public float |
| `ArmyCombatValueBonus` | public float |
| `EfficiencyBonus` | public float |
| `PowerFirst` | public bool |
| `description` | public string |
| `SpecialRules` | public List<HabModuleSpecialRule> |
| `extendedDescription` | public string |
| `constructionModelResource` | public string |
| `constructionModelDestructionResource` | public string |
| `RequiredProject` | public TIProjectTemplate |
| `UpgradesFrom` | public TIHabModuleTemplate |
| `UpgradesTo` | public TIHabModuleTemplate |
| `moduleConstructionSpeedModifier` | public float |
| `powerSource` | public bool |
| `powerConsumed` | public int |
| `CanTurnOff` | public bool |
| `spaceAssaultValue` | public float |
| `coreModule` | public bool |
| `habType` | public HabType |
| `onePerHab` | public bool |
| `automated` | public bool |
| `alienModule` | public bool |
| `noBuild` | public bool |
| `upgradesFromName` | public string |
| `tier` | public int |
| `requiredProjectName` | public string |
| `crew` | public int |
| `power` | public int |
| `baseMass_tons` | public float |
| `constructionTimeModifier` | public float |
| `miningModifier` | public float |
| `allowsShipConstruction` | public bool |
| `allowsResupply` | public bool |
| `mine` | public bool |
| `destroyed` | public bool |
| `buildTime_Days` | public float |
| `spaceCombatModule` | public bool |
| `incomeMoney_month` | public float |
| `incomeInfluence_month` | public float |
| `incomeOps_month` | public float |
| `incomeBoost_month` | public float |
| `missionControl` | public int |
| `incomeResearch_month` | public float |
| `incomeProjects` | public int |
| `incomeWater_month` | public float |
| `incomeVolatiles_month` | public float |
| `incomeMetals_month` | public float |
| `incomeNobles_month` | public float |
| `incomeFissiles_month` | public float |
| `incomeAntimatter_month` | public float |
| `incomeExotics_month` | public float |
| `controlPointCapacity` | public int |
| `techBonuses` | public TechBonus[] |
| `unlocksProjectName` | public string |
| `specialRules` | public List<HabModuleSpecialRule> |
| `specialRulesValue` | public float |
| `weightedBuildMaterials` | public ResourceCostBuilder |
| `supportMaterials_month` | public ResourceCostBuilder |
| `baseIconResource` | public string |
| `stationIconResource` | public string |
| `stationModelResource` | public string |
| `stationDestructionResource` | public string |
| `objectiveModule` | public bool |
| `alertWorthy` | public bool |
| `upgradeCostDiscount` | public const float |
| `upgradeSpeedDiscount` | public const float |
| `combatTroopsRules` | public static readonly List<HabModuleSpecialRule> |
| `_specialRules` | private List<HabModuleSpecialRule> |
| `cachedStationCombatModuleStrengths` | public static Dictionary<TIFactionState, Dictionary<int, float>> |
| `cachedHasBeenResearched` | private Dictionary<TIFactionState, bool> |
| `hasBeenResearchedCachedFrame` | private int |
| `_upgradesFrom` | private TIHabModuleTemplate |
| `_upgradesTo` | private TIHabModuleTemplate |
| `_upgradeToChecked` | private bool |
| `IncomeEntry` | private struct |
| `inlinePath` | public string |
| `value` | public string |

### Methods

```csharp
public float GetFarmResourceValue(FactionResource resource)
```

```csharp
public float GetCrossSectionalArea_m2(float angle = 3.4028235E+38f)
```

```csharp
public float GetSpecialRuleValue(HabModuleSpecialRule rule)
```

```csharp
public string benefitsAndCostsDescription(TIFactionState faction, TIHabState hab, bool prospectiveForHab = false)
```

```csharp
public string iconResource(HabType habType)
```

```csharp
public string constructionIconResource(HabType habType)
```

```csharp
public float Mass_tons(float irradiatedValue, TISpaceBodyState surfaceBody, TINaturalSpaceObjectState barycenter, TIFactionState faction)
```

```csharp
public int BaseStationModuleHitPoints(TIFactionState faction, TIHabState hab)
```

```csharp
public TIShipArmorTemplate GetBestArmor(TIFactionState faction, TINaturalSpaceObjectState location)
```

```csharp
public float TargetingBonus(TIFactionState faction, TIHabState alliedHab)
```

```csharp
public float ECMValue(TIFactionState faction, TIHabState alliedHab)
```

```csharp
public List<TIShipWeaponTemplate> NotionalWeaponsList(TIFactionState faction, bool isBase, TISpaceBodyState spacebody, bool includePD = true)
```

```csharp
public float SpaceCombatValue(TIFactionState faction, TIHabState hab, bool fullyCalculate)
```

```csharp
public static void InvalidateHabDefenseNumbers(TIFactionState faction)
```

```csharp
public float SpaceCombatValue_Station(TIFactionState faction, TIHabState hab)
```

```csharp
public float SpaceCombatValue_Base(TIFactionState faction, TIHabState hab)
```

```csharp
public ResourceCostBuilder BuildMaterials(float irradiatedValue, TISpaceBodyState spaceBody, TINaturalSpaceObjectState naturalSpaceObject, TIFactionState faction, float multiplier)
```

```csharp
public float MoneyCost(float irradiatedValue, TISpaceBodyState spaceBody, TINaturalSpaceObjectState naturalSpaceObject, TIFactionState faction, float rateMultiplier, List<ResourceValue> preSuppliedResources = null)
```

```csharp
public float BoostCostFromEarth(float irradiatedValue, TISpaceBodyState spaceBody, TIFactionState faction, TIGameState destination, float rateMultiplier, List<ResourceValue> preSuppliedResources = null)
```

```csharp
public TIResourcesCost CostFromEarth(TIFactionState faction, TIGameState destinationState, bool isUpgrade)
```

```csharp
public TIResourcesCost CostFromSpace(TIFactionState faction, TIGameState destinationState, bool isUpgrade, bool substituteBoost, int maxDaysToSave = 0, bool dontRecalculateIncome = false)
```

```csharp
public TIResourcesCost MinimumBoostCost(TIFactionState faction, TIGameState location, bool isUpgrade = false, int maxDaysToSave = 180)
```

```csharp
public TIResourcesCost MinimumBoostCostToday(TIFactionState faction, TIGameState location, bool isUpgrade = false)
```

```csharp
public bool OnFutureUpgradePath(TIHabModuleTemplate moduleToCheck)
```

```csharp
public bool OnFutureOrPastUpgradePath(TIHabModuleTemplate moduleToCheck)
```

```csharp
public bool SharesUpgradePath(TIHabModuleTemplate moduleToCheck)
```

```csharp
public bool IsForHabType(HabType testHabType)
```

```csharp
public bool ModuleTierIsAllowed(TIHabState hab)
```

```csharp
public bool AllowedForHabAutomatedStatus(TIHabState hab)
```

```csharp
public bool AllowedLocation(TIGameState habLocation, TIHabState hab)
```

```csharp
public bool EverAllowedForFaction(TIFactionState faction)
```

```csharp
public bool FactionCanBuild(TIFactionState faction)
```

```csharp
public float GetMonthlyRecyclableConsumption(FactionResource resource, TIFactionState faction = null, TIHabState hab = null)
```

```csharp
public float MonthlySupportCost(FactionResource resource, bool includeCrewSupportCost = true, TIFactionState faction = null, TIHabState hab = null)
```

```csharp
public float MonthlyCrewSupportCost(FactionResource resource, TIFactionState faction = null, TIHabState hab = null)
```

```csharp
public float YearlySupportCost(FactionResource resource, bool includeCrewSupportCost = true, TIFactionState faction = null, TIHabState hab = null)
```

```csharp
public float DailySupportCost(FactionResource resource, bool includeCrewSupportCost = true, TIFactionState faction = null, TIHabState hab = null)
```

```csharp
public float YearlyResourceIncome(FactionResource resource, TIHabState hab = null, TIFactionState faction = null)
```

```csharp
public float DailyResourceIncome(FactionResource resource, TIHabState hab = null, TIFactionState faction = null)
```

```csharp
public float MonthlyResourceIncome(FactionResource resource, TIGameState location = null, TIFactionState faction = null)
```

```csharp
public float MonthlyResourceRevenue(FactionResource resource, TIGameState location = null, TIFactionState faction = null)
```

```csharp
public TIHabModuleTemplate UpgradeModuleTemplate(TIFactionState faction, bool checkUnlocked)
```

```csharp
public bool CanUpgrade(TIFactionState faction)
```

```csharp
public float GetTechBonusByCategory(TechCategory category)
```

```csharp
public TIProjectTemplate GetProjectUnlocked()
```

```csharp
public float GetMiningIncome_Day(TIFactionState faction, TIHabSiteState habSite, FactionResource resource)
```

```csharp
public float GetMiningIncome_Year(TIFactionState faction, TIHabSiteState habSite, FactionResource resource)
```

```csharp
public float GetMiningIncome_Month(TIFactionState faction, TIHabSiteState habSite, FactionResource resource)
```

```csharp
public float ShipyardConstructionSpeedModifier(TIShipHullTemplate hullTemplate)
```

```csharp
public bool CombatTroops()
```

```csharp
public int ProspectivePower(TISpaceBodyState spaceBody, TIFactionState faction)
```

```csharp
public int ProspectivePower(TIHabSiteState site, TIFactionState faction)
```

```csharp
public int ProspectivePower(TIOrbitState orbit)
```

```csharp
public int ProspectivePower(TIHabState hab)
```

```csharp
public int ProspectivePower(TIGameState location, TIFactionState faction)
```

```csharp
public int ControlPointCapacity(bool habInEarthLEO)
```

```csharp
public bool HasLEOBonus()
```

```csharp
public static void ClearStaticData()
```

```csharp
public IncomeEntry(string ip, string v)
```
