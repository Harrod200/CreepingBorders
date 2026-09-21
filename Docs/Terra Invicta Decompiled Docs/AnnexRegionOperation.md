# AnnexRegionOperation

*Decompiled from `AnnexRegionOperation.cs`.*


## Class `AnnexRegionOperation`

```csharp
public class AnnexRegionOperation : TIArmyOperationTemplate
```

### Fields

| Name | Type |
|---|---|
| `baselineAnnexationDuration_days` | public const float |
| `influenceCost` | public const int |

### Methods

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
public override string GetDescription(TIGameState actorState = null, TIGameState target = null)
```

```csharp
private bool ArmyCanAnnex(TIArmyState army)
```

```csharp
public override bool OpVisibleToActor(TIGameState actorState, TIGameState targetState = null)
```

```csharp
public override bool ActorCanPerformOperation(TIGameState actorState, TIGameState target)
```

```csharp
public override List<TIGameState> GetPossibleTargets(TIGameState actorState, TIGameState defaultTarget = null)
```

```csharp
public override bool HasResourceCost()
```

```csharp
public override List<TIResourcesCost> ResourceCostOptions(TIFactionState faction, TIGameState target, TIGameState actor, bool checkCanAfford = true)
```

```csharp
public override void OnOperationCancel(TIGameState actorState, TIGameState target, TIDateTime opCompleteDate)
```

```csharp
public override bool OperationConfirmed(TIGameState actor, TIGameState target, TIDateTime opCompleteDate)
```

```csharp
public override void ExecuteOperation(TIGameState actorState, TIGameState target)
```
