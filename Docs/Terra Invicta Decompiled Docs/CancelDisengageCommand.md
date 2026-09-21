# CancelDisengageCommand

*Decompiled from `CancelDisengageCommand.cs`.*


## Class `CancelDisengageCommand`

```csharp
public class CancelDisengageCommand : TIShipCommandTemplate
```

### Fields

| Name | Type |
|---|---|
| `TriggersManeuver` | public override bool |
| `combatDurationTillAllowed_min` | public const float |
| `minDistanceToTrigger_km` | public const float |

### Methods

```csharp
public override int IconPosition()
```

```csharp
public override string GetDescription(TISpaceShipState ship = null)
```

```csharp
public override bool CommandVisibleToActor(TISpaceShipState ship)
```

```csharp
public override bool ActorCanPerformCommand(TISpaceShipState ship)
```

```csharp
public override void OnCommandExecute(TISpaceShipState ship, CombatTargetableState target = null)
```
