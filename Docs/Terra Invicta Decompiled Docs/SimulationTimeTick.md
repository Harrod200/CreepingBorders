# SimulationTimeTick

*Decompiled from `PavonisInteractive/TerraInvicta/Systems/GameTime/SimulationTimeTick.cs`.*


## Class `SimulationTimeTick`

```csharp
public class SimulationTimeTick : ComponentSystem
```

### Fields

| Name | Type |
|---|---|
| `gameTime` | private GameTimeManager |
| `anyKeyTimer` | private float |
| `factionPlanner` | private AIDailyFactionPlanner |
| `promptQueue` | private TIPromptQueueState |
| `missionPhase` | private TIMissionPhaseState |
| `spaceCombat` | private SpaceCombatManager |
| `precombatController` | private PrecombatController |

### Methods

```csharp
protected override void OnStartRunning()
```

```csharp
protected override void OnUpdate()
```
