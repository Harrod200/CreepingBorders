# DismissCouncilorAction

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/DismissCouncilorAction.cs`.*


## Class `DismissCouncilorAction`

```csharp
public class DismissCouncilorAction : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `councilorID` | private GameStateID |
| `factionID` | private GameStateID |
| `dismissingFactionID` | private GameStateID |

### Methods

```csharp
public DismissCouncilorAction(TICouncilorState councilor, TIFactionState faction, TIFactionState dismissingFaction)
```

```csharp
public override void Execute()
```
