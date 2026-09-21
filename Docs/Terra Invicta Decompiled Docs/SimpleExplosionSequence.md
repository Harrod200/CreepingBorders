# SimpleExplosionSequence

*Decompiled from `SimpleExplosionSequence.cs`.*


## Class `SimpleExplosionSequence`

```csharp
public class SimpleExplosionSequence : AbstractEffectController
```

### Fields

| Name | Type |
|---|---|
| `m_explosionEffect` | private ParticleGroup |
| `m_burnUpEffect` | private BurnUpEffect |
| `m_explosionTargets` | private List<GameObject> |
| `m_minDelay` | private float |
| `m_maxDelay` | private float |
| `m_delay` | private float |
| `m_elapsed` | private float |
| `m_targetIndex` | private int |
| `m_playingEffects` | private List<AbstractEffectController> |

### Methods

```csharp
private void Awake()
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

```csharp
private void CreateExplosion()
```
