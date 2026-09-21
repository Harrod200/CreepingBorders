# NarrativeEventOption

*Decompiled from `NarrativeEventOption.cs`.*


## Struct `NarrativeEventOption`

```csharp
public struct NarrativeEventOption
```

### Fields

| Name | Type |
|---|---|
| `UseAIModifiers` | public List<string> |
| `actingFactionCondition` | public TICondition |
| `targetCondition` | public TICondition |
| `outcomes` | public List<NarrativeEventOutcome> |
| `baseAIPreference` | public float |
| `useAIModifiers` | private List<string> |

### Methods

```csharp
public float outcomeChance(int idx, TIFactionState actingFaction, TIGameState target, TIGameState secondary)
```

```csharp
public List<NarrativeEventOutcome> possibleOutcomes(TIFactionState actingFaction, TIGameState target, TIGameState secondary)
```

```csharp
public string outcomeDescription(string eventDataName, int optionIdx, int outcomeIdx)
```

```csharp
public bool ValidOption(TIFactionState faction, TIGameState targetState, TIGameState secondary)
```

```csharp
public bool ValidOption(TINationState nation, TIGameState targetState, TIGameState secondary)
```

```csharp
public static bool PassesActorCondition(TIFactionState actingFaction, TICondition actingFactionCondition)
```

```csharp
public static bool PassesTargetCondition(TIGameState target, TICondition targetCondition)
```

```csharp
public StringBuilder OptionDetail(TIFactionState faction, TIGameState targetState, TIGameState secondaryState, string eventDataName, int idx, Dictionary<TIGameState, TIGameState> allTargetsandSeconds, TINarrativeEventTemplate narrativeEvent)
```
