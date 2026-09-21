# SelectFleetFormationAction

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/SelectFleetFormationAction.cs`.*


## Class `SelectFleetFormationAction`

```csharp
public class SelectFleetFormationAction : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `fleetID` | public GameStateID |
| `formationDataName` | public string |
| `combatID` | public GameStateID |
| `formation` | public Formation |
| `saveFormation` | public bool |
| `numberOfPositions` | public int |
| `activeShips` | public IList<CombatShipController> |

### Methods

```csharp
public SelectFleetFormationAction(TISpaceFleetState fleet, Formation formation, TISpaceCombatState combat, int numberOfPositions, IList<CombatShipController> activeShips, bool saveFormation = false)
```

```csharp
public override void Execute()
```
