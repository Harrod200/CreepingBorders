# uMyGUI_TexturePicker

*Decompiled from `LapinerTools/uMyGUI/uMyGUI_TexturePicker.cs`.*


## Class `uMyGUI_TexturePicker`

```csharp
public class uMyGUI_TexturePicker : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `TexturePrefab` | public GameObject |
| `SelectionPrefab` | public GameObject |
| `OffsetStart` | public float |
| `OffsetEnd` | public float |
| `Padding` | public float |
| `ButtonCallback` | public Action<int> |
| `Textures` | public Texture2D[] |
| `RTransform` | private RectTransform |
| `Instances` | public GameObject[] |
| `m_texturePrefab` | private GameObject |
| `m_selectionPrefab` | private GameObject |
| `m_offsetStart` | private float |
| `m_offsetEnd` | private float |
| `m_padding` | private float |
| `m_buttonCallback` | private Action<int> |
| `m_textures` | private Texture2D[] |
| `m_rectTransform` | private RectTransform |
| `m_elementSize` | private float |
| `m_selectionInstance` | private GameObject |
| `m_instances` | private GameObject[] |

### Methods

```csharp
public void SetSelection(int p_selectionIndex)
```

```csharp
public void SetTextures(Texture2D[] p_textures, int p_selectedIndex)
```

```csharp
private void OnDestroy()
```

```csharp
private void SetRectTransformPosition(RectTransform p_transform, int p_positionIndex, float p_size)
```

```csharp
private T TryFindComponent<T>(GameObject p_object) where T : Component
```
