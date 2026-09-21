# TISpaceShipState

*Decompiled from `PavonisInteractive/TerraInvicta/TISpaceShipState.cs`.*


## Class `TISpaceShipState`

```csharp
public class TISpaceShipState : TIGameState, CombatTargetableState, CombatWeaponCarrierState, OfficerCarrierState
```

### Fields

| Name | Type |
|---|---|
| `manueverRating` | public float |
| `pursuitAcceleration_mps2` | public float |
| `pursuitAcceleration_gs` | public float |
| `propellant` | public Propellant |
| `CurrentManeuverSequence` | public ShipManeuverSequence |
| `isSpaceShipState` | public override bool |
| `searchable` | public override Searchable |
| `ref_faction` | public override TIFactionState |
| `ref_fleet` | public override TISpaceFleetState |
| `ref_orbit` | public override TIOrbitState |
| `ref_naturalSpaceObject` | public override TINaturalSpaceObjectState |
| `ref_spaceBody` | public override TISpaceBodyState |
| `ref_hab` | public override TIHabState |
| `ref_habSite` | public override TIHabSiteState |
| `ref_spaceAsset` | public override TISpaceAssetState |
| `ref_ship` | public override TISpaceShipState |
| `ref_region` | public override TIRegionState |
| `hasMapObject` | public override bool |
| `inSpace` | public override bool |
| `template` | public TISpaceShipTemplate |
| `hull` | public TIShipHullTemplate |
| `faction` | public TIFactionState |
| `utilitySlotModules` | public List<TIShipModuleTemplate> |
| `partTemplates` | public List<TIShipPartTemplate> |
| `radiators` | public TIRadiatorTemplate |
| `drive` | public TIDriveTemplate |
| `powerPlant` | public TIPowerPlantTemplate |
| `driveModule` | public ModuleDataEntry |
| `powerPlantModule` | public ModuleDataEntry |
| `radiatorModule` | public ModuleDataEntry |
| `noseArmorTemplate` | public TIShipArmorTemplate |
| `lateralArmorTemplate` | public TIShipArmorTemplate |
| `tailArmorTemplate` | public TIShipArmorTemplate |
| `noseArmorThickness_m` | public float |
| `lateralArmorThickness_m` | public float |
| `tailArmorThickness_m` | public float |
| `councilorPassengers` | public List<TICouncilorState> |
| `alienCouncilorPassengers` | public List<TICouncilorState> |
| `crashdownEligible` | public bool |
| `landArmyEligible` | public bool |
| `maxThrust_combatExhaustVelocity_kps` | public float |
| `cruiseAcceleration_gs` | public float |
| `cruiseAcceleration_kps2` | public float |
| `combatAcceleration_kps2` | public float |
| `combatAcceleration_gs` | public float |
| `isAlien` | public bool |
| `dryMass_kg` | public double |
| `dryMass_tons` | public double |
| `wetMass_kg` | public double |
| `wetMass_tons` | public double |
| `currentMass_tons` | public double |
| `noseWeaponTemplates` | public List<TIShipWeaponTemplate> |
| `hullWeaponTemplates` | public List<TIShipWeaponTemplate> |
| `allWeaponTemplates` | public List<TIShipWeaponTemplate> |
| `utilityModuleTemplates` | public List<TIShipModuleTemplate> |
| `noseArmorValue` | public float |
| `leftArmorValue` | public float |
| `rightArmorValue` | public float |
| `tailArmorValue` | public float |
| `sumArmorValue` | public float |
| `role` | public ShipRole |
| `combatant` | public bool |
| `nonCombatant` | public bool |
| `spaceScienceResearchBonus` | public float |
| `damaged` | public bool |
| `internalDamage` | public bool |
| `badlyDamaged` | public bool |
| `seriouslyDamaged` | public bool |
| `isCapableOfTransfering` | public bool |
| `globalPosition` | public Vector3d |
| `desiredGlobalPosition` | public Vector3d |
| `combatRange_km` | public float |
| `MaxSafeAerobreakingEnergy_MJ` | public float |
| `MaxUnsaveAerobreakingEnergy_MJ` | public float |
| `angularAcceleration_degs2` | public float |
| `currentThrust_N` | public float |
| `currentEV_kps` | public float |
| `modifiedThrustCap` | public float |
| `maxCruiseAcceleration_g` | public float |
| `maxCombatAccleration_g` | public float |
| `maxAngularVelocity_rad_s` | public float |
| `defaultPositionOnCreation` | public Vector3d |
| `visibleCommands` | public List<IShipCommand> |
| `availableCommands` | public List<IShipCommand> |
| `availablePowerFraction` | public float |
| `availablePowerStorageFraction` | public float |
| `AuxPowerRequriedStorage_GJ` | public float |
| `WasteHeat_GW` | public float |
| `functionalMagazineModulesAmmoMultiplier` | public float |
| `currentBatteryCharge_GJ` | public float |
| `heatCapFraction` | public float |
| `heatFraction` | public float |
| `CanGainHeat` | public bool |
| `cooling` | public bool |
| `overheated` | public bool |
| `damage_mainThrustModifier` | public float |
| `damage_vectorThrustModifier` | public float |
| `weaponCooldownModifier_Pct` | public float |
| `ManeuverEffectivenessRatio` | public float |
| `ThrustEffectivenessRatio` | public float |
| `VisiblyDamaged` | public bool |
| `VisibleDamageFraction` | public float |
| `CriticalDamageTotal` | public float |
| `sideways_acceleration` | public double |
| `maneuverThrust_N` | public float |
| `canEverRetractRadiators` | public bool |
| `canIssueRetractRadiatorsCommand` | public bool |
| `canIssueExtendRadiatorsCommand` | public bool |
| `AllowBoostForRepairsResupply` | private bool |
| `PropellantShortage_tons` | public float |
| `BestExistingRefit` | public TISpaceShipTemplate |
| `CanRefit` | public bool |
| `NeedsRefit` | public bool |
| `noseWeapons` | public List<ModuleDataEntry> |
| `hullWeapons` | public List<ModuleDataEntry> |
| `utilityModules` | public List<ModuleDataEntry> |
| `RadiatorAnimationDuration_s` | public const int |
| `TEMP_WARM_THRESHOLD` | public const float |
| `TEMP_HOT_THRESHOLD` | public const float |
| `TEMP_MELTDOWN_THRESHOLD` | public const float |
| `BATT_LOW_TRESHOLD` | public const float |
| `BATT_CRITICAL_TRESHOLD` | public const float |
| `DAM_CON_FASTEST_REPAIR_MIN` | public const float |
| `DAM_CON_SLOWEST_REPAIR_MIN` | public const float |
| `ALIEN_REPAIR_BONUS` | public const float |
| `REPAIR_BAY_BONUS` | public const float |
| `MINIMUM_ANGULAR_ACCELERATION_RADS2` | private const float |
| `activeCombatManeuvers` | public List<CombatManeuver> |
| `armor` | public Dictionary<ArmorFacing, TISpaceShipState.ArmorData> |
| `propellant_tons` | public float |
| `kills` | public List<string> |
| `officers` | public List<TIOfficerState> |
| `damagedSystems` | private Dictionary<ShipSystem, float> |
| `damagedParts` | public List<DamagedShipPartData> |
| `damagedPartsCache` | private Dictionary<ModuleDataEntry, DamagedShipPartData> |
| `internalDamageTables` | private Dictionary<ArmorFacing, Dictionary<ShipSystem, float>> |
| `damagePoints` | public List<Vector4> |
| `prevPartsBeingRepaired` | public List<DamagedShipPartData> |
| `prevSystemsBeingRepaired` | public List<ShipSystem> |
| `plannedResupplyAndRepair` | public PlannedResupplyAndRepair |
| `currentFleetOffset` | public Vector3d |
| `currentRotation` | public Quaternion |
| `currentManeuver` | public StratManeuver |
| `currentManeuverSequence` | private ShipManeuverSequence |
| `inManeuver` | public bool |
| `inManeuverSequence` | public bool |
| `gameStateSubjectCreated` | private bool |
| `visualizerLink` | public ShipVisController |
| `_worstArmor` | public int |
| `_bestArmor` | public int |
| `_combatUpdatePropulsionEventName` | private string |
| `storedFaction` | public TIFactionState |
| `_wasteHeat_GW` | private float |
| `_systemsPowerGenerationRequirement_GW` | private float |
| `_weaponsPowerGenerationRequirement_GW` | private float |
| `_propulsionPowerGenerationRequirement_GW` | private float |
| `_auxReactorPowerGenerationRequirement_GW` | private float |
| `_allPowerGenerationRequirement_GW` | private float |
| `_auxPowerRequriedStorage_GJ` | private float |
| `isDummy` | public bool |
| `_driveModule` | private ModuleDataEntry |
| `_powerPlantModule` | private ModuleDataEntry |
| `_radiatorModule` | private ModuleDataEntry |
| `radiatorEventInstance` | private EventInstance |
| `damageLayer` | private DamageLayer |
| `damageVisualizationDirty` | private bool |
| `_cachedSpaceCombatValue` | private float |
| `spaceCombatValueDataDirty` | public bool |
| `effectiveBeamWeaponRange_km` | public Dictionary<float, Dictionary<string, float>> |
| `visualizationDataDirtyFrame` | private int |
| `combatSecondCounter` | private int |
| `availablePower_GJ` | public float |
| `systemsDepowered` | public bool |
| `generatorWorking` | public bool |
| `SystemRepairPriority` | public static readonly Dictionary<ShipSystem, int> |
| `CombatSystemRepairPriority` | public static readonly Dictionary<ShipSystem, int> |
| `ModuleRepairPriority` | public static readonly Dictionary<ShipModuleSlotType, int> |
| `LessThanDamageToRepairInCombat` | private static readonly Dictionary<ShipSystem, float> |
| `PartsDestroyedDuringOperation` | private readonly Dictionary<ShipSystem, bool> |
| `MAX_REPAIR_AFTER_DESTRUCTION` | private const float |
| `MAX_REPAIR_AFTER_DESTRUCTION_WITH_REPAIR_BAY` | private const float |
| `batteryCharge` | public Dictionary<ModuleDataEntry, float> |
| `oldHeatAtLastUIUpdate_GJ` | private float |
| `visiblyDamagedSystems` | public static readonly List<ShipSystem> |
| `innateHullRadiationProtectionMultiplier` | public const float |
| `DirectDamageableSystems` | private static readonly HashSet<ShipSystem> |
| `SoftSystems` | private static readonly HashSet<ShipSystem> |
| `DamagePointsToDestroyPropellantTank` | private const float |
| `targetingFrame` | private int |
| `_cacheTargetingBonus` | private float |
| `ECMFrame` | private int |
| `_cacheECMValue` | private float |
| `_cachedFunctionalUtilitySlotModulesFrame` | private int |
| `_cachedFunctionalUtilitySlotModules` | private List<TIUtilityModuleTemplate> |
| `numVectorThrusters` | public const int |
| `shipAmmoReloadStep` | public const int |
| `bestExistingRefitCachedFrame` | private int |
| `cachedBestExistingRefit` | private TISpaceShipTemplate |
| `StructuralDamageHullCostRepairMultiplier` | public const float |
| `BasePartRepairDuration_days` | public const float |
| `BaseArmorRepairDuration_days` | public const float |
| `testBoostForRepairResupply` | public const bool |
| `repairableArmorFacings` | private static readonly List<ArmorFacing> |
| `FoundBaseRules` | public static readonly List<SpecialModuleRule> |
| `FoundStandardStationRules` | public static readonly List<SpecialModuleRule> |
| `FoundSurveillanceStationRules` | public static readonly List<SpecialModuleRule> |
| `FoundAnyStationRules` | public static readonly List<SpecialModuleRule> |
| `FoundAnyHabRules` | public static readonly List<SpecialModuleRule> |
| `ArmorData` | public class |
| `damaged` | public bool |
| `maxArmor` | public int |
| `armorValue` | public int |
| `chippedPct` | public float |

### Properties

- `public float cruiseAcceleration_mps2`
- `public float combatAcceleration_mps2`
- `public float currentDeltaV_kps`
- `public float currentMaxDeltaV_kps`
- `public float currentMass_kg`
- `public float angular_acceleration_rads2`
- `public float max_angular_velocity_rad_s`
- `public int missionControlConsumption`
- `public bool radiatorsExtending`
- `public bool radiatorsRetracting`
- `public bool radiatorsExtended`
- `public float accumulatedHeat_GJ`
- `public float currentHeatSinkCapacity_GJ`
- `public bool thrustersActive`
- `public bool canSuicide`
- `public bool combatAIControl`
- `public bool disengageFromCombat`
- `public bool hasDisengaged`
- `public bool isDamageControlSuspended`
- `public CombatTargetableState combatPrimaryTarget`
- `public CombatTargetableState combatManeuverTarget`
- `public Dictionary<ModuleDataEntry, int> ammo`
- `public TISpaceFleetState fleet`
- `public Vector3d fleetFormationOffset`
- `public bool propulsionValuesDataDirty`
- `public TIDateTime launchDate`
- `public TIDateTime lastRefitDate`
- `public TIRegionState homeRegion`
- `public static readonly FactionResource[] relevantIncomeResources = new FactionResource[]`

### Methods

```csharp
public bool isShip()
```

```csharp
public bool isHabModule()
```

```csharp
public TIGameState GetTargetableState()
```

```csharp
public TISpaceShipState ref_shipCarrier()
```

```csharp
public TIHabModuleState ref_habModuleCarrier()
```

```csharp
public bool IsAlien()
```

```csharp
public Vector3d globalPositionAtTime(TIDateTime time)
```

```csharp
public float SpaceCombatValue(bool forceIt = false, float prospectiveDVChange_kps = 0f)
```

```csharp
private void CacheEffectiveBeamRanges()
```

```csharp
public string ThrusterSFXString()
```

```csharp
public string ThrusterSFXStringStrategyLayer()
```

```csharp
public string NameWithDamageIcons()
```

```csharp
public double MaxPreAerobreakVelocity_mps(double postAerobreakVelocity_mps, bool isSafe)
```

```csharp
public TIFactionState GetFaction()
```

```csharp
public void AddTargetedProjectile(TISpaceCombatProjectileState projectile)
```

```csharp
public override void InitWithTemplate(TIDataTemplate rawTemplate)
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
public override void PostVisualizerCreationInit_7()
```

```csharp
public override void PostEverythingSaveRepair_8()
```

```csharp
public void CompleteShipInitialization()
```

```csharp
private void RepairFleetMembership()
```

```csharp
public void InitShip()
```

```csharp
public void CopyDataForRefit(TISpaceShipState originalShip)
```

```csharp
public void CreateVisualizer(ShipVisController controller)
```

```csharp
public void InitDamageLayer(DamageLayer damageLayer)
```

```csharp
public override void SetDisplayName(string newName)
```

```csharp
public static List<IHullSection> SetUpArmorSections(TISpaceShipState ship)
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
public void DestroyShip(bool killPersonnel, TIFactionState destroyer)
```

```csharp
public TIResourcesCost ScuttleCost()
```

```csharp
public void SetVisualizationDataDirty()
```

```csharp
public void ClearShipDamageVisualizations()
```

```csharp
public void SetPropulsionValuesDirty(bool immediate = false, bool forceUseCurrentMass = false)
```

```csharp
private void UpdatePropulsionValues_Combat(TimeEventStart e)
```

```csharp
public float CombatAccelerationGivenRemainingDV_mps2(float remainingDV_mps)
```

```csharp
public float NotionalDeltaVChange_kps(float propellantChange_tons)
```

```csharp
public void UpdatePropulsionValues(bool forceUseCurrentMass = false)
```

```csharp
private void ChangeCurrentMass_kg(float change_kg, bool instantPropulsionUpdate = false)
```

```csharp
private void ChangePropellant_tons(float change_tons, bool instantPropulsionUpdate = false)
```

```csharp
private void SetPropellant_tons(float value, bool instantPropulsionUpdate = false)
```

```csharp
public float DriveHeat_GJ()
```

```csharp
public void RunDriveInCombat(float combatDV_kps, float combatAcceleration_kps2, float massPriorToBurn_kg)
```

```csharp
private float GetCombatRealismDVConsumptionFactor()
```

```csharp
public float GetDVConservingCombatAcceleration_mps2(float targetThrustDuration_s, float dvBudget_kps)
```

```csharp
public float DVconsumedInCombat(float combatDV_kps, float combatAcceleration_kps2, float massPriorToBurn_kg)
```

```csharp
public void ConsumeDeltaV(float DV_kps_consumed, bool instantPropulsionUpdate = true)
```

```csharp
public void RefundDeltaV(float DV_kps_refunded)
```

```csharp
private void SetCurrentDeltaVFromPropellantMass()
```

```csharp
public float AvailableDeltaVForCombat_kps()
```

```csharp
public bool DoesDriveHeatExceedRadiatorAndOverheatInOneSecond()
```

```csharp
public float GetCombatDeltaVFromPropellantMass()
```

```csharp
public float GetTotalMassFromDVRemaining(float DV_remaining_kps)
```

```csharp
public float ConvertToCombatDeltaV_kps(float cruiseDeltaV_kps)
```

```csharp
public bool MissionKilled()
```

```csharp
public void JoinFleet(TISpaceFleetState newFleet)
```

```csharp
public Vector3d GetShipFormationOffSet(int numberOfPositions, bool invertZ = false)
```

```csharp
public void SetFormationOffsetAndInitiateStationkeepingManeuver(int numberOfPositions, bool invertZ)
```

```csharp
public Vector3d GetCombatFormationOffSet(List<TISpaceShipState> shipsInFormation, Formation formation, int numberOfPositions, bool invertZForCombat = false, bool isCombatSetup = false)
```

```csharp
public void SetCombatFormationOffset(List<TISpaceShipState> shipsInFormation, Formation formation, int numberOfPositions, bool invertZForCombat = false, bool isCombatSetup = false)
```

```csharp
public Quaterniond GetDesiredRotation(bool realspace)
```

```csharp
public void InitiateManuever(Vector3d desiredOffset, Quaternion desiredOrientation)
```

```csharp
public void InitiateManeuverSequence(Vector3d driftTarget, Vector3d burnTarget, Vector3d desiredOffset, Quaternion desiredOrientation)
```

```csharp
public int Maneuver_Phase(TIDateTime time)
```

```csharp
public Quaternion Maneuver_RotationAtTime(TIDateTime time)
```

```csharp
public Vector3d Maneuver_PositionAtTime(TIDateTime time)
```

```csharp
public void EndManuever()
```

```csharp
public void UpdateCurrentManeuver()
```

```csharp
public double CurrentManeuverCompletePercentage(TIDateTime time)
```

```csharp
public TIResourcesCost GetRammingSpeedCost()
```

```csharp
public void SetRammingSpeed(bool enabled)
```

```csharp
public void SetDisengageOrder(bool enabled)
```

```csharp
public void CompleteDisengage()
```

```csharp
public void SetAIControl(bool setting)
```

```csharp
public void SetCombatPrimaryTarget(CombatTargetableState target)
```

```csharp
public void SetCombatManeuverTarget(CombatTargetableState maneuverTarget)
```

```csharp
public void CombatPerSecondChanges(bool triggerUIUpdate)
```

```csharp
public void CombatFractionalSecondChanges(double timeElapsed_s)
```

```csharp
private void CacheInternalPowerStats()
```

```csharp
public float PerSecondPowerGain()
```

```csharp
private void ChangeAvailablePower(float byAmount, bool triggerUIUpdate)
```

```csharp
private void SetAvailablePower(float toAmount, bool triggerUIUpdate)
```

```csharp
public void CombatPerQuarterSecondChanges(bool final)
```

```csharp
public void AddCombatManeuver(CombatManeuver maneuver)
```

```csharp
public bool PerformingCombatManeuver()
```

```csharp
public bool PerformingCombatManeuver(CombatManeuver maneuver)
```

```csharp
public bool PerformingCombatManeuver(List<CombatManeuver> maneuvers)
```

```csharp
public bool Rolling()
```

```csharp
public void RemoveCombatManeuver(CombatManeuver maneuver)
```

```csharp
public float GetWorstArmor()
```

```csharp
public float GetBestArmor()
```

```csharp
public void RecordKill(TIShipHullTemplate hull)
```

```csharp
public void SetCombatSystems()
```

```csharp
public void EnterCombat()
```

```csharp
public void SetPartDamage(ModuleDataEntry module, float value, bool add = false)
```

```csharp
public void PostCombat(bool allowRepairs = true)
```

```csharp
public void PostCombatVis()
```

```csharp
private float GetRepairBayBonusCrew()
```

```csharp
public void DamageControl()
```

```csharp
private void OnShipDamageControlRotationStatusChanged(ShipDamageControlRotationStatusChanged e)
```

```csharp
public float GetLaserBonusPower_MJ()
```

```csharp
public float GetParticleBonusPower_MJ()
```

```csharp
public float GetBonusPowerForWeapon_MJ(TIShipWeaponTemplate weapon)
```

```csharp
public float GetBonusPowerForWeapon_GJ(TIShipWeaponTemplate weapon)
```

```csharp
public List<ModuleDataEntry> AllWeaponModuleData()
```

```csharp
public IEnumerable<ModuleDataEntry> AllModuleData()
```

```csharp
public List<ModuleDataEntry> NuclearWeaponModuleData()
```

```csharp
public void LoadAmmo()
```

```csharp
public bool WeaponHasAmmo(ModuleDataEntry module)
```

```csharp
public bool WeaponNeedsBatteries(float ask_GJ)
```

```csharp
public bool WeaponHasPower(ModuleDataEntry module)
```

```csharp
public bool WeaponFireExceedsHeatCapacity(ModuleDataEntry module)
```

```csharp
public static bool LaserDownfiring(TIShipWeaponTemplate weapon, TISpaceCombatProjectileState targetedProjectile)
```

```csharp
public void FireWeapon(ModuleDataEntry module, TISpaceCombatProjectileState targetedProjectile)
```

```csharp
public void ChangeAmmoValue(ModuleDataEntry module, int delta)
```

```csharp
public static float BombardmentTargetRadiusValue_gameUnits(TIGameState target)
```

```csharp
public static Vector3d BombardmentTargetGlobalPosition(TIGameState state, TIDateTime time)
```

```csharp
public static bool BombardmentTargetInLineOfSight(TISpaceShipState ship, TIGameState target, TIDateTime time)
```

```csharp
public void Bombard(ModuleDataEntry bombardingWeaponModule, TIDateTime time, out bool targetDestroyed, out bool targetHit, bool doNotVisualize, float projectileVPDRatio)
```

```csharp
public bool WeaponDamaged(ModuleDataEntry moduleData)
```

```csharp
public bool WeaponDestroyed(ModuleDataEntry moduleData)
```

```csharp
public bool WeaponIsOperable(ModuleDataEntry moduleData)
```

```csharp
public bool WeaponCanFire(ModuleDataEntry moduleData)
```

```csharp
public bool WeaponDisabledBeyondFieldRepair(ModuleDataEntry moduleData)
```

```csharp
public bool AnyWeaponCanFire()
```

```csharp
public bool AllWeaponsDestroyed()
```

```csharp
public bool AllWeaponsDisabledBeyondFieldRepair()
```

```csharp
public bool AnyOffensiveWeaponCanFire()
```

```csharp
public bool AnyOffensiveMissileWeaponCanFire()
```

```csharp
public static Vector3 BombardmentTargetPosition_Display(TISpaceFleetState fleet, TIDateTime time, out float targetLongitude, out float targetLatitude, out Transform parentSpaceBody, out Transform targetTransform)
```

```csharp
public float BombardmentValue(TISpaceBodyState spaceBody)
```

```csharp
public float BombardmentValue(TISpaceBodyState spaceBody, float range_km)
```

```csharp
public float CurrentBatteryCapacity_GJ()
```

```csharp
public float ChangeBatteryCharge(float energyDelta_GJ, bool triggerUIUpdate)
```

```csharp
public void ChargeBatteriesToMax()
```

```csharp
public void UpdateHeatSinkCapacity_GJ()
```

```csharp
public void ApplyHeat(float heatValue_GJ, bool triggerUpdateEvent)
```

```csharp
public float RadiatorCooling_GJ()
```

```csharp
public void BleedHeatFromRadiators_s(double timeElapsed_s, bool triggerUpdateEvent)
```

```csharp
public float InternalDamageModifier()
```

```csharp
public void ChangeHeatInSinks(float heatValue_GJ, bool triggerUpdateEvent)
```

```csharp
public void ResolveHeatInSinks()
```

```csharp
public bool CanPerformShipCommands()
```

```csharp
public bool CanSetWaypoints()
```

```csharp
public bool FireControlActive()
```

```csharp
public bool CanRotateAndRoll()
```

```csharp
public void BuildInternalDamageTables()
```

```csharp
public float AbsorbAndApplyArmorDamage(TIShipWeaponTemplate attackingWeapon, ArmorFacing facing, float range_km, float damageAmount, float chippingAmount, DamageType damageType, float angle, TIFactionState attackingFaction, out float internalDamageAssessedHere, out float appliedRadiationDamage, int shreddingAmount = 0)
```

```csharp
public void ApplyDamage(TIShipWeaponTemplate attackingWeapon, ArmorFacing facing, float range_km, float damageAmount, float chippingAmount, DamageType damageType, float angle, TIFactionState attackingFaction, out float internalDamageAssessedHere, out float appliedRadiationDamage, int shreddingAmount = 0)
```

```csharp
public ArmorFacing GetNextInteralDamageLocation(ArmorFacing facing, ArmorFacing originalFacing, float angle, bool explosion, float damageDiffusion, out bool outTheOtherSide)
```

```csharp
public void ApplyInternalDamage(ArmorFacing facing, ArmorFacing originalFacing, float damageAmount, bool explosion, float weaponChipValue, float angle)
```

```csharp
public float ApplyInternalRadiationDamage(float xRayDamage, float baryonicDamage, ArmorFacing facing, ArmorFacing originalFacing, float angle, float diffusion)
```

```csharp
public void SyncDamageVisuals()
```

```csharp
public float GetSystemDamage(ShipSystem system)
```

```csharp
public bool SystemAsAWholeCanBeDamaged(ShipSystem system)
```

```csharp
public float GetSystemFunction(ShipSystem system)
```

```csharp
public float GetPartDamage(ModuleDataEntry moduleData)
```

```csharp
public float GetPartFunction(ModuleDataEntry moduleData)
```

```csharp
public bool PartDestroyed(ModuleDataEntry moduleData)
```

```csharp
public bool PartDamaged(ModuleDataEntry moduleData)
```

```csharp
public bool PartDamagedButNotDestroyed(ModuleDataEntry moduleData)
```

```csharp
public bool SystemDamaged(ShipSystem system)
```

```csharp
public bool SystemSeriouslyDamaged(ShipSystem system)
```

```csharp
public bool SystemDestroyed(ShipSystem system)
```

```csharp
public bool SystemDamagedButNotDestroyed(ShipSystem system)
```

```csharp
public bool ShipStructuralDamage()
```

```csharp
public bool ShipDestroyed()
```

```csharp
public float ApplyDamageToSystem(ShipSystem system, float damagePoints, out float damagePointsToApply)
```

```csharp
public void ApplyPercentDamageToSystem(ShipSystem system, float damagePercentage)
```

```csharp
public float TargetingBonus(TIShipWeaponTemplate weapon, TIHabState alliedHab)
```

```csharp
public float ECMValue(TIFactionState attacker, TIHabState alliedHab)
```

```csharp
public void ApplyThermalShredInStrategyLayer(int shreddingPoints)
```

```csharp
public float GetCrossSectionalArea_m2(float angle_degrees = -3.4028235E+38f)
```

```csharp
public ShipSystem GetSystemTypeFromModuleData(ModuleDataEntry module)
```

```csharp
public ModuleDataEntry GetPartToDamage(ShipSystem system, bool suppressError = false)
```

```csharp
public void DestroyPart(ModuleDataEntry part)
```

```csharp
public float ApplyDamageToPart(ModuleDataEntry moduleData, float damageValue, out float internalDamageApplied)
```

```csharp
public float ApplyDamageToPart(ModuleDataEntry moduleData, float damageValue, out bool secondaryExplosion, out float damagePointsApplied)
```

```csharp
public void ApplyPercentDamageToPart(ModuleDataEntry moduleData, float damagePercentage)
```

```csharp
public List<ModuleDataEntry> GetFunctionalUtilitySlotModules(float minHealth)
```

```csharp
public List<TIUtilityModuleTemplate> GetFunctionalUtilitySlotModuleTemplates(float minHealth)
```

```csharp
private void SetAngularAcceleration_rads2(float overrideMass_kg = -1f)
```

```csharp
public void ActivateThrusters()
```

```csharp
public void DeactivateThrusters()
```

```csharp
public void RetractRadiators()
```

```csharp
public void ExtendRadiators()
```

```csharp
public void InitiateExtendRadiators()
```

```csharp
public void InitiateRetractRadiators()
```

```csharp
public void CompleteExtendRadiators(TimeEventStart e)
```

```csharp
public void CompleteRetractRadiators(TimeEventStart e)
```

```csharp
private void OnRadiatorGameTimeSpeedChanged(GameTimeSpeedChanged e)
```

```csharp
public void ClearRadiatorAudio()
```

```csharp
public float FleetMissionControlMultiplier()
```

```csharp
public void InstantFullRepair()
```

```csharp
public void RePropellantToMax()
```

```csharp
public bool CanRefuelFromJovianAtmosphere()
```

```csharp
public bool CanRefuelFromHabSite(TIHabSiteState site)
```

```csharp
public bool AI_NeedsRefuelBadly(float minLocalFunctionalDV_kps)
```

```csharp
public bool AI_NeedsRefuel()
```

```csharp
public bool NeedsRefuel()
```

```csharp
public void RefuelPropellant(float tons)
```

```csharp
public TIResourcesCost GetPreferredPropellantTankCost(TIFactionState faction, float tonsToFill, bool textMixed)
```

```csharp
public float GetPropellantTonsForDesiredDv(float desiredDv)
```

```csharp
public bool NeedsRearm()
```

```csharp
public bool AI_NeedsRearmBadly()
```

```csharp
public bool AllWeaponsDry()
```

```csharp
public bool AI_InvoluntaryNoncombatant()
```

```csharp
public bool CanAffordAnyReload(TIHabState hab)
```

```csharp
public TIResourcesCost CostToReloadPartialAmmo(ModuleDataEntry weaponModuleData, int ammoToReload, TIHabState hab, bool testBoost)
```

```csharp
public TIResourcesCost SystemRepairCost(ShipSystem system, TIFactionState payingFaction, TIHabState repairingHab, bool testBoost)
```

```csharp
public TIResourcesCost PartRepairCost(ModuleDataEntry module, TIFactionState payingFaction, TIHabState repairingHab, bool testBoost)
```

```csharp
public TIResourcesCost ArmorFacingRepairCost(ArmorFacing facing, TIFactionState designingFaction, TIHabState repairingHab, bool testBoost)
```

```csharp
public List<ShipSystem> DamagedSystems()
```

```csharp
public List<ShipSystem> GetAffordableSystemRepairs(TIFactionState payingFaction, TIHabState repairingHab)
```

```csharp
public List<DamagedShipPartData> GetAffordablePartRepairs(TIFactionState payingFaction, TIHabState repairHab)
```

```csharp
public bool CanAffordAnyRepair(TIHabState repairingHab)
```

```csharp
public void RepairSystem(ShipSystem system)
```

```csharp
public void RepairPart(DamagedShipPartData part)
```

```csharp
public void RepairArmorFacing(ArmorFacing facing)
```

```csharp
public bool CanFulfillGoal(GoalType goal)
```

```csharp
public bool HasSpecialModuleRule(SpecialModuleRule rule, bool includeNonFunctional = false)
```

```csharp
public List<SpecialModuleRule> SpecialModuleRules(bool includeNonFunctional = false)
```

```csharp
public int SpecialModuleRuleCount(SpecialModuleRule rule)
```

```csharp
public float AssaultCombatValue(bool defense)
```

```csharp
public float InvasionCombatValue()
```

```csharp
public bool LongRangeFighter(bool includeOtherRoles)
```

```csharp
public bool MediumRangeFighter(bool includeOtherRoles)
```

```csharp
public List<TICouncilorState> CouncilorStatesPresentAndKnownToFaction(TIFactionState faction)
```

```csharp
public List<CouncilorView> CouncilorViewsPresentAndKnownToFaction(TIFactionState faction)
```

```csharp
public void SetMissionControlConsumption()
```

```csharp
public List<TIOfficerState> GetOfficers()
```

```csharp
public int GetMaxRankOfficers()
```

```csharp
public TIGameState GetState()
```

```csharp
public List<TIOfficerState> CheckForOfficerPromotionEvent(OfficerSpawnEventType spawnEventType, float chanceModifier = 0f, bool chanceModifierMult = false, List<TIOfficerState> existingPromotions = null)
```

```csharp
public List<TIOfficerTemplate> EligibleFreeOfficerCreationTemplates()
```

```csharp
public List<TIOfficerState> FreeOfficerCreationEvent(int officersToCreate = 1)
```

```csharp
public TIOfficerState CreateOfficer(string templateName)
```

```csharp
public float SumOfficerEffectsModifiers(OfficerEffectType effectType, float baseValue)
```

```csharp
public void OnInternalDamage_Officers(TIShipPartTemplate hitModule, float newDamageToSystem_points)
```

```csharp
public string KillAllOfficersReport()
```

```csharp
public void OnInternalDamage_Officers(ShipSystem hitSystem, float newDamageToSystem_points)
```

```csharp
public void CheckOfficersOnShipAchievement()
```

```csharp
public void BecomeCopyOf(TISpaceShipState shipToCopy)
```

```csharp
public override bool Equals(object obj)
```

```csharp
public ArmorData(int armorValue)
```

```csharp
public void RepairArmor()
```

```csharp
public int ShredArmor(int armorValueToShred)
```

```csharp
public float ChipArmor(float chip)
```

```csharp
public float GetArmorIntegrity()
```

```csharp
public static float GetArmorFacingVolume_m3(TISpaceShipState ship, ArmorFacing facing)
```

```csharp
public static TIShipArmorTemplate GetArmorTemplate(TISpaceShipState ship, ArmorFacing facing)
```
