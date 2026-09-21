# LegacyHumanHabPlanner

*Decompiled from `PavonisInteractive/TerraInvicta/Tasks/LegacyHumanHabPlanner.cs`.*


## Class `LegacyHumanHabPlanner`

```csharp
public class LegacyHumanHabPlanner : LegacyHabPlanner
```

### Fields

| Name | Type |
|---|---|
| `gameTime` | private GameTimeManager |
| `NEOBaseScores` | private Dictionary<TIOrbitState, float> |
| `missionControlReserve` | private const int |

### Methods

```csharp
public LegacyHumanHabPlanner()
```

```csharp
public override void ManageHabGoals(TIFactionState faction)
```

```csharp
private void EstablishEarthSpacePresence(TIFactionState faction, List<TIHabState> earthSystemStations)
```

```csharp
private void ManagePriorityProspectFactionGoals_Human(TIFactionState faction)
```

```csharp
private void ManagePriorityHabsConstructionFactionGoals_Human(TIFactionState faction)
```
