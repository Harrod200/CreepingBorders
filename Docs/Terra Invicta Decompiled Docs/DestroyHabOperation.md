# DestroyHabOperation

*Decompiled from `DestroyHabOperation.cs`.*


## Class `DestroyHabOperation`

```csharp
public class DestroyHabOperation : TISpaceFleetOperationTemplate
```

### Fields

| Name | Type |
|---|---|
| `destroyDurationPerTier_days` | private const float |

### Methods

```csharp
public override bool IsBlockingOperation()
```

```csharp
public override bool UpdatePropulsionOnComplete()
```

```csharp
public override bool CancelUponCombat()
```

```csharp
public override int SortOrder()
```

```csharp
public override bool CanCancel()
```

```csharp
public override OperationTiming GetOperationTiming()
```

```csharp
public override Type GetTargetingMethod()
```

```csharp
public override bool OpVisibleToActor(TIGameState actorState, TIGameState targetState = null)
```

```csharp
public override bool ActorCanPerformOperation(TIGameState actorState, TIGameState target)
```

```csharp
public override bool CancelUponDepartHab()
```

```csharp
public override float GetDuration_days(TIGameState actorState, TIGameState target, Trajectory trajectory = null)
```

```csharp
public override bool OperationConfirmed(TIGameState actor, TIGameState target, TIDateTime opCompleteDate)
```

```csharp
public override List<TIGameState> GetPossibleTargets(TIGameState actorState, TIGameState defaultTarget = null)
```

```csharp
public override bool WarnTarget(TIGameState target)
```

```csharp
public override void ExecuteOperation(TIGameState actorState, TIGameState target)
```

```csharp
public override void OnOperationCancel(TIGameState actorState, TIGameState target, TIDateTime opCompleteDate)
```

```csharp
public override string GetDescription(TIGameState actorState = null, TIGameState target = null)
```
