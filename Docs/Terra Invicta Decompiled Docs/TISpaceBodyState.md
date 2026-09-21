# TISpaceBodyState

*Decompiled from `PavonisInteractive/TerraInvicta/TISpaceBodyState.cs`.*


## Class `TISpaceBodyState`

```csharp
public class TISpaceBodyState : TINaturalSpaceObjectState
```

### Fields

| Name | Type |
|---|---|
| `isSpaceBodyState` | public override bool |
| `ref_spaceBody` | public override TISpaceBodyState |
| `ref_factions` | public override List<TIFactionState> |
| `ref_naturalSpaceObject` | public override TINaturalSpaceObjectState |
| `ref_spaceObject` | public override TISpaceObjectState |
| `semiMajorAxis_m` | public override double |
| `ecc` | public override double |
| `inclination_Rad` | public override double |
| `longAscendingNode_Rad` | public override double |
| `argPeriapsis_Rad` | public override double |
| `meanAnomalyAtEpoch_Rad` | public override double |
| `mapResource` | public virtual string |
| `mapScale` | public virtual double |
| `template` | public new TISpaceBodyTemplate |
| `irradiated` | public bool |
| `irradiatedMultiplier` | public float |
| `atmosphere` | public Atmosphere |
| `supportsAerocapture` | public override bool |
| `restrictsOrbitalBombardment` | public bool |
| `population` | public override ulong |
| `circumfrence_km` | public double |
| `modelResource` | public override string |
| `maxRadiusDimension_km` | public double |
| `maxRadiusDimension_m` | public double |
| `SpatialRotation` | public override Quaterniond |
| `rotationPeriod_Hours` | public double |
| `rotationperiod_s` | public double |
| `oblateness` | public double |
| `polarRadius_m` | public double |
| `polarRadius_km` | public double |
| `meanRadius_km` | public override double |
| `meanRadius_m` | public override double |
| `escapeVelocity_mps` | public double |
| `escapeVelocity_kps` | public double |
| `longestDimension_km` | public double |
| `longestDimension_m` | public double |
| `dimensionX_km` | public double |
| `dimensionY_km` | public double |
| `dimensionZ_km` | public double |
| `density_gcm3` | public double |
| `surfaceGravity_mps2` | public double |
| `surfaceGravity_g` | public double |
| `stationaryOrbitRadius_m` | public double |
| `tilt_Deg` | public float |
| `tiltSkew_Deg` | public float |
| `rotationOffset_Deg` | public float |
| `baseSortPosition` | public float |
| `getAsteroidResourceString` | public string |
| `iconResource` | public override string |
| `occupiedHabSites` | public List<TIHabSiteState> |
| `vacantHabSites` | public List<TIHabSiteState> |
| `AllNaturalSatellites` | public IEnumerable<TISpaceBodyState> |
| `SpaceBodiesInSystem` | public IEnumerable<TISpaceBodyState> |
| `OrbitsInSystem` | public IEnumerable<TIOrbitState> |
| `orbitsStar` | public bool |
| `canHaveMoons` | public bool |
| `surfaceBases` | public List<TIHabState> |
| `hasAvailableHabSites` | public bool |
| `interfaceOrbits` | public List<TIOrbitState> |
| `habs` | public override List<TIHabState> |
| `habsInSystem` | public override List<TIHabState> |
| `habSitesInSystem` | public List<TIHabSiteState> |
| `landedFleets` | public List<TISpaceFleetState> |
| `landedFleetsInSystem` | public List<TISpaceFleetState> |
| `fleetsInOrbitInSystem` | public List<TISpaceFleetState> |
| `fleetsInSystem` | public override List<TISpaceFleetState> |
| `fleetsInInterfaceOrbits` | public List<TISpaceFleetState> |
| `assetsInInterfaceOrbits` | public List<TISpaceAssetState> |
| `nations` | public List<TINationState> |
| `habSites` | public TIHabSiteState[] |
| `currentModelResource` | public string |
| `playerTag` | public PlayerTag |
| `naturalSatellites` | public List<TISpaceBodyState> |
| `lagrangePoints` | public List<TILagrangePointState> |
| `alienTerritory` | public bool |
| `north_pole_localized_coordinates_offset` | private Vector3 |
| `_semimajorAxis_m` | private double |
| `_ecc` | private double |
| `_inclination_Rad` | private double |
| `_longAscendingNode_Rad` | private double |
| `_argPeriapsis_Rad` | private double |
| `_meanAnomalyAtEpoch_Rad` | private double |
| `_rotationPeriod_Hours` | private double |
| `_meanRadius_m` | private double |
| `_meanRadius_km` | private double |
| `_polarRadius_m` | private double |
| `solarMultiplier` | public float |
| `solarMirrorBonus` | public Dictionary<TIFactionState, int> |
| `_escapeVelocityForMining_kps` | private double |

### Properties

- `public Quaterniond currentTilt`

### Methods

```csharp
public bool innerSystemAsteroid(bool includeSatellites)
```

```csharp
public bool innerMainBeltAsteroid(bool includeSatellites)
```

```csharp
public bool midMainBeltAsteroid(bool includeSatellites)
```

```csharp
public bool outerMainBeltAsteroid(bool includeSatellites)
```

```csharp
public bool centaur(bool includeSatellites)
```

```csharp
public bool kuiperBeltObject(bool includeSatellites)
```

```csharp
public override bool Colonized()
```

```csharp
public override bool Populous()
```

```csharp
public override void InitWithTemplate(TIDataTemplate template)
```

```csharp
public override void PostGameStateCreateInit_OnCreationOnly_1()
```

```csharp
public override void PostGlobalGameStateCreateInit_2()
```

```csharp
public override void PostInitializationInit_4()
```

```csharp
public Vector3d NorthPolePosition(TIDateTime time)
```

```csharp
public ValueTuple<Vector3, Vector3> GetForwardAndUp(TIDateTime time)
```

```csharp
private double GetRotationPeriod_Hours()
```

```csharp
private double GetPolarRadius_m()
```

```csharp
private double GetMeanRadius_km()
```

```csharp
public double relativeEnergyForMining(TIFactionState faction)
```

```csharp
public double escapeVelocityforMining_kps(TIFactionState faction)
```

```csharp
public string AtmosphereIconPath()
```

```csharp
public string AtmosphereDescription()
```

```csharp
public double DragVelocityPenaltyToReachOrbit_kps()
```

```csharp
public double DragDeltaVSavingsToLand_Frac(bool aerodynamic)
```

```csharp
public float LaserEffectivenessFactorThroughAtmo()
```

```csharp
public override double GetSurfaceRotation_Rad(TIDateTime time)
```

```csharp
public override double GetAngularDiameter(double distanceInMeters)
```

```csharp
public void ChangeSolarMirrorBonus(int changeBy, TIFactionState faction)
```

```csharp
public void ChangePlayerTag(PlayerTag newTag)
```

```csharp
public string GetMiningPotentialString()
```

```csharp
public void SetModelResource()
```

```csharp
public SiteProfileRating GetSiteProfileRating(FactionResource resource, bool prospected)
```

```csharp
public static string GetProfileRatingIconPath(SiteProfileRating rating, bool inline)
```

```csharp
public string GetProfileRatingIconPath(FactionResource resource, bool inline, bool prospected)
```

```csharp
public string GetProfileRatingAllIconsString(bool prospected)
```

```csharp
public TIHabSiteState GetHabSiteAtLocation(Vector2 coordinates)
```

```csharp
public TIHabSiteState GetHabSiteByName(string habSiteName)
```
