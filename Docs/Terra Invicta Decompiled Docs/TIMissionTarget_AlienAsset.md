# TIMissionTarget_AlienAsset

*Decompiled from `TIMissionTarget_AlienAsset.cs`.*


## Class `TIMissionTarget_AlienAsset`

```csharp
public class TIMissionTarget_AlienAsset : MissionTarget<TIRegionAlienAssetState>
```

### Methods

```csharp
public override TIFactionState GetRelevantFaction(TIGameState target)
```

```csharp
public override IEnumerable<TIRegionAlienAssetState> GetAllPotentialTargets(TIFactionState faction = null)
```

```csharp
public override List<string> ValidateSingleTarget(TIMissionTemplate mission, TICouncilorState councilor, TIGameState target)
```

```csharp
public override IList<TIRegionAlienAssetState> GetValidTargets(TIMissionTemplate mission, TICouncilorState councilor)
```
