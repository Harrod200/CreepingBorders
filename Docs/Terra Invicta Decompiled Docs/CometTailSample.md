# CometTailSample

*Decompiled from `PavonisInteractive/TerraInvicta/CometTailSample.cs`.*


## Class `CometTailSample`

```csharp
public abstract class CometTailSample
```

### Fields

| Name | Type |
|---|---|
| `Age_s` | public double |
| `Radius_m` | public double |
| `RelativeDensity` | public double |
| `Opacity` | public double |
| `Position_m` | public Vector3d |
| `Velocity_mps` | public Vector3d |
| `cachedNow` | private TIDateTime |
| `cachedPosition_m` | private Vector3d |
| `cachedVelocity_mps` | private Vector3d |

### Properties

- `public TIDateTime SpawnDate`
- `public Vector3d SpawnPosition`
- `public Vector3d SpawnVelocity`
- `public double SpawnRadius_m`
- `public double SpawnOpacity`
- `public double ExpansionVelocity_mps`
- `public abstract Color Color`

### Methods

```csharp
public virtual void CalculatePositionAndVelocity(TIDateTime time, out Vector3d position_m, out Vector3d velocity_mps, int resolution = 10)
```

```csharp
public virtual Vector3d GetAccelerationVector_mps2(Vector3d position_m)
```

```csharp
public CometTailSample(TIDateTime date, Vector3d position, Vector3d velocity, double radius_m, double opacity, double expansionVelocity_mps)
```
