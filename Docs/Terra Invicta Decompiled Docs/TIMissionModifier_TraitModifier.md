# TIMissionModifier_TraitModifier

*Decompiled from `TIMissionModifier_TraitModifier.cs`.*


## Class `TIMissionModifier_TraitModifier`

```csharp
public class TIMissionModifier_TraitModifier : TIMissionModifier
```

### Fields

| Name | Type |
|---|---|
| `displayName` | public override string |
| `trait` | public TITraitTemplate |
| `attribute` | public CouncilorAttribute |
| `attacking` | public bool |

### Methods

```csharp
public override float GetModifier(TICouncilorState attackingCouncilor, TIGameState target = null, float resourcesSpent = 0f, FactionResource resource = FactionResource.None)
```
