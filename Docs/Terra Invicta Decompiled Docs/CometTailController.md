# CometTailController

*Decompiled from `PavonisInteractive/TerraInvicta/CometTailController.cs`.*


## Class `CometTailController`

```csharp
public abstract class CometTailController<T> : CometParticleController where T : CometTailSample
```

### Fields

| Name | Type |
|---|---|
| `NearParticleRadius_m` | public float |
| `FarParticleRadius_m` | public float |
| `TargetOpacityFactor` | public override float |
| `DesiredTailLength_m` | public float |
| `TailLengthModifier` | public float |
| `DoNotDisplay` | public override bool |
| `Path` | protected CometTailPath |
| `VisualSizeEstimate_deg` | public float |
| `VisualSize_deg` | public float |
| `BaseNearParticleRadius_m` | public float |
| `BaseFarParticleRadius_m` | public float |
| `ExpansionVelocity_mps` | public float |
| `InitialExpansion_m` | public float |
| `BaseTailLength_m` | public float |
| `SampleResolution` | public int |
| `cachedPath` | private CometTailPath |
| `bakedVisualTFunction` | private Func<double, double> |
| `pathCachedFrame` | private int |
| `cachedTailLength_days` | private float |
| `tailLengthCachedPosition` | private Vector3d |
| `tailLengthCachedFrame` | private int |

### Methods

```csharp
public override void LateUpdate()
```

```csharp
public override ParticleSystem.EmitParams SpawnParticle(float t)
```

```csharp
public override void UpdateParticle(int particleIndex, ParticleSystem.Particle[] particles, List<Vector4> customParticleData0, List<Vector4> customParticleData1)
```

```csharp
protected float GetVisualT(float t)
```

```csharp
protected abstract T CreateParticleSample(TIDateTime date)
```

```csharp
protected float GetTailLength_days()
```

```csharp
protected List<CometTailSample> GetCometTailSamples()
```
