# FactionGoal_AssembleFleet

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_AssembleFleet.cs`.*


## Class `FactionGoal_AssembleFleet`

```csharp
public class FactionGoal_AssembleFleet : FactionGoal_Fleet
```

### Fields

| Name | Type |
|---|---|
| `fleetOperations` | public override List<Type> |
| `incompatibleGoals` | public override List<GoalType> |
| `fleetOps` | public static readonly List<Type> |
| `preferredShipRoles` | private static readonly Dictionary<ShipRole, float> |

### Properties

- `public TISpaceGameState assemblyLocation`
- `public TISpaceGameState assemblyPermaLocation`
- `public float maxStrength`
- `public bool constructionOnly`

### Methods

```csharp
public FactionGoal_AssembleFleet()
```

```csharp
public FactionGoal_AssembleFleet(TIFactionState faction, int importance, TISpaceGameState assemblyLocation, float maxStrength = float.PositiveInfinity, bool constructionOnly = false)
```

```csharp
public static FactionGoal_AssembleFleet CreateGoal(FactionGoal_AssembleFleet p)
```

```csharp
private void SetPermaLocation()
```

```csharp
public override void RemoveState()
```

```csharp
public override GoalType GetGoalType()
```

```csharp
public override TIGameState actor()
```

```csharp
public override TIGameState target()
```

```csharp
public override TIGameState location()
```

```csharp
public override TIGameState goalProduct()
```

```csharp
public override bool ValidNewGoal()
```

```csharp
public override bool InProgress()
```

```csharp
public override bool ShouldDiscardGoal()
```

```csharp
public override bool GoalFulfilled()
```

```csharp
public override bool RequiresFleet()
```

```csharp
public override ShipRole GetPrimaryShipRole()
```

```csharp
public override float GetDesiredAssaultCombatValue()
```

```csharp
public override List<TIFactionGoalState> BuildSubsequentGoals()
```

```csharp
public override Dictionary<ShipRole, float> GetSecondaryShipRoles()
```

```csharp
public override void ChangeTarget(TIGameState newTarget)
```

```csharp
public override float ComputeDesiredFleetCombatValue()
```

```csharp
public override void DailyGoalMaintenance()
```
