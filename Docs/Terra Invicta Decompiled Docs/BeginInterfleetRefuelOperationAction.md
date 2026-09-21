# BeginInterfleetRefuelOperationAction

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/BeginInterfleetRefuelOperationAction.cs`.*


## Class `BeginInterfleetRefuelOperationAction`

```csharp
internal class BeginInterfleetRefuelOperationAction : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `fleetID` | private GameStateID |
| `plan` | private List<PropellantSharingEvent> |

### Methods

```csharp
public BeginInterfleetRefuelOperationAction(TISpaceFleetState fleet, List<PropellantSharingEvent> plan)
```

```csharp
public override void Execute()
```
