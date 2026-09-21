# TIArmyOperationTemplate

*Decompiled from `TIArmyOperationTemplate.cs`.*


## Class `TIArmyOperationTemplate`

```csharp
public abstract class TIArmyOperationTemplate : TIOperationTemplate
```

### Fields

| Name | Type |
|---|---|
| `isConvenienceOperation` | public virtual bool |

### Methods

```csharp
public override bool OpVisibleToActor(TIGameState actorState, TIGameState targetState = null)
```

```csharp
public override bool IsBlockingOperation()
```

```csharp
public virtual bool IsCombatOperation()
```

```csharp
public virtual string GetSuccessHeadline(TIArmyState army, TIGameState target)
```

```csharp
public virtual string GetFailureHeadline(TIArmyState army, TIGameState target)
```

```csharp
public virtual string GetSuccessSummary(TIArmyState army, TIGameState target)
```

```csharp
public virtual string GetSuccessDetail(TIArmyState army, TIGameState target)
```

```csharp
public virtual string GetFailureSummary(TIArmyState army, TIGameState target)
```

```csharp
public virtual string GetFailureDetail(TIArmyState army, TIGameState target)
```

```csharp
public override bool OperationConfirmed(TIGameState actor, TIGameState target, TIDateTime opCompleteDate)
```
