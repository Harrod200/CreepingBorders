# TooltipTrigger

*Decompiled from `ModelShark/TooltipTrigger.cs`.*


## Class `TooltipTrigger`

```csharp
public class TooltipTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler, IPointerDownHandler, IPointerUpHandler
```

### Fields

| Name | Type |
|---|---|
| `tooltipStyle` | public TooltipStyle |
| `parameterizedTextFields` | public List<ParameterizedTextField> |
| `dynamicImageFields` | public List<DynamicImageField> |
| `dynamicSectionFields` | public List<DynamicSectionField> |
| `isRemotelyActivated` | public bool |
| `worldSpace` | public bool |
| `tooltipType` | public TooltipType |
| `backgroundTint` | public Color |
| `tipPosition` | public TipPosition |
| `minTextWidth` | public int |
| `maxTextWidth` | public int |
| `disablePendingTooltipsOnMouseExit` | public bool |
| `staysOpen` | public bool |
| `neverRotate` | public bool |
| `isBlocking` | public bool |
| `hoverTimer` | private float |
| `popupTimer` | private float |
| `tooltipDelay` | private float |
| `popupTime` | private float |
| `isInitialized` | private bool |
| `isMouseOver` | private bool |
| `isMouseDown` | private bool |

### Properties

- `public Tooltip Tooltip`

### Methods

```csharp
public void Start()
```

```csharp
private void Initialize()
```

```csharp
private void Update()
```

```csharp
public void OnPointerEnter(PointerEventData eventData)
```

```csharp
public void OnMouseOver()
```

```csharp
private void CreateTooltipRuntime(TooltipStyle tooltipStyle)
```

```csharp
public void OnMouseDown()
```

```csharp
public void OnMouseExit()
```

```csharp
public void OnPointerDown(PointerEventData eventData)
```

```csharp
public void OnSelect(BaseEventData eventData)
```

```csharp
public void OnPointerExit(PointerEventData eventData)
```

```csharp
public void OnPointerUp(PointerEventData eventData)
```

```csharp
public void OnMouseUp()
```

```csharp
public void OnDeselect(BaseEventData eventData)
```

```csharp
public void StartHover()
```

```csharp
public void ForceRefreshTooltip()
```

```csharp
public void ForceRefreshTooltipIfOpen()
```

```csharp
public void ForceHideTooltip()
```

```csharp
public void DisablePendingTooltips()
```

```csharp
public void StopHover(bool delayReparentOneFrame = false)
```

```csharp
public void Popup(float duration, GameObject triggeredBy)
```

```csharp
public void SetDelegate(string parameterName, ParameterizedTextField.BuildStringOnTooltipHover del)
```

```csharp
public void SetText(string parameterName, string text)
```

```csharp
public void SetImage(string parameterName, Sprite sprite)
```

```csharp
public void TurnSectionOn(string parameterName)
```

```csharp
public void TurnSectionOff(string parameterName)
```

```csharp
private void ToggleSection(string parameterName, bool isOn)
```

```csharp
public void OnDisable()
```
