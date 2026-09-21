# uMyGUI_Dropdown

*Decompiled from `LapinerTools/uMyGUI/uMyGUI_Dropdown.cs`.*


## Class `uMyGUI_Dropdown`

```csharp
public class uMyGUI_Dropdown : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `Entries` | public string[] |
| `SelectedIndex` | public int |
| `OnSelected` | public event Action<int> |
| `m_button` | private Button |
| `m_text` | private TMP_Text |
| `m_entriesRoot` | private RectTransform |
| `m_entriesBG` | private RectTransform |
| `m_entriesScrollbar` | private Scrollbar |
| `m_entryButton` | private Button |
| `m_entrySpacing` | private int |
| `m_staticText` | private string |
| `m_nothingSelectedText` | private string |
| `m_improveNavigationFocus` | protected bool |
| `m_entries` | private string[] |
| `m_selectedIndex` | private int |

### Methods

```csharp
public void Select(int p_selectedIndex)
```

```csharp
private void Start()
```

```csharp
private void LateUpdate()
```

```csharp
private void OnClick()
```

```csharp
private void ShowEntries(bool updatescroll = true)
```

```csharp
private void HideEntries()
```

```csharp
private void ClearEntries()
```

```csharp
private void UpdateText()
```

```csharp
private void SetOnClick(Button p_button, int p_selectedIndex)
```

```csharp
private void SetText(Button p_button, string p_text)
```

```csharp
private float GetHeight(Button p_button)
```

```csharp
private float GetHeight(RectTransform p_rTransform)
```

```csharp
private IEnumerator UpdateScrollBarVisibility()
```
