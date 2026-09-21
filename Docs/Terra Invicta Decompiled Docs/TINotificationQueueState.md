# TINotificationQueueState

*Decompiled from `PavonisInteractive/TerraInvicta/TINotificationQueueState.cs`.*


## Class `TINotificationQueueState`

```csharp
public class TINotificationQueueState : TIGameState
```

### Fields

| Name | Type |
|---|---|
| `activePlayer` | public static TIFactionState |
| `AllFactions` | private static List<TIFactionState> |
| `usedCouncilorMessages` | private Dictionary<TIFactionState.Advice, int> |
| `alienEvents` | public int |
| `promptQueue` | private TIPromptQueueState |
| `firstTimeTracker` | public Dictionary<TIFactionState, Dictionary<string, int>> |
| `maxNotificationQueueSize` | private const int |
| `maxBombardmentQueueSize` | private const int |
| `maxSummaryQueueSize` | private static readonly Dictionary<SummaryCategory, int> |
| `musicIntensityStep` | public const float |

### Properties

- `public List<NotificationQueueItem> notificationQueue`
- `public Queue<CouncilorMessage> councilorMessages`
- `public List<NotificationSummaryItem> notificationSummaryQueue`
- `public List<NotificationSummaryItem> timerNotificationQueue`
- `public Dictionary<SummaryCategory, List<NotificationSummaryItem>> panelSummaryQueue`

### Methods

```csharp
public override bool Initialize()
```

```csharp
public override void PostGlobalGameStateCreateInit_2()
```

```csharp
public override void PostVisualizerCreationInit_7()
```

```csharp
private static void AddItem(NotificationQueueItem item, bool addToAlienQueue = false)
```

```csharp
private static void AddRapidItem(NotificationSummaryItem summary, List<TIFactionState> factions)
```

```csharp
private void OnAlarmTriggered(TimeEventStart e)
```

```csharp
public static bool FirstNotificationOfType(TIFactionState faction, string notificationTemplateName)
```

```csharp
public static void CheckAndSetFirstNotificationOfType(NotificationQueueItem item)
```

```csharp
public static void SetFirstNotificationofType(TIFactionState faction, string notificationTemplateName)
```

```csharp
private static List<TIFactionState> AllFactionsExcept(TIFactionState councilState)
```

```csharp
private static List<TIFactionState> AllFactionsWithIntel(TIGameState target, float intelThreshhold)
```

```csharp
private static TIGameState GenericGotoState(TIGameState state)
```

```csharp
private static NotificationQueueItem InitItem(string templateName)
```

```csharp
public static void CleanQueueOfArchivedState(TIGameState state, TIGameState substituteState = null)
```

```csharp
public void CleanSummaryQueue(bool logit)
```

```csharp
public static string councilorGUIIconPath(TICouncilorState councilor)
```

```csharp
public float GetBaselineMusicIntensity(TIFactionState playerFaction)
```

```csharp
private static string GetRandomQuietExplosion()
```

```csharp
public static void LogPrecrashCampaignStart()
```

```csharp
public static void LogCampaignStart(TIFactionState faction, TIRegionState initialLandingLocation)
```

```csharp
public static void LogTutorialStart(TIFactionState faction)
```

```csharp
public static string AlarmString(TIFactionState faction, TIGameState target, Alarm alarm)
```

```csharp
public static void LogAlarmTriggered(TIFactionState faction, TIGameState target, Alarm alarm)
```

```csharp
public static void LogFactionWin(TIFactionState faction)
```

```csharp
public static void LogTimeChangeUpdate(TITimeQueueRepeatType newUpdateTiming)
```

```csharp
public static void LogFleetDetected(TIFactionState detectingFaction, TISpaceFleetState fleet)
```

```csharp
public static void LogHumanHabDetected(TIFactionState detectingFaction, TIHabState hab)
```

```csharp
public static void LogAlienHabDetected(TIFactionState detectingFaction, TIHabState hab)
```

```csharp
public static void LogAssaultCarrierLaunchesTowardEarth(List<TIFactionState> notifyFactions, TISpaceFleetState alienFleet, TIDateTime arrival)
```

```csharp
public static void LogFleetLaunchesTowardMyAsset(TISpaceFleetState fleet, ITransferTarget myAsset, List<TIFactionState> notifyFactions, TIDateTime arrival)
```

```csharp
public static void LogFleetEjectedFromStation(TISpaceFleetState fleet, TIHabState station)
```

```csharp
public static void LogFleetArrival(TISpaceFleetState fleet, TISpaceGameState origin, TISpaceGameState location, bool willResupply, bool willRepair, Dictionary<TIFactionState, string> factionSpecificText)
```

```csharp
public static void LogTrajectoryTargetManeuveredAndWeCannotChase(TISpaceFleetState fleet, int cause, TISpaceFleetState targetFleet)
```

```csharp
public static void LogTrajectoryAborted(TISpaceFleetState fleet, int cause, int outcome, TISpaceFleetState newFleet = null, TISpaceBodyState crashingInto = null)
```

```csharp
public static void LogFleetCrashes(TISpaceFleetState fleet, TISpaceBodyState spaceBody)
```

```csharp
public static void LogFleetEscapesSolarSystem(TISpaceFleetState fleet)
```

```csharp
public static void LogFleetLanded(TISpaceFleetState fleet)
```

```csharp
public static void LogFleetsMerged(TISpaceFleetState fleet, string oldFleetDisplayName)
```

```csharp
public static void LogNoSpaceBattleTakesPlace(TIFactionState attacker, TIFactionState defender, TISpaceObjectState location, string battleName)
```

```csharp
public static void LogSpaceBattleTakesPlace(TIFactionState attacker, TIFactionState defender, TIFactionState winner, TIFactionState loser, TISpaceFleetState fleet1, TISpaceFleetState fleet2, TIHabState hab, TISpaceObjectState location, string battleName, int attackerLosses, int defenderLosses)
```

```csharp
public static void LogInitiateOrbitalBombardment(TISpaceFleetState fleet, TIGameState target)
```

```csharp
public static void LogOrbitalBombardmentComplete(TISpaceFleetState fleet, TIGameState target, IOperation operation, TISpaceFleetState.EndBombardmentReason reason)
```

```csharp
public static void LogAutoBombardementCancelled(TISpaceFleetState fleet, bool outOfAmmo)
```

```csharp
public static void LogBombardingFleetEntersDangerZone(TISpaceFleetState fleet)
```

```csharp
public static void LogShipDestroyedInStrat(TISpaceShipState ship, List<TIFactionState> destroyers, TIGameState location, Dictionary<TIFactionState, string> officerDeaths)
```

```csharp
public static void LogOurFleetRefueled(TISpaceFleetState fleet, bool interfleet)
```

```csharp
public static void LogOurFleetRepaired(TISpaceFleetState fleet)
```

```csharp
public static void LogFleetAvailableForOperations(TISpaceFleetState fleet)
```

```csharp
public static void LogFleetStoleOurFuel(TISpaceFleetState fleet, TIHabState hab)
```

```csharp
public static void LogFleetUndocked(TISpaceFleetState fleet, TIHabState hab)
```

```csharp
public static void Rapid_LogBombardmentShot(TISpaceFleetState fleet, TIGameState target, TIDateTime dateTime, string outcome)
```

```csharp
public static void LogProbeLaunched(TIFactionState faction, TISpaceBodyState spaceBody)
```

```csharp
public static void LogProbeArrived(TIFactionState faction, TISpaceBodyState spaceBody)
```

```csharp
public static void LogEnemyProbeLaunched(TIFactionState faction, TISpaceBodyState spaceBody)
```

```csharp
public static void LogEnemyProbeArrived(TIFactionState faction, TISpaceBodyState spaceBody)
```

```csharp
public static void LogScanningPlanet(TISpaceFleetState fleet, TISpaceBodyState spaceBody, float duration)
```

```csharp
public static void LogScannedPlanet(TISpaceFleetState fleet, TISpaceBodyState spaceBody)
```

```csharp
public static void LogHabFounded(TIFactionState faction, TIHabState hab, TIGameState location)
```

```csharp
public static void LogHabModuleComplete(TISectorState sector, TIHabModuleTemplate module, string altName = "")
```

```csharp
public static void LogCriticalHabModuleComplete(TISectorState sector, TIHabModuleTemplate module)
```

```csharp
public static void LogHabAcquired(TIHabState hab, TIFactionState capturingFaction, TIFactionState oldFaction, bool modulesDestroyed, bool assault, bool mission, Dictionary<TIFactionState, string> factionStrings)
```

```csharp
public static void LogHabDefected(TIHabState hab, TIFactionState capturingFaction, TIFactionState oldFaction, bool modulesDestroyed)
```

```csharp
public static void LogHabAssaultFailed(TIGameState assaultingAsset, TIHabState hab, Dictionary<TIFactionState, string> bonusStrings, TIMissionOutcome outcome)
```

```csharp
public static void LogHabDefendInterestEnds(TIHabState hab)
```

```csharp
public static void LogHabDestroyed(TIHabState hab, TIFactionState destroyingFaction, TIFactionState oldFaction, TIResourcesCost recoveredResources, TIGameState destroyingFleet = null)
```

```csharp
public static void LogHabModuleForcedOffDueToPopulationChanges(TIFactionState faction, TINaturalSpaceObjectState state, List<TIHabState> factionHabs)
```

```csharp
public static void LogShipComplete(TISpaceShipState ship, TIHabState hab, bool isACancelledRefit = false)
```

```csharp
public static void LogOfficerKilledOutsideofCombat(TIOfficerState officer)
```

```csharp
public static void LogOfficerRetires(TIOfficerState officer)
```

```csharp
public static void LogObjectiveComplete(TIFactionState faction, TIObjectiveTemplate finishedTemplate, List<TIObjectiveTemplate> newlyUnlockedObjectives)
```

```csharp
public static void LogMilestoneComplete(TIFactionState faction, CampaignMilestone milestone)
```

```csharp
public static void LogGlobalMilestoneComplete(TIFactionState faction, GlobalMilestone milestone, TIGameState winningObject, List<ResourceValue> reward)
```

```csharp
public static void LogObjectiveUnlocked(TIFactionState faction, TIObjectiveTemplate unlockedObjective)
```

```csharp
public static void LogOtherFactionUnlocksVictoryCondition(TIFactionState unlockingFaction)
```

```csharp
public static void LogFirstFactionEncounter(TIFactionState detectingFaction, TIFactionState encounteredFaction, TIGameState encounterSource, TIGameState location)
```

```csharp
public static void LogFactionDefeated(TIFactionState deadFaction)
```

```csharp
public static void LogAlienCrashdown(TIRegionState region, bool firstCrashdown)
```

```csharp
public static void LogUFOLanding(TIRegionState region)
```

```csharp
public static void LogUFOLandingAssaulted(TIGameState assaultingState, TIFactionState faction, TIRegionUFOLandingState UFO)
```

```csharp
public static void LogUFOLandingBombed(TISpaceFleetState fleet, TIRegionUFOLandingState UFO)
```

```csharp
public static void LogAlienArmySpawned(TIAlienArmyState alienArmy)
```

```csharp
public static void LogAbductions(TIFactionState detectingFaction, TIRegionState region)
```

```csharp
public static void LogEnthrallElites(TIFactionState detectingFaction, TIRegionState region)
```

```csharp
public static void LogEnthrallOrg(TIFactionState detectingFaction, TIRegionState region, TIOrgState orgTarget, TICouncilorState councilorTarget, TIFactionState factionTarget)
```

```csharp
public static void LogEnthrallPublic(TIFactionState detectingFaction, TIRegionState region)
```

```csharp
public static void LogTerrorize(TIFactionState detectingFaction, TIRegionState region)
```

```csharp
public static void LogXenoformMission(TIFactionState detectingFaction, TIRegionState region, bool forcePopup = false)
```

```csharp
public static void LogAlienFacilityDetected(TIFactionState detectingFaction, TIRegionAlienFacilityState alienFacility)
```

```csharp
public static void LogAlienFacilityAssaulted(TIGameState assaultingState, TIFactionState faction, TIRegionAlienFacilityState facility, float exoticsGained, int abductionsEliminated)
```

```csharp
public static void LogAlienFacilityBombed(TISpaceFleetState fleet, TIRegionAlienFacilityState facility)
```

```csharp
public static void LogXenoformingDetected(TIFactionState detectingFaction, TIRegionXenoformingState xenoforming)
```

```csharp
public static void LogAlienFaunaArmySpawned(TIMegafaunaArmyState army)
```

```csharp
public static void LogAlienNationFounded(TINationState alienNation, TINationState absorbedNation, bool peaceful)
```

```csharp
public static void LogAlienNationGrows(TINationState alienNation, TIGameState absorbedGameState)
```

```csharp
public static void LogAlienNationCapitalConquered(TINationState alienNation, TIRegionState oldCapital, TIRegionState newCapital)
```

```csharp
public static void LogAlienNationOverthrown(TINationState alienNation, TIRegionState capital)
```

```csharp
public static void LogAlienNationConquered(TINationState alienNation, TIArmyState conqueringArmy)
```

```csharp
public static void LogAliensPassTechnologyToMe(TICouncilorState grantingAlien, TICouncilorState receivingCouncilor, float research, float exotics)
```

```csharp
public static void LogEnemyCouncilorKilledOnMissionTargetingMe(TIMissionState mission)
```

```csharp
public static void LogMyCouncilorKilledOnMission(TIMissionState mission)
```

```csharp
public static void LogMyCouncilorDetained(TIFactionState detainingFaction, TICouncilorState detainedCouncilor)
```

```csharp
public static void LogMyCouncilorReleased(TIFactionState detainingFaction, TICouncilorState detainedCouncilor)
```

```csharp
public static void LogMyCouncilorAssassinated(TICouncilorState deadCouncilor, TICouncilorState killingCouncilor, float hate)
```

```csharp
public static void LogEnemyMissionFailure(TIMissionState mission, MissionResult result)
```

```csharp
public static void LogCouncilorKilledInAttack(TICouncilorState deadCouncilor, TIGameState location)
```

```csharp
public static void LogCouncilorPassesAway(TICouncilorState deadCouncilor)
```

```csharp
public static void LogCouncilorGainsTrait(TICouncilorState councilor, TITraitTemplate trait)
```

```csharp
public static void LogDetainedCouncilorDismissed(TIFactionState detainingFaction, TICouncilorState detainedCouncilor)
```

```csharp
public static void LogControlPointDefenseExpires(TIControlPoint controlPoint)
```

```csharp
public static void LogCrackdownExpires(TIControlPoint controlPoint)
```

```csharp
public static void LogControlConsolidated(TIFactionState faction, TINationState nation)
```

```csharp
public static void LogCPDominated(TIControlPoint controlPoint, TIFactionState newOwner, TIFactionState oldOwner, TIMissionOutcome outcome, List<TIGameState> newControlPoints, List<TIGameState> oldControlPoints)
```

```csharp
public static void LogMissionOutcome(TIMissionState mission, MissionResult result, TIFactionState heldTargetFaction, List<TIGameState> newControlPoints = null, List<TIGameState> oldControlPoints = null, bool spy = false, string abortedReason = "")
```

```csharp
public static void LogIPassivelyCapturedACouncilor(TICouncilorState capturedCouncilor, TIFactionState myFaction, TIGameState location)
```

```csharp
public static void LogFactionOrgStolen(TIFactionState stealingFaction, TIFactionState victimFaction, TIOrgState org, List<TIOrgState> discardedOrgs, TICouncilorState victimCouncilor = null)
```

```csharp
public static void LogMyOrgStolen(TIFactionState stealingFaction, TICouncilorState victim, TIFactionState victimFaction, TIOrgState org, List<TIOrgState> discardedOrgs)
```

```csharp
public static void LogOrgsForcedToPool(TIFactionState faction, List<TIOrgState> lostOrgs)
```

```csharp
public static void LogOrgPoolOverfull(TIFactionState faction)
```

```csharp
public static void LogMyTechSabotaged(TIFactionState attackingFaction, TIFactionState sabotagedFaction, TIProjectTemplate project, float hate)
```

```csharp
public static void LogMyTechStolen(TIFactionState stealingFaction, TIFactionState victimFaction, TIProjectTemplate project, float hate)
```

```csharp
public static void LogSpyDiscovered(TICouncilorState councilor)
```

```csharp
public static void LogSpyLost(TIFactionState losingFaction, TICouncilorState councilor, bool betraysToFaction)
```

```csharp
public static void LogInvoluntaryCouncilorDismissal(TICouncilorState councilor, TIFactionState faction)
```

```csharp
public static void LogMyControlPointCrackedDown(TIControlPoint controlPoint, TIDateTime expiry, TIFactionState crackingFaction, float hate)
```

```csharp
public static void LogMyControlPointPurged(TIFactionState myFaction, TIFactionState takingFaction, TIControlPoint controlPoint, List<TIGameState> newControlPoints, List<TIGameState> oldControlPoints)
```

```csharp
public static void LogLoyaltySwitch(TIFactionState myFaction, TIFactionState oldFaction, TIControlPoint controlPoint, List<TIGameState> newControlPoints, List<TIGameState> oldControlPoints, TIMissionTemplate mission)
```

```csharp
public static void LogOurHabControlled(TIFactionState losingFaction, TIFactionState takingFaction, TIHabState hab)
```

```csharp
public static void LogDecommissionModuleComplete(TIHabModuleState module)
```

```csharp
public static void LogDecommissionHabComplete(TIHabState hab)
```

```csharp
public static void LogOurHabModuleDestroyed(TIHabModuleState module, TIFactionState responsibleFaction, float hate, bool displayResponsibleFaction, string nameOverride = "")
```

```csharp
public static void LogOurCriticalHabModuleDestroyed(TIHabModuleState module, TIFactionState responsibleFaction, float hate, bool displayResponsibleFaction)
```

```csharp
public static void LogOurHabDestroyed(TIHabState hab, TIFactionState destroyingFaction, TISpaceFleetState destroyingFleet)
```

```csharp
public static void LogOurShipChangedSides(TISpaceShipState ship, TIFactionState oldFaction, TIFactionState newFaction)
```

```csharp
public static void LogEnemyShipChangedSidesToUs(TISpaceShipState ship, TIFactionState oldFaction, TIFactionState newFaction)
```

```csharp
public static void LogMyHabAssaultInitiated(TIHabState hab, TIFactionState assaultingFaction)
```

```csharp
public static void LogNewCouncilorTurn()
```

```csharp
public static void LogEnemyCouncilorLocationDetected(TIFactionState detectingFaction, TICouncilorState detectedCouncilor)
```

```csharp
public static void LogAlienCouncilorDetected(TIFactionState detectingFaction, TICouncilorState detectedCouncilor)
```

```csharp
public static void LogMyCouncilorDetected(TIFactionState detectingFaction, TICouncilorState detectedCouncilor)
```

```csharp
public static void LogSpaceFacilityBombed(TIRegionSpaceFacilityState facilityState, TIFactionState responsibleParty, string newValue, float hate, int fightersDestroyed)
```

```csharp
public static void LogTechComplete(TIFactionState winningFaction, TITechTemplate techTemplate, int slot, bool cheat = false, string autoPick = "", string techTarget = "")
```

```csharp
public static void LogTechCompleteAndNewTechSelected(TIFactionState winningFaction, TITechTemplate oldTechTemplate, TITechTemplate newTechTemplate)
```

```csharp
public static void LogProjectTriggered(TIFactionState faction, TIProjectTemplate projectTemplate, bool special)
```

```csharp
public static void LogProjectComplete(TIFactionState faction, TIProjectTemplate projectTemplate, int slot, TIOrgState orgAwarded = null, string autoPick = "", string techTarget = "")
```

```csharp
public static void LogUniqueProjectCompleteByAnotherFaction(TIFactionState faction, TIProjectTemplate projectTemplate, IEnumerable<TIFactionState> factionsAlreadyNotified)
```

```csharp
public static void LogUniqueProjectSnipedByAnotherFaction(TIFactionState completingFaction, TIFactionState losingFaction, TIProjectTemplate project, int slot)
```

```csharp
public static void LogTechWinnerWarning(TIFactionState oldExpectedWinner, TIFactionState newExpectedWinner, int techSlotIndex)
```

```csharp
public static void LogFirstExecutiveControlPoint(TIControlPoint controlPoint)
```

```csharp
public static void LogControlPointAdded(TINationState nation, TIFactionState owner, TIControlPoint controlPoint, List<TIGameState> oldControlPointList)
```

```csharp
public static void LogControlPointReduction(TINationState nation, TIFactionState oldOwner, List<TIGameState> oldControlPointList)
```

```csharp
public static void LogRegimeChange(TINationState nation, TINationState instigatingNationState, List<TIGameState> oldControlPointList)
```

```csharp
public static void LogCoup(TINationState nationState, List<TIGameState> oldControlPointList, TIFactionState coupingFaction = null)
```

```csharp
public static void LogRevolution(TINationState nationState, List<TIGameState> oldControlPointList, bool looseNuke)
```

```csharp
public static void LogIndependence(TINationState newNation, TINationState oldNation)
```

```csharp
public static void LogNationGainsSpaceProgram(TINationState nation)
```

```csharp
public static void LogNationGainsNukes(TINationState nation)
```

```csharp
public static void LogNationGainsCoreEcoRegion(TINationState nation, TIRegionState region)
```

```csharp
public static void LogNationGainsCoreMineralRegion(TINationState nation, TIRegionState region)
```

```csharp
public static void LogNationGainsCoreOilRegion(TINationState nation, TIRegionState region)
```

```csharp
public static void LogDecolonizeComplete(TINationState nation, TIRegionState region)
```

```csharp
public static void LogDecontaminateComplete(TINationState nation, TIRegionState region)
```

```csharp
public static void LogLegitimizeClaimComplete(TIRegionState region)
```

```csharp
public static void LogMilitaryFounded(TINationState nation)
```

```csharp
public static void LogSTOFighterComplete(TINationState nation, TILaunchFacilityState site)
```

```csharp
public static void LogPolicyDeclined(TIPolicyOption policy, TINationState adoptingNation, TINationState targetNation)
```

```csharp
public static void LogPolicyAdopted(TIPolicyOption policy, TINationState adoptingNation, TIGameState target = null, TIGameState relatedGameState = null, int importance = 1, string overrideString = "", string overrideArt = "")
```

```csharp
public static void LogRegionChangesHands(TIRegionState region, TINationState oldNation, List<TIGameState> newNationOldControlPoints)
```

```csharp
public static void LogNationsCPPrioritiesReset(TIControlPoint controlPoint, PriorityType priority)
```

```csharp
public static void LogNationCompletesNuke(TINationState nation)
```

```csharp
public static void LogNationsGainClaims(Dictionary<TINationState, List<TIRegionState>> newClaims, TIFactionState excludeFaction)
```

```csharp
public static void LogMyArmyBadlyDamaged(TIArmyState army)
```

```csharp
public static void LogEnemyArmyJoinsBattle(TIArmyState arrivingEnemyArmy)
```

```csharp
public static void LogNationJoinsWar(TIWarState war, TINationState joiner)
```

```csharp
public static void LogArmyLaunchesTowardEnemyRegion(TIArmyState army, TIRegionState region)
```

```csharp
public static void LogArmyArrivesInRegion(TIArmyState army, TIRegionState region)
```

```csharp
public static void LogArmyTeleportedToLegalRegion(TIArmyState army, TIRegionState badRegion, TIRegionState newRegion)
```

```csharp
public static void LogArmyCompletesOperation(TIArmyState army, TIArmyOperationTemplate operation, TIGameState target, TIMissionOutcome outcome, string returnStr = "")
```

```csharp
public static void LogArmyCompletesOccupationOfRegion(TIArmyState army)
```

```csharp
public static void LogArmyBeginsAnnexation(TIArmyState army, TIDateTime endDate)
```

```csharp
public static void LogArmyCompletesAnnexation(TIArmyState army, TINationState oldNation)
```

```csharp
public static void LogArmyAnnexationCancelled(TINationState attemptingAnnexer, TIRegionState region)
```

```csharp
public static void LogArmyConquersNation(TIArmyState army, TINationState endingNation, TIRegionState oldCapital, List<TINationState> conqueringNations)
```

```csharp
public static void LogArmyAssignedToFaction(TIArmyState army, TIFactionState priorFaction)
```

```csharp
public static void LogNewArmyBuilt(TIArmyState army)
```

```csharp
public static void LogNewNavyBuilt(TIArmyState army)
```

```csharp
public static void LogSpaceDefensesComplete(TISpaceDefensesFacilityState defenses)
```

```csharp
public static void LogArmyIsDestroyed(TIArmyState army, TIRegionState location, TIFactionState attacker)
```

```csharp
public static void LogPactEnds(TIFactionState endingFaction, TIFactionState otherFaction, List<TradeOffer.TreatyType> treaties)
```

```csharp
public static void AlertNarrativeEvent(TIFactionState faction, TINarrativeEventTemplate eventTemplate, TIGameState target, TIGameState secondaryTarget = null, Dictionary<TIGameState, TIGameState> allTargetsAndSeconds = null)
```

```csharp
private static List<TIFactionState> GetFactionsToNotify(TIGameState actingState, TIGameState target, TIGameState secondaryState, PublicityType publicity)
```

```csharp
public static void LogNarrativeEventResolution(TIGameState actingState, TIGameState target, TIGameState secondaryState, TINarrativeEventTemplate eventTemplate, int optionSelected, int outcomeRolled, bool reportOutcome)
```

```csharp
public static void AddCouncilorMessage(TIGameState speaker, CouncilorChatType chatType, TIFactionState intendedFaction)
```

```csharp
public static CouncilorMessage GetNextCouncilorMessage()
```
