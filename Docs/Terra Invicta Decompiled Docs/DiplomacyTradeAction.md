# DiplomacyTradeAction

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/DiplomacyTradeAction.cs`.*


## Class `DiplomacyTradeAction`

```csharp
public class DiplomacyTradeAction : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `sendingFactionID` | private GameStateID |
| `receivingFactionID` | private GameStateID |
| `sendingTrade` | private TradeOffer |
| `receivingTrade` | private TradeOffer |
| `tradeHateModifier` | private float |

### Methods

```csharp
public DiplomacyTradeAction(TIFactionState sendingFaction, TIFactionState receivingFaction, TradeOffer sendingTrade, TradeOffer receivingTrade, float hateModifier)
```

```csharp
public override void Execute()
```
