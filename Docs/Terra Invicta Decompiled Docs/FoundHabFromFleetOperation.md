# FoundHabFromFleetOperation

*Decompiled from `FoundHabFromFleetOperation.cs`.*


## Class `FoundHabFromFleetOperation`

```csharp
public abstract class FoundHabFromFleetOperation : TISpaceFleetOperationTemplate_Special
```

### Methods

```csharp
public override OperationTiming GetOperationTiming()
```

```csharp
public override bool IsBlockingOperation()
```

```csharp
public abstract TIHabModuleTemplate CoreModule(bool alien)
```

```csharp
public abstract List<string> AdditionalModules(bool alien)
```

```csharp
public override float GetDuration_days(TIGameState actorState, TIGameState target, Trajectory trajectory = null)
```

```csharp
public override bool UpdatePropulsionOnComplete()
```

```csharp
public override bool MustAcceptCombat()
```

```csharp
public override bool CancelUponCombat()
```

```csharp
public override bool OpVisibleToActor(TIGameState actorState, TIGameState targetState = null)
```

```csharp
public override string GetDescription(TIGameState actorState = null, TIGameState target = null)
```

```csharp
public virtual int GetTier()
```
