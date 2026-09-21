# uMyGUI_PopupManager

*Decompiled from `LapinerTools/uMyGUI/uMyGUI_PopupManager.cs`.*


## Class `uMyGUI_PopupManager`

```csharp
public class uMyGUI_PopupManager : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `Instance` | public static uMyGUI_PopupManager |
| `IsInstanceSet` | public static bool |
| `Popups` | public uMyGUI_Popup[] |
| `PopupNames` | public string[] |
| `DeactivatedElementsWhenPopupIsShown` | public CanvasGroup[] |
| `IsPopupShown` | public bool |
| `POPUP_LOADING` | public const string |
| `POPUP_TEXT` | public const string |
| `POPUP_DROPDOWN` | public const string |
| `BTN_OK` | public const string |
| `BTN_YES` | public const string |
| `BTN_NO` | public const string |
| `s_instance` | private static uMyGUI_PopupManager |
| `m_popups` | private uMyGUI_Popup[] |
| `m_popupNames` | private string[] |
| `m_deactivatedElementsWhenPopupIsShown` | private CanvasGroup[] |

### Methods

```csharp
public uMyGUI_Popup ShowPopup(string p_name)
```

```csharp
public uMyGUI_Popup HidePopup(string p_name)
```

```csharp
public uMyGUI_Popup ShowPopup(int p_index)
```

```csharp
public uMyGUI_Popup HidePopup(int p_index)
```

```csharp
public bool HasPopup(string p_name)
```

```csharp
public bool AddPopup(uMyGUI_Popup p_popup, string p_name)
```

```csharp
public bool RemovePopup(uMyGUI_Popup p_popup)
```

```csharp
private uMyGUI_Popup LoadPopupFromResources(string p_name)
```

```csharp
private void Awake()
```

```csharp
private void Update()
```
