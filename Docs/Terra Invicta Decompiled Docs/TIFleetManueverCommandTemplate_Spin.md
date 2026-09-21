# TIFleetManueverCommandTemplate_Spin

*Decompiled from `TIFleetManueverCommandTemplate_Spin.cs`.*


## Class `TIFleetManueverCommandTemplate_Spin`

```csharp
public abstract class TIFleetManueverCommandTemplate_Spin : TIFleetManeuverCommandTemplate
```

### Methods

```csharp
public abstract CombatManeuver OppositeManeuver()
```

```csharp
public abstract CombatManeuver CancelManeuver()
```

```csharp
public abstract CombatManeuver CancelOppositeManeuver()
```

```csharp
public List<CombatManeuver> RestrictedManeuvers()
```

```csharp
public override bool CommandVisibleToPlayer(List<TISpaceShipState> playerShips)
```

```csharp
public override bool PlayerCanIssueCommand(List<TISpaceShipState> playerShips)
```
