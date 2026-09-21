# TIShipManeuverCommandTemplate

*Decompiled from `TIShipManeuverCommandTemplate.cs`.*


## Class `TIShipManeuverCommandTemplate`

```csharp
public abstract class TIShipManeuverCommandTemplate : TIShipCommandTemplate
```

### Fields

| Name | Type |
|---|---|
| `TriggersManeuver` | public override bool |
| `exclusiveManeuvers` | public static readonly List<CombatManeuver> |

### Methods

```csharp
public abstract CombatManeuver Maneuver()
```

```csharp
public override bool CommandVisibleToActor(TISpaceShipState ship)
```

```csharp
public override string GetCommandIconImagePath_On()
```

```csharp
public override void OnCommandExecute(TISpaceShipState ship, CombatTargetableState target = null)
```
