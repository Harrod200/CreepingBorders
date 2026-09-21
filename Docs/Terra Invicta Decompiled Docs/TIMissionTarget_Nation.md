# TIMissionTarget_Nation

*Decompiled from `TIMissionTarget_Nation.cs`.*


## Class `TIMissionTarget_Nation`

```csharp
public class TIMissionTarget_Nation : MissionTarget<TINationState>
```

### Methods

```csharp
public override TIFactionState GetRelevantFaction(TIGameState target)
```

```csharp
public override List<string> ValidateSingleTarget(TIMissionTemplate mission, TICouncilorState councilor, TIGameState target)
```

```csharp
public override IEnumerable<TINationState> GetAllPotentialTargets(TIFactionState faction = null)
```

```csharp
public override IList<TINationState> GetValidTargets(TIMissionTemplate mission, TICouncilorState councilor)
```
