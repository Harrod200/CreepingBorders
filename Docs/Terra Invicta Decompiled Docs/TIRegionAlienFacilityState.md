# TIRegionAlienFacilityState

*Decompiled from `PavonisInteractive/TerraInvicta/TIRegionAlienFacilityState.cs`.*


## Class `TIRegionAlienFacilityState`

```csharp
public class TIRegionAlienFacilityState : TIRegionAlienAssetState
```

### Fields

| Name | Type |
|---|---|
| `isRegionAlienFacility` | public override bool |
| `ref_alienFacility` | public override TIRegionAlienFacilityState |
| `maxHP` | private const int |
| `currentHP` | public float |

### Properties

- `public bool built`

### Methods

```csharp
public override bool Extant()
```

```csharp
public override string GetIconResourcePath(TIFactionState faction)
```

```csharp
public override string GetIllustrationPath(TIFactionState faction)
```

```csharp
public void InitWithRegionState(TIRegionState region)
```

```csharp
public override void PostInitializationInit_4()
```

```csharp
public void BuildFacility()
```

```csharp
public void SightedByFaction(TIFactionState council)
```

```csharp
public override float GetArmyAssaultDefenseScore()
```

```csharp
public override string ResolveAssault(TIGameState assaultingState, TIFactionState assaultingFaction, TIMissionOutcome outcome)
```

```csharp
public bool Bombed(TISpaceFleetState fleet, float damageValue)
```

```csharp
public void OnDestruction()
```

```csharp
public override List<CampaignMilestone> CampaignMilestonesGrantedOnCapture(TIFactionState capturingFaction, TIMissionOutcome outcome)
```
