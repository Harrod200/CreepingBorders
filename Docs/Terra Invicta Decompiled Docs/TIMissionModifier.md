# TIMissionModifier

*Decompiled from `TIMissionModifier.cs`.*


## Class `TIMissionModifier`

```csharp
public abstract class TIMissionModifier : IMissionModifier
```

### Fields

| Name | Type |
|---|---|
| `displayName` | public virtual string |

### Methods

```csharp
public abstract float GetModifier(TICouncilorState attackingCouncilor, TIGameState target = null, float resourcesSpent = 0f, FactionResource resource = FactionResource.None)
```

```csharp
public static float CouncilCollectiveDefense(TIFactionState councilState, CouncilorAttribute attribute)
```

```csharp
protected static TINationState ObjectToNation(TIFactionState viewingFaction, TIGameState state)
```
