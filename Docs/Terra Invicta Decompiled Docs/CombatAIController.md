# CombatAIController

*Decompiled from `PavonisInteractive/TerraInvicta/GamePlayScript/AI/CombatAIController.cs`.*


## Class `CombatAIController`

```csharp
public class CombatAIController
```

### Fields

| Name | Type |
|---|---|
| `combatState` | private TISpaceCombatState |
| `NAV_VOLUME_SIZE` | private const int |
| `BASE_DEPTH_NODE_SIZE` | private const float |
| `_navVolume` | private OcTree |
| `_pathFinder` | private Pathfinding |
| `_shipBehaviours` | private List<CombatShipBehaviourTree> |
| `_fleetControllers` | private CombatFleetController[] |
| `_habModuleControllers` | private CombatHabModuleController[] |
| `_combatManager` | private SpaceCombatManager |
| `lastTruceCheck` | private TIDateTime |

### Methods

```csharp
public CombatAIController(SpaceCombatManager manager, TIDateTime currentTime, CombatFleetController[] fleetControllers, CombatHabModuleController[] habModuleControllers)
```

```csharp
public void DivideShipsIntoSquadronsAndConfigureAI(IList<CombatShipController> shipsToConfigure, CombatFleetController fleet, CombatFleetController enemyFleet, TIDateTime currentTime)
```

```csharp
public void AddShipOfTheLineSquadron(IList<CombatShipController> ships, CombatFleetController fleetController, CombatFleetController enemyFleet, TIDateTime currentTime)
```

```csharp
public void AddInterceptorSquadron(IList<CombatShipController> ships, CombatFleetController fleetController, CombatFleetController enemyFleet, TIDateTime currentTime)
```

```csharp
public void AddShipBehaviour(CombatShipController ship, CombatFleetController fleetController, CombatFleetController enemyFleet, TIDateTime currentTime)
```

```csharp
public void RemoveShipBehaviour(CombatShipController shipController)
```

```csharp
public void Update(TIDateTime currentTime)
```

```csharp
private void UpdateMutualTruceVotes(TIDateTime currentTime)
```

```csharp
private bool ShipQualifiesAsInterceptor(CombatShipController ship, CombatFleetController enemyFleet)
```
