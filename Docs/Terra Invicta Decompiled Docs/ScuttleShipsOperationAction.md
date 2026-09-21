# ScuttleShipsOperationAction

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/ScuttleShipsOperationAction.cs`.*


## Class `ScuttleShipsOperationAction`

```csharp
public class ScuttleShipsOperationAction : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `fleet` | private GameStateID |
| `shipsToDestroyIDs` | private List<GameStateID> |

### Methods

```csharp
public ScuttleShipsOperationAction(TISpaceFleetState fleet, List<TISpaceShipState> shipsToDestroy)
```

```csharp
public override void Execute()
```
