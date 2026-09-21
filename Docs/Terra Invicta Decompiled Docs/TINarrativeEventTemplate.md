# TINarrativeEventTemplate

*Decompiled from `TINarrativeEventTemplate.cs`.*


## Class `TINarrativeEventTemplate`

```csharp
public class TINarrativeEventTemplate : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `ShouldCacheEventData` | public bool |
| `illustrationResource` | public string |
| `soundResource` | public string |
| `requiresAliens` | public bool |
| `year` | public int? |
| `endYear` | public int? |
| `earliestMonth` | public int? |
| `latestMonth` | public int? |
| `reqTechDataName` | public string |
| `reqEventUnlock` | public bool |
| `logPublicity` | public PublicityType |
| `alertPublicity` | public PublicityType |
| `repeatable` | public RepeatableStatus |
| `numOptions` | public int |
| `forceEvent` | public bool |
| `baseWeight` | public float |
| `monthlyWeightDelta` | public float |
| `altMonthlyWeightDelta` | public float |
| `weightDeltaWhenTriggered` | public float |
| `altBaseWeight` | public NarrativeEventWeightModifier |
| `global_cooldown_months` | public int |
| `target_cooldown_months` | public int |
| `targetType` | public NarrativeEventTargetType |
| `hitAllQualifyingTargets` | public bool |
| `firstTargetNotificationOnly` | public bool |
| `possibleTargetDataNames` | public List<string> |
| `targetConditions` | public List<TICondition> |
| `targetWeightModifiers` | public List<NarrativeEventWeightModifier> |
| `secondaryStateType` | public EffectSecondaryStateType |
| `secondaryStateConditions` | public List<TICondition> |
| `sameSecondaryForAllTargets` | public bool |
| `possibleSecondaryStateDataNames` | public List<string> |
| `secondaryWeightModifiers` | public List<NarrativeEventWeightModifier> |
| `eventOptions` | public List<NarrativeEventOption> |

### Methods

```csharp
public string summary(TIGameState actingState, TIGameState target, TIGameState secondaryTarget)
```

```csharp
public string query(TIFactionState faction, TIGameState target, TIGameState secondaryTarget)
```

```csharp
public string optionButtonText(TIGameState actor, TIGameState target, TIGameState secondaryTarget, int idx)
```

```csharp
public string optionButtonDetail(TIFactionState faction, TIGameState target, TIGameState secondaryTarget, int idx, Dictionary<TIGameState, TIGameState> allTargets)
```

```csharp
public string optionSummary(TIGameState actingState, TIGameState target, TIGameState secondaryTarget, int idx)
```

```csharp
public string outcomeSummary(TIGameState actingState, TIGameState target, TIGameState secondaryTarget, int optionIdx, int outcomeIdx)
```

```csharp
public string outcomeDetail(TIGameState actingState, TIGameState target, TIGameState secondaryTarget, int optionIdx, int outcomeIdx)
```

```csharp
public override bool IsValid(out string error)
```

```csharp
public bool ActorCanAffordAnyOption(TIFactionState faction, TIGameState target, TIGameState secondary)
```

```csharp
private StringBuilder NarrativeEventStringReplacement(StringBuilder baseString, TIGameState actingState, TIGameState target, TIGameState secondaryTarget, bool isSummary = false)
```

```csharp
public bool ReportOutcome(NarrativeEventOption selectedOption, NarrativeEventOutcome outcome, TIFactionState faction, TIGameState targetState, TIGameState secondaryState)
```
