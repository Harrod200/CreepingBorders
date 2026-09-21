# TIOperationTargeting

*Decompiled from `TIOperationTargeting.cs`.*


## Class `TIOperationTargeting`

```csharp
public abstract class TIOperationTargeting : TITargeting
```

### Fields

| Name | Type |
|---|---|
| `operationType` | protected IOperation |
| `actorState` | protected TIGameState |

### Methods

```csharp
public abstract TIGameState GetDefaultTarget()
```

```csharp
public TIGameState GetDefaultTargetOrNull()
```

```csharp
public abstract void Activate(TIGameState forceTarget = null)
```

```csharp
public abstract void Shutdown()
```

```csharp
public abstract OperationTargetingUIType UIType()
```

```csharp
public TIGameState GetTargetted()
```

```csharp
public string GetTargetName()
```

```csharp
protected void SetDefaultTarget(TIGameState forceTarget = null)
```

```csharp
public virtual void ForceTarget(TIGameState target)
```

```csharp
protected void AttemptSetTarget(TIGameState target)
```

```csharp
public virtual void Init(IOperation operationType, TIGameState actorState, TIGameState defaultTarget = null)
```

```csharp
protected void SetActivation(TIOperationTargeting mode)
```

```csharp
protected void SetShutdown()
```
