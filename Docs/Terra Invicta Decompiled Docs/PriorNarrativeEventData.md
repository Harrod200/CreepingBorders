# PriorNarrativeEventData

*Decompiled from `PavonisInteractive/TerraInvicta/PriorNarrativeEventData.cs`.*


## Struct `PriorNarrativeEventData`

```csharp
public struct PriorNarrativeEventData
```

### Fields

| Name | Type |
|---|---|
| `priorEventTemplate` | public TINarrativeEventTemplate |
| `priorEventTemplateName` | public string |
| `actorState` | public TIGameState |
| `selectedTarget` | public TIGameState |
| `secondaryTarget` | public TIGameState |
| `allTargetsandSeconds` | public Dictionary<TIGameState, TIGameState> |

### Methods

```csharp
public PriorNarrativeEventData(TINarrativeEventTemplate priorEvent, TIGameState actorState, TIGameState selectedTarget, TIGameState secondaryTarget, Dictionary<TIGameState, TIGameState> allTargetsandSeconds)
```
