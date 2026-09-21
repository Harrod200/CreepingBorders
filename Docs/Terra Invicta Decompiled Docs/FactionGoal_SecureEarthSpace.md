# FactionGoal_SecureEarthSpace

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_SecureEarthSpace.cs`.*


## Class `FactionGoal_SecureEarthSpace`

```csharp
public class FactionGoal_SecureEarthSpace : FactionGoal_DefendWithFleet
```

### Fields

| Name | Type |
|---|---|
| `preferredRoles` | private static readonly Dictionary<ShipRole, float> |

### Methods

```csharp
public FactionGoal_SecureEarthSpace()
```

```csharp
public FactionGoal_SecureEarthSpace(TIFactionState faction, int importance)
```

```csharp
public static FactionGoal_SecureEarthSpace CreateGoal(FactionGoal_SecureEarthSpace p)
```

```csharp
public override GoalType GetGoalType()
```

```csharp
public override bool ShouldDiscardGoal()
```

```csharp
public override bool IsDuplicate(TIFactionGoalState testGoal, TIGameState testTarget)
```

```csharp
public override void ChangeTarget(TIGameState newTarget)
```

```csharp
public override float ComputeDesiredFleetCombatValue()
```

```csharp
public override float GetMaximumFleetCombatValueRatio()
```

```csharp
public override Dictionary<ShipRole, float> GetSecondaryShipRoles()
```
