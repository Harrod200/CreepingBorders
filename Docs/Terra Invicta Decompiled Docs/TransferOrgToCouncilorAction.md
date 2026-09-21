# TransferOrgToCouncilorAction

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/TransferOrgToCouncilorAction.cs`.*


## Class `TransferOrgToCouncilorAction`

```csharp
public class TransferOrgToCouncilorAction : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `factionID` | private GameStateID |
| `councilorReceivingID` | private GameStateID |
| `councilorGivingID` | private GameStateID |
| `orgID` | private GameStateID |

### Methods

```csharp
public TransferOrgToCouncilorAction(TIOrgState org, TIFactionState faction, TICouncilorState councilorReceiving, TICouncilorState councilorGiving)
```

```csharp
public override void Execute()
```
