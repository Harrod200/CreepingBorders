# BombardOperation

*Decompiled from `BombardOperation.cs`.*


## Class `BombardOperation`

```csharp
public abstract class BombardOperation : TISpaceFleetOperationTemplate
```

### Fields

| Name | Type |
|---|---|
| `BOMBARDMENT_DURATION_DAYS` | public const float |

### Methods

```csharp
public abstract float bombardmentAltitude_km(TISpaceBodyState targetBody)
```

```csharp
public override OperationTiming GetOperationTiming()
```

```csharp
public override bool IsBlockingOperation()
```

```csharp
public override bool OpVisibleToActor(TIGameState actorState, TIGameState targetState = null)
```

```csharp
public override float GetDuration_days(TIGameState actorState, TIGameState target, Trajectory trajectory = null)
```

```csharp
public override Type GetTargetingMethod()
```

```csharp
public override bool ExecuteUponCancel()
```

```csharp
public override bool Repeatable()
```

```csharp
public override bool CanCancel()
```

```csharp
public override bool CancelUponCombat()
```

```csharp
public override bool MustAcceptCombat()
```

```csharp
public override bool WarnTarget(TIGameState target)
```

```csharp
public override bool ActorCanPerformOperation(TIGameState actorState, TIGameState target)
```

```csharp
public override List<TIGameState> GetPossibleTargets(TIGameState actorState, TIGameState defaultTarget = null)
```

```csharp
public override bool OnOperationConfirm(TIGameState actorState, TIGameState target, TIResourcesCost resourcesCost = null, Trajectory trajectory = null)
```

```csharp
public override void ExecuteOperation(TIGameState actorState, TIGameState target)
```

```csharp
public override string GetDescription(TIGameState actorState = null, TIGameState target = null)
```

```csharp
public override List<Type> BreakthroughOps()
```
