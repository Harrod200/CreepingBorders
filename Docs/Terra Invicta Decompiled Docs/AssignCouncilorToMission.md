# AssignCouncilorToMission

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/AssignCouncilorToMission.cs`.*


## Class `AssignCouncilorToMission`

```csharp
public class AssignCouncilorToMission : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `councilorID` | private GameStateID |
| `targetID` | private GameStateID |
| `resourcesSpend` | private readonly float |
| `missionTemplate` | private TIMissionTemplate |

### Methods

```csharp
public AssignCouncilorToMission(TICouncilorState councilor, TIMissionTemplate missionTemplate, TIGameState target, float resourcesSpend, bool forceMission = false)
```

```csharp
public override void Execute()
```
