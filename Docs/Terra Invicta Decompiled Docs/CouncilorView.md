# CouncilorView

*Decompiled from `PavonisInteractive/TerraInvicta/CouncilorView.cs`.*


## Struct `CouncilorView`

```csharp
public struct CouncilorView
```

### Fields

| Name | Type |
|---|---|
| `isEnemy` | public bool |
| `playerCouncilAgent` | public bool |
| `agentForFaction` | public TIFactionState |
| `turned` | public bool |
| `detained` | public bool |
| `displayNameMemory` | public string |
| `displayNameMemorySentence` | public string |
| `displayNameCurrent` | public string |
| `displayNameCurrentSentence` | public string |
| `factionMemory` | public TIFactionState |
| `factionCurrent` | public TIFactionState |
| `factionIcon64Memory` | public string |
| `factionIcon128Memory` | public string |
| `factionIcon256Memory` | public string |
| `factionIcon64Current` | public string |
| `councilorActionIcon64CurrentSprite` | public Sprite |
| `councilorJobMemory` | public TICouncilorTypeTemplate |
| `councilorJobStringMemory` | public string |
| `councilorJobCurrent` | public TICouncilorTypeTemplate |
| `councilorJobStringCurrent` | public string |
| `mapIconResourcePathMemory` | public string |
| `mapIconResourcePathCurrent` | public string |
| `genericIconResourcePath` | public string |
| `portraitPath` | public string |
| `missionPhaseIllustrationData` | public CouncilorIllustrationData |
| `councilorAge` | public string |
| `councilorHomeTown` | public string |
| `isKnownAlien` | public bool |
| `associatedLocationString` | public string |
| `location` | public TIGameState |
| `associatedLocation` | public TIGameState |
| `HasMission` | public bool |
| `GetActiveMission` | public TIMissionState |
| `currentMissionResolveTime` | public string |
| `GetCompletedMission` | public TIMissionState |
| `currentMissionTemplate` | public TIMissionTemplate |
| `currentMissionTarget` | public TIGameState |
| `currentMissionDisplayName` | public string |
| `currentMissionTargetDisplayName` | public string |
| `orgs` | public List<TIOrgState> |
| `traits` | public List<TITraitTemplate> |
| `playerCouncil` | private readonly TIFactionState |
| `councilor` | public readonly TICouncilorState |

### Methods

```csharp
public CouncilorView(TICouncilorState councilor, TIFactionState playerCouncil)
```

```csharp
public string factionStringMemory(bool capitalize)
```

```csharp
public string factionStringCurrentKnowledge(bool capitalize, bool color = false)
```

```csharp
public float EstimateAttributeFromJob(TICouncilorState councilor, CouncilorAttribute attribute)
```

```csharp
public float GetAttribute(CouncilorAttribute attribute)
```

```csharp
public string GetAttributeString(CouncilorAttribute attribute)
```

```csharp
public List<TIMissionTemplate> GetMissionsList(TICouncilorState councilor)
```

```csharp
public string locationString(bool longform)
```

```csharp
public string GetActiveMissionIcon()
```

```csharp
public string GetCurrentMissionString(bool includeTarget = true, bool includeResolveTime = false, bool twoLineTarget = false)
```

```csharp
public bool GrantsMarkedToAssassin()
```

```csharp
public float EvaluateCouncilor()
```
