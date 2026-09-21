# BreakPactAction

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/BreakPactAction.cs`.*


## Class `BreakPactAction`

```csharp
public class BreakPactAction : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `actingFactionID` | private GameStateID |
| `otherFactionID` | private GameStateID |
| `pactsToBreak` | private readonly List<TradeOffer.TreatyType> |

### Methods

```csharp
public BreakPactAction(TIFactionState actingFaction, TIFactionState otherFaction, List<TradeOffer.TreatyType> pactsToBreak)
```

```csharp
public override void Execute()
```
