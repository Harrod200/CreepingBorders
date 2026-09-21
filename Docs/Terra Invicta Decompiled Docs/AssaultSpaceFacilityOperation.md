# AssaultSpaceFacilityOperation

*Decompiled from `AssaultSpaceFacilityOperation.cs`.*


## Class `AssaultSpaceFacilityOperation`

```csharp
public class AssaultSpaceFacilityOperation : TIArmyOperationTemplate
```

### Methods

```csharp
public override bool ActorCanPerformOperation(TIGameState actorState, TIGameState target)
```

```csharp
public override OperationTiming GetOperationTiming()
```

```csharp
public override int SortOrder()
```

```csharp
public override Type GetTargetingMethod()
```

```csharp
public override string GetSuccessHeadline(TIArmyState army, TIGameState target)
```

```csharp
public override string GetSuccessSummary(TIArmyState army, TIGameState target)
```

```csharp
public override string GetSuccessDetail(TIArmyState army, TIGameState target)
```

```csharp
public override List<TIGameState> GetPossibleTargets(TIGameState actorState, TIGameState defaultTarget = null)
```

```csharp
public override float GetDuration_days(TIGameState actorState, TIGameState target, Trajectory trajectory = null)
```

```csharp
public override void ExecuteOperation(TIGameState actorState, TIGameState target)
```
