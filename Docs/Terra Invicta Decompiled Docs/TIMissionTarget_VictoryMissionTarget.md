# TIMissionTarget_VictoryMissionTarget

*Decompiled from `TIMissionTarget_VictoryMissionTarget.cs`.*


## Class `TIMissionTarget_VictoryMissionTarget`

```csharp
public class TIMissionTarget_VictoryMissionTarget : MissionTarget<TIGameState>
```

### Methods

```csharp
public override TIFactionState GetRelevantFaction(TIGameState target)
```

```csharp
public static bool IsVictoryTarget(TIObjectiveTemplate victoryObjective, TIGameState target)
```

```csharp
private TIObjectiveTemplate GetVictoryObjective(TIFactionState faction)
```

```csharp
public override List<string> ValidateSingleTarget(TIMissionTemplate mission, TICouncilorState councilor, TIGameState target)
```

```csharp
public override IEnumerable<TIGameState> GetAllPotentialTargets(TIFactionState faction)
```

```csharp
public IEnumerable<TIGameState> GetVictoryTargets(TIFactionState faction)
```

```csharp
public override IList<TIGameState> GetValidTargets(TIMissionTemplate mission, TICouncilorState councilor)
```
