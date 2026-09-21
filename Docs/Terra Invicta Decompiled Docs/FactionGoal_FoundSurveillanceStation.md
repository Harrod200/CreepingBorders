# FactionGoal_FoundSurveillanceStation

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_FoundSurveillanceStation.cs`.*


## Class `FactionGoal_FoundSurveillanceStation`

```csharp
public class FactionGoal_FoundSurveillanceStation : FactionGoal_FoundStation
```

### Fields

| Name | Type |
|---|---|
| `fleetOperations` | public override List<Type> |
| `spaceOperations` | public override List<Type> |
| `spaceOps` | private static readonly List<Type> |
| `fleetOps` | public new static readonly List<Type> |

### Properties

- `public int tier`

### Methods

```csharp
public FactionGoal_FoundSurveillanceStation()
```

```csharp
public FactionGoal_FoundSurveillanceStation(TIFactionState faction, int importance, TIOrbitState orbit, GoalType defendGoal, int tier)
```

```csharp
public override bool IsDuplicate(TIFactionGoalState testGoal, TIGameState testTarget)
```

```csharp
public override bool ShouldDiscardGoal()
```

```csharp
public static FactionGoal_FoundSurveillanceStation CreateGoal(FactionGoal_FoundSurveillanceStation p)
```

```csharp
public static List<TIOrbitState> candidateOrbits(int tier)
```

```csharp
public override void RemoveState()
```

```csharp
public override bool RequiresFleet()
```

```csharp
public override ShipRole GetPrimaryShipRole()
```

```csharp
public override GoalType GetGoalType()
```

```csharp
public override float ComputeDesiredFleetCombatValue()
```

```csharp
public override IEnumerable<TIOrbitState> GetAlternativeOrbits()
```

```csharp
public override bool ReadyForTransferToTarget(TISpaceFleetState fleet)
```
