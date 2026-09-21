# FactionGoal_FixUpFleet

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_FixUpFleet.cs`.*


## Class `FactionGoal_FixUpFleet`

```csharp
public abstract class FactionGoal_FixUpFleet : FactionGoal_Fleet
```

### Fields

| Name | Type |
|---|---|
| `incompatibleGoals` | public override List<GoalType> |
| `fleetOperations` | public override List<Type> |
| `incompatibleFleetGoals` | private static readonly List<GoalType> |

### Properties

- `public TIHabState destination`

### Methods

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
public override bool RequiresFleet()
```

```csharp
public override List<TIFactionGoalState> BuildSubsequentGoals()
```

```csharp
public override float ComputeDesiredFleetCombatValue()
```

```csharp
public override float GetDesiredAssaultCombatValue()
```

```csharp
public override ShipRole GetPrimaryShipRole()
```

```csharp
public override Dictionary<ShipRole, float> GetSecondaryShipRoles()
```

```csharp
public override bool IsDuplicate(TIFactionGoalState testGoal, TIGameState testTarget)
```

```csharp
public override void ChangeTarget(TIGameState newTarget)
```

```csharp
public override bool NeedsShipsOrdered()
```
