# MissionTarget

*Decompiled from `MissionTarget.cs`.*


## Class `MissionTarget`

```csharp
public abstract class MissionTarget<T> : IMissionTarget<T>, IMissionTarget where T : TIGameState
```

### Methods

```csharp
public abstract TIFactionState GetRelevantFaction(TIGameState target)
```

```csharp
public abstract List<string> ValidateSingleTarget(TIMissionTemplate mission, TICouncilorState councilor, TIGameState target)
```

```csharp
public abstract IEnumerable<T> GetAllPotentialTargets(TIFactionState faction)
```

```csharp
public abstract IList<T> GetValidTargets(TIMissionTemplate mission, TICouncilorState councilor)
```

```csharp
public bool ValidTarget(List<string> results)
```
