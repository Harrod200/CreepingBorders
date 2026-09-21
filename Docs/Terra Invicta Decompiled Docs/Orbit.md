# Orbit

*Decompiled from `PavonisInteractive/TerraInvicta/Systems/Orbit.cs`.*


## Struct `Orbit`

```csharp
public struct Orbit : IComponentData
```

### Fields

| Name | Type |
|---|---|
| `PeriapsisEpoch` | public DateTime |
| `IsElliptical` | public bool |
| `IsHyperbolic` | public bool |
| `Eccentricity` | public double |
| `SemimajorAxis_m` | public double |
| `Inclination_Rad` | public double |
| `LongitudeAscendingNode_Rad` | public double |
| `ArgumentPeriapsis_Rad` | public double |
| `MeanAnomalyAtEpoch_Rad` | public double |
| `PositionAtEpoch` | public Vector3d |
| `VelocityAtEpoch` | public Vector3d |
| `Epoch` | public DateTime |
| `Barycenter` | public Entity |
| `_PeriapsisEpoch` | private DateTime? |
| `Period` | public double |
| `MeanMotion` | public double |
| `Apoapsis` | public Vector3d |
| `Periapsis` | public Vector3d |
| `Normal` | public Vector3d |
| `OrbitTrail` | public VectorLine |
| `WorldPoints` | public Vector3d[] |
| `ScaledPoints` | public Vector3[] |
| `TimeAtPoint_s` | public double[] |
