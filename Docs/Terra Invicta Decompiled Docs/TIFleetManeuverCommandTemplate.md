# TIFleetManeuverCommandTemplate

*Decompiled from `TIFleetManeuverCommandTemplate.cs`.*


## Class `TIFleetManeuverCommandTemplate`

```csharp
public abstract class TIFleetManeuverCommandTemplate : TIFleetCommandTemplate
```

### Fields

| Name | Type |
|---|---|
| `exclusiveManeuvers` | public static readonly List<CombatManeuver> |

### Methods

```csharp
public override string GetTooltipText(bool isGroupCommand)
```

```csharp
public abstract CombatManeuver Maneuver()
```

```csharp
public override bool CommandVisibleToPlayer(List<TISpaceShipState> playerShips)
```

```csharp
public override string CommandIconImagePath()
```

```csharp
public override string GetCommandIconImagePath_On()
```
