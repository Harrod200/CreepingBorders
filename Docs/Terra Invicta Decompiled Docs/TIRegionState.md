# TIRegionState

*Decompiled from `PavonisInteractive/TerraInvicta/TIRegionState.cs`.*


## Class `TIRegionState`

```csharp
public class TIRegionState : TIGameState
```

### Fields

| Name | Type |
|---|---|
| `template` | public TIRegionTemplate |
| `mapRegionTemplateName` | public string |
| `coreResourceRegion` | public bool |
| `isRegionState` | public override bool |
| `searchable` | public override Searchable |
| `ref_region` | public override TIRegionState |
| `ref_nation` | public override TINationState |
| `ref_spaceBody` | public override TISpaceBodyState |
| `ref_naturalSpaceObject` | public override TINaturalSpaceObjectState |
| `ref_spaceObject` | public override TISpaceObjectState |
| `ref_faction` | public override TIFactionState |
| `ref_factions` | public override List<TIFactionState> |
| `hasMapObject` | public override bool |
| `hasEarthMapObject` | public override bool |
| `ref_UFOLanding` | public override TIRegionUFOLandingState |
| `ref_UFOCrashdown` | public override TIRegionUFOCrashdownState |
| `ref_regionAlienActivity` | public override TIRegionAlienActivityState |
| `ref_alienFacility` | public override TIRegionAlienFacilityState |
| `ref_xenoforming` | public override TIRegionXenoformingState |
| `solarBodyName` | public string |
| `boostLatitude` | public float |
| `latitude` | public float |
| `longitude` | public float |
| `terrain` | public TerrainType |
| `StandardLocalPosition` | public Vector3d |
| `mapRegionTemplate` | public TIMapRegionTemplate |
| `spaceBody` | public TISpaceBodyState |
| `boostPerMonth_dekatons` | public float |
| `hasAnySpaceFacility` | public bool |
| `hasAlienFacility` | public bool |
| `area_km2` | public float |
| `coastCurrentlyFrozen` | public bool |
| `isCoastal` | public bool |
| `onTheWater` | public bool |
| `isIsland` | public bool |
| `alienAssets` | public TIRegionAlienAssetState[] |
| `alienActivities` | public TIRegionAlienEntityState[] |
| `illustrationPaths` | public List<string> |
| `nationalGDPShareValue` | public double |
| `nationalGDPShareValue_bn` | public double |
| `regionalPerCapitaGDP` | public double |
| `perCapitaGDPstr` | public string |
| `GDPstring` | public string |
| `displayNameSentIn` | public string |
| `displayNameSentOf` | public string |
| `isCapital` | public bool |
| `hostileRegion` | public bool |
| `Controller` | public RegionController |
| `NuclearDetonationEventName` | private string |
| `ArmyEmbarkEventName` | public string |
| `ArmySeaTransitEventName` | public string |
| `annexationEndDate` | public TIDateTime |
| `GetOccupierNation` | public TINationState |
| `population` | public float |
| `populationDensity` | public float |
| `annualPopulationGrowth` | public double |
| `Regions` | public static IEnumerable<TIRegionState> |
| `CoastalRegions` | public static IEnumerable<TIRegionState> |
| `Neighbors` | public IEnumerable<TIRegionState> |
| `ConnectedRegions` | public IEnumerable<TIRegionState> |
| `maxMissionControl` | public int |
| `canLaunch` | public bool |
| `baseSTOFireStr` | public string |
| `numSTOFightersOnCooldown` | public int |
| `maxSTOFighters` | public int |
| `availableSTOFighters` | public int |
| `fighterSquadronName` | public string |
| `canAddSTOFighter` | public bool |
| `adjacencies` | private Dictionary<TIRegionState, TerrestrialAdjacencyType> |
| `missionControl` | public int |
| `boostPerYear_dekatons` | public float |
| `coreEconomicRegion` | public bool |
| `resourceRegion` | public bool |
| `oilRegion` | public bool |
| `colonyRegion` | public bool |
| `permanentlyDecolonized` | public bool |
| `nuclearDetonations` | public int |
| `oceanType` | public WorldOceanType |
| `_spaceBody` | private TISpaceBodyState |
| `numSTOFighters` | public int |
| `STOFighterCooldownExpiry` | public List<TIDateTime> |
| `spaceFacilities` | public List<TIRegionSpaceFacilityState> |
| `boostFacility` | public TILaunchFacilityState |
| `missionControlFacility` | public TIMissionControlFacilityState |
| `spaceDefenseFacility` | public TISpaceDefensesFacilityState |
| `armies` | public List<TIArmyState> |
| `abductions` | public int |
| `gameTime` | private GameTimeManager |
| `_mapRegionTemplate` | private TIMapRegionTemplate |
| `localized_coordinates_offset` | private Vector3 |
| `_claimsOnRegion` | private List<TINationState> |
| `originalColony` | public TINationState |
| `accumulatedCoreEconomyRegionTriggers` | public int |
| `accumulatedCoreOilRegionTriggers` | public int |
| `accumulatedCoreMiningRegionTriggers` | public int |
| `accumulatedDecolonizeTriggers` | public int |
| `accumulatedDecontaminateTriggers` | public int |
| `gameStateSubjectCreated` | private bool |
| `regionSizeFactor` | private float |
| `standardLocalPosition` | private Vector3d |
| `_distanceToRegion` | private Dictionary<TIRegionState, float> |
| `neighbors` | private List<TIRegionState> |
| `cooldownForHealthyFighter_days` | public const int |
| `cooldownForDamagedFighter_days` | public const int |
| `maxMaxSTOFighters_Region` | public const int |
| `boostDivisorForMaxSTOFighters` | public const float |

### Properties

- `public TINationState nation`
- `public TINationState leadOccupier`
- `public Dictionary<TINationState, float> occupations`
- `public float populationInMillions`
- `public bool antiSpaceDefenses`
- `public bool underBombardment`
- `public bool isCounterfiring`
- `public TIRegionAlienFacilityState alienFacility`
- `public TIRegionAlienActivityState alienActivity`
- `public TIRegionUFOLandingState alienLanding`
- `public TIRegionUFOCrashdownState alienCrashdown`
- `public TIRegionXenoformingState xenoforming`
- `public float annualPopGrowthModifier`
- `public bool isBeingAnnexed`
- `public TIArmyState annexingArmy`
- `public TIDateTime annexationBeginDate`
- `public float annexationDaysLeft`

### Methods

```csharp
public Vector3d GetLocalPosition(TIDateTime time)
```

```csharp
public float GetDistanceEstimate_km(TIRegionState other)
```

```csharp
public Vector3d GetGlobalPosition(TIDateTime time)
```

```csharp
public override void InitWithTemplate(TIDataTemplate template)
```

```csharp
public void InitializePostCampaignCreation()
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
public float NationalGDPProportion()
```

```csharp
public float GlobalGDPProportion()
```

```csharp
public static Dictionary<TIRegionState, float> GlobalGDPProportions()
```

```csharp
public string IconString(TIFactionState faction)
```

```csharp
public float DistanceToRegion_km(TIRegionState region)
```

```csharp
public static float DistanceBetweenTwoCoordinates_km(float lat1, float long1, float lat2, float long2, double planetRadius_km)
```

```csharp
public IEnumerable<WaterBody> GetBorderingWaterBodies()
```

```csharp
public IEnumerable<WaterBody> GetAccessibleWaterBodies(TINationState askingNation)
```

```csharp
public bool CanalRegion()
```

```csharp
public static bool SuezAccess(TINationState askingNation)
```

```csharp
public static bool PanamaAccess(TINationState askingNation)
```

```csharp
public static bool TurkishStraitAccess(TINationState askingNation)
```

```csharp
public static float SeaTravelMultiplier(TINationState movingNation, TIRegionState region1, TIRegionState region2)
```

```csharp
public bool Battle()
```

```csharp
public bool BorderWithAnotherNation(bool enemiesOnly)
```

```csharp
public void DestroySpaceAssets(bool attack)
```

```csharp
public void DestroySpaceFacility(SpaceFacilityType facilityType, bool attack)
```

```csharp
public void ChangeNuclearDetonations(int value)
```

```csharp
public void NuclearAttackOnRegion(TIFactionState launchingFaction, TINationState launchingNation = null)
```

```csharp
public void NationLaunchedNuclearAttackArrival(TimeEventStart e)
```

```csharp
public void OnNuclearAttackArrives(TIFactionState applyingFaction, TINationState applyingNation = null)
```

```csharp
public void ApplyDamageToRegion(float strength, TIFactionState applyingFaction = null, TINationState applyingNation = null, bool includeArmies = true, bool includeCouncilors = false, bool forceAttackSpaceAssets = false, bool nuclear = false)
```

```csharp
private void CompleteOccupationofRegion(TIArmyState army)
```

```csharp
public void LiberateMyRegion()
```

```csharp
public void SetLeadOccupier()
```

```csharp
public bool IsFullyOccupied()
```

```csharp
public bool OccupiedOrOccupationUnderway()
```

```csharp
public bool OccupationUnderwayButNotComplete()
```

```csharp
public bool NoOccupationUnderwayOrComplete()
```

```csharp
public void ValidateAndCleanOccupations()
```

```csharp
public TINationState GetLeadOccupierInFullOccupation()
```

```csharp
public List<TINationState> GetOccupyingAlliance(bool ordered = false)
```

```csharp
public bool PartofOccupyingAlliance(TINationState nation)
```

```csharp
public float GetIndividualOccupationValue(TINationState occupyingNation)
```

```csharp
public float GetHighestWarAllianceOccupationValueByNation(TINationState occupyingNation, out TINationState allianceLeader)
```

```csharp
public float GetHighestWarAllianceOccupationValue(out TINationState leaderOfLeadingAlliance, out List<TINationState> occupyingAlliance)
```

```csharp
public void CheckAndTriggerOccupation(TIArmyState army)
```

```csharp
public void IncreaseOccupationValue(TINationState occupyingNation, float value, TIArmyState army = null)
```

```csharp
public void SetOccupationValue(TINationState occupyingNation, float value, TIArmyState army = null)
```

```csharp
public float RegionArmyActionMultiplier(bool invert = true)
```

```csharp
public bool ValidRegionToAnnexOrLiberate(TIArmyState army)
```

```csharp
public void BeginAnnexation(TIArmyState annexingArmy, float days)
```

```csharp
public void EndAnnexation()
```

```csharp
public float PercentAnnexed()
```

```csharp
public static TINationState LiberationTarget(TIArmyState liberatingArmy)
```

```csharp
public bool CheckAndEndAnnexation(bool force)
```

```csharp
public void AnnexationDay()
```

```csharp
public List<TIArmyState> FilteredArmiesPresent(bool includeNations, bool includeAllAllies, bool includeNationsEnemies, bool includeAtSea, bool includeOnlyWarActiveAllies)
```

```csharp
public int NumArmiesPresent(bool includeNations, bool includeAllies, bool includeEnemies, bool includeOnlyWarActiveAllies)
```

```csharp
public List<TIArmyState> MegafaunaArmiesPresent()
```

```csharp
public List<TIArmyState> FactionArmiesPresent(TIFactionState faction, bool includeNations, bool includeAllies, bool includeEnemies, bool includeMegafauna)
```

```csharp
public int NumFactionArmiesPresent(TIFactionState faction, bool includeNations, bool includeAllies, bool includeEnemies, bool includeMegafauna)
```

```csharp
public float GenericLocalForcesDefenseLevel(bool modifyForCohesion)
```

```csharp
public void GrowPopulationByMonth()
```

```csharp
public void ChangePopulation_Millions(float value, bool modifyGDPForChange = true)
```

```csharp
public float PropagandaOnPop(TIFactionIdeologyTemplate targetIdeologyTemplate, float strength)
```

```csharp
public void ChangeAnnualPopulationGrowthModifier(float value)
```

```csharp
public bool ClaimedBy(TINationState nationState, bool requireExtantNation = false, bool requireProjectGatePassed = true, bool includeCurrentOwner = true)
```

```csharp
public void AddClaim(TINationState nation)
```

```csharp
public void RemoveClaim(TINationState nation)
```

```csharp
public List<TINationState> SecessionCandidates()
```

```csharp
public List<TINationState> NationsWithClaim(bool requireExtantNation = false, bool requireExtantClaim = true, bool includeCurrentOwner = true, bool capitalsOnly = false)
```

```csharp
public List<TIRegionState> ThisAndAdjacentRegions(bool IAmAnInvadingArmy)
```

```csharp
public List<TINationState> AdjacentNations(bool includingOwner, bool IAmAnInvadingArmy)
```

```csharp
public List<TIRegionState> AdjacentRegions(bool IAmAnInvadingArmy)
```

```csharp
public TerrestrialAdjacencyType GetAdjacencyType(TIRegionState regionState)
```

```csharp
public bool IsAdjacent(TIRegionState region, bool IAmAnInvadingArmy)
```

```csharp
public void ChangeAdjacency(TIRegionState region, TerrestrialAdjacencyType newAdjacencyType)
```

```csharp
private void SetAdjacencies()
```

```csharp
public void ChangeOceanType(WorldOceanType newOceanType)
```

```csharp
public List<TICouncilorState> GetCouncilorsInRegion()
```

```csharp
public List<TICouncilorState> GetVisibleCouncilorsInRegion(TIFactionState faction)
```

```csharp
public void ConductAbductions(TIFactionState faction, int number)
```

```csharp
public float GetAbductionsMissionBonusFromRegion()
```

```csharp
public TIRegionState NearestInSupraRegion(bool includeIslands)
```

```csharp
public bool AllowedDestinationForAlienCouncilor(TICouncilorState councilor)
```

```csharp
public List<TICouncilorState> GetProtectors()
```

```csharp
public float GetProtectionBonus(CouncilorAttribute attribute)
```

```csharp
public TIRegionSpaceFacilityState GetRegionSpaceFacility(SpaceFacilityType facilityType)
```

```csharp
public int ChangeSpaceFacilityValue(SpaceFacilityType facilityType, float fValue = 0f, bool bValue = false, bool attack = false)
```

```csharp
public void UnderBombardment()
```

```csharp
public void EndBombardment(TISpaceFleetState endingFleet)
```

```csharp
public void SetSTOFighterOnCooldown(int duration_days)
```

```csharp
public void CheckSTOFighterCooldowns()
```

```csharp
public void DestroyRandomSTOFighter()
```

```csharp
public void DestroyAllSTOFighters(bool forceUpdate = false)
```
