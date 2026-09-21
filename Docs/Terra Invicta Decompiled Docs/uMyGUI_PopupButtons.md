# uMyGUI_PopupButtons

*Decompiled from `LapinerTools/uMyGUI/uMyGUI_PopupButtons.cs`.*


## Class `uMyGUI_PopupButtons`

```csharp
public class uMyGUI_PopupButtons : uMyGUI_Popup
```

### Fields

| Name | Type |
|---|---|
| `m_buttons` | protected RectTransform[] |
| `m_buttonNames` | protected string[] |
| `m_improveNavigationFocus` | protected bool |
| `m_onBtnClickCallbacks` | protected Dictionary<string, Action> |
| `m_audioSources` | protected AudioSource[] |
| `m_isClosing` | protected bool |
| `m_isCloseCanceled` | protected bool |
| `noText` | public TMP_Text |
| `yesText` | public TMP_Text |
| `okText` | public TMP_Text |

### Methods

```csharp
public override void Show()
```

```csharp
public override void Hide()
```

```csharp
public virtual uMyGUI_PopupButtons ShowButton(string p_buttonName)
```

```csharp
public virtual uMyGUI_PopupButtons ShowButton(string p_buttonName, Action p_callback)
```

```csharp
public virtual void OnButtonClick(RectTransform p_btn)
```

```csharp
protected override void Start()
```

```csharp
protected void OnDestroy()
```

```csharp
private void LoadLocalizedText()
```
