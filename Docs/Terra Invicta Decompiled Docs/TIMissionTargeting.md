# TIMissionTargeting

*Decompiled from `TIMissionTargeting.cs`.*


## Class `TIMissionTargeting`

```csharp
public abstract class TIMissionTargeting : TITargeting
```

### Fields

| Name | Type |
|---|---|
| `councilor` | protected TICouncilorState |

### Properties

- `public TIMissionTemplate missionTemplate`

### Methods

```csharp
public virtual TIGameState GetDefaultTarget()
```

```csharp
public abstract void Activate()
```

```csharp
public abstract void Shutdown()
```

```csharp
protected void SetDefaultTarget()
```

```csharp
public virtual string GetTargetName()
```

```csharp
protected void SetTarget(TIGameState target)
```

```csharp
public virtual TIGameState GetTargetted()
```

```csharp
public virtual void Init(TIMissionTemplate missionType, TICouncilorState councilor)
```

```csharp
public virtual void ForceTarget(TIGameState target)
```

```csharp
protected void SetActivation(TIMissionTargeting mode)
```

```csharp
protected void SetShutdown()
```
