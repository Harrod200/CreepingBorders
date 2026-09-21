# TIFactionState

*Decompiled from `PavonisInteractive/TerraInvicta/TIFactionState.cs`.*


## Class `TIFactionState`

```csharp
public class TIFactionState : TIGameState, IGameStateVisualizer, IOperationCapableState
```

### Fields

| Name | Type |
|---|---|
| `isFactionState` | public override bool |
| `searchable` | public override Searchable |
| `ref_faction` | public override TIFactionState |
| `template` | public TIFactionTemplate |
| `playerControl` | public Player |
| `ideologyCoordinates` | public Vector3 |
| `activeCouncilors` | public List<TICouncilorState> |
| `ships` | public List<TISpaceShipState> |
| `knownShips` | public List<TISpaceShipState> |
| `numActiveCouncilors` | public int |
| `IsActiveHumanFaction` | public bool |
| `IsAlienFaction` | public bool |
| `IsAlienProxy` | public bool |
| `isAlienAppeaser` | public bool |
| `isActivePlayer` | public bool |
| `veryProAlien` | public bool |
| `proAlien` | public bool |
| `antiAlien` | public bool |
| `veryAntiAlien` | public bool |
| `malleable` | public bool |
| `extremist` | public bool |
| `shouldNeverAttackAliens` | public bool |
| `cynical` | public bool |
| `believers` | public bool |
| `currentlyDetectingHydra` | public bool |
| `currentlySearchingForHydraCouncilor` | public bool |
| `currentlyHuntingHydraMissions` | public bool |
| `currentlyTryingToContactHydra` | public bool |
| `currentlyHuntingHydraToKill` | public bool |
| `currentlyCapturingHydra` | public bool |
| `huntingAlienWarship` | public bool |
| `CanSellSpaceResourcesOnEarth` | public bool |
| `displayNameWithColor` | public string |
| `displayNameCapitalized` | public string |
| `displayNameCapitalizedWithColor` | public string |
| `adjective` | public string |
| `adjectiveWithColor` | public string |
| `inlineControlPointCapIcon` | public string |
| `leaderName` | public string |
| `leaderAddress` | public string |
| `leaderNameWithAddress` | public string |
| `fleetNameBase` | public string |
| `introduction` | public string |
| `goal` | public string |
| `winningOrgTemplate` | public TIOrgTemplate |
| `factionIcon64path` | public string |
| `factionIcon128path` | public string |
| `factionIcon256path` | public string |
| `factionIcon64UIpath` | public string |
| `factionIcon128UIpath` | public string |
| `factionIcon256UIpath` | public string |
| `cursorPath` | public string |
| `cinematicsPath` | public string |
| `recentDailySpoilsIncome` | public float |
| `mediumTermDailySpoilsIncome` | public float |
| `scenarioCustomizations` | public ScenarioCustomizations |
| `copyResources` | public Dictionary<FactionResource, float> |
| `spaceAssets` | public List<TISpaceAssetState> |
| `primaryStation` | public TIHabState |
| `primarySystem` | public TISpaceBodyState |
| `leaderIcon` | public Sprite |
| `factionIcon64` | public Sprite |
| `factionIcon128` | public Sprite |
| `factionIcon256` | public Sprite |
| `factionIcon64UI` | public Sprite |
| `factionIcon128UI` | public Sprite |
| `factionIcon256UI` | public Sprite |
| `fleetIcon` | public Sprite |
| `fleetIcon1` | public Sprite |
| `fleetIcon2` | public Sprite |
| `fleetIcon3` | public Sprite |
| `stationIcon` | public Sprite |
| `baseIcon` | public Sprite |
| `leaderAppearance` | private TICouncilorAppearanceTemplate |
| `victoryTemplate` | public TIVictoryTemplate |
| `pathLeaderIcon` | public string |
| `pathLeaderHeadVideo` | public string |
| `pathLeaderTorsoVideo` | public string |
| `pathLeaderHeadPortrait` | public string |
| `pathLeaderTorsoPortration` | public string |
| `Insolvent` | public bool |
| `MineNetworkSize` | public int |
| `SafeMineNextworkSize` | public int |
| `MissionControlIncome` | public int |
| `MissionControlIncomeSansHabIncome` | public int |
| `AnyAvailableMissionControl` | public bool |
| `AvailableMissionControl` | public int |
| `MissionControlBalance` | public int |
| `AvailableMissionControlMinusFutureUsage` | public int |
| `MissionControlShortage` | public int |
| `UnlockedSpaceResources` | public bool |
| `AI_GenericMissionControlAvailable` | public int |
| `AI_AnyAvailabeGenericMissionControl` | public bool |
| `HasAnySpaceResources` | public bool |
| `UnlockedAntimatter` | public bool |
| `UnlockedExotics` | public bool |
| `totalControlNations` | public List<TINationState> |
| `majorityControlNations` | public List<TINationState> |
| `executiveNations` | public List<TINationState> |
| `nationsWithMyControlPoints` | public List<TINationState> |
| `AllSetPolicyMissionOptionsWithTargets` | public List<PolicyOptionWithTarget> |
| `maxCouncilSize` | public int |
| `emptyCouncilorSlots` | public int |
| `CouncilorsOnEarth` | public List<TICouncilorState> |
| `FirstCouncilorAvailableForMissionAssignment` | public TICouncilorState |
| `factionsCompromisingThisFaction` | public List<TIFactionState> |
| `factionsCompromised` | public List<TIFactionState> |
| `AlienDetectionBonus` | public int |
| `HumanDetectionBonus` | public int |
| `ArmyCombatBonus` | public float |
| `PropagandaBonus` | public float |
| `shipBuilding` | public bool |
| `BonusPctFromDistribution` | public float |
| `GlobalResearchPurse` | public float |
| `completedProjectsDistinct` | public List<TIProjectTemplate> |
| `TriggeredProjects` | public List<TIProjectTemplate> |
| `combatShips` | public IEnumerable<TISpaceShipState> |
| `noncombatShips` | public IEnumerable<TISpaceShipState> |
| `FleetDryMass_tons` | public float |
| `FleetWetMass_tons` | public float |
| `FutureFleetWetMass_tons` | public float |
| `habs` | public List<TIHabState> |
| `stations` | public List<TIHabState> |
| `bases` | public List<TIHabState> |
| `habModules` | public List<TIHabModuleState> |
| `activeHabModules` | public List<TIHabModuleState> |
| `needsPrimaryHab` | public bool |
| `shipConstructionModules` | public List<TIHabModuleState> |
| `LEOStations` | public List<TIHabState> |
| `EarthSystemStations` | public List<TIHabState> |
| `HabCores` | public List<TIHabState> |
| `MaxStationTier` | public int |
| `MaxBaseTier` | public int |
| `HabSchematics` | public IEnumerable<HabSchematic> |
| `KnownFleets` | public List<TISpaceFleetState> |
| `TargetableFleets` | public List<TISpaceFleetState> |
| `KnownHabs` | public List<TIHabState> |
| `KnownStations` | public List<TIHabState> |
| `TargetableStations` | public List<TIHabState> |
| `KnownBases` | public List<TIHabState> |
| `TargetableOrbitsForBuilding` | public List<TIOrbitState> |
| `FullSystemVisibility` | public bool |
| `GetAlienDetectionRange_AU` | public double |
| `GetAlienDetectionRange_m` | public double |
| `TargetableOrbitsForNavigation` | public List<TIOrbitState> |
| `KnownAlienFacilities` | public List<TIRegionAlienFacilityState> |
| `KnownUFOLandings` | public List<TIRegionUFOLandingState> |
| `KnownAbductions` | public List<TIRegionAlienActivityState> |
| `KnownXenoformMissions` | public List<TIRegionAlienActivityState> |
| `KnownXenoforming` | public List<TIRegionXenoformingState> |
| `KnownAlienActivities` | public List<TIRegionAlienActivityState> |
| `KnownAlienEntities` | public List<TIRegionAlienEntityState> |
| `KnownEnthralls` | public List<TIRegionAlienActivityState> |
| `allowedShipHulls` | public IEnumerable<TIShipHullTemplate> |
| `allowedRadiators` | public IEnumerable<TIRadiatorTemplate> |
| `allowedDrives` | public IEnumerable<TIDriveTemplate> |
| `allowedBatteries` | public IEnumerable<TIBatteryTemplate> |
| `allowedArmors` | public IEnumerable<TIShipArmorTemplate> |
| `allowedPowerPlants` | public IEnumerable<TIPowerPlantTemplate> |
| `allowedNoseWeapons` | public IEnumerable<TIShipWeaponTemplate> |
| `allowedHullWeapons` | public IEnumerable<TIShipWeaponTemplate> |
| `allowedHeatSinks` | public IEnumerable<TIHeatSinkTemplate> |
| `allowedUtilityModules` | public IEnumerable<TIUtilityModuleTemplate> |
| `allowedShipParts` | public List<TIShipPartTemplate> |
| `EarthSTOFightersAvailable` | public int |
| `TotalEarthSTOFighters` | public int |
| `TargetsForSTOFighters` | public List<TISpaceAssetState> |
| `CanLaunchSTOFighters` | public bool |
| `desiredSTOWetMass_tons` | private float |
| `assassinateMission` | public static TIMissionTemplate |
| `detainMission` | public static TIMissionTemplate |
| `assaultAlienAssetMission` | public static TIMissionTemplate |
| `surveilMission` | public static TIMissionTemplate |
| `investigateMission` | public static TIMissionTemplate |
| `setPolicyMission` | public static TIMissionTemplate |
| `orbitMission` | public static TIMissionTemplate |
| `transferMission` | public static TIMissionTemplate |
| `deorbitMission` | public static TIMissionTemplate |
| `defendInterestsMission` | public static TIMissionTemplate |
| `seizeHabMission` | public static TIMissionTemplate |
| `protectMission` | public static TIMissionTemplate |
| `controlHabMission` | public static TIMissionTemplate |
| `abductionsMission` | public static TIMissionTemplate |
| `terrorizeMission` | public static TIMissionTemplate |
| `enthrallElitesMission` | public static TIMissionTemplate |
| `enthrallPublicMission` | public static TIMissionTemplate |
| `enthrallNonAlignedElitesMission` | public static TIMissionTemplate |
| `enthrallOrgMission` | public static TIMissionTemplate |
| `xenoformMission` | public static TIMissionTemplate |
| `purgeMission` | public static TIMissionTemplate |
| `crackdownMission` | public static TIMissionTemplate |
| `hostileTakeoverMission` | public static TIMissionTemplate |
| `stealProjectMission` | public static TIMissionTemplate |
| `sabotageProjectMission` | public static TIMissionTemplate |
| `grantNationMission` | public static TIMissionTemplate |
| `publicCampaignMission` | public static TIMissionTemplate |
| `contactMission` | public static TIMissionTemplate |
| `adviseMission` | public static TIMissionTemplate |
| `goToGroundMission` | public static TIMissionTemplate |
| `controlNationMission` | public static TIMissionTemplate |
| `coupMission` | public static TIMissionTemplate |
| `inspireMission` | public static TIMissionTemplate |
| `turnMission` | public static TIMissionTemplate |
| `sabotageSpaceFacilityMission` | public static TIMissionTemplate |
| `sabotageHabModuleMission` | public static TIMissionTemplate |
| `unrestMission` | public static TIMissionTemplate |
| `stabilizeMission` | public static TIMissionTemplate |
| `passTechnologyMission` | public static TIMissionTemplate |
| `buildFacilityMission` | public static TIMissionTemplate |
| `enemyWarFactions` | public List<TIFactionState> |
| `enemyTotalWarFactions` | public List<TIFactionState> |
| `factionsAtWarWithMe` | public List<TIFactionState> |
| `AIFullDump` | public static bool |
| `TechRaceSlot` | public int |
| `IsInTechRace` | public bool |
| `LastTechRaceDate` | public TIDateTime |
| `HasChosenPassiveTechSlot` | public bool |
| `forcedTechNames` | public List<string> |
| `cheapestForcedTechName` | public string |
| `FlagshipHull` | public TIShipHullTemplate |
| `CanDetectTerrorMissions` | public bool |
| `CanDetectAbductions` | public bool |
| `CanDetectEnthralls` | public bool |
| `CanDetectAllAlienMissions` | public bool |
| `CanDetectAlien` | public bool |
| `CanCaptureAlien` | public bool |
| `HasRelationsWithAliens` | public bool |
| `AlienContactBlocked` | public bool |
| `CanContactAlien` | public bool |
| `CanCountAbductions` | public bool |
| `maxResearchSetting` | private const int |
| `maxTurnedCouncilors` | public const int |
| `HQProjectSlot` | public const int |
| `orgProjectSlot` | public const int |
| `habProjectSlot` | public const int |
| `player` | public TIPlayerState |
| `councilors` | public List<TICouncilorState> |
| `turnedCouncilors` | public List<TICouncilorState> |
| `knownSpies` | public List<TICouncilorState> |
| `intelSharingFactions` | public List<TIFactionState> |
| `unassignedOrgs` | public List<TIOrgState> |
| `fleets` | public List<TISpaceFleetState> |
| `habSectors` | public List<TISectorState> |
| `availableOrgs` | public List<TIOrgState> |
| `newAvailableOrgs` | public List<TIOrgState> |
| `availableCouncilors` | public List<TICouncilorState> |
| `newAvailableCouncilors` | public List<TICouncilorState> |
| `shipDesigns` | public List<TISpaceShipTemplate> |
| `shipDesignsLock` | private readonly object |
| `shipRefitDesigns` | public List<TISpaceShipTemplate> |
| `shipRefitDesignNames` | public List<string> |
| `obsoleteShipDesigns` | public List<string> |
| `customPresets` | public List<TIPriorityPresetTemplate> |
| `habDesigns` | public List<TIHabTemplate> |
| `savedHabDesigns` | public int |
| `controlPoints` | public List<TIControlPoint> |
| `permaAbandonedNations` | public List<TINationState> |
| `armies` | public List<TIArmyState> |
| `resources` | public Dictionary<FactionResource, float> |
| `baseIncomes_year` | private Dictionary<FactionResource, float> |
| `He3Access` | public bool |
| `dailyResourceTransfers` | public List<DailyResourceTransfer> |
| `lastWeeksSpoils` | public float |
| `thisWeeksCumulativeSpoils` | public float |
| `lastMonthsSpoils` | public float |
| `thisMonthsCumulativeSpoils` | public float |
| `cachedSTOFighterMinimumBoost` | public float |
| `fullSpaceVisibility` | public bool |
| `objectiveNames` | private Dictionary<string, ObjectiveStatus> |
| `availableProjectNames` | private List<string> |
| `activeProjectTriggers` | private List<ProjectTrigger> |
| `currentProjectProgress` | public List<ProjectProgress> |
| `researchWeights` | public int[] |
| `numAtrocitiesByCause` | public Dictionary<TIFactionState.AtrocityCause, int> |
| `intel` | private Dictionary<TIGameState, float> |
| `highestIntel` | private Dictionary<TIGameState, float> |
| `factionFleetsEncountered` | public Dictionary<TIFactionState, int> |
| `factionAssassinations` | public Dictionary<TIFactionState, int> |
| `lastRecordedLoyalty` | public Dictionary<TICouncilorState, int> |
| `lastTimeSecretsWereSeen` | public Dictionary<TICouncilorState, TIDateTime> |
| `ignoreContacts` | public List<TIFactionState> |
| `ignoreInterstateDiplomacy` | public List<TIFactionState> |
| `defaultPriorityPresetTemplateName` | public string |
| `primaryHab` | public TIHabState |
| `nextRefitNumber` | public int |
| `abductions` | public int |
| `councilorsGenerated` | public int |
| `specialRegionAdjacencies` | public List<SpecialRegionAdjacencies> |
| `alienInvestigations` | public int |
| `aliensRemoved` | public int |
| `armiesLost` | public Dictionary<ArmyType, int> |
| `aiValues` | public AIValues |
| `factionHate` | private Dictionary<TIFactionState, float> |
| `assessedAlienHateOfMe` | private float |
| `lastDateOfFixedAlienHate` | private TIDateTime |
| `internalCouncilorSuspicion` | public Dictionary<TICouncilorState, float> |
| `thisTurnsReveralScore` | public float |
| `crazyIvan` | public bool |
| `factionGoals` | public Dictionary<GoalType, List<TIFactionGoalState>> |
| `desiredShipClass` | public DesiredShipClass |
| `factionEarlyToDoList` | public List<AITaskCategory> |
| `factionLateToDoList` | public List<AITaskCategory> |
| `minorCPTrouble` | public bool |
| `majorCPTrouble` | public bool |
| `alienProxyNeedsHelp` | public bool |
| `currentRiskAversion` | public float |
| `knownAlienSites` | public Dictionary<TIGameState, TIDateTime> |
| `AIReviewProjects` | public bool |
| `knowsWinCondition` | public bool |
| `updateShipDesignsFlag` | public bool |
| `updateHabPlanningFlag` | public bool |
| `resourceIncomeDeficiencies` | public List<FactionResource> |
| `mostPowerfulHumanEnemy` | public TIFactionState |
| `selfAssessement` | public FactionSelfAssessment |
| `AISavingTarget` | public AISavingData |
| `focusGoal` | public TIFactionGoalState |
| `lostControlPoints` | public Dictionary<TIControlPoint, TIDateTime> |
| `initialAINationGoals` | public List<TINationState> |
| `highestSpaceStrengthSinceLastAlienKnockdown` | public float |
| `planningMissions` | public bool |
| `preppingForMissions` | public bool |
| `hiddenProjects` | public List<string> |
| `favoredProjects` | public List<string> |
| `obsoletedShipParts` | public List<string> |
| `missedProjects` | public List<string> |
| `sabotagedProjects` | public List<string> |
| `longtermTechTarget` | public string |
| `boostAccounts` | public Dictionary<TIFactionState.BoostAccountName, TIDateTime> |
| `perceivedEnemyFleetStrengthFactors` | public Dictionary<TIFactionState, float> |
| `showRegularNotifications` | public bool |
| `showTimerNotifications` | public bool |
| `showAlerts` | public bool |
| `showSummaryLogs` | public bool |
| `alertSpaceTimerNotifications` | public bool |
| `checkNotificationOverrides` | public bool |
| `notificationOverrides` | public Dictionary<string, TINotificationTemplateOverride> |
| `showMonthlyIncomesInTopBarAndIntel` | public bool |
| `showObsoleteParts` | public bool |
| `defaultFleetArrivalAlert` | public int |
| `defaultFleetArrivalAlert_Earth` | public int |
| `defaultFleetArrivalAlienModifier` | public int |
| `defaultFleetArrivalAlienModifier_Earth` | public int |
| `defaultHullAppearanceIndex` | public int |
| `alarms` | public List<Alarm> |
| `mapColorationStyle` | public MapColorationStyle |
| `shipsBuiltInClass` | public Dictionary<string, int> |
| `history_CPCapOverageByDay` | public List<float> |
| `history_MCCapOverageByDay` | public List<int> |
| `gameStateSubjectCreated` | private bool |
| `defeated` | public bool |
| `gameTime` | private GameTimeManager |
| `intelMarkerForProspectorEnRoute` | public const float |
| `intelToProspectSpaceBody` | public const float |
| `objectives` | private Dictionary<TIObjectiveTemplate, ObjectiveStatus> |
| `availableProjects` | public List<TIProjectTemplate> |
| `completedProjects` | public List<TIProjectTemplate> |
| `techContributionHistory` | public Dictionary<TITechTemplate, float> |
| `defaultPriorityPreset` | public TIPriorityPresetTemplate |
| `ideology` | public TIFactionIdeologyTemplate |
| `_factionIcon64` | private Sprite |
| `_factionIcon128` | private Sprite |
| `_factionIcon256` | private Sprite |
| `_factionIcon64UI` | private Sprite |
| `_factionIcon128UI` | private Sprite |
| `_factionIcon256UI` | private Sprite |
| `_fleetIcon` | private Sprite |
| `_fleetIcon1` | private Sprite |
| `_fleetIcon2` | private Sprite |
| `_fleetIcon3` | private Sprite |
| `_baseIcon` | private Sprite |
| `_stationIcon` | private Sprite |
| `_leaderIcon` | private Sprite |
| `_leaderAppearance` | private TICouncilorAppearanceTemplate |
| `_victoryTemplate` | private TIVictoryTemplate |
| `fleetGoalTracker` | public Dictionary<TISpaceFleetState, FactionGoal_Fleet> |
| `cachedPriorityBonuses` | public Dictionary<PriorityType, float> |
| `cachedTechTooltipStrings` | public Dictionary<TIGenericTechTemplate, string> |
| `_playerControl` | private Player |
| `isDummy` | private bool |
| `minimumAge` | private const int |
| `maximumAge` | private const int |
| `elder` | private const int |
| `declining` | private readonly TITraitTemplate |
| `DailyIncomeTransactionLabel` | public const string |
| `Transactions` | public Dictionary<string, List<TIFactionState.Transaction>> |
| `annualResourceIncomes` | private Dictionary<FactionResource, float> |
| `dirtyResourcesTracker` | private readonly TIDirtyResourcesTracker |
| `cachedYearlyRevenue` | private Dictionary<FactionResource, float> |
| `habSupportResources` | public static FactionResource[] |
| `missionControlUsageDataDirty` | private bool |
| `cachedGenericMissionControlAvailable` | private int |
| `genericMissionControlAvailableCachedFrame` | private int |
| `ExpenditureResolution_days` | public const float |
| `highestRecordedExpenditurePerDay` | private Dictionary<TIFactionState.Expenditure, Dictionary<FactionResource, ValueTuple<TIDateTime, float>>> |
| `fleetWetMassDuringHighestShipMaintainence` | private Dictionary<FactionResource, float> |
| `LocalTransferDVLog` | private List<ValueTuple<float, float>> |
| `SolarTransferDVLog` | private List<ValueTuple<float, float>> |
| `cachedAverageNationPriorityFractions` | private Dictionary<PriorityType, float> |
| `averagePriorityFractionsCachedFrame` | private int |
| `startMaxCouncilSize` | public const int |
| `maxMaxCouncilSize` | public const int |
| `cachedTotalStats` | private Dictionary<CouncilorAttribute, int> |
| `councilorResources` | public static readonly FactionResource[] |
| `cachedLEOHabPriorityBonuses` | private Dictionary<PriorityType, float> |
| `cachedLEOHabPriorityBonuses_IncludeNonActive` | private Dictionary<PriorityType, float> |
| `LEOHabPriorityBonusesCachedFrame` | private int |
| `cachedAlienDetectionBonus` | private int |
| `alienDetectionBonusCachedFrame` | private int |
| `cachedHumanDetectionBonus` | private int |
| `HumanDetectionBonusCachedFrame` | private int |
| `cachedArmyCombatBonus` | private float |
| `armyCombatBonusCachedFrame` | private int |
| `cachedPropagandaBonus` | private float |
| `propagandaBonusCachedFrame` | private int |
| `cachedTraitProjectCount` | private int |
| `traitProjectCountCachedFrame` | private int |
| `cachedOrgProjectCount` | private int |
| `orgProjectCountCachedFrame` | private int |
| `cachedHabProjectCount` | private int |
| `habProjectCountCachedFrame` | private int |
| `spaceRangeContexts` | public static readonly List<Context> |
| `TechMultiplierCapBeforeDiminishingReturns` | public const float |
| `cachedBaseHabsMultipliers` | private Dictionary<TechCategory, float> |
| `baseHabsMultiplierCachedFrames` | private Dictionary<TechCategory, int> |
| `cachedTraitsMultiplier` | private Dictionary<TechCategory, float> |
| `cachedOrgsMultiplier` | private Dictionary<TechCategory, float> |
| `cachedFleetsModifier` | private Dictionary<TechCategory, float> |
| `globalResearchPurse` | private float |
| `cachedTriggeredProjects` | private List<TIProjectTemplate> |
| `triggeredProjectsCachedFrame` | private int |
| `specialReinvestigateProjectName` | private const string |
| `specialReinvestigateProject` | protected readonly TIProjectTemplate |
| `cachedAverageShipBuildCost` | private TIResourcesCost |
| `averageShipBuildCostCachedDate` | private TIDateTime |
| `cachedAverageShipFuelCost` | private TIResourcesCost |
| `averageShipFuelCostCachedDate` | private TIDateTime |
| `desiredStaticFleetFraction` | private float |
| `CombatLogs` | public List<TIFactionState.CombatLog> |
| `MaximumTotalCombatLogAttackCount` | public const int |
| `MaximumAttackCountPerCombatLog` | public const int |
| `HabDestructionLog` | public List<TIFactionState.HabDestructionLogEntry> |
| `ShipConstructionTransactionLabel` | public const string |
| `lastUnaffordableShipShipyard` | public TIHabModuleState |
| `AIMaxTransferDurationToAssignConstructionToShipyard_days` | public const int |
| `habSchematics` | private List<HabSchematic> |
| `probeOvertakeFeasibility` | private const float |
| `innerBaseRange_AU` | public const float |
| `outerBaseRange_AU` | public const float |
| `cachedCanExplore` | private HashSet<TISpaceGameState> |
| `cachedKnownAlienEntities` | private List<TIRegionAlienEntityState> |
| `cachedKnownAlienEntitiesFrame` | private int |
| `AlienControlPointGiftHistory` | public List<ValueTuple<TINationState, TIDateTime>> |
| `shipDesignCount` | public int |
| `cachedAllowedShipHulls` | private List<TIShipHullTemplate> |
| `cachedAllowedRadiators` | private List<TIRadiatorTemplate> |
| `cachedAllowedDrives` | private List<TIDriveTemplate> |
| `cachedAllowedBatteries` | private List<TIBatteryTemplate> |
| `cachedAllowedArmors` | private List<TIShipArmorTemplate> |
| `cachedAllowedPowerPlants` | private List<TIPowerPlantTemplate> |
| `cachedAllowedNoseWeapons` | private List<TIShipWeaponTemplate> |
| `cachedAllowedHullWeapons` | private List<TIShipWeaponTemplate> |
| `cachedAllowedHeatSinks` | private List<TIHeatSinkTemplate> |
| `cachedAllowedUtilityModules` | private List<TIUtilityModuleTemplate> |
| `validWeaponClassesForHumanHabs` | protected readonly List<WeaponClass> |
| `validWeaponClassesForAlienHabs` | protected readonly List<WeaponClass> |
| `shipDesigner_CachedDriveStats` | private Dictionary<ValueTuple<ShipRole, TIShipHullTemplate>, Dictionary<TIDriveTemplate, ValueTuple<float, float>>> |
| `defaultHumanFighterMissile` | private const string |
| `defaultAlienFighterCannon` | private const string |
| `defaultAlienFighterMissile` | private const string |
| `defaultAlienFighterDrive` | private const string |
| `TradeCreditTransactionLabel` | public const string |
| `TradeDebitTransactionLabel` | public const string |
| `dumpfile` | public static readonly string |
| `AIDump` | public static readonly bool |
| `cachedFleetGoals` | private List<FactionGoal_Fleet> |
| `fleetGoalsDirty` | private bool |
| `cachedUnresolvedFleetGoals` | private List<FactionGoal_Fleet> |
| `unresolvedFleetGoalsDirty` | private bool |
| `Kills` | public Dictionary<TIFactionState, List<string>> |
| `techRaceSlot` | private int |
| `lastTechRaceDate` | private TIDateTime |
| `cachedFactionWarStatus` | private Dictionary<TIFactionState, bool> |
| `factionWarStatusCachedFrame` | private int |
| `repeatableAdvice` | public static readonly List<TIFactionState.Advice> |
| `friendlyCouncilorToCouncilorMissions` | public static readonly List<string> |
| `BoostAccountName` | public enum |
| `Transaction` | public struct |
| `Resource` | public FactionResource |
| `Amount` | public float |
| `Date` | public TIDateTime |
| `Expenditure` | public enum |
| `CombatLog` | public class |
| `Winner` | public TIFactionState |
| `HabPresent` | public bool |
| `FleetVsFleet` | public bool |
| `AliensPresent` | public bool |
| `Date` | public TIDateTime |
| `Ships` | public Dictionary<TIFactionState, List<ValueTuple<string, string>>> |
| `HabFaction` | public TIFactionState |
| `Attacks` | public List<TIFactionState.CombatLog.Attack> |
| `winner` | private TIFactionState |
| `WasSurprising` | public TIFactionState.CombatLog.SurpriseType |
| `Attack` | public struct |
| `WeaponDataName` | public string |
| `Range_km` | public float |
| `ArmorFacing` | public ArmorFacing |
| `Angle` | public float |
| `TargetingBonus` | public float |
| `SurpriseType` | public enum |
| `HabDestructionLogEntry` | public struct |
| `IsStation` | public bool |
| `IsBase` | public bool |
| `HabType` | public HabType |
| `SpaceBody` | public TISpaceBodyState |
| `Date` | public TIDateTime |
| `Destroyer` | public TIFactionState |
| `ShipyardAISearchResult` | public enum |
| `ShipDesignerOutcome` | public enum |
| `AtrocityCause` | public enum |
| `GoalFilter` | public enum |
| `Advice` | public enum |
| `AdviceData` | public struct |
| `adviceType` | public TIFactionState.Advice |
| `adviceText` | public string |
| `priority` | public float |
| `target` | public TIGameState |

### Properties

- `public Dictionary<TIHabModuleState, List<ShipConstructionQueueItem>> nShipyardQueues`
- `public Dictionary<string, float> techNameContributionHistory`
- `public bool unlockedVictoryObjective`
- `public List<string> finishedProjectNames`
- `public bool orgProjectSlotUnlocked`
- `public bool habProjectSlotUnlocked`
- `public int atrocities`
- `public List<CampaignMilestone> milestones`
- `public string factionOperationCompleteName`
- `public List<PolicyOptionWithTarget> plannedPolicies`
- `public GameObject factionObject`
- `public int missionControlUsage`
- `public int PassiveTechSlot`
- `public TIDateTime LastObjectiveProjectCompletionDate`
- `private Dictionary<FactionResource, float> cachedMiningMultiplier = TIResourcesCost.basicSpaceResources.ToDictionary<FactionResource, FactionResource, float>((FactionResource x) => x, (FactionResource x) => 1f);`
- `private Dictionary<FactionResource, int> miningMultiplierCachedFrame = TIResourcesCost.basicSpaceResources.ToDictionary<FactionResource, FactionResource, int>((FactionResource x) => x, (FactionResource x) => -1);`
- `private Dictionary<TechCategory, int> traitsMultiplierCachedFrame = Enums.TechCategories.ToDictionary<TechCategory, TechCategory, int>((TechCategory x) => x, (TechCategory x) => -1);`
- `private Dictionary<TechCategory, int> orgsMultiplierCachedFrame = Enums.TechCategories.ToDictionary<TechCategory, TechCategory, int>((TechCategory x) => x, (TechCategory x) => -1);`
- `private Dictionary<TechCategory, int> fleetsModifierCachedFrame = Enums.TechCategories.ToDictionary<TechCategory, TechCategory, int>((TechCategory x) => x, (TechCategory x) => -1);`

### Methods

```csharp
public bool permanentAlly(TIFactionState faction)
```

```csharp
public bool CanBeDisabled()
```

```csharp
public bool Defeated()
```

```csharp
public void ResetPrimaryHab()
```

```csharp
public override bool Initialize()
```

```csharp
public override void InitWithTemplate(TIDataTemplate template)
```

```csharp
public static TIFactionState CreateDummy(TIFactionTemplate template)
```

```csharp
public override void PostGameStateCreateInit_OnCreationOnly_1()
```

```csharp
public override void PostGlobalGameStateCreateInit_2()
```

```csharp
public override void PostCanvasManagerCreateInit_3()
```

```csharp
public override void PostAllStartUpInit_5()
```

```csharp
public override void PostVisualizerCreationInit_6()
```

```csharp
public override void PostVisualizerCreationInit_7()
```

```csharp
public void SetAlarm(TIGameState targetGameState, TIDataTemplate targetTemplate, TIDateTime triggerTime, AlarmType alarm, string customString = "")
```

```csharp
public void NewCampaign()
```

```csharp
public void CreateVisualizer(TIDataTemplate myTemplate)
```

```csharp
public TICouncilorTypeTemplate GetRandomJobWithMissions(List<string> missionNames, List<TICouncilorTypeTemplate> takenJobs = null)
```

```csharp
public void RecruitInitialCouncilors()
```

```csharp
private void AgeCouncilors()
```

```csharp
internal void MonthlyFactionUpdate()
```

```csharp
internal void MidMonthlyUpdate()
```

```csharp
public void CheckForDefeated()
```

```csharp
internal void Daily0000FactionUpdate()
```

```csharp
public IEnumerator UpdateShipDesignStrengths()
```

```csharp
public static bool DontAccumulateResource(FactionResource resourceType)
```

```csharp
public static bool ResourceCanGoNegative(FactionResource resourceType)
```

```csharp
public static bool TradeableResource(FactionResource resourceType)
```

```csharp
public void ChangeBaseResourceIncome(FactionResource resourceType, float amount)
```

```csharp
public float GetCurrentResourceAmount(FactionResource resourceType)
```

```csharp
private void RecordTransaction(float amountToAdd, FactionResource resourceType, string label = null)
```

```csharp
public float AddToCurrentResource(float amountToAdd, FactionResource resourceType, bool suppressFactionResourcesUpdatedEvent = false, string label = null)
```

```csharp
public IEnumerable<TIFactionState.Transaction> GetFilteredTransactions(ref float window_days, string label = null, FactionResource resource = FactionResource.None, Func<string, bool> LabelPredicate = null)
```

```csharp
public IEnumerable<TIFactionState.Transaction> GetFilteredTransactions(float window_days, string label = null, FactionResource resource = FactionResource.None, Func<string, bool> LabelPredicate = null)
```

```csharp
public float SubtractFromCurrentResource(float amountToSubtract, FactionResource resourceType, bool suppressFactionResourcesUpdatedEvent = false, string label = null)
```

```csharp
public float TransferResourceToFaction(float amountToTransfer, FactionResource resource, TIFactionState receivingFaction)
```

```csharp
public float GetLoseableResearch()
```

```csharp
public float GetMonthlyIncome(FactionResource resourceType, bool dontRecalculate = false, bool suppressFactionResourcesUpdatedEvent = false)
```

```csharp
public float GetNetDailyIncome(FactionResource resourceType, bool suppressFactionResourcesUpdatedEvent = false)
```

```csharp
public float GetDailyIncome(FactionResource resourceType, bool dontRecalculate = false, bool suppressFactionResourcesUpdatedEvent = false)
```

```csharp
public float GetSpoilsAdjustedMonthlyIncome()
```

```csharp
public int GetMaxSimultaneousProjects()
```

```csharp
public float GetTotalProjects()
```

```csharp
public int GetMissionControlFromCouncilors()
```

```csharp
public int GetMissionControlFromNations()
```

```csharp
public int GetMissionControlContributionFromHabs()
```

```csharp
public List<ResourceValue> AvailableSpaceResources(float fraction = 1f)
```

```csharp
public List<ResourceValue> AvailableSpaceResourcesExcept(float fraction, TIResourcesCost committedSpending)
```

```csharp
public int GetMaxMissionControl()
```

```csharp
public int GetMaxMissionControlFromBuildableSources()
```

```csharp
public float GetBaselineControlPointMaintenanceCost(bool includeDisabled = false)
```

```csharp
public float GetControlPointMaintenanceFreebieCap()
```

```csharp
public float GetOneDayControlPointCapMissionPenalty()
```

```csharp
public float GetAveragedControlPointCapPenaltyToMissions()
```

```csharp
public float GetAveragedMissionControlShortage()
```

```csharp
public float GetAnnualInfluenceCostOfNextControlPoint(TINationState nation)
```

```csharp
public float GetAnnualControlPointMaintenanceCost()
```

```csharp
public void SetPermaAbandonNationStatus(TINationState nation, bool setAbandoned)
```

```csharp
public float GetYearlyIncomeFromHQ(FactionResource resourceType)
```

```csharp
public float GetMonthlyIncomeFromHQ(FactionResource resource)
```

```csharp
public float GetDailyIncomeFromHQ(FactionResource resourceType)
```

```csharp
public float GetDailyIncomeFromCouncilors(FactionResource resourceType)
```

```csharp
public float GetDailyIncomeFromNations(FactionResource resourceType, bool includeDeficit = true)
```

```csharp
public float GetMonthlyIncomeFromNations(FactionResource resourceType, bool includeDeficit = true)
```

```csharp
public float GetDailyIncomeFromHabs(FactionResource resourceType)
```

```csharp
public float GetYearlyIncomeFromCouncilors(FactionResource resourceType)
```

```csharp
public float GetMonthlyIncomeFromCouncilors(FactionResource resourceType)
```

```csharp
public float GetYearlyIncomeFromNations(FactionResource resourceType, bool includeDeficit = true)
```

```csharp
public float GetYearlyNetIncomeFromShips(FactionResource resource)
```

```csharp
public float GetMonthlyNetIncomeFromShips(FactionResource resource)
```

```csharp
public float GetDailyNetIncomeFromShips(FactionResource resource)
```

```csharp
public float GetYearlyGrossRevenueFromShips(FactionResource resource)
```

```csharp
public float GetMonthlyGrossRevenueFromShips(FactionResource resource)
```

```csharp
public float GetDailyGrossRevenueFromShips(FactionResource resource)
```

```csharp
public float GetYearlyExpensesFromShips(FactionResource resource)
```

```csharp
public float GetMonthlyExpensesFromShips(FactionResource resource)
```

```csharp
public float GetDailyExpensesFromShips(FactionResource resource)
```

```csharp
public static bool IsASpaceResource(FactionResource resource)
```

```csharp
public float GetYearlyIncomeFromHabs(FactionResource resourceType)
```

```csharp
public float GetNetYearlyIncomeFromDiplomacy(FactionResource resourceType)
```

```csharp
public float GetNetMonthlyIncomeFromDiplomacy(FactionResource resourceType)
```

```csharp
public float GetNetDailyIncomeFromDiplomacy(FactionResource resourceType)
```

```csharp
public void AddDailyResourceTransfer(TIFactionState targetFaction, FactionResource resource, float value, TIDateTime expiry, bool fixedValue)
```

```csharp
public void RemoveDailyResourceTransfer(DailyResourceTransfer transfer)
```

```csharp
public void UpdateDailyResourceTransfers()
```

```csharp
public float GetMonthlyTransferOutFromResourceTransfers(FactionResource resource, TIFactionState targetFaction, bool includeInactives)
```

```csharp
public float GetMonthlyTransferInFromResourceTransfers(FactionResource resource, TIFactionState originFaction, bool includeInactives)
```

```csharp
public float GetYearlyIncomeFromExcessMissionControl(FactionResource resourceType)
```

```csharp
public float GetMonthlyIncomeFromExcessMissionControl(FactionResource resourceType)
```

```csharp
public float GetDailyIncomeFromExcessMissionControl(FactionResource resourceType)
```

```csharp
public void TriggerFactionResourceUpdateEvent()
```

```csharp
public void SetResourceIncomeDataDirty(FactionResource resource)
```

```csharp
public void SetResourceIncomeDataDirty(FactionResource[] resources)
```

```csharp
public void SetResourceIncomeDataDirty()
```

```csharp
public float GetMonthlyIncomeWithoutDiplomacy(FactionResource resourceType)
```

```csharp
public float GetYearlyIncomeWithoutDiplomacy(FactionResource resourceType)
```

```csharp
public float GetYearlyIncome(FactionResource resourceType, bool dontRecalculate = false, bool suppressFactionResourcesUpdatedEvent = false, bool forceRecalculate = false)
```

```csharp
public float GetUnderConstructionMiningIncomePerDay(FactionResource resource)
```

```csharp
public float GetUnderConstructionMiningAdjustedNetIncomePerDay(FactionResource resource)
```

```csharp
public float GetUnderConstructionMiningAdjustedNetIncomePerYear(FactionResource resource)
```

```csharp
public void RecalculateIncomes()
```

```csharp
public float GetYearlyRevenue(FactionResource resource, bool forceRecalculate = false, bool forceUseCache = false)
```

```csharp
public float GetMonthlyRevenue(FactionResource resource, bool forceUseCache = false)
```

```csharp
public float GetDailyRevenue(FactionResource resource, bool forceUseCache = false)
```

```csharp
public float GetYearlyExpenditure(FactionResource resource, bool forceUseCache = false)
```

```csharp
public float GetMonthlyRevenue_AI(FactionResource resource)
```

```csharp
public float GetDailyRevenue_AI(FactionResource resource)
```

```csharp
public float GetYearlyExpenditure_AI(FactionResource resource, bool forceUseCache = false)
```

```csharp
public float GetMonthlyGrossRevenue(FactionResource resource)
```

```csharp
public float GetMonthlyGrossExpenses(FactionResource resource)
```

```csharp
public float DailySpaceResourceShortage()
```

```csharp
public void CheckForResourceShortages()
```

```csharp
public bool SubstitutingBoostForSpaceResource()
```

```csharp
public float DailyHabBoostShortage()
```

```csharp
public bool InsufficientBoostToSupportHabs()
```

```csharp
public bool ResourceShortageOfType(FactionResource resource)
```

```csharp
public int GetMissionControlRequirementFromShips()
```

```csharp
public int GetMissionControlRequirementFromNextMine(TISpaceBodyState body = null)
```

```csharp
public int GetMissionControlGainedFromTurningOffMine(TIHabModuleState mine)
```

```csharp
public int GetMissionControlRequirementFromMineNetwork(int mineNetworkSize = -1)
```

```csharp
public int GetMissionControlRequirementFromHabs(bool includeMineNetwork = true)
```

```csharp
public int GetMissionControlFromRefits()
```

```csharp
public int GetFutureMissionControlfromUnderConstructionShips(bool onlyPaidShips = false)
```

```csharp
public void SetMissionControlUsageDataDirty()
```

```csharp
public int GetMissionControlUsage()
```

```csharp
public int GetMissionControlUsageUnderConstruction()
```

```csharp
public int GetFutureAdditionalMissionControlUsage()
```

```csharp
public float GetCurrentMiningMultiplierFromOrgsAndEffects(FactionResource resource)
```

```csharp
public bool UnlockedResource(FactionResource resource)
```

```csharp
public List<FactionResource> SellableResourcesOnEarth()
```

```csharp
public TIRegionSpaceFacilityState SelectRandomLaunchSite()
```

```csharp
private string GetExpenditureLabel(TIFactionState.Expenditure expenditure, FactionResource resource)
```

```csharp
public void RecordExpenditure(TIFactionState.Expenditure expenditure, FactionResource resource, float quantity)
```

```csharp
public void RecordExpenditure(TIFactionState.Expenditure expenditure, TIResourcesCost resourcesCost)
```

```csharp
public float GetHighestRecordedExpenditurePerDay(TIFactionState.Expenditure expenditure, FactionResource resource, bool update = false)
```

```csharp
public void RecordExpenditurePerDay(TIFactionState.Expenditure expenditure, FactionResource resource, float expenditurePerDay)
```

```csharp
public void ClearHighestRecordedExpenditure(TIFactionState.Expenditure expenditure, FactionResource resource)
```

```csharp
public float EstimateExpenditurePerDay(TIFactionState.Expenditure expenditure, FactionResource resource)
```

```csharp
public float EstimateTotalExpenditurePerDay(FactionResource resource)
```

```csharp
public float GetDVPerDayEstimate()
```

```csharp
public float PredictMaximumMaintainenceCostsPerDay(FactionResource resource)
```

```csharp
public void LogTransfer(Trajectory trajectory)
```

```csharp
public List<TINationState> nationsWithInterest(bool includeAlienProxies)
```

```csharp
public void AddPlannedPolicy(PolicyOptionWithTarget policy)
```

```csharp
public void RemovePlannedPolicy(PolicyOptionWithTarget policy)
```

```csharp
public void ClearPlannedPolicies()
```

```csharp
public List<TIPriorityPresetTemplate> ValidPresetsForFaction()
```

```csharp
public void SetDefaultPreset(string presetName)
```

```csharp
public void SaveCustomPresetDesign(TIPriorityPresetTemplate priorityPreset)
```

```csharp
public void DeleteCustomPresetDesign(TIPriorityPresetTemplate priorityPreset)
```

```csharp
public float GetAverageNationPriorityFraction(PriorityType nationPriority)
```

```csharp
public List<TICouncilorState> AvailableCouncilorsWithMission(TIMissionTemplate mission)
```

```csharp
public TICouncilorState GetBestCouncilorForJob(TIMissionTemplate mission, List<TICouncilorState> availableCouncilors)
```

```csharp
public void BeginIntelSharingWith(TIFactionState faction)
```

```csharp
public void EndIntelSharingWith(TIFactionState faction)
```

```csharp
public float Suspicion(TICouncilorState councilor)
```

```csharp
public bool AI_SuspectTurned(TICouncilorState councilor)
```

```csharp
public void SetSuspicion(TICouncilorState councilor, float value)
```

```csharp
public void ChangeSuspicion(TICouncilorState councilor, float delta)
```

```csharp
public void AddSuspicionForFailure(MissionResult missionResult)
```

```csharp
public void AddSuspicionForMajorReversal(float multiplier, TICouncilorState targetedCouncilor)
```

```csharp
public void ClearScrambleValues()
```

```csharp
public bool ShouldTryToRestoreCouncilorLoyalty(TICouncilorState turnedCouncilor)
```

```csharp
public bool WorthTryingToUnturnCouncilor(TICouncilorState turnedCouncilor, TICouncilorState inspirer, int sliderSteps = -1)
```

```csharp
public float GetAggregateStat(CouncilorAttribute attribute, bool includeDetained, TIGameState requiredSupraLocation = null)
```

```csharp
public void SetCouncilStatsDirty()
```

```csharp
public int GetTotalStat(CouncilorAttribute attribute, bool includeDetained, TIGameState requiredSupraLocation = null)
```

```csharp
public float GetMaxCouncilorStat(CouncilorAttribute attribute, bool includeDetained, TIGameState requiredSupraLocation = null)
```

```csharp
public bool CouncilHasTrait(TITraitTemplate trait, bool includeDetained, TIGameState requiredSupraLocation = null)
```

```csharp
public void GrantNewOrgToCouncilor(TICouncilorState councilor, string orgDataName)
```

```csharp
public void AddAvailableCouncilor(TICouncilorState councilor, bool forced = false)
```

```csharp
public void DismissCouncilor(TICouncilorState councilor, TIFactionState dismissingFaction)
```

```csharp
public TICouncilorState GetNextCouncilor(TICouncilorState councilor, bool useFinderSortIndex = false)
```

```csharp
public TICouncilorState GetPreviousCouncilor(TICouncilorState councilor)
```

```csharp
public bool GenerateRecruitableCouncilors(bool campaignStart = false)
```

```csharp
public List<MissionOption> GetMissionOptionsForTarget(TIGameState target)
```

```csharp
public IEnumerable<TIMissionTemplate> GetAllPossibleMissions()
```

```csharp
public static TIOrgState CreateNewOrg(TIOrgTemplate newOrgTemplate)
```

```csharp
public static TIOrgState CreateNewOrg(string orgDataName)
```

```csharp
public bool CouncilHasOrg(TIOrgTemplate orgTemplate, bool includeDetained)
```

```csharp
public List<TIOrgState> ValidateAllOrgs(bool suppressReporting)
```

```csharp
public void AddAvailableOrg(TIOrgState newOrg, bool newToFaction = true)
```

```csharp
public bool GenerateOrgsForAcquisition(bool campaignStart = false)
```

```csharp
public void CachePriorityBonuses_Day()
```

```csharp
public float SumLEOHabPriorityBonuses(PriorityType priority, bool includeNonActive = false, float extra = 0f)
```

```csharp
public float SumPriorityBonuses(PriorityType priority, bool skipLEO = false)
```

```csharp
public bool OwnsOrgInUnassignedPool(TIOrgState org)
```

```csharp
public bool CanPurchaseOrg(TIOrgState org)
```

```csharp
public void PurchaseOrg(bool unassignedInCouncil, TIOrgState org, TICouncilorState councilor = null, bool straightToPool = false)
```

```csharp
public bool CanTransferOrgFromCouncilorToCouncilor(TIOrgState org, TICouncilorState receivingCouncilor, bool checkCost = true)
```

```csharp
public void TransferOrgToCouncilor(TIOrgState org, TICouncilorState councilorReceiving, TICouncilorState councilorGiving)
```

```csharp
public void SellOrg(TIOrgState org, TICouncilorState councilor = null)
```

```csharp
public void LoseOrg(TIOrgState org)
```

```csharp
public TIOrgState CreateOrTransferOrgToFactionPool(TIOrgTemplate orgTemplate, bool allowTheft = true)
```

```csharp
public void AddOrgToFactionPool(TIOrgState org, TICouncilorState councilor = null, bool skipOverageCheck = false)
```

```csharp
public void AssignOrgToCouncilor(TIOrgState org, TICouncilorState councilor)
```

```csharp
public int UnassignedPoolOverage()
```

```csharp
public void RemoveOrgFromUnassignedPool(TIOrgState org)
```

```csharp
public void ActivateCouncilorOrgs()
```

```csharp
public void DeactivateAllCouncilorOrgs()
```

```csharp
public List<TIOrgState> GetAllOrgs()
```

```csharp
public List<TIOrgState> GetStealableOrgs(TICouncilorState councilor)
```

```csharp
public float GetNegativeDailyIncomeFromUnassignedOrgs(FactionResource resource)
```

```csharp
public float GetNegativeYearlyIncomeFromUnassignedOrgs(FactionResource resource)
```

```csharp
public float GetNegativeMonthlyIncomeFromUnassignedOrgs(FactionResource resource)
```

```csharp
public int TraitProjectCount()
```

```csharp
public int OrgProjectCount()
```

```csharp
public bool OrgProjectAllowed()
```

```csharp
private TIProjectTemplate GetDefaultProjectForSlot(int slot)
```

```csharp
public void CheckForOrgProjectStatusChange()
```

```csharp
public int HabProjectCount()
```

```csharp
public bool HabProjectAllowed()
```

```csharp
public void CheckforHabProjectUnlock()
```

```csharp
public TIProjectTemplate GetProjectInSlot(int slot)
```

```csharp
public ProjectProgress GetProjectProgressInSlot(int slot)
```

```csharp
public int GetSlotForProject(TIProjectTemplate projectTemplate)
```

```csharp
public int GetResearchPriority(int slot)
```

```csharp
public void SetResearchPriority(int slot, int value)
```

```csharp
public void IncrementResearchPriority(int slot)
```

```csharp
public void DecrementResearchPriority(int slot)
```

```csharp
public string ProjectCompletionDate(int slot)
```

```csharp
public int TotalResearchWeights(bool orgProject, bool habProject)
```

```csharp
public float FractionWeightInSlot(int slot, bool orgProject, bool habProject)
```

```csharp
public float FractionWeightInSlot(int slot)
```

```csharp
public void AddResearchToProject(int slot, float researchValue)
```

```csharp
public int ContributingToSlots(bool orgProject, bool habProject)
```

```csharp
public int ActiveSlotsWithTechCategory(TechCategory category, bool orgProject, bool habProject)
```

```csharp
public bool ResearchProjectCompleted(int slot)
```

```csharp
public bool NewProjectRequired(int slot)
```

```csharp
public float TechContributionBonus(TIProjectTemplate project)
```

```csharp
public string GetCachedTechTooltipString(TIGenericTechTemplate tech)
```

```csharp
public void SetCachedTechTooltipString(TIGenericTechTemplate tech, bool recursive = true)
```

```csharp
public void CacheAllTechTooltipStrings()
```

```csharp
public void OnProjectComplete(TIProjectTemplate project, int slot, bool suppressLogging = false, bool startup = false)
```

```csharp
public void OnProjectCompleteInSlot(int slot)
```

```csharp
public bool ProjectPaused(TIProjectTemplate template)
```

```csharp
public ProjectProgress GetProjectProgressByTemplate(TIProjectTemplate template)
```

```csharp
public float GetProjectProgressValueByTemplate(TIProjectTemplate template)
```

```csharp
public float GetProjectProgressValueByTemplateFraction(TIProjectTemplate template)
```

```csharp
public void SetProjectInSlot(int slot, TIProjectTemplate newProjectTemplate)
```

```csharp
public List<int> AllowedProjectSlots()
```

```csharp
public bool ProjectAllowedInSlot(int slot)
```

```csharp
public int BestAvailableEmptySlot()
```

```csharp
public int MostReplaceableProjectSlot()
```

```csharp
public float MultipleFacilitiesMultiplier(int traitProjects, int orgFacilities, int habFacilities)
```

```csharp
public float BaseHabsMultiplier(TechCategory techCategory, float extra = 0f)
```

```csharp
public float AdjustedHabsMultiplier(TechCategory techCategory, float extra = 0f)
```

```csharp
public float HabsMultiplier(TechCategory techCategory)
```

```csharp
public float TraitsMultiplier(TechCategory techCategory)
```

```csharp
public float OrgsMultiplier(TechCategory techCategory)
```

```csharp
public float FleetsModifier(TechCategory techCategory)
```

```csharp
public float InvestigationsModifier(TechCategory techCategory)
```

```csharp
public float SumCategoryModifiers(TechCategory category)
```

```csharp
public float DistributedCategoryModifierValue(TechCategory category)
```

```csharp
public float EffectsModifier(TechCategory techCategory)
```

```csharp
public float GetEffectiveResearch(float points, TechCategory category, bool isProject)
```

```csharp
public float GetEffectiveResearchPerDay(TechCategory category, bool isProject, bool fast = false)
```

```csharp
public float PointsToSlot(int slot, float points, float totalWeights)
```

```csharp
public void DistributeResearchToSlots(float basePointsToDistribute)
```

```csharp
public List<TIProjectTemplate> CurrentlyActiveProjects()
```

```csharp
public List<TIProjectTemplate> StartedProjects()
```

```csharp
public List<TIProjectTemplate> SelectableProjects(int slot = -1)
```

```csharp
public IEnumerable<TIProjectTemplate> GetFutureProjects(int layerCount)
```

```csharp
public IEnumerable<TIProjectTemplate> GetDescendentProjects(IEnumerable<TIProjectTemplate> ancestors, int generationCount)
```

```csharp
public List<TIProjectTemplate> StealableProjects(TIFactionState stealingFaction)
```

```csharp
public List<TIProjectTemplate> ProjectsVulnerableToSabotage(TIFactionState sabotagingFaction)
```

```csharp
public void SufferProjectSabotage(TIProjectTemplate project)
```

```csharp
public bool AddAvailableProject(string dataName)
```

```csharp
public bool AddAvailableProject(TIProjectTemplate project, ProjectTrigger triggerToRemove = null)
```

```csharp
public void AddCompletedProject(string dataName)
```

```csharp
private void AddCompletedProject(TIProjectTemplate project)
```

```csharp
public void SetLongTermTechTarget(string techDataName)
```

```csharp
public bool SetProjectHidden(string projectDataName)
```

```csharp
public bool SetProjectUnhidden(string projectDataName)
```

```csharp
public bool SetProjectFavored(string projectDataName)
```

```csharp
public bool SetProjectUnfavored(string projectDataName)
```

```csharp
public bool ProjectAlreadyTriggered(TIProjectTemplate projectTemplate)
```

```csharp
public void OnPublicTechCompleted(TITechTemplate completedTechTemplate, float myContributionFraction)
```

```csharp
public void OnPublicTechCompleted_PostEffectsApplied(TITechTemplate completedTechTemplate, bool startup)
```

```csharp
public void OnMilestoneCompleted(CampaignMilestone milestone)
```

```csharp
public float GetProjectUnlockChance(TIProjectTemplate project, float bonus)
```

```csharp
public void RollToAddProjectTrigger(TIProjectTemplate project, TIProjectTemplate oneTimeProjectCompleted = null)
```

```csharp
public bool EligibleForMissedProjectProject()
```

```csharp
public void CheckForMissedProjectProject()
```

```csharp
public void AddMissedProjectToList(string missedProject)
```

```csharp
public void RemoveMissedProjectFromList(string missedProject)
```

```csharp
public void DailyProjectTriggerCheck()
```

```csharp
public void MonthlyProjectTriggerChanceChange()
```

```csharp
public bool HasObjectiveProjectAvailable()
```

```csharp
public void AddFleet(TISpaceFleetState fleet)
```

```csharp
public void RemoveFleet(TISpaceFleetState fleet)
```

```csharp
public void DailyFleetsUpdate()
```

```csharp
public TIResourcesCost GetAverageShipBuildCost()
```

```csharp
public TIResourcesCost GetTypicalShipBuildCost()
```

```csharp
public TIResourcesCost GetTypicalShipBuildCostSansRareMaterials()
```

```csharp
public TIResourcesCost GetTypicalShipFuelCostsPerKps()
```

```csharp
public TIResourcesCost GetTypicalShipFuelCostPerKPSSansRareMaterials()
```

```csharp
public float GetTypicalShipSpaceCombatValue()
```

```csharp
public float GetTypicalShipMissionControlConsumption()
```

```csharp
public float GetTypicalShipBombardmentValue(TISpaceBodyState spaceBody)
```

```csharp
public static IEnumerable<TISpaceFleetState> GetDefenders(TISpaceObjectState primaryDefender)
```

```csharp
public IEnumerable<TISpaceFleetState> GetAttackers(TISpaceFleetState primaryAttacker)
```

```csharp
public float GetDesiredStaticFleetFraction()
```

```csharp
public void AddCombatLog(TIFactionState.CombatLog combatLog)
```

```csharp
public List<TIHabState> ShipConstructionHabs(bool includeInactives, bool includeUnderConstruction = false)
```

```csharp
public IEnumerable<TIHabState> ResupplyHabs(bool includeInactives, bool includeTheft = false)
```

```csharp
public bool CanBuildShipsAtLocation(TIGameState location, bool includeInactives, bool includeUnderConstruction)
```

```csharp
public bool CanResupplyShipsAtLocation(TIGameState location, bool includeInactives)
```

```csharp
public bool CanFoundHabFromHabAtLocation(TIGameState location, bool includeInactives = false, bool includeUnderConstruction = false)
```

```csharp
public int MaxTierCanFoundAtLocation(TIGameState location, bool includeInactives = false, bool includeUnderConstruction = false)
```

```csharp
public void SetHe3Access()
```

```csharp
public List<TIHabState> MyHabsAtLocation(TIGameState location)
```

```csharp
public TIHabState GetMainBaseInSystem(TISpaceBodyState system)
```

```csharp
public TISpaceBodyState GetInnermostColonizedPlanet()
```

```csharp
public void NeverForget(TIHabState destroyedHab, TIFactionState destroyer = null)
```

```csharp
public IEnumerable<TIFactionState.HabDestructionLogEntry> GetHabDestructions(TISpaceBodyState spaceBody, HabType habType = HabType.Any)
```

```csharp
public bool MaxedOutHabForFaction(TIHabState hab)
```

```csharp
public List<TIHabState> MaxedOutHabsForFaction(HabType habType)
```

```csharp
public void SaveHabDesign(TIHabTemplate habDesign)
```

```csharp
public void DeleteHabDesign(string dataName)
```

```csharp
public bool IsDuplicateHabDesign(TIHabTemplate designToTest)
```

```csharp
public List<ShipConstructionQueueItem> GetShipyardQueue(TIHabModuleState shipyard)
```

```csharp
public void AddShipyardToFaction(TIHabModuleState candidateShipyardModule, bool startup = false)
```

```csharp
public void RemoveShipyardFromFaction(TIHabModuleState shipyard, bool peaceful)
```

```csharp
public bool AddShipToShipyardQueue(TIHabModuleState shipyard, TISpaceShipTemplate shipClass, bool allowPayFromEarth, float fractionWillingToSpend = 1f, FactionGoal_Fleet intendedGoal = null, bool isRefit = false, TISpaceShipTemplate originalShipDesign = null, TISpaceShipState originalShipState = null)
```

```csharp
public void RemoveShipFromShipyardQueue(TIHabModuleState shipyard, ShipConstructionQueueItem item)
```

```csharp
public void RepositionShipinShipyardQueue(TIHabModuleState shipyard, ShipConstructionQueueItem item, int newIndex)
```

```csharp
public bool AttemptInitiateShipConstruction(TIHabModuleState shipyard)
```

```csharp
public void ShipConstructionQueueDailyUpdate()
```

```csharp
private Vector3 GetHabOffsetDirection(Transform root, int index, int count)
```

```csharp
public void RecordShipBuilt(TISpaceShipTemplate template)
```

```csharp
public void CompleteShipConstruction(TIHabModuleState shipyardIdx, bool refitCancel = false, ShipConstructionQueueItem item = null)
```

```csharp
public bool UnlockedShipPart(TIShipPartTemplate part)
```

```csharp
public float DaysToShipyardAvailability(TIHabModuleState shipyard)
```

```csharp
public bool AI_ShipyardCanServeGoal(TIHabModuleState shipyard, TIFactionGoalState goal, TISpaceShipTemplate ship, bool respectLocalGoals = true)
```

```csharp
public TIHabModuleState AI_GetBestShipyardForBuild(TISpaceShipTemplate ship, TIGameState destination, TIFactionGoalState goal, out TIFactionState.ShipyardAISearchResult result, out bool tapBoost, bool tapSavings = false, float fraction = 1f, bool emergency = false, bool ignoreCanAfford = false)
```

```csharp
public float GetMineSizeModifier()
```

```csharp
public float GetHabConstructionDurationModifier()
```

```csharp
public void OnTimedOperationComplete(TimeEventStart e)
```

```csharp
public List<IOperation> VisibleOperationList(TINaturalSpaceObjectState naturalSpaceObject)
```

```csharp
public List<IOperation> AvailableOperationList(TINaturalSpaceObjectState naturalSpaceObject)
```

```csharp
public List<OperationData> CurrentOperations()
```

```csharp
public bool CanProspectFromShip(TISpaceBodyState spaceBody)
```

```csharp
public bool CandidateForProspecting(TISpaceBodyState spaceBody)
```

```csharp
public List<TIResourcesCost> CanOvertakeProbeWithProbe(TISpaceBodyState spaceBody)
```

```csharp
public bool CanProspectWithProbe(TISpaceBodyState spaceBody, bool checkIfCanOvertake)
```

```csharp
public bool EligibleForFoundingBase(TISpaceBodyState spaceBody)
```

```csharp
public bool AlienTerritoryToAvoid(TISpaceBodyState spaceBody)
```

```csharp
public bool EligibleforColonization(TISpaceGameState spaceGameState)
```

```csharp
public bool CanExplore(TISpaceGameState spaceGameState)
```

```csharp
public float DesiredStrategicRange_AU()
```

```csharp
private void CheckForNewObjectives()
```

```csharp
public void CheckForMilestonesCompleteViaOperation(TIOperationTemplate operation, TIGameState target)
```

```csharp
public bool CanCompleteAccessLiveAliensMilestones()
```

```csharp
public void CompleteMilestone(CampaignMilestone milestone)
```

```csharp
public static void CompleteMilestoneForAllHumanFactions(CampaignMilestone milestone)
```

```csharp
public void ResetMilestone(CampaignMilestone milestone)
```

```csharp
public void ResetAllTutorialMilestones()
```

```csharp
public bool MilestoneCompleted(CampaignMilestone milestone)
```

```csharp
public void InitializeAchievements()
```

```csharp
public void InitializeSteamAchievements()
```

```csharp
public void UnlockAchievement(string apiName)
```

```csharp
public void ResetAchievement(string apiName)
```

```csharp
private void UnlockSteamAchievement(string apiName)
```

```csharp
private void ResetSteamAchievement(string apiName)
```

```csharp
public void ResetAllSteamUserStats(bool resetAchievementsToo)
```

```csharp
public void ProcessBuildHabAchievements(TIHabState hab)
```

```csharp
public bool WonWithAllFactions()
```

```csharp
public void CheckForObjectivesCompleteViaMilestone(CampaignMilestone milestone)
```

```csharp
public void CheckForObjectivesCompleteViaProject(TIProjectTemplate projectTemplate)
```

```csharp
public void CheckForObjectivesCompleteViaTech(TITechTemplate techTemplate)
```

```csharp
public void CheckForObjectivesCompleteViaMission(TIMissionState missionState, MissionResult result)
```

```csharp
public void CheckForObjectivesCompleteViaHabModuleActivated(TIHabModuleState habModule)
```

```csharp
public List<CampaignMilestone> DesiredMilestones()
```

```csharp
public void CompleteObjective(TIObjectiveTemplate objective)
```

```csharp
public void UnlockObjective(TIObjectiveTemplate objective)
```

```csharp
public List<TIObjectiveTemplate> CheckForNewObjectiveUnlocksViaObjective()
```

```csharp
public List<TIObjectiveTemplate> GetObjectives()
```

```csharp
public List<TIObjectiveTemplate> GetObjectivesByStatus(ObjectiveStatus status)
```

```csharp
public List<TIObjectiveTemplate> GetObjectivesByType(ObjectiveType objectiveType)
```

```csharp
public List<TIObjectiveTemplate> GetObjectivesAndChildByType(ObjectiveType objectiveType)
```

```csharp
public List<TIObjectiveTemplate> GetObjectivesByTypeAndStatus(ObjectiveType objectiveType, ObjectiveStatus status)
```

```csharp
public ObjectiveStatus GetObjectiveStatus(TIObjectiveTemplate objectiveTemplate)
```

```csharp
public bool IsObjectiveComplete(TIObjectiveTemplate objectiveTemplate)
```

```csharp
public CampaignMilestone GetMileStoneFromObjective(TIObjectiveTemplate objectiveTemplate)
```

```csharp
public string GetObjectiveCompletedVoicePath(TIObjectiveTemplate finishedObjective)
```

```csharp
public CampaignMusicProgression GetDesiredMusicProgression()
```

```csharp
public void LaunchProspector(TISpaceBodyState spaceBody)
```

```csharp
public void ProspectSpaceBody(TISpaceBodyState spaceBody)
```

```csharp
public bool ProspectingSpaceBody(TISpaceBodyState spaceBody)
```

```csharp
public bool ProspectorEnRoute(TISpaceBodyState spaceBody)
```

```csharp
public bool FleetSurveyingPlanet(TISpaceBodyState spaceBody)
```

```csharp
public TIDateTime ProspectorArrival(TISpaceBodyState spaceBody)
```

```csharp
public bool Prospected(TISpaceBodyState spaceBody)
```

```csharp
public bool Prospected(TIHabSiteState habSite)
```

```csharp
public bool CanShareIntelItemWithFaction(TIFactionState receivingFaction, TIGameState gameState)
```

```csharp
public void GiveIntelToFaction(TIFactionState intelGainingFaction, bool fromSpy)
```

```csharp
private void ProcessIntelChange(TIGameState intelTarget, bool simultaneous)
```

```csharp
public float GainIntelToMinimum(TIGameState intelTarget, float gain, float minimum, TIGameState changeSource = null, float maxFromThisGain = 1f)
```

```csharp
public void SetIntelIfValueHigher(TIGameState intelTarget, float value, TIGameState changeSource = null)
```

```csharp
public void SetIntelIfValueLower(TIGameState intelTarget, float value, TIGameState changeSource = null, bool simultaneous = false)
```

```csharp
public void SetIntel(TIGameState intelTarget, float value, TIGameState changeSource = null, bool simultaneous = false)
```

```csharp
public void GainIntel(TIGameState intelTarget, float value, TIGameState source = null, bool simultaneous = false)
```

```csharp
public float GetIntel(TIGameState prospectiveTarget)
```

```csharp
public float GetHighestIntel(TIGameState target)
```

```csharp
public List<TICouncilorState> EnemyCouncilorsIHaveIntelOn(TIFactionState faction, bool allHuman = false)
```

```csharp
public List<TISpaceBodyState> ProspectedSpaceBodies()
```

```csharp
public List<TISpaceBodyState> SpaceBodiesWithProspectorEnRoute()
```

```csharp
public IEnumerable<TISpaceBodyState> ProspectedAndSoonToBeProspectedSpaceBodies()
```

```csharp
public bool SufficientIntel(TIGameState target, float thresholdValue)
```

```csharp
public bool SufficientMemory(TIGameState target, float thresholdValue)
```

```csharp
public bool HasMemoryOnCouncilorBasicData(TICouncilorState councilor)
```

```csharp
public bool HasMemoryOnCouncilorDetails(TICouncilorState councilor)
```

```csharp
public bool HasMemoryOnCouncilorSecrets(TICouncilorState councilor)
```

```csharp
public bool HasIntelOnCouncilorLocation(TICouncilorState councilor)
```

```csharp
public bool HasIntelOnCouncilorBasicData(TICouncilorState councilor)
```

```csharp
public bool HasIntelOnCouncilorDetails(TICouncilorState councilor)
```

```csharp
public bool HasIntelOnCouncilorMission(TICouncilorState councilor)
```

```csharp
public bool HasIntelOnCouncilorSecrets(TICouncilorState councilor)
```

```csharp
public bool HasIntelOnSpaceAssetLocation(TISpaceAssetState asset)
```

```csharp
public bool HasIntelOnFleetShipDetails(TISpaceFleetState fleet)
```

```csharp
public bool HasIntelOnUndercoverCouncilorsInSpaceAsset(TISpaceAssetState asset)
```

```csharp
public void ExpireIntel(TIGameState gameState, bool alsoFromHighest)
```

```csharp
public void PingForAlienSpaceAssetDetection()
```

```csharp
public void DegradeIntelOnVariousThings()
```

```csharp
public CouncilorView GetViewofCouncilor(TICouncilorState targetCouncilor)
```

```csharp
public FactionView GetViewofFaction(TIFactionState targetFaction)
```

```csharp
public bool CanTargetFleet(TISpaceFleetState targetFleet)
```

```csharp
public bool CanTargetStation(TIHabState hab)
```

```csharp
public bool CanTargetOrbit(TIOrbitState orbit)
```

```csharp
public List<CouncilorView> EverKnownCouncilors(TIFactionState faction)
```

```csharp
public List<TICouncilorState> CurrentKnownUnidentifiedCouncilors()
```

```csharp
public List<TICouncilorState> CurrentKnownCouncilors(bool requireFactionIdentified, List<TIFactionState> limitToFactions = null, bool justExcludeMine = false, bool includeDetained = true)
```

```csharp
public void MarkAlienSite(TIGameState site, TIDateTime time = null)
```

```csharp
public TIGameState MostRecentAlienSite(bool EarthOnly = true)
```

```csharp
public float MostRecentAlienSiteAge_days(bool EarthOnly = true)
```

```csharp
public void RegisterControlPointRecievedFromAliens(TIControlPoint controlPoint)
```

```csharp
public float GetFactionHate(TIFactionState enemyCouncil)
```

```csharp
public float GetEstimatedAlienHate()
```

```csharp
public TIDateTime GetLastDateofFixedAlienHate()
```

```csharp
public void FixAssessedAlienHateToActualValue()
```

```csharp
public void UpdateEstimatedAlienHate(float value, bool force = false)
```

```csharp
public void SetFactionHate(TIFactionState enemyCouncil, float value, bool cantConflagrate = false, string cause = "")
```

```csharp
public void GainFactionHate(TIFactionState enemyCouncil, float value, bool cantConflagrate = false, string cause = "", bool randomize = true)
```

```csharp
public bool ShouldWorryAboutMCBasedAlienHate()
```

```csharp
public float MCBasedAlienHate(TIFactionState enemyFaction)
```

```csharp
public float MinimumFactionHate(TIFactionState enemyFaction)
```

```csharp
public float MaximumFactionHate(TIFactionState enemyFaction)
```

```csharp
public void SaveShipDesign(TISpaceShipTemplate shipDesign)
```

```csharp
public void DeleteShipDesign(TISpaceShipTemplate shipDesign)
```

```csharp
public IReadOnlyList<TISpaceShipTemplate> GetShipDesignsThreadSafe()
```

```csharp
private IEnumerable<TIShipPartTemplate> GetPartVariations(TIShipPartTemplate part)
```

```csharp
public void SetShipPartObsolete(TIShipPartTemplate part, bool includeVariations = true)
```

```csharp
public void SetShipPartNotObsolete(TIShipPartTemplate part, bool includeVariations = true)
```

```csharp
public void SetDesignerShowObsoletePartsSetting(bool show)
```

```csharp
public void UpdateAllowedShipParts(List<TIShipPartTemplate> newParts = null)
```

```csharp
public TIRadiatorTemplate GetBestRadiatorRaw()
```

```csharp
public TIRadiatorTemplate GetBestRadiator(TISpaceShipTemplate design, bool allowExotics)
```

```csharp
public TIBatteryTemplate GetBestBattery(TISpaceShipTemplate design, bool allowExotics)
```

```csharp
public TIShipArmorTemplate GetBestArmor(bool allowExotics)
```

```csharp
public TIDriveTemplate GetBestDrive(ShipRole role, int thrusters, bool allowAntimatter, bool allowExotics, float desiredStrategicRange_AU)
```

```csharp
public void SetShipDesignNoseWeapons(bool playerAutodesign, ref TISpaceShipTemplate design, bool allowExotics, IEnumerable<TIShipWeaponTemplate> choices = null)
```

```csharp
public string GetBestPointDefenseWeaponTemplateName()
```

```csharp
public string GetBestHabWeapon(bool isBase, int tier, WeaponClass preferredClass, TISpaceBodyState parentSpaceBody, List<TIShipWeaponTemplate> notionalAdditions = null)
```

```csharp
private IEnumerable<TIShipWeaponTemplate> GetWeaponBasket(IEnumerable<TIShipWeaponTemplate> candidates, Dictionary<TIShipWeaponTemplate, float> scores)
```

```csharp
private TIShipWeaponTemplate ChooseWeapon(IEnumerable<TIShipWeaponTemplate> candidates, Dictionary<TIShipWeaponTemplate, float> scores, bool forceChooseBest)
```

```csharp
private void SetShipDesignHullWeapons(bool playerAutoDesign, ref TISpaceShipTemplate design, bool allowExotics, IEnumerable<TIShipWeaponTemplate> choices = null)
```

```csharp
public TIPowerPlantTemplate GetBestPowerPlant(TISpaceShipTemplate design, bool allowExotics, bool allowAntimatter, IEnumerable<TIPowerPlantTemplate> choices = null)
```

```csharp
public TIHeatSinkTemplate GetBestHeatSink(bool allowExotics)
```

```csharp
public TIUtilityModuleTemplate GetBestAssaultModule(List<TIUtilityModuleTemplate> allowedModules)
```

```csharp
public TIUtilityModuleTemplate GetBestECMModule(List<TIUtilityModuleTemplate> allowedModules)
```

```csharp
public TIShipModuleTemplate GetNextBestUtilityModule(TISpaceShipTemplate design, ref List<TIUtilityModuleTemplate> allowedModules, bool allowExotics, ref List<int> skipList, List<TIShipModuleTemplate> selectedModules)
```

```csharp
private void AddUtilityModuleToDesign(ref List<TIShipModuleTemplate> modules, ref List<TIUtilityModuleTemplate> allowedModules, TIShipModuleTemplate module)
```

```csharp
protected List<ModuleDataTemplateEntry> GetBestUtilityModules(TISpaceShipTemplate design, bool allowExotics, bool allowAntimatter, IEnumerable<IEnumerable<SpecialModuleRule>> forcedSpecialModuleRules = null, List<ModuleDataTemplateEntry> cachedBestUtilityModules = null)
```

```csharp
public IEnumerable<TIDriveTemplate> GetDriveCatalogue(ShipRole role, TIShipHullTemplate hull, float randomness = 0f)
```

```csharp
private IEnumerable<T> GetObsoleteFilteredParts<T>(IEnumerable<T> parts) where T : TIShipPartTemplate
```

```csharp
public TIFactionState.ShipDesignerOutcome DesignShip(bool playerAutodesign, ShipRole role, out TISpaceShipTemplate design, float desiredStrategicRange_AU, bool allowExotics = false, bool allowAntimatter = false, TIShipHullTemplate forceHull = null, IEnumerable<IEnumerable<SpecialModuleRule>> forcedSpecialModuleRules = null, bool heavy = false, TIOrbitState exampleOrigin = null, TIOrbitState exampleDestination = null, float desiredMaxTransferDuration = float.PositiveInfinity, float hardMaxTransferDuration = float.PositiveInfinity)
```

```csharp
public TIFactionState.ShipDesignerOutcome DesignAlienShip(ShipRole role, out TISpaceShipTemplate design, float desiredStrategicRange_AU, bool allowExotics = false, bool allowAntimatter = false, TIShipHullTemplate forceHull = null, bool heavy = false, int designPasses = 122)
```

```csharp
public TISpaceShipTemplate DesignRefit(TISpaceShipTemplate original)
```

```csharp
public bool HasRefitForTemplate(TISpaceShipTemplate originalTemplate)
```

```csharp
public bool HasRefitForTemplate(TISpaceShipTemplate originalTemplate, out TISpaceShipTemplate refitTemplate)
```

```csharp
public List<TIShipWeaponTemplate> AllowedHumanFighterNoseWeapons()
```

```csharp
public List<TIShipWeaponTemplate> AllowedFighterHullWeapons()
```

```csharp
public float STOFighterLaunchCost(TISpaceShipTemplate fighterTemplate)
```

```csharp
public ValueTuple<float, float> GetAverageSTOFighterStats()
```

```csharp
public TISpaceShipTemplate DesignSTOFighter(TINationState homeNation, TIShipWeaponTemplate primaryArmament = null)
```

```csharp
public void CacheSTOFighterMass()
```

```csharp
public bool CanTradeAwayResource(FactionResource resource, TIFactionState otherFaction)
```

```csharp
public TradeOffer InitializeTradingOptions(TIFactionState otherFaction)
```

```csharp
public void ProcessTrade(TradeOffer acceptedOffer, float tradeHateModifier, TIFactionState otherFaction, bool originalContactingFaction)
```

```csharp
public bool WillingToTrade(TIFactionState otherFaction)
```

```csharp
public bool MayTradeAwayHab(TIHabState hab, TIFactionState receivingFaction)
```

```csharp
public bool AI_ShouldNotAcquireHabInTrade(TIHabState hab)
```

```csharp
public bool AI_ShouldNotTradeAwayHab(TIHabState hab)
```

```csharp
public bool CanTradeProject(TIProjectTemplate project, TIFactionState factionToTradeTo)
```

```csharp
public bool CanTradeOrg(TIOrgState org, TIFactionState factionToTradeTo)
```

```csharp
public bool HasNAP(TIFactionState otherFaction, bool includeToBeDiscarded = true)
```

```csharp
public bool HasTruce(TIFactionState otherFaction, bool includeToBeDiscarded = true)
```

```csharp
public bool CanTradeNAP(TIFactionState otherFaction)
```

```csharp
public string NoNAPTradeFeedback(TIFactionState otherFaction, bool includeAILogic)
```

```csharp
public string NoIntelFeedback(TIFactionState otherFaction)
```

```csharp
public string NoTruceFeedback(TIFactionState otherFaction)
```

```csharp
public bool CanTradeTruce(TIFactionState otherFaction)
```

```csharp
public bool CanTradeIntelSharing(TIFactionState otherFaction, bool ignoreExistingAgreement = false)
```

```csharp
public bool CanTradeTreaty(TIFactionState otherFaction, TradeOffer.TreatyType treatyType)
```

```csharp
public string DiplomacyGreetingMessage(TIFactionState otherFaction, bool forceWar)
```

```csharp
public string GetDiplomacyMood(TIFactionState otherFaction)
```

```csharp
public void CommitAtrocity(int numAtrocities, TIFactionState.AtrocityCause cause, bool propagandaHitWhenZero = false, float multiplier = 0.333f)
```

```csharp
public string AtrocityCauseTable()
```

```csharp
public void SetNotificationPreference(string notificationTemplateDataName, int notificationType, NotificationOverrideBehavior overrideBehavior)
```

```csharp
public Dictionary<TIOrgState, TICouncilorState> ProposeOptimizedCriticalOrgMissions(out List<TIMissionTemplate> missionsNotFound, List<TIMissionTemplate> criticalMissions = null)
```

```csharp
public List<TIMissionTemplate> ObjectiveCriticalMissions()
```

```csharp
public List<TIMissionTemplate> RequiredMissions(bool includeCriticals = true)
```

```csharp
public List<TIMissionTemplate> MissingRequiredMissions(List<TIMissionTemplate> requiredMissions = null)
```

```csharp
public bool IsInTotalWarWithFaction(TIFactionState enemy)
```

```csharp
public static void LogAI(string logEntry, bool fullDumpOnly = false)
```

```csharp
public static void DumpGoals(TIFactionState faction)
```

```csharp
public static void DumpShipyards(TIFactionState faction)
```

```csharp
public static void DumpMissions(TIFactionState faction)
```

```csharp
public List<TIFactionGoalState> GoalsOfType(GoalType goalType, bool orderByImportance = false, bool skipResolved = true)
```

```csharp
public List<TIFactionGoalState> GoalsOfType(List<GoalType> goalTypes, bool orderByImportance = false, bool skipResolved = true)
```

```csharp
public TIFactionGoalState AddGoal(TIFactionGoalState prospectiveGoal, HandleDuplicateGoalRule duplicationRule = HandleDuplicateGoalRule.ResetImportance, TISpaceFleetState fleet = null)
```

```csharp
public void RemoveGoal(TIFactionGoalState goal)
```

```csharp
public List<TIFactionGoalState> FindGoals(GoalType goaltype, TIGameState actor, TIGameState target, TIFactionState.GoalFilter filter = TIFactionState.GoalFilter.none, bool skipResolved = true)
```

```csharp
public List<TIFactionGoalState> FindGoals(List<GoalType> goalTypes, TIGameState actor, TIGameState target, TIFactionState.GoalFilter filter = TIFactionState.GoalFilter.none, bool skipResolved = true)
```

```csharp
public List<TIFactionGoalState> FindGoals(List<GoalType> goalTypes, List<TIGameState> actors, List<TIGameState> targets, TIFactionState.GoalFilter filter = TIFactionState.GoalFilter.none, bool skipResolved = true)
```

```csharp
public List<TIFactionGoalState> GoalsWithTarget(TIGameState target, GoalType goalTypeFilter, bool skipResolved = true)
```

```csharp
public List<TIFactionGoalState> GoalsWithTarget(TIGameState target, List<GoalType> goalTypeFilter = null, bool skipResolved = true)
```

```csharp
public IEnumerable<FactionGoal_Fleet> AllFleetGoals(bool skipResolved)
```

```csharp
public List<TIFactionGoalState> AllFoundHabGoals(bool skipResolved)
```

```csharp
public List<TIFactionGoalState> AllCaptureNationGoals(bool skipResolved)
```

```csharp
public void CleanStateFromGoalTargets(TIGameState state)
```

```csharp
public void SubstituteFleetAsGoalTarget(TISpaceFleetState oldState, TISpaceFleetState newState)
```

```csharp
public void RegisterKill(TIGameState destroyedTarget, float valueMultiplier)
```

```csharp
public float GetPerceivedEnemyFleetStrengthFactor(TIFactionState enemy)
```

```csharp
public float GetPerceivedEnemyFleetStrength(TISpaceFleetState enemyFleet)
```

```csharp
public float GetPerceivedEnemySpaceAssetStrength(TISpaceAssetState spaceAsset)
```

```csharp
public float GetPerceivedEnemySpaceAssetStrength_AndItsDefenders(TISpaceAssetState spaceAsset)
```

```csharp
public void AdjustPerceivedEnemyFleetStrengthFactor(TIFactionState enemy, float adjustmentFactor)
```

```csharp
public void BeginTechRace(int techSlot)
```

```csharp
public void EndTechRace()
```

```csharp
public void ClearPassiveTechSlot()
```

```csharp
public void SetPassiveTechSlot(int passiveTechSlot)
```

```csharp
public float TechCategoryValuation(TechCategory category)
```

```csharp
public float TechRoleValuation(TechRole role)
```

```csharp
public float AI_ModifiedRiskAversion()
```

```csharp
public TIFactionGoalState GetManagementGoalForNation(TINationState nation, bool beneficialOnly)
```

```csharp
public TIFactionGoalState SetManagementGoalForNation(TINationState nation)
```

```csharp
public GoalType AI_GetPreferredManagementGoalForNation(TINationState nation)
```

```csharp
public bool AI_AtWarWithOtherFactions()
```

```csharp
public bool AI_AtWarWithFaction(TIFactionState faction)
```

```csharp
public int AI_WarWithFactionImportance(TIFactionState otherFaction)
```

```csharp
public float AvailableCPCapSpace()
```

```csharp
public bool MinorCPTrouble()
```

```csharp
public bool MajorCPTrouble()
```

```csharp
public bool NationWithFactionInterest(TINationState nation, bool includeAlienProxyRelations)
```

```csharp
public TISpaceShipTemplate GetDesiredShipToBuild(FactionGoal_Fleet factionGoal, bool needNow = false)
```

```csharp
public void FactionExposed(TIFactionState otherFaction)
```

```csharp
public void AISetSavingTarget(TIDataTemplate desiredPurchase, TIGameState location, TIFactionGoalState factionGoal)
```

```csharp
public void AIClearSavingTarget(string stack)
```

```csharp
public bool CanDetectAlienMission(TIMissionTemplate mission)
```

```csharp
public void SetIntialPlanetaryConquestGoals(TIHabSiteState mainBaseSite)
```

```csharp
public float AlienHabSurveillanceStrength()
```

```csharp
public float GetBestNotionalMissionSuccessChance(TIMissionTemplate mission, TIGameState target, List<TICouncilorState> councilorsToCheck = null)
```

```csharp
public static List<TIFactionState.AdviceData> GetAdvice(TIGameState speaker, int kount, List<TIFactionState.Advice> allowedAdviceTypes = null)
```

```csharp
public override bool Equals(object obj)
```

```csharp
public CombatLog(IEnumerable<TISpaceShipState> ships, TIHabState hab = null)
```

```csharp
public void AddAttack(TIFactionState.CombatLog.Attack attack)
```

```csharp
public void SetAttacks(IEnumerable<TIFactionState.CombatLog.Attack> attacks)
```

```csharp
public TIFactionState.CombatLog.SurpriseType IsSurprising()
```

```csharp
public AdviceData(TIFactionState.Advice adviceType, string adviceText, float priority, TIGameState target)
```
