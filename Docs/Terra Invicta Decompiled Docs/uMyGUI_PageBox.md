# uMyGUI_PageBox

*Decompiled from `LapinerTools/uMyGUI/uMyGUI_PageBox.cs`.*


## Class `uMyGUI_PageBox`

```csharp
public class uMyGUI_PageBox : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `PageCount` | public int |
| `MaxPageBtnCount` | public int |
| `SelectedPage` | public int |
| `RTransform` | public RectTransform |
| `OnPageSelected` | public event Action<int> |
| `PageButtonTransform` | private RectTransform |
| `m_previousButton` | private Button |
| `m_nextButton` | private Button |
| `m_pageButton` | private Button |
| `m_pageCount` | private int |
| `m_maxPageBtnCount` | private int |
| `m_selectedPage` | private int |
| `m_rectTransform` | private RectTransform |
| `m_pageButtonTransform` | private RectTransform |
| `m_offset` | private int |
| `m_pageButtons` | private List<Button> |

### Methods

```csharp
public void SetPageCount(int p_newPageCount)
```

```csharp
public void SelectPageAndCenterOffset(int p_selectedPage)
```

```csharp
public void SelectPage(int p_selectedPage)
```

```csharp
public void UpdateUI()
```

```csharp
private void Start()
```

```csharp
private void SetText(Button p_button, string p_text)
```

```csharp
private void SetOnClick(Button p_button, int p_pageNumber)
```

```csharp
private float GetWidth(Button p_button)
```

```csharp
private float GetWidth(RectTransform p_rTransform)
```

```csharp
private void Clear()
```
