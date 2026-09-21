# TIRegionUFOLandingState

*Decompiled from `PavonisInteractive/TerraInvicta/TIRegionUFOLandingState.cs`.*


## Class `TIRegionUFOLandingState`

```csharp
public class TIRegionUFOLandingState : TIRegionAlienAssetState
```

### Fields

| Name | Type |
|---|---|
| `isRegionLandedUFO` | public override bool |
| `ref_UFOLanding` | public override TIRegionUFOLandingState |
| `alienNation` | public TINationState |
| `deployArmyEvent` | public string |
| `expireLandingEvent` | public string |
| `deployingArmy` | private bool |
| `supportingArmyBuildup` | private bool |
| `maxHP` | private const float |
| `currentHP` | public float |

### Properties

- `public bool landingPresent`

### Methods

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
public override bool Extant()
```

```csharp
public void TriggerLanding(float overrideTime = -1f)
```

```csharp
public void OnAlienArmyDeployed(TimeEventStart e)
```

```csharp
public void CompleteArmyDeployment(TimeEventStart e)
```

```csharp
public void ExpireUFOLandingForAll()
```

```csharp
public override float GetArmyAssaultDefenseScore()
```

```csharp
public override string ResolveAssault(TIGameState assaultingState, TIFactionState assaultingFaction, TIMissionOutcome outcome)
```

```csharp
public bool Bombed(TISpaceFleetState bombingState, float damageValue)
```

```csharp
public override List<CampaignMilestone> CampaignMilestonesGrantedOnCapture(TIFactionState assaultingFaction, TIMissionOutcome outcome = TIMissionOutcome.Success)
```
