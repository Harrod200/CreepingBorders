# TechProgress

*Decompiled from `PavonisInteractive/TerraInvicta/TechProgress.cs`.*


## Class `TechProgress`

```csharp
public class TechProgress
```

### Fields

| Name | Type |
|---|---|
| `techTemplate` | public TITechTemplate |
| `TechCategory` | public TechCategory |
| `progressFrac` | public float |
| `remainingResearch` | public float |
| `slot` | public int |
| `techTemplateName` | public string |
| `accumulatedResearch` | public float |
| `factionContributions` | public Dictionary<TIFactionState, float> |
| `selector` | public TIFactionState |

### Methods

```csharp
public TechProgress(string templateName)
```

```csharp
public TechProgress(TITechTemplate template)
```

```csharp
public TIFactionState GetExpectedWinner(bool fast = false)
```

```csharp
public List<TIFactionState> GetPlacements()
```

```csharp
public int GetPlacement(TIFactionState faction)
```

```csharp
public bool CantWin(TIFactionState faction)
```

```csharp
public bool CantLose(TIFactionState faction)
```
