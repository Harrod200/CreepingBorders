# TIMissionTemplate

*Decompiled from `TIMissionTemplate.cs`.*


## Class `TIMissionTemplate`

```csharp
public class TIMissionTemplate : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `primaryAttackerStat` | public CouncilorAttribute |
| `primaryResource` | public FactionResource |
| `ContestedMission` | public bool |
| `hasCost` | public bool |
| `UsesSlider` | public bool |
| `IsVictoryMission` | public bool |
| `description` | public string |
| `descriptionWithTiming` | public string |
| `missionIconImagePath_On` | public string |
| `missionIconImagePath_Off` | public string |
| `iconAnimationController` | public string |
| `pendingAnimation` | public string |
| `resolvingAnimation` | public string |
| `keyValues` | public string |
| `multiLineDescriptionWithModifiers` | public string |
| `baseMission` | public bool |
| `noise` | public float[] |
| `hate` | public float[] |
| `XPonSuccess` | public int |
| `resolutionOrder` | public int |
| `movementRule` | public MissionMovementRule |
| `resolutionMethod` | public TIMissionResolution |
| `attackerContexts` | public List<Context> |
| `defenderContexts` | public List<Context> |
| `targetEffects` | public List<TIMissionEffect> |
| `councilorEffects` | public List<TIMissionEffect> |
| `target` | public IMissionTarget |
| `conditions` | public List<TIMissionCondition> |
| `cost` | public TIMissionCost |
| `sortOrder` | public int |
| `missionContext` | public MissionContext |
| `persistentEffect` | public bool |
| `utilityScore` | public float |
| `AIDoubleUpAllowed` | public bool |
| `maximumTargetOptionCount` | public int |
| `specialPost` | public bool |
| `permanentAssignment` | public bool |
| `debugForced` | public bool |
| `knowledgeProject` | public string |
| `successSFX` | public string |
| `successSFXAlienSpecial` | public string |
| `UIalertEnemyOnFail` | public bool |
| `allowedForAutoDefense` | public bool |
| `_primaryAttackerStat` | private CouncilorAttribute |
| `_primaryAttackerStatSet` | private bool |
| `_primaryDefenderStat` | private CouncilorAttribute |
| `_primaryDefenderStatSet` | private bool |
| `missionIconImagePath` | public string |
| `completedIllustrationResource` | public List<string> |
| `targetingMethodType` | public Type |

### Methods

```csharp
public CouncilorAttribute primaryDefenderStat()
```

```csharp
public string CriticalSuccessText(params string[] args)
```

```csharp
public string SuccessText(params string[] args)
```

```csharp
public string FailureText(params string[] args)
```

```csharp
public string CriticalFailureText(params string[] args)
```

```csharp
public string GetCompletedIllustrationResource(TIGameState missionTarget, TIControlPoint targetControlPoint)
```

```csharp
public TIMissionTemplate(string name)
```

```csharp
public override TIGameState CreateGameState()
```

```csharp
public IList<TIGameState> GetValidTargets(TICouncilorState councilor)
```

```csharp
public bool CanAfford(TIFactionState faction, TICouncilorState councilor = null)
```

```csharp
public static string MissionTargetingList(TIFactionState faction, TIGameState target)
```

```csharp
public string MissionDetailText()
```
