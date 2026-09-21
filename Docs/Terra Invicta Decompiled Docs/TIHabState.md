# TIHabState

*Decompiled from `PavonisInteractive/TerraInvicta/TIHabState.cs`.*


## Class `TIHabState`

```csharp
public class TIHabState : TISpaceAssetState, OfficerCarrierState
```

### Fields

| Name | Type |
|---|---|
| `HabSchematic` | public HabSchematic |
| `ConflictFleets` | public IEnumerable<TISpaceFleetState> |
| `isHabState` | public override bool |
| `searchable` | public override Searchable |
| `ref_hab` | public override TIHabState |
| `ref_orbit` | public override TIOrbitState |
| `ref_spaceBody` | public override TISpaceBodyState |
| `ref_faction` | public override TIFactionState |
| `ref_habSite` | public override TIHabSiteState |
| `ref_spaceObject` | public override TISpaceObjectState |
| `ref_naturalSpaceObject` | public override TINaturalSpaceObjectState |
| `ref_lagrangePoint` | public override TILagrangePointState |
| `ref_spaceAsset` | public override TISpaceAssetState |
| `IsBase` | public bool |
| `IsStation` | public bool |
| `numActiveSectors` | public int |
| `activeSectors` | public List<TISectorState> |
| `MineSlot` | public TIHabModuleState |
| `CoreSlot` | public TIHabModuleState |
| `numCompletedModules` | public int |
| `coreSector` | public TISectorState |
| `coreModule` | public TIHabModuleState |
| `coreFaction` | public TIFactionState |
| `template` | public new TIHabTemplate |
| `objectType` | public override SpaceObjectType |
| `iconResource` | public override string |
| `modelResource` | public override string |
| `meanRadius_km` | public override double |
| `meanRadius_m` | public override double |
| `modelScale` | public override float |
| `location` | public override TISpaceGameState |
| `maxCouncilors` | public int |
| `irradiated` | public bool |
| `irradiatedMultiplier` | public float |
| `localGravity_gs` | public double |
| `mass_kg` | public override double |
| `decommissioning` | public bool |
| `HasMine` | public bool |
| `HasMineFunctional` | public bool |
| `HasActiveMine` | public bool |
| `HasInactiveButPowerableMine` | public bool |
| `mine` | public TIHabModuleState |
| `crew` | public int |
| `GetSunOrbitingRelatedObject` | public override TISpaceObjectState |
| `maxTier` | public int |
| `LocationName` | public string |
| `altitude` | public double |
| `description` | public string |
| `MayHaveFluctuatingIncomes` | public bool |
| `controlPointCapacityValue` | public int |
| `AdministrationAdviserMultiplier` | public float |
| `CommandAdviserMultiplier` | public float |
| `ScienceAdviserMultiplier` | public float |
| `maxSectors` | public const int |
| `maxSectorIdx` | public const int |
| `sectors` | public List<TISectorState> |
| `districts` | public List<TIHabDistrictState> |
| `habSite` | public TIHabSiteState |
| `councilorsOnBoard` | public List<TICouncilorState> |
| `officersOnBoard` | public List<TIOfficerState> |
| `customHabIconResource` | public string |
| `anyCoreCompleted` | public bool |
| `coreDefended` | public bool |
| `gameStateSubjectCreated` | private bool |
| `_dockedShipAbovePositions` | public TIConeLayoutState |
| `netAnnualIncomes` | private Dictionary<TIFactionState, Dictionary<FactionResource, float>> |
| `administrationModuleModifier` | private float |
| `habSchematicTemplateName` | private string |
| `HabSchematicAssignedDate` | public TIDateTime |
| `habSchematic` | private HabSchematic |
| `habSchematic_SaveRepair` | private HabSchematic |
| `conflictFleets` | private HashSet<TISpaceFleetState> |
| `baseObject` | private GameObject |
| `cachedOkayModules` | private List<TIHabModuleState> |
| `okayModulesCachedFrame` | private int |
| `cachedFunctionalModules` | private List<TIHabModuleState> |
| `functionalModulesCachedFrame` | private int |
| `allowSupplyTheft` | private const bool |
| `FarmProvidedResources` | public readonly List<FactionResource> |
| `cachedMonthlyRevenue` | private Dictionary<FactionResource, float> |
| `monthlyRevenueCachedFrame` | private int |
| `enemyFleetInLineOfSight` | private Dictionary<TISpaceFleetState, bool> |
| `cachedLOSCheckTime` | private TIDateTime |
| `HabMetrics` | public static readonly HabMetric[] |
| `RingStruct` | public struct |
| `NE` | public bool |
| `NW` | public bool |
| `SE` | public bool |
| `SW` | public bool |
| `BaseConnectionStruct` | public struct |
| `C42` | public bool |
| `C16` | public bool |
| `C36` | public bool |
| `C46` | public bool |
| `C56` | public bool |
| `C76` | public bool |
| `ModulePlacementOrder` | private struct |
| `module` | public string |
| `sector` | public int |
| `slot` | public int |

### Properties

- `public HabType habType`
- `public int tier`
- `public List<TICouncilorState> advisingCouncilors`
- `public List<TISpaceFleetState> dockedFleets`
- `public TIHabState.RingStruct ringStruct`
- `public TIHabState.BaseConnectionStruct connStruct`
- `public bool underAssault`
- `public TIDateTime coreDefendExpiration`
- `public bool createdFromTemplate`
- `public bool inEarthLEO`
- `public bool staticHab`
- `public bool underBombardment`

### Methods

```csharp
public TIGameState GetTargetableState()
```

```csharp
public List<TIHabModuleState> AllModuleStates()
```

```csharp
public List<TIHabModuleState> AllModules()
```

```csharp
public List<TIHabModuleState> CompletedModules()
```

```csharp
public List<TIHabModuleState> OkayModules()
```

```csharp
public List<TIHabModuleState> FunctionalModules()
```

```csharp
public List<TIHabModuleState> ActiveModules()
```

```csharp
public List<TIHabModuleState> UnpoweredModules()
```

```csharp
public List<TIHabModuleState> ActiveCombatModules()
```

```csharp
public List<TIHabModuleState> FunctionalCombatModules()
```

```csharp
public List<TIHabModuleState> UnderConstructionModules()
```

```csharp
public List<TIHabModuleState> PresentModules()
```

```csharp
public List<TIHabModuleState> AvailableSlots()
```

```csharp
public List<TIHabModuleState> AllSlots()
```

```csharp
public List<TIHabModuleState> CompletedShipyards()
```

```csharp
public void SetModulesDirty()
```

```csharp
public bool CanSellResources(TIFactionState faction)
```

```csharp
public override bool IsAlien()
```

```csharp
public bool HasAnyFunctionalModules(bool skipCoreModule = false)
```

```csharp
public static bool IsMineSlot(int sector, int slot, HabType habType)
```

```csharp
public TIHabModuleState GetModule(int sector, int moduleNum)
```

```csharp
public override float CombatRange_km()
```

```csharp
public int MissionControlCost(bool allowNegativeReturn, TIFactionState faction = null)
```

```csharp
public static int maxModules(int tier)
```

```csharp
public static bool IsModuleAllowedForHab(TIFactionState faction, TIGameState location, TIHabModuleTemplate moduleTemplate, IEnumerable<TIHabModuleTemplate> existingModules = null, bool skipOnePerHabUpgradeCheckForDowngrade = false)
```

```csharp
public bool IsModuleAllowedForThisHab(TIFactionState faction, TIHabModuleTemplate moduleTemplate, bool downGradingOnePerHabModule = false)
```

```csharp
public List<TIHabModuleTemplate> AllowedModules(TIFactionState faction)
```

```csharp
public bool ModuleFunctioning(TIHabModuleTemplate moduleTemplate, bool includeUpgradePrereqs = false)
```

```csharp
public bool ModuleUpgradePrereqModuleAlreadyOnHab(TIHabModuleTemplate candidateUpgradeModuleTemplate)
```

```csharp
public bool HasAnyActiveModuleInUpgradeChain(TIHabModuleTemplate moduleTemplate)
```

```csharp
public bool GetUpgradeModuleLocation(TIHabModuleTemplate candidateUpgradeModuleTemplate, out int sector, out int moduleSlot)
```

```csharp
public bool OnlyUpgradeAllowed(TIHabModuleTemplate moduleTemplate)
```

```csharp
public List<TIHabModuleState> ModulesElgibleForUpgradeTo(TIHabModuleTemplate candidateUpgradeModuleTemplate)
```

```csharp
public TIHabModuleState GetSlotForNewModule(TIHabModuleTemplate moduleTemplate, bool allowUpgrades = true, IEnumerable<TIHabModuleState> slots = null)
```

```csharp
public override float SpaceCombatValue()
```

```csharp
public float FleetTargetingBonus()
```

```csharp
public float FleetECMBonus()
```

```csharp
public float AggregateDefensiveScore_Station()
```

```csharp
public float PerceivedAggregateDefensiveScore_Station(TIFactionState enemyFaction)
```

```csharp
public bool IsSafeToVisit(TISpaceFleetState fleet)
```

```csharp
public bool AllowsShipConstruction(TIFactionState faction = null, bool checkInactives = false, bool checkUnderConstruction = false)
```

```csharp
public int ResupplySpeedDivisor()
```

```csharp
public float DaysUntilCanStartResupply()
```

```csharp
public bool CanFullyRepairFleet(TISpaceFleetState fleet)
```

```csharp
public bool CanPartiallyRepairFleet(TISpaceFleetState fleet)
```

```csharp
public bool CanPartiallyRepairShip(TISpaceShipState ship)
```

```csharp
private bool CanFullyRepairShip(TISpaceShipState ship)
```

```csharp
public bool CanBuildAndRepairShipPart(TIShipPartTemplate part)
```

```csharp
public void CompleteShipConstruction(TISpaceShipState newShip, TISpaceShipState refitFrom = null)
```

```csharp
public int RepairSpeedDivisor()
```

```csharp
public float DaysUntilCanStartRepair()
```

```csharp
public bool AllowsResupply(TIFactionState checkingFaction, bool allowHumanTheft, bool checkInactives = false)
```

```csharp
public void UpdateAllModuleConstructionTimes()
```

```csharp
public float GetModuleConstructionTimeModifier(bool checkInactives = false, TIHabModuleState excludeModule = null)
```

```csharp
public bool DropTroops(TIFactionState faction)
```

```csharp
public List<HabModuleSpecialRule> ActiveSpecialAbilities(TIFactionState faction)
```

```csharp
public List<HabModuleSpecialRule> SpecialAbilities(TIFactionState faction)
```

```csharp
public List<TISpaceShipTemplate> ShipsBeingBuiltAtHab(TIFactionState faction)
```

```csharp
public IEnumerable<ShipConstructionQueueItem> AllShipConstructionQueueItems(TIFactionState faction)
```

```csharp
public bool HasResourceIncomeForFaction(FactionResource resource, TIFactionState faction)
```

```csharp
public bool AtLeastOneSectorHasIncome(FactionResource resource)
```

```csharp
public float GetNetTechBonusByFaction(TechCategory category, TIFactionState faction, bool includeInactives)
```

```csharp
public bool AtLeastOneCoreSectorHasTechBonus(TechCategory techCategory, bool includeInactives)
```

```csharp
public static float GetIrradiatedMultiplier(TISpaceGameState location)
```

```csharp
public override void InitWithTemplate(TIDataTemplate rawTemplate)
```

```csharp
public override void PostGameStateCreateInit_OnCreationOnly_1()
```

```csharp
public override void PostGlobalGameStateCreateInit_2()
```

```csharp
public override void PostAllStartUpInit_5()
```

```csharp
public override void PostVisualizerCreationInit_7()
```

```csharp
public override void PostEverythingSaveRepair_8()
```

```csharp
public void InitializeNewHab(TIFactionState faction, TIGameState exactLocation, TIGameState founder, int tierSetting, float deliveryTime_days, List<string> additionalModuleNames = null)
```

```csharp
public override void CreateVisualizer(TIDataTemplate myTemplate)
```

```csharp
public void InitializeSector(TIFactionState faction, int sectorNum)
```

```csharp
public void InitializeIncomes()
```

```csharp
public void OnHabCreated()
```

```csharp
public void SetFaction(TIFactionState faction)
```

```csharp
public void SetCustomIconString(string iconString)
```

```csharp
public string CaptureHab(TIFactionState capturingFaction, int successLevel, bool traded = false, bool defected = false, Dictionary<TIFactionState, string> factionStrings = null, TISpaceFleetState capturingFleet = null)
```

```csharp
public TIHabModuleState SelectModuleToDestroy()
```

```csharp
public TIHabModuleState SelectModuleToDestroy_Marines()
```

```csharp
public TIHabModuleState SelectModuleToDestroy_Power()
```

```csharp
public IEnumerator DestroyModuleFromCombatDelayed(TIFactionState destroyer, TIHabModuleState moduleToDestroy, float delay)
```

```csharp
public bool DestroyModule(TIFactionState destroyer, TIHabModuleState moduleToDestroy, bool suppressLogging = false, bool skipFullDestructioncheck = false, bool alwaysAlert = true, float hate = 0f, bool skipRepowerOrder = false, bool fromMission = false)
```

```csharp
public bool DestroyModule(TIFactionState destroyer, TIHabModuleState moduleToDestroy, out int accumulatedAtrocities_Killer, out int accumulatedAtrocities_Loser, bool suppressLogging = false, bool skipFullDestructioncheck = false, bool alwaysAlert = true, float hate = 0f, bool skipRepowerOrder = false, bool fromMission = false, bool dontProcessAtrocitiesLocally = false)
```

```csharp
public int AtrocitiesFromDestruction()
```

```csharp
public int AtrocitiesFromLoss()
```

```csharp
public void PostCombat()
```

```csharp
public bool CoreInTransit()
```

```csharp
public void DestroyHab(TIFactionState destroyer, float recoveryMultiplier, bool peacefulDecommission = false, TISpaceFleetState destroyingFleet = null, float bonusExotics = 0f)
```

```csharp
public void BeginDecommissionModule(TIHabModuleState module)
```

```csharp
public void CompleteDecommissionModule(TIHabModuleState module, bool clearPriorModule)
```

```csharp
public TIResourcesCost DecommissionHabCost()
```

```csharp
public bool CanDecommissionHab()
```

```csharp
public TIResourcesCost DecommissionHabRefund()
```

```csharp
public void BeginDecommissionHab()
```

```csharp
public void DecommissionHab()
```

```csharp
public void ConstructFoundingModule(string moduleTemplateName, int sector, int slot, float deliveryAndBuildTime_days)
```

```csharp
public void InitiateModuleConstruction(TISectorState sector, int slot, TIHabModuleTemplate moduleTemplate, TIResourcesCost cost)
```

```csharp
public void CompleteModuleConstruction(TIHabModuleState module)
```

```csharp
public void UpdateAllModuleConnectors()
```

```csharp
public TIHabState.RingStruct ActivateRings()
```

```csharp
public TIHabState.BaseConnectionStruct ActivateBaseConnections()
```

```csharp
public List<TIHabModuleState> RebuildCandidates()
```

```csharp
public TIResourcesCost FullRebuildCost()
```

```csharp
public List<TIHabModuleState> UpgradeCandidates()
```

```csharp
public TIResourcesCost FullUpgradeCost()
```

```csharp
public List<TIHabModuleState> UpgradeCandidates(TIHabModuleTemplate template)
```

```csharp
public TIResourcesCost FullUpgradeCost(TIHabModuleTemplate template, bool allowSubstitutions)
```

```csharp
public TIHabTemplate ConvertToTemplate(TIFactionState faction)
```

```csharp
public bool CanApplySavedTemplate(TIHabTemplate newTemplate)
```

```csharp
public List<TIHabModuleTemplate> ApplySavedTemplate(TIHabTemplate newTemplate, bool prospectiveOnly, bool replaceExisting, out TIResourcesCost baselineCost, out float netPower, out List<TIHabModuleTemplate> rejectedModules)
```

```csharp
public void UpdatePowerAndResourceValues_N(bool turnEverythingOn = false, TIHabModuleState modulePowerJustSet = null)
```

```csharp
public float GetAnnualNetResourceIncome(TIFactionState faction, FactionResource resource)
```

```csharp
public void UpdateCurrentAnnualNetResourceIncomes(bool suppressFactionResourcesUpdatedEvent = false)
```

```csharp
public int FarmCrewDiscount()
```

```csharp
public float FarmCrewCoveredPct()
```

```csharp
public float GetMonthlySupportCost(FactionResource resource, bool includeInactivesIncomeAndSupport = false)
```

```csharp
public float GetNetCurrentMonthlyIncome(TIFactionState faction, FactionResource resource, bool includeInactivesIncomeAndSupport, bool useCache = false)
```

```csharp
public float GetMonthlyRevenue(FactionResource resource, bool dontRecalculate = false)
```

```csharp
public float GetMonthlyRevenue_WithAdviser(FactionResource resource, bool dontRecalculate = false)
```

```csharp
public float GetYearlyRevenue(FactionResource resource, bool dontRecalculate = false)
```

```csharp
public void ResetIcon()
```

```csharp
public int NetPower(bool includeUnderConstruction, bool includeDeactivated)
```

```csharp
public bool EnoughPowerForModule(TIHabModuleState module)
```

```csharp
private void TurnOnPowerModulesToResolveDeficit(ref int netPower)
```

```csharp
public void ResetPower()
```

```csharp
public void ValidateLocalPopulationRequirementsForAllNearbyHabs()
```

```csharp
public void UpdatePowerManagement(bool turnEverythingPossibleOn = false, TIHabModuleState moduleJustPowerSet = null, bool AI = false)
```

```csharp
public List<HabModuleSpecialRule> HabConstructHabOptions(TIFactionState faction, bool includeInactives = false, bool includeUnderConstruction = false)
```

```csharp
public float MarineModuleCombatValue()
```

```csharp
public override float AssaultCombatValue(bool defense)
```

```csharp
public float ModifiedDefenseCombatValue(bool againstAirAssault)
```

```csharp
public void ArriveCouncilor(TICouncilorState councilor)
```

```csharp
public void DepartCouncilor(TICouncilorState councilor)
```

```csharp
public List<TICouncilorState> councilorsPresent(TIFactionState limitToFaction = null)
```

```csharp
public List<TICouncilorState> CouncilorsPresentAndKnownToFaction(TIFactionState faction, bool skipOurFaction = false, TIFactionState limitOutputToFaction = null)
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
public float GetAdvisingAttribute(CouncilorAttribute attribute)
```

```csharp
public void AddDockedFleet(TISpaceFleetState fleet)
```

```csharp
public bool RemoveDockedFleet(TISpaceFleetState fleet)
```

```csharp
public bool CanDefendHabWithSTOFighters()
```

```csharp
public bool DockingRequiresCombat(TISpaceFleetState fleet, bool checkForSTODefenses)
```

```csharp
public bool CanDock(TISpaceFleetState fleet, bool checkForSTODefenses)
```

```csharp
public void DockFleet(TISpaceFleetState fleet, out Vector3d offset)
```

```csharp
public void LaunchFleet(TISpaceFleetState fleet)
```

```csharp
public float SpaceCombatValueFromDockedFleets()
```

```csharp
public float SpaceCombatValueFromDefendingFleets()
```

```csharp
public float AssaultCombatValueFromDockedFleets(TIFactionState fleetFaction, bool defense)
```

```csharp
public void TakeDamageFromParticipatingInAssault_Offense(TIMissionOutcome outcome, TIFactionState defender)
```

```csharp
public void TakeDamageFromParticipatingInAssault_Defense(TIMissionOutcome outcome, TIFactionState attacker)
```

```csharp
public override List<TISpaceFleetState> GetNearbyIdleAlliedFleets(TIDateTime time = null)
```

```csharp
public void AddConflictFleet(TISpaceFleetState fleet)
```

```csharp
public bool IsConflictFleet(TISpaceFleetState fleet)
```

```csharp
public bool IsThreateningFleet(TISpaceFleetState fleet)
```

```csharp
public bool CanStoreOfficer(bool swap, int additionalProposedTransfersToHab)
```

```csharp
public int MaxOfficerStorageAllowed()
```

```csharp
public TIGameState GetState()
```

```csharp
public List<TIOfficerState> GetOfficers()
```

```csharp
public void UpdateDefendHabStatus()
```

```csharp
public string ResolveDefendHabEffect(TIFactionState faction, int duration_months)
```

```csharp
public void ExpireDefense(bool notify)
```

```csharp
public void SetDefenseExpiry(TIDateTime expiry)
```

```csharp
public List<TICouncilorState> GetProtectors()
```

```csharp
public float GetProtectionBonus(CouncilorAttribute attribute)
```

```csharp
public float GetLEOLabBonus(HabModuleSpecialRule rule, bool includeNonActive = false)
```

```csharp
public void SetUnderAssault(TIGameState assaulter, bool setting, bool alert)
```

```csharp
public void SetUnderBombardment()
```

```csharp
public bool CheckLOSToOrbitalTarget(TISpaceFleetState fleet, TIDateTime time)
```

```csharp
public void TryClearBombardmentStatus(TISpaceFleetState endingFleet)
```

```csharp
public string GetLocalizedHabModuleList()
```

```csharp
public string BuildShortHabSummary(TIFactionState viewingFaction)
```

```csharp
public ModulePlacementOrder(string module, int sector, int slot)
```
