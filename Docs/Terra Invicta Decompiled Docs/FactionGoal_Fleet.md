# FactionGoal_Fleet

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_Fleet.cs`.*


## Class `FactionGoal_Fleet`

```csharp
public abstract class FactionGoal_Fleet : TIFactionGoalState
```

### Fields

| Name | Type |
|---|---|
| `FleetCouncilorGoal` | public virtual bool |
| `ExampleTrajectory` | public Trajectory |
| `isFleetGoal` | public override bool |
| `ref_fleetGoal` | public override FactionGoal_Fleet |
| `needsFleet` | public bool |
| `buildFleetsSequentially` | public virtual bool |
| `IsFrontGoal` | public bool |
| `allRoles` | public List<ShipRole> |
| `allPrimaryRoles` | public List<ShipRole> |
| `desiredFleetCombatValue` | public float |
| `ShouldPerformMissionMinimallyArmed` | public virtual bool |
| `desiredFlagshipHull` | public virtual TIShipHullTemplate |
| `learnedPerformanceRequirements` | public LearnedPerformanceRequirements |
| `cachedExampleTrajectory` | private Trajectory |
| `exampleTrajectoryCacheDatestamp` | private TIDateTime |
| `coreFleetOpsList` | protected static readonly List<Type> |
| `pendingFleets` | public List<TISpaceFleetState> |
| `dynamicAttackTarget` | public TIGameState |
| `bombardmentDefenseMultiplier` | protected const float |
| `cachedDesiredFleetCombatValue` | private float |
| `desiredFleetCombatValueCachedDate` | private TIDateTime |

### Properties

- `public TISpaceFleetState assignedFleet`
- `public abstract List<Type> fleetOperations`
- `public TIHabState resupplyHab`
- `public TISpaceBodyState flyByLocation`

### Methods

```csharp
public abstract bool RequiresFleet()
```

```csharp
public bool CanUseFleet()
```

```csharp
public bool LookingForFleet()
```

```csharp
public virtual bool SpaceCombatGoal()
```

```csharp
private ShipConstructionQueueItem FindConstructionQueueItemForPendingShip(string dataName)
```

```csharp
public TIGameState GetBombardmentTarget(TISpaceFleetState fleet, IEnumerable<TIGameState> emergencyTargets)
```

```csharp
public override TIDataTemplate SavingForTemplate(TIFactionState faction, out bool alreadyOrdered, out TIHabModuleState shipyard)
```

```csharp
public virtual void OnTransferComplete()
```

```csharp
public override void OnGoalComplete()
```

```csharp
public virtual void AssignFleet(TISpaceFleetState fleet)
```

```csharp
public virtual void UnassignFleet()
```

```csharp
public virtual bool LeaveMyFleetAlone()
```

```csharp
public override void DailyGoalMaintenance()
```

```csharp
public IEnumerable<ShipConstructionQueueItem> PendingShips()
```

```csharp
public List<TISpaceShipTemplate> PendingShipTemplates()
```

```csharp
public List<string> PendingShipDataNames()
```

```csharp
public bool AddPendingFleet(TISpaceFleetState pendingFleet)
```

```csharp
public bool RemovePendingFleet(TISpaceFleetState pendingFleet)
```

```csharp
public virtual bool ReadyForTransferToTarget(TISpaceFleetState fleet)
```

```csharp
public virtual bool NeedsFlagshipOrdered(List<TISpaceShipTemplate> pendingShips)
```

```csharp
public virtual bool NeedsShipsOrdered()
```

```csharp
public abstract ShipRole GetPrimaryShipRole()
```

```csharp
public virtual bool NeedsPrimaryRoleOrdered(List<TISpaceShipTemplate> pendingShipTemplates)
```

```csharp
public abstract Dictionary<ShipRole, float> GetSecondaryShipRoles()
```

```csharp
public static float ComputeBaselineFleetCombatValue(TIFactionState faction, TIGameState location)
```

```csharp
public virtual float ComputeDesiredFleetCombatValue()
```

```csharp
public bool HasEnoughSpaceCombatValue(TISpaceFleetState fleet)
```

```csharp
public virtual float GetMaximumFleetCombatValueRatio()
```

```csharp
public float GetMaximumFleetCombatValue()
```

```csharp
public virtual float GetForcePursueFleetCombatValue(TISpaceFleetState enemyFleet, TIHabState hab)
```

```csharp
public virtual bool MayIncreaseFleetSize()
```

```csharp
public abstract float GetDesiredAssaultCombatValue()
```

```csharp
public virtual Type GetBestOperation(TISpaceFleetState fleet, List<Type> candidateOperations, out TIGameState operationTarget)
```
