# AIDailyFactionPlanner

*Decompiled from `PavonisInteractive/TerraInvicta/Tasks/AIDailyFactionPlanner.cs`.*


## Class `AIDailyFactionPlanner`

```csharp
public class AIDailyFactionPlanner : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `Every3DaysCap` | private const int |
| `Every4DaysCap` | private const int |
| `Every7DaysCap` | private const int |
| `Every14DaysCap` | private const int |
| `gameTime` | private GameTimeManager |
| `AIFactions` | private TIFactionState[] |
| `numAIFactions` | private int |
| `LEOs` | private List<TIOrbitState> |
| `factionAIData` | public static Dictionary<TIFactionState, StaticFactionAIData> |
| `maxTargets` | private static readonly Dictionary<SupraRegion, int> |
| `maxAcceptableTimeForSpaceBodyOperation_d` | public const int |
| `BuildSpaceAssetsBusy` | private bool |
| `orderedPrioritiesForSpares` | private readonly List<PriorityType> |
| `buildUpMilitaryGoals` | private readonly List<GoalType> |
| `NucConsiderationFrequency_days` | public const int |
| `PeacetimeArmyConsiderationFrequence_days` | public const int |
| `megaFaunaActionFrequency_days` | public const int |
| `fleetOperationsLive` | private bool |
| `isDesigningShips` | private static Dictionary<TIFactionState, bool> |
| `CouncilorOrgValue` | private struct |
| `councilor` | public TICouncilorState |
| `score` | public float |
| `OrgCouncilorScore` | private struct |
| `org` | public TIOrgState |
| `councilor` | public TICouncilorState |
| `score` | public float |
| `AIRelationshipChangeKey` | private struct |
| `nation` | public TINationState |
| `targetNation` | public TINationState |
| `change` | public RelationChange |
| `AIRelationshipChange` | private struct |
| `nation` | public TINationState |
| `targetNation` | public TINationState |
| `change` | public RelationChange |
| `score` | public float |
| `goalImportance` | public int |

### Properties

- `public static AIDailyFactionPlanner singleton`

### Methods

```csharp
private void Awake()
```

```csharp
public void Initialize()
```

```csharp
private void InitializeAILogging()
```

```csharp
private void LogHardwareSpecs()
```

```csharp
private void LogDumpString(string logString)
```

```csharp
private void SetGlobalStaticData()
```

```csharp
public static void InitializeAIForNewCampaign()
```

```csharp
public void IdleAIPlanning()
```

```csharp
private void PerformAITaskGroup(TIFactionState faction, bool early)
```

```csharp
private void PerformAITaskGroup(TIFactionState faction, AITaskCategory task)
```

```csharp
public void FactionOperations0000()
```

```csharp
public void FactionOperations(bool early)
```

```csharp
public IEnumerator FactionOperationsLoop(bool early)
```

```csharp
public void FactionOperations2300()
```

```csharp
private void AnalyzeDeficiencies_Human(TIFactionState faction, Dictionary<FactionResource, Dictionary<TIFactionState, float>> factionIncomes, float campaignDuration_years, bool useAltMethod = true)
```

```csharp
public void AnalyzeDeficiences_Alien(TIFactionState faction, Dictionary<FactionResource, Dictionary<TIFactionState, float>> factionIncomes, float campaignDuration_years)
```

```csharp
private void KillAnyAlienShipForObjective(TIFactionState faction, TIObjectiveTemplate objective, int maxRelatedAttackGoals)
```

```csharp
private void ManageObjectiveGoals(TIFactionState faction)
```

```csharp
public static float GetMonthlyAlienHateGain(TIFactionState humanFaction, bool isMostThreateningHumanEnemy, bool isStrongestHumanFaction, float miscModifier = 1f, float campaignDuration_years = -1f, int difficulty = -1)
```

```csharp
public static float GetExpectedYearsUntilWarWithAliens(TIFactionTemplate humanFaction, int difficulty, float extraHateLossPerMonth = 0f, float extraHate = 0f)
```

```csharp
public static float JealousyAndDeescalation(TIFactionState faction, TIFactionState enemyFaction, bool generalDeescalation, bool processPeriodicChange)
```

```csharp
private void ManageWarsWithFaction(TIFactionState faction)
```

```csharp
public static void SetInitialFactionNationTargets()
```

```csharp
public static void ManagePriorityNationControlGoalsForFaction(TIFactionState faction)
```

```csharp
public static void DisableOwnNations(TIFactionState faction, Dictionary<TIControlPoint, float> controlPointValues)
```

```csharp
public static void ConsiderNuclearAttack(TINationState nation, TINationState nationNukingUs = null, bool nationNukingOurInvadingArmies = false)
```

```csharp
public static bool ExpectNukeLaunch(int situation, TINationState nationWithNukes, TINationState targetNation)
```

```csharp
public static void ManageFleetGoals(TIFactionState faction)
```

```csharp
private void ManageFleets(TIFactionState faction)
```

```csharp
public static void ResolveGoals(TIFactionState faction)
```

```csharp
private void ReviewAndSetGoals(TIFactionState faction)
```

```csharp
private static void DismissCouncilors(TIFactionState faction, List<TIMissionTemplate> missingRequiredMissions, ref Dictionary<TICouncilorState, Dictionary<FactionResource, float>> councilorIncomes)
```

```csharp
public static bool AI_ControllingNeutralPowers(TIFactionState faction)
```

```csharp
public static void RecruitCouncilors(TIFactionState faction, List<TIMissionTemplate> requiredMissions, List<TIMissionTemplate> missingRequiredMissions, ref Dictionary<TICouncilorState, Dictionary<FactionResource, float>> councilorIncomes, bool chasingHydra, int factionWars, bool controllingNeutralPowers)
```

```csharp
private static bool TryAddOrgToCouncilor(AIDailyFactionPlanner.OrgCouncilorScore orgCandidate, List<TIMissionTemplate> possibleMissions, List<TIMissionTemplate> requiredMissions, List<TIMissionTemplate> missingRequiredMissions, out bool removeOrg, out bool removeCouncilor, Dictionary<FactionResource, float> councilorIncomes, bool chasingHydra, int factionWars, bool chasingNeutralPowers)
```

```csharp
private static void PurchaseOrgs(TIFactionState faction, Dictionary<TIOrgState, TICouncilorState> missionCriticalTransfers, List<TIMissionTemplate> requiredMissions, List<TIMissionTemplate> missingRequiredMissions, ref Dictionary<TICouncilorState, Dictionary<FactionResource, float>> councilorIncomes, bool chasingHydra, int factionWars, bool controllingNeutralPowers, List<TICouncilorState> criticalAdminNeed)
```

```csharp
private static void TransferOrgsToPool(TIFactionState faction)
```

```csharp
public static void TransferOrgsFromPool(TIFactionState faction)
```

```csharp
public static void TransferOrgsFromPool(TIFactionState faction, Dictionary<TIOrgState, TICouncilorState> missionCriticalTransfers, List<TIMissionTemplate> requiredMissions, List<TIMissionTemplate> missingRequiredMissions, ref Dictionary<TICouncilorState, Dictionary<FactionResource, float>> councilorIncomes, bool chasingHydra, int factionWars, bool controllingNeutralPowers)
```

```csharp
public static void SellOrgs(TIFactionState faction, List<TIMissionTemplate> requiredMissions, int requiredToSell = 0)
```

```csharp
public static void SpendXP(TIFactionState faction, List<TIMissionTemplate> requiredMissions, List<TIMissionTemplate> missingRequiredMissions, ref Dictionary<TICouncilorState, Dictionary<FactionResource, float>> councilorIncomes, bool chasingHydra, int factionWars, bool controllingNeutralPowers)
```

```csharp
private static void ManageCouncilors(TIFactionState faction, GameTimeManager gameTime)
```

```csharp
private void SetResearchPriorities(TIFactionState faction)
```

```csharp
private void FocusCompetitionTechs(TIFactionState faction)
```

```csharp
private void AliensCheckGoals(TIFactionState aliens)
```

```csharp
private static void CreateAlienBaseFoundingGoal(TISpaceBodyState system, int importance)
```

```csharp
private void CheckTriggerInnerSystemOffensives(TIFactionState aliens)
```

```csharp
public static void LaunchDeployArmyOperation(TIArmyState army, TIGameState destination)
```

```csharp
public static void LaunchOperation(TIGameState actorState, IOperation operation, TIGameState target, TIResourcesCost cost = null)
```

```csharp
private void BuildSpaceAssets(TIFactionState faction)
```

```csharp
private static void ProspectSites(TIFactionState faction)
```

```csharp
private IEnumerator BuildSpaceAssetsCo(TIFactionState faction)
```

```csharp
public static int AdjustShipyardQueue(TIFactionState faction, ShipConstructionQueueItem item)
```

```csharp
private static void CheckSellResourcesOnEarth(TIFactionState faction)
```

```csharp
public static void ManageAlliancesAndRivalries(TIFactionState faction)
```

```csharp
private void ManageNations(TIFactionState faction)
```

```csharp
public void AttemptFundPriority(TIFactionState faction, TINationState nation, PriorityType priority, ref Dictionary<FactionResource, float> resourcesAvailable)
```

```csharp
private void ArmyOperations(TIFactionState faction)
```

```csharp
public static double SelectTrajectoryAsync(IMobileAsset fleet, TIGameState destination, float desiredReserveDVFraction, out TransferResult result, Action<Trajectory> callback, bool mayUseReserveDV = false, double sampleSizeMultiplier = 1.0)
```

```csharp
public static bool SingleFleetOperation(TISpaceFleetState fleet, bool allowRecursiveCalls = true)
```

```csharp
private IEnumerator PeriodicFleetOperations(TIFactionState faction)
```

```csharp
public static void DesignShips(TIFactionState faction, Action Callback = null)
```

```csharp
public static IEnumerator DesignShipsCoroutine(TIFactionState faction, Action Callback)
```

```csharp
public static Dictionary<TINationState, PlannedFighters> DetermineSTOFighterPlan(TIFactionState faction, IEnumerable<TISpaceFleetState> fleets, TIHabState hab, bool isReinforcement, bool assessmentOnly)
```

```csharp
public static void AIReaction(AIReactionEvent reactionEvent, TIGameState relevantState1 = null, TIGameState relevantState2 = null)
```

```csharp
public AIRelationshipChange(TINationState nation, TINationState target, RelationChange change, float score, int goalImportance)
```

```csharp
public AIDailyFactionPlanner.AIRelationshipChangeKey GetKey()
```
