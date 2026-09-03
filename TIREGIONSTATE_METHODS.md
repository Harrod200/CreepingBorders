# TIRegionState - Complete Method and Property Reference

## Overview
`TIRegionState` is the game state class representing regions in Terra Invicta. It inherits from `TIGameState`.

---

## Public Properties

### Region Ownership & Status
- `TINationState nation` - The nation that controls this region
- `TINationState leadOccupier` - The lead nation occupying this region
- `Dictionary<TINationState, float> occupations` - Dictionary of occupying nations and their occupation values
- `float populationInMillions` - Population in millions

### Military & Defense
- `bool antiSpaceDefenses` - Whether region has anti-space defenses
- `bool underBombardment` - Whether region is under bombardment
- `bool isCounterfiring` - Whether region is firing back at attack
- `TIRegionAlienFacilityState alienFacility` - Alien facility in region
- `TIRegionAlienActivityState alienActivity` - Current alien activity
- `TIRegionUFOLandingState alienLanding` - UFO landing state
- `TIRegionUFOCrashdownState alienCrashdown` - UFO crashdown state
- `TIRegionXenoformingState xenoforming` - Xenoforming state

### Annexation & Control
- `bool isBeingAnnexed` - Whether annexation is in progress
- `float annexationDaysLeft` - Days remaining for annexation
- `TIArmyState annexingArmy` - Army performing annexation
- `TIDateTime annexationBeginDate` - When annexation started

### Population & Economics
- `float annualPopGrowthModifier` - Modifier for population growth

---

## Public Methods

### Occupation & Control
- `void CheckAndTriggerOccupation(TIArmyState army)` - Check and trigger occupation
- `void IncreaseOccupationValue(TINationState occupyingNation, float value, TIArmyState army = null)` - Increase occupation value
- `void SetOccupationValue(TINationState occupyingNation, float value, TIArmyState army = null)` - Set occupation value
- `bool IsFullyOccupied()` - Check if region is fully occupied
- `bool OccupiedOrOccupationUnderway()` - Check occupation status
- `bool OccupationUnderwayButNotComplete()` - Check if occupation in progress
- `bool NoOccupationUnderwayOrComplete()` - Check if no occupation
- `void ValidateAndCleanOccupations()` - Validate and clean occupation data
- `TINationState GetLeadOccupierInFullOccupation()` - Get lead occupier if fully occupied
- `bool PartofOccupyingAlliance(TINationState nation)` - Check if nation part of occupying alliance
- `float GetIndividualOccupationValue(TINationState occupyingNation)` - Get individual occupation value
- `float GetHighestWarAllianceOccupationValueByNation(TINationState occupyingNation, out TINationState allianceLeader)` - Get highest occupation value
- `float GetHighestWarAllianceOccupationValue(out TINationState leaderOfLeadingAlliance, out List<TINationState> occupyingAlliance)` - Get highest alliance occupation
- `void SetLeadOccupier()` - Set lead occupier
- `List<TINationState> GetOccupyingAlliance(bool ordered = false)` - Get occupying alliance

### Annexation & Liberation
- `void BeginAnnexation(TIArmyState annexingArmy, float days)` - Begin annexation process
- `void EndAnnexation()` - End annexation
- `float PercentAnnexed()` - Get annexation percentage
- `bool CheckAndEndAnnexation(bool force)` - Check and end annexation
- `void AnnexationDay()` - Process annexation day
- `bool ValidRegionToAnnexOrLiberate(TIArmyState army)` - Check if valid for annexation/liberation
- `void LiberateMyRegion()` - Liberate this region
- `static TINationState LiberationTarget(TIArmyState liberatingArmy)` - Get liberation target

### Claims & Adjacency
- `bool ClaimedBy(TINationState nationState, bool requireExtantNation = false, bool requireProjectGatePassed = true, bool includeCurrentOwner = true)` - Check if claimed
- `void AddClaim(TINationState nation)` - Add claim
- `void RemoveClaim(TINationState nation)` - Remove claim
- `List<TINationState> NationsWithClaim(bool requireExtantNation = false, bool requireExtantClaim = true, bool includeCurrentOwner = true, bool capitalsOnly = false)` - Get nations with claims
- `bool IsAdjacent(TIRegionState region, bool IAmAnInvadingArmy)` - Check if adjacent
- `void ChangeAdjacency(TIRegionState region, TerrestrialAdjacencyType newAdjacencyType)` - Change adjacency
- `TerrestrialAdjacencyType GetAdjacencyType(TIRegionState regionState)` - Get adjacency type
- `List<TIRegionState> AdjacentRegions(bool IAmAnInvadingArmy)` - Get adjacent regions
- `List<TIRegionState> ThisAndAdjacentRegions(bool IAmAnInvadingArmy)` - Get this and adjacent regions
- `List<TINationState> AdjacentNations(bool includingOwner, bool IAmAnInvadingArmy)` - Get adjacent nations

### Population & Growth
- `void GrowPopulationByMonth()` - Grow population monthly
- `void ChangePopulation_Millions(float value, bool modifyGDPForChange = true)` - Change population
- `void ChangeAnnualPopulationGrowthModifier(float value)` - Change growth modifier
- `float PropagandaOnPop(TIFactionIdeologyTemplate targetIdeologyTemplate, float strength)` - Apply propaganda

### Military Operations
- `int NumArmiesPresent(bool includeNations, bool includeAllies, bool includeEnemies, bool includeOnlyWarActiveAllies)` - Count armies
- `int NumFactionArmiesPresent(TIFactionState faction, bool includeNations, bool includeAllies, bool includeEnemies, bool includeMegafauna)` - Count faction armies
- `float GenericLocalForcesDefenseLevel(bool modifyForCohesion)` - Get defense level
- `float RegionArmyActionMultiplier(bool invert = true)` - Get action multiplier
- `List<TIArmyState> ArmiesPresent()` - Get armies present
- `List<TIArmyState> AllArmiesPresent(TIFactionState faction, bool includeNations, bool includeAllies, bool includeEnemies, bool includeMegafauna)` - Get all armies
- `List<TIArmyState> MegafaunaArmiesPresent()` - Get megafauna armies

### Nuclear & Bombing
- `void NuclearAttackOnRegion(TIFactionState launchingFaction, TINationState launchingNation = null)` - Launch nuclear attack
- `void NationLaunchedNuclearAttackArrival(TimeEventStart e)` - Nuclear attack arrival event
- `void OnNuclearAttackArrives(TIFactionState applyingFaction, TINationState applyingNation = null)` - Handle nuclear attack
- `void ApplyDamageToRegion(float strength, TIFactionState applyingFaction = null, TINationState applyingNation = null, bool includeArmies = true, bool includeCouncilors = false, bool forceAttackSpaceAssets = false, bool nuclear = false)` - Apply damage
- `void ChangeNuclearDetonations(int value)` - Change nuclear detonations
- `void UnderBombardment()` - Mark as under bombardment
- `void EndBombardment(TISpaceFleetState endingFleet)` - End bombardment

### Alien Operations
- `void ConductAbductions(TIFactionState faction, int number)` - Conduct abductions
- `float GetAbductionsMissionBonusFromRegion()` - Get abduction bonus
- `bool AllowedDestinationForAlienCouncilor(TICouncilorState councilor)` - Check alien councilor destination
- `float GetProtectionBonus(CouncilorAttribute attribute)` - Get protection bonus
- `void DestroySpaceAssets(bool attack)` - Destroy space assets
- `void DestroySpaceFacility(SpaceFacilityType facilityType, bool attack)` - Destroy specific facility

### Space Facilities
- `TIRegionSpaceFacilityState GetRegionSpaceFacility(SpaceFacilityType facilityType)` - Get space facility
- `int ChangeSpaceFacilityValue(SpaceFacilityType facilityType, float fValue = 0f, bool bValue = false, bool attack = false)` - Change facility value
- `void SetSTOFighterOnCooldown(int duration_days)` - Set STO fighter cooldown
- `void CheckSTOFighterCooldowns()` - Check STO fighter cooldowns
- `void DestroyRandomSTOFighter()` - Destroy random STO fighter
- `void DestroyAllSTOFighters(bool forceUpdate = false)` - Destroy all STO fighters

### Councils & Presence
- `List<TICouncilorState> GetCouncilorsInRegion()` - Get councilors in region
- `List<TICouncilorState> GetProtectors()` - Get protectors
- `List<TICouncilorState> GetVisibleCouncilorsInRegion(TIFactionState faction)` - Get visible councilors

### Territory & Neighboring
- `TIRegionState NearestInSupraRegion(bool includeIslands)` - Get nearest region in supra-region
- `void ChangeOceanType(WorldOceanType newOceanType)` - Change ocean type
- `List<TINationState> SecessionCandidates()` - Get secession candidates

### Positioning & Coordinates
- `Vector3d GetGlobalPosition(TIDateTime time)` - Get global position
- `Vector3d GetLocalPosition(TIDateTime time)` - Get local position

### Static Utilities
- `static bool PanamaAccess(TINationState askingNation)` - Check Panama Canal access
- `static bool SuezAccess(TINationState askingNation)` - Check Suez Canal access
- `static bool TurkishStraitAccess(TINationState askingNation)` - Check Turkish Strait access
- `static Dictionary<TIRegionState, float> GlobalGDPProportions()` - Get global GDP proportions
- `static float DistanceBetweenTwoCoordinates_km(float lat1, float long1, float lat2, float long2, double planetRadius_km)` - Calculate distance between coordinates
- `static float SeaTravelMultiplier(TINationState movingNation, TIRegionState region1, TIRegionState region2)` - Get sea travel multiplier

### Initialization & Lifecycle
- `override void InitWithTemplate(TIDataTemplate template)` - Initialize with template
- `override void PostAllStartUpInit_5()` - Post startup init
- `override void PostCanvasManagerCreateInit_3()` - Post canvas manager init
- `override void PostGlobalGameStateCreateInit_2()` - Post game state init
- `void InitializePostCampaignCreation()` - Initialize post-campaign

### Display & UI
- `string IconString(TIFactionState faction)` - Get icon string for faction

---

## Common Usage Patterns

### Check Region Ownership
```csharp
if (region.nation == targetNation)
{
	// Region is owned by target nation
}
```

### Get Adjacent Regions
```csharp
var adjacent = region.AdjacentRegions(false);
foreach (var adjRegion in adjacent)
{
	// Process adjacent region
}
```

### Check Adjacency Between Regions
```csharp
if (region1.IsAdjacent(region2, false))
{
	// Regions are adjacent
}
```

### Calculate Distance
```csharp
float distance = TIRegionState.DistanceBetweenTwoCoordinates_km(
	region1.latitude, region1.longitude,
	region2.latitude, region2.longitude,
	planet.meanRadius_km);
```

### Check Claims
```csharp
bool hasClaim = region.ClaimedBy(nation);
var claimants = region.NationsWithClaim();
```

### Get Occupying Nations
```csharp
var occupiers = region.GetOccupyingAlliance();
float totalOccupation = 0;
foreach (var occupier in region.occupations)
{
	totalOccupation += occupier.Value;
}
```

---

## Notes
- Methods marked as `static` can be called without an instance
- Properties with private setters can only be modified through specific methods
- Many methods take boolean parameters for filters (e.g., `includingOwner`, `includeAllies`)
- Distance calculations use actual planetary coordinates and mean radius

