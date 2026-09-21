# TISpaceObjectState

*Decompiled from `PavonisInteractive/TerraInvicta/TISpaceObjectState.cs`.*


## Class `TISpaceObjectState`

```csharp
public abstract class TISpaceObjectState : TISpaceGameState, IGameStateVisualizer
```

### Fields

| Name | Type |
|---|---|
| `isSpaceObjectState` | public override bool |
| `ref_spaceObject` | public override TISpaceObjectState |
| `hasMapObject` | public override bool |
| `inSpace` | public override bool |
| `template` | public TISpaceObjectTemplate |
| `activePlayerDisplayName` | public string |
| `modelResource` | public virtual string |
| `modelScale` | public virtual float |
| `mass_kg` | public virtual double |
| `mass_EarthMasses` | public double |
| `mu` | public double |
| `objectType` | public virtual SpaceObjectType |
| `iconResource` | public virtual string |
| `meanRadius_km` | public virtual double |
| `meanRadius_m` | public virtual double |
| `semiMajorAxis_m` | public virtual double |
| `semiMajorAxis_km` | public double |
| `semiMajorAxis_AU` | public double |
| `ecc` | public virtual double |
| `inclination_Rad` | public virtual double |
| `longAscendingNode_Rad` | public virtual double |
| `argPeriapsis_Rad` | public virtual double |
| `meanAnomalyAtEpoch_Rad` | public virtual double |
| `meanLongitude_Rad` | public virtual double |
| `orbitalPeriod_s` | public virtual double |
| `orbitalPeriod_Hours` | public double |
| `orbitalPeriod_Days` | public double |
| `orbitalPeriod_Years` | public double |
| `meanVelocity_mps` | public double |
| `velocity_mps` | public double |
| `apsidalPrecession_Years` | public double |
| `nodalPrecession_Years` | public double |
| `epoch_JYears` | public virtual double |
| `SpatialRotation` | public virtual Quaterniond |
| `longitude` | public float |
| `gameObjectLink` | public GameObject |
| `DisplayPositionNow` | public Vector3 |
| `radius_gameUnits` | public float |
| `inEarthSystem` | public virtual bool |
| `icon` | public Sprite |
| `isEarth` | public bool |
| `isLuna` | public bool |
| `isSun` | public bool |
| `isaMoon` | public bool |
| `periapsis_AU` | public double |
| `apoapsis_AU` | public double |
| `periapsis_km` | public double |
| `apoapsis_km` | public double |
| `meanMotion_s` | public double |
| `GetSunOrbitingRelatedObject` | public virtual TISpaceObjectState |
| `_rnd_rotationOffset_Deg` | protected double? |
| `globalPosition` | protected Vector3d |
| `globalPositionTime` | protected DateTime |
| `gameTime` | protected GameTimeManager |
| `_icon` | protected Sprite |
| `symbolResource` | public const string |
| `GenericTransferEV_kps` | public const float |
| `HabClassification` | public enum |

### Properties

- `public TIDateTime epoch_DateTime`
- `public SpaceObjectController controller`

### Methods

```csharp
public double meanAnomaly_Rad(TIDateTime time)
```

```csharp
public double meanLongitudeAtTime_Rad(TIDateTime time)
```

```csharp
public virtual double GetSurfaceRotation_Rad(TIDateTime time)
```

```csharp
public virtual Color GetSymbolColor()
```

```csharp
public override void InitWithTemplate(TIDataTemplate template)
```

```csharp
public override void PostGameStateCreateInit_OnCreationOnly_1()
```

```csharp
public virtual void CreateVisualizer(TIDataTemplate myTemplate)
```

```csharp
public virtual CartesianState ToLocalCartesianStateAtTime(TIDateTime time)
```

```csharp
public virtual CartesianState ToGlobalCartesianStateAtTime(TIDateTime time)
```

```csharp
public virtual Vector3d GetGlobalPosition()
```

```csharp
public virtual Vector3d GetGlobalPositionAtTime(TIDateTime time)
```

```csharp
public Vector3d GetVelocityVectorAtTime(TIDateTime time)
```

```csharp
public double GetVelocityAtTime(TIDateTime time)
```

```csharp
public virtual double GetAngularDiameter(double distanceInMeters)
```

```csharp
public double GetAngularDiameter(Vector3d viewingPosition)
```

```csharp
public double GetAngularDiameter()
```

```csharp
protected virtual OrbitalElementsState ToOrbitalElementsState(TIDateTime time = null)
```

```csharp
private DateTime TimeAtMeanAnomaly(double meanAnomaly, DateTime time)
```

```csharp
private double MeanAnomalyAtTime(DateTime time)
```

```csharp
public DateTime NextPeriapsisTime(DateTime time)
```

```csharp
private double TrueToEccentric(double trueAnomaly)
```

```csharp
private double EccentricToMean(double E)
```

```csharp
public DateTime TimeOfTrueAnomaly(double trueAnomaly, DateTime time)
```

```csharp
public double TrueAnomalyFromVector(Vector3d v)
```

```csharp
public static double TransferDistance(IMobileAsset fleet, TIGameState destination, ITransferTarget originValue, ITransferTarget destinationValue, bool generic)
```

```csharp
public static double MaxDistanceBetweenTwoSpaceObjects_m(TISpaceObjectState object1, TISpaceObjectState object2)
```

```csharp
public static double MinDistanceBetweenTwoSpaceObjects_m(TISpaceObjectState object1, TISpaceObjectState object2)
```

```csharp
public static double MinDistanceBetweenTwoSpaceObjects_m(TISpaceFleetState object1, TISpaceObjectState object2)
```

```csharp
public static double MinDistanceBetweenTwoSpaceObjects_m(IMobileAsset object1, TISpaceObjectState object2)
```

```csharp
public static double AverageDistanceBetweenTwoSpaceObjects_m(TISpaceObjectState object1, TISpaceObjectState object2)
```

```csharp
public static double ExactDistanceBetweenTwoSpaceObjects_m(TISpaceFleetState object1, TISpaceObjectState object2)
```

```csharp
public static double ExactDistanceBetweenTwoSpaceObjects_m(TISpaceObjectState object1, TISpaceObjectState object2)
```

```csharp
public static double ExactDistanceBetweenTwoSpaceObjects_m(IMobileAsset object1, TISpaceObjectState object2)
```

```csharp
public static TINaturalSpaceObjectState FindCommonBarycenter(TISpaceObjectState firstObject, TIGameState secondObject)
```

```csharp
public static bool IsAroundBarycenter(TISpaceObjectState firstObject, TINaturalSpaceObjectState barycenter)
```

```csharp
public TINaturalSpaceObjectState FindCommonBarycenter(TIGameState secondSpaceObject)
```

```csharp
public static void FindRelevantOrbitingObjectsForTransfer(TISpaceAssetState asset, TIGameState destination, out TINaturalSpaceObjectState commonBarycenter, out ITransferTarget itt_origin, out ITransferTarget itt_destination)
```

```csharp
public static TISpaceObjectState GetSunOrbitingRelatedObject_static(TISpaceObjectState testObject)
```

```csharp
public static double genericSynodicPeriod_s(TIGameState origin, TIGameState destination, out bool isRetrograde)
```

```csharp
protected static double MeanLongitudeBetweenTwoSpaceObjects_deg(TINaturalSpaceObjectState origin, TINaturalSpaceObjectState destination, TIDateTime time)
```

```csharp
protected static double AngleBetweenTwoSpaceObjects_deg(TINaturalSpaceObjectState origin, TINaturalSpaceObjectState destination, TIDateTime time)
```

```csharp
protected static double HohmannTransferTime_s(TIFactionState faction, GenericSpaceObject origin, GenericSpaceObject destination)
```

```csharp
public static double GetHohmannTimePenaltyFraction(TIFactionState faction, TIDateTime nextHohmann, double synodicPeriod_s, out bool penaltyFromPrior)
```

```csharp
public static double GenericTransferTime_s(TIFactionState faction, TIGameState origin, TIGameState destination)
```

```csharp
private static double LagrangeTransferDuration_s(TINaturalSpaceObjectState transferBarycenter, double radius_m, double angle_Deg)
```

```csharp
private static double GenericTransferDeltaV_mps(GenericSpaceObject origin, GenericSpaceObject destination, bool ignoreInclinationChange = false)
```

```csharp
public static double GenericTransferDeltaV_mps(TIGameState origin, TIGameState destination, bool ignoreInclinationChange = false)
```

```csharp
public static float ModifiedGenericTransferEV_kps(TIFactionState faction)
```

```csharp
public static double GenericTransferBoostFromEarthSurface(TIFactionState faction, TIGameState destination, float mass_tons)
```

```csharp
private static double GenericTransferDeltaVFromEarthLEO_mps(TIFactionState faction, TIGameState destination, bool ignoreInclinationChange = false)
```

```csharp
private static double GenericTransferDeltaVFromEarthLEO_kps(TIFactionState faction, TIGameState destination, bool ignoreInclinationChange = false)
```

```csharp
public static float GenericTransferTime_d(TIFactionState faction, TIGameState origin, TIGameState destination)
```

```csharp
public static float GenericTransferTimeFromEarthsSurface_d(TIFactionState faction, TIGameState destination)
```

```csharp
public static double GenericTransferTimeFromNearestHab_d(TIFactionState faction, TIGameState destination, TISpaceObjectState.HabClassification habClassification, out TIHabState nearestHab)
```
