# RandomEffectSequence

*Decompiled from `RandomEffectSequence.cs`.*


## Class `RandomEffectSequence`

```csharp
public class RandomEffectSequence : AbstractEffectController
```

### Fields

| Name | Type |
|---|---|
| `m_duration` | private float |
| `m_iterations` | private int |
| `m_targetEffects` | private List<AbstractEffectController> |
| `m_sequence` | private List<ValueTuple<float, AbstractEffectController>> |
| `m_elapsed` | private float |
| `m_playingEffects` | private List<AbstractEffectController> |

### Methods

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
