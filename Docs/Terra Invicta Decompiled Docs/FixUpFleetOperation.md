# FixUpFleetOperation

*Decompiled from `FixUpFleetOperation.cs`.*


## Class `FixUpFleetOperation`

```csharp
public abstract class FixUpFleetOperation : TISpaceFleetOperationTemplate
```

### Methods

```csharp
public override OperationTiming GetOperationTiming()
```

```csharp
public override bool IsBlockingOperation()
```

```csharp
public override bool UseResourceCostDuration()
```

```csharp
public override bool CanCancel()
```

```csharp
public override bool CancelUponDepartHab()
```

```csharp
public override float GetDuration_days(TIGameState actorState, TIGameState target, Trajectory trajectory = null)
```

```csharp
public override Type GetTargetingMethod()
```

```csharp
public override bool HasResourceCost()
```

```csharp
public override List<TIGameState> GetPossibleTargets(TIGameState actorState, TIGameState defaultTarget = null)
```

```csharp
public override List<Type> BreakthroughOps()
```

```csharp
protected void HandlePartialCompletion(TISpaceFleetState fleet, TIDateTime opCompleteDate)
```

```csharp
protected void CleanUpFleetRepairData(TISpaceFleetState fleet)
```
