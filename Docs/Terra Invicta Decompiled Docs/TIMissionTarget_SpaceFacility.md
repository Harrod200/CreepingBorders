# TIMissionTarget_SpaceFacility

*Decompiled from `TIMissionTarget_SpaceFacility.cs`.*


## Class `TIMissionTarget_SpaceFacility`

```csharp
public class TIMissionTarget_SpaceFacility : MissionTarget<TIRegionSpaceFacilityState>
```

### Methods

```csharp
public override TIFactionState GetRelevantFaction(TIGameState target)
```

```csharp
public override List<string> ValidateSingleTarget(TIMissionTemplate mission, TICouncilorState councilor, TIGameState target)
```

```csharp
public override IEnumerable<TIRegionSpaceFacilityState> GetAllPotentialTargets(TIFactionState faction = null)
```

```csharp
public override IList<TIRegionSpaceFacilityState> GetValidTargets(TIMissionTemplate mission, TICouncilorState councilor)
```
