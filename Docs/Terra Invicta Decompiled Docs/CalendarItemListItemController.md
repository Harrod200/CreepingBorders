# CalendarItemListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/CalendarItemListItemController.cs`.*


## Class `CalendarItemListItemController`

```csharp
public class CalendarItemListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `parentItem` | private CalendarDayGridItemController |
| `dateTime` | private TIDateTime |
| `calendarItem` | public TMP_Text |
| `flag1` | public Image |
| `flag2` | public Image |
| `icon` | public Image |
| `button` | public Button |
| `alarm` | private bool |
| `calHLG` | public HorizontalLayoutGroup |

### Methods

```csharp
public void UpdateListItem(CalendarDayGridItemController parent, string itemText, TIDateTime dateTime, bool alarm, string flag1Path = "", string flag2Path = "", string iconPath = "")
```

```csharp
public void OnButtonPressed()
```

```csharp
private void OnEnable()
```

```csharp
private void OnDisable()
```
