# AbstractEffectController

*Decompiled from `AbstractEffectController.cs`.*


## Class `AbstractEffectController`

```csharp
public abstract class AbstractEffectController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `OnStarted` | public event Action |
| `OnCompleted` | public event Action |
| `m_Comment` | private string |
| `m_playOnAwake` | private bool |
| `m_oneShot` | private bool |
| `m_isPlaying` | protected bool |
| `m_isPaused` | protected bool |
| `m_isUnPaused` | protected bool |
| `gameTime` | private GameTimeManager |
| `debugCanPause` | private bool |

### Methods

```csharp
protected virtual void Start()
```

```csharp
protected virtual void OnEnable()
```

```csharp
protected virtual void OnDisable()
```

```csharp
public void Play()
```

```csharp
public void Pause()
```

```csharp
public void Stop()
```

```csharp
protected void EffectCompleted()
```

```csharp
private void Update()
```

```csharp
public abstract void CleanUp()
```

```csharp
protected abstract void OnPlay()
```

```csharp
protected abstract void OnUpdate(float deltaTime)
```

```csharp
protected abstract void OnStop()
```

```csharp
protected abstract void OnPause()
```

```csharp
protected abstract void OnUnPause()
```
