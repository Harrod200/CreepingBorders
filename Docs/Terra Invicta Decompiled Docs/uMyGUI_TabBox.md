# uMyGUI_TabBox

*Decompiled from `LapinerTools/uMyGUI/uMyGUI_TabBox.cs`.*


## Class `uMyGUI_TabBox`

```csharp
public class uMyGUI_TabBox : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `SEND_MESSAGE_ACTIVATE_NAME` | public const string |
| `SEND_MESSAGE_DEACTIVATE_NAME` | public const string |
| `m_btns` | private RectTransform[] |
| `m_tabs` | private RectTransform[] |
| `m_selectedIndex` | private int |
| `m_isSelectTabOnStart` | private bool |
| `m_isPlayTabAnimOnStart` | private bool |
| `m_isPlayBtnAnimOnStart` | private bool |
| `m_animMode` | private uMyGUI_TabBox.EAnimMode |
| `m_fadeInAnimTab` | private string |
| `m_fadeOutAnimTab` | private string |
| `m_fadeInAnimBtn` | private string |
| `m_fadeOutAnimBtn` | private string |
| `m_isSendMessage` | private bool |
| `m_isMoveDownInHierarchyOnSelect` | private bool |
| `EAnimMode` | public enum |

### Methods

```csharp
public void SelectTab(int p_tabIndex)
```

```csharp
private void Start()
```

```csharp
private void UpdateTabActiveStates(int p_tabIndex)
```

```csharp
private void AnimateRectRectTransformSelection(int p_tabIndex, RectTransform[] p_transforms, string p_fadeInAnim, string p_fadeOutAnim, bool p_isActivateChanged)
```

```csharp
private IEnumerator DeactivateAfterDelay(GameObject p_object, float p_delay)
```
