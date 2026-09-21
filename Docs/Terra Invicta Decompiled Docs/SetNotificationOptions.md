# SetNotificationOptions

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/SetNotificationOptions.cs`.*


## Class `SetNotificationOptions`

```csharp
public class SetNotificationOptions : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `factionID` | private GameStateID |
| `templateDataName` | private string |
| `notificationType` | private int |
| `overrideBehavior` | private NotificationOverrideBehavior |

### Methods

```csharp
public SetNotificationOptions(TIFactionState faction, string templateDataName, int type, NotificationOverrideBehavior behavior)
```

```csharp
public override void Execute()
```
