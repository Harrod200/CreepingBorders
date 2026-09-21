# SelectCombatBid

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/SelectCombatBid.cs`.*


## Class `SelectCombatBid`

```csharp
public class SelectCombatBid : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `factionID` | public GameStateID |
| `combatID` | public GameStateID |
| `bid_kps` | public float |
| `extendedOverride` | public CombatStance |
| `extendedPursuerIDs` | public List<GameStateID> |

### Methods

```csharp
public SelectCombatBid(TISpaceCombatState combat, TIFactionState faction, float bid_kps, CombatStance extendedOverride, List<TISpaceShipState> extendedPursuers)
```

```csharp
public override void Execute()
```
