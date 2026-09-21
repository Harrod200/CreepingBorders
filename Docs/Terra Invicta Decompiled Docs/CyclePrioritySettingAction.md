# CyclePrioritySettingAction

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/CyclePrioritySettingAction.cs`.*


## Class `CyclePrioritySettingAction`

```csharp
public class CyclePrioritySettingAction : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `controlPointID` | private GameStateID |
| `factionID` | private GameStateID |
| `priority` | private PriorityType |
| `decrement` | private bool |

### Methods

```csharp
public CyclePrioritySettingAction(TIControlPoint controlPoint, TIFactionState faction, PriorityType priority, bool decrement)
```

```csharp
public override void Execute()
```
