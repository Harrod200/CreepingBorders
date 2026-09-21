# uMyGUI_PopupDropdown

*Decompiled from `LapinerTools/uMyGUI/uMyGUI_PopupDropdown.cs`.*


## Class `uMyGUI_PopupDropdown`

```csharp
public class uMyGUI_PopupDropdown : uMyGUI_PopupText
```

### Fields

| Name | Type |
|---|---|
| `m_dropdown` | protected uMyGUI_Dropdown |
| `m_onSelected` | protected Action<int> |
| `dropDownHeader` | public TMP_Text |

### Methods

```csharp
private new void Start()
```

```csharp
public override void Show()
```

```csharp
public override void Hide()
```

```csharp
public virtual uMyGUI_PopupDropdown SetEntries(string[] p_entries)
```

```csharp
public virtual uMyGUI_PopupDropdown SetOnSelected(Action<int> p_onSelected)
```
