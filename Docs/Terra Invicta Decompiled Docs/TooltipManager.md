# TooltipManager

*Decompiled from `ModelShark/TooltipManager.cs`.*


## Class `TooltipManager`

```csharp
public class TooltipManager : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `tooltipDelayPrimary` | public float |
| `tooltipDelaySupplemental` | public float |
| `TextFieldDelimiter` | public string |
| `Instance` | public static TooltipManager |
| `guiCamera` | public Camera |
| `matchRotationTo` | public RectTransform |
| `tooltipsEnabled` | public bool |
| `touchSupport` | public bool |
| `fadeDuration` | public float |
| `overflowProtection` | public bool |
| `positionBounds` | public PositionBounds |
| `lastTooltip` | public string |
| `lastTooltipTrigger` | public TooltipTrigger |
| `instance` | private static TooltipManager |
| `isInitialized` | private bool |
| `attemptingToShowTooltip` | public bool |

### Properties

- `public Canvas GuiCanvas`
- `private Canvas RootCanvas`
- `public GameObject TooltipContainer`
- `private GameObject TooltipContainerNoAngle`
- `public Dictionary<TooltipStyle, Tooltip> Tooltips`
- `public Tooltip BlockingTooltip`

### Methods

```csharp
private void Awake()
```

```csharp
private void Update()
```

```csharp
private void Initialize()
```

```csharp
private GameObject CreateTooltipContainer(string containerName)
```

```csharp
public void ResetTooltipRotation()
```

```csharp
public void SetTextAndSize(TooltipTrigger trigger)
```

```csharp
public IEnumerator Show(TooltipTrigger trigger)
```

```csharp
public void HideAll()
```

```csharp
private void OnLanguageChangedEvent()
```

```csharp
private void OnDestroy()
```

```csharp
public void MoveContainerToDummyCanvas(bool nextFrame = false)
```

```csharp
private IEnumerator MoveContainerToDummyNF()
```

```csharp
public List<TooltipStyle> VisibleTooltips()
```
