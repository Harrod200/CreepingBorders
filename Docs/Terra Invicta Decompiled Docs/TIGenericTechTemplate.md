# TIGenericTechTemplate

*Decompiled from `TIGenericTechTemplate.cs`.*


## Class `TIGenericTechTemplate`

```csharp
public abstract class TIGenericTechTemplate : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `categoryString` | public string |
| `categoryDescription` | public string |
| `description` | protected virtual string |
| `descriptionPath` | protected string |
| `summary` | public virtual string |
| `IconResource` | public string |
| `GetVoiceoverPath` | public string |
| `ref_tech` | public virtual TITechTemplate |
| `ref_project` | public virtual TIProjectTemplate |
| `noPrereqs` | public bool |
| `Effects` | public List<TIEffectTemplate> |
| `TechPrereqs` | public List<TIGenericTechTemplate> |
| `AltTechPrereq0` | public TIGenericTechTemplate |
| `AltTechPrereq1` | public TIGenericTechTemplate |
| `techCategory` | public TechCategory |
| `AI_techRole` | public TechRole |
| `AI_criticalTech` | public bool |
| `prereqs` | public List<string> |
| `altPrereq0` | public string |
| `altPrereq1` | public string |
| `researchCost` | public float |
| `effects` | public List<string> |
| `requiredMilestone` | public CampaignMilestone |
| `iconResource` | public string |
| `completedIllustrationPath` | public string |
| `voiceoverPath` | public string |
| `_allPrereqFor` | private List<TIGenericTechTemplate> |
| `cachedTechPrereqs` | private List<TIGenericTechTemplate> |
| `cachedAltTechPrereq0` | private TIGenericTechTemplate |
| `cachedAltPrereq0` | private bool |
| `cachedAltTechPrereq1` | private TIGenericTechTemplate |
| `cachedAltPrereq1` | private bool |

### Methods

```csharp
public string GetCategoryIconPath()
```

```csharp
protected virtual string filteredDescription(TechBenefitsContext context)
```

```csharp
public static string GetTechCategoryString(TechCategory category)
```

```csharp
public static string GetTechCategoryDescription(TechCategory category)
```

```csharp
public virtual string BenefitsDescription(TIFactionState faction, TechBenefitsContext benefitsContext, TIOrgState newOrg = null)
```

```csharp
public virtual string WarningsDescription(TIFactionState faction, TechBenefitsContext context)
```

```csharp
public abstract string GetCompletedIllustrationPath()
```

```csharp
public abstract bool isGlobalTech()
```

```csharp
public abstract bool isProject()
```

```csharp
public virtual bool ShouldHide(TIFactionState faction)
```

```csharp
public void CachePrereqs()
```

```csharp
public string GetFullDescription(TIFactionState faction, TechBenefitsContext context, TIOrgState newOrg = null, bool truncatedDescriptions = false)
```

```csharp
public static string PathTechCategoryIcon(TechCategory category)
```

```csharp
public static string categoryInlineSprite(TechCategory category)
```

```csharp
public abstract float GetResearchCost(TIFactionState faction)
```

```csharp
public string UnlockableTechString(TIFactionState faction, TechBenefitsContext benefitsContext)
```

```csharp
public static string GetUnlockChanceString(TIProjectTemplate project, TIFactionState faction)
```

```csharp
public List<TITechTemplate> UniqueGlobalTechUnlocks(TIFactionState faction)
```

```csharp
public List<TIProjectTemplate> UniqueProjectUnlocks(TIFactionState faction)
```

```csharp
public List<TIGenericTechTemplate> CompletionWillUnlock(TIFactionState faction)
```

```csharp
public IEnumerable<TIGenericTechTemplate> GetAllDescendents()
```

```csharp
public IEnumerable<TIGenericTechTemplate> GetAllLockedDescendents(TIFactionState faction)
```

```csharp
public bool LeadsToObjectiveProjects(TIFactionState faction)
```

```csharp
public List<TIGenericTechTemplate> AllPrereqFor(TIFactionState filterFaction, bool filterUnknownXenoProjects)
```

```csharp
public string PrereqForStr_Archive(TIFactionState faction, bool withholdDirectUnlocks)
```

```csharp
public bool IsAnAltPrereqOf(TIGenericTechTemplate techToCheck)
```

```csharp
public abstract bool IsEverAvailableToFaction(TIFactionState faction)
```

```csharp
protected List<TIDataTemplate> CodexUnlocks()
```

```csharp
public bool SpaceExplorationTech()
```
