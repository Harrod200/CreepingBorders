# TISpaceBodyTemplate

*Decompiled from `TISpaceBodyTemplate.cs`.*


## Class `TISpaceBodyTemplate`

```csharp
public class TISpaceBodyTemplate : TINaturalSpaceObjectTemplate
```

### Fields

| Name | Type |
|---|---|
| `bodyAltName` | public string |
| `classification` | public string |
| `descriptor1` | public string |
| `descriptor2` | public string |
| `discovery_Year` | public string |
| `MapResource` | public string |
| `MapScale` | public float |
| `irradiated` | public bool |
| `equatorialRadius_km` | public double? |
| `meanRadius_km` | public double? |
| `dimensionX_km` | public double? |
| `dimensionY_km` | public double? |
| `dimensionZ_km` | public double? |
| `oblateness` | public float? |
| `tilt_Deg` | public float? |
| `tiltSkew_Deg` | public float? |
| `density_gcm3` | public double? |
| `rotationPeriod_strHours` | public string |
| `rotationOffset_Deg` | public float? |
| `fabricatedData` | public string |
| `min_periapsis_altitude_km` | public double? |
| `irradiatedMultiplier` | public float |
| `atmosphere` | public Atmosphere |
| `mapResource` | public string |
| `mapScale` | public float? |
| `numAltModels` | public int |
| `altModels` | public List<AltSpaceBodyModel> |
| `angularDiameterMultiplier` | public float |
| `atmosphereScaleHeight_km` | public double |
| `atmosphereSurfaceDensity_kgpm3` | public double |
| `habSites` | public List<string> |

### Methods

```csharp
public override TIGameState CreateGameState()
```
