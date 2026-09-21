# TIMissionEffect

*Decompiled from `TIMissionEffect.cs`.*


## Class `TIMissionEffect`

```csharp
public abstract class TIMissionEffect
```

### Methods

```csharp
public abstract string ApplyEffect(TIMissionState mission, TIGameState target, TIMissionOutcome outcome = TIMissionOutcome.Success)
```

```csharp
public virtual bool HasDelayedEffect()
```

```csharp
public virtual void ApplyDelayedEffect(TIMissionState mission, TIGameState target, TIMissionOutcome outcome = TIMissionOutcome.Success, string dataName = "")
```

```csharp
protected bool MissionSuccess(TIMissionOutcome outcome)
```

```csharp
protected bool MissionFailure(TIMissionOutcome outcome)
```
