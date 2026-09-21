# SplitFleetOperationAction

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/SplitFleetOperationAction.cs`.*


## Class `SplitFleetOperationAction`

```csharp
public class SplitFleetOperationAction : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `oldFleetID` | private GameStateID |
| `newFleetShipIDs` | private List<GameStateID> |
| `goal` | private FactionGoal_Fleet |

### Properties

- `public TISpaceFleetState newFleet`

### Methods

```csharp
public SplitFleetOperationAction(TISpaceFleetState oldFleet, List<TISpaceShipState> newFleetShips, FactionGoal_Fleet goal = null)
```

```csharp
public override void Execute()
```
