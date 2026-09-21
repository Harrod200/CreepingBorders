# SteamWorkshopMain

*Decompiled from `LapinerTools/Steam/SteamWorkshopMain.cs`.*


## Class `SteamWorkshopMain`

```csharp
public class SteamWorkshopMain : SteamMainBase<SteamWorkshopMain>
```

### Fields

| Name | Type |
|---|---|
| `OnItemListLoaded` | public event Action<WorkshopItemListEventArgs> |
| `OnSubscribed` | public event Action<WorkshopItemEventArgs> |
| `OnUnsubscribed` | public event Action<WorkshopItemEventArgs> |
| `OnAddedFavorite` | public event Action<WorkshopItemEventArgs> |
| `OnRemovedFavorite` | public event Action<WorkshopItemEventArgs> |
| `OnVoted` | public event Action<WorkshopItemEventArgs> |
| `OnInstalled` | public event Action<WorkshopItemEventArgs> |
| `OnUploaded` | public event Action<WorkshopItemUpdateEventArgs> |
| `Sorting` | public WorkshopSortMode |
| `SearchText` | public string |
| `SearchTags` | public List<string> |
| `SearchMatchAnyTag` | public bool |
| `IsSteamCacheEnabled` | public bool |
| `m_reqPage` | private uint |
| `m_reqItemList` | private WorkshopItemList |
| `m_items` | private Dictionary<PublishedFileId_t, WorkshopItem> |
| `m_downloadingItems` | private List<PublishedFileId_t> |
| `m_uploadItemData` | private WorkshopItemUpdate |
| `m_renderedTexture` | private Texture2D |
| `m_sorting` | private WorkshopSortMode |
| `m_searchText` | private string |
| `m_searchTags` | private List<string> |
| `m_searchMatchAnyTag` | private bool |
| `m_isSteamCacheEnabled` | private bool |

### Methods

```csharp
public bool GetItemList(uint p_page, Action<WorkshopItemListEventArgs> p_onItemListLoaded)
```

```csharp
public bool Subscribe(WorkshopItem p_item, Action<WorkshopItemEventArgs> p_onSubscribed)
```

```csharp
public bool Subscribe(PublishedFileId_t p_fileId, Action<WorkshopItemEventArgs> p_onSubscribed)
```

```csharp
public bool Unsubscribe(WorkshopItem p_item, Action<WorkshopItemEventArgs> p_onUnsubscribed)
```

```csharp
public bool Unsubscribe(PublishedFileId_t p_fileId, Action<WorkshopItemEventArgs> p_onUnsubscribed)
```

```csharp
public bool AddFavorite(WorkshopItem p_item, Action<WorkshopItemEventArgs> p_onAddedFavorite)
```

```csharp
public bool AddFavorite(PublishedFileId_t p_fileId, Action<WorkshopItemEventArgs> p_onAddedFavorite)
```

```csharp
public bool RemoveFavorite(WorkshopItem p_item, Action<WorkshopItemEventArgs> p_onRemovedFavorite)
```

```csharp
public bool RemoveFavorite(PublishedFileId_t p_fileId, Action<WorkshopItemEventArgs> p_onRemovedFavorite)
```

```csharp
public bool Vote(WorkshopItem p_item, bool p_isUpVote, Action<WorkshopItemEventArgs> p_onVoted)
```

```csharp
public bool Vote(PublishedFileId_t p_fileId, bool p_isUpVote, Action<WorkshopItemEventArgs> p_onVoted)
```

```csharp
public float GetDownloadProgress(WorkshopItem p_item)
```

```csharp
public float GetDownloadProgress(PublishedFileId_t p_fileId)
```

```csharp
public float GetUploadProgress(WorkshopItemUpdate p_itemUpdate)
```

```csharp
public bool Upload(WorkshopItemUpdate p_itemData, Action<WorkshopItemUpdateEventArgs> p_onUploaded)
```

```csharp
public void RenderIcon(Camera p_camera, int p_width, int p_height, string p_saveToFilePath, Action<Texture2D> p_onRenderIconCompleted)
```

```csharp
public void RenderIcon(Camera p_camera, int p_width, int p_height, string p_saveToFilePath, bool p_keepTextureReference, Action<Texture2D> p_onRenderIconCompleted)
```

```csharp
public WorkshopItemUpdate GetItemUpdateFromFolder(string p_itemContentFolderPath)
```

```csharp
protected override void LateUpdate()
```

```csharp
private void OnDestroy()
```

```csharp
private void OnAvailableItemsCallCompleted(SteamUGCQueryCompleted_t p_callback, bool p_bIOFailure)
```

```csharp
private void OnPublishedItemsCallCompleted(SteamUGCQueryCompleted_t p_callback, bool p_bIOFailure)
```

```csharp
private void OnFavoriteItemsCallCompleted(SteamUGCQueryCompleted_t p_callback, bool p_bIOFailure)
```

```csharp
private void OnSubscribedItemsCallCompleted(SteamUGCQueryCompleted_t p_callback, bool p_bIOFailure)
```

```csharp
private void OnVotedItemsCallCompleted(SteamUGCQueryCompleted_t p_callback, bool p_bIOFailure)
```

```csharp
private void OnUserVoteCallCompleted(GetUserItemVoteResult_t p_callback, bool p_bIOFailure)
```

```csharp
private void OnSubscribeCallCompleted(RemoteStorageSubscribePublishedFileResult_t p_callback, bool p_bIOFailure)
```

```csharp
private void OnUnsubscribeCallCompleted(RemoteStorageUnsubscribePublishedFileResult_t p_callback, bool p_bIOFailure)
```

```csharp
private void OnFavoriteChangeCallCompleted(UserFavoriteItemsListChanged_t p_callback, bool p_bIOFailure)
```

```csharp
private void OnVoteCallCompleted(SetUserItemVoteResult_t p_callback, bool p_bIOFailure)
```

```csharp
private void OnCreateItemCompleted(CreateItemResult_t p_callback, bool p_bIOFailure)
```

```csharp
private void OnItemUpdateCompleted(SubmitItemUpdateResult_t p_callback, bool p_bIOFailure)
```

```csharp
private WorkshopItem ParseItem(UGCQueryHandle_t p_handle, uint p_indexInHandle, SteamUGCDetails_t p_itemDetails)
```

```csharp
private bool CanAddRequestedItemToList(WorkshopItem item)
```

```csharp
private bool IsInstalled(EItemState p_itemState)
```

```csharp
private bool IsDownloading(EItemState p_itemState)
```

```csharp
private bool IsUpdateNeeded(EItemState p_itemState)
```

```csharp
private uint GetPageCount(SteamUGCQueryCompleted_t p_callback)
```

```csharp
private void QueryPublishedItems(uint p_page)
```

```csharp
private void QueryFavoritedItems(uint p_page)
```

```csharp
private void QueryVotedItems(uint p_page)
```

```csharp
private void QuerySubscribedItems(uint p_page)
```

```csharp
private void QueryAllItems()
```

```csharp
private IEnumerator RenderIconRoutine(Camera p_camera, int p_width, int p_height, string p_saveToFilePath, bool p_keepTextureReference, Action<Texture2D> p_onRenderIconCompleted)
```
