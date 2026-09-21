# NotificationSummaryItem

*Decompiled from `NotificationSummaryItem.cs`.*


## Class `NotificationSummaryItem`

```csharp
public class NotificationSummaryItem
```

### Fields

| Name | Type |
|---|---|
| `template` | public TINotificationTemplate |
| `templateName` | public string |
| `itemSummary` | public string |
| `dateTimeString` | public string |
| `iconResource` | public string |
| `iconBackgroundResource` | public string |
| `backgroundColor` | public Color |
| `outcome` | public TIMissionOutcome |
| `gotoGameState` | public TIGameState |
| `alienRelated` | public bool |
| `dateTime` | public TIDateTime |
| `_template` | private TINotificationTemplate |
| `timerFactions` | public List<TIFactionState> |
| `newsFeedFactions` | public List<TIFactionState> |
| `summaryLogFactions` | public List<TIFactionState> |

### Methods

```csharp
public NotificationSummaryItem(string itemSummary, string iconResource, string iconBackgroundResource, Color backgroundColor, TIGameState gotoGameState, bool alienRelated, TIDateTime dateTime, string templateName, List<TIFactionState> timerFactions, List<TIFactionState> newsFeedFactions, List<TIFactionState> summaryLogFactions, TIMissionOutcome outcome)
```

```csharp
public void UpdateGotoGameState(TIGameState state)
```
