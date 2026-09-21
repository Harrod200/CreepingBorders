# TISpaceFleetOperationTemplate

*Decompiled from `TISpaceFleetOperationTemplate.cs`.*


## Class `TISpaceFleetOperationTemplate`

```csharp
public abstract class TISpaceFleetOperationTemplate : TIOperationTemplate
```

### Methods

```csharp
public virtual bool ExecuteUponCancel()
```

```csharp
public virtual bool CanCancel()
```

```csharp
public virtual bool isAlien()
```

```csharp
public virtual bool UpdatePropulsionOnComplete()
```

```csharp
public virtual bool MustAcceptCombat()
```

```csharp
public override bool OperationConfirmed(TIGameState actor, TIGameState target, TIDateTime opCompleteDate)
```

```csharp
public virtual List<Type> BreakthroughOps()
```

```csharp
public virtual bool CancelUponCombat()
```

```csharp
public virtual bool CancelUponDepartHab()
```

```csharp
public override void OnOperationCancel(TIGameState actorState, TIGameState target, TIDateTime opCompleteDate)
```

```csharp
public TIDateTime RescheduleFleetOperation(TISpaceFleetState fleet, OperationData operationData, float daysChange)
```

```csharp
protected bool ActorCanPerformOperation_PassInterruptCheck(TIGameState actorState)
```
