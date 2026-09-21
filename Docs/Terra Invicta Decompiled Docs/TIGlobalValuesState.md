# TIGlobalValuesState

*Decompiled from `PavonisInteractive/TerraInvicta/TIGlobalValuesState.cs`.*


## Class `TIGlobalValuesState`

```csharp
public class TIGlobalValuesState : TIGameState
```

### Fields

| Name | Type |
|---|---|
| `usingCustomizations` | public static bool |
| `Customizations` | public static ScenarioCustomizations |
| `BaselineUnnormalizedSpaceCombatValue` | public static float |
| `globalGDP` | public static double |
| `globalGDP_CampaignStart` | public static double |
| `globalResearch` | public static float |
| `globalGDPFractionOfBaseline` | public static float |
| `globalResearchFractionOfBaseline` | public static float |
| `pcgdpToReduceUnrestBy1` | public float |
| `pcgdpToRaiseMissionBaseDifficultyBy1` | public float |
| `pcgdpToRaiseBaseCPMaintenanceCostBy1` | public float |
| `PCGDPToReduceUnrestBy1` | public static float |
| `PCGDPToRaiseMissionBaseDifficultyBy1` | public static float |
| `PCGDPToRaiseBaseCPMaintenanceCostBy1` | public static float |
| `GlobalValues` | public static TIGlobalValuesState |
| `temperatureAnomalyCO2_C` | public float |
| `temperatureAnomalyCH4_C` | public float |
| `temperatureAnomalyN2O_C` | public float |
| `temperatureAnomalyStratosphericAerosols_C` | public float |
| `temperatureAnomaly_C` | public float |
| `temperatureAnomaly_F` | public float |
| `temperatureAnomaly_C_startTime` | public float |
| `globalSeaLevelAnomaly_m` | public float |
| `CanDisableFactions` | public static bool |
| `gameStateSubjectCreated` | private bool |
| `resourceMarketValues` | public Dictionary<FactionResource, float> |
| `pastEarthAtmosphericCO2_ppm` | public float[] |
| `pastEarthAtmosphericCH4_ppm` | public float[] |
| `pastEarthAtmosphericN2O_ppm` | public float[] |
| `globalSeaLevelRise1Triggered` | public bool |
| `globalSeaLevelRise2Triggered` | public bool |
| `endOfOil` | public bool |
| `CO2SourcesRecord_ppm` | public Dictionary<GHGSources, double> |
| `CH4SourcesRecord_ppm` | public Dictionary<GHGSources, double> |
| `N2OSourcesRecord_ppm` | public Dictionary<GHGSources, double> |
| `SuezRegion` | public TIRegionState |
| `PanamaRegion` | public TIRegionState |
| `TurkishStraitRegion` | public TIRegionState |
| `scenarioCustomizations` | public ScenarioCustomizations |
| `currentNuclearExchanges` | public List<NuclearExchange> |
| `isTutorialActive` | public static bool |
| `gameTime` | private GameTimeManager |
| `inactiveNarrativeEvents` | public List<string> |
| `narrativeEvents` | public Dictionary<string, float> |
| `narrativeEventsOnCooldown_months` | public Dictionary<string, float> |
| `narrativeEventsTargetSpecificCooldowns` | public Dictionary<string, List<EventStateCooldownData>> |
| `triggeredOncePerCampaignEvents` | public List<string> |
| `triggeredOncePerTargetEvents` | public Dictionary<string, List<TIFactionState>> |
| `priorNarrativeEventData` | public Dictionary<string, List<PriorNarrativeEventData>> |
| `altWeightConditionTriggered` | public List<string> |
| `removedNarrativeEvents` | public List<string> |
| `pendingNarrativeEvents` | public List<PendingNarrativeEvent> |
| `interstateWars` | public List<TIWarState> |
| `moddingActive` | public bool |
| `moddingUsedAnytime` | public bool |
| `currentTechSort` | public int |
| `techSortAscend` | public bool |
| `currentProjectSort` | public int |
| `projectSortAscend` | public bool |
| `projectSortShowObsolete` | public bool |
| `fleetScreenClassShowObsolete` | public bool |
| `habQuickBuildToggle` | public bool |
| `habQuickBuildWithBoostToggle` | public bool |
| `showFinderCouncilors` | public bool |
| `showFinderArmies` | public bool |
| `showFinderHabs` | public bool |
| `showFinderFleets` | public bool |
| `globalMilestones` | public Dictionary<GlobalMilestone, TIFactionState> |
| `alienInvaderArmies` | public int |
| `promptQueue` | private TIPromptQueueState |
| `timeState` | private TITimeState |
| `baselineUnnormalizedSpaceCombatValue` | private float |
| `baselineUnnormalizedSpaceCombatValue_Static` | private static float |
| `councilorAppearanceTemplatesInUse` | public List<string> |
| `ideologyTemplateLookup` | public Dictionary<FactionIdeology, TIFactionIdeologyTemplate> |
| `cachedGlobalGDP` | private static double |
| `cachedGlobalGDP_CampaignStart` | private static double |
| `cachedGlobalResearch` | public static float |
| `fixedPCGDPToReduceUnrestBy1` | private float |
| `fixedPCGDPToRaiseMissionBaseDifficultyBy1` | private float |
| `repairCPMaintenanceScaling` | private bool |
| `fixedPCGDPToRaiseBaseCPMaintenanceCostBy1` | private float |
| `isSpaceCombatEnabled` | public static bool |
| `ideologyDistanceGrid` | public Dictionary<FactionIdeology, Dictionary<FactionIdeology, float>> |
| `worstCasePublicOpinionDispersal` | public float |
| `preindustrialCO2_ppm` | public const float |
| `preindustrialCH4_ppm` | public const float |
| `preindustrialN2O_ppm` | public const float |
| `safeAtmosphericCO2_ppm` | public const float |
| `safeAtmosphericCH4_ppm` | public const float |
| `safeAtmosphericN2O_ppm` | public const float |
| `safeAtmosphericGICs_ppm` | public const float |
| `CH4_relativeImpact` | public const float |
| `N2O_relativeImpact` | public const float |
| `anomalyFactor` | private const float |
| `aerosolsFromNukeBarrage_ppm` | public const float |
| `aerosolsFromSingleNuke_ppm` | public const float |
| `aerosolsForCloudCover_ppm` | public const float |
| `xenoformingFullCoverageCO2AnnualConsumption_ppm` | public const float |
| `globalSeaLevelRise1_cm` | public const float |
| `globalSeaLevelRise2_cm` | public const float |
| `MeltPerCAnomaly` | public const float |
| `minEventsPerMonth` | private int |
| `maxEventsPerMonth` | private int |
| `globalMilestoneRewards` | private Dictionary<GlobalMilestone, List<ResourceValue>> |
| `savedInit` | public bool |
| `tutorialMode` | public bool |
| `startDifficulty` | public int |

### Properties

- `public float earthAtmosphericCO2_ppm`
- `public float earthAtmosphericCH4_ppm`
- `public float earthAtmosphericN2O_ppm`
- `public float stratosphericAerosols_ppm`
- `public float globalSeaLevelAnomaly_cm`
- `public float initialSustainabilityMin`
- `public float sustainabilityHelperModifier`
- `public int nuclearStrikes`
- `public int looseNukes`
- `public int difficulty`
- `public float bestGlobalHumanMiltech`
- `public float bestGlobalHumanEducation`
- `public int controlPointMaintenanceFreebies`
- `public string campaignStartVersion`
- `public string latestSaveVersion`
- `public TIDateTime realWorldCampaignStart`
- `public float averageRegionPopulation`
- `public float medianRegionArea_km2`
- `public Dictionary<FactionResource, float> maxGlobalExpectedHabSiteProduction_day`
- `public float maxSolar`

### Methods

```csharp
public override bool Initialize()
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
public override void PostVisualizerCreationInit_7()
```

```csharp
public void SetIdeologyDistanceGrid()
```

```csharp
public void ModifyMarketValuesForResourceSale(Dictionary<FactionResource, int> resourcesSold)
```

```csharp
public void ModifyMarketValuesForEconomyPriority()
```

```csharp
public void ModifyMarketValuesForArmyPriority()
```

```csharp
public void ModifyMarketValuesForMilitaryPriority()
```

```csharp
public void ModifyMarketValuesForNuclearWeaponsPriority()
```

```csharp
public void ModifyMarketValuesForRecession(int power)
```

```csharp
public float GetPurchaseResourceMarketValue(FactionResource resource)
```

```csharp
public float GetModifiedResourceMarketValueForSelling(TIFactionState faction, FactionResource resource)
```

```csharp
public void AddCO2_ppm(float amount, GHGSources source)
```

```csharp
public void AddCH4_ppm(float amount, GHGSources source)
```

```csharp
public void AddN2O_ppm(float amount, GHGSources source)
```

```csharp
public void AddStratosphericAerosols_ppm(float amount, bool causedByNuke)
```

```csharp
public void AddToSeaLevel_cm(float amount)
```

```csharp
public void AddSpoilsPriorityEnvEffect(TINationState nation, float scaling)
```

```csharp
public void AddEnvironmentPriorityEnvEffect(TINationState nation)
```

```csharp
public void NuclearBarrageLaunched(TINationState attacker, TIRegionState target, TINationState enemy)
```

```csharp
public void TriggerNuclearDetonationEffect(bool barrage, TINationState attacker, TIRegionState region, TINationState enemy)
```

```csharp
public void MonthlyGlobalEnvironmentalChanges()
```

```csharp
public void ChangeLooseNukesValue(int delta)
```

```csharp
public void TrySetMaximumMiltech(TINationState nation, float newValue)
```

```csharp
public void TrySetMaximumEducation(TINationState nation, float newValue)
```

```csharp
public static bool CanAnyHumanNationUsePriority(PriorityType priority)
```

```csharp
public Dictionary<FactionIdeology, float> GetGlobalPublicOpinionProportions()
```

```csharp
private TINarrativeEventTemplate NarrativeEventTemplate(string dataName)
```

```csharp
private bool EventConditionsMet(TINarrativeEventTemplate narrativeEvent)
```

```csharp
private bool ValidateSingleTarget(TINarrativeEventTemplate narrativeEvent, TIGameState possibleTarget)
```

```csharp
private Dictionary<TIGameState, float> GetTargets(TINarrativeEventTemplate narrativeEvent, bool ignoreConditions = false)
```

```csharp
public TIGameState GetSecondaryTarget(TINarrativeEventTemplate narrativeEvent, TIGameState primaryState, bool ignoreConditions = false)
```

```csharp
public void NarrativeEventsMonthlyUpdate()
```

```csharp
private string FindNarrativeEvent(string eventDataName)
```

```csharp
public static PendingNarrativeEvent GetCurrentNarrativeEvent(Prompt prompt)
```

```csharp
public static void ClearNarrativeEvent(Prompt prompt)
```

```csharp
public static Prompt FindPromptForNarrativeEvent(TIGameState actor, TIGameState target, TIGameState secondaryTarget, string narrativeEventName)
```

```csharp
public void TriggerNarrativeEvent(TimeEventStart e)
```

```csharp
public void TriggerNarrativeEvent(TINarrativeEventTemplate narrativeEvent, TIFactionState forceFaction = null, bool forceEvent = false)
```

```csharp
public void ExecuteNarrativeEventOption(TINarrativeEventTemplate eventTemplate, TIFactionState faction, TIGameState targetGameState, TIGameState secondaryGameState, int optionSelectedValue, Dictionary<TIGameState, TIGameState> allTargetsandSeconds, Prompt prompt)
```

```csharp
public void ExecuteNarrativeEventOption(TINarrativeEventTemplate eventTemplate, TINationState nation, TIGameState targetGameState, TIGameState secondaryGameState, int optionSelectedValue, Dictionary<TIGameState, TIGameState> allTargetsandSeconds, Prompt prompt)
```

```csharp
public void CleanUpOrgs()
```

```csharp
public TIWarState InitiateWarFromStart(TIWarState war, TINationState attacker, TINationState defender, List<TINationState> attackingAlliance, List<TINationState> defendingAlliance)
```

```csharp
public TIWarState InitiateWar(TINationState attacker, TINationState defender, List<TINationState> attackingAlliance, List<TINationState> defendingAlliance)
```

```csharp
public TIWarState FindWarByInitiators(TINationState attacker, TINationState defender)
```

```csharp
public void DeleteWar(TIWarState war)
```

```csharp
public static void AgglomerateAllWars()
```

```csharp
public void CheckGlobalMilestone(GlobalMilestone milestoneToCheck, TIFactionState faction, TIGameState locationOfAchievement)
```

```csharp
public bool HasGlobalMilestoneBeenAchieved(GlobalMilestone milestone)
```

```csharp
public void CheckGlobalMilestoneOnHabFounding(TIHabState hab, bool createdFromTemplate)
```

```csharp
public void SaveStartSettings()
```

```csharp
public static float GetResearchSpeedModifier()
```

```csharp
public static float GetAlienProgressionModifiedDuration_IgnoreStartingProgression_years_exact()
```

```csharp
public static float GetAlienProgressionModifiedDuration_years_exact()
```

```csharp
public static float GetGlobalMineProductivityModifier()
```

```csharp
public static float GetHabModuleConstructionTimeSettingsModifier(TIFactionState faction)
```

```csharp
public static float GetShipConstructionTimeSettingsModifier(TIFactionState faction)
```

```csharp
public static float GetMiningRateSettingsModifier(TIFactionState faction)
```

```csharp
public static bool IsQuietAlienCampaign()
```

```csharp
public static bool IsInvasionFocusedAlienCampaign()
```

```csharp
public static void ClearStaticData()
```
