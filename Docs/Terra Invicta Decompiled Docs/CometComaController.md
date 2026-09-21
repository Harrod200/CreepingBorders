# CometComaController

*Decompiled from `PavonisInteractive/TerraInvicta/CometComaController.cs`.*


## Class `CometComaController`

```csharp
public class CometComaController : CometParticleController
```

### Fields

| Name | Type |
|---|---|
| `RelativeRadius` | public float |
| `DustRadius_m` | public float |
| `ExpansionVelocity_mps` | public float |
| `SolarWindAcceleration_mps2` | public float |
| `DoNotDisplay` | public override bool |
| `BaseExpansionVelocity_mps` | public float |
| `BaseSolarWindAcceleration_mps2` | public float |
| `ComaStillnessZone` | public float |
| `ComaSlownessZone` | public float |
| `BaseDustRadius_m` | public float |
| `RadiusScalingFactor` | public float |
| `RelativeSpawnAltitude` | public float |
| `calibrationRadius_m` | private const float |
| `Glow` | public GameObject |
| `GlowRenderer` | public Renderer |
| `GlowEdgeWidth_deg` | public float |
| `GlowColor` | public Color |

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
private void Timestep(ref Vector3 offsetFromComet, ref Vector3 velocity, float timeStep_s)
```

```csharp
public override void InitiateOverrideRenderMode(bool drawingToRenderTexture)
```
