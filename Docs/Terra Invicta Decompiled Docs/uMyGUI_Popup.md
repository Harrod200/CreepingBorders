# uMyGUI_Popup

*Decompiled from `LapinerTools/uMyGUI/uMyGUI_Popup.cs`.*


## Class `uMyGUI_Popup`

```csharp
public class uMyGUI_Popup : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `OnShow` | public event Action |
| `OnHide` | public event Action |
| `IsShown` | public virtual bool |
| `loadingText` | public TMP_Text |
| `m_createFrame` | protected int |

### Properties

- `public virtual bool DestroyOnHide`

### Methods

```csharp
public virtual void Show()
```

```csharp
public virtual void Hide()
```

```csharp
protected virtual void Awake()
```

```csharp
protected virtual void Start()
```

```csharp
protected IEnumerator DestroyOnEndOfFrame()
```
