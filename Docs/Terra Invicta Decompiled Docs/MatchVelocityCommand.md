# MatchVelocityCommand

*Decompiled from `MatchVelocityCommand.cs`.*


## Class `MatchVelocityCommand`

```csharp
public class MatchVelocityCommand : TIShipManeuverCommandWithTargetTemplate, IShipCommandWithTarget
```

### Methods

```csharp
public override int IconPosition()
```

```csharp
public override CombatManeuver Maneuver()
```

```csharp
public override bool ActorCanPerformCommand(TISpaceShipState ship)
```

```csharp
public override bool RequiresTarget()
```

```csharp
public bool IncludeFriendlyTargets()
```

```csharp
public bool OnlyFriendlyTargets()
```

```csharp
public Type GetTargetingMethod()
```

```csharp
public void InitiateTargeting(TISpaceShipState ship)
```

```csharp
public void EndTargeting(TIFactionState faction)
```

```csharp
public override void OnCommandExecute(TISpaceShipState ship, CombatTargetableState target = null)
```
