# SetPriorityAction

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/SetPriorityAction.cs`.*


## Class `SetPriorityAction`

```csharp
public class SetPriorityAction : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `controlPointID` | private GameStateID |
| `factionID` | private GameStateID |
| `priority` | private readonly PriorityType |
| `onlyIfHigher` | private readonly bool |
| `value` | private int |
| `skipUpdates` | private readonly bool |

### Methods

```csharp
public SetPriorityAction(TIControlPoint controlPoint, TIFactionState faction, PriorityType priority, int value, bool onlyIfHigher, bool skipUpdates)
```

```csharp
public override void Execute()
```
