# TIOperationTargeting_HabSite

*Decompiled from `TIOperationTargeting_HabSite.cs`.*


## Class `TIOperationTargeting_HabSite`

```csharp
public class TIOperationTargeting_HabSite : TIOperationTargeting
```

### Fields

| Name | Type |
|---|---|
| `spaceBody` | private TISpaceBodyState |
| `faction` | private TIFactionState |
| `fleet` | private TISpaceFleetState |

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
private void HabSiteSelectedForTargeting(HabSiteSelectedEvent e)
```

```csharp
public override void Activate(TIGameState forceTarget = null)
```

```csharp
public override void Shutdown()
```

```csharp
public override TIGameState GetDefaultTarget()
```
