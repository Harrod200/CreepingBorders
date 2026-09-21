# SaveMenuController

*Decompiled from `SaveMenuController.cs`.*


## Class `SaveMenuController`

```csharp
public class SaveMenuController : MenuController
```

### Fields

| Name | Type |
|---|---|
| `Singleton` | public static SaveMenuController |
| `optionsScreen` | public OptionsScreenController |
| `saveList` | public CreateSaveFileScrollList |
| `returnButton` | public Button |
| `deleteButton` | public Button |
| `saveButton` | public Button |
| `metadataScreenController` | public MetadataScreenController |
| `saveFileName` | public TMP_InputField |
| `saveFileString` | private string |
| `SaveGameHeader` | public TMP_Text |
| `ReturnText` | public TMP_Text |
| `DeleteText` | public TMP_Text |
| `SaveText` | public TMP_Text |
| `InvalidSaveNameText` | public TMP_Text |
| `savingScreen` | public GameObject |
| `savingText` | public TMP_Text |
| `deletePanelObject` | public GameObject |
| `confirmDeleteText` | public TMP_Text |
| `confirmDeleteButtonText` | public TMP_Text |
| `cancelDeleteButtonText` | public TMP_Text |
| `thisCanvasGroup` | private CanvasGroup |
| `savingFailedOverlay` | public GameObject |
| `savingFailedDialog` | public SavingFailedDialog |

### Methods

```csharp
private void Start()
```

```csharp
private void Awake()
```

```csharp
private void OnEnable()
```

```csharp
private void OnDestroy()
```

```csharp
private void UpdateList(SaveFilesChangedEvent e)
```

```csharp
public override void OnOpen()
```

```csharp
private string GetDefaultSaveFileString()
```

```csharp
private void SaveFileSelected(SaveFile? selectedSaveInfo)
```

```csharp
public bool ValidSaveFileName(string proposedName)
```

```csharp
private bool CompressedFilenameAvailable(string proposedName)
```

```csharp
public void TextEntryMode_Enter()
```

```csharp
public void TextEntryMode_End()
```

```csharp
public void NewFileNameTyped(string newName)
```

```csharp
public void WriteSaveFile()
```

```csharp
public void DisplaySavingFailedDialog(string errorMessage)
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
private void OnApplicationFocus(bool focus)
```

```csharp
public static bool SavingIsBlocked()
```
