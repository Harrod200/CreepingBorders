# OrbitalElementsState

*Decompiled from `PavonisInteractive/TerraInvicta/OrbitalElementsState.cs`.*


## Struct `OrbitalElementsState`

```csharp
public struct OrbitalElementsState
```

### Fields

| Name | Type |
|---|---|
| `normalVector` | public Vector3d |
| `ascendingNodeVector` | public Vector3d |
| `periapsisVector` | public Vector3d |
| `eccentricVector` | public Vector3d |
| `periapsis_m` | public double |
| `apoapsis_m` | public double |
| `epoch` | public DateTime |
| `longAscendingNode_Rad` | public double |
| `argPeriapsis_Rad` | public double |
| `inclination_Rad` | public double |
| `semiMajorAxis_m` | public double |
| `eccentricity` | public double |
| `meanAnomalyAtEpoch_Rad` | public double |

### Methods

```csharp
public OrbitalElementsState(double longAscendingNode_Rad, double argPeriapsis_Rad, double inclination_Rad, double semiMajorAxis_m, double ecc, double meanAnomalyAtEpoch_Rad, DateTime epoch)
```

```csharp
public OrbitalElementsState(double longAscendingNode_Rad, double argPeriapsis_Rad, double inclination_Rad, double semiMajorAxis_m, double ecc, double meanAnomalyAtEpoch_Rad, TIDateTime epoch)
```

```csharp
public OrbitalElementsState(OrbitalElementsState orbit)
```

```csharp
public OrbitalElementsState(OrbitalElementsState orbit, double meanAnomalyAtEpoch_Rad, TIDateTime epoch)
```

```csharp
public OrbitalElementsState(Orbit orbit)
```

```csharp
public OrbitalElementsState(ITransferTarget target, double meanAnomalyAtEpoch_Rad, TIDateTime epoch)
```

```csharp
public OrbitalElementsState(TIOrbitState orbit, double meanAnomalyAtEpoch_Rad, DateTime epoch)
```

```csharp
public OrbitalElementsState(TISpaceObjectState spaceObject)
```

```csharp
public OrbitalElementsState(TISpaceFleetState fleet)
```

```csharp
public OrbitalElementsState(IMobileAsset fleet)
```

```csharp
public double MeanAnomalyAtTime_Rad(DateTime time, double barycenterMass_kg)
```

```csharp
public double MeanLongitudeAtTime_Rad(DateTime time, double barycenterMass_kg)
```

```csharp
public double TrueAnomalyAtTime_Rad(DateTime time, double barycenterMass_kg)
```

```csharp
public DateTime NextTimeAtMeanAnomaly(double meanAnomaly_rad, DateTime earliestTime, double barycenterMass_kg)
```

```csharp
public DateTime PreviousTimeAtMeanAnomaly(double meanAnomaly_rad, DateTime latestTime, double barycenterMass_kg)
```

```csharp
private DateTime TimeAtMeanAnomaly_Hyperbola(double meanAnomaly_rad, double barycenterMass_kg)
```

```csharp
public CartesianState ToCartesianStateAtTime(DateTime time, double barycenterMass_kg)
```

```csharp
public CartesianState ToCartesianStateAtMeanAnomaly(double meanAnomaly_Rad, double barycenterMass_kg)
```

```csharp
public double GetTrueAnomalyFromEccentricAnomaly(double eccentricAnomaly_Rad)
```

```csharp
public double GetEccentricAnomalyFromTrueAnomaly(double trueAnomaly_Rad)
```

```csharp
public double GetEccentricAnomalyFromMeanAnomaly(double meanAnomaly_Rad)
```

```csharp
public double OrbitalPeriod(double barycenterMass_kg)
```

```csharp
private void AnglesToCartesianState(double omega, double u, double i, out Vector3d position, out Vector3d velocity)
```

```csharp
private Vector3d GetOrbitNormalVector()
```

```csharp
private Vector3d AscendingNodeDirection()
```

```csharp
private Vector3d PeriapsisPosition()
```

```csharp
public Vector3d PeriapsisDirection()
```

```csharp
public bool Approximately(OrbitalElementsState b, double barycenterMass_kg = 0.0)
```

```csharp
public double MeanAnomalyWhenClosestToVelocity_Rad(Vector3d localVelocity_mps)
```

```csharp
public double MeanAnomalyWhenClosestToPosition_Rad(Vector3d localPosition_m)
```

```csharp
public double GetMeanAnomalyFromEccentricAnomaly(double eccentricAnomaly_Rad)
```
