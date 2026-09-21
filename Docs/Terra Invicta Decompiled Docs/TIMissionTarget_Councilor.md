# TIMissionTarget_Councilor

*Decompiled from `TIMissionTarget_Councilor.cs`.*


## Class `TIMissionTarget_Councilor`

```csharp
public class TIMissionTarget_Councilor : MissionTarget<TICouncilorState>
```

### Methods

```csharp
public override TIFactionState GetRelevantFaction(TIGameState target)
```

```csharp
public override List<string> ValidateSingleTarget(TIMissionTemplate mission, TICouncilorState councilor, TIGameState target)
```

```csharp
public override IEnumerable<TICouncilorState> GetAllPotentialTargets(TIFactionState faction = null)
```

```csharp
public override IList<TICouncilorState> GetValidTargets(TIMissionTemplate mission, TICouncilorState councilor)
```
