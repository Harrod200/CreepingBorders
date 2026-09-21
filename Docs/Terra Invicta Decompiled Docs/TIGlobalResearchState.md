# TIGlobalResearchState

*Decompiled from `PavonisInteractive/TerraInvicta/TIGlobalResearchState.cs`.*


## Class `TIGlobalResearchState`

```csharp
public class TIGlobalResearchState : TIGameState, IGameStateVisualizer
```

### Fields

| Name | Type |
|---|---|
| `UseHarshTechTree` | public static bool |
| `globalResearch` | public static TIGlobalResearchState |
| `MostRecentlyFinishedTech` | public static TITechTemplate |
| `UnlockedTechs` | public static List<TITechTemplate> |
| `CurrentResearchingTechs` | public static List<TITechTemplate> |
| `FinishedTechDataNames` | public List<string> |
| `techProgress` | private TechProgress[] |
| `campaignStartYear` | private int |
| `finishedTechData` | private List<FinishedTechData> |
| `gameStateSubjectCreated` | private bool |
| `finishedTechs` | private List<TITechTemplate> |
| `finishedOneTimeOnlyProjects` | public List<TIProjectTemplate> |
| `_allTechs` | private List<TITechTemplate> |
| `_allProjects` | private List<TIProjectTemplate> |
| `useHarshTree` | private bool |
| `endGameTechsCompletedByCategory` | public Dictionary<TechCategory, int> |
| `dailyResearchCmd` | protected JointResearchDailyUpdate |

### Properties

- `public List<string> finishedTechsNames`
- `public List<string> finishedOneTimeOnlyProjectNames`

### Methods

```csharp
public override bool Initialize()
```

```csharp
public override void PostGameStateCreateInit_OnCreationOnly_1()
```

```csharp
public override void PostGlobalGameStateCreateInit_2()
```

```csharp
public override void PostInitializationInit_4()
```

```csharp
public static List<TITechTemplate> GetAllTechs()
```

```csharp
public static List<TIProjectTemplate> GetAllProjects()
```

```csharp
private void AddFinishedTech(string templateName, bool duringInit = false)
```

```csharp
private void AddFinishedTech(TITechTemplate finishedTech, bool duringInit = false)
```

```csharp
public void AddFinishedOneTimeOnlyProject(TIProjectTemplate finishedProject)
```

```csharp
private bool AllTechsFinished()
```

```csharp
public string TechCompletionDate(int slot)
```

```csharp
public void AddResearchToTech(int slot, float contribution, TIFactionState factionState)
```

```csharp
public static List<TITechTemplate> FinishedTechs()
```

```csharp
public static bool TechFinished(TITechTemplate tech)
```

```csharp
public bool IsTechFinished(TITechTemplate tech)
```

```csharp
public static List<TITechTemplate> AvailableTechs()
```

```csharp
public int GetSlotForFactionCompletedTechs(TIFactionState faction)
```

```csharp
public void AssignNewTechToSlot(TITechTemplate template, int slot)
```

```csharp
public TechProgress GetTechProgress(int slot)
```

```csharp
public static float GetAccumulatedResearchByTech(TITechTemplate tech)
```

```csharp
public TIFactionState Leader(int slot)
```

```csharp
public int GetSlotForTech(TITechTemplate tech)
```

```csharp
public void GrantTech(string techName, bool logit = false, bool startup = false)
```

```csharp
public void OnTechFinished(int slot)
```

```csharp
public bool CheckForAutoPickTech(TIFactionState faction)
```

```csharp
public TIGenericTechTemplate nextPrereqTechToTarget(string targetTechName, TIFactionState faction, bool needTechReturned = false)
```

```csharp
public IEnumerable<TIGenericTechTemplate> GetDescendentTechs(IEnumerable<TIGenericTechTemplate> ancestors, TIFactionState faction, int generationCount)
```

```csharp
public void CheckForCompletedTechs()
```

```csharp
public void DailyResearchUpdate(TimeEventStart e)
```

```csharp
public void CreateVisualizer(TIDataTemplate myTemplate)
```
