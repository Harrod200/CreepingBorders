# ImageAnimator

*Decompiled from `ImageAnimator.cs`.*


## Class `ImageAnimator`

```csharp
public class ImageAnimator : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `image` | public Image |
| `sprites` | private Sprite[] |
| `animationSpeed` | public float |
| `stopFlag` | private bool |

### Properties

- `public bool isPlaying`

### Methods

```csharp
public void SetSpriteSheet(string path, float animationSpeed = 0.1f)
```

```csharp
private IEnumerator LoopAnimation()
```

```csharp
public int SpriteCount()
```

```csharp
public void Play()
```

```csharp
public void Stop()
```
