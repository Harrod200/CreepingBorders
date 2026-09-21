# CometTailDustSample

*Decompiled from `PavonisInteractive/TerraInvicta/CometTailDustSample.cs`.*


## Class `CometTailDustSample`

```csharp
public class CometTailDustSample : CometTailSample
```

### Fields

| Name | Type |
|---|---|
| `Color` | public override Color |

### Properties

- `public double GrainDiameter_mm`

### Methods

```csharp
public CometTailDustSample(TIDateTime date, Vector3d position, Vector3d velocity, double radius_m, double opacity, double expansionVelocity_mps, double grainDiameter_mm = 0.001)
```

```csharp
public override Vector3d GetAccelerationVector_mps2(Vector3d position_m)
```
