# NotificationOptionListItem

*Decompiled from `PavonisInteractive/TerraInvicta/NotificationOptionListItem.cs`.*


## Class `NotificationOptionListItem`

```csharp
public class NotificationOptionListItem : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `template` | public TINotificationTemplate |
| `notificationName` | public TMP_Text |
| `alertBehaviorToggle` | public Toggle |
| `newsFeedBehaviorToggle` | public Toggle |
| `timerFeedBehaviorToggle` | public Toggle |
| `summaryFeedBehaviorToggle` | public Toggle |
| `toggleHeaderButton` | public Button |
| `headerObject` | public GameObject |
| `headerText` | public TMP_Text |
| `headerCategoryKey` | public string |
| `controller` | public NotificationsOptionsController |

### Methods

```csharp
public void UpdateListItem(NotificationOptionListItem_Data data)
```

```csharp
public void UpdateListItem(TINotificationTemplate notificationTemplate, TINotificationTemplateOverride notificationOverride = null)
```

```csharp
private bool ShowCheckmark(TINotificationTemplateOverride templateOverride, int notificationType)
```

```csharp
public void UpdateToggle(int notificationType)
```

```csharp
public void OnToggleHeaderStatus()
```

```csharp
private void ModifyOverride(int notificationType)
```
