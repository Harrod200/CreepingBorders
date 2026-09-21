# ConfirmPolicyAction

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/ConfirmPolicyAction.cs`.*


## Class `ConfirmPolicyAction`

```csharp
public class ConfirmPolicyAction : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `targetID` | private GameStateID |
| `proposerID` | private GameStateID |
| `guidingFactionID` | private GameStateID |
| `councilorID` | private GameStateID |
| `policy` | private TIPolicyOption |

### Methods

```csharp
public ConfirmPolicyAction(TINationState proposingNation, TIFactionState guidingFaction, TIGameState target, TICouncilorState triggeringCouncilor, TIPolicyOption policy)
```

```csharp
public override void Execute()
```
