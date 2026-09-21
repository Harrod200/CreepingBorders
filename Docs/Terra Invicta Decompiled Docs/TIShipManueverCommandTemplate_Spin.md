# TIShipManueverCommandTemplate_Spin

*Decompiled from `TIShipManueverCommandTemplate_Spin.cs`.*


## Class `TIShipManueverCommandTemplate_Spin`

```csharp
public abstract class TIShipManueverCommandTemplate_Spin : TIShipManeuverCommandTemplate
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
public override bool CommandVisibleToActor(TISpaceShipState ship)
```

```csharp
public override bool ActorCanPerformCommand(TISpaceShipState ship)
```
