# ConfirmOperationAction

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/ConfirmOperationAction.cs`.*


## Class `ConfirmOperationAction`

```csharp
public class ConfirmOperationAction : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `actorID` | private GameStateID |
| `targetID` | private GameStateID |
| `operation` | private IOperation |
| `resourcesCost` | private TIResourcesCost |
| `trajectory` | private Trajectory |

### Methods

```csharp
public ConfirmOperationAction(TIGameState actorState, TIGameState target, IOperation operation, TIResourcesCost resourcesCost = null, Trajectory trajectory = null)
```

```csharp
public override void Execute()
```
