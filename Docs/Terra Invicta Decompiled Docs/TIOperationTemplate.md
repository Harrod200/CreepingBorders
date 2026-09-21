# TIOperationTemplate

*Decompiled from `TIOperationTemplate.cs`.*


## Class `TIOperationTemplate`

```csharp
public abstract class TIOperationTemplate : TIDataTemplate, IOperation
```

### Fields

| Name | Type |
|---|---|
| `operationIconImagePath` | public string |

### Methods

```csharp
public string GetDisplayName()
```

```csharp
public virtual string GetDescription(TIGameState actorState = null, TIGameState target = null)
```

```csharp
public abstract int SortOrder()
```

```csharp
public virtual bool IsBlockingOperation()
```

```csharp
public virtual bool RequiresThrustProfile()
```

```csharp
public virtual bool HasResourceCost()
```

```csharp
public string GetOperationIconImagePath_On()
```

```csharp
public string GetOperationIconImagePath_Off()
```

```csharp
public abstract bool OpVisibleToActor(TIGameState actorState, TIGameState targetState = null)
```

```csharp
public virtual bool ActorCanPerformOperation(TIGameState actorState, TIGameState target)
```

```csharp
public abstract List<TIGameState> GetPossibleTargets(TIGameState actorState, TIGameState defaultTarget = null)
```

```csharp
public abstract Type GetTargetingMethod()
```

```csharp
public abstract float GetDuration_days(TIGameState actorState, TIGameState target, Trajectory trajectory = null)
```

```csharp
public virtual bool UseResourceCostDuration()
```

```csharp
public virtual bool UseAbsoluteCompletionDateFromTrajectory()
```

```csharp
public TIOperationTemplate GetTemplate()
```

```csharp
public virtual List<TIResourcesCost> ResourceCostOptions(TIFactionState faction, TIGameState target, TIGameState actor, bool checkCanAfford = true)
```

```csharp
public abstract bool OperationConfirmed(TIGameState actor, TIGameState target, TIDateTime opCompleteDate)
```

```csharp
public abstract OperationTiming GetOperationTiming()
```

```csharp
public virtual bool Repeatable()
```

```csharp
public virtual bool WarnTarget(TIGameState target)
```

```csharp
public TIOperationTemplate()
```

```csharp
public bool ValidOperation(TIGameState actorState, TIGameState target, TIResourcesCost cost = null)
```

```csharp
protected bool OnOperationConfirm_Base(TIGameState actorState, TIGameState target, TIResourcesCost resourcesCost = null, Trajectory trajectory = null)
```

```csharp
public virtual bool OnOperationConfirm(TIGameState actorState, TIGameState target, TIResourcesCost resourcesCost = null, Trajectory trajectory = null)
```

```csharp
public abstract void ExecuteOperation(TIGameState actorState, TIGameState target)
```

```csharp
public void OnOperationExecute(TIGameState actorState, TIGameState target)
```

```csharp
public virtual void OnOperationCancel(TIGameState actorState, TIGameState target, TIDateTime opCompleteDate)
```
