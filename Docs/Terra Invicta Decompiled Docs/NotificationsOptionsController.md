# NotificationsOptionsController

*Decompiled from `PavonisInteractive/TerraInvicta/NotificationsOptionsController.cs`.*


## Class `NotificationsOptionsController`

```csharp
public class NotificationsOptionsController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `notificationOptionListAdapter` | public NotificationOptionListAdapter |
| `notificationModels` | public List<NotificationOptionListItemModel> |
| `notificationOptionsHeader` | public TMP_Text |
| `notificationOptionsApplyChanges` | public TMP_Text |
| `alertBehaviorHeader` | public TMP_Text |
| `newsFeedBehaviorHeader` | public TMP_Text |
| `timerFeedBehaviorHeader` | public TMP_Text |
| `summaryFeedBehaviorHeader` | public TMP_Text |
| `setDefaultsButtonText` | public TMP_Text |
| `setProfileDefaultsButtonText` | public TMP_Text |
| `applyCurrentasDefaultsButtonText` | public TMP_Text |
| `categoriesOpened` | public Dictionary<string, bool> |
| `categoriesCreated` | private Dictionary<string, bool> |
| `activePlayer` | private TIFactionState |

### Methods

```csharp
private void Awake()
```

```csharp
private void Start()
```

```csharp
private void InitializeLoc()
```

```csharp
public void InitializeNotificationOptions()
```

```csharp
public void ToggleCategoryVisibility(string categoryKey)
```

```csharp
public void SetNotificationModels()
```

```csharp
public void SetDefaults()
```

```csharp
public void SetUserDefaults()
```

```csharp
public void ApplyCurrentSettingsToProfile()
```
