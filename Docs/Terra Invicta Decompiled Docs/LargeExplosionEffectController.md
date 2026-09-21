# LargeExplosionEffectController

*Decompiled from `LargeExplosionEffectController.cs`.*


## Class `LargeExplosionEffectController`

```csharp
public class LargeExplosionEffectController : AbstractEffectController
```

### Fields

| Name | Type |
|---|---|
| `explosionParticleSystem` | private ParticleSystem |
| `durationVariance` | private float |
| `postProcessing` | private PostProcessProfile |
| `postProcessPriority` | private float |
| `postProcessDuration` | private float |
| `postProcessMaxDistance` | private float |
| `postProcessMaxAngle` | private float |
| `postProcessCurve` | private AnimationCurve |
| `postProcessingVolume` | private PostProcessVolume |
| `postProcessingTimeScale` | private float |
| `progress` | private float |
| `affectedCameras` | private HashSet<Camera> |

### Methods

```csharp
private void Awake()
```

```csharp
private void OnDestroy()
```

```csharp
public override void CleanUp()
```

```csharp
protected override void OnPlay()
```

```csharp
protected override void OnStop()
```

```csharp
protected override void OnUpdate(float deltaTime)
```

```csharp
protected override void OnPause()
```

```csharp
protected override void OnUnPause()
```
