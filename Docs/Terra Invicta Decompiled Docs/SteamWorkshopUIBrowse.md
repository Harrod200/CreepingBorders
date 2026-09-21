# SteamWorkshopUIBrowse

*Decompiled from `LapinerTools/Steam/UI/SteamWorkshopUIBrowse.cs`.*


## Class `SteamWorkshopUIBrowse`

```csharp
public class SteamWorkshopUIBrowse : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `Instance` | public static SteamWorkshopUIBrowse |
| `OnSortModeChanged` | public event Action<WorkshopSortModeEventArgs> |
| `OnSearchButtonClick` | public event Action<string> |
| `OnPageChanged` | public event Action<int> |
| `OnPlayButtonClick` | public event Action<WorkshopItemEventArgs> |
| `OnVoteUpButtonClick` | public event Action<WorkshopItemEventArgs> |
| `OnVoteDownButtonClick` | public event Action<WorkshopItemEventArgs> |
| `OnSubscribeButtonClick` | public event Action<WorkshopItemEventArgs> |
| `OnUnsubscribeButtonClick` | public event Action<WorkshopItemEventArgs> |
| `OnAddFavoriteButtonClick` | public event Action<WorkshopItemEventArgs> |
| `OnRemoveFavoriteButtonClick` | public event Action<WorkshopItemEventArgs> |
| `OnItemDataSet` | public event Action<SteamWorkshopItemNode.ItemDataSetEventArgs> |
| `s_instance` | protected static SteamWorkshopUIBrowse |
| `ITEM_BROWSER` | protected uMyGUI_TreeBrowser |
| `PAGE_SELCTOR` | protected uMyGUI_PageBox |
| `SORTING` | protected SteamWorkshopUIBrowse.SortingConfig |
| `searchInputField` | protected TMP_InputField |
| `SEARCH_BUTTON` | protected Button |
| `installColumnText` | protected TMP_Text |
| `m_loadOnStart` | protected bool |
| `m_improveNavigationFocus` | protected bool |
| `m_uiNodeToSteamItem` | protected Dictionary<uMyGUI_TreeBrowser.Node, WorkshopItem> |
| `initialized` | private bool |
| `SortingConfig` | public class |
| `DROPDOWN` | public uMyGUI_Dropdown |
| `DEFAULT_SORT_MODE` | public int |
| `OPTIONS` | public SteamWorkshopUIBrowse.SortingConfig.Option[] |
| `Option` | public class |
| `MODE` | public WorkshopSortMode |
| `DISPLAY_TEXT` | public string |

### Methods

```csharp
public void InvokeOnPlayButtonClick(WorkshopItem p_clickedItem)
```

```csharp
public void InvokeOnVoteUpButtonClick(WorkshopItem p_clickedItem)
```

```csharp
public void InvokeOnVoteDownButtonClick(WorkshopItem p_clickedItem)
```

```csharp
public void InvokeOnSubscribeButtonClick(WorkshopItem p_clickedItem)
```

```csharp
public void InvokeOnUnsubscribeButtonClick(WorkshopItem p_clickedItem)
```

```csharp
public void InvokeOnAddFavoriteButtonClick(WorkshopItem p_clickedItem)
```

```csharp
public void InvokeOnRemoveFavoriteButtonClick(WorkshopItem p_clickedItem)
```

```csharp
public void InvokeOnItemDataSet(WorkshopItem p_itemData, SteamWorkshopItemNode p_itemUI)
```

```csharp
public void PulledPublishedItems()
```

```csharp
public void SetItems(WorkshopItemList p_itemList)
```

```csharp
public void LoadItems(int p_page)
```

```csharp
public void Search(string p_searchText)
```

```csharp
protected void SetPage(int p_page)
```

```csharp
protected virtual void Start()
```

```csharp
protected virtual void LateUpdate()
```

```csharp
private void OnLanguageChangedEvent()
```

```csharp
private void LoadLocalizedText()
```

```csharp
protected virtual void OnDestroy()
```

```csharp
protected virtual void ShowErrorMessage(ErrorEventArgs p_errorArgs)
```

```csharp
protected virtual void SetItems(WorkshopItemListEventArgs p_itemListArgs)
```

```csharp
protected virtual uMyGUI_TreeBrowser.Node[] ConvertItemsToNodes(WorkshopItem[] p_items)
```

```csharp
protected virtual void InitSorting()
```

```csharp
protected virtual void InitSearch()
```

```csharp
protected virtual void InvokeEventHandlerSafely<T>(Action<T> p_handler, T p_data)
```
