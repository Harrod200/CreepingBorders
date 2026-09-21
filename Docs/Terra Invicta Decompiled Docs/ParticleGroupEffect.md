# ParticleGroupEffect

*Decompiled from `ParticleGroupEffect.cs`.*


## Class `ParticleGroupEffect`

```csharp
public class ParticleGroupEffect : AbstractEffectController
```

### Fields

| Name | Type |
|---|---|
| `m_particleGroup` | public ParticleGroup |
| `m_spawnAnchor` | public Transform |
| `m_loopDurationOverride` | public float |
| `m_particleInstances` | private List<GameObject> |
| `m_loopingEffects` | private List<ParticleSystem> |
| `m_playingEffects` | private List<ParticleSystem> |
| `spawnPosition` | private Vector3 |
| `spawnRotation` | private Quaternion |
| `spawnScale` | private Vector3 |

### Methods

```csharp
private void Awake()
```

```csharp
protected override void OnPlay()
```

```csharp
public override void CleanUp()
```

```csharp
protected override void OnUpdate(float deltaTime)
```

```csharp
protected override void OnStop()
```

```csharp
protected override void OnPause()
```

```csharp
protected override void OnUnPause()
```

```csharp
private IEnumerator StopLoopedEffects(float duration)
```
