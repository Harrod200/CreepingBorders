# SteamWorkshopUIUpload

*Decompiled from `LapinerTools/Steam/UI/SteamWorkshopUIUpload.cs`.*


## Class `SteamWorkshopUIUpload`

```csharp
public class SteamWorkshopUIUpload : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `Instance` | public static SteamWorkshopUIUpload |
| `OnNameSet` | public event Action<string> |
| `OnDescriptionSet` | public event Action<string> |
| `OnTagSet` | public event Action<int> |
| `OnIconFilePathSet` | public event Action<string> |
| `OnIconTextureSet` | public event Action<Texture2D> |
| `OnStartedUpload` | public event Action<WorkshopItemUpdateEventArgs> |
| `OnFinishedUpload` | public event Action<WorkshopItemUpdateEventArgs> |
| `s_instance` | protected static SteamWorkshopUIUpload |
| `ICON_WIDTH` | protected int |
| `ICON_HEIGHT` | protected int |
| `NAME_INPUT` | protected TMP_InputField |
| `DESCRIPTION_INPUT` | protected TMP_InputField |
| `TagsDropdown` | protected TMP_Dropdown |
| `ICON` | protected RawImage |
| `SCREENSHOT_BUTTON` | protected Button |
| `UPLOAD_BUTTON` | protected Button |
| `m_improveNavigationFocus` | protected bool |
| `m_isUploading` | protected bool |
| `m_pendingImageDownload` | protected WWW |
| `m_itemData` | protected WorkshopItemUpdate |

### Methods

```csharp
public virtual void SetItemData(WorkshopItemUpdate p_itemData)
```

```csharp
protected virtual void Start()
```

```csharp
protected virtual void LateUpdate()
```

```csharp
protected virtual void OnDestroy()
```

```csharp
protected virtual void OnEditName(string p_name)
```

```csharp
protected virtual void OnEditDescription(string p_description)
```

```csharp
protected virtual void OnEditTag(int p_tagIndex)
```

```csharp
public void OnExplorerHereClicked()
```

```csharp
protected virtual void OnScreenshotButtonClick()
```

```csharp
protected virtual void OnUploadButtonClick()
```

```csharp
protected virtual void ShowSuccessMessage(WorkshopItemUpdateEventArgs p_successArgs)
```

```csharp
protected virtual void ShowErrorMessage(LapinerTools.Steam.Data.ErrorEventArgs p_errorArgs)
```

```csharp
protected virtual void InvokeEventHandlerSafely<T>(Action<T> p_handler, T p_data)
```

```csharp
protected virtual IEnumerator ShowUploadProgress()
```

```csharp
protected virtual IEnumerator SetDescriptionSafe(string p_description)
```

```csharp
protected virtual IEnumerator LoadIcon(string p_filePath)
```
