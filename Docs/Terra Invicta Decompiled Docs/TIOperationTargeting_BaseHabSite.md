# TIOperationTargeting_BaseHabSite

*Decompiled from `TIOperationTargeting_BaseHabSite.cs`.*


## Class `TIOperationTargeting_BaseHabSite`

```csharp
public class TIOperationTargeting_BaseHabSite : TIOperationTargeting
```

### Fields

| Name | Type |
|---|---|
| `spaceBody` | private TISpaceBodyState |
| `faction` | private TIFactionState |
| `fleet` | private TISpaceFleetState |

### Methods

```csharp
public override OperationTargetingUIType UIType()
```

```csharp
public override List<Type> TargetedGameStates()
```

```csharp
public override void Init(IOperation operationType, TIGameState actorState, TIGameState defaultTarget = null)
```

```csharp
private void HabSiteSelectedForTargeting(HabSiteSelectedEvent e)
```

```csharp
private void HabSelectedForTargeting(HabSelectedEvent e)
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
