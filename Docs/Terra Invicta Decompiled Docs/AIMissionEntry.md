# AIMissionEntry

*Decompiled from `PavonisInteractive/TerraInvicta/Tasks/AIMissionEntry.cs`.*


## Class `AIMissionEntry`

```csharp
public class AIMissionEntry
```

### Fields

| Name | Type |
|---|---|
| `faction` | public TIFactionState |
| `estimatedFinalSuccessChance` | public float |
| `FailureIsOk` | public bool |
| `isTooRisky` | public bool |
| `extraCarefulAIDuration_years` | private const float |
| `councilor` | public TICouncilorState |
| `mission` | public TIMissionTemplate |
| `target` | public TIGameState |
| `sliderSteps` | public int |
| `payoff` | public float |
| `expectedUtility` | public float |
| `acceptableMinimumSuccess` | public float |
| `successChanceHigh` | public float |
| `successChanceLow` | public float |
| `finalSuccessChance` | public float |
| `objective` | public bool |
| `maxAffordableSliderSteps` | public int |
| `finalized` | public bool |

### Methods

```csharp
public AIMissionEntry(AICouncilorMissionPlanner planner, TIMissionTemplate mission_, TICouncilorState councilor_, TIGameState target_, float riskAversion, List<TIMissionTemplate> requiredMissions, List<TIMissionTemplate> missingRequiredMissions, bool objective_, float campaignDuration_years, List<CampaignMilestone> desiredMilestones, bool huntingForAlienActivity, float huntAbility, List<TIFactionState> warFactions, TIRegionState recentAlienSite, float timeSinceAlienSite_days, float availableResource, bool capturingNeutralNations, float basePayoff = -1f)
```

```csharp
public AIMissionEntry()
```
