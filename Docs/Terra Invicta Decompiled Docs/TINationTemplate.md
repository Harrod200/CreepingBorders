# TINationTemplate

*Decompiled from `TINationTemplate.cs`.*


## Class `TINationTemplate`

```csharp
public class TINationTemplate : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `UIColor` | public Color |
| `displayName` | public override string |
| `displayNameWithArticle` | public string |
| `nationAdjective` | public string |
| `unionDisplayName` | public string |
| `unionDisplayNameWithArticle` | public string |
| `unionAdjective` | public string |
| `displayNameWithArticleAndPlacePrep` | public string |
| `unionDisplayNameWithArticleAndPlacePrep` | public string |
| `initialFaction` | public TIFactionState |
| `color` | public Color |
| `unionTrigger` | public int |
| `aggregateNation` | public bool |
| `flagResource` | public string |
| `unionFlagResource` | public string |
| `popGrowthModifier` | public float |
| `greenEconomy` | public float |
| `initialGDP` | public double? |
| `cohesion` | public float? |
| `unrest` | public float? |
| `inequality` | public float? |
| `democracy` | public float? |
| `education` | public float? |
| `spaceProgram` | public string |
| `spaceFunding_year` | public float? |
| `miltech` | public float? |
| `nuclearWeapons` | public float? |
| `foundMilitaryIPs` | public float? |
| `initSpaceIPs` | public float? |
| `nuclearProgramIPs` | public float? |
| `buildNukeIPs` | public float? |
| `buildArmyIPs` | public float? |
| `buildNavyIPs` | public float? |
| `initialPriorityPreset` | public string[] |
| `tankSeries` | public string[] |
| `initialFactionStr` | public string |
| `yearofHighestGDP` | public int? |
| `highestPerCapitaGDP` | public float |
| `ISOCodes` | public List<string> |
| `solarBody` | public string |
| `group` | public int |
| `_dName` | private string |

### Methods

```csharp
public override TIGameState CreateGameState()
```

```csharp
public string startUpDisplayName()
```

```csharp
public string startUpUnionDisplayName()
```

```csharp
public bool IsStartingUnion(List<TINationTemplate> nationsInScenario, List<string> completedProjectsInScenario)
```

```csharp
public int StartingClaims(List<TINationTemplate> nationsInScenario, List<string> completedProjectsInScenario, bool countLockedClaims)
```

```csharp
public string GetUnionFlagResource()
```

```csharp
public TIPriorityPresetTemplate priorityPreset(int index)
```
