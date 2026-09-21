# TIAlienArmyState

*Decompiled from `PavonisInteractive/TerraInvicta/TIAlienArmyState.cs`.*


## Class `TIAlienArmyState`

```csharp
public class TIAlienArmyState : TIArmyState
```

### Fields

| Name | Type |
|---|---|
| `techLevel` | public override float |
| `CanTakeOffensiveAction` | public override bool |
| `adjustedTechLevel` | public override float |
| `homeNation` | public override TINationState |
| `investmentArmyFactor` | public override float |
| `investmentNavyFactor` | public override float |
| `AnimatorResource` | public override string |
| `FightingSpriteSheet` | public override string |
| `MovingSpriteSheet` | public override string |
| `GetIconForegroundResource` | public override string |
| `HumanArmy` | public override bool |
| `AlienRegularArmy` | public override bool |
| `ref_alienArmyState` | public override TIAlienArmyState |
| `ref_controlPoint` | public override TIControlPoint |
| `dailyHealRate` | public override float |
| `spawning` | public bool |

### Methods

```csharp
public override bool LegalRegion(TIRegionState region)
```

```csharp
public override bool CanHeal()
```

```csharp
public override string GetModelResource()
```

```csharp
public override Sprite GetTransportIcon()
```

```csharp
public override Sprite GetForegroundIcon()
```

```csharp
public void SpawnArmy(TIRegionState startingRegion)
```

```csharp
public override bool OccupyingRegion(bool includeLiberating = false)
```
