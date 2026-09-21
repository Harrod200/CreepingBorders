# TICommandTargetableTargeting

*Decompiled from `TICommandTargetableTargeting.cs`.*


## Class `TICommandTargetableTargeting`

```csharp
public class TICommandTargetableTargeting : TICommandTargeting
```

### Fields

| Name | Type |
|---|---|
| `ship` | private TISpaceShipState |
| `ships` | private List<TISpaceShipState> |
| `command` | private IShipCommandWithTarget |
| `fleetCommand` | private IFleetCommandWithTarget |
| `possibleTargets` | private new List<CombatTargetableState> |
| `fleetTargeting` | private bool |

### Methods

```csharp
public override List<Type> TargetedGameStates()
```

```csharp
public override void Initialize(TISpaceShipState ship, IShipCommandWithTarget command)
```

```csharp
public override void Initialize(List<TISpaceShipState> ships, IFleetCommandWithTarget command)
```

```csharp
private void CleanupListeners(CombatEnds e)
```

```csharp
private void CleanupListeners()
```

```csharp
private bool ValidShipTarget(CombatantShipController shipController, bool allIncludingFriendlies, bool onlyFriendlies)
```

```csharp
private bool ValidHabModuleTarget(CombatHabModuleController moduleController, bool allIncludingFriendlies, bool onlyFriendlies)
```

```csharp
private bool ValidTarget(CombatantController target)
```

```csharp
public new List<CombatTargetableState> GetPossibleTargets(bool includeFriendlies, bool onlyFriendlies)
```

```csharp
private void ValidTargetSelectedForTargeting(CombatTargetedableStateSelected e)
```
