# SetUserAlarmAction

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/SetUserAlarmAction.cs`.*


## Class `SetUserAlarmAction`

```csharp
public class SetUserAlarmAction : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `factionID` | private GameStateID |
| `targetID` | private GameStateID |
| `dateTime` | private TIDateTime |
| `alarm` | private AlarmType |
| `userString` | private string |

### Methods

```csharp
public SetUserAlarmAction(TIFactionState faction, TIGameState targetState, AlarmType alarm, TIDateTime dateTime, string userString)
```

```csharp
public override void Execute()
```
