# TINationState

*Decompiled from `PavonisInteractive/TerraInvicta/TINationState.cs`.*


## Class `TINationState`

```csharp
public class TINationState : TIPolityState
```

### Fields

| Name | Type |
|---|---|
| `isNationState` | public override bool |
| `searchable` | public override Searchable |
| `ref_nation` | public override TINationState |
| `ref_region` | public override TIRegionState |
| `ref_factions` | public override List<TIFactionState> |
| `ref_spaceBody` | public override TISpaceBodyState |
| `ref_naturalSpaceObject` | public override TINaturalSpaceObjectState |
| `ref_spaceObject` | public override TISpaceObjectState |
| `ref_faction` | public override TIFactionState |
| `hasMapObject` | public override bool |
| `hasEarthMapObject` | public override bool |
| `template` | public TINationTemplate |
| `extant` | public bool |
| `inFederation` | public bool |
| `inAlienFederation` | public bool |
| `alienAlly` | public bool |
| `isUnion` | public bool |
| `displayNameWithArticle` | public string |
| `displayNameWithArticleCapitalized` | public string |
| `nationalAdjective` | public string |
| `displayNameWithArticleAndPlacePrep` | public string |
| `flagResource` | public string |
| `abductions` | public int |
| `maxControlPointIndex` | public int |
| `atWar` | public bool |
| `belligerentInActiveWar` | public bool |
| `hasAlienFacility` | public bool |
| `unionTrigger` | public int |
| `numExtantNations` | public static int |
| `breakaway` | public bool |
| `flag` | public Sprite |
| `GDPstring` | public string |
| `getNumControlPoints` | private int |
| `getNumControlPoints_unclamped` | private int |
| `perCapitaGDP` | public float |
| `perCapitaGDPstr` | public string |
| `inequalityWarning` | public bool |
| `severeInequalityWarning` | public bool |
| `InequalityDescriptiveString` | public string |
| `EducationDescriptiveString` | public string |
| `DemocracyDescriptiveString` | public string |
| `inequalityImpactOnCohesion` | public float |
| `populationImpactOnCohesion` | public float |
| `regionsImpactOnCohesion` | public float |
| `perCapitaGDPImpactOnCohesion` | public float |
| `rivalsImpactOnCohesion` | public float |
| `warsImpactOnCohesion` | public float |
| `publicEliteDivideImpactOnCohesion` | public float |
| `publicOpinionImpactOnCohesion` | public float |
| `distanceFromCapitalToPopCenter_km_old` | public float |
| `distanceFromCapitalToPopCenter_km` | public float |
| `autocracyImpactOnCohesion` | public float |
| `anocracyImpactOnCohesion` | public float |
| `hostileClaimsImpactOnCohesion` | public float |
| `cohesionRestState` | public float |
| `CohesionRestStateDetail` | public string |
| `CohesionDescriptiveString` | public string |
| `cohesionWarning` | public bool |
| `futureMajorCohesionWarning` | public bool |
| `majorCohesionWarning` | public bool |
| `corruption` | public float |
| `elitesHappy` | public bool |
| `civilWar` | public bool |
| `futureUnrestMajorWarning` | public bool |
| `unrestWarning` | public bool |
| `unrestMajorWarning` | public bool |
| `perCapitaGDPEffectOnUnrest` | public float |
| `armyImpactOnUnrest` | public float |
| `xenoformingImpactOnUnrest` | public float |
| `unrestRestState` | public float |
| `unrestRestState_unclamped` | public float |
| `hostileClaimsImpactOnUnrest` | public float |
| `unrestRestStateDetail` | public string |
| `research_month` | public float |
| `MilitaryTechDescriptiveString` | public string |
| `standardArmies` | public List<TIArmyState> |
| `numStandardArmies` | public int |
| `numNavies` | public int |
| `numSTOFighters` | public int |
| `availableSTOFighters` | public int |
| `nationNavalScore` | public float |
| `navalFreedom` | public bool |
| `navalFreedomString` | public string |
| `allowedArmies` | public int |
| `canBuildArmy` | public bool |
| `maxNavies` | public int |
| `maxNaviesCanBuild` | public int |
| `canBuildNavy` | public bool |
| `area_km2` | public float |
| `coastalRegions` | public int |
| `resourceRegions` | public int |
| `miningRegions` | public int |
| `oilRegions` | public int |
| `colonyRegions` | public int |
| `nonColonyRegions` | public int |
| `currentResourceRegions` | public int |
| `landlocked` | public bool |
| `spaceDefenseCoverage` | public float |
| `population_Millions` | public float |
| `population` | public float |
| `annualNationalPopulationChange` | public float |
| `populationDesnity_pop_km2` | public float |
| `solarBody` | public string |
| `spaceFunding_month` | public float |
| `spaceProgramSites` | public List<TIRegionSpaceFacilityState> |
| `rawBoostPerYear_dekatons` | public float |
| `rawBoostPerMonth_dekatons` | public float |
| `missionControl` | public int |
| `currentBoost_year` | public float |
| `currentBoost_month` | public float |
| `boostIncome_year_dekatons` | public float |
| `boostIncome_month_dekatons` | public float |
| `spaceFundingIncome_year` | public float |
| `spaceFundingIncome_month` | public float |
| `currentMissionControl` | public int |
| `maxMissionControl` | public int |
| `executiveControlPoint` | public TIControlPoint |
| `numberTwoControlPoint` | public TIControlPoint |
| `executiveFaction` | public TIFactionState |
| `ControlPointMaintenanceCost` | public float |
| `MajorGlobalPower` | public bool |
| `SignificantPower` | public bool |
| `controlPointOwnersByPoint` | public List<TIGameState> |
| `NativeControlPoints` | public IEnumerable<TIControlPoint> |
| `NumNativeControlPoints` | public int |
| `NumOwnedControlPoints` | public int |
| `TotalOwningFaction` | public TIFactionState |
| `MajorityControlFaction` | public TIFactionState |
| `FactionsWithControlPoint` | public List<TIFactionState> |
| `base_consolidateExecControl_days` | public float |
| `modifiedConsolidatedExecControl_days` | public float |
| `daysUntilExecutivePowerConsolidated` | public float |
| `ExecutivePowerConsolidated` | public bool |
| `armiesAtHome` | public int |
| `deployedArmies` | public int |
| `investmentPoints_unrestPenalty_frac` | public float |
| `investmentPoints_occupationPenalty_frac` | public float |
| `ValidPriorities` | public List<PriorityType> |
| `InvalidPriorities` | public List<PriorityType> |
| `MaxAnnualDirectInvestIPs` | public int |
| `economyPriorityPerCapitaIncomeChange` | public float |
| `economyPriorityInequalityChange` | public float |
| `welfarePriorityInequalityChange` | public float |
| `environmentPrioritySustainabilityChange` | public float |
| `knowledgePriorityCohesionChange` | public float |
| `knowledgePriorityEducationChange` | public float |
| `governmentPriorityDemocracyChange` | public float |
| `unityPriorityCohesionChange` | public float |
| `unityPriorityEducationChange` | public float |
| `militaryPriorityTechLevelChange` | public float |
| `OppressionPriorityUnrestChange` | public float |
| `OppressionPriorityDemocracyChange` | public float |
| `OppressionPriorityCohesionChange` | public float |
| `spoilsPriorityMoney` | public float |
| `spoilsPriorityMoneyPerControlPoint` | public float |
| `spoilsPriorityInequalityChange` | public float |
| `spoilsPriorityDemocracyChange` | public float |
| `spoilsSustainabilityChange` | public float |
| `maxFunding_year` | public float |
| `spaceFundingPriorityIncomeChange` | public float |
| `spaceflightInitialBoost` | public float |
| `BestBoostLatitude` | public float |
| `hasAntiSpaceDefenses` | public int |
| `completeAntiSpaceDefenses` | public bool |
| `eligibleAlliances` | public List<TINationState> |
| `eligibleRivals` | public List<TINationState> |
| `eligibleEndAlliances` | public List<TINationState> |
| `eligibleEndRivalries` | public List<TINationState> |
| `candidateUnifications` | public List<TINationState> |
| `eligibleUnifications` | public List<TINationState> |
| `WarCapable` | public bool |
| `WarCapableAllies` | public List<TINationState> |
| `enemies` | public List<TINationState> |
| `currentWarStates` | public List<TIWarState> |
| `offensiveWarStates` | public List<TIWarState> |
| `defensiveWarStates` | public List<TIWarState> |
| `warsImLeading` | public List<TIWarState> |
| `offensiveWarsImLeading` | public List<TIWarState> |
| `defensiveWarsImLeading` | public List<TIWarState> |
| `nonHostileClaims` | public List<TIRegionState> |
| `adviserCommandBonus` | public float |
| `adviserScienceBonus` | public float |
| `adviserAdministrationBonus` | public float |
| `singleIdeaCap` | public float |
| `CanExist` | private bool |
| `militaryStrength` | public float |
| `controlPoints` | public List<TIControlPoint> |
| `federation` | public TIFederationState |
| `breakawayParent` | public TINationState |
| `breakaways` | public List<TINationState> |
| `adjacentNations` | private Dictionary<TINationState, TerrestrialAdjacencyType> |
| `factionUnrestAttempts` | private Dictionary<TIFactionState, int> |
| `historyCohesion` | public List<float> |
| `historyCohesionRestState` | public List<float> |
| `historyDemocracy` | public List<float> |
| `historyUnrest` | public List<float> |
| `historyUnrestRestState` | public List<float> |
| `historyInequality` | public List<float> |
| `historyGDP` | public List<double> |
| `historySpaceFunding` | public List<float> |
| `historyEducation` | public List<float> |
| `historyPopulation` | public List<float> |
| `historySustainability` | public List<float> |
| `historyBoost` | public List<float> |
| `historyMissionControl` | public List<int> |
| `historyMiltech` | public List<float> |
| `historyNukes` | public List<int> |
| `historyResearch` | public List<float> |
| `historyInvestmentPoints` | public List<float> |
| `historyPublicOpinion` | public List<Dictionary<FactionIdeology, float>> |
| `historyWarStatus` | public List<float> |
| `historyNumRegions` | public List<int> |
| `baseInvestmentPoints_month` | private float |
| `directInvestmentedIPsThisYear` | public float |
| `alienNation` | public bool |
| `aggregateNation` | public bool |
| `improveRelationsCooldowns` | public Dictionary<TINationState, TIDateTime> |
| `rivalryCooldowns` | public Dictionary<TINationState, TIDateTime> |
| `improveRelationsDeclinedUnderCurrentExecutivePair` | public List<TINationState> |
| `dateOfNewGovernment` | public TIDateTime |
| `gameStateSubjectCreated` | private bool |
| `gameTime` | private GameTimeManager |
| `_flag` | private Sprite |
| `daysOfHistoryTracking` | public const int |
| `lastIdxOfHistoryTracking` | public const int |
| `lastExecutiveChange` | public LastExecutiveChange |
| `numOilRegions_dailyCache` | public int |
| `numMiningRegions_dailyCache` | public int |
| `numCoreEconomicRegions_dailyCache` | public int |
| `restofFederationECOBonus_dailyCache` | public float |
| `cohesionRestState_dailyCache` | public float |
| `unrestRestState_dailyCache` | public float |
| `maxControlPoints` | public const int |
| `initialHumanMaxMilitaryTechLevel` | public const float |
| `maxAlienNationMilitaryTechLevel` | public const float |
| `tracker_GDPChangeReason_CurrentTrackingPeriod` | public Dictionary<TINationState.GDPChangeReason, float> |
| `tracker_GDPChangeReason_PriorTrackingPeriod` | public Dictionary<TINationState.GDPChangeReason, float> |
| `tracker_GDPChangeReason_AllTime` | public Dictionary<TINationState.GDPChangeReason, float> |
| `tracker_GDP_ByQuarter` | public Dictionary<int, float> |
| `tracker_InequalityChangeReason_CurrentTrackingPeriod` | public Dictionary<TINationState.InequalityChangeReason, float> |
| `tracker_InequalityChangeReason_PriorTrackingPeriod` | public Dictionary<TINationState.InequalityChangeReason, float> |
| `tracker_InequalityChangeReason_AllTime` | public Dictionary<TINationState.InequalityChangeReason, float> |
| `tracker_Inequality_ByQuarter` | public Dictionary<int, float> |
| `tracker_CohesionChangeReason_CurrentTrackingPeriod` | public Dictionary<TINationState.CohesionChangeReason, float> |
| `tracker_CohesionChangeReason_PriorTrackingPeriod` | public Dictionary<TINationState.CohesionChangeReason, float> |
| `tracker_CohesionChangeReason_AllTime` | public Dictionary<TINationState.CohesionChangeReason, float> |
| `tracker_Cohesion_ByQuarter` | public Dictionary<int, float> |
| `tracker_UnrestChangeReason_CurrentTrackingPeriod` | public Dictionary<TINationState.UnrestChangeReason, float> |
| `tracker_UnrestChangeReason_PriorTrackingPeriod` | public Dictionary<TINationState.UnrestChangeReason, float> |
| `tracker_UnrestChangeReason_AllTime` | public Dictionary<TINationState.UnrestChangeReason, float> |
| `tracker_Unrest_ByQuarter` | public Dictionary<int, float> |
| `tracker_EducationChangeReason_CurrentTrackingPeriod` | public Dictionary<TINationState.EducationChangeReason, float> |
| `tracker_EducationChangeReason_PriorTrackingPeriod` | public Dictionary<TINationState.EducationChangeReason, float> |
| `tracker_EducationChangeReason_AllTime` | public Dictionary<TINationState.EducationChangeReason, float> |
| `tracker_Education_ByQuarter` | public Dictionary<int, float> |
| `tracker_DemocracyChangeReason_CurrentTrackingPeriod` | public Dictionary<TINationState.DemocracyChangeReason, float> |
| `tracker_DemocracyChangeReason_PriorTrackingPeriod` | public Dictionary<TINationState.DemocracyChangeReason, float> |
| `tracker_DemocracyChangeReason_AllTime` | public Dictionary<TINationState.DemocracyChangeReason, float> |
| `tracker_Democracy_ByQuarter` | public Dictionary<int, float> |
| `tracker_PCGDP_ByQuarter` | public Dictionary<int, float> |
| `minControlPoints` | private const int |
| `maxInequality` | private const int |
| `CO2_ppm_CognitionLoss` | public const float |
| `CO2_CognitionLossRate_month` | public const float |
| `CO2_CognitionLossRate_max` | public const float |
| `GDPtoGHG` | public const double |
| `PoptoGHG` | public const double |
| `OilRegionToGHG` | public const double |
| `preIndustrialPCGDP` | public const float |
| `subsistencePCGDP` | public const float |
| `GHGPortion_CO2` | public const float |
| `GHGPortion_CH4` | public const float |
| `GHGPortion_N2O` | public const float |
| `CO2AfterUptake` | public const float |
| `CH4AfterUptake` | public const float |
| `N2OAfterUptake` | public const float |
| `_cachedBestCurrentSustainabilityValue` | private static float |
| `_bestCurrentSustainabilityFrame` | private static int |
| `baseCohesionValue` | public const float |
| `worseOffQuarters` | private const int |
| `CohesionPerPeerRival` | private const float |
| `MaxCohesionFromRivals` | private const float |
| `MaxCohesionFromWars` | private const float |
| `totalitarian` | private const float |
| `authoritarian` | private const float |
| `democratic` | private const float |
| `autocracyScaling` | private const float |
| `alienNationOnlyUnrestChangeReason` | public static readonly List<TINationState.UnrestChangeReason> |
| `baseUnrestValue` | public const float |
| `DemocracyExponent` | private const float |
| `MasterResearchMultiplier` | private const float |
| `PCGDPExponent` | private const float |
| `TwoToPCGDPExponent` | private const float |
| `cachedNavalFreedom` | private bool |
| `navalFreedomCachedFrame` | private int |
| `spaceFunding_year` | public float |
| `NationalResources` | public static readonly FactionResource[] |
| `publicOpinionToInfluenceScaler` | private const float |
| `_accumulatedInvestmentPoints` | private Dictionary<PriorityType, float> |
| `directInvest_CPMaintenanceCostFractionInfluence` | private const float |
| `directInvest_MoneyInefficiencyMultiplier` | private const float |
| `directInvest_ViceroyInfluenceModifier` | private const float |
| `directInvest_CorruptionIncreaseModifier` | private const float |
| `direct_ECO_Base_Money` | private const float |
| `direct_ECO_Influence` | private const float |
| `direct_WEL_Base_Money` | private const float |
| `direct_WEL_Influence` | private const float |
| `direct_ENV_Base_Money` | private const float |
| `direct_ENV_Influence` | private const float |
| `direct_KNO_Base_Money` | private const float |
| `direct_KNO_Influence` | private const float |
| `direct_GOV_Base_Money` | private const float |
| `direct_GOV_Influence` | private const float |
| `direct_UNI_Base_Money` | private const float |
| `direct_UNI_Influence` | private const float |
| `direct_MIL_Money` | private const float |
| `direct_MIL_Influence` | private const float |
| `direct_MIL_Ops` | private const float |
| `direct_OPP_Base_Influence` | private const float |
| `direct_OPP_Ops` | private const float |
| `direct_DEV_Influence` | private const float |
| `direct_FLI_Money` | private const float |
| `direct_FLI_Influence` | private const float |
| `direct_BOO_Money` | private const float |
| `direct_BOO_Influence` | private const float |
| `direct_MC_Money` | private const float |
| `direct_MC_Influence` | private const float |
| `direct_ARM_Money` | private const float |
| `direct_ARM_Influence` | private const float |
| `direct_ARM_Ops` | private const float |
| `direct_NAV_Money` | private const float |
| `direct_NAV_Influence` | private const float |
| `direct_NAV_Ops` | private const float |
| `direct_FMI_Money` | private const float |
| `direct_FMI_Influence` | private const float |
| `direct_FMI_Ops` | private const float |
| `direct_NUC_Money` | private const float |
| `direct_NUC_Influence` | private const float |
| `direct_NUC_Ops` | private const float |
| `direct_NUK_Money` | private const float |
| `direct_NUK_Influence` | private const float |
| `direct_NUK_Ops` | private const float |
| `direct_DEF_Money` | private const float |
| `direct_DEF_Influence` | private const float |
| `direct_DEF_Ops` | private const float |
| `direct_STO_Money` | private const float |
| `direct_STO_Influence` | private const float |
| `direct_STO_Ops` | private const float |
| `populationBaseLineForScaling` | public const int |
| `numWelfaresForDecolonizeTriggers` | public const int |
| `BadSustainabilityCutPoint` | private const float |
| `GoodSustainabililityCutPoint` | private const float |
| `numEnvironmentsToTriggerDecontaminate` | public const int |
| `PeakEducationEffectiveness` | public const float |
| `bonusEducationEffectiveness` | public const float |
| `OppressionDemocracyMinimumForLosingCohesion` | public const float |
| `maxGDPToFunding` | private const float |
| `minGDPForCoreEconomicRegion_bn` | public const float |
| `whitePeaceCohesionPenaltyModifier_attacker` | private const float |
| `whitePeaceCohesionPenaltyModifier_defender` | private const float |
| `FactionLevelRelationShipChangeCost` | public static readonly TIResourcesCost |
| `maxRegionDamageDuringRevolution` | private const float |
| `lowUnrestChangeDuringRevolution` | private const float |
| `highUnrestChangeDuringRevolution` | private const float |
| `minCohesionChangeDuringRevolution` | private const float |
| `maxCohesionChangeDuringRevolution` | private const float |
| `minInequalityChangeDuringRevolution` | private const float |
| `maxInequalityChangeDuringRevolution` | private const float |
| `maxDemocracyForOrganicCoup` | public const float |
| `minUnrestForOrganicCoup` | public const float |
| `minUnrestForRevolution` | public static readonly float |
| `maxCohesionForSecession` | public static readonly float |
| `minUnrestForSecession` | public static readonly float |
| `accessibleWarEnemy_skipWarEnemiesTRUE` | private Dictionary<TINationState, bool> |
| `accessibleWarEnemy_skipWarEnemiesFALSE` | private Dictionary<TINationState, bool> |
| `AccessibleWarEnemyCachedNavalFreedom` | private bool |
| `cachedMilitaryStrength` | private float |
| `militaryStrengthCachedFrame` | private int |
| `oldRivalsCount` | public int |
| `rareEventsProcessingFrequency_Days` | private const int |
| `Priorities` | public static readonly IEnumerable<PriorityType> |
| `GDPChangeReason` | public enum |
| `InequalityChangeReason` | public enum |
| `EducationChangeReason` | public enum |
| `DemocracyChangeReason` | public enum |
| `CohesionChangeReason` | public enum |
| `UnrestChangeReason` | public enum |

### Properties

- `public TIRegionState capital`
- `public TIRegionState originalCapital`
- `public List<TIRegionState> regions`
- `public List<TINationState> allies`
- `public List<TINationState> rivals`
- `public List<TIRegionState> claims`
- `public List<TIRegionState> hostileClaims`
- `public List<TINationState> wars`
- `public List<TIArmyState> armies`
- `public Dictionary<FactionIdeology, float> publicOpinion`
- `public int StartOfTurnNativeControlPoints`
- `public List<TICouncilorState> advisingCouncilors`
- `public int numControlPoints`
- `public int numControlPoints_unclamped`
- `public float economyScore`
- `public float missionDifficultyEconomyScore`
- `public float accumulatedLegitimizeClaimTriggers`
- `public bool canAccumulateCoreEconomyTriggers`
- `public bool canAccumulateCoreOilTriggers`
- `public bool canAccumulateCoreMiningTriggers`
- `public bool canAccumulateDecolonizeTriggers`
- `public bool canAccumulateDecontaminateTriggers`
- `public bool canAccumulateLegitimizeClaimTriggers`
- `public bool spaceFlightProgram`
- `public bool military`
- `public bool nuclearProgram`
- `public bool canBuildSpaceDefenses`
- `public bool canBuildSTOSquadrons`
- `public bool canDecontaminate`
- `public int numNuclearWeapons`
- `public float maxMilitaryTechLevel`
- `public float sustainability`
- `public bool policy_closedBorders`
- `public bool policy_noOilDevelopment`
- `public bool policy_noMineralDevelopment`
- `public bool policy_noNukes`
- `public double GDP`
- `public float inequality`
- `public float education`
- `public float democracy`
- `public float cohesion`
- `public float unrest`
- `public float militaryTechLevel`
- `public float priorityEffectPopScaling`

### Methods

```csharp
public bool WillbeUnion(int newNonColonyRegions)
```

```csharp
public override void InitWithTemplate(TIDataTemplate template)
```

```csharp
public override void PostGameStateCreateInit_OnCreationOnly_1()
```

```csharp
public static void SetAllBilaterals()
```

```csharp
public override void PostGlobalGameStateCreateInit_2()
```

```csharp
public override void PostCanvasManagerCreateInit_3()
```

```csharp
public override void PostInitializationInit_4()
```

```csharp
public override void PostAllStartUpInit_5()
```

```csharp
public void SetDataDirty()
```

```csharp
public void SetDisplayNameAndFlag()
```

```csharp
public float GetPublicOpinionOfFaction(TIFactionState faction)
```

```csharp
public float GetPublicOpinionOfFaction(FactionIdeology ideology)
```

```csharp
public float GetPublicOpinionOfFaction(TIFactionIdeologyTemplate factionIdeology)
```

```csharp
public float GetMostPopularFactionValue(bool returnUndecided)
```

```csharp
public TIFactionIdeologyTemplate GetMostPopularIdeology(bool returnUndecided)
```

```csharp
public static bool proAlienPublic(TINationState nation)
```

```csharp
public static bool fanaticProAlienPublic(TINationState nation)
```

```csharp
public static bool antiAlienPublic(TINationState nation)
```

```csharp
public static bool fanaticAntiAlienPublic(TINationState nation)
```

```csharp
public FactionIdeology GetMeanPublicOpinion()
```

```csharp
public Vector3 GetMeanPublicOpinionVector()
```

```csharp
public float GetPublicOpinionStdDv()
```

```csharp
public float PublicOpinionToMaxIdeologicalAntipathyRatio()
```

```csharp
public FactionIdeology GetMeanEliteIdeology()
```

```csharp
public Vector3 GetMeanEliteVector()
```

```csharp
public static FactionIdeology GetNearestIdeology(Vector3 ideaPoint, bool allowAlien = false, FactionIdeology disallowIdeology = FactionIdeology.None)
```

```csharp
public static float GetIdeologicalDistance(Vector3 ideaPoint1, Vector3 ideaPoint2)
```

```csharp
public static float GetIdeologicalDistance(TIFactionIdeologyTemplate ideology1, Vector3 ideaPoint)
```

```csharp
public static float GetIdeologicalDistance(TIFactionState faction1, TIFactionState faction2)
```

```csharp
public static float GetIdeologicalDistance(TIFactionIdeologyTemplate ideology1, TIFactionIdeologyTemplate ideology2)
```

```csharp
public static float GetIdeologicalDistance(FactionIdeology ideology1, FactionIdeology ideology2)
```

```csharp
public static float GetIdeologicalDistance(TIFactionIdeologyTemplate ideology1, FactionIdeology ideology2)
```

```csharp
public float GetPublicOpinionProportion(FactionIdeology ideology)
```

```csharp
public void SetInitialPublicOpinion()
```

```csharp
public bool PublicOpinionMonthlyChange(TIFactionState faction, float minDelta)
```

```csharp
public void InitializeAllTrackers()
```

```csharp
protected void FillOutPastTrackerDataForNewNation()
```

```csharp
protected void BringTrackerDataUpToDate()
```

```csharp
public void ResetPeriodicTrackers()
```

```csharp
public void UpdateDailyTrackers()
```

```csharp
public void UpdateQuarterlyTrackers()
```

```csharp
public void ModifyGDP(double value, TINationState.GDPChangeReason reason)
```

```csharp
public void GDPPctChange(float frac, TINationState.GDPChangeReason reason)
```

```csharp
public string HistoryGDPStr(int days)
```

```csharp
public float HistoryPerCapitaGDP(int days)
```

```csharp
public float PerCapitaGDPFractionOfHighest(int includedQuarters = 40)
```

```csharp
public float PerCapitaGDPFractionOfLowest(int includedQuarters = 40)
```

```csharp
public void AddToInequality(float value, TINationState.InequalityChangeReason reason)
```

```csharp
public string GetInequalityDescriptiveStringAndValue(int decimalPlaces = 1)
```

```csharp
public static float MeanAnnualGDPDamage(float tempAnomaly_C, float inequality)
```

```csharp
public void MonthlyTemperatureEconomicImpact(float tempAnomaly_C, float CO2_ppm)
```

```csharp
public Tuple<double, double, double> GHGsFromEconomy_tons(bool monthly, float proposedSustainabilityChange = 0f)
```

```csharp
public static double CO2toPPM(double input_tons)
```

```csharp
public static double CH4toPPM(double input_tons)
```

```csharp
public static double N2OtoPPM(double input_tons)
```

```csharp
public void ProcessMonthlyGHGsFromEconomy()
```

```csharp
public static string SustainabilityValueForDisplay(float sustainability)
```

```csharp
public string SustainabilityChangeForDisplay(float proposedChange)
```

```csharp
public string SustainabilityIcon()
```

```csharp
public string SustainabilityIconInlinePath()
```

```csharp
public void AddToSustainability(float value)
```

```csharp
public void SetSustainability(float value, bool clamp = true)
```

```csharp
public static float BestCurrentSustainabilityValue(bool forceUpdate)
```

```csharp
public string BestCurrentSustainabilityValueForDisplay()
```

```csharp
public void AddToEducation(float value, TINationState.EducationChangeReason reason)
```

```csharp
public string GetEducationDescriptiveStringAndValue(int decimalPlaces = 1)
```

```csharp
public void AddToDemocracy(float value, TINationState.DemocracyChangeReason reason)
```

```csharp
public string GetDemocracyDescriptiveStringAndValue(int decimalPlaces = 1)
```

```csharp
public float AddToCohesion(float value, TINationState.CohesionChangeReason reason)
```

```csharp
public float DemocracyImpactOnCohesion(float originalValue)
```

```csharp
private static string ColorCohesionRestStateValue(string formattedValue, float value)
```

```csharp
public string CohesionRestStateInlineSpritePath()
```

```csharp
public float GetMonthlyCohesionMovement()
```

```csharp
public string GetCohesionDescriptiveStringAndValue(int decimalPlaces = 1)
```

```csharp
public void AddToUnrest(float value, TINationState.UnrestChangeReason reason, float cap = 10f)
```

```csharp
public float IndividualArmyImpactOnUnrest(TIFactionState faction)
```

```csharp
private static string ColorUnrestRestStateValue(string formattedValue, float value)
```

```csharp
public float GetMonthlyUnrestMovement()
```

```csharp
public string UnrestRestStateInlineSpritePath()
```

```csharp
public string GetUnrestDescriptiveStringAndValue(int decimalPlaces = 1)
```

```csharp
public void AddToMilitaryTechLevel(float value)
```

```csharp
public void AddToMaxMilitaryTechLevel(float value)
```

```csharp
public string GetMilitaryDescriptiveStringAndValue(int decimalPlaces = 1)
```

```csharp
public void ChangeNumNuclearWeapons(int value)
```

```csharp
public string NavalFreedomStringValue(bool includeCounts)
```

```csharp
public void CacheRegionValues()
```

```csharp
public TIRegionState RandomRegionWeightedByPopulation()
```

```csharp
public void AddRegion(TIRegionState region)
```

```csharp
public void RemoveRegion(TIRegionState region)
```

```csharp
private void ChangeControlPointOwner(TIControlPoint controlPoint, ControlPointChangeCause cause, TIFactionState faction)
```

```csharp
public void ChangeControlPointOwner(int index, ControlPointChangeCause cause, TIFactionState faction = null)
```

```csharp
public TIControlPoint GetControlPoint(int index)
```

```csharp
public void RemoveControlPointFromNation(TIControlPoint controlpoint)
```

```csharp
public int CountFactionControlPointsByIdeology(FactionIdeology ideology, bool includeDisabled, bool includeDefended)
```

```csharp
public int CountFactionControlPoints(TIFactionState council, bool includeDisabled, bool includePermanentAllies, bool includeDefended)
```

```csharp
public bool FactionHasControlPoint(TIFactionState faction)
```

```csharp
public TIControlPoint GetControlPointOfType(ControlPointType cpType)
```

```csharp
public TIFactionState GetControlPointOfTypeFaction(ControlPointType cpType)
```

```csharp
public void UpdateControlPointTypes()
```

```csharp
public List<TIControlPoint> FactionControlPoints(TIFactionState faction, bool includeDisabled, bool includePermanentAllies, bool includeDefended)
```

```csharp
public float CouncilControlPointFraction(TIFactionState council, bool includeDisabled, bool includePermanentAllies)
```

```csharp
public float CouncilControlPointFraction_DiscountNeutral(TIFactionState council, bool includeDisabled, bool includePermanentAllies)
```

```csharp
public IEnumerable<TIControlPoint> EnemyControlPoints(TIFactionState faction)
```

```csharp
public TIControlPoint FirstNativeControlPoint()
```

```csharp
public TIControlPoint HighestFactionControlPoint(TIFactionState council, bool includeDefended)
```

```csharp
public TIControlPoint HighestOtherFactionControlPoint(TIFactionState council, bool includeDefended, bool requireAttackable)
```

```csharp
public TIControlPoint RandomOtherFactionControlPoint(TIFactionState council, bool includeDefended, bool requireAttackable)
```

```csharp
public TIControlPoint LowestOtherFactionControlPoint(TIFactionState filterFaction)
```

```csharp
public TIFactionState WeightedRandomFactionByControlPoints()
```

```csharp
public TIFactionState GetControlPointTypeOwner(ControlPointType controlPointType)
```

```csharp
public bool CanDisableControlPoints(TIFactionState faction)
```

```csharp
public void SelfDisableControlPoints(TIFactionState faction)
```

```csharp
public TIDateTime ExecutivePowerConsolidationDate()
```

```csharp
public void PossiblePriorityValidationChange(bool alertReset = true)
```

```csharp
public float GetInvestmentFromControlPoint()
```

```csharp
public float GetMonthlyMoneyIncomeFromControlPoint(TIFactionState faction)
```

```csharp
public float GetMonthlyBoostIncomeFromControlPoint()
```

```csharp
public int GetMissionControlFromControlPoint(int controlPointIndex)
```

```csharp
public float GetMonthlyResearchFromControlPoint(TIFactionState faction)
```

```csharp
public float GetCouncilInvestmentPointShare(TIFactionState council)
```

```csharp
public float GetFactionMissionControlFromNation(TIFactionState council, bool includeDisabled)
```

```csharp
public float GetMonthlyCouncilResourceShare(TIFactionState faction, FactionResource resourceType, bool includeInactives = false)
```

```csharp
public List<TIArmyState> GetArmiesByControlPoint(int checkControlPoint)
```

```csharp
public int GetNumArmiesAtControlPoint(int checkControlPoint)
```

```csharp
public int GetNumArmiesForFaction(TIFactionState councilState)
```

```csharp
public void AddArmy(TIArmyState army)
```

```csharp
public bool RemoveArmy(TIArmyState army)
```

```csharp
public void ClearArmies()
```

```csharp
public TIPriorityPresetTemplate PlayerSettingsMatchTemplate(int controlPointIndex, bool validate = true)
```

```csharp
public void ApplyInvestmentTemplateToControlPoint(int controlPointIndex, string investmentTemplateName)
```

```csharp
public void ApplyInvestmentTemplateToControlPoint(int controlPointIndex, TIPriorityPresetTemplate investmentTemplate)
```

```csharp
protected void SetBaseInvestmentPoints_month()
```

```csharp
public float BaseInvestmentPoints_month()
```

```csharp
public float BaseInvestmentPoints_month(TIFactionState faction)
```

```csharp
public float GetAccumulatedInvestmentPoints(PriorityType priority)
```

```csharp
public void SetAccumulatedInvestmentPoints(PriorityType priority, float value, bool triggerUpdate)
```

```csharp
public float GetInitialInvestmentPoints(PriorityType priority)
```

```csharp
public float GetRequiredInvestmentPointsForPriority(PriorityType priority)
```

```csharp
public bool ReachedInvestmentThreshhold(PriorityType priority)
```

```csharp
public float DeltaToInvestmentThreshhold(PriorityType priority)
```

```csharp
public bool ValidPriority(PriorityType priority)
```

```csharp
public float percentWeighttoPriority(PriorityType priority)
```

```csharp
public float ControlPointPriorityBonuses(TIControlPoint controlPoint, PriorityType priority, bool checkDisabled, bool ignoreDiversityBonus = false)
```

```csharp
public float ControlPointPriorityBonuses_Uncached(TIControlPoint controlPoint, PriorityType priority, bool checkDisabled)
```

```csharp
public float ControlPointWeightsTotalToPriorityIP(PriorityType priority)
```

```csharp
public float NationalPriorityBonuses(PriorityType priority)
```

```csharp
public static bool EverAllowedForDirectInvest(PriorityType priority)
```

```csharp
public bool CanDirectInvest(TIFactionState faction, PriorityType priority, out int maxAllowed)
```

```csharp
public int MaxDirectInvestIPsRemainingThisYear()
```

```csharp
public void DirectInvestment(PriorityType priority, float IPs)
```

```csharp
public bool SkipDirectInvestInfluenceCost(TIFactionState faction)
```

```csharp
public TIResourcesCost InvestmentPointDirectPurchasePrice(PriorityType priority, TIFactionState faction)
```

```csharp
public TIResourcesCost SingleDirectInvestmentPrice(PriorityType priority, int IPs, TIFactionState faction)
```

```csharp
public PriorityType GetRandomPriorityToDamage()
```

```csharp
public void ModifyAccumulatedInvestment(PriorityType priority, float by, bool multiply, bool triggerUpdate)
```

```csharp
public void ModifyAccumulatedInvestmentFractional(PriorityType priority, float fraction, bool triggerUpdate)
```

```csharp
public void ProcessPrioritySpending()
```

```csharp
public void SetPriorityEffectPopScaling()
```

```csharp
public void OnEconomyPriorityComplete()
```

```csharp
public void OnWelfarePriorityComplete()
```

```csharp
public float OneStepGHGReduction(int which = 0)
```

```csharp
public float EnvPriorityCO2Removed()
```

```csharp
public float EnvPriorityCH4Removed()
```

```csharp
public float EnvPriorityN2ORemoved()
```

```csharp
public void OnEnvironmentPriorityComplete()
```

```csharp
public void OnKnowledgePriorityComplete()
```

```csharp
public void OnGovernmentPriorityComplete()
```

```csharp
public void OnUnityPriorityComplete()
```

```csharp
public void OnMilitaryPriorityComplete()
```

```csharp
public void OnOppressionPriorityComplete()
```

```csharp
private void OnSpoilsPriorityComplete()
```

```csharp
public void OnFundingPriorityComplete()
```

```csharp
public void ChangeAnnualSpaceFundingValue(float change)
```

```csharp
public float BoostIncrease(float boostLatitude)
```

```csharp
public float BoostGainLow()
```

```csharp
public float BoostGainHigh()
```

```csharp
public void OnBoostPriorityComplete()
```

```csharp
private void OnMissionControlPriorityComplete()
```

```csharp
private void OnSpaceFlightProgramPriorityComplete()
```

```csharp
public void GrantSpaceFlightProgram()
```

```csharp
public int GetNextArmyControlPointIdx()
```

```csharp
public TIRegionState GetNextArmyRegion()
```

```csharp
private bool OnBuildArmyPriorityComplete()
```

```csharp
public TIArmyState GetNextNavy()
```

```csharp
private void OnBuildSealiftPriorityComplete()
```

```csharp
private void OnInitiateNuclearProgramComplete()
```

```csharp
public void OnBuildNuclearWeaponsPriorityComplete()
```

```csharp
public void ActivateBuildSpaceDefenses()
```

```csharp
public TIRegionState GetNextSpaceDefensesRegion()
```

```csharp
public void OnBuildSpaceDefensesPriorityComplete()
```

```csharp
public float MilitaryTechLevelOnFounding()
```

```csharp
public void OnFoundMilitaryPriorityComplete()
```

```csharp
public void ActivateBuildSTOSquadron()
```

```csharp
public List<TILaunchFacilityState> CandidateSTOSquadronRegions()
```

```csharp
public TILaunchFacilityState GetNextSTOSquadronLocation()
```

```csharp
public void OnBuildSTOSquadronPriorityComplete()
```

```csharp
public List<TIRegionState> CandidateCoreEconomicRegions()
```

```csharp
public TIRegionState GetNextCoreEcoRegion()
```

```csharp
public bool OnCoreEconomicRegionPriorityComplete(TIRegionState region)
```

```csharp
public List<TIRegionState> CandidateCoreMiningRegions()
```

```csharp
public TIRegionState GetNextCoreMiningRegion()
```

```csharp
public void OnCoreMiningRegionComplete(TIRegionState region)
```

```csharp
public List<TIRegionState> CandidateCoreOilRegions()
```

```csharp
public TIRegionState GetNextCoreOilRegion()
```

```csharp
public bool OnCoreOilRegionPriorityComplete(TIRegionState region)
```

```csharp
public List<TIRegionState> CandidateDecolonizeRegions()
```

```csharp
public TIRegionState GetNextDecolonizeRegion()
```

```csharp
public bool OnDecolonizeRegionPriorityComplete(TIRegionState region)
```

```csharp
public void ActivateCanDecontaminateRegion()
```

```csharp
public List<TIRegionState> CandidateDecontaminateRegions()
```

```csharp
public TIRegionState GetNextDecontaminateRegion()
```

```csharp
public bool OnDecontaminateRegionPriorityComplete(TIRegionState region)
```

```csharp
public List<TIRegionState> CandidateLegitimizeClaimRegions()
```

```csharp
public TIRegionState GetNextLegitimizeClaimRegion()
```

```csharp
public bool OnLegitimizeClaimPriorityComplete()
```

```csharp
public void SyncAllPriorites(int sourceIdx)
```

```csharp
public static string GetInlinePriorityIcon(PriorityType priority)
```

```csharp
public bool IsAdjacentToRegion(TIRegionState testRegion, bool IAmAnInvadingArmy)
```

```csharp
public bool IsAdjacentToNation(TINationState nation, bool IAmAnInvadingArmy)
```

```csharp
public TerrestrialAdjacencyType NationAdjacency(TINationState nation)
```

```csharp
public List<TINationState> AdjacentNations(bool IAmAnInvadingArmy)
```

```csharp
public void GenerateAdjacentNationsDictionary()
```

```csharp
public bool CanAlly(TINationState nation, bool ignoreAccess = false)
```

```csharp
public string GetFeedbackLine(string text, bool condition)
```

```csharp
public string CanAllyFeedback(TINationState nation)
```

```csharp
public bool CanRival(TINationState nation)
```

```csharp
public string CanRivalFeedback(TINationState nation)
```

```csharp
public bool IsEnemy(TINationState nation)
```

```csharp
public bool CanEndAlliance(TINationState nation)
```

```csharp
public string CanEndAllianceFeedback(TINationState nation)
```

```csharp
public bool CanEndRivalry(TINationState nation)
```

```csharp
public string CanEndRivalryFeedback(TINationState nation)
```

```csharp
public bool CanNormalize(TINationState nation)
```

```csharp
public string CanUnifyFeedback(TINationState nation)
```

```csharp
public List<TIRegionState> MyClaimsOnOtherNation(TINationState targetNation, bool includeHostile)
```

```csharp
public bool HasClaimOnOtherNation(TINationState targetNation, bool includeHostile = true)
```

```csharp
public List<TIRegionState> MyNonCapitalClaimsOnOtherNation(TINationState targetNation)
```

```csharp
public bool HasNonCapitalClaimOnOtherNation(TINationState targetNation)
```

```csharp
public List<TIRegionState> MyNonCapitalAdjacentClaimsOnOtherNation(TINationState targetNation)
```

```csharp
public bool NonCapitalAdjacentClaimsOnOtherNation(TINationState targetNation)
```

```csharp
public List<TIRegionState> ExternalClaims()
```

```csharp
public bool HasExternalClaims()
```

```csharp
public bool MyClaimOnOtherCapital(TINationState targetNation, bool originalCapital, bool includeHostile)
```

```csharp
public bool IsAtWarWith(TINationState nation)
```

```csharp
public bool IsRivalWith(TINationState nation)
```

```csharp
public bool IsAlliedWith(TINationState nation, bool includeSelf = false)
```

```csharp
public List<TIWarState> findWarsWith(TINationState nation)
```

```csharp
private void AddWar(TINationState enemy)
```

```csharp
private void RemoveWar(TINationState enemy)
```

```csharp
private void InitiateWarWithSingleEnemy(TIFactionState actingFaction, TINationState enemyNation)
```

```csharp
private void EndWarWithSingleEnemy(TIFactionState actingFaction, TINationState otherNation, bool maintainRivalry, bool teleportArmiesNow)
```

```csharp
public void SyncWarCount(TINationState enemy)
```

```csharp
public void DeclareLimitedWar(TIFactionState actingFaction, TINationState defendingNation)
```

```csharp
public float CohesionLossFromDeclaringWar(TINationState defendingNation)
```

```csharp
public void DeclareFullWar(TIFactionState actingFaction, TINationState defendingNation)
```

```csharp
public void JoinWar(TIFactionState actingFaction, TINationState ally, TIWarState war)
```

```csharp
public bool InThisWar(TIWarState war)
```

```csharp
public bool NoFederationConflictOfInterest(TINationState otherNation)
```

```csharp
public bool NoFederationConflictOfInterest(List<TINationState> otherNations)
```

```csharp
public bool AllowedWarTarget_NoRivalryCheck(TINationState targetNation, List<TINationState> warCapableAllies)
```

```csharp
public List<TINationState> ValidNewWarTargets()
```

```csharp
public bool ValidNewWarTarget(TINationState nation, bool skipRivalry = false)
```

```csharp
public string CanAttackFeedback(TINationState nation)
```

```csharp
public bool CanJoinNewWarAsAttacker(TIWarState war)
```

```csharp
public bool CanJoinExistingWarAsAttacker(TIWarState war)
```

```csharp
public bool CanJoinExistingWarAsDefender(TIWarState war)
```

```csharp
public float CohesionLossFromWhitePeace(TIWarState war)
```

```csharp
public void WhitePeace(TIFactionState actingFaction, TIWarState war, bool processCohesionChange)
```

```csharp
public static void EndFullWar(TIFactionState actingFaction, TIWarState war, bool forceArmyReturnCheck, bool processCohesionChange)
```

```csharp
public void DeclineOffensiveWar(TINationState nation, TIWarState war)
```

```csharp
public void SortWarsList()
```

```csharp
public void SortAllianceList()
```

```csharp
public void SortRivalsList()
```

```csharp
public void SetImproveRelationsCooldown(TIFactionState actingFaction, TINationState nation, int days)
```

```csharp
public bool CanImproveRelationsYet(TINationState nation)
```

```csharp
public void DeclineImproveRelations(TINationState nation)
```

```csharp
public void InitiateAlliance(TIFactionState actingFaction, TINationState newAlly)
```

```csharp
public void EndAlliance(TIFactionState actingFaction, TINationState nation)
```

```csharp
private bool AddAlly(TIFactionState actingFaction, TINationState nation, bool skipCooldown = false, bool suppressEventTrigger = false)
```

```csharp
private bool RemoveAlly(TIFactionState actingFaction, TINationState nation)
```

```csharp
private void ClearAllies()
```

```csharp
public void InitiateRivalry(TIFactionState actingFaction, TINationState nation, bool skipCooldown = false, bool skipRivalryClearDuration = false)
```

```csharp
public void EndRivalry(TIFactionState actingFaction, TINationState nation)
```

```csharp
private void AddRival(TIFactionState actingFaction, TINationState nation, bool skipCooldown = false, bool skipRivalryClearDuration = false, bool suppressEventTriggers = false)
```

```csharp
private void RemoveRival(TIFactionState actingFaction, TINationState nation)
```

```csharp
public void UpgradeRelations(TIFactionState faction, TINationState nation)
```

```csharp
public void DowngradeRelations(TIFactionState faction, TINationState nation)
```

```csharp
private void ClearRivals()
```

```csharp
public void SetClaim(TIRegionState region, bool fromSeizure, bool forceFromSeizure)
```

```csharp
public float TotalImpactFromHostileClaims()
```

```csharp
public bool HostileClaimDueToDemocracy(TINationState testNation)
```

```csharp
public bool ClaimWillBeHostile(TIRegionState region, bool ignoreCurrentNation = false)
```

```csharp
public string WillBeHostileExplanation(TIRegionState region)
```

```csharp
public void RemoveClaim(TIRegionState region)
```

```csharp
public void RemoveHostileClaim(TIRegionState region)
```

```csharp
public void FormFederation(TINationState nation)
```

```csharp
public bool CanFormFederation(TINationState nation)
```

```csharp
public string CanFormFederationFeedback(TINationState nation)
```

```csharp
public static string FailingNationsPreventingFederation(TIFederationState federation, TINationState prospectiveNation)
```

```csharp
public string CanJoinFederationFeedback(TIFederationState federation, TINationState prospectiveNation)
```

```csharp
public bool CanLeaveFederation()
```

```csharp
public string CanLeaveFederationFeedback()
```

```csharp
public void SetFederation(TIFactionState actingFaction, TIFederationState federationToJoin, bool starter = false, bool skipCooldown = false)
```

```csharp
public void LeaveFederation(TIFactionState actingFaction, bool process)
```

```csharp
public bool CanDoFactionLevelRelationshipChange(TINationState targetNation, RelationChange change)
```

```csharp
public void HandleFactionLevelRelationshipChanges(TINationState targetNation, RelationChange change)
```

```csharp
public void HandlePromptArmyOrderedToDepartDecision(TINationState challengingNation, ArmyOrderedToDepartOptions option, Prompt prompt)
```

```csharp
public bool CanAllyForRemoveArmyPrompt(TINationState nationAskingForArmiesToLeave)
```

```csharp
public bool CanDeclareWarForRemoveArmyPrompt(TINationState nationAskingForArmiesToLeave, bool justMadePeace)
```

```csharp
public List<TICouncilorState> GetCouncilorsInNation()
```

```csharp
public List<TICouncilorState> GetVisibleCouncilorsInNation(TIFactionState lookingFaction)
```

```csharp
public void AddAdvisingCouncilor(TICouncilorState councilor)
```

```csharp
public void RemoveAdvisingCouncilor(TICouncilorState councilor)
```

```csharp
public void ClearAdvisingCouncilors()
```

```csharp
public float GetAdvisingScore(CouncilorAttribute attribute)
```

```csharp
public static void GlobalPropaganda(TIFactionIdeologyTemplate factionIdeology, float strength)
```

```csharp
public static void AllFactionNationsPropaganda_PerOwnedCP(TIFactionState faction, float strength)
```

```csharp
public void PropagandaOnPop_PerOwnedCP(TIFactionIdeologyTemplate targetIdeology, float strength, int bonusCPs = 0, bool bulk = false)
```

```csharp
public void PropagandaOnPop_PerOwnedCPFraction(TIFactionIdeologyTemplate targetIdeology, float strength)
```

```csharp
public float PropagandaOnPop(TIFactionIdeologyTemplate targetIdeologyTemplate, float strength, bool bulkProcessing = false)
```

```csharp
private void PropagandaOnPop(Vector3 targetIdeaPoint, float strength, bool bulkProcessing = false)
```

```csharp
public float IncreaseUnrest(TIFactionState faction, float strength, bool capIncrease, TINationState.UnrestChangeReason reason)
```

```csharp
public void StabilizeNation(TIFactionState faction, float strength, TINationState.UnrestChangeReason reason)
```

```csharp
public int GetCouncilUnrestAttempts(TIFactionState council)
```

```csharp
public void RemoveCouncilUnrestAttempts(TIFactionState faction)
```

```csharp
public void CreditCouncilUnrestAttempts(TIFactionState council)
```

```csharp
public TIFactionState HighestUnrestContributor()
```

```csharp
public List<TIPolicyOption> availableSetPolicyOptions(bool includeCancel)
```

```csharp
public List<PolicyOptionWithTarget> AvailableSetPolicyOptionsWithTargets(bool includeCancel = false)
```

```csharp
public void ClearRelationsCooldowns()
```

```csharp
public List<int> NewGovernment(ControlPointChangeCause cause, TIFactionState retainingFaction = null)
```

```csharp
public void CheckOfferWarPostNewGovernment(bool leftFederation, TINationState federationLeader)
```

```csharp
public void GrantControlPointsToUnrestingFactions(int maxToGrant, ControlPointChangeCause cause)
```

```csharp
public void GrantControlPointOfTypeByPopularity(ControlPointType CPtype, TIFactionState interestedFaction, float rigged)
```

```csharp
public void DistributeControlPointsByPopularity_Individual(TIFactionState interestedFaction, float rigged)
```

```csharp
public void Revolution()
```

```csharp
public void ReInitializeNewNation()
```

```csharp
public void AlienNationOverthrown(List<TINationState> conqueringAlliance, TIArmyState conqueringArmy)
```

```csharp
public void Coup(TICouncilorState councilor = null, int strength = 0)
```

```csharp
public void RegimeChange(TINationState conqueringNation, List<TINationState> conqueringAlliance, TIArmyState conqueringArmy)
```

```csharp
public void RegimeChange(TINationState conqueringNation, List<TINationState> conqueringAlliance, TIFactionState conqueringFaction, bool suppressReporting = false)
```

```csharp
public float PeriodicOrganicCoupChance()
```

```csharp
public float PeriodicRevolutionChance()
```

```csharp
public float SecessionChance(float unrestMultiplier, bool organic)
```

```csharp
public void DailySecessionCheck()
```

```csharp
public bool PostUnrestSecessionCheck(TIFactionState faction, float strength, bool forceAlien = false)
```

```csharp
public void PeriodicInvoluntaryRegionTransferAwayCheck()
```

```csharp
public void Secession(TIFactionState actingFaction, TINationState newNation, List<TIRegionState> transferringRegions, TINationState liberator = null)
```

```csharp
public void ReleaseNation(TIFactionState actingFaction, TINationState newNation, bool capitalOnly)
```

```csharp
public void SetAsBreakaway(TIFactionState actingFaction, TINationState parent)
```

```csharp
public void ReleaseBreakaway(TIFactionState actingFaction, TINationState breakaway, bool amicable)
```

```csharp
public void SetCapital(TIRegionState region)
```

```csharp
private void SetNonAssignedCapital()
```

```csharp
private void Independence(TIFactionState actingFaction, TINationState sourceNationForRegions, TINationState parentNationForStats, List<TIRegionState> regions, bool amicable, bool suppressReporting, bool actingFactionForCPs, ControlPointChangeCause cause)
```

```csharp
public void AbsorbNation(TIFactionState actingFaction, TINationState joiningNationState)
```

```csharp
public void Unification(TIFactionState actingFaction, TINationState joiningNationState)
```

```csharp
public void SunderNation(TIFactionState actingFaction, TINationState sunderedNation, List<TIRegionState> candidateRegions, float breakawayChance, ControlPointChangeCause cause)
```

```csharp
public void AnnexNation(TIFactionState actingFaction, TINationState joiningNationState, bool alienNationFounded = false)
```

```csharp
public void TransferRegionsControlTo(List<TIRegionState> regions, TINationState newNation, bool destroyArmies, bool suppressReporting, bool forceDecolonize, bool autoTeleportArmies, bool skipOrgValidation = false)
```

```csharp
private void UpdatePCGDPHistoryWithTerritoryLoss(TIRegionState movingRegion)
```

```csharp
public void UpdatePCGDPHistoryWithTerritoryGain(double movingRegionPCGDP, float movingRegionPopulationInMillions)
```

```csharp
private void TransferRegionControlTo(TIRegionState region, TINationState newNation, bool destroyArmies = true, bool suppressReporting = false)
```

```csharp
public List<TIRegionState> NuclearWeaponsTargets(bool targetArmiesOnly = false)
```

```csharp
public bool AccessibleWarEnemy(TINationState potentialWar, bool skipWarEnemies)
```

```csharp
public void SetArmyAccessibilityDirty()
```

```csharp
public void ArmiesDailyUpdate()
```

```csharp
public IEnumerable<TIArmyState> MegaFaunaArmiesOnSoil()
```

```csharp
public IEnumerable<TIArmyState> MegaFaunaArmiesWeShouldAttack()
```

```csharp
public bool inSameFederation(TINationState nation)
```

```csharp
public int NumArmiesDefendingMe()
```

```csharp
public int NumArmiesDefendingMe(TIFactionState exceptFaction)
```

```csharp
public int NumNuclearWeaponsDefendingMe()
```

```csharp
public int NumNuclearWeaponsDefendingMeAgainst(TINationState target)
```

```csharp
public int NumNuclearWeaponsDefendingMeInWar(TIWarState war)
```

```csharp
public int NumNuclearWeaponsThreateningMeInWars()
```

```csharp
public float DefensiveAllianceMilitaryStrength()
```

```csharp
public List<TINationState> ProspectiveOffensiveAlliance(TINationState enemy, bool includeSelf = false)
```

```csharp
public float OffensiveAllianceProspectiveMilitaryStrength(TINationState enemy, bool includeSelf = false)
```

```csharp
public TINationState DefensiveAllianceProspectiveWarLeader()
```

```csharp
public List<TIArmyState> CurrentWarAllianceArmies(TINationState enemy)
```

```csharp
public int iCurrentWarAllianceArmies(TINationState enemy)
```

```csharp
public List<TINationState> CurrentWarAllies(TINationState enemy, bool includeSelf)
```

```csharp
public List<TINationState> CurrentWarAllies_AllWars()
```

```csharp
public static float CurrentWarAllianceMilitaryStrength(TINationState baseNation, TINationState enemy)
```

```csharp
public bool WinningWarAgainst(TINationState enemy)
```

```csharp
public int EnemyArmiesOnMyTerritory_NoMegafauna()
```

```csharp
public int ArmiesThreateningCapital(bool includeThoseinBattleWithArmies, bool capitalOnly = false)
```

```csharp
public float WinningWarBy(TINationState enemy)
```

```csharp
public float AssessOverallWarStatus()
```

```csharp
internal void DailyNationUpdate()
```

```csharp
private void DebugAllies()
```

```csharp
public void UpdateControlPointStatus()
```

```csharp
private void UpdateControlPoints(TIFactionState grantToCouncil = null, bool suppressReporting = false)
```

```csharp
public void UpdateNativeControlPointsCount()
```

```csharp
public void UpdateArmiesControllingFactions()
```

```csharp
internal void MonthlyNationUpdate(float eyes)
```

```csharp
internal void QuarterlyNationUpdate()
```
