# SetIgnoreFactionContactAction

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/SetIgnoreFactionContactAction.cs`.*


## Class `SetIgnoreFactionContactAction`

```csharp
public class SetIgnoreFactionContactAction : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `actingFactionID` | private GameStateID |
| `targetFactionID` | private GameStateID |
| `ignore` | private bool |

### Methods

```csharp
public SetIgnoreFactionContactAction(TIFactionState actingFaction, TIFactionState targetFaction, bool ignore)
```

```csharp
public override void Execute()
```
