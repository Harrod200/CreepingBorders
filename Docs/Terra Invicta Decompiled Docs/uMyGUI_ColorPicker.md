# uMyGUI_ColorPicker

*Decompiled from `LapinerTools/uMyGUI/uMyGUI_ColorPicker.cs`.*


## Class `uMyGUI_ColorPicker`

```csharp
public class uMyGUI_ColorPicker : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `RedSlider` | public Slider |
| `GreenSlider` | public Slider |
| `BlueSlider` | public Slider |
| `PickedColor` | public Color |
| `ColorPreview` | public Graphic |
| `m_redSlider` | private Slider |
| `m_greenSlider` | private Slider |
| `m_blueSlider` | private Slider |
| `m_pickedColor` | private Color |
| `m_colorPreview` | private Graphic |
| `m_onChanged` | public EventHandler<uMyGUI_ColorPicker.ColorEventArgs> |
| `EventArgs` | public class ColorEventArgs : |
| `Value` | public readonly Color |

### Methods

```csharp
private void Start()
```

```csharp
private void OnDestroy()
```

```csharp
private void SetRedValue(float p_redValue)
```

```csharp
private void SetGreenValue(float p_greenValue)
```

```csharp
private void SetBlueValue(float p_blueValue)
```

```csharp
private void UpdateColor()
```

```csharp
public ColorEventArgs(Color p_value)
```
