# StratCombatInitStrategy

*Decompiled from `PavonisInteractive/TerraInvicta/Tasks/StratCombatInitStrategy.cs`.*


## Class `StratCombatInitStrategy`

```csharp
public class StratCombatInitStrategy : ICombatInitStrategy
```

### Fields

| Name | Type |
|---|---|
| `stanceWeights` | private Dictionary<CombatStance, float> |

### Methods

```csharp
private void ChangeStanceWeight(CombatStance stance, float value)
```

```csharp
private bool AttemptForceStance(CombatStance stance)
```

```csharp
public CombatStance SelectStance(TIFactionState faction, TISpaceCombatState combatState, Dictionary<TINationState, PlannedFighters> fighterPlan)
```

```csharp
public float SelectBid_kps(TIFactionState faction, TISpaceCombatState combatState, out CombatStance extendedStance, out List<TISpaceShipState> chasers)
```

```csharp
public static Formation SelectSkirmishFormation(TISpaceFleetTemplate fleet, bool defendingHab)
```
