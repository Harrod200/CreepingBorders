# OrbitExtensions

*Decompiled from `PavonisInteractive/TerraInvicta/OrbitExtensions.cs`.*


## Class `OrbitExtensions`

```csharp
public static class OrbitExtensions
```

### Fields

| Name | Type |
|---|---|
| `s_orbitIntensity` | private static float |
| `s_defaultOrbitMaterial` | private static Material |
| `s_orbitColor` | private static readonly Dictionary<SpaceObjectType, Color> |

### Methods

```csharp
public static Orbit Fill(this Orbit orbit, bool noElements = false)
```

```csharp
public static Orbit FillOrbitTrail(this Orbit orbit, TISpaceObjectState spaceObject, out GameObject orbitTrailObject)
```

```csharp
public static Orbit FillTransferOrbit(this Orbit orbit, IMobileAsset fleet, Trajectory trajectory, out GameObject orbitTrailObject)
```

```csharp
public static double SynodicPeriod(this Orbit a, Orbit b)
```

```csharp
public static Orbit PerturbedOrbit(this Orbit orbit, DateTime time, Vector3d deltaV, out OrbitalElementsState newOrbit)
```

```csharp
public static Vector3d Position(this Orbit orbit, DateTime time)
```

```csharp
public static Vector3d LocalPosition(this Orbit orbit, DateTime time)
```

```csharp
public static CartesianState LocalCartesianState(this Orbit orbit, DateTime time)
```

```csharp
public static CartesianState CartesianState(this Orbit orbit, DateTime time)
```

```csharp
public static DateTime TimeOfTrueAnomaly(this Orbit orbit, double trueAnomaly, DateTime time)
```

```csharp
public static double TrueAnomalyFromVector(this Orbit orbit, Vector3d v)
```

```csharp
public static double RadiusAtTrueAnomaly(this Orbit orbit, double t)
```

```csharp
public static DateTime NextPeriapsisTime(this Orbit orbit, DateTime time)
```

```csharp
public static DateTime PrevPeriapsisTime(this Orbit orbit, DateTime time)
```

```csharp
public static DateTime NextApoapsisTime(this Orbit orbit, DateTime time)
```

```csharp
public static Vector3d ApoapsisPosition(this Orbit orbit)
```

```csharp
public static Vector3d PeriapsisPosition(this Orbit orbit)
```

```csharp
private static DateTime TimeAtMeanAnomaly(this Orbit orbit, double meanAnomaly, DateTime time)
```

```csharp
private static double MeanAnomalyAtTime(this Orbit orbit, DateTime time)
```

```csharp
private static double EccentricToMean(this Orbit orbit, double E)
```

```csharp
private static double TrueToEccentric(this Orbit orbit, double trueAnomaly)
```

```csharp
private static double CircularOrbitSpeed(SpaceObject body, double radius)
```

```csharp
public static Vector3d DeltaVToCircularize(this Orbit orbit, DateTime time)
```

```csharp
public static Vector3d HeadingToAN(this Orbit orbit)
```

```csharp
public static Vector3d Prograde(this Orbit orbit, DateTime time)
```

```csharp
public static Vector3d Horizontal(this Orbit orbit, DateTime time)
```

```csharp
public static Vector3d Radial(this Orbit orbit, DateTime time)
```

```csharp
public static double Radius(this Orbit orbit, DateTime time)
```

```csharp
public static double Separation(this Orbit a, Orbit b, DateTime time)
```
