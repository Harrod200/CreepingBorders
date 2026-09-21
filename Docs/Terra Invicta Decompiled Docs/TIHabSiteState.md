# TIHabSiteState

*Decompiled from `PavonisInteractive/TerraInvicta/TIHabSiteState.cs`.*


## Class `TIHabSiteState`

```csharp
public class TIHabSiteState : TISpaceGameState
```

### Fields

| Name | Type |
|---|---|
| `isHabSiteState` | public override bool |
| `searchable` | public override Searchable |
| `ref_faction` | public override TIFactionState |
| `ref_factions` | public override List<TIFactionState> |
| `ref_hab` | public override TIHabState |
| `ref_spaceBody` | public override TISpaceBodyState |
| `ref_habSite` | public override TIHabSiteState |
| `ref_spaceObject` | public override TISpaceObjectState |
| `ref_naturalSpaceObject` | public override TINaturalSpaceObjectState |
| `hasMapObject` | public override bool |
| `inSpace` | public override bool |
| `detailDisplayName` | public string |
| `hasOperatingBase` | public bool |
| `hasPlannedOrOperatingBase` | public bool |
| `surfaceGravity_g` | public double |
| `surfaceGravity_mps2` | public double |
| `template` | public TIHabSiteTemplate |
| `irradiated` | public bool |
| `irradiatedValue` | public float |
| `rotationalVelocity_kps` | public double |
| `maxTier` | public int |
| `radius_gameUnits` | public float |
| `numIncomes` | public int |
| `parentBody` | public TISpaceBodyState |
| `hab` | public TIHabState |
| `landedFleets` | public List<TISpaceFleetState> |
| `water_day` | public float |
| `volatiles_day` | public float |
| `metals_day` | public float |
| `nobles_day` | public float |
| `fissiles_day` | public float |
| `latitude` | public float |
| `longitude` | public float |
| `pendingHab` | public bool |
| `gameStateSubjectCreated` | private bool |
| `controller` | private HabSiteController |
| `solarMultiplier` | public float |
| `localized_coordinates_offset` | private Vector3 |
| `positionOffsetDueToIrregularBody` | public Vector3d |
| `Statistics` | public static class |
| `ExpectedSpaceResourcesPerMonth` | public static Dictionary<TIHabSiteState, Dictionary<FactionResource, float>> |
| `SpaceResourcesPerMonth_Mean` | public static Dictionary<FactionResource, float> |
| `SpaceResourcesPerMonth_StandardDeviation` | public static Dictionary<FactionResource, float> |
| `SpaceResourceGrade` | public enum |

### Properties

- `public TIMiningProfileTemplate miningProfile`

### Methods

```csharp
public double MinDeltaVToLaunch_kps(float acceleration_mps2)
```

```csharp
public HabSiteController GetController()
```

```csharp
public override void InitWithTemplate(TIDataTemplate rawTemplate)
```

```csharp
public void SetController(HabSiteController controller)
```

```csharp
public override void PostGlobalGameStateCreateInit_2()
```

```csharp
public Vector3d GlobalPosition(TIDateTime time)
```

```csharp
public double DeltaVToLandFromInterface_kps(TIOrbitState orbit, double fleetAcceleration_mps2, bool generic, bool aerodynamic)
```

```csharp
public void MarkPendingHab()
```

```csharp
public void FoundHab()
```

```csharp
public float GetDailyProduction(FactionResource resource)
```

```csharp
public IEnumerable<FactionResource> PrimaryResources()
```

```csharp
public float GetMonthlyProduction(FactionResource resource)
```

```csharp
public string ProductivityString(bool probed)
```

```csharp
public float GetHabSiteMinProductivity_day(FactionResource resource)
```

```csharp
public float GetHabSiteMinProductivity_month(FactionResource resource)
```

```csharp
public float GetHabSiteMaxProductivity_day(FactionResource resource)
```

```csharp
public float GetHabSiteMaxProductivity_month(FactionResource resource)
```

```csharp
public float GetHabSiteExpectedProductivity_day(FactionResource resource)
```

```csharp
public float GetHabSiteExpectedProductivity_month(FactionResource resource)
```

```csharp
public TIHabSiteState.Statistics.SpaceResourceGrade GetExpectedResourceGrade(FactionResource resource)
```

```csharp
public TIHabSiteState.Statistics.SpaceResourceGrade GetActualResourceGrade(FactionResource resource)
```

```csharp
private bool Nothing(float mean, float width, float min, float jump)
```

```csharp
private float ModifyBaseValueForConditions(float baseValue, bool densitySensitive)
```

```csharp
private float ModifyWidthValueFromSettings(float baseValue, float jump)
```

```csharp
private float SetDailyOutputValue(float mean, float width, float min, float jump, bool densistySensitive)
```

```csharp
public Dictionary<FactionResource, float> SampleProductivityPerDay()
```

```csharp
private void RandomizeSiteMiningData()
```

```csharp
public void ModifySiteMiningData(float modifier)
```

```csharp
public void LandFleet(TISpaceFleetState fleet)
```

```csharp
public void LaunchFleet(TISpaceFleetState fleet)
```

```csharp
public List<TIHabSiteState> AdjacentSites()
```

```csharp
public static TIHabSiteState.Statistics.SpaceResourceGrade GetResourceGrade(FactionResource resource, float incomePerMonth)
```

```csharp
public static void Recalculate()
```
