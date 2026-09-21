# WorkshopItem

*Decompiled from `LapinerTools/Steam/Data/WorkshopItem.cs`.*


## Class `WorkshopItem`

```csharp
public class WorkshopItem
```

### Fields

| Name | Type |
|---|---|
| `SteamNativeData` | public class |

### Properties

- `public string Name`
- `public string SanitizedName`
- `public string Description`
- `public string OwnerName`
- `public string PreviewImageURL`
- `public uint VotesUp`
- `public uint VotesDown`
- `public ulong Subscriptions`
- `public ulong Favorites`
- `public bool IsSubscribed`
- `public bool IsFavorited`
- `public bool IsVotedUp`
- `public bool IsVotedDown`
- `public bool IsVoteSkipped`
- `public bool IsOwned`
- `public bool IsInstalled`
- `public bool IsDownloading`
- `public bool IsUpdateNeeded`
- `public string InstalledLocalFolder`
- `public ulong InstalledSizeOnDisk`
- `public DateTime InstalledTimestamp`
- `public WorkshopItem.SteamNativeData SteamNative`
- `public PublishedFileId_t m_nPublishedFileId`
- `public SteamUGCDetails_t m_details`
- `public EItemState m_itemState`

### Methods

```csharp
public WorkshopItem()
```

```csharp
public SteamNativeData()
```

```csharp
public SteamNativeData(PublishedFileId_t p_nPublishedFileId)
```
