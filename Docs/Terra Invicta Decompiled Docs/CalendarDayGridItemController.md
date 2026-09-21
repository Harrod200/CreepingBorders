# CalendarDayGridItemController

*Decompiled from `PavonisInteractive/TerraInvicta/CalendarDayGridItemController.cs`.*


## Class `CalendarDayGridItemController`

```csharp
public class CalendarDayGridItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `dayNumber` | public TMP_Text |
| `todaysEventList` | public ListManagerBase |
| `alarmButton` | public Button |
| `tip` | public TooltipTrigger |
| `date` | private TIDateTime |
| `CooldownPair` | public struct |
| `nation1` | public TINationState |
| `nation2` | public TINationState |
| `CalendarItem` | public struct |
| `dateTime` | public TIDateTime |
| `description` | public string |
| `icon` | public string |
| `flag1` | public string |
| `flag2` | public string |
| `alarm` | public bool |

### Methods

```csharp
public void ClearGridItem()
```

```csharp
private string SetTip(List<CalendarDayGridItemController.CalendarItem> todaysEvents)
```

```csharp
public void UpdateGridItem(TIDateTime date, List<CalendarDayGridItemController.CalendarItem> todaysEvents)
```

```csharp
public void OnAlarmClicked()
```

```csharp
public void OnItemButtonClicked(TIDateTime dateTime, string description)
```

```csharp
public static SortedList<int, List<CalendarDayGridItemController.CalendarItem>> GetMonthlyEvents(TIFactionState faction, TIDateTime date)
```

```csharp
public CalendarItem(TIDateTime dateTime, string description, bool alarm = false, string icon = "", string flag1 = "", string flag2 = "")
```
