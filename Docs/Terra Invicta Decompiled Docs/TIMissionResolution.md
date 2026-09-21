# TIMissionResolution

*Decompiled from `TIMissionResolution.cs`.*


## Class `TIMissionResolution`

```csharp
public abstract class TIMissionResolution
```

### Fields

| Name | Type |
|---|---|
| `automaticSuccess` | public virtual bool |
| `attackingModifiers` | public List<TIMissionModifier> |
| `defendingModifiers` | public List<TIMissionModifier> |
| `baseDifficulty` | public float |

### Methods

```csharp
public abstract float GetSuccessChance(TIMissionTemplate mission, TICouncilorState councilor = null, TIGameState target = null, float resourcesSpent = 0f, bool reValidateTarget = false)
```

```csharp
public abstract TIMissionResult GetMissionOutcome(TIMissionTemplate mission, TICouncilorState councilor = null, TIGameState target = null, float resourcesSpent = 0f)
```

```csharp
public string GetSuccessChanceString(TIMissionTemplate mission, out float successChance, TICouncilorState councilor = null, TIGameState target = null, float resourcesSpent = 0f, bool reValidateTarget = false, int digits = 2)
```

```csharp
public string GetSuccessChanceString(TIMissionTemplate mission, TICouncilorState councilor = null, TIGameState target = null, float resourcesSpent = 0f, bool reValidateTarget = false, int digits = 2)
```
