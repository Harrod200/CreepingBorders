# CancelSpinCommand

*Decompiled from `CancelSpinCommand.cs`.*


## Class `CancelSpinCommand`

```csharp
public abstract class CancelSpinCommand : TIShipManeuverCommandTemplate
```

### Methods

```csharp
public override bool CommandVisibleToActor(TISpaceShipState ship)
```

```csharp
public override bool ActorCanPerformCommand(TISpaceShipState ship)
```

```csharp
public abstract CombatManeuver CancelManeuver()
```

```csharp
public override void OnCommandExecute(TISpaceShipState ship, CombatTargetableState target = null)
```
