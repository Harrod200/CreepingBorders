# FactionGoal_FoundHab

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_FoundHab.cs`.*


## Class `FactionGoal_FoundHab`

```csharp
public abstract class FactionGoal_FoundHab : FactionGoal_Space
```

### Fields

| Name | Type |
|---|---|
| `GrantMissionControlIndulgence` | public override bool |
| `specialModules` | protected List<TIHabModuleTemplate> |
| `requiredModuleNames` | public List<string> |
| `preferredShipRoles` | private static readonly Dictionary<ShipRole, float> |
| `hab` | private TIHabState |

### Properties

- `public bool setAsPrimaryHab`

### Methods

```csharp
public override bool RequiresFleet()
```

```csharp
public override TIGameState actor()
```

```csharp
public override bool InProgress()
```

```csharp
public override bool FoundHabGoal()
```

```csharp
public List<TIHabModuleTemplate> RequiredModules()
```

```csharp
public override bool NeedsShipsOrdered()
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

```csharp
public void SetHab(TIHabState hab)
```

```csharp
public override TIGameState goalProduct()
```

```csharp
public override bool GoalFulfilled()
```

```csharp
public override bool ShouldDiscardGoal()
```

```csharp
public override bool ShouldPauseGoal()
```

```csharp
public override bool LeaveMyFleetAlone()
```
