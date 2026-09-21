# DirectInvestAction

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/DirectInvestAction.cs`.*


## Class `DirectInvestAction`

```csharp
public class DirectInvestAction : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `plannedDirectInvestments` | private Dictionary<PriorityType, float> |
| `factionID` | private GameStateID |
| `nationID` | private GameStateID |

### Methods

```csharp
public DirectInvestAction(TIFactionState faction, TINationState nation, Dictionary<PriorityType, float> plannedDirectInvestments)
```

```csharp
public DirectInvestAction(TIFactionState faction, TINationState nation, PriorityType priority, float IPs)
```

```csharp
public override void Execute()
```
