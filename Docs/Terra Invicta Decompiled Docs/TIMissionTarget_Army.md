# TIMissionTarget_Army

*Decompiled from `TIMissionTarget_Army.cs`.*


## Class `TIMissionTarget_Army`

```csharp
public class TIMissionTarget_Army : MissionTarget<TIArmyState>
```

### Methods

```csharp
public override TIFactionState GetRelevantFaction(TIGameState target)
```

```csharp
public override List<string> ValidateSingleTarget(TIMissionTemplate mission, TICouncilorState councilor, TIGameState target)
```

```csharp
public override IList<TIArmyState> GetValidTargets(TIMissionTemplate mission, TICouncilorState councilor)
```

```csharp
public override IEnumerable<TIArmyState> GetAllPotentialTargets(TIFactionState faction = null)
```
