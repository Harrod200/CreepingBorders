# AICouncilorMissionPlanner

*Decompiled from `PavonisInteractive/TerraInvicta/Tasks/AICouncilorMissionPlanner.cs`.*


## Class `AICouncilorMissionPlanner`

```csharp
public class AICouncilorMissionPlanner : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `runner` | private readonly IPlayerActionRunner |
| `warFactions` | private List<TIFactionState> |
| `factionDesiredMilestones` | private List<CampaignMilestone> |
| `councilorMissionDictionary` | private Dictionary<AIMissionEntry, float> |
| `rawControlPointPayoffs` | private Dictionary<TIFactionState, Dictionary<TIControlPoint, float>> |
| `controlPointPayoffs` | private Dictionary<TIControlPoint, float> |
| `rawNationPayoffs` | private Dictionary<TIFactionState, Dictionary<TINationState, float>> |
| `nationPayoffs` | private Dictionary<TINationState, float> |
| `nationModifyingGoals` | private Dictionary<TINationState, List<TIFactionGoalState>> |
| `nationModifyingGoalsByFaction` | private Dictionary<TIFactionState, List<TIFactionGoalState>> |
| `factionMissionModifyingGoals` | private Dictionary<TIFactionState, List<TIFactionGoalState>> |
| `recentAlienSite` | private TIRegionState |
| `timeSinceAlienSite_days` | private float |
| `recentAlienControlPointGift` | private TINationState |
| `timeSinceAlienControlPointGift_days` | private float |
| `availableResources` | private Dictionary<FactionResource, float> |
| `huntingForAlienActivity` | private bool |
| `huntAbility` | private float |
| `lastFactionPayoffValuesRecorded` | private TIFactionState |
| `predictability_favoritesCount` | public const int |
| `predictability` | public const float |
| `favoritesThreshold` | public const float |
| `favoritesMultiplier` | public const float |
| `predictabilityPower` | public const float |
| `focusGoalPolicyMultiplier` | private const int |
| `focusGoalMissionMultiplier` | private const int |
| `cachedPayoffFrame` | public static int |
| `cameraManager` | private CameraManager |
| `AISmoothing` | private bool |
| `SmoothingMSPerFrame` | private int |
| `factionMissionDictionary` | private Dictionary<AICachedMissionEntry, float> |
| `averageControlPointValue_Dominate` | private static float |
| `cpCapFraction_Dominate` | private static float |
| `CPCountForNoAttacksWithoutGoal` | private const int |
| `scoredPolicyOptions` | private Dictionary<PolicyOptionWithTarget, float> |
| `campaignDuration_years` | public static float |

### Properties

- `public static AICouncilorMissionPlanner singleton`

### Methods

```csharp
private void Awake()
```

```csharp
public void Initialize()
```

```csharp
public float GetPayoffForMissionTarget(TIFactionState faction, TIMissionTemplate mission, TICouncilorState councilor, TIGameState target, List<TIMissionTemplate> requiredMissions, List<TIMissionTemplate> missingRequiredMissions, TIFactionGoalState focusGoal, List<CampaignMilestone> factionDesiredMilestones, float campaignDuration_years, bool huntingForAlienActivity, float huntAbility, List<TIFactionState> warFactions, TIRegionState recentAlienSite, float timeSinceAlienSite_days, bool capturingNeutralNations)
```

```csharp
public float GetGoalMultipliers(TIFactionState faction, TIMissionTemplate mission, TIGameState target, TIFactionGoalState focusGoal)
```

```csharp
public static float GetPayoffForMissionTarget_Individual(TIFactionState faction, TIMissionTemplate mission, TICouncilorState councilor, TIGameState target, List<TIMissionTemplate> requiredMissions, List<TIMissionTemplate> missingRequiredMissions, Dictionary<TINationState, float> nationPayoffs, bool huntingForAlienActivity, float huntAbility, List<TIFactionState> warFactions, TIRegionState recentAlienSite, float timeSinceAlienSite_days, TINationState recentAlienControlPointGift, float timeSinceAlienControlPointGift_days, bool capturingNeutralNations)
```

```csharp
public static float GetPayoffForMissionTarget_Faction(TIFactionState faction, TIMissionTemplate mission, TIGameState target, List<CampaignMilestone> factionDesiredMilestones, Dictionary<TIControlPoint, float> rawControlPointPayoffs, Dictionary<TIControlPoint, float> controlPointPayoffs, Dictionary<TINationState, float> rawNationPayoffs, Dictionary<TINationState, float> nationPayoffs, float campaignDuration_years)
```

```csharp
public float NationPayoff_Current(TIFactionState faction, TINationState nation)
```

```csharp
public static float AbductionsPayoff(TIRegionState region)
```

```csharp
public static float AdvisePayoff(TICouncilorState councilor, TIGameState target)
```

```csharp
public static float AssassinatePayoff(TIFactionState actingFaction, TICouncilorState targetCouncilor, List<CampaignMilestone> factionDesiredMilestones)
```

```csharp
public static float AssaultAlienAssetPayoff(TIFactionState faction, TIRegionAlienAssetState asset, List<CampaignMilestone> factionDesiredMilestones)
```

```csharp
public static float TransferControlPayoff(TIFactionState faction, TINationState nation, float nationPayoff)
```

```csharp
public static float BuildFacilityPayoff(TIFactionState faction, TIRegionState region)
```

```csharp
public static float EnthrallUnalignedElitesPayoff(TIFactionState faction, TIControlPoint CP, Dictionary<TIControlPoint, float> controlPointPayoffs, float campaignDuration_years)
```

```csharp
public static float ControlNationPayoff(TIFactionState faction, TIControlPoint CP, Dictionary<TIControlPoint, float> controlPointPayoffs, float campaignDuration_years)
```

```csharp
public static float DominatePayoff(TIFactionState faction, TINationState nation, Dictionary<TIControlPoint, float> controlPointPayoffs)
```

```csharp
public static float CoupPayoff(TIFactionState faction, TINationState nation, float rawNationPayoff)
```

```csharp
public static float CrackdownPayoff(TIFactionState faction, TIControlPoint controlPoint, float controlPointPayoff)
```

```csharp
public static float DefendInterestsPayoff(TIFactionState faction, TIGameState target, Dictionary<TIControlPoint, float> rawControlPointPayoffs)
```

```csharp
public static float DetainCouncilorPayoff(TIFactionState faction, TICouncilorState targetCouncilor, List<CampaignMilestone> factionDesiredMilestones)
```

```csharp
public static float DeorbitPayoff(TICouncilorState councilor)
```

```csharp
public static float ContactCouncilorPayoff(TIFactionState faction, TIFactionState targetFaction)
```

```csharp
public static float DetectCouncilActivityPayoff(TIFactionState faction, TICouncilorState councilor, TIGameState target, bool huntingForAlienActivity, float huntAbility, List<TIFactionState> warFactions, TIRegionState recentAlienSite, float timeSinceAlienSite_days, TINationState recentAlienControlPointGift, float timeSinceAlienControlPointGift_days, Dictionary<TINationState, float> nationPayoffs)
```

```csharp
private static float ScoreRegionForAlienSearch(TIFactionState faction, TIRegionState region, TIRegionState recentAlienSite, float timeSinceAlienSite_days, TINationState recentAlienControlPointGift, float timeSinceAlienControlPointGift_days)
```

```csharp
private TIRegionState BestRegionForAlienSearch(TICouncilorState councilor, List<TIRegionState> candidateRegions)
```

```csharp
public static float GoToGroundPayoff(TICouncilorState councilor, TIRegionState region)
```

```csharp
public static float HostileTakeoverPayoff(TICouncilorState councilor, TIOrgState targetOrg, List<TIMissionTemplate> requiredMissions, List<TIMissionTemplate> missingRequiredMissions, bool chasingNeutralNations)
```

```csharp
public static float IncreaseUnrestPayoff(TIFactionState faction, TIRegionState region, TINationState nation, float rawNationPayoff)
```

```csharp
public static float InspirePayoff(TIFactionState faction, TICouncilorState targetCouncilor)
```

```csharp
public static float InvestigateAlienActivityPayoff(TIFactionState faction)
```

```csharp
public static float InvestigateCouncilorPayoff(TIFactionState investigatingFaction, TICouncilorState targetCouncilor)
```

```csharp
public static float ProtectMissionPayoff(TICouncilorState protector, TIGameState target)
```

```csharp
public static float EnthrallPublicPayoff(TIFactionState faction, TIRegionState region, float nationPayoff)
```

```csharp
public static float PublicOpinionShiftPayoff(TIFactionState faction, TINationState nation, float nationPayoff)
```

```csharp
public static float ExtractPayoff(TIFactionState faction, TICouncilorState detainedCouncilor)
```

```csharp
public static float EnthrallFactionElitesPayoff(TIFactionState faction, TIControlPoint controlPoint, float rawControlPointPayoff)
```

```csharp
public static float PurgePayoff(TIFactionState faction, TIControlPoint controlPoint, float controlPointPayoff)
```

```csharp
public static float SabotageProjectPayoff(TIFactionState faction, TIFactionState targetFaction)
```

```csharp
public static float PassTechnologyPayoff(TIFactionState faction, TIFactionState targetFaction)
```

```csharp
public static float SabotageSpaceFacilitiesPayoff(TIFactionState faction, TIRegionSpaceFacilityState targetFacility)
```

```csharp
public static float SeizeAssetPayoff(TIFactionState faction, TIGameState target)
```

```csharp
public static float StabilizePayoff(TIFactionState faction, TINationState nation, float rawNationPayoff)
```

```csharp
public static float StealProjectPayoff(TIFactionState faction, TIFactionState targetFaction)
```

```csharp
public static float TerrorizePayoff(TIFactionState faction, TIRegionState targetRegion, Dictionary<TIControlPoint, float> rawControlPointPayoffs)
```

```csharp
public static float TurnCouncilorPayoff(TIFactionState faction, TICouncilorState targetCouncilor)
```

```csharp
public static float XenoformingPayoff(TIFactionState faction, TIRegionState region)
```

```csharp
public void SetRawNationPayoffsByFaction(TIFactionState faction, bool force)
```

```csharp
public void SetPayoffValues(TIFactionState faction, bool forceRecalculation)
```

```csharp
private int SetIdealSpendForMission(AIMissionEntry missionEntry, int missionsWithSameResource)
```

```csharp
public void AddScoredPolicyOption(PolicyOptionWithTarget policyOption, float score)
```

```csharp
public static float ScorePolicyOption(PolicyOptionWithTarget policyOption, TIFactionState faction, int importance, Dictionary<TINationState, Dictionary<PolicyType, int>> targetNationPolicies, Dictionary<TINationState, float> nationPayoffs)
```

```csharp
public void ModifyScoredPolicyOptionForCoordinatedMissions(AIMissionEntry selectedEntry, List<TICouncilorState> availableCouncilors, ref Dictionary<AIMissionEntry, float> missionDictionary)
```

```csharp
public static IEnumerable<ValueTuple<TICouncilorState, float>> FilterCouncilorsForPossibleAlien(IEnumerable<TICouncilorState> suspects, TICouncilorState exampleCouncilor, TIMissionTemplate exampleMission)
```

```csharp
public List<TIGameState> GetHuntListForAliens(TIFactionState faction, List<TICouncilorState> candidateCouncilors, TIMissionTemplate objectiveMission, bool alwaysHunt, List<TICouncilorState> alreadyTargetedCouncilors, TINationState recentAlienControlPointGift, float timeSinceAlienControlPointGift_days)
```

```csharp
public void MissionPhasePrepCoroutine(TIFactionState faction)
```

```csharp
public void PlanMissionsCoroutine(TIFactionState faction)
```

```csharp
protected IEnumerator MissionPhasePrep(TIFactionState faction)
```

```csharp
protected IEnumerator PlanMissions(TIFactionState faction)
```

```csharp
protected AICouncilorMissionPlan PlanMissionsTask(TIFactionState faction)
```

```csharp
public void RunSelectedPlayerActions(AICouncilorMissionPlan plan)
```

```csharp
public void SelectMission(AIMissionEntry selectedEntry, ref List<AIMissionEntry> selectedMissions, ref List<TICouncilorState> availableCouncilors)
```
