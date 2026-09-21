# ProjectProgress

*Decompiled from `ProjectProgress.cs`.*


## Class `ProjectProgress`

```csharp
public class ProjectProgress
```

### Fields

| Name | Type |
|---|---|
| `projectTemplate` | public TIProjectTemplate |
| `projectCategory` | public TechCategory |
| `projectTemplateName` | public string |
| `accumulatedResearch` | public float |
| `slot` | public int |
| `completed` | public bool |

### Methods

```csharp
public ProjectProgress()
```

```csharp
public ProjectProgress(TIProjectTemplate projectTemplate, int slot, float accumulatedResearch = 0f)
```

```csharp
public ProjectProgress(string name, int slot, float accumulatedResearch = 0f)
```

```csharp
public bool SufficientResearchAccumulated(TIFactionState faction)
```

```csharp
public float progressFrac(TIFactionState faction)
```
