# TIMissionTarget_Region

*Decompiled from `TIMissionTarget_Region.cs`.*


## Class `TIMissionTarget_Region`

```csharp
public class TIMissionTarget_Region : MissionTarget<TIRegionState>
```

### Methods

```csharp
public override TIFactionState GetRelevantFaction(TIGameState target)
```

```csharp
public override List<string> ValidateSingleTarget(TIMissionTemplate mission, TICouncilorState councilor, TIGameState target)
```

```csharp
public override IEnumerable<TIRegionState> GetAllPotentialTargets(TIFactionState faction = null)
```

```csharp
public override IList<TIRegionState> GetValidTargets(TIMissionTemplate mission, TICouncilorState councilor)
```
