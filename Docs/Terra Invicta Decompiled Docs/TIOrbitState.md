# TIOrbitState

*Decompiled from `PavonisInteractive/TerraInvicta/TIOrbitState.cs`.*


## Class `TIOrbitState`

```csharp
public class TIOrbitState : TISpaceGameState, ITransferTarget
```

### Fields

| Name | Type |
|---|---|
| `isOrbitState` | public override bool |
| `ref_orbit` | public override TIOrbitState |
| `ref_spaceBody` | public override TISpaceBodyState |
| `ref_spaceObject` | public override TISpaceObjectState |
| `ref_naturalSpaceObject` | public override TINaturalSpaceObjectState |
| `ref_lagrangePoint` | public override TILagrangePointState |
| `hasMapObject` | public override bool |
| `inSpace` | public override bool |
| `template` | public virtual TIOrbitTemplate |
| `stationCapacity` | public virtual int |
| `irradiated` | public virtual bool |
| `altitude_m` | public double |
| `altitude_km` | public double |
| `eccentricity` | public virtual double |
| `inclination_Rad` | public virtual double |
| `longitudeAscendingNode_Rad` | public virtual double |
| `longitudePeriapsis` | public virtual double |
| `argPeriapsis_Rad` | public virtual double |
| `isAdHocOrbit` | public virtual bool |
| `irradiatedValue` | public float |
| `circumference_km` | public float |
| `fleetsInOrbit` | public List<TISpaceFleetState> |
| `stationsInOrbit` | public List<TIHabState> |
| `period_s` | public double |
| `antimatterPerMonth_dekatonnes` | public float |
| `localEscapeVelocity_mps` | public double |
| `localGravity_mps2` | public double |
| `localGravity_kps2` | public double |
| `localGravity_gs` | public double |
| `averageOrbitalVelocity_mps` | public double |
| `averageOrbitalVelocity_kps` | public double |
| `assetsInOrbit` | public List<TISpaceAssetState> |
| `pendingHabs` | public int |
| `destroyedAssets` | public int |
| `solarMultiplier` | public float |
| `interfaceOrbit` | public bool |
| `gameStateSubjectCreated` | private bool |
| `semiMajorAxis_km` | public double |
| `semiMajorAxis_m` | public double |
| `semiMajorAxis_AU` | public double |
| `isEarthLEO` | public bool |
| `alienTerritory` | public bool |

### Properties

- `public virtual float amat_ugpy`

### Methods

```csharp
public IEnumerable<TIEffectTemplate> GetExplorationEffectOptions()
```

```csharp
public double relevant_orbit_m(TINaturalSpaceObjectState commonBarycenter)
```

```csharp
public CartesianState relevantCartesianState(TINaturalSpaceObjectState commonBarycenter, TIDateTime dateTime, double meanAnomaly_Rad)
```

```csharp
public List<TISpaceFleetState> knownFleetsInOrbit(TIFactionState faction)
```

```csharp
public override void InitWithTemplate(TIDataTemplate rawTemplate)
```

```csharp
public override void PostGlobalGameStateCreateInit_2()
```

```csharp
public override void PostAllStartUpInit_5()
```

```csharp
public void AssignToBarycenter()
```

```csharp
public TINaturalSpaceObjectState FindCommonBarycenter(TIOrbitState orbit)
```

```csharp
public TINaturalSpaceObjectState FindCommonBarycenter(TISpaceObjectState spaceObject)
```

```csharp
public void MarkPendingHab()
```

```csharp
public void FoundHab()
```

```csharp
public Vector3d GetGlobalPositionAtTimeAndAnomaly(TIDateTime time, double meanAnomalyAtEpoch_deg)
```

```csharp
public double OffsetToAnomaly_Rad(double desiredOffset_km)
```

```csharp
public double TestAndCorrectAnomalyToAvoidOverlap(TISpaceAssetState assetToCheck, double proposedAnomaly_Rad, bool docking, bool extraDistance = false)
```

```csharp
public Orbit ToOrbit(TIDateTime epoch, double meanAnomalyAtEpoch_Rad)
```

```csharp
public OrbitalElementsState ToOrbitalElementsState(TIDateTime epoch, double meanAnomalyAtEpoch_Rad)
```

```csharp
public bool NewStationAllowed(int tier = 0, TIFactionState faction = null)
```

```csharp
public double DeltaVToReachFromSurface_kps(float latitude_deg)
```

```csharp
public double DeltaVToReachFromSurface_kps(float latitude_deg, double fleetAcceleration_mps2)
```

```csharp
public bool tryToGetLocalCartesianState(TIDateTime time, out CartesianState cartesianState, out TINaturalSpaceObjectState barycenter)
```

```csharp
public TINaturalSpaceObjectState localBarycenter(TIDateTime time)
```

```csharp
public void getOrbitalElementsState(TIDateTime time, out OrbitalElementsState orbitalElementsState, out TINaturalSpaceObjectState barycenter, out bool meanAnomalyIsGood)
```

```csharp
public void DestroyedAssetsChange(int change)
```

```csharp
public bool OrbitOfInterest(TIFactionState faction, int filter)
```

```csharp
public int OrbitInterestLevel(TIFactionState faction)
```

```csharp
public static string OrbitTooltip(TIOrbitState orbit)
```
