# TIStartTimeTemplate

*Decompiled from `TIStartTimeTemplate.cs`.*


## Class `TIStartTimeTemplate`

```csharp
public class TIStartTimeTemplate : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `year` | public int |
| `month` | public int |
| `day` | public int |
| `hour` | public int |
| `minute` | public int |
| `second` | public int |
| `bonusMoney` | public float |
| `bonusInfluence` | public float |
| `bonusOps` | public float |
| `bonusBoost` | public float |
| `bonusMissionControl` | public int |
| `bonusWater` | public float |
| `bonusVolatiles` | public float |
| `bonusMetals` | public float |
| `bonusNobles` | public float |
| `bonusFissiles` | public float |
| `bonusAntimatter` | public float |
| `bonusExotics` | public float |
| `initialCrashdownRegionTemplateName` | public string |
| `initialAtmosphericCO2_ppm` | public float |
| `initialAtmosphericCH4_ppm` | public float |
| `initialAtmosphericN2O_ppm` | public float |
| `initialStratosphericAerosols_ppm` | public float |
| `initialGlobalSeaLevelAnomaly_cm` | public float |
| `globalStartingGDPScaling` | public float |
| `distributeFactionlessHabsAndFleets` | public bool |
| `initialLooseNukes` | public int? |
| `startingTechs` | public string[] |
| `techTreeUIStarters` | public string[] |
| `globalTechsCompleted` | public List<string> |
| `projectsCompleted` | public List<string> |
| `startingShipDesigns` | public List<string> |
| `startingSurveyedSpaceBodies` | public List<string> |
| `startingAlienCouncilorFleets` | public List<string> |
| `orgGlobalResearchSensitivity` | public float |
| `orgGlobalGDPSensitivity` | public float |
| `populationRegressionPeriod_years` | public float |
| `alienSurveillanceDelay_years` | public float |
| `alienQuietDuration_years` | public float |
| `alienSetupDuration_years` | public float |
| `alienSetupStartIncome` | public float |
| `alienSetupEndIncome` | public float |
| `alienProgressionModifier` | public float |
| `alienStartingProgression_years` | public float |
| `scaleCPMaintenanceWithStartingGDP` | public bool |
| `scaleEconomyDefenseWithStartingGDP` | public bool |
| `GDPDefenseModifier` | public float |
| `CPMaintenanceModifier` | public float |
| `invasionFocusedAliens` | public bool |

### Methods

```csharp
public override TIGameState CreateGameState()
```

```csharp
public TIRegionState InitialCrashdownRegion()
```
