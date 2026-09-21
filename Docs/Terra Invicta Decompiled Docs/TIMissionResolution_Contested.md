# TIMissionResolution_Contested

*Decompiled from `TIMissionResolution_Contested.cs`.*


## Class `TIMissionResolution_Contested`

```csharp
public class TIMissionResolution_Contested : TIMissionResolution
```

### Fields

| Name | Type |
|---|---|
| `automaticSuccess` | public override bool |
| `scaling` | public const float |
| `failureChanceAtBalance` | public const float |
| `criticalCutPoint` | public const float |

### Methods

```csharp
public override TIMissionResult GetMissionOutcome(TIMissionTemplate mission, TICouncilorState councilor = null, TIGameState target = null, float resourcesSpent = 0f)
```

```csharp
public override float GetSuccessChance(TIMissionTemplate mission, TICouncilorState councilor = null, TIGameState target = null, float resourcesSpent = 0f, bool reValidateTarget = false)
```

```csharp
public List<TIMissionModifier> GetAttackingNonZeroModifiers(TIMissionTemplate mission, TICouncilorState councilor = null, TIGameState target = null, float resourcesSpent = 0f)
```

```csharp
public List<TIMissionModifier> GetDefendingNonZeroModifiers(TIMissionTemplate mission, TICouncilorState councilor = null, TIGameState target = null, float resourcesSpent = 0f)
```

```csharp
public List<TIMissionModifier> GetAllModifiers(TIMissionTemplate mission, bool attacking, TICouncilorState councilor, TIGameState target, float resourcesSpent)
```

```csharp
protected List<TIMissionModifier> GetNonZeroModifiers(TIMissionTemplate mission, bool attacking, TICouncilorState councilor, TIGameState target, float resourcesSpent)
```

```csharp
public float SumAttackingModifiers(TIMissionTemplate mission, TICouncilorState councilor, TIGameState target, float resourcesSpent)
```

```csharp
public float SumDefendingModifiers(TIMissionTemplate mission, TICouncilorState councilor, TIGameState target, float resourcesSpent)
```

```csharp
private float SumModifiers(TIMissionTemplate mission, List<TIMissionModifier> modifiers, TICouncilorState councilor, TIGameState target, float resourcesSpent)
```

```csharp
public float Difficulty(TIMissionTemplate mission, TICouncilorState councilor, TIGameState target, float resourcesSpent)
```
