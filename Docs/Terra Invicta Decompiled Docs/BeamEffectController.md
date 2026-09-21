# BeamEffectController

*Decompiled from `BeamEffectController.cs`.*


## Class `BeamEffectController`

```csharp
public class BeamEffectController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `StartPoint` | public Vector3 |
| `EndPoint` | public Vector3 |
| `beamDistanceScaling` | private static float |
| `isLaserPointLightEnabled` | public static bool |
| `emissionUniform` | private static int |
| `mainTexUniform` | private static int |
| `beamColor` | private Color |
| `intensity` | private float |
| `beamWidth` | private float |
| `_hitParticleSystem` | private ParticleSystem |
| `hitParticleSystems` | private ParticleSystem[] |
| `fireParticleSystem` | private ParticleSystem |
| `startLight` | private Light |
| `endLight` | private Light |
| `startLightInitialRange` | private float |
| `endLightInitialRange` | private float |
| `initialTextureScale` | private Vector2 |
| `lineRenderer` | private LineRenderer |
| `targetColorUniforms` | private List<ValueTuple<Material, Color>> |
| `targetEmissionUniforms` | private List<ValueTuple<Material, Color>> |
| `targetParticleColors` | private List<ValueTuple<ParticleSystem, Color>> |
| `trailMaterial` | private Material |
| `hitParticleMaxScale` | public float |

### Methods

```csharp
private void Awake()
```

```csharp
private void OnEnable()
```

```csharp
private void OnDisable()
```

```csharp
private void OnDestroy()
```

```csharp
public void SetBeamPoints(Vector3 start, Vector3 end)
```

```csharp
private void OnWillRenderObject()
```

```csharp
private void ApplyColorToMaterials()
```

```csharp
private Color GetUpdatedColor(Color orig, Color dest)
```
