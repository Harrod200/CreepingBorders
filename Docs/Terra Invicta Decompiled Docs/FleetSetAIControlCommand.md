# FleetSetAIControlCommand

*Decompiled from `FleetSetAIControlCommand.cs`.*


## Class `FleetSetAIControlCommand`

```csharp
public class FleetSetAIControlCommand : TIFleetCommandTemplate
```

### Methods

```csharp
public override bool CommandVisibleToPlayer(List<TISpaceShipState> playerShips)
```

```csharp
public override bool PlayerCanIssueCommand(List<TISpaceShipState> playerShips)
```

```csharp
public override List<TISpaceShipState> GetEligibleShips(List<TISpaceShipState> playerShips)
```

```csharp
public override TIShipCommandTemplate GetShipCommandTemplate()
```

```csharp
public override int IconPosition()
```

```csharp
public override void OnExecuteFleetCommand(List<TISpaceShipState> playerShips, CombatTargetableState target = null)
```
