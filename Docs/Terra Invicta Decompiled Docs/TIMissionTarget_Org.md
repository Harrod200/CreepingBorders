# TIMissionTarget_Org

*Decompiled from `TIMissionTarget_Org.cs`.*


## Class `TIMissionTarget_Org`

```csharp
public class TIMissionTarget_Org : MissionTarget<TIOrgState>
```

### Methods

```csharp
public override TIFactionState GetRelevantFaction(TIGameState target)
```

```csharp
public override IEnumerable<TIOrgState> GetAllPotentialTargets(TIFactionState faction)
```

```csharp
public override IList<TIOrgState> GetValidTargets(TIMissionTemplate mission, TICouncilorState councilor)
```

```csharp
public override List<string> ValidateSingleTarget(TIMissionTemplate mission, TICouncilorState councilor, TIGameState target)
```
