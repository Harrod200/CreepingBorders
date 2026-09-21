# RespondToPolicyProposalAction

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/RespondToPolicyProposalAction.cs`.*


## Class `RespondToPolicyProposalAction`

```csharp
public class RespondToPolicyProposalAction : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `actorID` | private GameStateID |
| `proposerID` | private GameStateID |
| `relatedID` | private GameStateID |
| `policy` | private TIPolicyOption |
| `accept` | private bool |

### Methods

```csharp
public RespondToPolicyProposalAction(TINationState respondingNation, TINationState proposingNation, TIGameState relatedGameState, TIPolicyOption policy, bool accept)
```

```csharp
public override void Execute()
```
