# BeginOfficerTransferOperationAction

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/BeginOfficerTransferOperationAction.cs`.*


## Class `BeginOfficerTransferOperationAction`

```csharp
internal class BeginOfficerTransferOperationAction : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `fleetID` | private GameStateID |
| `plan` | private Dictionary<TIOfficerState, OfficerCarrierState> |

### Methods

```csharp
public BeginOfficerTransferOperationAction(TISpaceFleetState fleet, Dictionary<TIOfficerState, OfficerCarrierState> plan)
```

```csharp
public override void Execute()
```
