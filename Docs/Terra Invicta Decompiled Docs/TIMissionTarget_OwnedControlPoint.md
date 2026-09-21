# TIMissionTarget_OwnedControlPoint

*Decompiled from `TIMissionTarget_OwnedControlPoint.cs`.*


## Class `TIMissionTarget_OwnedControlPoint`

```csharp
public class TIMissionTarget_OwnedControlPoint : MissionTarget<TIControlPoint>
```

### Methods

```csharp
public override TIFactionState GetRelevantFaction(TIGameState target)
```

```csharp
public override List<string> ValidateSingleTarget(TIMissionTemplate mission, TICouncilorState councilor, TIGameState target)
```

```csharp
public override IEnumerable<TIControlPoint> GetAllPotentialTargets(TIFactionState faction = null)
```

```csharp
public override IList<TIControlPoint> GetValidTargets(TIMissionTemplate mission, TICouncilorState councilor)
```
