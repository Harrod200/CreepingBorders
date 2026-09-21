# TIGlobalConfig

*Decompiled from `TIGlobalConfig.cs`.*


## Class `TIGlobalConfig`

```csharp
public class TIGlobalConfig : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `globalConfig` | public static TIGlobalConfig |
| `AlienInnerSystemExoticAttacksAreActive` | public static bool |
| `globalName` | public static string |
| `difficulties` | public const int |
| `invertDiffCap` | public const int |
| `requiredInvestmentPoints` | private Dictionary<PriorityType, float> |
| `xenoformingAttributeBonusDifficultyScaling` | private Dictionary<int, float> |
| `abductionMissionBonusDifficultyScaling` | private Dictionary<int, float> |
| `AI_HumanShipbuildingCostDifficultyScaling` | private Dictionary<int, float> |
| `AI_AlienShipbuildingCostDifficultyScaling` | private Dictionary<int, float> |
| `consolidationRequiredExecChange` | public List<ControlPointChangeCause> |
| `canvasesToLoad` | public string[] |
| `skirmishCanvasesToLoad` | public string[] |
| `terminalKeyCode` | public int |
| `quotes` | public int |
| `creditsEntries` | public int |
| `numberOfLoadingScreenTips` | public int |
| `strategyLayerSpeedSettings` | public List<int> |
| `combatLayerSpeedSettings` | public List<int> |
| `diff_initialCouncilorsFavoredStat` | public bool |
| `controlPointMaintenanceFreebies` | public int |
| `controlPointBonusMaintenanceFreebiesPerRemovedFaction` | public int |
| `spaceMineFreebies` | public int |
| `dontStopBimonthlyMissions` | public bool |
| `useSiteNameWhenNamingBases` | public bool |
| `researchSpeedSliderMax` | public int |
| `controlPointFreebieSliderMax` | public int |
| `controlPointAIFreebieSliderMax` | public int |
| `missionControlFreebieSliderMax` | public int |
| `missionControlAIFreebieSliderMax` | public int |
| `miningProductivitySliderMax` | public int |
| `alienProgressionRateSliderMax` | public int |
| `miningRateSliderMax` | public int |
| `habConstructionSpeedSliderMax` | public int |
| `shipConstructionSpeedSliderMax` | public int |
| `IPMultiplierSliderMax` | public int |
| `randomEventsPerMonthSliderMax` | public int |
| `defaultRandomEventsPerMonth` | public int |
| `pointsPerCPSliderTick` | public int |
| `pointsPerMCSliderTick` | public int |
| `defaultMiningProductivity` | public int |
| `defaultSpaceBodyCapForMiningProductivityBonus` | public int |
| `defaultDisableFactionValue` | public bool |
| `immediateNewsAlert` | public bool |
| `verboseStatDescriptions` | public bool |
| `initialMaxOrgsAvailableToCouncil` | public int |
| `ExcessMCToMoneyConversion_Day` | public float |
| `ExcessMCToResearchConversion_Day` | public float |
| `maxFactionOrgPoolSize` | public int |
| `atrocityPOMultiplier` | public float |
| `maxFactionCouncilorCandidatePool` | public int |
| `maxFactionCouncilorCandidatePoolVariance` | public int |
| `allowNegativeInfluenceBaseIncome` | public bool |
| `chanceCouncilorTemplate` | public float |
| `maxCouncilorAttribute` | public int |
| `characterGenRegionCoreEcoModifier` | public float |
| `characterGenRegionHighEducationModifer` | public float |
| `characterGenRegionHighEducationThreshhold` | public float |
| `characterGenRegionVeryHighEducationModifier` | public float |
| `characterGenRegionVeryHighEducationThreshhold` | public float |
| `alienShockTroopOrgDataName` | public string |
| `antiAffinityCouncilorRecruitCost_influence` | public int |
| `baseCouncilorRecruitCost_influence` | public int |
| `affinityCouncilorRecruitCost_influence` | public int |
| `skipCouncilorInfluenceBonus` | public int |
| `monthsOfDetectionDefenseAfterRecruiting` | public int |
| `postRecruitingDetectionDefenseMultiplier` | public float |
| `alienDetectionBonusCapFromLEOHabs` | public float |
| `humanDetectionBonusCapFromLEOHabs` | public float |
| `councilorMaxOrgs` | public int |
| `XPToLevelUp` | public int |
| `initialXPPerYearAge` | public int |
| `minAgeForXPBonus` | public int |
| `HighUnrestDefinition` | public float |
| `additivePerModifierCap` | public int |
| `sellOrgDiscount` | public float |
| `transferOrgCostMultiplier` | public float |
| `priority_ECO` | public float |
| `priority_WEL` | public float |
| `priority_ENV` | public float |
| `priority_KNO` | public float |
| `priority_DEM` | public float |
| `priority_UNI` | public float |
| `priority_MIL` | public float |
| `priority_OPP` | public float |
| `priority_SPO` | public float |
| `priority_DEV` | public float |
| `priority_BOO` | public float |
| `priority_MC` | public float |
| `priority_FLI` | public float |
| `priority_FMI` | public float |
| `priority_ARM` | public float |
| `priority_NAV` | public float |
| `priority_NUC` | public float |
| `priority_NUK` | public float |
| `priority_DEF` | public float |
| `priority_STO` | public float |
| `numEcosForCoreEcoRegion` | public int |
| `numEcosForCoreMiningRegion` | public int |
| `numEcosForCoreOilRegion` | public int |
| `numPrioritiesForLegitimize` | public int |
| `nationalInvestmentArmyFactorHome` | public float |
| `nationalInvestmentArmyFactorAway` | public float |
| `nationalInvestmentNavyFactor` | public float |
| `maxMonthlyCohesionIncrease_normal` | public float |
| `maxMonthlyCohesionDecrease_normal` | public float |
| `maxMonthlyCohesionDecrease_cap` | public float |
| `maxMonthlyUnrestMovement_normal` | public float |
| `maxMonthlyUnrestMovement_rapidIncrease` | public float |
| `democracyDecreaseToMakeHostileClaim` | public float |
| `maxCombinedImpactFromHostileClaims` | public float |
| `fullQuarterlyTracking` | public bool |
| `badInequality` | public float |
| `severeInequality` | public float |
| `cohesionImpactPerKMtoPopCenter` | public float |
| `maxDistanceImpactOnCohesion` | public float |
| `cohesionImpactMultiplierIfSeparatistMovement` | public float |
| `inequalityCohesionMultiplier` | public float |
| `populationCohesionImpactPower` | public float |
| `publicEliteIdeologicalDistanceCohesionMultiplier` | public float |
| `publicOpinionDispersionCohesionMultiplier` | public float |
| `controlPointCountScaling` | public float |
| `controlPointScalingDivisor` | public float |
| `controlPointIPScaling` | public float |
| `controlPointIPFactor` | public float |
| `controlPointCostScaling` | public float |
| `controlPointMaintenanceDivisor` | public float |
| `populationBasedIPEffectScaling` | public float |
| `coreMineralBuildMilitaryModifier` | public float |
| `federationGDPEconomyBonus` | public float |
| `fedLeaderDemocracyScoreToLeaveFederationFreely` | public float |
| `coreEcoRegionGDPModifier` | public float |
| `coreResourceRegionGDPModifier` | public float |
| `colonyRegionGDPModifier` | public float |
| `minMilitaryTechLevel` | public float |
| `minControlPointsForNavy` | public int |
| `minControlPointsForNavyException` | public int |
| `PCGDPForNavyException` | public float |
| `minPopulationForFirstArmy_millions` | public float |
| `minPopulationForAdditionalArmiesPer_millions` | public float |
| `economyPriorityPerCapitaIncomeChange_base` | public float |
| `economyPriorityPerCapitaIncomeChange_perCoreEcoRegion` | public float |
| `economyPriorityPerCapitaIncomeChange_perResourceRegion` | public float |
| `economyPriorityInequalityIncrease` | public float |
| `economyPriorityInequalityIncrease_perResourceRegion` | public float |
| `welfarePriorityInequalityChange` | public float |
| `environmentPrioritySustainabilityChange` | public float |
| `knowledgePriorityEducationIncrease` | public float |
| `governmentPriorityDemocracyIncrease` | public float |
| `militaryPriorityMiltechIncrease` | public float |
| `oppressionPriorityUnrestMultiplier` | public float |
| `oppressionPriorityDemocracyDecrease` | public float |
| `conditionalOppressionPriorityCohesionDecrease` | public float |
| `boostPriorityIncreaseAtEquator` | public float |
| `boostLatitudeDivisor` | public float |
| `fundingPriorityBaseIncomeIncrease` | public float |
| `spoilsPriorityMoneyPerInvestmentPoint` | public float |
| `spoilsPriorityMoneyPerResourceRegion` | public float |
| `spoilsDemocracyMoneyModifier` | public float |
| `spoilsPriorityBaseInequalityChange` | public float |
| `spoilsPriorityInequalityChange_perResourceRegion` | public float |
| `spoilsPriorityDemocracyChange` | public float |
| `spoilsPrioritySustainabilityChange` | public float |
| `spoilsPrioritySustainabilityChange_perResourceRegion` | public float |
| `spoilsPriorityPublicOpinionScaling` | public float |
| `unityPublicOpinionBaseStrength` | public float |
| `unityPriorityEducationChange` | public float |
| `unityBaseCohesionChange` | public float |
| `unityMinCohesionChange` | public float |
| `DI_baseInvestmentPointCost_Influence` | public float |
| `DI_perControlPointIPMultiplier_Influence` | public float |
| `maxInvestmentPointDiscountfromControlPoints` | public float |
| `daysOfFreeDirectInvestAfterRegimeChange` | public float |
| `nationalDirectInvestmentCapGlobalMultiplier` | public float |
| `LEOHabModulePriorityBonusCap` | public float |
| `minGDPFracIncreaseFromFederation` | public float |
| `maxGDPFracIncreaseFromFederation` | public float |
| `minInequalityIncreaseFromFederation` | public float |
| `maxInequalityIncreaseFromFederation` | public float |
| `prohibitCapitalShenanigans` | public bool |
| `inequalityHitFromResourceOrColonyAnnexation` | public float |
| `cohesionHitFromRegionAnnexation` | public float |
| `corporationsOrgMoneyDiscount` | public float |
| `tradeUnionsOrgInfluenceDiscount` | public float |
| `aristoracySpoilsMult` | public float |
| `defenseSectorArmyBuff` | public float |
| `religionUnityPublicOpinionBonusStrength` | public int |
| `extractiveSpoilsBonusPerResourceRegion` | public float |
| `defenseSectorHealBonus` | public float |
| `financialSectorFundingBonus` | public float |
| `knowledgeSectorResearchBonus` | public float |
| `globalEnergyCrisisBaseGDPLoss` | public float |
| `globalEnergyCrisisBaseInequalityGain` | public float |
| `globalEnergyCrisisOilRegionGDPGain` | public float |
| `improveRelationsCooldown_ImprovementDeclined_d` | public int |
| `improveRelationsCooldown_EndAlliance_d` | public int |
| `improveRelationsCooldown_FormRivalry_d` | public int |
| `newRivalryCohesionPenaltyWindow_d` | public int |
| `improveRelationsCooldown_LeaveFederation_d` | public int |
| `improveRelationsCooldown_Independence_d_amicable` | public int |
| `improveRelationsCooldown_Independence_d_nonAmicable` | public int |
| `improveRelationsCooldown_EndRivalry_d` | public int |
| `improveRelationsCooldown_FormAlliance_d` | public int |
| `improveRelationsCooldown_JoinFederation_d` | public int |
| `consolidateExecControl_d` | public float |
| `consolidateExecControl_perCP` | public float |
| `smallRegionDefinition_km2` | public float |
| `looseNukeFromRevolutionChancePerNuke` | public float |
| `selfDisableControlPointDuration_months` | public int |
| `maxArmyCombatBonusFromLEOHabs` | public float |
| `baseCohesionLossWhenDeclaringWarOnNewRival` | public float |
| `maxCohesionLossWhenDeclaringWarOnRival` | public float |
| `cohesionGainFromDeclaringWarOnOldRival` | public float |
| `cohesionGainFromBeingTargetOfWar` | public float |
| `cohesionGainFromAnsweringAllyCallToDefensiveWar` | public float |
| `cohesionGainFromAnsweringAllyCallToOffensiveWar` | public float |
| `basePassiveDemocracyIncreaseFromNeighbor` | public float |
| `SpoCO2_ppm` | public float |
| `SpoCH4_ppm` | public float |
| `SpoN2O_ppm` | public float |
| `SpoResCO2_ppm` | public float |
| `SpoResCH4_ppm` | public float |
| `SpoResN2O_ppm` | public float |
| `WelCO2_ppm` | public float |
| `WelCH4_ppm` | public float |
| `WelN2O_ppm` | public float |
| `occupationSpeed` | public float |
| `battleDamageEffectivenessFactor` | public float |
| `localDefensesDamageEffectivenessFactor` | public float |
| `ruggedTerrainDefenseBonus` | public float |
| `coreEconomicRegionDefenseBonus` | public float |
| `baseRegionDefenseBonus` | public float |
| `armyRegionDefenseBonus` | public float |
| `armyCrackdownMalus` | public float |
| `adjacentFriendlyForcesRegionMiltechMultiplier` | public float |
| `defenseCohesionMultiplier` | public float |
| `defenseUnrestMultiplier` | public float |
| `armyStrengthToLiberate` | public float |
| `SuezCanalRegion` | public string |
| `PanamaCanalRegion` | public string |
| `TurkishStraitsRegion` | public string |
| `habDefensesPDDPSMultiplier` | public float |
| `regionDefensesPDAMultiplier_Self` | public float |
| `regionDefensesPDAMultiplier_Region` | public float |
| `first20ExtraProjectBonusPct` | public float |
| `second20ExtraProjectBonusPct` | public float |
| `overageExtraProjectBonusPct` | public float |
| `researchBonusPerSlotInUse` | public float |
| `categoryBonusPenaltyPerExtraSlot` | public float |
| `passiveTechInvestment_C` | public float |
| `passiveTechInvestment_N` | public float |
| `passiveTechInvestment_V` | public float |
| `passiveTechInvestment_B` | public float |
| `activeTechInvestment_C` | public float |
| `activeTechInvestment_N` | public float |
| `activeTechInvestment_V` | public float |
| `activeTechInvestment_B` | public float |
| `initialMaxAllowedResourceSteps` | public int |
| `TIMissionModifier_TargetNationGDP_Multiplier` | public float |
| `TIMissionModifier_DisabledControlPoint` | public float |
| `TIMissionModifier_AdditionalDisabledControlPoints` | public float |
| `TIMissionModifier_DefendedAsset` | public float |
| `TIMissionModifier_AliensRemoved_Scaling` | public float |
| `TIMissionModifier_NationalRivalries_Multiplier` | public float |
| `TIMissionModifier_ControlPointOverage_Multiplier` | public float |
| `TIMissionModifier_DefendedAssetConditionalAliens` | public float |
| `TIMissionModifier_NationEconomyPower` | public float |
| `TIMissionModifier_OrgDefenses` | public float |
| `TIMissionModifier_NationalIndustries` | public float |
| `maxValueFromAttackerAdjacentControlPoints` | public float |
| `MaxSabotageProjectRPDamage` | public float |
| `MaxSabotageProjectAccumulatedHit` | public float |
| `missionMoneyMultiplier` | public float |
| `basePropagandaStrength` | public float |
| `maxLEOHabPropagandaStrengthBonus` | public float |
| `exoticsFromAlienFacilityRaid` | public float |
| `abductionsCancelledFactorOnFacilityAssault` | public float |
| `maxAbductionMissionImpact` | public float |
| `enthrallElitesBySizeMultiplier` | public float |
| `defendInterestPerCPDuration_days` | public int |
| `defendInterestDistributableDuration_days` | public int |
| `alienNationDataName` | public string |
| `alienMasterProject` | public string |
| `alienAdvancedMasterProject` | public string |
| `globalAbductionsThreshhold_Higher` | public int |
| `globalAbductionsThreshhold_Lower` | public int |
| `influenceGainFromAbductions` | public float |
| `moneyGainFromAbductions_Success` | public float |
| `moneyGainFromAbductions_CriticalSuccess` | public float |
| `influenceGainFromEnthrallPublic` | public float |
| `moneyGainFromEnthrallPublic_Success` | public float |
| `moneyGainFromEnthrallPublic_CriticalSuccess` | public float |
| `daysToFieldArmyFromUFO` | public int |
| `daysToPrepareFullArmyFromUFO` | public int |
| `alienArmyTechCap` | public float |
| `alienArmyTechLevel` | public float |
| `alienArmyTechFromAbductions` | public float |
| `alienArmiesFromLanding` | public int |
| `AI_invaderArmiesLostBeforeBuildup` | public int |
| `extraYearsToDelayAlienInvasion_C` | public int |
| `extraYearsToDelayAlienInvasion_N` | public int |
| `extraYearsToDelayAlienInvasion_V` | public int |
| `extraYearsToDelayAlienInvasion_B` | public int |
| `yearsBeforeAlienTotalWarAllowed_C` | public int |
| `yearsBeforeAlienTotalWarAllowed_N` | public int |
| `yearsBeforeAlienTotalWarAllowed_V` | public int |
| `yearsBeforeAlienTotalWarAllowed_B` | public int |
| `yearsBeforeAlienAdvancedTech_C` | public int |
| `yearsBeforeAlienAdvancedTech_N` | public int |
| `yearsBeforeAlienAdvancedTech_V` | public int |
| `yearsBeforeAlienAdvancedTech_B` | public int |
| `useAlternateTriggersForAlienAdvancedTech_C` | public bool |
| `useAlternateTriggersForAlienAdvancedTech_N` | public bool |
| `useAlternateTriggersForAlienAdvancedTech_V` | public bool |
| `useAlternateTriggersForAlienAdvancedTech_B` | public bool |
| `yearsBeforeAlienInnerSystemExoticAttacks_C` | public int |
| `yearsBeforeAlienInnerSystemExoticAttacks_N` | public int |
| `yearsBeforeAlienInnerSystemExoticAttacks_V` | public int |
| `yearsBeforeAlienInnerSystemExoticAttacks_B` | public int |
| `yearsBeforeInnerSystemOffensives_C` | public int |
| `yearsBeforeInnerSystemOffensives_N` | public int |
| `yearsBeforeInnerSystemOffensives_V` | public int |
| `yearsBeforeInnerSystemOffensives_B` | public int |
| `steadyAlienHateGainModifier_C` | public float |
| `steadyAlienHateGainModifier_N` | public float |
| `steadyAlienHateGainModifier_V` | public float |
| `steadyAlienHateGainModifier_B` | public float |
| `alienReducedWarAttacks_C` | public bool |
| `alienReducedWarAttacks_N` | public bool |
| `alienReducedWarAttacks_V` | public bool |
| `alienReducedWarAttacks_B` | public bool |
| `alienMaxExtraWarAttacks_C` | public int |
| `alienMaxExtraWarAttacks_N` | public int |
| `alienMaxExtraWarAttacks_V` | public int |
| `alienMaxExtraWarAttacks_B` | public int |
| `alienStartingHateMaxmum_C` | public float |
| `alienStartingHateMaxmum_N` | public float |
| `alienStartingHateMaxmum_V` | public float |
| `alienStartingHateMaxmum_B` | public float |
| `alienHateMaximumIncreasePerYear_C` | public float |
| `alienHateMaximumIncreasePerYear_N` | public float |
| `alienHateMaximumIncreasePerYear_V` | public float |
| `alienHateMaximumIncreasePerYear_B` | public float |
| `alienCallOffWarAttacksThreshold_C` | public float |
| `alienCallOffWarAttacksThreshold_N` | public float |
| `alienCallOffWarAttacksThreshold_V` | public float |
| `alienCallOffWarAttacksThreshold_B` | public float |
| `alienHateReprieveAfterKnockdown_C` | public float |
| `alienHateReprieveAfterKnockdown_N` | public float |
| `alienHateReprieveAfterKnockdown_V` | public float |
| `alienHateReprieveAfterKnockdown_B` | public float |
| `TIMissionModifier_XenoformingAttributeBonus_DifficultyScaling_C` | public float |
| `TIMissionModifier_XenoformingAttributeBonus_DifficultyScaling_N` | public float |
| `TIMissionModifier_XenoformingAttributeBonus_DifficultyScaling_V` | public float |
| `TIMissionModifier_XenoformingAttributeBonus_DifficultyScaling_B` | public float |
| `TIMissionModifier_AbductionValueScaling_C` | public float |
| `TIMissionModifier_AbductionValueScaling_N` | public float |
| `TIMissionModifier_AbductionValueScaling_V` | public float |
| `TIMissionModifier_AbductionValueScaling_B` | public float |
| `maxAlienBaseGoals_C` | public int |
| `maxAlienBaseGoals_N` | public int |
| `maxAlienBaseGoals_V` | public int |
| `maxAlienBaseGoals_B` | public int |
| `extraMaxAlienBaseGoals_TotalWarEra_C` | public int |
| `extraMaxAlienBaseGoals_TotalWarEra_N` | public int |
| `extraMaxAlienBaseGoals_TotalWarEra_V` | public int |
| `extraMaxAlienBaseGoals_TotalWarEra_B` | public int |
| `AI_AlienHatePerMCUtilitizedMultiplier_C` | public float |
| `AI_AlienHatePerMCUtilitizedMultiplier_N` | public float |
| `AI_AlienHatePerMCUtilitizedMultiplier_V` | public float |
| `AI_AlienHatePerMCUtilitizedMultiplier_B` | public float |
| `AI_MissionAttackerBonus_C` | public float |
| `AI_MissionAttackerBonus_N` | public float |
| `AI_MissionAttackerBonus_V` | public float |
| `AI_MissionAttackerBonus_B` | public float |
| `AI_MissionDefenderBonus_C` | public float |
| `AI_MissionDefenderBonus_N` | public float |
| `AI_MissionDefenderBonus_V` | public float |
| `AI_MissionDefenderBonus_B` | public float |
| `AI_GangUpOnLeaderMinimumIdeologicalDistance_C` | public float |
| `AI_GangUpOnLeaderMinimumIdeologicalDistance_N` | public float |
| `AI_GangUpOnLeaderMinimumIdeologicalDistance_V` | public float |
| `AI_GangUpOnLeaderMinimumIdeologicalDistance_B` | public float |
| `AI_BonusMissionControl_C` | public float |
| `AI_BonusMissionControl_N` | public float |
| `AI_BonusMissionControl_V` | public float |
| `AI_BonusMissionControl_B` | public float |
| `AI_BonusCPCap_C` | public float |
| `AI_BonusCPCap_N` | public float |
| `AI_BonusCPCap_V` | public float |
| `AI_BonusCPCap_B` | public float |
| `AI_AlienExoticMultiplier_C` | public float |
| `AI_AlienExoticMultiplier_N` | public float |
| `AI_AlienExoticMultiplier_V` | public float |
| `AI_AlienExoticMultiplier_B` | public float |
| `AI_AlienEarthFleetSizeModifier_C` | public float |
| `AI_AlienEarthFleetSizeModifier_N` | public float |
| `AI_AlienEarthFleetSizeModifier_V` | public float |
| `AI_AlienEarthFleetSizeModifier_B` | public float |
| `AI_AlienEarthFleetExcessModifier_C` | public float |
| `AI_AlienEarthFleetExcessModifier_N` | public float |
| `AI_AlienEarthFleetExcessModifier_V` | public float |
| `AI_AlienEarthFleetExcessModifier_B` | public float |
| `AI_AlienSurveillanceDelayModifier_C` | public float |
| `AI_AlienSurveillanceDelayModifier_N` | public float |
| `AI_AlienSurveillanceDelayModifier_V` | public float |
| `AI_AlienSurveillanceDelayModifier_B` | public float |
| `AI_AlienQuiescence_C` | public float |
| `AI_AlienQuiescence_N` | public float |
| `AI_AlienQuiescence_V` | public float |
| `AI_AlienQuiescence_B` | public float |
| `AI_WormholeSetupSpeed_C` | public float |
| `AI_WormholeSetupSpeed_N` | public float |
| `AI_WormholeSetupSpeed_V` | public float |
| `AI_WormholeSetupSpeed_B` | public float |
| `Diff_ExoticsSalvageRate_C` | public float |
| `Diff_ExoticsSalvageRate_N` | public float |
| `Diff_ExoticsSalvageRate_V` | public float |
| `Diff_ExoticsSalvageRate_B` | public float |
| `minAbductionsinRegionForFacility` | public int |
| `monthlyChanceAbductionPerSurveillanceHabEye` | public float |
| `increaseAlienMaxAttackFleetStrengthRatioOverTime_C` | public float |
| `increaseAlienMaxAttackFleetStrengthRatioOverTime_N` | public float |
| `increaseAlienMaxAttackFleetStrengthRatioOverTime_V` | public float |
| `increaseAlienMaxAttackFleetStrengthRatioOverTime_B` | public float |
| `initialMaxAlienAttackFleetStrengthRatio_C` | public float |
| `initialMaxAlienAttackFleetStrengthRatio_N` | public float |
| `initialMaxAlienAttackFleetStrengthRatio_V` | public float |
| `initialMaxAlienAttackFleetStrengthRatio_B` | public float |
| `yearsToDelayAlienMiddleColonization_C` | public float |
| `yearsToDelayAlienMiddleColonization_N` | public float |
| `yearsToDelayAlienMiddleColonization_V` | public float |
| `yearsToDelayAlienMiddleColonization_B` | public float |
| `alienNonPlanetaryOuterSystemColonizationLimit_C` | public int |
| `alienNonPlanetaryOuterSystemColonizationLimit_N` | public int |
| `alienNonPlanetaryOuterSystemColonizationLimit_V` | public int |
| `alienNonPlanetaryOuterSystemColonizationLimit_B` | public int |
| `size5Project` | public string |
| `size6Project` | public string |
| `intelToSeeNeutralPawn` | public float |
| `intelToSeeCouncilorBasicData` | public float |
| `intelToSeeCouncilorDetails` | public float |
| `intelToSeeCouncilorMission` | public float |
| `intelToSeeCouncilorSecrets` | public float |
| `myCouncilorBaselineIntel` | public float |
| `intelToSeeFactionBasicData` | public float |
| `intelToSeeFactionObjectives` | public float |
| `intelToSeeFactionProjects` | public float |
| `intelToSeeFactionResources` | public float |
| `intelToSeeFactionUnassignedOrgs` | public float |
| `myFactionBaselineIntel` | public float |
| `humanSpaceAssetBaselineIntel` | public float |
| `humanMySpaceAssetBaselineIntel` | public float |
| `alienSpaceAssetBaselineIntel` | public float |
| `alienMySpaceAssetBaselineIntel` | public float |
| `intelToSeeSpaceAssetLocationandComposition` | public float |
| `intelToSeeFleetShipDetails` | public float |
| `intelToSeeSpaceAssetUndercoverEnemyCouncilors` | public float |
| `baselineAlienAssetDetectionRange_AU` | public float |
| `totalSystemDetection_AU` | public float |
| `factionHateForHabAssaultOperationPerTier` | public float |
| `factionHateForHabDestructionOperationPerTier` | public float |
| `factionHateMultiplierPerModuleDestroyedPerTier` | public float |
| `factionHateForDestroyingArmyOutsideofWar` | public float |
| `factionHateSIFactorPerShipDestroyed` | public float |
| `factionHateForDeclaringWarCPMultiplier` | public float |
| `factionHateForInitiatingBombardment_AnyTarget` | public float |
| `factionHateForTrade` | public float |
| `factionHateForTradeTreaty` | public float |
| `factionHateConflictThreshold` | public float |
| `factionHateWarThreshold` | public float |
| `goodTradeThreshold` | public float |
| `meaningfulTradeThreshold` | public float |
| `tradeAcceptanceTextVariants` | public int |
| `factionHateWarDeterminantDivisor` | public float |
| `alienFactionHateWarValue` | public float |
| `factionHateStealResources` | public float |
| `minimumFleetStrength` | public float |
| `minimumAssaultStrength` | public float |
| `factionHateForBurnXenoforming` | public float |
| `factionHateForDestroyLandedUFO` | public float |
| `factionHateForDestroyAlienFacility` | public float |
| `divisibleHateForDestroyingAlienNation` | public float |
| `AI_BaseAllowedOverageCPMaintenance` | public int |
| `hateVariance` | public float |
| `maxHumanAttackFleetStrengthRatio_C` | public float |
| `maxHumanAttackFleetStrengthRatio_N` | public float |
| `maxHumanAttackFleetStrengthRatio_V` | public float |
| `maxHumanAttackFleetStrengthRatio_B` | public float |
| `maxAttackFleetRatio_AllCases` | public float |
| `hateBurnoffFromKillingHabmodulesDivisor_C` | public float |
| `hateBurnoffFromKillingHabmodulesDivisor_N` | public float |
| `hateBurnoffFromKillingHabmodulesDivisor_V` | public float |
| `hateBurnoffFromKillingHabmodulesDivisor_B` | public float |
| `AI_CouncilorStatChasingMultiplier_C` | public float |
| `AI_CouncilorStatChasingMultiplier_N` | public float |
| `AI_CouncilorStatChasingMultiplier_V` | public float |
| `AI_CouncilorStatChasingMultiplier_B` | public float |
| `spaceResourceToTons` | public float |
| `crewWaterConsumptionTons_year` | public float |
| `crewVolatilesConsumptionTons_year` | public float |
| `crewSalary_year` | public float |
| `crewBaselineWater_tons` | public float |
| `crewBaselineVolatiles_tons` | public float |
| `decomissionModuleRefundRate` | public float |
| `colonizedSpaceObjectValue` | public ulong |
| `populousSpaceObjectValue` | public ulong |
| `innerMiddleBeltLine` | public float |
| `middleOuterBeltLine` | public float |
| `maxHabBoostFromEarthDuration_days` | public float |
| `probeConstructionTime_d` | public float |
| `probeMetalsPayloadMassFraction` | public float |
| `probeVolatilesPayloadMassFraction` | public float |
| `probeNoblesPayloadMassFraction` | public float |
| `probeFissilesPayloadMassFraction` | public float |
| `probeWaterPropellantMassFraction` | public float |
| `probeVolatilesPropellantMassFraction` | public float |
| `probePayloadBaseline_tons` | public float |
| `probePayloadPerHabSite_tons` | public float |
| `maxMassforMiningResourceMalus` | public double |
| `metalsBonusDensityCutPoint` | public float |
| `metalsMalusDensityCutPoint` | public float |
| `initialWaterValue` | public float |
| `initialVolatilesValue` | public float |
| `initialMetalsValue` | public float |
| `initialNobleMetalsValue` | public float |
| `initialFissilesValue` | public float |
| `initialAntimatterValue` | public float |
| `initialExoticsValue` | public float |
| `baseEarthSaleInefficiency` | public float |
| `scuttlePerCrewMassCost` | public float |
| `scuttleRefund` | public float |
| `refitBuildTimeCap` | public float |
| `smallShipyardPenaltyPowerPerTier` | public float |
| `TIModifier_HumanAIShipBuildingScaling_C` | public float |
| `TIModifier_HumanAIShipBuildingScaling_N` | public float |
| `TIModifier_HumanAIShipBuildingScaling_V` | public float |
| `TIModifier_HumanAIShipBuildingScaling_B` | public float |
| `TIModifier_AlienAIShipBuildingScaling_C` | public float |
| `TIModifier_AlienAIShipBuildingScaling_N` | public float |
| `TIModifier_AlienAIShipBuildingScaling_V` | public float |
| `TIModifier_AlienAIShipBuildingScaling_B` | public float |
| `desiredSTOFighterWetMass_tons` | public float |
| `AssaultValue_AlienArmy` | public float |
| `extraStartingCombatDistance_km` | public float |
| `influenceCostBaseForRammingSpeed` | public float |
| `baselineMaxHumanCruiseAcceleration_g` | public float |
| `baselineMaxHumanCombatAcceleration_g` | public float |
| `maxAlienCruiseAcceleration_g` | public float |
| `maxAlienCombatAcceleration_g` | public float |
| `shipPartRepairBaseCostMultiplier` | public float |
| `daysToRefuelAPropellantTank` | public float |
| `daysToReloadAShipWeaponStep` | public float |
| `daysToRepairSystem` | public float |
| `daysToRepairPart` | public float |
| `basicSalvageRecoveryCap` | public float |
| `antimatterSalvageChance` | public float |
| `exoticsSalvageRecoveryCap` | public float |
| `DP_DestroyMissile` | public float |
| `DP_FireAtMagRound` | public float |
| `maxShipsAllowedInCombat` | public int |
| `ExoticsPerAlienHabTier` | public float |
| `ECM_SecondsBollixedPerPointMissed` | public float |
| `ECM_SecondsBollixedPerPointMissed_Missile` | public float |
| `attackBonusPerTargetECMDefeat` | public float |
| `highBombardmentAltitude_km` | public float |
| `medBombardmentAltitude_km` | public float |
| `lowBombardmentAltitude_km` | public float |
| `armyBombardmentDamageDivisor_InBattle` | public float |
| `armyBombardmentDamageDivisor_Dispersed` | public float |
| `officerTransferCostPerRank` | public float |
| `alwaysFireAtSaturated` | public bool |
| `logAllDamageInCombat` | public bool |
| `duration_scaling_divisor` | public float |
| `randomEventsPerMonthVariability` | public int |
| `maxRandomEventsPerMonth` | public int |
| `notificationReceiveInputDelay` | public float |
| `importAllAIShipDesignsInSkirmish` | public bool |
| `pathNoCouncilFlag` | public string |
| `pathCircle` | public string |
| `pathEmptyControlPoint` | public string |
| `pathNavalArmyIcon` | public string |
| `pathNoNavyMovementIcon` | public string |
| `pathWarIcon` | public string |
| `pathPeaceIcon` | public string |
| `pathWaterIcon` | public string |
| `pathVolatilesIcon` | public string |
| `pathBaseMetalsIcon` | public string |
| `pathNobleMetalsIcon` | public string |
| `pathFissilesIcon` | public string |
| `pathAntimatterIcon` | public string |
| `pathExoticsIcon` | public string |
| `pathProjectsIcon` | public string |
| `pathMoneyIcon` | public string |
| `pathInfluenceIcon` | public string |
| `pathOpsIcon` | public string |
| `pathResearchIcon` | public string |
| `pathBoostIcon` | public string |
| `pathMissionControlIcon` | public string |
| `pathNukesIcon` | public string |
| `pathHabPowerIcon` | public string |
| `pathHabPowerAlertIcon` | public string |
| `pathHabResupplyIcon` | public string |
| `pathHabShipyardIcon` | public string |
| `pathHabModuleConstructionIcon` | public string |
| `pathHabDefenseIcon` | public string |
| `pathUnderConstructionIcon` | public string |
| `pathArmyStrengthIcon` | public string |
| `pathOccupationIcon` | public string |
| `pathArmyCombatIcon` | public string |
| `pathFleetInTransitIcon` | public string |
| `pathFleetCombatIcon` | public string |
| `pathFleetIcon` | public string |
| `pathWarningIcon` | public string |
| `pathOrbitIcon` | public string |
| `pathProspectedHabSite` | public string |
| `pathNotProspectedHabSite` | public string |
| `pathBeyondRangeHabSite` | public string |
| `pathSpaceCombatScoreIcon` | public string |
| `pathColonyIcon` | public string |
| `pathUnrestIcon` | public string |
| `pathSpaceAssaultScoreIcon` | public string |
| `pathSpaceMiningIcon` | public string |
| `pathSTOFighter` | public string |
| `pathSunStylized` | public string |
| `pathUndecidedGradient` | public string |
| `ECO_IconPath` | public string |
| `WEL_IconPath` | public string |
| `KNO_IconPath` | public string |
| `UNI_IconPath` | public string |
| `FMI_IconPath` | public string |
| `MIL_IconPath` | public string |
| `SPO_IconPath` | public string |
| `FLI_IconPath` | public string |
| `DEV_IconPath` | public string |
| `BOO_IconPath` | public string |
| `MC_IconPath` | public string |
| `ARM_IconPath` | public string |
| `NAV_IconPath` | public string |
| `NUC_IconPath` | public string |
| `NUK_IconPath` | public string |
| `DEF_IconPath` | public string |
| `GOV_IconPath` | public string |
| `SUB_IconPath` | public string |
| `ENV_IconPath` | public string |
| `pathPersuasionIcon` | public string |
| `pathInvestigationIcon` | public string |
| `pathEspionageIcon` | public string |
| `pathCommandIcon` | public string |
| `pathAdministrationIcon` | public string |
| `pathScienceIcon` | public string |
| `pathSecurityIcon` | public string |
| `pathLoyaltyIcon` | public string |
| `pathResNoneIcon` | public string |
| `pathResPossibleIcon` | public string |
| `pathResLowIcon` | public string |
| `pathResMedIcon` | public string |
| `pathResHighIcon` | public string |
| `pathResMaxIcon` | public string |
| `pathArmyIconBackground` | public string |
| `pathCouncilorIconBackground` | public string |
| `pathCoreEconomicRegion` | public string |
| `pathCoreResourceRegion_Oil` | public string |
| `pathCoreResourceRegion_Mining` | public string |
| `pathCoreResourceRegion_PotentialOil` | public string |
| `pathAlienArmy_attacking` | public string |
| `pathAlienArmy_defending` | public string |
| `pathAlienMegafaunaArmy` | public string |
| `minArmyBaseTechLevel` | public int |
| `maxArmyBaseTechLevel` | public int |
| `pathArmy0_attacking` | public string |
| `pathArmy1_attacking` | public string |
| `pathArmy2_attacking` | public string |
| `pathArmy3_attacking` | public string |
| `pathArmy4_attacking` | public string |
| `pathArmy5_attacking` | public string |
| `pathArmy6_attacking` | public string |
| `pathArmy7_attacking` | public string |
| `pathArmy0_defending` | public string |
| `pathArmy1_defending` | public string |
| `pathArmy2_defending` | public string |
| `pathArmy3_defending` | public string |
| `pathArmy4_defending` | public string |
| `pathArmy5_defending` | public string |
| `pathArmy6_defending` | public string |
| `pathArmy7_defending` | public string |
| `pathArmy0_sea` | public string |
| `pathArmy2_sea` | public string |
| `pathAlienArmy_sea` | public string |
| `pathGeoscapeStation` | public string |
| `pathGeoscapeBase` | public string |
| `pathGeoscapeUnidentifiedCouncilor` | public string |
| `pathGeoscapeCrashdown` | public string |
| `pathGeoscapeUFOLanding` | public string |
| `pathGeoscapeAbductions` | public string |
| `pathGeoscapeEnthrallPublic` | public string |
| `pathGeoscapeEnthrallElites` | public string |
| `pathGeoscapeAlienActivity` | public string |
| `pathGeoscapeTerrorize` | public string |
| `pathGeoscapeXenoform` | public string |
| `pathGeoscapeAlienFacility` | public string |
| `pathGeoscapeXenoform1` | public string |
| `pathGeoscapeXenoform2` | public string |
| `pathGeoscapeXenoform3` | public string |
| `pathGeoscapeLaunchSite1` | public string |
| `pathGeoscapeLaunchSite2` | public string |
| `pathGeoscapeLaunchSite3` | public string |
| `pathGeoscapeMissionControl1` | public string |
| `pathGeoscapeMissionControl2` | public string |
| `pathGeoscapeMissionControl3` | public string |
| `pathGeoscapeSpaceDefenses` | public string |
| `pathGeoscapeAirliner1` | public string |
| `pathGeoscapePrivateJet1` | public string |
| `pathGeoscapeAirliner2` | public string |
| `pathGeoscapePrivateJet2` | public string |
| `pathEnergyIcon` | public string |
| `pathInformationScienceIcon` | public string |
| `pathLifeScienceIcon` | public string |
| `pathMaterialsIcon` | public string |
| `pathMilitaryScienceIcon` | public string |
| `pathSocialScienceIcon` | public string |
| `pathSpaceScienceIcon` | public string |
| `pathXenologyIcon` | public string |
| `pathProbeComplete` | public string |
| `pathProbeEnRoute` | public string |
| `greenUpArrow` | public string |
| `greenDownArrow` | public string |
| `redUpArrow` | public string |
| `redDownArrow` | public string |
| `pathNoneIcon` | public string |
| `crackdownMissionIconPath` | public string |
| `defendInterestsMissionIconPath` | public string |
| `friendlyRelationsInlineSpritePath` | public string |
| `smallCrackdownMissionIconPath` | public string |
| `smallDefendInterestsMissionIconPath` | public string |
| `pathPlayButton` | public string |
| `pathPauseButton` | public string |
| `pathPlusButtonIconPath` | public string |
| `pathMinusButtonIconPath` | public string |
| `pathPlusHoverButtonIconPath` | public string |
| `pathMinusHoverButtonIconPath` | public string |
| `pathNotificationPlusButtonIconPath` | public string |
| `pathNotificationPlusHoverButtonIconPath` | public string |
| `pathNotificationMinusButtonIconPath` | public string |
| `pathNotificationMinusHoverButtonIconPath` | public string |
| `pathMaximizeButtonIconPath` | public string |
| `pathMaximizeHoverButtonIconPath` | public string |
| `pathMinimizeButtonIconPath` | public string |
| `pathMinimizeHoverButtonIconPath` | public string |
| `pathMaxTier1Hab` | public string |
| `pathMaxTier2Hab` | public string |
| `pathMaxTier3Hab` | public string |
| `pathMaxTier4Hab` | public string |
| `pathWeaponExplosion` | public string |
| `pathAlienThrusterVFX` | public string |
| `pathHumanThrusterBasicVFX` | public string |
| `pathHumanThrusterAdvancedVFX` | public string |
| `pathFallbackLaserVFX` | public string |
| `pathFallbackMuzzleFlashVFX` | public string |
| `pathFallbackProjectileVFX` | public string |
| `pathGeoscapeCrashdown_gui` | public string |
| `pathGeoscapeStation_gui` | public string |
| `pathGeoscapeBase_gui` | public string |
| `pathGeoscapeUFOLanding_gui` | public string |
| `pathGeoscapeAbductions_gui` | public string |
| `pathGeoscapeEnthrallPublic_gui` | public string |
| `pathGeoscapeEnthrallElites_gui` | public string |
| `pathGeoscapeAlienActivity_gui` | public string |
| `pathGeoscapeTerrorize_gui` | public string |
| `pathGeoscapeXenoform_gui` | public string |
| `pathGeoscapeAlienFacility_gui` | public string |
| `investmentInlineSpritePath` | public string |
| `educationInlineSpritePath` | public string |
| `cohesionInlineSpritePath` | public string |
| `democracyInlineSpritePath` | public string |
| `unrestInlineSpritePath` | public string |
| `perCapitaGDPInlineSpritePath` | public string |
| `inequalityInlineSpritePath` | public string |
| `populationInlineSpritePath` | public string |
| `nukesInlineSpritePath` | public string |
| `miltechInlineSpritePath` | public string |
| `persuasionInlineSpritePath` | public string |
| `investigationInlineSpritePath` | public string |
| `espionageInlineSpritePath` | public string |
| `commandInlineSpritePath` | public string |
| `administrationInlineSpritePath` | public string |
| `scienceInlineSpritePath` | public string |
| `securityInlineSpritePath` | public string |
| `loyaltyInlineSpritePath` | public string |
| `controlPointInlineSpritePath_empty` | public string |
| `controlPointInlineSpritePath_color` | public string |
| `boostInlineSpritePath` | public string |
| `missionControlInlineSpritePath` | public string |
| `moneyInlineSpritePath` | public string |
| `influenceInlineSpritePath` | public string |
| `opsInlineSpritePath` | public string |
| `researchInlineSpritePath` | public string |
| `projectsInlineSpritePath` | public string |
| `waterInlineSpritePath` | public string |
| `metalsInlineSpritePath` | public string |
| `noblesInlineSpritePath` | public string |
| `volatilesInlineSpritePath` | public string |
| `fissilesInlineSpritePath` | public string |
| `exoticsInlineSpritePath` | public string |
| `antimatterInlineSpritePath` | public string |
| `upGreenArrowInlineSpritePath` | public string |
| `downGreenArrowInlineSpritePath` | public string |
| `upRedArrowInlineSpritePath` | public string |
| `downRedArrowInlineSpritePath` | public string |
| `spaceCombatScoreInlineSpritePath` | public string |
| `spaceDebrisInlineSpritePath` | public string |
| `tutorialInlineSpritePath` | public string |
| `spaceAssaultValueInlineSpritePath` | public string |
| `pathInlineSpaceMiningIcon` | public string |
| `pathInlineSolarIcon` | public string |
| `shipDamageInlineSpritePath` | public string |
| `armorInlineSpritePath` | public string |
| `armyBattleInlineSpritePath` | public string |
| `pathInlineHabStationIcon` | public string |
| `pathInlineHabBaseIcon` | public string |
| `pathInlineEscapeVelocityIcon` | public string |
| `orbitInlineSpritePath` | public string |
| `zeroResourcesInlineSpritePath` | public string |
| `noneIconInlineSpritePath` | public string |
| `unknownResourcesInlineSpritePath` | public string |
| `level1ResourcesInlineSpritePath` | public string |
| `level2ResourcesInlineSpritePath` | public string |
| `level3ResourcesInlineSpritePath` | public string |
| `level4ResourcesInlineSpritePath` | public string |
| `armyInlineSpritePath` | public string |
| `navyInlineSpritePath` | public string |
| `noNavyInlineSpritePath` | public string |
| `capitalRegionInlineSpritePath` | public string |
| `coreEconomicRegionInlineSpritePath` | public string |
| `miningRegionInlineSpritePath` | public string |
| `coreOilRegionInlineSpritePath` | public string |
| `potentialMiningRegionInlineSpritePath` | public string |
| `potentialCoreOilRegionInlineSpritePath` | public string |
| `colonyRegionInlineSpritePath` | public string |
| `ecologicallyVulnerableRegionInlineSpritePath` | public string |
| `ecologicallySafeRegionInlineSpritePath` | public string |
| `ruggedRegionInlineSpritePath` | public string |
| `nukedRegionInlineSpritePath` | public string |
| `alienEntityInlineSpritePath` | public string |
| `antiSpaceDefensesInlineSpritePath` | public string |
| `occupationInlineSpritePath` | public string |
| `energyTechInlineSpritePath` | public string |
| `informationTechInlineSpritePath` | public string |
| `militaryTechInlineSpritePath` | public string |
| `materialsTechInlineSpritePath` | public string |
| `lifeTechInlineSpritePath` | public string |
| `socialTechInlineSpritePath` | public string |
| `spaceTechInlineSpritePath` | public string |
| `xenologyTechInlineSpritePath` | public string |
| `victoryItemInlineSpritePath` | public string |
| `ECO_InlineSpritePath` | public string |
| `WEL_InlineSpritePath` | public string |
| `ENV_InlineSpritePath` | public string |
| `GOV_InlineSpritePath` | public string |
| `KNO_InlineSpritePath` | public string |
| `UNI_InlineSpritePath` | public string |
| `MIL_InlineSpritePath` | public string |
| `OPP_InlineSpritePath` | public string |
| `SPO_InlineSpritePath` | public string |
| `DEV_InlineSpritePath` | public string |
| `BOO_InlineSpritePath` | public string |
| `MC_InlineSpritePath` | public string |
| `FMI_InlineSpritePath` | public string |
| `SUB_InlineSpritePath` | public string |
| `ARM_InlineSpritePath` | public string |
| `NAV_InlineSpritePath` | public string |
| `NUC_InlineSpritePath` | public string |
| `NUK_InlineSpritePath` | public string |
| `DEF_InlineSpritePath` | public string |
| `STO_InlineSpritePath` | public string |
| `FLI_InlineSpritePath` | public string |
| `CEC_InlineSpritePath` | public string |
| `CMI_InlineSpritePath` | public string |
| `OIL_InlineSpritePath` | public string |
| `DCL_InlineSpritePath` | public string |
| `DCT_InlineSpritePath` | public string |
| `sustainabilityInlineSpritePath_Red` | public string |
| `sustainabilityInlineSpritePath_Orange` | public string |
| `sustainabilityInlineSpritePath_Yellow` | public string |
| `sustainabilityInlineSpritePath_Blue` | public string |
| `sustainabilityInlineSpritePath_Green` | public string |
| `habShipyardPresentInlineSpritePath` | public string |
| `habResupplyPresentInlineSpritePath` | public string |
| `habModuleConstructionInlineSpritePath` | public string |
| `habDefenseScoreInlineSpritePath` | public string |
| `habPowerInlineSpritePath` | public string |
| `habPowerAlertInlineSpritePath` | public string |
| `irradiatedInlineSpritePath` | public string |
| `deltaInlineSpritePath` | public string |
| `deltaVInlineSpritePath` | public string |
| `lessThanOrEqualToInlineSpritePath` | public string |
| `greaterThanOrEqualToInlineSpritePath` | public string |
| `warningInlineSpritePath` | public string |
| `starInlineSpritePath` | public string |
| `grayStarInlineSpritePath` | public string |
| `starInlineSpritePath_sizeOverride60` | public string |
| `underConstructionInlineSpritePath` | public string |
| `probeCompleteInlineSpritePath` | public string |
| `probeEnRouteInlineSpritePath` | public string |
| `gravityInlineSpritePath` | public string |
| `keyboard_AltInlineSpritePath` | public string |
| `keyboard_CtrlInlineSpritePath` | public string |
| `keyboard_StrgInlineSpritePath` | public string |
| `keyboard_ShiftInlineSpritePath` | public string |
| `station_human_underconstruction_t1_icon` | public string |
| `station_human_underconstruction_t2_icon` | public string |
| `station_human_underconstruction_t3_icon` | public string |
| `station_alien_underconstruction_t1_icon` | public string |
| `station_alien_underconstruction_t2_icon` | public string |
| `station_alien_underconstruction_t3_icon` | public string |
| `station_human_underconstruction_t1_module` | public string |
| `station_human_underconstruction_t2_module` | public string |
| `station_human_underconstruction_t3_module` | public string |
| `station_alien_underconstruction_t1_module` | public string |
| `station_alien_underconstruction_t2_module` | public string |
| `station_alien_underconstruction_t3_module` | public string |
| `station_human_underconstruction_t1_module_destruction` | public string |
| `station_human_underconstruction_t2_module_destruction` | public string |
| `station_human_underconstruction_t3_module_destruction` | public string |
| `station_alien_underconstruction_t1_module_destruction` | public string |
| `station_alien_underconstruction_t2_module_destruction` | public string |
| `station_alien_underconstruction_t3_module_destruction` | public string |
| `rammingSpeedIcon` | public string |
| `AllStopCommandOffIcon` | public string |
| `disengageIcon` | public string |
| `alarmClockIcon` | public string |
| `alarmClockInlineSpritePath` | public string |
| `illus_launchFacilitySmallPath` | public string |
| `illus_launchFacilityMediumPath` | public string |
| `illus_launchFacilityLargePath` | public string |
| `illus_missionControlFacilitySmallPath` | public string |
| `illus_missionControlFacilityMediumPath` | public string |
| `illus_missionControlFacilityLargePath` | public string |
| `illus_spaceDefensesPath` | public string |
| `illus_xenoformingStage1` | public string |
| `illus_xenoformingStage2` | public string |
| `illus_xenoformingStage3` | public string |
| `illus_landedUFO` | public string |
| `illus_crashedUFO` | public string |
| `illus_alienActivity` | public string |
| `illus_alienFacility` | public string |
| `illus_enthrallPublic` | public string |
| `illus_enthrallElites` | public string |
| `illus_abductions` | public string |
| `illus_terrorize` | public string |
| `illus_humanArmy0` | public string |
| `illus_humanArmy1` | public string |
| `illus_humanArmy2` | public string |
| `illus_humanArmy3` | public string |
| `illus_humanArmy4` | public string |
| `illus_humanArmy5` | public string |
| `illus_humanArmy6` | public string |
| `illus_humanArmy7` | public string |
| `illus_humanNavyTransport0` | public string |
| `illus_humanNavyTransport2` | public string |
| `illus_humanNavyTransport6` | public string |
| `illus_armyConstructed` | public string |
| `illus_armyAssigned` | public string |
| `illus_humanOutpost` | public string |
| `illus_humanSettlement` | public string |
| `illus_humanColony` | public string |
| `illus_alienOutpost` | public string |
| `illus_alienSettlement` | public string |
| `illus_alienColony` | public string |
| `illus_alienNationFounded` | public string |
| `illus_alienFaunaSpawn` | public string |
| `illus_xenofaunaArmy` | public string |
| `illus_alienArmy` | public string |
| `illus_alienNavyTransport` | public string |
| `illus_assaultStation` | public string |
| `illus_assaultBase` | public string |
| `illus_assaultXenoforming` | public string |
| `illus_assaultXenoFacility` | public string |
| `illus_alienCrashdown` | public string |
| `illus_alienLandedUFOBombed` | public string |
| `illus_alienFacilityBombed` | public string |
| `illus_myCouncilorAssassinated_Earth` | public string |
| `illus_myCouncilorAssassinated_Earth_alt` | public string |
| `illus_myCouncilorAssassinated_Space` | public string |
| `illus_myCouncilorDetected_Earth` | public string |
| `illus_spyDiscovered` | public string |
| `illus_myCouncilorDetained` | public string |
| `illus_myOrgStolen` | public string |
| `illus_myControlPointCrackdown` | public string |
| `illus_myControlPointPurged` | public string |
| `illus_habLostToPolitics` | public string |
| `illus_habLostToAssault` | public string |
| `illus_war` | public string |
| `illus_peace` | public string |
| `illus_federation` | public string |
| `illus_unification` | public string |
| `illus_independence` | public string |
| `illus_nuclearWeaponsLaunch` | public string |
| `illus_coup` | public string |
| `illus_annexation` | public string |
| `illus_revolution` | public string |
| `illus_regimeChange` | public string |
| `illus_nuclearProgram` | public string |
| `illus_spaceProgram` | public string |
| `illus_probelaunched` | public string |
| `illus_BSBE_preCrashIntro` | public string |
| `illus_controlPointPaths` | public string[] |
| `techColor` | public Color32[] |
| `gradientTechCategoryPath` | public Dictionary<TechCategory, string> |
| `illus_techCompletePath` | public Dictionary<TechCategory, string> |
| `illus_projectCompletePath` | public Dictionary<TechCategory, string> |
| `illus_alienEarth` | public List<string> |
| `debug_ConsoleActive` | public bool |
| `debug_fullAIDump` | public bool |
| `debug_advancedFactionStart` | public bool |
| `debug_spaceDetection` | public bool |
| `debug_shipDesignAI` | public bool |
| `debug_fullAIKnowledge` | public bool |
| `debug_AINeverFleesPrecombat` | public bool |
| `debug_AIAlwaysFleesPrecombat` | public bool |
| `debug_showAllShipPartsIncludingAlien` | public bool |
| `debug_showAllShipParts` | public bool |
| `debug_showAllHabParts` | public bool |
| `debug_AICombatPathing` | public bool |
| `debug_suppressCombatAI` | public bool |
| `debug_suppressCombatAIAfterXPasses` | public int |
| `debug_suppressSkirmishRotatePlanet` | public bool |
| `debug_skirmishSpaceBodyZoomMult` | public float |
| `debug_noMissionFail` | public bool |
| `debug_alwaysCritFail` | public bool |
| `debug_showHateValues` | public bool |
| `targetFrameRate` | public int |
| `dontPlayCinematicVideos` | public bool |
| `alwaysAllowIncreaseUIScale` | public bool |
| `smoothAIMissionPlanning` | public bool |
| `smoothingMSPerFrame` | public int |
| `combatCamera_maxZoom` | public float |
| `combatCamera_minZoom` | public float |
| `combatCamera_maxPan` | public float |
| `combatCamera_minPan` | public float |
| `combatCamera_minCameraMovementSpeed` | public float |
| `combatCamera_maxCameraMovementSpeed` | public float |
| `combatCamera_minScrollSpeedOffset` | public float |
| `combatCamera_maxScrollSpeedOffset` | public float |
| `combatCamera_mouseRotateSpeedOffset` | public float |
| `combatCamera_keyRotateSpeedOffset` | public float |
| `combatCamera_keyZoomSpeed` | public float |
| `strategyCamera_DragRateNormal` | public double |
| `strategyCamera_DragRateSlow` | public double |
| `strategyCamera_ZoomRateNormal` | public double |
| `strategyCamera_ZoomRateSlow` | public double |
| `strategyCamera_ZoomLongDistanceThreshold` | public double |
| `strategyCamera_ZoomMediumDistanceThreshold` | public double |
| `strategyCamera_ZoomShortDistanceThreshold` | public double |
| `strategyCamera_ZoomLongDistanceMultiplier` | public double |
| `strategyCamera_ZoomMediumDistanceMultiplier` | public double |
| `strategyCamera_ZoomLimit` | public double |
| `strategyCamera_ZoomLimitEarth` | public double |
| `strategyCamera_MaxZoomStep` | public double |
| `strategyCamera_MinDistanceFromCamera` | public double |
| `strategyCamera_LogScaleDistanceFromCamera` | public double |
| `distanceToViewSurfaceBases` | public float |
| `homeCountryThreeLetterISOCodeOverride` | public string |
| `campaignStartSeed` | public int |
| `savePath` | public string |

### Properties

- `public int[] uiScaleValues = new int[]`
- `public List<string> illus_EarthStationPaths = new List<string>(2)`
- `public List<string> illus_StationInteriorPaths = new List<string>(3)`
- `public List<string> illus_BaseInteriorPaths = new List<string>(3)`
- `public List<string> illus_ShipInteriorPaths = new List<string>(1)`
- `public List<string> illus_UnknownOnEarth = new List<string>`
- `public List<string> illus_detainedEarth = new List<string>`
- `public List<string> illus_UnknownInSpace = new List<string>`
- `public List<string> illus_loadingScreens = new List<string>`
- `public List<string> skyboxes = new List<string>`

### Methods

```csharp
public float GetRequiredInvestmentPoints(PriorityType priority)
```

```csharp
public float GetPassiveTechInvestmentDifficultyScaling()
```

```csharp
public float GetActiveTechInvestmentDifficultyScaling()
```

```csharp
public float GetAICriticalCouncilorStatChasingAggressivenessDifficultyScaling()
```

```csharp
public float GetXenoformingAttributeBonusDifficultyScaling()
```

```csharp
public float GetAbductionMissionBonusDifficultyScaling()
```

```csharp
public float GetAIShipbuildingCostDifficultyScaling(TIFactionState faction)
```

```csharp
public float GetCampaignDurationBeforeAlienAdvancedTech()
```

```csharp
public bool UseAlternateTriggersForAlienAdvancedTech()
```

```csharp
public float GetCampaignDurationBeforeAlienInnerSystemExoticAttacks()
```

```csharp
public float GetCampaignDurationBeforeAlienInnerSystemOffensives()
```

```csharp
public float GetCampaignDurationBeforeAlienTotalWar()
```

```csharp
public bool IsAlienTotalWarPossible()
```

```csharp
public float GetMaxAlienBases(float campaignDuration_y)
```

```csharp
public float GetYearsUntilFirstAlienInvasionDifficultyScaling()
```

```csharp
public float GetAlienSteadyHateGainModifier(int difficulty = -1)
```

```csharp
public bool DoAliensHaveReducedWarAttacks()
```

```csharp
public int GetAlienMaxExtraWarAttacks()
```

```csharp
public float GetAlienStartingHateMaximum()
```

```csharp
public float GetAlienHateMaximumIncreasePerYear()
```

```csharp
public float GetAlienHateMaximum()
```

```csharp
public float GetAlienCallOffWarAttacksThreshold()
```

```csharp
public bool DoAliensGiveHateReprieveAfterKnockdown()
```

```csharp
public float AlienHateReprieveAfterKnockdown()
```

```csharp
public float AI_GetDifficultyBasedMaxAttackFleetStrengthRatio(bool alien)
```

```csharp
public float GetDifficultyBasedYearsToDelayAlienMiddleColonization()
```

```csharp
public int GetDifficultyBasedAlienNonPlanetaryOuterSystemColonizationLimit()
```

```csharp
public float AI_GetHateBurnoffFromKillingHabmodulesDivisor(bool alien)
```

```csharp
public float AI_GlobalMissionDifficultyModifier_Att(TICouncilorState attackingCouncilor, TIGameState target)
```

```csharp
public float AI_GlobalMissionDifficultyModifier_Def(TICouncilorState attackingCouncilor, TIGameState target)
```

```csharp
public float AI_AlienHatePerMCUtilitizedMultiplier()
```

```csharp
public float AI_GangUpOnLeaderBehavior_MinIdeologicalDistance_Difficulty()
```

```csharp
public float AI_BonusFreeMissionControl_Difficulty(int difficulty)
```

```csharp
public float AI_BonusFreeCPCap_Difficulty(int difficulty)
```

```csharp
public float AI_BonusInfluenceOnPlayerCouncilorSelect()
```

```csharp
public float AI_GetExoticsMultiplier()
```

```csharp
public float AI_AlienEarthFleetSizeModifier()
```

```csharp
public float AI_AlienEarthFleetExcessModifier()
```

```csharp
public float Diff_GetExoticsSalvageRate()
```

```csharp
public float AI_AlienSurveillanceDelay_years()
```

```csharp
public bool AI_AliensMaySurveil()
```

```csharp
public float AI_AlienBaseQuietness()
```

```csharp
public float AI_AliensWormholeSetupFraction()
```

```csharp
public TIGlobalConfig()
```

```csharp
public TIGlobalConfig(string templateName)
```
