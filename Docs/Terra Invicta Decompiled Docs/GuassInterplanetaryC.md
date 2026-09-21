# GuassInterplanetaryC

*Decompiled from `PavonisInteractive/TerraInvicta/GuassInterplanetaryC.cs`.*


## Class `GuassInterplanetaryC`

```csharp
internal class GuassInterplanetaryC
```

### Fields

| Name | Type |
|---|---|
| `DAY_s` | private const double |
| `G` | private const double |
| `PI` | private const double |
| `TWOPI` | private const double |
| `commonBarycenterMu` | public double |
| `baseLaunch_js` | public double |
| `baseDuration_s` | public double |
| `durationStep_s` | public double |
| `launchDateStep_s` | public double |
| `Source` | public GuassInterplanetaryC.OrbitalBody |
| `Destination` | public GuassInterplanetaryC.OrbitalBody |
| `nextHohmannLaunchDate` | public double |
| `commonBarycenterMu_AU` | public double |
| `synodicPeriod_days` | public double |
| `Results` | public List<GuassInterplanetaryC.FlightPlanC> |
| `OrbitalBody` | public struct |
| `a_m` | public double |
| `e` | public double |
| `i_rad` | public double |
| `o_rad` | public double |
| `l_rad` | public double |
| `w_rad` | public double |
| `epoch_seconds` | public double |
| `radius_m` | public double |
| `mu` | public double |
| `period_d` | public double |
| `FlightPlanC` | public struct |
| `orbit` | public GuassInterplanetaryC.OrbitalBody |
| `launchDate_js` | public double |
| `duration_s` | public double |
| `departure_deltaV_mps` | public double |
| `arrival_deltaV_mps` | public double |
| `PosVel` | public struct |
| `pos` | public Vector3d |
| `vel` | public Vector3d |

### Methods

```csharp
private GuassInterplanetaryC.FlightPlanC MakeFlightPlan(double a_m, double e, double i_rad, double o_rad, double l_rad, double w_rad, double launchDate_js, double duration_s, double departure_deltaV_mps, double arrival_deltaV_mps)
```

```csharp
private GuassInterplanetaryC.PosVel makePosVel(double px, double py, double pz, double vx, double vy, double vz)
```

```csharp
private double OrbitalPeriod(double semiMajorAxis_m, double barycenterMass_kg)
```

```csharp
private double Normalize_Rad(double angle)
```

```csharp
private GuassInterplanetaryC.PosVel AnglesToCartesianState(double omega, double u, double i)
```

```csharp
private GuassInterplanetaryC.PosVel getOrbitPointAtJD(double jd, double a_m, double e, double inc_rad, double o_rad, double l_rad, double w_rad, double j2000Epoch, double barycenterMass_kg)
```

```csharp
private GuassInterplanetaryC.PosVel getOrbitalBodyAtTime(GuassInterplanetaryC.OrbitalBody ob, double t)
```

```csharp
private double gaussCalcT(double r1d, double r2d, double angleTo, double k, double l, double m, double trialP, out double a, out double f, out double g)
```

```csharp
private double gaussGuessP(ref double t, double r1d, double r2d, double angleTo, out double a, out double f, out double g)
```

```csharp
public void ComputeFlightPlans()
```

```csharp
public override string ToString()
```
