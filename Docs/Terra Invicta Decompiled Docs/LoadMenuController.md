# LoadMenuController

*Decompiled from `PavonisInteractive/TerraInvicta/LoadMenuController.cs`.*


## Class `LoadMenuController`

```csharp
public class LoadMenuController : MenuController
```

### Fields

| Name | Type |
|---|---|
| `startMenuController` | public StartMenuController |
| `isImportingAvailable` | private bool |
| `isImporting` | private bool |
| `importMode` | public bool |
| `saveList` | public CreateSaveFileScrollList |
| `loadButton` | public Button |
| `deleteButton` | public Button |
| `continueButton` | public Button |
| `openSaveFolderButton` | public Button |
| `metadataScreenController` | public MetadataScreenController |
| `sceneManager` | private SceneManager |
| `loadHeader` | public TMP_Text |
| `loadButtonText` | public TMP_Text |
| `deleteButtonText` | public TMP_Text |
| `openSaveFolderText` | public TMP_Text |
| `loadingScreen` | public GameObject |
| `loadingText` | public TMP_Text |
| `deletePanelObject` | public GameObject |
| `confirmDeleteText` | public TMP_Text |
| `confirmDeleteButtonText` | public TMP_Text |
| `cancelDeleteButtonText` | public TMP_Text |
| `selectedFilename` | public TMP_Text |
| `importingPopup` | public GameObject |
| `importingPopupText` | public TMP_Text |
| `thisCanvasGroup` | private CanvasGroup |
| `workCycleCount` | private int |
| `secondsSinceLastWorkCycle` | private float |
| `importedSaveStructure` | private SaveStructure |
| `importCallback` | private Action<SaveStructure> |
| `cancelImportCallback` | private Action |

### Methods

```csharp
private void Start()
```

```csharp
private void LoadLocalizedText()
```

```csharp
private void OnLanguageChangedEvent()
```

```csharp
private void Update()
```

```csharp
private void OnEnable()
```

```csharp
private void OnDestroy()
```

```csharp
private void OnApplicationFocus(bool focus)
```

```csharp
public override void OnClose()
```

```csharp
private void UpdateList(SaveFilesChangedEvent e)
```

```csharp
private void SaveFileSelected(SaveFile? saveFileButton)
```

```csharp
public void LoadSaveFile()
```

```csharp
public void LoadSaveFilePath(string saveFilePath)
```

```csharp
public void AskConfirmDeletion()
```

```csharp
public void OnConfirmDelete()
```

```csharp
public void OnCancelDelete()
```

```csharp
public void DeleteSaveFile()
```

```csharp
public void EnterImportMode(Action<SaveStructure> importCallback_, Action cancelImportCallback_ = null)
```

```csharp
public void EnterLoadMode()
```

```csharp
public void OnOpenSaveFolderClicked()
```
