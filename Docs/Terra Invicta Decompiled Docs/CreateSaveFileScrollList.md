# CreateSaveFileScrollList

*Decompiled from `CreateSaveFileScrollList.cs`.*


## Class `CreateSaveFileScrollList`

```csharp
public class CreateSaveFileScrollList : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `normalSprite` | private Sprite |
| `highlightedSprite` | public Sprite |
| `loadSaveGameButton` | public GameObject |
| `contentPanel` | public Transform |
| `selectedButton` | public LoadSaveButton |
| `metadataScreenController` | public MetadataScreenController |
| `currentCallbackFn` | public CreateSaveFileScrollList.SelectionCallback |
| `lastSaveFileIndex` | public int |
| `savedGamesPath` | private static string |

### Methods

```csharp
private void Start()
```

```csharp
public void OnApplicationQuit()
```

```csharp
public void SetSelectionCallback(CreateSaveFileScrollList.SelectionCallback selFn)
```

```csharp
public void PopulateList()
```

```csharp
public static string GetSaveFolderPath()
```

```csharp
public void SelectSaveFile(LoadSaveButton saveButton)
```

```csharp
private void OnEnable()
```

```csharp
private void OnDisable()
```

```csharp
private void OnChanged(object source, FileSystemEventArgs e)
```

```csharp
private void OnRenamed(object source, RenamedEventArgs e)
```

```csharp
public delegate void SelectionCallback(SaveFile? saveInfo)
```
