# NarrativeEventOutcome

*Decompiled from `NarrativeEventOutcome.cs`.*


## Struct `NarrativeEventOutcome`

```csharp
public struct NarrativeEventOutcome
```

### Fields

| Name | Type |
|---|---|
| `projectGranted` | public TIProjectTemplate |
| `orgGranted` | public TIOrgTemplate |
| `eventsToAdd` | public List<TINarrativeEventTemplate> |
| `eventsToRemove` | public List<TINarrativeEventTemplate> |
| `effectTemplates` | public List<TIEffectTemplate> |
| `delayedEffectTemplates` | public List<TIEffectTemplate> |
| `costBuilder` | public ResourceCostBuilder |
| `costMultiplier` | public CostMultiplier |
| `effectTemplateNames` | public List<string> |
| `delayedEffectTemplateNames` | public List<string> |
| `addNarrativeEvents` | public List<string> |
| `removeNarrativeEvents` | public List<string> |
| `projectGrantedTemplateName` | public string |
| `orgGrantedTemplateName` | public string |
| `weight` | public float |
| `facWtMod` | public List<NarrativeEventWeightModifier> |
| `tarWtMod` | public List<NarrativeEventWeightModifier> |
| `secWtMod` | public List<NarrativeEventWeightModifier> |
| `AIFavored` | public bool |
| `forceAlert` | public bool |

### Methods

```csharp
public bool ReportOutcome(TIGameState targetState)
```

```csharp
public float GetModifiedWeight(TIFactionState actingFaction, TIGameState target, TIGameState secondary)
```

```csharp
public TIResourcesCost GetCosts(TIGameState targetState)
```

```csharp
public TIResourcesCost GetRawCosts()
```

```csharp
public float GetCostMultiplier(TIGameState targetState)
```
