# AIEvaluators

*Decompiled from `PavonisInteractive/TerraInvicta/AIEvaluators.cs`.*


## Class `AIEvaluators`

```csharp
public static class AIEvaluators
```

### Fields

| Name | Type |
|---|---|
| `SystemFleetStrengths` | public static Dictionary<TISpaceObjectState, Dictionary<TIFactionState, float>> |
| `controlEmptyCPUtility` | public const float |
| `baseControlPointUtility` | public const float |
| `investmentPointUtility` | public const float |
| `spaceFlightProgramUtility` | public const float |
| `unrestsquaredUtility` | public const float |
| `nuclearWeaponsProgramUtility` | public const float |
| `ideologicalDistanceUtility` | public const float |
| `resultingControlUtility` | public const float |
| `executiveControlPointUtilityMultiplier` | public const float |
| `armyUtility` | public const float |
| `miltechUtility` | public const float |
| `orbitalDefensesUtility` | public const float |
| `terrorizingForControlPointRelativeUtility` | public const float |
| `popularityRelativeUtility` | public const float |
| `coupUtility` | public const float |
| `revolutionUtility` | public const float |
| `CaptureNationGoalWeight` | public const float |
| `armyBadlyDamaged` | public const float |
| `armyCriticallyDamaged` | public const float |
| `_AIRelativeValuation` | private static readonly Dictionary<FactionResource, float> |
| `DeficientAdjustment` | public const float |
| `notShipBuildingPenalty` | private const float |
| `cachedTechTiers` | private static Dictionary<TIFactionState, Dictionary<TIGenericTechTemplate, int>> |
| `techTiersCacheDate` | private static TIDateTime |
| `obsoleteProjects` | private static Dictionary<TIFactionState, HashSet<TIProjectTemplate>> |
| `improvedShipModuleModifier` | private const float |
| `newHabModuleModifier` | private const float |
| `criticalModifier` | private const float |
| `forcedModifier` | private const float |
| `coreModifier` | private const float |
| `cachedPlannedNetIncomeFromHab` | private static Dictionary<FactionResource, float> |
| `cachedPlannedRevenueFromHab` | private static Dictionary<FactionResource, float> |
| `cachedNonHabCategoryBonuses` | private static Dictionary<TechCategory, float> |
| `cachedProspectiveHabCategoryBonuses` | private static Dictionary<TechCategory, float> |
| `upkeepInsecurityCache` | private static Dictionary<TIFactionState, Dictionary<FactionResource, Dictionary<AIEvaluators.UpkeepInsecurityType, ValueTuple<bool, TIDateTime>>>> |
| `cachedCriticalResources` | private static Dictionary<TIFactionState, ValueTuple<FactionResource, TIDateTime>> |
| `cachedObjectiveHabModuleTemplate` | private static TIHabModuleTemplate |
| `cachedObjectiveHabModuleTemplateObjective` | private static TIObjectiveTemplate |
| `PrimarySystemCampedSoonCutoff_days` | public static float |
| `cachedSystemFleetStrengths` | private static Dictionary<TISpaceObjectState, Dictionary<TIFactionState, float>> |
| `systemFleetStrengthsCachedDate` | private static TIDateTime |
| `threatLevelCachedDate_all` | private static TIDateTime |
| `cachedThreatLevels_all` | private static Dictionary<TISpaceObjectState, Dictionary<TIFactionState, float>> |
| `threatLevelCachedDate_warEnemiesOnly` | private static TIDateTime |
| `cachedThreatLevels_warEnemiesOnly` | private static Dictionary<TISpaceObjectState, Dictionary<TIFactionState, float>> |
| `cachedTypicalSTOFigherSCV` | private static float |
| `cachedTypicalSTOFigherBoostCost` | private static float |
| `typicalSTOFighterCachedDate` | private static TIDateTime |
| `typicalSTOFighter_CacheWaitTime_d` | private static float |
| `cachedFactionStrengthEstimates` | private static Dictionary<TIFactionState, float> |
| `cachedFactionStrengthEstimates_SpaceOnly` | private static Dictionary<TIFactionState, float> |
| `factionStrengthEstimatesCachedDate` | private static TIDateTime |
| `factionStrengthEstimates_CacheWaitTime_d` | private static int |
| `MAX_IDEOLOGICAL_X_DISTANCE_FOR_NAP` | public const float |
| `MAX_IDEOLOGICAL_DISTANCE_FOR_INTEL` | public const float |
| `MoneySitation` | public enum |
| `UpkeepInsecurityType` | public enum |
| `HabCapturingLogic` | public enum |

### Methods

```csharp
public static float GetAIRelativeValuation(FactionResource resource)
```

```csharp
public static void ClearStaticData()
```

```csharp
public static float FixedResourceValue(TIFactionState faction, FactionResource resource, float value, bool scale)
```

```csharp
public static float EvaluateMonthlyResourceIncome(TIFactionState faction, FactionResource resource, float value)
```

```csharp
public static float EvaluateMonthlyResourceIncome_Trade(TIFactionState faction, FactionResource resource, float quantityPerMonth, float permanence = 1f)
```

```csharp
public static int AbundantValue(FactionResource resource)
```

```csharp
public static bool Abundant(TIFactionState faction, FactionResource resource, float stockpile, bool positiveIncome, float multiplier = 1f)
```

```csharp
public static bool Abundant(TIFactionState faction, FactionResource resource, float multiplier = 1f)
```

```csharp
public static bool Deficient(TIFactionState faction, FactionResource resource, float dailyIncome, float stockpile, float thresholdValue, float campaignDuration_Years, Dictionary<FactionResource, Dictionary<TIFactionState, float>> factionIncomes)
```

```csharp
public static bool LackingBasicMissionControl(this TIFactionState faction)
```

```csharp
public static float EvaluateControlPoint(TIFactionState faction, TIControlPoint controlPoint)
```

```csharp
public static float EvaluateNation(TIFactionState faction, TINationState nation)
```

```csharp
public static TIRegionState SelectAlienCrashdownRegion(bool advance, bool makeAHole = false)
```

```csharp
public static TIRegionState SelectAlienArmyLandingRegion(bool makeAHole = false)
```

```csharp
public static float ScoreNuclearTarget(TINationState targetingNation, TIRegionState targetRegion, TINationState targetNation)
```

```csharp
public static bool IsUsefulForBoost(this TINationState nation)
```

```csharp
public static float CalculateRiskUtility(TIFactionState faction, float chanceOfSuccess)
```

```csharp
public static float EvaluateMissionTemplateUtility(TICouncilorState councilor, TIMissionTemplate mission, List<TIMissionTemplate> requiredMissions, List<TIMissionTemplate> missingRequiredMissions)
```

```csharp
public static float EvaluateOrgForCouncilor(TIOrgState org, TICouncilorState councilor, List<TIMissionTemplate> possibleMissions, List<TIMissionTemplate> requiredMissions, List<TIMissionTemplate> missingRequiredMissions, bool acquiring, Dictionary<FactionResource, float> councilorIncomes, bool chasingHydra, int factionWars, bool chasingNeutralNations, bool criticalAdminNeed = false)
```

```csharp
public static float EvaluateOrgForTrade(TIOrgState org, TIFactionState faction)
```

```csharp
public static float EvaluateTrait(TICouncilorState councilor, TIFactionState faction, TITraitTemplate trait, List<TIMissionTemplate> possibleMissions, List<TIMissionTemplate> requiredMissions, List<TIMissionTemplate> missingRequiredMissions, Dictionary<FactionResource, float> councilorIncomes, bool chasingHydra, int factionWars, bool chasingNeutralNations)
```

```csharp
public static float ScoreTraitConditionals(TICouncilorState councilor, TIFactionState faction, TITraitTemplate trait, List<TIMissionTemplate> possibleMissions, List<TIMissionTemplate> requiredMissions, List<TIMissionTemplate> missingRequiredMissions, Dictionary<FactionResource, float> councilorIncomes, bool chasingHydra, int factionWars, bool chasingNeutralNations)
```

```csharp
public static Dictionary<TICouncilorState, float> EvaluateCandidateCouncilors(TIFactionState faction, List<TIMissionTemplate> requiredMissions, List<TIMissionTemplate> missingRequiredMissions, CouncilorAttribute lackingAttribute, bool chasingHydra, int factionWars, bool chasingNeutralNations)
```

```csharp
public static float EvaluateAugmentationOption(TICouncilorState councilor, CouncilorAugmentationOption option, List<TIMissionTemplate> possibleMissions, List<TIMissionTemplate> requiredMissions, List<TIMissionTemplate> missingRequiredMissions, Dictionary<FactionResource, float> councilorIncomes, bool chasingHydra, int factionWars, bool chasingNeutralNations)
```

```csharp
public static float EvaluateStatIncreaseUtility(TICouncilorState councilor, TIFactionState faction, CouncilorAttribute attribute, int bonus, List<TIMissionTemplate> possibleMissions, List<TIMissionTemplate> requiredMissions, Dictionary<FactionResource, float> relevantIncomes, bool chasingHydra, int factionWars, bool chasingNeutralNations, bool isOrgEquipped = false)
```

```csharp
public static TIRegionState GetBestRegionsForFacilityAbductions(TIFactionState faction, TICouncilorState councilor)
```

```csharp
private static float ModifyProjectScoreForResources(TIFactionState faction, TIShipPartTemplate part)
```

```csharp
public static TITechTemplate SelectTech(TIFactionState faction, List<TITechTemplate> candidates, bool randomize)
```

```csharp
public static TIProjectTemplate SelectProject(TIFactionState faction, int slot = -1)
```

```csharp
public static TIProjectTemplate SelectProject(TIFactionState faction, List<TIProjectTemplate> candidates, bool considerDuration, bool randomize)
```

```csharp
public static int SelectTechRaceSlot(TIFactionState faction)
```

```csharp
public static int SelectPassiveTechSlot(TIFactionState faction)
```

```csharp
public static int GetHighestActiveProjectTier(TIFactionState faction)
```

```csharp
public static bool ShouldFocusOnGlobalResearch(this TIFactionState faction)
```

```csharp
public static int GetTechTier(TIGenericTechTemplate tech, TIFactionState faction)
```

```csharp
private static int RecalculateTechTier(TIGenericTechTemplate tech, TIFactionState faction)
```

```csharp
public static float ScoreProjectResourceRewardsRelativeToResearchCost(this TIProjectTemplate project, TIFactionState faction)
```

```csharp
public static bool AreProjectResourceRewardsWorthResearchCost(this TIProjectTemplate project, TIFactionState faction)
```

```csharp
public static bool ShouldSkipProject(TIProjectTemplate project, TIFactionState faction)
```

```csharp
public static bool ShouldFocusOnObjectiveProject(this TIFactionState faction, out bool hyperFocus)
```

```csharp
public static float ScoreExpandNationProject(TIFactionState faction, TIProjectTemplate project)
```

```csharp
public static int ScoreNeutralizeProject(TIFactionState faction, TIProjectTemplate project)
```

```csharp
public static float ScoreTech(TIFactionState faction, TIGenericTechTemplate tech, bool considerDuration, bool forcedFactionTech, bool shipBuilding, IEnumerable<TIMissionTemplate> availableMissions)
```

```csharp
public static float EvaluateTechForTrade(TIFactionState faction, TIGenericTechTemplate tech)
```

```csharp
public static float EvaluateHabModule_PercentChange(TIFactionState faction, TIGameState location, TIHabModuleTemplate moduleTemplate, HabPreferences preferences = null, IEnumerable<TIHabModuleTemplate> existingModules = null, Func<FactionResource, float> GetCurrentMonthlyIncome = null, bool moduleComparison = true, bool newModuleSameEverythingElse = false)
```

```csharp
public static float GetHabModuleSize(TIFactionState faction, TIGameState location, TIHabModuleTemplate moduleTemplate, IEnumerable<TIHabModuleTemplate> existingModules)
```

```csharp
public static float GetPowerModuleSize(TIFactionState faction, TIGameState location, float powerRequired)
```

```csharp
public static float GetPowerModuleSize(TIFactionState faction, TIGameState location, TIHabModuleTemplate moduleTemplate)
```

```csharp
public static float GetFarmModuleSize(TIFactionState faction, TIGameState location, TIHabModuleTemplate moduleTemplate)
```

```csharp
public static float EvaluateHabModule_Strategy(TIFactionState faction, TIGameState location, TIHabModuleTemplate moduleTemplate, HabPreferences preferences, IEnumerable<TIHabModuleTemplate> prospectiveModules)
```

```csharp
public static float EvaluateHabModule_LEO(TIFactionState faction, TIGameState location, TIHabModuleTemplate moduleTemplate, HabPreferences preferences, IEnumerable<TIHabModuleTemplate> prospectiveModules)
```

```csharp
public static float EvaluateHabModule(TIFactionState faction, TIHabState hab, TIHabModuleTemplate module, bool expansionPlanned, bool habAllowsResupply, float habSpaceCombatValue, TIHabModuleState currentConstructionModule, int iFactionShipyards, int iHabShipyards, bool upgrade, int iFarms, List<HabModuleSpecialRule> maxxedOutSpecialRules, List<TechCategory> maxxedOutTechCategories)
```

```csharp
public static float EvaluateHabSector(TIFactionState faction, TISectorState sector)
```

```csharp
public static float EvaluateHab(TIFactionState faction, TIHabState hab, bool mySectorsOnly, bool enemySectorsOnly)
```

```csharp
public static float EvaluateHabResourcesForTrade(TIFactionState faction, TIHabState hab)
```

```csharp
public static float EvaluateHabForTrade(TIFactionState faction, TIHabState hab)
```

```csharp
public static bool WillReceivingHabCauseOrWorsenDeficit(TIFactionState faction, TIHabState hab)
```

```csharp
public static bool WillLosingHabCauseOrWorsenDeficit(TIFactionState faction, TIHabState hab)
```

```csharp
public static List<TISpaceBodyState> SpaceBodiesBetween(float lowDist_AU, float highDist_AU)
```

```csharp
public static List<TINaturalSpaceObjectState> SpaceDestinationsBetween(float lowDist_AU, float highDist_AU)
```

```csharp
public static float EvaluateSpaceBody(TIFactionState faction, TISpaceBodyState body, bool considerDistance = false, bool considerGravity = false, bool considerOccupied = false)
```

```csharp
public static float GetSolarEnergyEfficiency(TINaturalSpaceObjectState spaceObject)
```

```csharp
public static bool IsEnergyEfficient(TINaturalSpaceObjectState spaceObject)
```

```csharp
public static float SpaceResourcesForShipBuild(TIFactionGoalState goal)
```

```csharp
public static bool ValidShipyardToSpendBoost(TIFactionState faction, TIHabModuleState shipyard)
```

```csharp
public static bool ShouldSpendBoostAtShipyard(TIFactionState faction, TIHabModuleState shipyard, float boost, TIFactionGoalState relatedGoal)
```

```csharp
public static bool ShouldPayTodaysBoostCost(TISpaceShipTemplate ship, TIFactionState faction, TIHabModuleState shipyard, float spaceResourcesFraction, TIFactionGoalState relatedGoal)
```

```csharp
public static bool ShouldRateLimitBoostExpenditure(TIHabModuleTemplate module, TIFactionState faction, TIGameState location)
```

```csharp
public static float GetRateLimitedBoostSpendFraction_Probe(this TIFactionState faction)
```

```csharp
public static float GetDaysToWaitForRateLimitedBoostPurchase(TIFactionState faction, float incomeFraction, float boostCost)
```

```csharp
public static float GetMaxBoostForRateLimitedBoostPurchase(TIFactionState faction, float incomeFraction, TIFactionState.BoostAccountName boostAccountName)
```

```csharp
public static bool ShouldPayRateLimitedBoostCost(TIHabModuleTemplate moduleTemplate, TIFactionState faction, TIGameState location, bool isUpgrade = false)
```

```csharp
public static bool ShouldPayRateLimitedBoostCost(float boostCost, TIFactionState faction, TIGameState location, bool isUpgrade = false)
```

```csharp
public static bool ShouldPayTodaysBoostCost(TIHabModuleTemplate habModuleTemplate, TIFactionState faction, TIGameState location, bool isUpgrade = false, int maxDaysToSave = 180)
```

```csharp
public static bool CanSaveBoostByWaiting(TIHabModuleTemplate module, TIFactionState faction, TIGameState location, bool isUpgrade = false, int maxDaysToWait = 180)
```

```csharp
public static bool ShouldNotTakeOnElectiveExpenditureRightNow(TIFactionState faction, FactionResource resource, float costPerYear)
```

```csharp
public static bool ShouldNotBuildHabModuleRightNow(TIHabModuleTemplate module, TIFactionState faction, TIGameState location)
```

```csharp
public static bool ShouldPauseHabConstruction(this TIHabState hab)
```

```csharp
public static AIEvaluators.MoneySitation GetMoneySituation(this TIFactionState faction, float spoilsValue = 0f)
```

```csharp
public static float EvaluateHabSite(TIFactionState faction, TIHabSiteState habSite, bool considerDistance = false, bool considerGravity = false, bool considerZeroes = true)
```

```csharp
public static Dictionary<FactionResource, ValueTuple<bool, bool, bool>> GetSpaceResourceIncomesChecklist(Func<FactionResource, float> GetIncomePerMonth)
```

```csharp
public static bool IsChecklistComplete([TupleElementNames(new string[]
```

```csharp
public static float EstimateFutureIncomePerMonth(TIFactionState faction, FactionResource resourceType, bool includeAvailableHabSites, bool includePendingHabSites, bool doNotDiscountLongtermIncomes = false)
```

```csharp
public static float EvaluateSpaceResourceIncomes_Strategic(Func<FactionResource, float> GetIncomePerMonth, Dictionary<FactionResource, ValueTuple<bool, bool, bool>> incomeChecklist)
```

```csharp
public static bool PassesBudgetingRules(TIFactionState faction, TIDataTemplate item, FactionResource resource, float cost, bool isPlanned, bool useSavingTargetBank = false)
```

```csharp
public static bool PassesBudgetingRules(TIFactionState faction, TIDataTemplate item, TIResourcesCost cost, bool isPlanned, bool useSavingTargetBank = false)
```

```csharp
public static bool PassesBudgetingRulesExceptExotics(TIFactionState faction, TIDataTemplate item, TIResourcesCost cost, bool isPlanned, bool useSavingTargetBank = false)
```

```csharp
public static bool PassesBudgetingRulesSansExotics(TIFactionState faction, TIDataTemplate item, TIResourcesCost cost, bool isPlanned, bool useSavingTargetBank = false)
```

```csharp
public static void ClearResourceUpkeepInsecurityCache(TIFactionState faction)
```

```csharp
public static bool IsResourceUpkeepInsecure(this TIFactionState faction, FactionResource resource, AIEvaluators.UpkeepInsecurityType upkeepInsecurityType)
```

```csharp
private static void ClearUpkeepInsecurityCache()
```

```csharp
public static IEnumerable<FactionResource> ResourcesExperiencingUpkeepInsecurity(this TIFactionState faction)
```

```csharp
public static bool HasUpkeepInsecurity(this TIFactionState faction)
```

```csharp
public static IEnumerable<FactionResource> ResourcesExperiencingUpkeepInsecurityInTheFuture(this TIFactionState faction)
```

```csharp
public static bool HasUpkeepInsecurityInTheFuture(this TIFactionState faction)
```

```csharp
public static IEnumerable<FactionResource> ResourcesExperiencingUpkeepInsecurity_Cautious(this TIFactionState faction)
```

```csharp
public static bool FuelEfficiencyMode(this TIFactionState faction)
```

```csharp
public static float GetStaticFleetFraction(this TIFactionState faction)
```

```csharp
public static float GetTargetDesiredStaticFleetFraction(TIFactionState faction)
```

```csharp
public static bool ShouldIncreaseStaticFleetFraction(this TIFactionState faction)
```

```csharp
public static IEnumerable<FactionGoal_DefendWithFleet> GetBossDefenseGoals(TIFactionState faction)
```

```csharp
public static FactionGoal_DefendWithFleet GetNextBossDefenseGoalToFortify(TIFactionState faction, List<FactionGoal_DefendWithFleet> bosses = null)
```

```csharp
public static FactionResource GetCriticalBasicSpaceResource(this TIFactionState faction)
```

```csharp
public static bool IsSpaceBodyDangerous(TISpaceBodyState spaceBody, TIFactionState faction)
```

```csharp
public static float GetYearsNeededToPayForCompleteFleet(TIFactionState faction)
```

```csharp
public static bool NeedsSpaceBootstrap(this TIFactionState faction)
```

```csharp
public static bool LaggingInSpaceEconomy(this TIFactionState faction)
```

```csharp
public static IEnumerable<TIHabModuleState> GetOrderedShipyards(TIFactionState faction)
```

```csharp
public static bool MyTurf(this TIFactionState faction, TISpaceBodyState system)
```

```csharp
public static bool IsTrespassing(this TIFactionState aggrievedFaction, TIGameState accused)
```

```csharp
public static TIObjectiveTemplate GetPrimaryHabModuleObjective(TIFactionState faction)
```

```csharp
public static bool DoesHabMatchObjectiveHabModuleRequirements(TIObjectiveTemplate objective, TIHabState hab, bool ignoreTier = false)
```

```csharp
public static bool DoesHabMatchObjectiveHabModuleRequirements(TIHabState hab, bool ignoreTier = false)
```

```csharp
public static bool FactionNeedsNewObjectiveHab(TIFactionState faction, TIObjectiveTemplate objective)
```

```csharp
public static bool FactionNeedsNewObjectiveHab(TIFactionState faction)
```

```csharp
public static bool FactionIsWorkingOnHabModuleBasedObjectives(TIFactionState faction)
```

```csharp
public static float GetEstimatedTransferTime_days(TIFactionState faction, TIOrbitState originOrbit, TIGameState destination, float acceleration_mps2, float deltaV_mps, float failureTransferTime_days = float.PositiveInfinity)
```

```csharp
public static float GetEstimatedTransferTime_days(TIFactionState faction, TISpaceBodyState origin, TISpaceBodyState destination, float acceleration_mps2, float deltaV_mps, float failureTransferTime_days = float.PositiveInfinity)
```

```csharp
public static float PrimarySystemDangerLevel(TIFactionState faction, out float threatStrength)
```

```csharp
public static bool IsPrimarySystemInPeril(TIFactionState faction)
```

```csharp
public static IEnumerable<TISpaceFleetState> GetEnemyFleetsInSystemOrSoonToArrive(TIFactionState faction, TISpaceBodyState system, float soonCutoff_days)
```

```csharp
public static bool AreEnemyFleetsInSystemOrSoonToArrive(TIFactionState faction, TISpaceBodyState system, float soonCutoff_days)
```

```csharp
public static bool IsPrimarySystemCampedOrSoonToBe(TIFactionState faction)
```

```csharp
public static bool ShouldRescuePrimarySystem(TIFactionState faction)
```

```csharp
public static float GetAdjustedFleetSuperiorityFactor(TIFactionState faction)
```

```csharp
public static float GetFleetStrengthInSystem(TIFactionState faction, TISpaceObjectState system)
```

```csharp
public static float GetPresentFleetStrengthInSystem(TIFactionState faction, TISpaceObjectState system)
```

```csharp
public static float GetThreatLevelAtLocation(TIFactionState faction, TIGameState location, bool warEnemiesOnly)
```

```csharp
public static IEnumerable<TIFactionState> GetAttackableFactions(TIFactionState faction)
```

```csharp
public static bool IsSystemContested(TIFactionState faction, TIGameState location)
```

```csharp
public static float GetRiskAdjustedThreatLevelAtLocation(TIFactionState faction, TIGameState location, bool warEnemiesOnly)
```

```csharp
public static float GetRequiredDefenseStrength(TIFactionState defender, TIFactionState attacker, float attackStrength, TIHabState defendingHab = null)
```

```csharp
public static bool IsDefenseFeasible(TIFactionState defender, TIGameState gameState, float attackStrength)
```

```csharp
public static bool IsSafeForColonization(this TIGameState gameState, TIFactionState faction, HabType habType = HabType.Any)
```

```csharp
public static bool IsSafeForColonization(this TIOrbitState orbit, TIFactionState faction)
```

```csharp
public static bool IsSafeForColonization(this TIHabSiteState habSite, TIFactionState faction)
```

```csharp
public static float GetSystemDeadliness(this TISpaceBodyState system, TIFactionState faction, HabType habType = HabType.Any)
```

```csharp
public static float GetSystemDeadlinessScoreModifier(this TISpaceBodyState system, TIFactionState faction)
```

```csharp
public static bool ShouldSystemBeInDefenseMode(TIFactionState faction, TISpaceBodyState system)
```

```csharp
public static float GetMinimumSuperiorityForSpontaniousAttack(this TIFactionState faction)
```

```csharp
public static float GetDesiredSuperiorityForSpontaniousAttack(this TIFactionState faction)
```

```csharp
public static TIHabState SelectHabToAttack(TIFactionState attackingFaction, IEnumerable<TIHabState> enemyHabs)
```

```csharp
private static IEnumerable<TIHabState> GetCriticalConstructionHabs(IEnumerable<TIHabState> habs, out IEnumerable<TIHabState> constructionHabs)
```

```csharp
public static TIHabState SelectStationToAttack(TIFactionState attackingFaction, IEnumerable<TIHabState> enemyStations, float expectedAttackStrength = -1f)
```

```csharp
public static TIHabState SelectBaseToAttack(TIFactionState attackingFaction, IEnumerable<TIHabState> enemyBases)
```

```csharp
public static TIHabState SelectHabToCapture(TIFactionState capturingFaction, TIFactionState targetFaction, IEnumerable<TIHabState> candidates = null, AIEvaluators.HabCapturingLogic capturingLogic = AIEvaluators.HabCapturingLogic.All, bool ignoreMissionControl = false)
```

```csharp
public static TIRegionSpaceFacilityState SelectSpaceFacilityToAttack(TIFactionState attackingFaction, TIFactionState targetFaction)
```

```csharp
public static TISpaceFleetState SelectFleetToAttack(TIFactionState attackingFaction, IEnumerable<TISpaceFleetState> enemyFleets, float expectedAttackStrength = -1f)
```

```csharp
public static IEnumerable<ValueTuple<TISpaceFleetState, TISpaceFleetState>> GenerateQuickAttacks(TIFactionState faction, IEnumerable<TISpaceFleetState> enemyFleets, int attackCount, Func<TISpaceFleetState, bool> MayUseFleetForAttack = null)
```

```csharp
public static TISpaceBodyState GetFutureSystem(this TIGameState state)
```

```csharp
public static bool ShouldLaunchEmergencyAttackAgainstAsset(TIFactionState actor, TIGameState enemyAsset, bool spontaneousAttack)
```

```csharp
public static void GetTypicalSTOFighterStats(out float spaceCombatValue, out float boostCost)
```

```csharp
public static float GetTypicalSTOFighterSpaceCombatValue()
```

```csharp
public static float GetTypicalSTOFighterBoostCost()
```

```csharp
public static float ScoreRelationsChange(TINationState seeker, TINationState target, RelationChange change, bool sameExecutive)
```

```csharp
public static float ScoreLeaveFederation(TINationState nation, TIFederationState federation)
```

```csharp
public static float ScoreEndAlliance(TINationState seeker, TINationState ally, bool sameExecutive, bool checkFormAllianceTest)
```

```csharp
public static float ScoreInitiateRivalry(TINationState attacker, TINationState defender, bool sameExecutive)
```

```csharp
public static float ScoreFormAlliance(TINationState seeker, TINationState potentialAlly, bool sameExecutive, bool checkEndAllianceTest)
```

```csharp
private static bool AI_NationShouldAlterBehaviorDueToAlienNationPresenceOnEarth(TINationState nation1, TINationState nation2)
```

```csharp
public static float ScoreIncreasingConflict(TINationState attacker, TINationState defender, bool sameExecutive, PolicyType policy)
```

```csharp
public static float ScoreImprovedRelations(TINationState seeker, TINationState recipient, bool sameExecutive)
```

```csharp
public static bool AlwaysEndConflict(TINationState actingNation, TINationState warNation)
```

```csharp
public static float GetAlienQuietness()
```

```csharp
public static bool ShouldAliensGoLoud()
```

```csharp
public static int GetAliensPreferredCouncilorCount()
```

```csharp
public static bool ShouldAliensXenoform()
```

```csharp
public static bool BadRegion(TINationState nation, TIRegionState region)
```

```csharp
public static bool AIWillingToJoinOffensiveAllysWar(TINationState nation, TINationState allyStartingWar, TINationState defender)
```

```csharp
public static bool AIAlliesCollectivelyWillingToJoinOffensiveWar(TINationState allyStartingWar, TINationState defender, out float offensiveAllianceStrength, out List<TINationState> prospectiveAlliance)
```

```csharp
public static bool NuclearDeterred(TIFactionState potentiallyDeterredFaction, TINationState potentiallyDeterredNation, TINationState deterringNation, int goalImportance, TIWarState war = null)
```

```csharp
public static float FactionGotoWarRequiredHate(TIFactionState faction, TIFactionState targetFaction)
```

```csharp
public static float FactionsGoToWarProgress(TIFactionState faction, TIFactionState targetFaction)
```

```csharp
public static bool FactionsGoToWar(TIFactionState factionState, TIFactionState targetFaction)
```

```csharp
public static TISpaceAssetState GetNearbySpaceAssetTarget(this TISpaceFleetState fleet)
```

```csharp
public static void OnAlienNationCreated(bool addInvasionGoal)
```

```csharp
public static bool AI_ShouldAbortBadMission(TIMissionState mission)
```

```csharp
public static bool AI_ShouldAvoidDoublingUpMissionTarget(TICouncilorState setCouncilor, TIMissionTemplate setMission, TIGameState setTarget, float setSuccessChance, TICouncilorState councilor, TIMissionTemplate missionTemplate, TIGameState target)
```

```csharp
public static void ComputeFactionStengthEstimates()
```

```csharp
public static float GetFactionStrengthEstimate(this TIFactionState faction)
```

```csharp
public static float GetRelativeHumanStrengthEstimate(this TIFactionState faction, TIFactionState otherFaction)
```

```csharp
public static TIFactionState GetStrongestHumanFaction(Func<TIFactionState, bool> Predicate = null)
```

```csharp
public static TIFactionState GetMostThreateningEnemyHumanFaction(this TIFactionState faction)
```

```csharp
public static TIFactionState GetMostThreateningWarEnemyHumanFaction(this TIFactionState faction)
```

```csharp
public static float GetFactionStrengthEstimate_SpaceOnly(this TIFactionState faction)
```

```csharp
public static bool HumanFactionTooBeatDownToContinue(TIFactionState humanAIFaction, TIFactionState enemyFaction = null)
```

```csharp
public static int GetWillingnessToTradeTruce(TIFactionState faction, TIFactionState otherFaction, bool checkOtherFaction)
```

```csharp
public static int GetWillingnessToTradeNAP(TIFactionState faction, TIFactionState otherFaction, bool checkOtherFaction)
```

```csharp
public static int GetWillingnessToShareIntel(TIFactionState AIfaction, TIFactionState otherFaction, bool checkOtherFaction, bool ignoreExistingAgreement = false)
```

```csharp
public static float GetWillingnessToTradeTreaty(TIFactionState faction, TIFactionState otherFaction, TradeOffer.TreatyType treatyType)
```
