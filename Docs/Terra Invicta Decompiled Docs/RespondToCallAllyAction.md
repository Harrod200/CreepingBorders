# RespondToCallAllyAction

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/RespondToCallAllyAction.cs`.*


## Class `RespondToCallAllyAction`

```csharp
public class RespondToCallAllyAction : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `allyID` | private GameStateID |
| `warID` | private GameStateID |
| `callingNationID` | private GameStateID |
| `accept` | private bool |

### Methods

```csharp
public RespondToCallAllyAction(TINationState ally, TINationState callingNation, TIWarState war, bool accept)
```

```csharp
public override void Execute()
```
