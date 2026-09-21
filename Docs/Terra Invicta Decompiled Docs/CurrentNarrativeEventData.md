# CurrentNarrativeEventData

*Decompiled from `PavonisInteractive/TerraInvicta/CurrentNarrativeEventData.cs`.*


## Struct `CurrentNarrativeEventData`

```csharp
public struct CurrentNarrativeEventData
```

### Fields

| Name | Type |
|---|---|
| `eventTemplate` | public TINarrativeEventTemplate |
| `eventTemplateName` | public string |
| `actorState` | public TIGameState |
| `selectedTarget` | public TIGameState |
| `secondaryTarget` | public TIGameState |
| `allTargetsandSeconds` | public Dictionary<TIGameState, TIGameState> |

### Methods

```csharp
public CurrentNarrativeEventData(TINarrativeEventTemplate eventTemplate, TIGameState actorState, TIGameState selectedTarget, TIGameState secondaryTarget, Dictionary<TIGameState, TIGameState> allTargetsandSeconds)
```
