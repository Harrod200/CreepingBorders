# TIRegionAlienAssetState

*Decompiled from `PavonisInteractive/TerraInvicta/TIRegionAlienAssetState.cs`.*


## Class `TIRegionAlienAssetState`

```csharp
public abstract class TIRegionAlienAssetState : TIRegionAlienEntityState
```

### Fields

| Name | Type |
|---|---|
| `isRegionAlienAsset` | public override bool |
| `ref_regionAlienAsset` | public override TIRegionAlienAssetState |

### Methods

```csharp
public abstract string ResolveAssault(TIGameState assaultingState, TIFactionState assaultingFaction, TIMissionOutcome outcome)
```

```csharp
public abstract List<CampaignMilestone> CampaignMilestonesGrantedOnCapture(TIFactionState capturingFaction, TIMissionOutcome outcome)
```

```csharp
public abstract float GetArmyAssaultDefenseScore()
```

```csharp
public virtual string GetDestroyedIllustrationPath()
```

```csharp
public bool UnderArmyAssault()
```
