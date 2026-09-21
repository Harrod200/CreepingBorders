# DOTweenAnimation

*Decompiled from `DG/Tweening/DOTweenAnimation.cs`.*


## Class `DOTweenAnimation`

```csharp
public class DOTweenAnimation : ABSAnimationComponent
```

### Fields

| Name | Type |
|---|---|
| `delay` | public float |
| `duration` | public float |
| `easeType` | public Ease |
| `easeCurve` | public AnimationCurve |
| `loopType` | public LoopType |
| `loops` | public int |
| `id` | public string |
| `isRelative` | public bool |
| `isFrom` | public bool |
| `isIndependentUpdate` | public bool |
| `autoKill` | public bool |
| `isActive` | public bool |
| `isValid` | public bool |
| `target` | public Component |
| `animationType` | public DOTweenAnimationType |
| `targetType` | public TargetType |
| `forcedTargetType` | public TargetType |
| `autoPlay` | public bool |
| `useTargetAsV3` | public bool |
| `endValueFloat` | public float |
| `endValueV3` | public Vector3 |
| `endValueV2` | public Vector2 |
| `endValueColor` | public Color |
| `endValueString` | public string |
| `endValueRect` | public Rect |
| `endValueTransform` | public Transform |
| `optionalBool0` | public bool |
| `optionalFloat0` | public float |
| `optionalInt0` | public int |
| `optionalRotationMode` | public RotateMode |
| `optionalScrambleMode` | public ScrambleMode |
| `optionalString` | public string |
| `_tweenCreated` | private bool |
| `_playCount` | private int |

### Methods

```csharp
private void Awake()
```

```csharp
private void Start()
```

```csharp
private void OnDestroy()
```

```csharp
public void CreateTween()
```

```csharp
public override void DOPlay()
```

```csharp
public override void DOPlayBackwards()
```

```csharp
public override void DOPlayForward()
```

```csharp
public override void DOPause()
```

```csharp
public override void DOTogglePause()
```

```csharp
public override void DORewind()
```

```csharp
public override void DORestart(bool fromHere = false)
```

```csharp
public override void DOComplete()
```

```csharp
public override void DOKill()
```

```csharp
public void DOPlayById(string id)
```

```csharp
public void DOPlayAllById(string id)
```

```csharp
public void DOPauseAllById(string id)
```

```csharp
public void DOPlayBackwardsById(string id)
```

```csharp
public void DOPlayBackwardsAllById(string id)
```

```csharp
public void DOPlayForwardById(string id)
```

```csharp
public void DOPlayForwardAllById(string id)
```

```csharp
public void DOPlayNext()
```

```csharp
public void DORewindAndPlayNext()
```

```csharp
public void DORestartById(string id)
```

```csharp
public void DORestartAllById(string id)
```

```csharp
public List<Tween> GetTweens()
```

```csharp
public static TargetType TypeToDOTargetType(Type t)
```

```csharp
private void ReEvaluateRelativeTween()
```
