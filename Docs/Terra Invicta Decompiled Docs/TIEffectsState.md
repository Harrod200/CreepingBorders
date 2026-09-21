# TIEffectsState

*Decompiled from `PavonisInteractive/TerraInvicta/TIEffectsState.cs`.*


## Class `TIEffectsState`

```csharp
public class TIEffectsState : TIGameState
```

### Fields

| Name | Type |
|---|---|
| `factionEffectsNames` | private Dictionary<TIFactionState, Dictionary<Context, List<string>>> |
| `factionEffectExpirations` | private Dictionary<TIFactionState, Dictionary<string, TIDateTime>> |
| `factionEffects` | private Dictionary<TIFactionState, Dictionary<Context, List<TIEffectTemplate>>> |
| `gameStateSubjectCreated` | private bool |
| `maxMultiplierForScaledEffects` | public const float |

### Methods

```csharp
public override bool Initialize()
```

```csharp
public override void PostGlobalGameStateCreateInit_2()
```

```csharp
private void AddEffectToFaction(TIFactionState faction, TIEffectTemplate effectTemplate)
```

```csharp
public void GlobalCheckForRemoveEffects()
```

```csharp
private void RemoveEffect(TIEffectTemplate effectTemplate, TIGameState source)
```

```csharp
private void ProcessContextUpdate(Context testContext, TIFactionState faction)
```

```csharp
public static List<TIFactionState> GetAffectedFactions(TIEffectTemplate effectTemplate, TIFactionState sourceFaction)
```

```csharp
public static void AddEffect(TIEffectTemplate effectTemplate, TIFactionState sourceFaction, TIGameState inputEffectTarget = null, TIGameState inputEffectSecondaryTarget = null, string triggeringTemplateDataName = "")
```

```csharp
public static bool CheckForEffectInContext(Context context, TIGameState gameState, TIEffectTemplate effectTemplate)
```

```csharp
public static bool CheckForEffectInAnyContext(TIGameState gameState, TIEffectTemplate effectTemplate)
```

```csharp
public static bool CheckForAnyEffectInContext(Context context, TIGameState gameState)
```

```csharp
public static List<TIEffectTemplate> GetFactionEffectsForContext(Context context, TIFactionState faction)
```

```csharp
public static float SumEffectsModifiers(Context context, TIGameState sourceState, float baseValue, string strFilter = null)
```

```csharp
public static List<TIGameState> InstantEffectTargetToGameStates(TIGameState sourceState, EffectTargetType effectTarget, TIGameState inputState = null)
```

```csharp
public static List<TIGameState> GetEffectSecondaryStateCandidates(TIGameState primaryState, EffectSecondaryStateType targetType, TIGameState secondaryInputState = null, TINarrativeEventTemplate narrativeEvent = null)
```

```csharp
public static TIGameState GetSecondaryStateForEffect(EffectSecondaryStateType secondaryStateType, TIGameState primaryState, TIGameState secondaryInputState = null)
```

```csharp
public static float MinScaledTenPointStatEffect(float value)
```

```csharp
public static float MaxScaledTenPointStatEffect(float value)
```

```csharp
private static float RandomizedInstantEffectValue(float value, float randomizer)
```

```csharp
public static void ProcessInstantEffect(TIFactionState sourceFaction, EffectTargetType effectTargetType, EffectSecondaryStateType secondaryStateType, InstantEffect instantEffect, float value, float randomizer, string strValue, TIGameState inputState = null, TIGameState secondaryinputState = null, string triggeringTemplateDataName = "")
```
