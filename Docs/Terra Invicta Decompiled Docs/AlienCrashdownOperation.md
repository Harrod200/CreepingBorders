# AlienCrashdownOperation

*Decompiled from `AlienCrashdownOperation.cs`.*


## Class `AlienCrashdownOperation`

```csharp
public class AlienCrashdownOperation : TISpaceFleetOperationTemplate_Special
```

### Methods

```csharp
public override OperationTiming GetOperationTiming()
```

```csharp
public override List<SpecialModuleRule> RequiredCapability()
```

```csharp
public override int SortOrder()
```

```csharp
public override bool IsBlockingOperation()
```

```csharp
public override bool isAlien()
```

```csharp
public override bool UpdatePropulsionOnComplete()
```

```csharp
public override bool CancelUponCombat()
```

```csharp
public override bool OpVisibleToActor(TIGameState actorState, TIGameState targetState = null)
```

```csharp
public bool CanCrashdown(TIGameState actorState)
```

```csharp
public override bool ActorCanPerformOperation(TIGameState actorState, TIGameState target)
```

```csharp
public override float GetDuration_days(TIGameState actorState, TIGameState target, Trajectory trajectory = null)
```

```csharp
public override Type GetTargetingMethod()
```

```csharp
public override List<TIGameState> GetPossibleTargets(TIGameState actorState, TIGameState defaultTarget = null)
```

```csharp
public override void ExecuteOperation(TIGameState actorState, TIGameState target)
```
