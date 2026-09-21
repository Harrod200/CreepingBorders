# TIArmyState

*Decompiled from `PavonisInteractive/TerraInvicta/TIArmyState.cs`.*


## Class `TIArmyState`

```csharp
public class TIArmyState : TIGameState, IOperationCapableState
```

### Fields

| Name | Type |
|---|---|
| `isArmyState` | public override bool |
| `searchable` | public override Searchable |
| `ref_faction` | public override TIFactionState |
| `ref_region` | public override TIRegionState |
| `ref_nation` | public override TINationState |
| `ref_spaceBody` | public override TISpaceBodyState |
| `ref_spaceObject` | public override TISpaceObjectState |
| `ref_naturalSpaceObject` | public override TINaturalSpaceObjectState |
| `ref_army` | public override TIArmyState |
| `ref_controlPoint` | public override TIControlPoint |
| `hasMapObject` | public override bool |
| `hasEarthMapObject` | public override bool |
| `ref_megafaunaArmyState` | public virtual TIMegafaunaArmyState |
| `ref_alienArmyState` | public virtual TIAlienArmyState |
| `template` | public TIArmyTemplate |
| `homeNation` | public virtual TINationState |
| `currentNation` | public TINationState |
| `techLevel` | public virtual float |
| `baseTechLevel` | private int |
| `InFriendlyRegion` | public virtual bool |
| `InLegalRegion` | public bool |
| `CanTakeOffensiveAction` | public virtual bool |
| `HumanArmy` | public virtual bool |
| `AlienMegafaunaArmy` | public virtual bool |
| `AlienRegularArmy` | public virtual bool |
| `techLevelSpeedModifier` | public float |
| `useHomeInvestmentFactor` | public bool |
| `investmentArmyFactor` | public virtual float |
| `investmentNavyFactor` | public virtual float |
| `atSea` | public bool |
| `IsMoving` | public bool |
| `dailyHealRate` | public virtual float |
| `ReachableRegions` | public IEnumerable<TIRegionState> |
| `ReachableRegions_Fast` | public IEnumerable<TIRegionState> |
| `EnterableRegions` | public IEnumerable<TIRegionState> |
| `finalDestination` | public TIRegionState |
| `displayNameWithArticleCapitalized` | public string |
| `displayNameWithNation` | public string |
| `displayNameWithNationAndArticle` | public string |
| `displayNameWithNationAndArticleCapitalized` | public string |
| `UseAttackingVisuals` | public bool |
| `GetIconForegroundResource` | public virtual string |
| `GetIconBackgroundSprite` | public Sprite |
| `GetIconBackgroundResource` | public string |
| `GetIconBackgroundResourceColor` | public Color |
| `AnimatorResource` | public virtual string |
| `FightingSpriteSheet` | public virtual string |
| `MovingSpriteSheet` | public virtual string |
| `illustration` | public virtual string |
| `LEOHabBonus` | public float |
| `adjustedTechLevel` | public virtual float |
| `combatEffectiveness` | public float |
| `FightingInFriendlyRegionBonus` | public float |
| `regionDamageScaling` | private float |
| `faction` | public TIFactionState |
| `homeRegion` | public TIRegionState |
| `priorRegion` | public TIRegionState |
| `deploymentType` | public DeploymentType |
| `strength` | public float |
| `controlPointIdx` | public int |
| `createdFromTemplate` | public bool |
| `currentOperations` | public List<OperationData> |
| `operationTarget` | public TIGameState |
| `destroyed` | public bool |
| `armyType` | public ArmyType |
| `gameStateSubjectCreated` | private bool |
| `displayNameWithArticle` | public string |
| `AI_targetEnemyRegion` | public TIRegionState |
| `baselineNavalFleetSpeed_kph` | public const float |
| `armyMovement_km_day` | public const float |
| `smallMovementPower` | public const float |
| `evenSplitMovementPower` | public const float |
| `largeMovementPower` | public const float |
| `enemyRegionBaseMultiplier` | public const float |
| `enemyRegionRuggedMultiplier` | public const float |
| `friendlyRegionRuggedMultipler` | public const float |
| `colonyRegionMultiplier` | public const float |
| `hostileToHostileMultiplier` | public const float |
| `normal_enemyRegion` | public static readonly float |
| `small_enemyRegion` | public static readonly float |
| `large_enemyRegion` | public static readonly float |
| `normal_enemyRegion_rugged` | public static readonly float |
| `small_enemyRegion_rugged` | public static readonly float |
| `large_enemyRegion_rugged` | public static readonly float |
| `normal_friendlyRegion_rugged` | public static readonly float |
| `small_friendlyRegion_rugged` | public static readonly float |
| `large_friendlyRegion_rugged` | public static readonly float |
| `normal_colonyRegion` | public static readonly float |
| `small_colonyRegion` | public static readonly float |
| `large_colonyRegion` | public static readonly float |
| `_isMoving` | private bool |
| `_isFighting` | private bool |
| `_lastIsFightingFrame` | private int |
| `cachedReachableRegions` | private HashSet<TIRegionState> |
| `reachableRegionsCachedFrame` | private int |
| `cachedReachableRegions_Fast` | private HashSet<TIRegionState> |
| `reachableRegionsCachedDate_Fast` | private TIDateTime |
| `cachedEnterableRegions` | private HashSet<TIRegionState> |
| `enterableRegionsCachedFrame` | private int |
| `cachedConnectedRegions` | private Dictionary<TIRegionState, ValueTuple<HashSet<TIRegionState>, int>> |
| `destinationQueue` | public List<TIRegionState> |
| `journeyHeuristic` | private static Dictionary<string, Dictionary<string, float>> |
| `journeyHeuristicThreads` | private static List<Thread> |
| `_finalDestination` | private TIRegionState |
| `_finalDestinationFrame` | private int |
| `_enemyArmiesInRegion` | private Dictionary<TIRegionState, IEnumerable<TIArmyState>> |
| `_enemyArmiesCacheFrame` | private int |
| `genericBackgroundColor` | private static readonly Color |
| `combatScaling` | public const float |
| `failureChanceAtBalance` | public const float |
| `lastEnemyArmy` | private TIArmyState |
| `battleScaling` | private const float |
| `occupationScaling` | private const float |
| `majorBattleChanceBase` | private const float |
| `majorArmyEngagementModifer` | private const float |
| `minorBattleModifier` | private const float |
| `majorBattleModifier` | private const float |
| `decisiveBattleModifier` | private const float |
| `maxOccupationChangePerArmyPerDay` | public const float |
| `LocalDefensesDamageReductionFactor` | private const int |

### Properties

- `public TIRegionState currentRegion`
- `public TIDateTime embarkDate`
- `public TIDateTime destinationSeaDate`
- `public bool huntingXenofauna`
- `public string armyDamageEventName`
- `public string armyStatusUpdateEventName`
- `public string armyOperationCompleteEventName`

### Methods

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
public override void PostAllStartUpInit_5()
```

```csharp
public void NewArmy(ArmyType armyType, int value = 0, float startingStrength = 1f)
```

```csharp
public void SetGameStateCreated()
```

```csharp
public void Disband()
```

```csharp
public virtual bool LegalRegion(TIRegionState region)
```

```csharp
public virtual bool IsAttacking()
```

```csharp
public virtual bool InBattleWithArmies()
```

```csharp
public virtual bool InBattleWithArmiesOrRegionDefenses()
```

```csharp
public virtual bool CanHeal()
```

```csharp
public static float baseSeaMovementSpeed_days(TIRegionState origin, TIRegionState destination, TIArmyState army, bool onlyConsiderDistance = false)
```

```csharp
public static float baseLandMovementSpeed_days(TIRegionState origin, TIRegionState destination, TIArmyState army, bool onlyConsiderDistance = false)
```

```csharp
public void SetIsMoving()
```

```csharp
public void SetNotMoving()
```

```csharp
public bool IsFighting(bool forceUpdate)
```

```csharp
public List<TIArmyState> GetEnemyArmiesInRegion()
```

```csharp
public bool FriendlyRegion(TIRegionState region)
```

```csharp
public bool OccupierInCurrentRegion()
```

```csharp
public bool FriendlyRegionIncludingFullyOccupied(TIRegionState region)
```

```csharp
public bool CanReduceOccupation()
```

```csharp
public virtual bool OccupyingRegion(bool includeLiberation = true)
```

```csharp
public bool InEnemyCapital()
```

```csharp
public float OccupationValue()
```

```csharp
public bool InBattleWithOtherArmiesAndWinningByALot()
```

```csharp
public static IList<TIRegionState> OneStepValidDestinationRegions(TIArmyState army, TIRegionState currentRegion, bool includeCurrentRegion)
```

```csharp
public static List<TIRegionState> AllValidDestinationRegions(TIArmyState army, TIRegionState currentRegion, bool includeCurrentRegion)
```

```csharp
public static DeploymentType GetRequiredDeploymentType(TIRegionState origin, TIRegionState destination, TIArmyState army = null)
```

```csharp
public static bool IsTraversible(TIRegionState origin, TIRegionState destination, out DeploymentType deploymentTypeRequired, TIArmyState army = null)
```

```csharp
public static bool IsTraversible(TIRegionState origin, TIRegionState destination, TIArmyState army = null)
```

```csharp
public bool CanEnter(TIRegionState destination)
```

```csharp
public static float GetDeploymentToAdjacentRegionDuration_Days(TIRegionState origin, TIRegionState destination, TIArmyState army = null)
```

```csharp
public float GetDeploymentToAdjacentRegionDuration_Days(TIRegionState destination)
```

```csharp
public static float GetAdmissableHeuristicOfJourneyDurationInDays(TIRegionState origin, TIRegionState destination, TIArmyState army = null)
```

```csharp
private static IEnumerable<TIRegionState> GetConnectedRegions(TIRegionState origin, TIArmyState army = null)
```

```csharp
public static List<TIRegionState> GetJourney(TIRegionState origin, TIRegionState destination, out float durationInDays, Func<TIRegionState, bool> IsRegionAllowed = null, TIArmyState army = null)
```

```csharp
public static List<TIRegionState> GetJourney(TIRegionState origin, TIRegionState destination, TIArmyState army = null)
```

```csharp
public List<TIRegionState> GetJourney(TIRegionState origin, TIRegionState destination, Func<TIRegionState, bool> ShouldAvoidRegion)
```

```csharp
public List<TIRegionState> GetJourney_AvoidEnemyRegions(TIRegionState origin, TIRegionState destination)
```

```csharp
public List<TIRegionState> GetJourney(TIRegionState origin, TIRegionState destination, out float durationInDays)
```

```csharp
public List<TIRegionState> GetJourney(TIRegionState origin, TIRegionState destination)
```

```csharp
public List<TIRegionState> GetJourney(TIRegionState destination)
```

```csharp
public static float GetJourneyDurationInDays(TIRegionState origin, TIRegionState destination, TIArmyState army = null)
```

```csharp
public float GetJourneyDurationInDays(TIRegionState destination)
```

```csharp
public bool CanGetTo(TIRegionState destination, Func<TIRegionState, bool> IsRegionAllowed = null, TIRegionState origin = null, Dictionary<TIRegionState, bool> canGetToCache = null)
```

```csharp
public bool CanGetTo(TIRegionState destination, bool doNotEnterEnemyRegions)
```

```csharp
public static void BakeJourneyHeuristic()
```

```csharp
public static void FinishBakingJourneyHeuristic()
```

```csharp
public void SetSeaTransitStages(TIDateTime startDate, TIDateTime completionDate, TIRegionState destinationRegion)
```

```csharp
public void CancelSeaTransit()
```

```csharp
public ArmySeaTransitStage SeaTransitStage()
```

```csharp
public static TIRegionState ScoreAndSelectRegion(TIArmyState army, List<TIRegionState> regions, AIArmyDestination destination)
```

```csharp
private IEnumerable<TIArmyState> EnemyArmiesInRegion(TIRegionState region)
```

```csharp
public static bool RegionMeetsDestinationCriteria(TIArmyState army, TIRegionState region, AIArmyDestination destinationType)
```

```csharp
public static TIRegionState FindArmyDestination(TIArmyState army, AIArmyDestination destinationType)
```

```csharp
public static TIRegionState GetArmyDestination(TIArmyState army, AIArmyDestination destinationType, int numAlternatesToConsider = 4)
```

```csharp
public virtual Sprite GetTransportIcon()
```

```csharp
public virtual Sprite GetForegroundIcon()
```

```csharp
public virtual string GetModelResource()
```

```csharp
public void SetArmyDataDirty()
```

```csharp
public void AssignToFaction(TIFactionState newCouncil, bool alienMegafaunaTakeover = false)
```

```csharp
public void AddNavy()
```

```csharp
public void Rename(string newName, string newNameWithArticle)
```

```csharp
public bool TakeDamage(float amount, TIFactionState attacker, TINationState attackingNation, bool allowReformingOfHumanArmies)
```

```csharp
public void HealDamage()
```

```csharp
public float AttemptRepair(float amountToAttempt)
```

```csharp
public void SetStrength(float value)
```

```csharp
public void MoveArmyToRegion(TIRegionState newRegion, bool newArmy = false)
```

```csharp
public void GoHome()
```

```csharp
public float GetEffectiveCombatStrength()
```

```csharp
public string CombatBreakdown_Army()
```

```csharp
public float GetAttackValue()
```

```csharp
public float GetEnemyDefendValue(TIArmyState defendingArmy)
```

```csharp
public float GetCombatSuccessChance(float attackValue, float enemyValue)
```

```csharp
public void FireAtEnemyArmy(TIArmyState defendingArmy)
```

```csharp
public static float LocalForcesAdjacentRegionsBonus(TIRegionState currentRegion)
```

```csharp
public float LocalForcesBaseDefenseLevel(bool modifyForCohesionAndUnrest, TINationState occupierWereFighting)
```

```csharp
public virtual void EngageLocalForcesAndOccupy(bool regionReturnFireOnly = false)
```

```csharp
public void CheckAndPromptIfInIllegalRegion(bool autoTeleport, bool justMadePeace)
```

```csharp
public bool TeleportArmyFromIllegalRegion()
```

```csharp
public List<IOperation> VisibleOperationList(TINaturalSpaceObjectState naturalSpaceObject = null)
```

```csharp
public List<IOperation> AvailableOperationList(TINaturalSpaceObjectState naturalSpaceObject = null)
```

```csharp
public List<IOperation> SubstantiveAvailableOperationList()
```

```csharp
private void UpdateIsMoving()
```

```csharp
public void RemoveOperation(OperationData data)
```

```csharp
public void ClearOperations()
```

```csharp
public List<OperationData> CurrentOperations()
```

```csharp
public TIMissionOutcome AssaultAlienAsset(TIRegionAlienAssetState alienAsset, TIMissionOutcome baseOutcome)
```

```csharp
public void OnTimedOperationComplete(TimeEventStart e)
```

```csharp
public string OperationDescription()
```

```csharp
public void SetHuntingXenofauna(bool setting)
```
