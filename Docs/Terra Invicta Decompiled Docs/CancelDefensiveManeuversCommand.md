# CancelDefensiveManeuversCommand

*Decompiled from `CancelDefensiveManeuversCommand.cs`.*


## Class `CancelDefensiveManeuversCommand`

```csharp
public class CancelDefensiveManeuversCommand : TIShipManeuverCommandTemplate
```

### Methods

```csharp
public override int IconPosition()
```

```csharp
public override CombatManeuver Maneuver()
```

```csharp
public CombatManeuver CancelManeuver()
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
