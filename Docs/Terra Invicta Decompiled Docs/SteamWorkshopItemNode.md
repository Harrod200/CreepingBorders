# SteamWorkshopItemNode

*Decompiled from `LapinerTools/Steam/UI/SteamWorkshopItemNode.cs`.*


## Class `SteamWorkshopItemNode`

```csharp
public class SteamWorkshopItemNode : MonoBehaviour, IScrollHandler, IEventSystemHandler
```

### Fields

| Name | Type |
|---|---|
| `Image` | public RawImage |
| `nameText` | public TMP_Text |
| `descriptionText` | public TMP_Text |
| `modDescriptionTooltipTrigger` | public TooltipTrigger |
| `voteCountText` | public TMP_Text |
| `m_btnVotesUp` | protected Button |
| `m_btnVotesUpActive` | protected Button |
| `m_btnVotesDown` | protected Button |
| `m_btnVotesDownActive` | protected Button |
| `favoritesCountText` | public TMP_Text |
| `m_btnFavorites` | protected Button |
| `m_btnFavoritesActive` | protected Button |
| `subscriptionCountText` | public TMP_Text |
| `downloadProgressText` | public TMP_Text |
| `m_btnSubscriptions` | protected Button |
| `m_btnSubscriptionsActive` | protected Button |
| `m_image` | protected RawImage |
| `m_selectionImage` | protected Image |
| `m_btnDownload` | protected Button |
| `m_btnPlay` | protected Button |
| `m_btnDelete` | protected Button |
| `m_useExplicitNavigation` | protected bool |
| `m_improveNavigationFocus` | protected bool |
| `m_data` | protected SteamWorkshopItemNode.SendMessageInitData |
| `m_parentScroller` | protected ScrollRect |
| `m_pendingImageDownload` | protected WWW |
| `isDestroyed` | protected bool |
| `EventArgsBase` | public class ItemDataSetEventArgs : |
| `SendMessageInitData` | public class |

### Properties

- `public WorkshopItem ItemData`
- `public SteamWorkshopItemNode ItemUI`
- `public WorkshopItem Item`

### Methods

```csharp
public virtual void uMyGUI_TreeBrowser_InitNode(object p_data)
```

```csharp
private IEnumerator Fixtext()
```

```csharp
public virtual void OnScroll(PointerEventData data)
```

```csharp
public virtual void Select()
```

```csharp
protected virtual void Start()
```

```csharp
protected virtual void OnDestroy()
```

```csharp
protected virtual void OnPlayBtn()
```

```csharp
protected virtual void Subscribe()
```

```csharp
protected virtual void Unsubscribe()
```

```csharp
protected virtual void AddFavorite()
```

```csharp
protected virtual void RemovedFavorite()
```

```csharp
protected virtual void VoteUp()
```

```csharp
protected virtual void VoteDown()
```

```csharp
protected virtual void OnItemInstalled(WorkshopItemEventArgs p_itemArgs)
```

```csharp
protected virtual Action<WorkshopItemEventArgs> OnItemUpdated(Selectable p_focusWhenDone)
```

```csharp
protected virtual void SetNavigationTargetsHorizontal(Selectable[] p_horizontalNavOrder)
```

```csharp
protected virtual void SetNavigationTargetsVertical(Selectable p_current, Selectable[] p_verticalNavOrder)
```

```csharp
protected virtual IEnumerator SetNavigationTargetsVertical()
```

```csharp
protected virtual void SetAutomaticNavigation(Selectable p_selectable)
```

```csharp
protected virtual IEnumerator ShowDownloadProgress()
```

```csharp
protected virtual IEnumerator DownloadPreview(string p_URL)
```
