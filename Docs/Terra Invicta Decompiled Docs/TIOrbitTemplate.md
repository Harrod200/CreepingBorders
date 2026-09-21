# TIOrbitTemplate

*Decompiled from `TIOrbitTemplate.cs`.*


## Class `TIOrbitTemplate`

```csharp
public class TIOrbitTemplate : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `Eccentricity` | public double |
| `Inclination_Rad` | public double |
| `LongitudeAscendingNode_Rad` | public double |
| `ArgPeriapsis_Rad` | public double |
| `LongitudePeriapsis` | public double |
| `irradiated` | public bool |
| `barycenterTemplate` | public TINaturalSpaceObjectTemplate |
| `barycenter` | public TINaturalSpaceObjectState |
| `randomSemiMajorAxisRangeValue_km` | public float |
| `randomInclinationRangeValue_Deg` | public float |
| `randomAnomaly_Rad` | public double |
| `SemiMajorAxis_m` | public double |
| `SemiMajorAxis_km` | public double |
| `SemiMajorAxis_AU` | public double |
| `Altitude_km` | public double |
| `abbreviation` | public string |
| `description` | public string |
| `barycenterName` | public string |
| `semiMajorAxis_AU` | public double? |
| `semiMajorAxis_km` | public double? |
| `altitude_km` | public double? |
| `earthLEO` | public bool |
| `synch` | public bool |
| `semiMajorAxisRange_km` | public float |
| `eccentricity` | public double? |
| `inclination_Deg` | public double? |
| `inclinationRange_Deg` | public float |
| `longAscendingNode_Deg` | public double |
| `argPeriapsis_Deg` | public double |
| `irradiatedMultiplier` | public float |
| `interfaceOrbit` | public bool |
| `radialOrbit` | public bool |
| `stationCapacity` | public int |
| `amat_ugpy` | public float |
| `effectToExplore` | public string |
| `_semimajorAxis_m` | private double |
| `tooClose` | private const float |

### Methods

```csharp
public override TIGameState CreateGameState()
```

```csharp
public OrbitalElementsState Generate(bool allowRandoms = true, bool assignRandomAnomaly = true)
```

```csharp
public OrbitalElementsState Generate(bool allowRandoms, double meanAnomalyAtEpoch_Rad, TIDateTime epoch)
```
