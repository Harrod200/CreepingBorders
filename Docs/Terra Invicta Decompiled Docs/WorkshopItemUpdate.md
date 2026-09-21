# WorkshopItemUpdate

*Decompiled from `LapinerTools/Steam/Data/WorkshopItemUpdate.cs`.*


## Class `WorkshopItemUpdate`

```csharp
public class WorkshopItemUpdate
```

### Fields

| Name | Type |
|---|---|
| `SteamNativeData` | public class |

### Properties

- `public string Name`
- `public string Description`
- `public string IconPath`
- `public string ContentPath`
- `public string ChangeNote`
- `public List<string> Tags`
- `public WorkshopItemUpdate.SteamNativeData SteamNative`
- `public PublishedFileId_t m_nPublishedFileId`
- `public UGCUpdateHandle_t m_uploadHandle`
- `public EItemUpdateStatus m_lastValidUpdateStatus`

### Methods

```csharp
public WorkshopItemUpdate()
```

```csharp
public WorkshopItemUpdate(WorkshopItem p_existingItem)
```

```csharp
public WorkshopItemUpdate(PublishedFileId_t p_existingPublishedFileId)
```

```csharp
public SteamNativeData()
```

```csharp
public SteamNativeData(PublishedFileId_t p_nPublishedFileId)
```
