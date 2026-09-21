# FleetMatchVelocityCommand

*Decompiled from `FleetMatchVelocityCommand.cs`.*


## Class `FleetMatchVelocityCommand`

```csharp
public class FleetMatchVelocityCommand : TIFleetManeuverCommandTemplate, IFleetCommandWithTarget
```

### Fields

| Name | Type |
|---|---|
| `ships` | public List<TISpaceShipState> |

### Methods

```csharp
public override int IconPosition()
```

```csharp
public override CombatManeuver Maneuver()
```

```csharp
public override bool PlayerCanIssueCommand(List<TISpaceShipState> playerShips)
```

```csharp
public override TIShipCommandTemplate GetShipCommandTemplate()
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
public void InitiateTargeting(List<TISpaceShipState> ships)
```

```csharp
public void EndTargeting(TIFactionState faction)
```
