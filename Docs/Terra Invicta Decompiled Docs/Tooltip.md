# Tooltip

*Decompiled from `ModelShark/Tooltip.cs`.*


## Class `Tooltip`

```csharp
public class Tooltip
```

### Fields

| Name | Type |
|---|---|
| `layoutGroup` | public HorizontalOrVerticalLayoutGroup |

### Properties

- `public RectTransform RectTransform`
- `public TooltipStyle TooltipStyle`
- `public GameObject GameObject`
- `public List<TextField> TextFields`
- `public List<ImageField> ImageFields`
- `public List<SectionField> SectionFields`
- `public Image BackgroundImage`
- `public CanvasRenderer[] CanvasRenderers`
- `public Graphic[] Graphics`
- `public LayoutGroup[] LayoutGroups`
- `public bool StaysOpen`
- `public bool NeverRotate`
- `public bool IsBlocking`
- `public static string Delimiter`
- `public TooltipTrigger TooltipTrigger`

### Methods

```csharp
public void Initialize()
```

```csharp
public void WarmUp()
```

```csharp
public void Deactivate(bool delayReparentOneFrame = false)
```

```csharp
public void ResetParameterizedFields()
```

```csharp
public void Display(float fadeDuration)
```
