# CancelFleetSpinCommand

*Decompiled from `CancelFleetSpinCommand.cs`.*


## Class `CancelFleetSpinCommand`

```csharp
public abstract class CancelFleetSpinCommand : TIFleetManeuverCommandTemplate
```

### Methods

```csharp
public override bool CommandVisibleToPlayer(List<TISpaceShipState> playerShips)
```

```csharp
public override bool PlayerCanIssueCommand(List<TISpaceShipState> playerShips)
```

```csharp
public abstract CombatManeuver CancelManeuver()
```
