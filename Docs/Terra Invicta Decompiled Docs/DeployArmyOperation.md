# DeployArmyOperation

*Decompiled from `DeployArmyOperation.cs`.*


## Class `DeployArmyOperation`

```csharp
public abstract class DeployArmyOperation : TIArmyOperationTemplate
```

### Properties

- `public bool JourneyMode`

### Methods

```csharp
public void SetJourneyMode(bool allowJournies)
```

```csharp
public DeployArmyOperation(bool allowJournies_ = false)
```

```csharp
public override OperationTiming GetOperationTiming()
```

```csharp
public override int SortOrder()
```

```csharp
public override Type GetTargetingMethod()
```

```csharp
public override bool IsCombatOperation()
```

```csharp
public override float GetDuration_days(TIGameState actorState, TIGameState target, Trajectory trajectory = null)
```

```csharp
public override bool OnOperationConfirm(TIGameState actorState, TIGameState target, TIResourcesCost resourcesCost = null, Trajectory trajectory = null)
```

```csharp
public override void ExecuteOperation(TIGameState actorState, TIGameState target)
```

```csharp
public override void OnOperationCancel(TIGameState actorState, TIGameState target, TIDateTime opCompleteDate)
```

```csharp
public override bool Equals(object obj)
```
