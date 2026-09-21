# TIMissionTarget_AlienActivity

*Decompiled from `TIMissionTarget_AlienActivity.cs`.*


## Class `TIMissionTarget_AlienActivity`

```csharp
public class TIMissionTarget_AlienActivity : MissionTarget<TIRegionAlienEntityState>
```

### Methods

```csharp
public override TIFactionState GetRelevantFaction(TIGameState target)
```

```csharp
public override List<string> ValidateSingleTarget(TIMissionTemplate mission, TICouncilorState councilor, TIGameState target)
```

```csharp
public override IEnumerable<TIRegionAlienEntityState> GetAllPotentialTargets(TIFactionState faction = null)
```

```csharp
public override IList<TIRegionAlienEntityState> GetValidTargets(TIMissionTemplate mission, TICouncilorState councilor)
```
