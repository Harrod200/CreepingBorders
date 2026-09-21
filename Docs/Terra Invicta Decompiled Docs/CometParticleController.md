# CometParticleController

*Decompiled from `PavonisInteractive/TerraInvicta/CometParticleController.cs`.*


## Class `CometParticleController`

```csharp
public abstract class CometParticleController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `TargetParticleCount` | public int |
| `TargetOpacityFactor` | public virtual float |
| `Comet` | public TISpaceBodyState |
| `DoNotDisplay` | public virtual bool |
| `ParticleLifetime_s` | public float |
| `CometController` | public CometController |
| `ParticleSystem` | public ParticleSystem |
| `RenderTextureParticleMaterial` | public Material |
| `Color` | public Color |
| `Color32` | private Color32 |
| `ParticleCountAtOneAU` | public int |
| `MinimumParticleCount` | public int |
| `OpacityLerpSpeed` | public float |
| `particlesArray` | private ParticleSystem.Particle[] |
| `ParticleSpawnBehavior` | public enum |

### Properties

- `public float OpacityFactor`

### Methods

```csharp
public virtual ParticleSystem.EmitParams SpawnParticle(float t)
```

```csharp
public virtual void UpdateParticle(int particleIndex, ParticleSystem.Particle[] particles, List<Vector4> customParticleData0, List<Vector4> customParticleData1)
```

```csharp
public virtual void LateUpdate()
```

```csharp
public virtual void InitiateOverrideRenderMode(bool drawingToRenderTexture)
```

```csharp
protected virtual IEnumerable<float> GetAgeSegments(int resolution = 10)
```

```csharp
protected Vector3 GetUnityPosition(Vector3d position)
```

```csharp
public byte GetFeatheredAlphaByte(int index)
```

```csharp
public Color32 GetFeatheredColor(int index)
```
