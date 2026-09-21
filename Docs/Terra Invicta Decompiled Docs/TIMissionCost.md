# TIMissionCost

*Decompiled from `TIMissionCost.cs`.*


## Class `TIMissionCost`

```csharp
public abstract class TIMissionCost
```

### Fields

| Name | Type |
|---|---|
| `resourceType` | public FactionResource |
| `value` | public float |

### Methods

```csharp
public abstract float GetCost(float bonus, TICouncilorState councilor = null, TIGameState scalingState = null)
```

```csharp
public virtual bool MeetsCondition(TICouncilorState councilor)
```
