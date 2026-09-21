# SetIgnoreFactionInterstateDiplomacyAction

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/SetIgnoreFactionInterstateDiplomacyAction.cs`.*


## Class `SetIgnoreFactionInterstateDiplomacyAction`

```csharp
public class SetIgnoreFactionInterstateDiplomacyAction : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `actingFactionID` | private GameStateID |
| `targetFactionID` | private GameStateID |
| `ignore` | private bool |

### Methods

```csharp
public SetIgnoreFactionInterstateDiplomacyAction(TIFactionState actingFaction, TIFactionState targetFaction, bool ignore)
```

```csharp
public override void Execute()
```
