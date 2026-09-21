# CanvasControllerBase

*Decompiled from `PavonisInteractive/TerraInvicta/CanvasControllerBase.cs`.*


## Class `CanvasControllerBase`

```csharp
public abstract class CanvasControllerBase : MonoBehaviour, ICanvas, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
```

### Fields

| Name | Type |
|---|---|
| `GameObject` | public GameObject |
| `Paused` | public bool |
| `hideIfNotTopOfStack` | public bool |
| `componentsToHide` | protected List<Behaviour> |
| `typesToHide` | private readonly List<Type> |
| `delayPoint1` | private static WaitForSeconds |

### Properties

- `public Canvas Canvas`
- `private protected CanvasManager canvasManager`
- `public GameTimeManager gameTime`
- `private protected bool componentsCached`
- `public TIFactionState activePlayer`

### Methods

```csharp
public virtual void Initialize()
```

```csharp
public virtual void Show()
```

```csharp
public virtual void Hide()
```

```csharp
public virtual void HideNoCache()
```

```csharp
public virtual void OnDestroy()
```

```csharp
public virtual bool Visible()
```

```csharp
public virtual void Refresh()
```

```csharp
public void RefreshScaling()
```

```csharp
public void SetActivePlayer(bool startup)
```

```csharp
public virtual void UpdateActivePlayerUIElements(bool startup)
```

```csharp
private IEnumerator ShuttingDownCanvas()
```

```csharp
public void OnPointerEnter(PointerEventData eventData)
```

```csharp
public void OnPointerExit(PointerEventData eventData)
```

```csharp
public void OnApplicationFocus(bool focus)
```

```csharp
public virtual void SetUltraWideScaling()
```

```csharp
public virtual void UpdateUIScaling()
```

```csharp
public float VerticalScaleValueLimit()
```

```csharp
public void OnClickOpenCodex(string topic = "codex_welcome")
```
