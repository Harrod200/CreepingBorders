# TISpaceShipTemplate

*Decompiled from `TISpaceShipTemplate.cs`.*


## Class `TISpaceShipTemplate`

```csharp
public class TISpaceShipTemplate : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `isAlien` | public bool |
| `modelResource` | public string |
| `GetHullAppearanceIndex` | public int |
| `designingFaction` | public TIFactionState |
| `hullTemplate` | public TIShipHullTemplate |
| `driveTemplate` | public TIDriveTemplate |
| `thrusterCount` | public int |
| `powerPlantTemplate` | public TIPowerPlantTemplate |
| `radiatorTemplate` | public TIRadiatorTemplate |
| `batteryTemplates` | public List<TIBatteryTemplate> |
| `noseArmorTemplate` | public TIShipArmorTemplate |
| `noseArmorValue` | public int |
| `noseArmorThickness` | public float |
| `lateralArmorTemplate` | public TIShipArmorTemplate |
| `lateralArmorValue` | public int |
| `lateralArmorThickness_m` | public float |
| `tailArmorTemplate` | public TIShipArmorTemplate |
| `tailArmorValue` | public int |
| `tailArmorThickness` | public float |
| `size` | public ShipSize |
| `requiresExotics` | public bool |
| `requiresAntimatter` | public bool |
| `baseCombatAcceleration_mps2` | public float |
| `TestCombats` | public static IEnumerable<TISpaceShipTemplate.TestCombat> |
| `partTemplates` | public List<TIShipPartTemplate> |
| `utilityModules` | public IEnumerable<ModuleDataEntry> |
| `utilitySlotModuleTemplates` | public IEnumerable<TIShipModuleTemplate> |
| `noseWeapons` | public IEnumerable<ModuleDataEntry> |
| `noseWeaponTemplates` | public IEnumerable<TIShipWeaponTemplate> |
| `hullWeapons` | public IEnumerable<ModuleDataEntry> |
| `hullWeaponTemplates` | public IEnumerable<TIShipWeaponTemplate> |
| `allWeapons` | public List<ModuleDataEntry> |
| `allWeaponTemplates` | public List<TIShipWeaponTemplate> |
| `heatSinkModules` | public List<ModuleDataEntry> |
| `batteryModules` | public List<ModuleDataEntry> |
| `crewBillets` | public int |
| `damConCrewBillets` | public int |
| `shipHasALaser` | public bool |
| `shipHasAParticleBeam` | public bool |
| `validPowerPlantsForDrive` | public List<TIPowerPlantTemplate> |
| `validDrivesForPowerPlant` | public List<TIDriveTemplate> |
| `drivePowerRequirement_GW` | public float |
| `shipPowerProductionRequirement_GW` | public float |
| `requiredSystemsPower_GW` | public float |
| `requiredWeaponsPowerGeneration_GW` | public float |
| `requiredWeaponsPowerStorage_GJ` | public float |
| `wasteHeat_GW` | public float |
| `modifiedCapSurfaceArea_m2` | public float |
| `magazineModuleCount` | public int |
| `magazineModuleMultiplier` | public float |
| `powerPlantMass_tons` | public float |
| `radiatorMass_tons` | public float |
| `noseArmorMass_tons` | public float |
| `lateralArmorMass_tons` | public float |
| `tailArmorMass_tons` | public float |
| `totalArmorMass_tons` | public float |
| `propellantMass_tons` | public float |
| `dryMass_kg` | public float |
| `propellantMass_kg` | public float |
| `wetMass_tons` | public float |
| `wetMass_kg` | public float |
| `allBatteriesMass_tons` | public float |
| `crewMass_tons` | public float |
| `weaponsMass_tons` | public float |
| `powerPlantBuildCost` | public TIResourcesCost |
| `radiatorsBuildCost` | public TIResourcesCost |
| `noseArmorBuildCost` | public TIResourcesCost |
| `lateralArmorBuildCost` | public TIResourcesCost |
| `tailArmorBuildCost` | public TIResourcesCost |
| `modifiedThrust_N` | public float |
| `modifiedEV_kps` | public float |
| `baseCombatThrust_N` | public float |
| `baseCombatExhaustVelocity_kps` | public float |
| `baseCombatAcceleration_gs` | public float |
| `baseManueverThrust` | public float |
| `baseAngularAcceleration_rads2` | public float |
| `baseAngularAcceleration_degs2` | public float |
| `maxAngularVelocity_mps` | public float |
| `maxAngularVelocity_degs` | public float |
| `maxDamageControlAngularVelocity_mps` | public float |
| `ValidTemplate` | public bool |
| `fullClassName` | public string |
| `className` | public string |
| `illegalShipClassNames` | public static List<string> |
| `CanDeleteDesign` | public bool |
| `roleStr` | public string |
| `roleDescription` | public string |
| `nonCombatant` | public bool |
| `combatant` | public bool |
| `factionName` | public string |
| `hullName` | public string |
| `driveName` | public string |
| `powerPlantName` | public string |
| `radiatorName` | public string |
| `propellantTanks` | public int |
| `refitIteration` | public int |
| `noseArmor` | public ArmorFacingTemplate |
| `lateralArmor` | public ArmorFacingTemplate |
| `tailArmor` | public ArmorFacingTemplate |
| `moduleTemplateEntries` | public List<ModuleDataTemplateEntry> |
| `hullWeaponTemplateEntries` | public List<ModuleDataTemplateEntry> |
| `noseWeaponTemplateEntries` | public List<ModuleDataTemplateEntry> |
| `fireModeTemplateEntries` | public List<FireModeDataTemplateEntry> |
| `role` | public ShipRole |
| `longRange_km` | public const float |
| `mediumRange_km` | public const float |
| `shortRange_km` | public const float |
| `propellantTankMass_tons` | public const float |
| `mass_per_crew_tons` | public const float |
| `maneuverThrust_N_human` | public const float |
| `maneuverThrust_N_alien` | public const float |
| `maxThrusters` | public const int |
| `hasDisplayName` | public bool |
| `_unnormalizedCombatValue` | private float |
| `_combatValue` | private float |
| `_baseCruiseDeltaV_kps` | private float |
| `_baseCruiseAcceleration_mps2` | private float |
| `hullAppearanceIndex` | public int |
| `hideInSkirmish` | public bool |
| `isIncompleteDesign` | private bool |
| `nation` | public TINationState |
| `_designingFaction` | private TIFactionState |
| `_hullTemplate` | private TIShipHullTemplate |
| `_driveTemplate` | private TIDriveTemplate |
| `_powerPlantTemplate` | private TIPowerPlantTemplate |
| `_radiatorTemplate` | private TIRadiatorTemplate |
| `_noseArmorTemplate` | private TIShipArmorTemplate |
| `_lateralArmorTemplate` | private TIShipArmorTemplate |
| `_tailArmorTemplate` | private TIShipArmorTemplate |
| `_requiredExotics` | private float |
| `_requiredAntimatter` | private float |
| `testCombats` | private static List<TISpaceShipTemplate.TestCombat> |
| `baselineUnormalizedSCVUpdatedFrame` | private static int |
| `StandardAlienShipStrength` | public const float |
| `cachedUtilityModules` | private List<ModuleDataEntry> |
| `cachedUtilityModuleTemplates` | private List<TIShipModuleTemplate> |
| `cachedNoseWeapons` | private List<ModuleDataEntry> |
| `cachedNoseWeaponTemplates` | private List<TIShipWeaponTemplate> |
| `cachedHullWeapons` | private List<ModuleDataEntry> |
| `cachedHullWeaponTemplates` | private List<TIShipWeaponTemplate> |
| `PDWeaponBonusPowerLimit` | private const float |
| `cachedDryMass_tons` | private float |
| `_spaceResourceConstructionCost` | private TIResourcesCost |
| `_heatCapacity_GJ` | private float |
| `_batteryCapacity_GJ` | private float |
| `numRotationalThrusters` | public const int |
| `outerColonyShipRequirement` | private readonly List<SpecialModuleRule> |
| `innerColonyShipRequirement` | private readonly List<SpecialModuleRule> |
| `orderToCheckRoles` | private readonly List<ShipRole> |
| `TestCombat` | public class |
| `Attacks` | public List<TISpaceShipTemplate.TestCombat.Attack> |
| `Attack` | public struct |
| `Weapon` | public TIShipWeaponTemplate |
| `Range_km` | public float |
| `ArmorFacing` | public ArmorFacing |
| `Angle` | public float |
| `Roll` | public float |
| `TargetingBonus` | public float |

### Properties

- `private readonly List<SpecialModuleRule> explorerRequirement = new List<SpecialModuleRule>`
- `private readonly List<SpecialModuleRule> armyCarrierRequirement = new List<SpecialModuleRule>`
- `private readonly List<SpecialModuleRule> surveillanceShipRequirement = new List<SpecialModuleRule>`

### Methods

```csharp
public void FinishDesigningShip()
```

```csharp
public TISpaceShipTemplate()
```

```csharp
public override TIGameState CreateGameState()
```

```csharp
public TISpaceShipTemplate(string dataNameToSet)
```

```csharp
public TISpaceShipState CreateDummyShip()
```

```csharp
public void SetDisplayName(string displayNameToSet)
```

```csharp
public void SetClassDisplayName(bool forceRefresh = false)
```

```csharp
public TISpaceShipTemplate Clone(string dataName, string factionName)
```

```csharp
public void InitAtRunTime(bool skipNaming = false)
```

```csharp
public void CacheTemplateValues(bool skipCost = false)
```

```csharp
public void SetHullTemplate(string templateName)
```

```csharp
public void SetDriveTemplate(string templateName)
```

```csharp
public void SetPowerPlantTemplate(string templateName)
```

```csharp
public void SetRadiatorTemplate(string templateName)
```

```csharp
public void SetNoseArmorTemplate(string templateName)
```

```csharp
public void SetLateralArmorTemplate(string templateName)
```

```csharp
public void SetTailArmorTemplate(string templateName)
```

```csharp
public float baseCruiseAcceleration_mps2(bool forceUpdate)
```

```csharp
public float basePursuitAcceleration_mps2(bool forceUpdate)
```

```csharp
public float baseCruiseDeltaV_kps(bool forceUpdate)
```

```csharp
public static void GenerateTestCombats()
```

```csharp
public static float GetUnnormalizedSpaceCombatValueFromParameters(float survivability, [TupleElementNames(new string[]
```

```csharp
public float UnnormalizedTemplateSpaceCombatValue(bool forceUpdate = false, float fidelity = 1f)
```

```csharp
public static float GetNormalizedSpaceCombatValue(float unnormalizedSpaceCombatValue, float minimumFraction = 0.1f)
```

```csharp
public float TemplateSpaceCombatValue(bool forceUpdate = false, float updateFraction = -1f, float fidelity = 1f, bool fast = false)
```

```csharp
public static bool AllowDynamicTemplateSpaceCombatValue()
```

```csharp
public float BombardmentValue(TISpaceBodyState spaceBody)
```

```csharp
public float InvasionCombatValue()
```

```csharp
public float GetMonthlyNetIncome(FactionResource resource)
```

```csharp
public float GetMonthlyGrossRevenue(FactionResource resource)
```

```csharp
public float GetMonthlyExpenses(FactionResource resource)
```

```csharp
public ArmorFacingTemplate GetArmorFacingTemplateInSlot(ShipModuleSlotType slot)
```

```csharp
public void TrySetArmor(ShipModuleSlotType armorSlot, int numPointsToSet)
```

```csharp
public int TryAddArmorPoints(ShipModuleSlotType armorSlot, int numPointsToAdd)
```

```csharp
public int GetMaxAllowedArmorBySlot(ShipModuleSlotType armorSlot, out float maxDepth_m, TIShipArmorTemplate prospectiveArmor = null)
```

```csharp
public bool ValidAssignedSlotForLocation(TIShipPartTemplate partTemplate, int slot)
```

```csharp
public bool ValidAssignedSlotForLocation(ModuleDataEntry moduleDataEntry)
```

```csharp
public bool ValidAssignedSlotForLocation(ModuleDataTemplateEntry moduleDataTemplateEntry)
```

```csharp
public bool SlotIndexOccupied(int slotIndex, bool testSecondarySlotsForWeapons)
```

```csharp
public TIShipPartTemplate GetPartInHullSlotIndex(int slotIndex, bool testSecondarySlotsForWeapons)
```

```csharp
public TIShipPartTemplate GetPartInHullSlot(TIShipHullTemplate.ShipModuleSlot shipModuleSlot, bool testSecondarySlotsForWeapons)
```

```csharp
public TIShipPartTemplate GetPartInHullSlot(Vector2 coordinates, bool testSecondarySlotsForWeapons)
```

```csharp
public FireModeDataTemplateEntry GetFireModeDataEntryFromSlot(int slot)
```

```csharp
public void SetFireModeForSlot(int slot, FireMode fireMode)
```

```csharp
public void ReCacheUtilityModules()
```

```csharp
public float TargetingBonus(TIFactionState faction = null)
```

```csharp
public float ECMValue(bool attackerIsAlien, TIFactionState faction = null)
```

```csharp
public bool ValidPartForDesign(TIShipPartTemplate part)
```

```csharp
private bool ValidUtilityModuleForDrive(TIUtilityModuleTemplate utilityModule, TIDriveTemplate drive)
```

```csharp
private bool ValidPowerPlantForShipsDrive(TIPowerPlantTemplate powerPlantToCheck)
```

```csharp
public bool validDriveForShipsPowerPlant(TIDriveTemplate driveToCheck)
```

```csharp
public static List<TIDriveTemplate> ValidDrivesForPowerPlants(List<TIDriveTemplate> candidateDrives, IEnumerable<TIPowerPlantTemplate> availablePowerPlants)
```

```csharp
public int GetIdealPropellentTankCount(float desiredDV, out float actualDV, float minimumReturnRatio, float maximumReturnRatio)
```

```csharp
public int GetIdealPropellentTankCount(float desiredDV, out float actualDV)
```

```csharp
public float GetRelativeValueOfRefit(TISpaceShipTemplate refit)
```

```csharp
public TIResourcesCost RefitResourceCost(TIHabModuleState shipyard, TISpaceShipTemplate originalDesign, bool includePropellant = true, bool includeRefuel = false, TISpaceShipState shipRefitting = null)
```

```csharp
public float GetRefitBuildTimeDays(TIHabModuleState shipyard, TISpaceShipTemplate originalDesign)
```

```csharp
public bool IsAValidRefitFor(TISpaceShipTemplate oldShipTemplate, out string reason, bool getReason = false)
```

```csharp
public bool AreUtilityModulesValidForRefit(TISpaceShipTemplate oldShipTemplate)
```

```csharp
public bool AreWeaponModulesValidForRefit(TISpaceShipTemplate oldShipTemplate)
```

```csharp
public static string GetRefitSuffix(int iteration)
```

```csharp
public float GetLaserBonusPower_MJ(Func<ModuleDataEntry, float> GetPartFunction = null)
```

```csharp
public float GetParticleBonusPower_MJ(Func<ModuleDataEntry, float> GetPartFunction = null)
```

```csharp
public float GetBonusPowerForWeapon_MJ(TIShipWeaponTemplate weapon, Func<ModuleDataEntry, float> GetPartFunction = null)
```

```csharp
public float GetBonusPowerForWeapon_GJ(TIShipWeaponTemplate weapon, Func<ModuleDataEntry, float> GetPartFunction = null)
```

```csharp
public float GetBonusPowerForWeapon_Multiplier(TIShipWeaponTemplate weapon, float range_km, Func<ModuleDataEntry, float> GetPartFunction = null)
```

```csharp
public float dryMass_tons(bool forceUpdate = false)
```

```csharp
public void SetDryMass_tons(float dryMass_tons)
```

```csharp
public void SetBaseCruiseDeltaV_kps(float baseCruiseDeltaV_kps)
```

```csharp
public TIResourcesCost singlePropellantTankCost(TIFactionState faction, float tankFillFraction = 1f)
```

```csharp
public TIResourcesCost propellantTanksBuildCost(TIFactionState faction)
```

```csharp
public float propellantTanksBuildCost(TIFactionState faction, FactionResource resource)
```

```csharp
public TIResourcesCost spaceResourceConstructionCost(bool forceUpdateToCache, TIHabModuleState shipyard, bool includePropellant = true, bool skipConstructionTime = false, bool updateWithoutCaching = false)
```

```csharp
public TIResourcesCost earthResourceConstructionCost(TIFactionState faction, TIHabModuleState shipyard)
```

```csharp
public static TIResourcesCost MixedResourceConstructionCost(TIFactionState faction, TIHabState hab, TIResourcesCost baseCost, List<ResourceValue> availableSpaceResources = null, bool ignoreTime = false)
```

```csharp
public float baseCruiseAcceleration_gs(bool forceUpdate)
```

```csharp
public float baseCruiseDeltaV_mps(bool forceUpdate)
```

```csharp
public float HeatCapacity_GJ(bool forceUpdate = false)
```

```csharp
public float BatteryCapacity_GJ(bool forceUpdate = false)
```

```csharp
public float GetCrossSectionalArea_m2(float angle_degrees = -3.4028235E+38f)
```

```csharp
public static void ClearUnusedTemplates()
```

```csharp
public string GenerateRandomClassName(TIFactionTemplate faction)
```

```csharp
public bool CanTakeOffFromSurfaceShipyard(TIHabModuleState shipyard)
```

```csharp
public bool CanBuildAtShipyard(TIHabModuleState shipyard)
```

```csharp
public bool ShouldObsolete(TIFactionState faction)
```

```csharp
public bool Obsolete(TIFactionState faction)
```

```csharp
public bool IsDuplicateOf(TISpaceShipTemplate other)
```

```csharp
public string quickSummary(bool obfuscateAlienData, TISpaceShipState shipState, bool hideAlienDataDistance = false, bool includePartNames = false, bool listOfficers = false)
```

```csharp
public bool AllowedRole(ShipRole role)
```

```csharp
public bool HasSpecialModuleCapability(SpecialModuleRule rule)
```

```csharp
public bool HasSpecialModuleCapability(List<SpecialModuleRule> rules)
```

```csharp
public bool HasFoundBaseCapability()
```

```csharp
public bool HasFoundStationCapability()
```

```csharp
public bool HasFoundStandardStationCapability()
```

```csharp
public bool HasFoundSurveillanceStationCapability()
```

```csharp
public bool CanFulfillGoal(FactionGoal_Fleet goal)
```

```csharp
public float AssaultCombatValue(bool defense)
```

```csharp
public bool FitsRole(ShipRole role)
```

```csharp
public ShipRole AssignRole()
```

```csharp
public static bool shortRangeStrategic(ShipRole role)
```

```csharp
public static bool mediumRangeStrategic(ShipRole role)
```

```csharp
public static bool longRangeStrategic(ShipRole role)
```

```csharp
public static bool longRangeCombatant(ShipRole role)
```

```csharp
public static bool shortRangeCombatant(ShipRole role)
```

```csharp
public static bool mediumRangeCombatant(ShipRole role)
```

```csharp
public static bool SoloOperator(ShipRole role)
```

```csharp
public string DebugSummary()
```

```csharp
public static void ClearStaticData()
```

```csharp
public void AddAttack(TISpaceShipTemplate.TestCombat.Attack attack)
```
