# DeployArmyOperation_TargetHome

*Decompiled from `DeployArmyOperation_TargetHome.cs`.*


## Class `DeployArmyOperation_TargetHome`

```csharp
public class DeployArmyOperation_TargetHome : DeployArmyOperation
```

### Fields

| Name | Type |
|---|---|
| `isConvenienceOperation` | public override bool |

### Methods

```csharp
public override int SortOrder()
```

```csharp
public override bool OpVisibleToActor(TIGameState actorState, TIGameState targetState = null)
```

```csharp
public override bool ActorCanPerformOperation(TIGameState actorState, TIGameState target)
```

```csharp
public static List<TIGameState> GetPossibleTargets(TIGameState actorState, bool allowJournies)
```

```csharp
public override List<TIGameState> GetPossibleTargets(TIGameState actorState, TIGameState defaultTarget = null)
```

```csharp
public DeployArmyOperation_TargetHome()
```
