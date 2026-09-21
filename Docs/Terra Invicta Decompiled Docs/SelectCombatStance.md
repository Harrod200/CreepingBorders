# SelectCombatStance

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/SelectCombatStance.cs`.*


## Class `SelectCombatStance`

```csharp
public class SelectCombatStance : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `combatID` | private GameStateID |
| `factionID` | private GameStateID |
| `stance` | private readonly CombatStance |

### Methods

```csharp
public SelectCombatStance(TISpaceCombatState combat, TIFactionState faction, CombatStance stance)
```

```csharp
public override void Execute()
```
