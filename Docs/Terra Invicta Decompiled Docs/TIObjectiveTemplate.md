# TIObjectiveTemplate

*Decompiled from `TIObjectiveTemplate.cs`.*


## Class `TIObjectiveTemplate`

```csharp
public class TIObjectiveTemplate : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `grantsResources` | public bool |
| `factions` | public List<TIFactionState> |
| `unlockingObjectives` | public List<TIObjectiveTemplate> |
| `targetProjectTemplate` | public TIProjectTemplate |
| `targetTechTemplate` | public TITechTemplate |
| `targetMissionTemplate` | public TIMissionTemplate |
| `targetHabModuleTemplate` | public TIHabModuleTemplate |
| `targetHabLocationState` | public TIGameState |
| `objectiveType` | public ObjectiveType |
| `factionDataNames` | public List<string> |
| `starter` | public bool |
| `unlockingObjectivesConjunction` | public Conjunction |
| `unlockingObjectiveNames` | public List<string> |
| `targetMissionTemplateName` | public string |
| `targetMissionTarget` | public ObjectiveMissionTargetType |
| `targetProjectTemplateName` | public string |
| `targetTechTemplateName` | public string |
| `targetMilestone` | public CampaignMilestone |
| `targetHabModuleName` | public string |
| `targetHabLocation` | public string |
| `targetCount` | public int |
| `resourcesGranted` | public ResourceValue[] |
| `AIValuesIndex` | public int |
| `setsWinConditionForFaction` | public bool |
| `assignedIllustrationResource` | public string |
| `completedIllustrationResource` | public string |
| `completedVoicePathAppease` | public string |
| `completedVoicePathCooperate` | public string |
| `completedVoicePathDestroy` | public string |
| `completedVoicePathEscape` | public string |
| `completedVoicePathExploit` | public string |
| `completedVoicePathResist` | public string |
| `completedVoicePathSubmit` | public string |
| `completedVoicePathAlien` | public string |
| `completedVoicePathMod1` | public string |
| `completedVoicePathMod2` | public string |
| `completedVoicePathMod3` | public string |
| `completedVoicePathMod4` | public string |
| `completedVoicePathMod5` | public string |
| `completedVoicePathMod6` | public string |
| `completedVoicePathMod7` | public string |
| `completedVoicePathMod8` | public string |
| `isChildObjective` | public bool |
| `_factions` | private List<TIFactionState> |

### Methods

```csharp
public new string displayName(TIFactionState faction)
```

```csharp
public string description(TIFactionState faction)
```

```csharp
public string solution(TIFactionState faction)
```

```csharp
public string solutionUnresolved(TIFactionState faction)
```

```csharp
public string resolution(TIFactionState faction)
```

```csharp
public string fullDescription(TIFactionState faction, bool unresolvedSolution = false)
```

```csharp
public string fullParentMilestoneDescription(TIFactionState faction)
```

```csharp
public string milestoneDescription(TIFactionState faction)
```

```csharp
public string VictorySummary(TIFactionState faction)
```

```csharp
public static string ParseObjectiveTags(TIFactionState faction, string inputString)
```

```csharp
public string NeededTechsAndProjects(TIFactionState faction)
```

```csharp
public ObjectiveStatus GetObjectiveStatus(TIFactionState faction)
```

```csharp
public bool IsObjectiveComplete(TIFactionState faction)
```

```csharp
public bool passedUnlockingObjectives(TIFactionState faction)
```

```csharp
public bool ValidObjectiveTarget(TIGameState candidate, TIFactionState faction)
```

```csharp
public List<TIGameState> ValidObjectiveTargets(List<TIGameState> candidateList, TIFactionState faction)
```

```csharp
public static bool IsTutorialMilestone(CampaignMilestone milestone)
```

```csharp
public static bool MilestoneRequiresDeadHydraAccess(CampaignMilestone milestone)
```

```csharp
public static bool MilestoneRequiresLiveAlienAccess(CampaignMilestone milestone)
```

```csharp
public static bool SuppressMilestoneReporting(CampaignMilestone milestone)
```

```csharp
public static bool HasChildMilestone(TIFactionState faction, TIObjectiveTemplate objective)
```

```csharp
public List<TIObjectiveTemplate> GetChildMilestones(TIFactionState faction, TIObjectiveTemplate objective)
```
