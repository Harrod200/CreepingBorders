# TITargeting

*Decompiled from `TITargeting.cs`.*


## Class `TITargeting`

```csharp
public abstract class TITargeting
```

### Fields

| Name | Type |
|---|---|
| `GetPossibleTargets` | public IList<TIGameState> |
| `forceMap` | public virtual bool |
| `currentTarget` | protected TIGameState |
| `possibleTargets` | protected IList<TIGameState> |

### Properties

- `public bool activated`

### Methods

```csharp
public abstract List<Type> TargetedGameStates()
```

```csharp
private void CycleToTarget(TIGameState target)
```

```csharp
public void CycleTargetForward()
```

```csharp
public void CycleTargetBackward()
```
