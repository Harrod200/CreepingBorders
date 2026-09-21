# FactionGoal_ProspectSites

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_ProspectSites.cs`.*


## Class `FactionGoal_ProspectSites`

```csharp
public class FactionGoal_ProspectSites : FactionGoal_Space
```

### Fields

| Name | Type |
|---|---|
| `fleetOperations` | public override List<Type> |
| `spaceOperations` | public override List<Type> |
| `incompatibleGoals` | public override List<GoalType> |
| `preferredShipRoles` | private static readonly Dictionary<ShipRole, float> |

### Properties

- `public bool requireFleet`
- `public TISpaceBodyState targetSpaceBody`
- `public GoalType buildBaseGoal`
- `public GoalType buildStationGoal`
- `private static readonly List<Type> fleetOps = new List<Type>(FactionGoal_Fleet.coreFleetOpsList)`
- `private static readonly List<Type> spaceOps = new List<Type>`

### Methods

```csharp
public FactionGoal_ProspectSites()
```

```csharp
public FactionGoal_ProspectSites(TIFactionState faction, int importance, TISpaceBodyState targetSpaceBody, bool requireFleet, GoalType foundBaseGoal, GoalType buildBaseGoal, GoalType buildStationGoal)
```

```csharp
public static FactionGoal_ProspectSites CreateGoal(FactionGoal_ProspectSites p)
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
public override bool RequiresFleet()
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
public override void ChangeTarget(TIGameState newTarget)
```

```csharp
public override List<TIFactionGoalState> BuildSubsequentGoals()
```

```csharp
public override ShipRole GetPrimaryShipRole()
```

```csharp
public override Dictionary<ShipRole, float> GetSecondaryShipRoles()
```

```csharp
public override float GetDesiredAssaultCombatValue()
```
