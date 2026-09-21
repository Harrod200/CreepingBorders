# TIRegionXenoformingState

*Decompiled from `PavonisInteractive/TerraInvicta/TIRegionXenoformingState.cs`.*


## Class `TIRegionXenoformingState`

```csharp
public class TIRegionXenoformingState : TIRegionAlienAssetState
```

### Fields

| Name | Type |
|---|---|
| `isRegionXenoformingState` | public override bool |
| `ref_xenoforming` | public override TIRegionXenoformingState |
| `severityDescription` | public string |
| `spawnArmyValue` | public static readonly float |
| `stage3Xenoforming` | public static readonly float |
| `stage2Xenoforming` | public static readonly float |
| `autodetectThreshold` | public static readonly float |
| `megafaunaSpawnCost` | public static readonly float |
| `spreadToAdjacentThreshold` | private int |

### Properties

- `public float xenoformingLevel`

### Methods

```csharp
public void InitWithRegionState(TIRegionState region)
```

```csharp
public override void PostInitializationInit_4()
```

```csharp
public override string GetIconResourcePath(TIFactionState faction)
```

```csharp
public override string GetIllustrationPath(TIFactionState faction)
```

```csharp
public override string GetDestroyedIllustrationPath()
```

```csharp
public void ChangeXenoformingLevel(float byValue)
```

```csharp
public void SetXenoformingLevel(float toValue)
```

```csharp
public override bool Extant()
```

```csharp
public void UpdateIntel(bool allowVanish)
```

```csharp
public void DailyXenoformingGrowth()
```

```csharp
public void SpawnMegafaunaArmy()
```

```csharp
public override bool VisibleToFaction(TIFactionState faction)
```

```csharp
public void SightedByFaction(TIFactionState faction, bool triggerVisualUpdate)
```

```csharp
public float AlienAttributeBonus()
```

```csharp
public override float GetArmyAssaultDefenseScore()
```

```csharp
public override string ResolveAssault(TIGameState assaultingState, TIFactionState assaultingfaction, TIMissionOutcome outcome)
```

```csharp
public override List<CampaignMilestone> CampaignMilestonesGrantedOnCapture(TIFactionState faction, TIMissionOutcome outcome)
```
