# NewsFeedListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/NewsFeedListItemController.cs`.*


## Class `NewsFeedListItemController`

```csharp
public class NewsFeedListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `item` | public NotificationSummaryItem |
| `itemIcon` | public Image |
| `itemIconBackground` | public Image |
| `itemHeadline` | public TMP_Text |
| `detailTooltipTrigger` | public TooltipTrigger |
| `gotoButton` | public Button |
| `additionalImage` | public Image |
| `secondaryIcon` | public Image |

### Methods

```csharp
public void UpdateListItem(NotificationSummaryItem item, bool showText, bool useMoreSecondaryIcons)
```

```csharp
public void FlashNewsIcon()
```

```csharp
private IEnumerator FlashNewsIconEffect()
```

```csharp
public IEnumerator FadeOutIconEffect()
```

```csharp
public void OnClick()
```

```csharp
public void OnRightClick()
```

```csharp
public void FadeOutIcon()
```

```csharp
private void HideNewsItem()
```
