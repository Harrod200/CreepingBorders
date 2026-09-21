# SetSTOFightersForCombatAction

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/SetSTOFightersForCombatAction.cs`.*


## Class `SetSTOFightersForCombatAction`

```csharp
public class SetSTOFightersForCombatAction : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `factionID` | private GameStateID |
| `combatID` | private GameStateID |
| `fighterPlan` | private readonly Dictionary<TINationState, PlannedFighters> |

### Methods

```csharp
public SetSTOFightersForCombatAction(TISpaceCombatState combat, TIFactionState faction, Dictionary<TINationState, PlannedFighters> fighterPlan)
```

```csharp
public override void Execute()
```
