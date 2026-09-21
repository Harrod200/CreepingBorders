# TIMegafaunaArmyState

*Decompiled from `PavonisInteractive/TerraInvicta/TIMegafaunaArmyState.cs`.*


## Class `TIMegafaunaArmyState`

```csharp
public class TIMegafaunaArmyState : TIArmyState
```

### Fields

| Name | Type |
|---|---|
| `techLevel` | public override float |
| `InFriendlyRegion` | public override bool |
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
| `AlienMegafaunaArmy` | public override bool |
| `ref_megafaunaArmyState` | public override TIMegafaunaArmyState |
| `ref_controlPoint` | public override TIControlPoint |
| `dailyHealRate` | public override float |
| `bonusTechLevel` | public float |
| `BASE_MEGAFAUNA_TECH_LEVEL` | private const float |
| `MILTECH_BONUS_ON_MERGE` | public const float |
| `MEGAFAUNA_HEALING_FACTOR` | private const float |

### Methods

```csharp
public void SpawnArmy(TIRegionState startingRegion)
```

```csharp
public override bool IsAttacking()
```

```csharp
public override bool LegalRegion(TIRegionState region)
```

```csharp
public override bool OccupyingRegion(bool includeLiberation)
```

```csharp
public override bool InBattleWithArmies()
```

```csharp
public override bool CanHeal()
```

```csharp
public override Sprite GetForegroundIcon()
```

```csharp
public override string GetModelResource()
```

```csharp
public bool CanHealInRegion(TIRegionState region)
```

```csharp
public void MergeWithOtherXenofauna(TIMegafaunaArmyState armyToMergeWith)
```

```csharp
public bool AI_DesiredRegion(TIRegionState region)
```

```csharp
public override void EngageLocalForcesAndOccupy(bool regionReturnFireOnly = false)
```
