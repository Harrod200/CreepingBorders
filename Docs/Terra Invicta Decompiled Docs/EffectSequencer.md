# EffectSequencer

*Decompiled from `EffectSequencer.cs`.*


## Class `EffectSequencer`

```csharp
public class EffectSequencer : AbstractEffectController
```

### Fields

| Name | Type |
|---|---|
| `m_playbackSpeed` | private float |
| `m_effects` | private EffectSequencer.SequencedEffect[] |
| `m_playingEffects` | private List<AbstractEffectController> |
| `m_curEffectIndex` | private int |
| `m_curTime` | private float |
| `SequencedEffect` | public struct |
| `label` | private string |
| `time` | public float |
| `effect` | public AbstractEffectController |

### Methods

```csharp
protected override void Start()
```

```csharp
public override void CleanUp()
```

```csharp
private void StepSequence(float deltaTime)
```

```csharp
protected override void OnPlay()
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
public int Compare(EffectSequencer.SequencedEffect x, EffectSequencer.SequencedEffect y)
```
