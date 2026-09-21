# MicrothrustSphere

*Decompiled from `PavonisInteractive/TerraInvicta/MicrothrustSphere.cs`.*


## Class `MicrothrustSphere`

```csharp
public class MicrothrustSphere
```

### Fields

| Name | Type |
|---|---|
| `ACCELERATION_MULTIPLIER` | public const double |
| `FleetAcceleration_mps2` | public double |

### Properties

- `public double Radius_m`
- `public double OrbitalVelocityAtSphere_mps`
- `public double Mu`
- `public bool IsLimitedBySphereOfInfluence`

### Methods

```csharp
public MicrothrustSphere(double fleetAcceleration_mps2, double mu, double sphereOfInfluence_m)
```

```csharp
public double GetDuration_s(double velocity_mps)
```

```csharp
public double GetAnomalyDelta_Rad(double velocity_mps)
```

```csharp
public double GetDeltaV_mps(double velocity_mps)
```

```csharp
private double FourthPower(double x)
```
