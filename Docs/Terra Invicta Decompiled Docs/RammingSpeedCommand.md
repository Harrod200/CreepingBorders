# RammingSpeedCommand

*Decompiled from `RammingSpeedCommand.cs`.*


## Class `RammingSpeedCommand`

```csharp
public class RammingSpeedCommand : TIShipCommandTemplate
```

### Fields

| Name | Type |
|---|---|
| `TriggersManeuver` | public override bool |

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
public override TIResourcesCost GetResourcesCost(TISpaceShipState ship)
```

```csharp
public override void OnCommandExecute(TISpaceShipState ship, CombatTargetableState target = null)
```
