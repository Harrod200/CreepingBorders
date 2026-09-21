# TISpaceFleetState

*Decompiled from `PavonisInteractive/TerraInvicta/TISpaceFleetState.cs`.*


## Class `TISpaceFleetState`

```csharp
public class TISpaceFleetState : TISpaceAssetState, IOperationCapableState, IMobileAsset, ITransferTarget
```

### Fields

| Name | Type |
|---|---|
| `fleetTrajectoryData` | public FleetTrajectoryData |
| `waitingForCombat` | public bool |
| `inCombatOrWaitingForCombat` | public bool |
| `inEarthSystem` | public override bool |
| `IsFullyInitialized` | public bool |
| `isSpaceFleetState` | public override bool |
| `searchable` | public override Searchable |
| `ref_faction` | public override TIFactionState |
| `ref_hab` | public override TIHabState |
| `ref_habSite` | public override TIHabSiteState |
| `ref_orbit` | public override TIOrbitState |
| `ref_fleet` | public override TISpaceFleetState |
| `ref_spaceAsset` | public override TISpaceAssetState |
| `ref_spaceBody` | public override TISpaceBodyState |
| `ref_naturalSpaceObject` | public override TINaturalSpaceObjectState |
| `barycenter` | public override TINaturalSpaceObjectState |
| `template` | public new TISpaceFleetTemplate |
| `smallShips` | public List<TISpaceShipState> |
| `mediumShips` | public List<TISpaceShipState> |
| `largeShips` | public List<TISpaceShipState> |
| `objectType` | public override SpaceObjectType |
| `mass_kg` | public override double |
| `altitude_km` | public float |
| `dockedOrLanded` | public bool |
| `landed` | public bool |
| `dockedAtHab` | public bool |
| `landedAtBase` | public bool |
| `dockedAtStation` | public bool |
| `landedInOutback` | public bool |
| `transferAssigned` | public bool |
| `inTransfer` | public bool |
| `isCapableOfTransfering` | public bool |
| `mayLegallyStartATransfer` | public bool |
| `bombarding` | public bool |
| `cruiseAcceleration_kps2` | public float |
| `cruiseAcceleration_mps2` | public float |
| `maxAcceleration_mps2` | public float |
| `pursuitAcceleration_mps2` | public float |
| `pursuitAcceleration_gs` | public float |
| `cruiseAcceleration_gs` | public float |
| `maxAcceleration_gs` | public float |
| `fullyLoadedAcceleration_gs` | public float |
| `maxDeltaV_kps` | public float |
| `currentDeltaV_kps` | public float |
| `currentDeltaV_mps` | public float |
| `councilorPassengers` | public List<TICouncilorState> |
| `alienPassengers` | public List<TICouncilorState> |
| `modelResource` | public override string |
| `meanRadius_m` | public override double |
| `meanRadius_km` | public override double |
| `modelScale` | public override float |
| `allShipsHaveDeltaV` | public bool |
| `allShipsCanManeuver` | public bool |
| `availableDeltaVforPrecombat_kps` | public float |
| `availableDeltaVforPrecombat_mps` | public float |
| `pipPosition` | public Vector3[] |
| `RotationNow` | public Quaternion |
| `semiMajorAxis_m` | public override double |
| `ecc` | public override double |
| `inclination_Rad` | public override double |
| `longAscendingNode_Rad` | public override double |
| `argPeriapsis_Rad` | public override double |
| `meanAnomalyAtEpoch_Rad` | public override double |
| `epoch_JYears` | public override double |
| `meanLongitude_Rad` | public override double |
| `location` | public override TISpaceGameState |
| `iconResource` | public override string |
| `RallyingFleets` | public IEnumerable<TISpaceFleetState> |
| `IsStarterAlienCouncilorFleetInOriginalLocation` | public bool |
| `fleetIsLost` | public bool |
| `CombatRecoveryEventName` | public string |
| `FireMissionEventName` | public string |
| `underBombardment` | public bool |
| `bombardXenofaunaCheck` | private string |
| `RefitsAvailable` | public Dictionary<TISpaceShipState, TISpaceShipTemplate> |
| `AllowUseBoostForRepairsResupply` | public bool |
| `RelativeValueOfRefittedFleet` | public float |
| `FormationWidth` | public float |
| `displayNameByFaction` | private Dictionary<TIFactionState, string> |
| `EXISTING_TRAJECTORY_ACCELERATION_FORGIVENESS` | public const double |
| `currentOperations` | public List<OperationData> |
| `dockedLocation` | public TISpaceGameState |
| `_fleetTrajectoryData` | private FleetTrajectoryData |
| `battleFormationOffset` | private Vector3 |
| `combatState` | public TISpaceCombatState |
| `parentFleet` | public TISpaceFleetState |
| `alwaysShowOrbitTrailDuringTransfer` | public bool |
| `AI_FailedAttackEnemyStrength` | public Dictionary<TIGameState, float> |
| `unreachableLocations` | public HashSet<TIGameState> |
| `gameStateSubjectCreated` | private bool |
| `dummyFleet` | public bool |
| `bombardmentAltitude_km` | public float |
| `timeOfLastFireMission` | public TIDateTime |
| `delayedTransferAbortNotification` | public TISpaceFleetState.DelayedTransferAbortNotification |
| `campaignStartLocation` | public TISpaceGameState |
| `_visibleOperationListCacheFrame` | private int |
| `_cachedVisibleOperationList` | private List<IOperation> |
| `_availableOperationListCacheFrame` | private int |
| `_cachedAvailableOperationList` | private List<IOperation> |
| `endBombardmentReason` | public TISpaceFleetState.EndBombardmentReason |
| `bombardmentTargetBracketStatus` | private TISpaceFleetState.BombardmentBracketingStatus |
| `firstHitFromBombardmentRun` | private bool |
| `degreesStep` | private const float |
| `ReportableEndBombardmentReasons` | public static readonly List<TISpaceFleetState.EndBombardmentReason> |
| `requiredPartFunctionforMarineAssault` | public const float |
| `AI_NeedRefuelBadly_LocalResupply_kps` | private const float |
| `AI_NeedRefuelBadly_AlienMin_kps` | private const float |
| `AI_NeedRefuelBadly_HumanMin_kps` | private const float |
| `AI_NeedRefuelBadly_DVPerAU_kps` | private const float |
| `officerTransferPlan` | public Dictionary<TIOfficerState, OfficerCarrierState> |
| `defaultAlienFormation` | public readonly Formation |
| `defaultHumanFormation` | public readonly Formation |
| `defaultAlienCombatFormation` | public readonly Formation |
| `defaultHumanCombatFormation` | public readonly Formation |
| `dockedFormation` | public readonly Formation |
| `waitingToInitiateCombatDatas` | private List<TISpaceFleetState.WaitingToInitiateCombatData> |
| `fleetsWaitingToInitiateCombat` | public static HashSet<TISpaceFleetState> |
| `Logs` | public List<TISpaceFleetState.FleetLog> |
| `DelayedTransferAbortNotification` | public class |
| `cause` | public int |
| `outcome` | public int |
| `doomedFleet` | public TISpaceFleetState |
| `collisionTarget` | public TISpaceBodyState |
| `BombardmentBracketingStatus` | private enum |
| `EndBombardmentReason` | public enum |
| `WaitingToInitiateCombatData` | public struct |
| `TargetFleet` | public TISpaceFleetState |
| `TargetHab` | public TIHabState |
| `FleetLog` | public struct |
| `Label` | public string |
| `Date` | public TIDateTime |
| `Location` | public TIGameState |
| `GoalType` | public GoalType |
| `GoalTarget` | public TIGameState |
| `GoalTargetFaction` | public TIFactionState |
| `ShipCount` | public int |
| `FuelMass_dekatons` | public float |

### Properties

- `public List<TISpaceShipState> ships`
- `public Formation formation`
- `public Formation savedFormation`
- `public Trajectory trajectory`
- `public List<PropellantSharingEvent> propellantSharingPlan`
- `public bool inAccelerationPhase`
- `public bool inDecelerationPhase`
- `public bool unavailableForOperations`
- `public TIDateTime returnToOperationsTime`
- `public bool huntingXenofauna`
- `public TIGameState bombardmentTarget`
- `public string fleetOperationCompleteName`
- `public TIHabState homeport`
- `public Vector3d dockOffset`
- `public Trajectory[] proposedTrajectories`

### Methods

```csharp
public override float CombatRange_km()
```

```csharp
public override bool IsAlien()
```

```csharp
public override float SpaceCombatValue()
```

```csharp
public void destroyProposedTrajectories()
```

```csharp
public string GetLocationDescription(TIFactionState faction, bool capitalize, bool expand)
```

```csharp
public string FleetQuickDescription(TIFactionState viewingFaction)
```

```csharp
public override Vector3d GetGlobalPositionAtTime(TIDateTime time)
```

```csharp
public bool InSphereOfInfluence(TISpaceObjectState spaceObject)
```

```csharp
public override TINaturalSpaceObjectState GetSphereOfInfluence(bool exact = false)
```

```csharp
private double MaxPreAerobreakVelocity_mps(double postAerobreakVelocity_mps, bool isSafe)
```

```csharp
public override bool tryToGetLocalCartesianState(TIDateTime time, out CartesianState cartesianState, out TINaturalSpaceObjectState barycenter)
```

```csharp
public override TINaturalSpaceObjectState localBarycenter(TIDateTime time)
```

```csharp
public override void getOrbitalElementsState(TIDateTime time, out OrbitalElementsState orbitalElementsState, out TINaturalSpaceObjectState barycenter, out bool meanAnomalyIsGood)
```

```csharp
public override double common_a_m(TINaturalSpaceObjectState commonBarycenter)
```

```csharp
public override double common_i_rad(TINaturalSpaceObjectState commonBarycenter)
```

```csharp
public override double common_M_rad(TINaturalSpaceObjectState commonBarycenter, TIDateTime time)
```

```csharp
public override bool Initialize()
```

```csharp
public override void InitWithTemplate(TIDataTemplate template)
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
public override void PostInitializationInit_4()
```

```csharp
private void RepairTrajectorieWithHyperbolicMicrothrusting()
```

```csharp
private void RepairPotentialTrajectoryNullFleetReference_PreVisualizer()
```

```csharp
private void RepairPotentialInvalidTrajectoryFleetReference()
```

```csharp
private void RepairPotentialInvalidCommonBarycenterForTrajectory()
```

```csharp
private void RepairPotentialIllegalOrbit()
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
private void RepairPotentialLaunchInconsistency()
```

```csharp
private void RepairPotentialMissingDestination()
```

```csharp
private void RepairPotentialNonsenseNextTrajectory()
```

```csharp
private void RepairPotentialBrokenBurn()
```

```csharp
private void RepairPotentialInvalidBurn()
```

```csharp
private void RepairPotentialInconsistendOperationTargetAndTransferDestination()
```

```csharp
public void OnFleetCreated()
```

```csharp
public void InitializeRunTimeFleetData(bool suppressLogging)
```

```csharp
public void SetFaction(TIFactionState newFaction)
```

```csharp
public FactionGoal_Fleet AssignedGoal()
```

```csharp
public static TISpaceFleetState CreateAtRunTime(TIFactionState faction, List<TISpaceShipState> ships, TIGameState location, TISpaceFleetState parentFleet, FactionGoal_Fleet AIBuiltForGoal = null, bool theft = false, bool spawnedFighters = false, Trajectory trajectory = null)
```

```csharp
public override void CreateVisualizer(TIDataTemplate myTemplate)
```

```csharp
public void Disband()
```

```csharp
public void PostCombat(TISpaceCombatState combat, double combatDuration_s, bool relocate)
```

```csharp
public void CombatRecovery()
```

```csharp
public void CombatRecovery(TimeEventStart e)
```

```csharp
public List<IOperation> VisibleOperationList(TINaturalSpaceObjectState naturalSpaceObject = null)
```

```csharp
public List<IOperation> AllowedOpsList()
```

```csharp
public List<IOperation> AvailableOperationList(TINaturalSpaceObjectState naturalSpaceobject = null)
```

```csharp
public List<OperationData> CurrentOperations()
```

```csharp
public void CancelOperation(OperationData operation)
```

```csharp
public void ForceCancelCurrentOperations()
```

```csharp
public void ForceCancelCurrentOperations(TISpaceFleetOperationTemplate operation)
```

```csharp
public void OnTimedOperationComplete(TimeEventStart e)
```

```csharp
public void CompleteFleetOperation(IOperation operation, TIGameState target)
```

```csharp
public bool CanMerge(TISpaceFleetState otherFleet)
```

```csharp
public override List<TISpaceFleetState> GetNearbyIdleAlliedFleets(TIDateTime time = null)
```

```csharp
public void ScuttleShips(List<TISpaceShipState> ships)
```

```csharp
public bool MustAcceptCombatAsDefender()
```

```csharp
public void InitiateBombardment(TIGameState target, bool fromSave, float altitude_km)
```

```csharp
public void ForceEndBombardment(TISpaceFleetState.EndBombardmentReason reason)
```

```csharp
public void EndBombardment(TISpaceFleetState.EndBombardmentReason reason)
```

```csharp
public void FireMission(TimeEventStart e)
```

```csharp
public static bool WeaponCanBombardSpaceBody(ModuleDataEntry weaponModuleData, TISpaceBodyState spaceBody)
```

```csharp
protected void FireMission(TIDateTime time, out bool targetHit, out bool anyCapableShip)
```

```csharp
public void AddToBombardmentLog(string toAdd, TIDateTime logTime)
```

```csharp
public bool CanHuntXenofauna()
```

```csharp
public void SetHuntingXenofauna(bool setting, bool involuntary)
```

```csharp
private void CheckAutoBombardXenofauna(TimeEventStart e)
```

```csharp
public void AttemptBombardXenofauna()
```

```csharp
public void PostAssaultDamage(TIMissionOutcome outcome, bool offense)
```

```csharp
public List<TIOfficerState> PostAssaultPromotionsAndDeaths(TIMissionOutcome outcome, bool offense, out List<TIOfficerState> officerDeaths)
```

```csharp
public override float AssaultCombatValue(bool defense)
```

```csharp
public float InvasionCombatValue()
```

```csharp
public bool AI_LegsToUseSiteForResupply(TIHabSiteState site, float hypetheticalDVPenalty_kps = 0f)
```

```csharp
public bool AI_NeedsRefuel()
```

```csharp
public bool NeedsRefuel()
```

```csharp
public bool NeedsRearm()
```

```csharp
public bool NeedsRepair()
```

```csharp
public bool AI_NeedsRefuelBadly()
```

```csharp
public bool AI_InterfleetRefuelCandidate()
```

```csharp
public bool AI_NeedsRearmBadly()
```

```csharp
public bool AI_NeedsRepairBadly()
```

```csharp
public bool AI_SeekSpecialHabRepairIfNecessary()
```

```csharp
public void TruncateResupplyAndRepair(float fractionCompleted)
```

```csharp
public bool ShipFinishedRepair(float fractionCompleted, TISpaceShipState ship)
```

```csharp
public bool CanRefitAtLocation()
```

```csharp
public bool NeedsRefit()
```

```csharp
public bool CanAffordAnyPropellant(TIFactionState faction)
```

```csharp
public bool CanAffordAnyReloading(TIHabState hab)
```

```csharp
public bool CanAffordAnyRepairs(TIHabState hab)
```

```csharp
public bool IsResupplying()
```

```csharp
public bool IsRepairing()
```

```csharp
public bool CanSharePropellant()
```

```csharp
public List<PropellantGroup> BuildPropellantGroups()
```

```csharp
public void SetPropellantSharingPlan(List<PropellantSharingEvent> plan)
```

```csharp
public void ExecutePropellantSharingPlan()
```

```csharp
public static List<PropellantSharingEvent> CreatePropellantSharingPlan_Equalization(List<TISpaceShipState> group, bool mustMeaningfullyImproveGroupDV = false)
```

```csharp
public bool AI_CreatePropellantSharingPlan_Equalization()
```

```csharp
private static float CalcEqualDeltaV(List<TISpaceShipState> group)
```

```csharp
public int GetOfficerCountInShips()
```

```csharp
public void SetOfficerTransferPlan(Dictionary<TIOfficerState, OfficerCarrierState> plan)
```

```csharp
public void ExecuteOfficerTransferPlan()
```

```csharp
public void AI_OptimizeOfficers()
```

```csharp
public Formation DefaultFormation()
```

```csharp
public void AssignFormation(string shapeDataName, FormationSpacing spacing, FormationConcentration concentration, FormationFocus focus, int numberOfPositions, bool invertZ = false, bool initialAssignment = false, bool forStratLayer = false)
```

```csharp
public void AssignFormation(Formation formation, bool invertZ = false, bool initialAssignment = false, bool saveFormation = false, bool isCombatSetup = false, bool forStratLayer = false)
```

```csharp
public void ResetFormation(bool invertZ = false, bool forStratLayer = false)
```

```csharp
public void TeleportAllToFormation(bool invertZ = false, bool forStratLayer = false)
```

```csharp
public Vector3d FormationCenter(bool includeZ = false)
```

```csharp
public void AddShipsToFleet(List<TISpaceShipState> newShips, TISpaceFleetState originFleet, bool storeFaction = false, bool startup = false)
```

```csharp
private void ForceIconResourceReset()
```

```csharp
private void AddShipToFleet(TISpaceShipState ship, Vector3d currentPosition, TISpaceFleetState oldFleet, Vector3d oldFleetPosition)
```

```csharp
public void RemoveShipsFromFleet(List<TISpaceShipState> shipsToRemove, TISpaceFleetState newFleet = null)
```

```csharp
public TISpaceShipState GetFlagship()
```

```csharp
public int RawMissionControlConsumption()
```

```csharp
public int MissionControlConsumption()
```

```csharp
public int GetFleetOrbitInterestLevel()
```

```csharp
public static TIOrbitState FinalDestinationOrbit(TISpaceFleetState fleet)
```

```csharp
public static TINaturalSpaceObjectState FinalDestinationNaturalSpaceObject(TISpaceFleetState fleet)
```

```csharp
public TIDateTime GetArrivalTimeSortWeight()
```

```csharp
public List<TISpaceShipState> ShipsWithSpecialModuleRule(SpecialModuleRule rule)
```

```csharp
public List<TISpaceShipState> ShipsWithSpecialModuleRule(List<SpecialModuleRule> rules)
```

```csharp
public void ExpendSpecialModuleCapability(List<SpecialModuleRule> capability, bool all = false, bool destroyEntireShip = false)
```

```csharp
public bool HasSpecialModuleCapability(SpecialModuleRule capability)
```

```csharp
public bool HasFoundHabCapability()
```

```csharp
public float BombardmentValue(TISpaceBodyState spaceBody)
```

```csharp
public float BombardmentValue(TISpaceBodyState spaceBody, float range_km)
```

```csharp
public float SalvageBonus()
```

```csharp
public new void SetDisplayName(string displayName)
```

```csharp
public void ForceDisplayName(TIFactionState faction, string name)
```

```csharp
public void SetDisplayName(TIFactionState detectingFaction, string forceString = null, bool nameEdit = false)
```

```csharp
public override string GetDisplayName(TIFactionState namingFaction)
```

```csharp
public bool DetailsVisibleToFaction(TIFactionState faction)
```

```csharp
public List<TICouncilorState> CouncilorsPresentAndKnownToFaction(TIFactionState faction)
```

```csharp
public List<CouncilorView> CouncilorViewsPresentAndKnownToFaction(TIFactionState faction)
```

```csharp
public bool DoIKnowThisFleetIsTransfering(TIFactionState myFaction)
```

```csharp
protected void RemoveTransfer()
```

```csharp
public void Land(TIHabSiteState site)
```

```csharp
public void Dock(TIHabState hab, bool newFleet = false)
```

```csharp
public void DepartFromDockingLocation()
```

```csharp
public void SetAccelerationPhaseStatus(bool inPhase, bool forceRotation = false, bool forceStop = false)
```

```csharp
public void SetDecelerationPhaseStatus(bool inPhase, bool forceRotation = false, bool forceStop = false)
```

```csharp
public void AssignTrajectory(Trajectory trajectoryToAssign)
```

```csharp
public void RefreshTrajectory()
```

```csharp
public void GlobalCheckNotifyFleetLaunch()
```

```csharp
public void LaunchFleet(bool alertInterceptingFleets = true)
```

```csharp
public List<TISpaceFleetState> CheckForTransferTargetLoop()
```

```csharp
public List<TISpaceGameState> GetChainedDestinations()
```

```csharp
public List<TISpaceFleetState> GetFleetsWeAreIntercepting(bool destroyBadFleet = false)
```

```csharp
public void TransferTargetFleetHasManeuvered()
```

```csharp
public double TrajectoryFractionCompleted()
```

```csharp
public double DVConsumedOnTrajectory_kps()
```

```csharp
public float DVRequiredToCompleteTrajectory_kps()
```

```csharp
public void FinishWaitingToInitiateCombat()
```

```csharp
public bool InitiateCombat(TISpaceFleetState targetFleet, TIHabState hab, bool allowDummyFleetToStart = false)
```

```csharp
public Dictionary<float, List<TISpaceShipState>> GetAccelerationGroups(bool combat)
```

```csharp
public void AssumeTargetFleetTrajectory(Trajectory oldTrajectory)
```

```csharp
public bool PrecludeDockingWithEnemyStation(TIHabState station)
```

```csharp
public void ApproachDock(TIHabState hab)
```

```csharp
public void ArriveFleet(bool startupFix = false)
```

```csharp
public void SetHomePort(TIHabState hab)
```

```csharp
protected override OrbitalElementsState ToOrbitalElementsState(TIDateTime time = null)
```

```csharp
public override CartesianState ToLocalCartesianStateAtTime(TIDateTime time)
```

```csharp
public bool AnyValidTrajectory(TIGameState destination)
```

```csharp
public void VerifyAssignedTransfer(bool delayNotification = false)
```

```csharp
public void AbortTransfer(int cause, TIDateTime now = null, bool delayNotification = false)
```

```csharp
private IEnumerable<TISpaceFleetState> GetAllFleetsRendezvousingWithUs()
```

```csharp
private void TryToRemoveAdHocOrbit(TIAdHocOrbitState adHocOrbit)
```

```csharp
public bool IsTransferingAtTime(TIDateTime time)
```

```csharp
private void HandleSpaceObjectSelection(bool removeSelection = false)
```

```csharp
public bool CanFulfillGoal(FactionGoal_Fleet goal, bool emergency = false)
```

```csharp
public bool CombatFleet()
```

```csharp
public bool NonCombatFleet()
```

```csharp
public bool InvasionFleet()
```

```csharp
public bool SurveillanceFleet()
```

```csharp
public void RecordFailedAttackOnTarget(TIGameState target, float value = 1f, bool additive = false)
```

```csharp
public void RemoveFailedAttackRecord(TIGameState target)
```

```csharp
public float GetFailedAttacksOnTargetValue(TIGameState target)
```

```csharp
public int GetFailedAttacksOnTargetCount(TIGameState target)
```

```csharp
public void AddFleetLog(string label)
```

```csharp
public List<ValueTuple<GoalType, TIGameState, TIFactionState>> GetRecentGoalInfo(float maximumAge_days)
```

```csharp
public static void ClearStaticData()
```
