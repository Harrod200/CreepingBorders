# ColorAnimationEffect

*Decompiled from `ColorAnimationEffect.cs`.*


## Class `ColorAnimationEffect`

```csharp
public class ColorAnimationEffect : AbstractEffectController
```

### Fields

| Name | Type |
|---|---|
| `m_useScaledGameTimeCheck` | private bool |
| `m_squareIntensity` | private bool |
| `m_blendMode` | private ColorAnimationEffect.ColorBlendMode |
| `m_colorAnimation` | private Gradient |
| `m_intensityAnimation` | private AnimationCurve |
| `m_duration` | private float |
| `m_targetRenderers` | private Renderer[] |
| `m_targetUniformName` | private string |
| `m_targetUniform` | private int |
| `m_targetMaterials` | private List<ValueTuple<Material, Color>> |
| `m_progress` | private float |
| `m_reversed` | private bool |
| `m_useScaledTime` | private bool |
| `m_gameTime` | private GameTimeManager |
| `ColorBlendMode` | public enum |

### Methods

```csharp
public void Awake()
```

```csharp
protected override void OnEnable()
```

```csharp
public override void CleanUp()
```

```csharp
public void PlayReversed()
```

```csharp
public void Resume()
```

```csharp
public new void Pause()
```

```csharp
public void SetColors(params Color[] args)
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
