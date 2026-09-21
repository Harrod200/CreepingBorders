# TIOperationTargeting_Hab

*Decompiled from `TIOperationTargeting_Hab.cs`.*


## Class `TIOperationTargeting_Hab`

```csharp
public class TIOperationTargeting_Hab : TIOperationTargeting
```

### Fields

| Name | Type |
|---|---|
| `fleet` | private TISpaceFleetState |
| `faction` | private TIFactionState |

### Methods

```csharp
public override List<Type> TargetedGameStates()
```

```csharp
public override OperationTargetingUIType UIType()
```

```csharp
public override void Init(IOperation operationType, TIGameState actorState, TIGameState defaultTarget = null)
```

```csharp
public override void Activate(TIGameState forceTarget = null)
```

```csharp
public override void Shutdown()
```

```csharp
private void HabSelectedForTargeting(HabSelectedEvent e)
```

```csharp
public override TIGameState GetDefaultTarget()
```
