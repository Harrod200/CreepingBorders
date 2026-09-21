# ModMenuController

*Decompiled from `PavonisInteractive/TerraInvicta/ModMenuController.cs`.*


## Class `ModMenuController`

```csharp
public class ModMenuController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `modManager` | public ModManager |
| `modListManager` | public ListManagerBase |
| `ownedItemPopup` | public SteamWorkshopUpdateOwnedItemExampleStatic |
| `workshopBrowser` | public SteamWorkshopUIBrowse |
| `ownedModDropdown` | private uMyGUI_Dropdown |
| `mainModPanel` | public GameObject |
| `steamWorkshopUploadPanel` | public GameObject |
| `steamWorkshopBrowsePanel` | public GameObject |
| `modWarningObject` | public GameObject |
| `useModsToggle` | public Toggle |
| `moddingTitleText` | public TMP_Text |
| `tabWorkshopBrowseText` | public TMP_Text |
| `tabWorkshopUploadText` | public TMP_Text |
| `modsRefreshText` | public TMP_Text |
| `WorkshopUploadTitleText` | public TMP_Text |
| `modNameLabelText` | public TMP_Text |
| `modDescLabelText` | public TMP_Text |
| `modTagLabelText` | public TMP_Text |
| `modExplorerHereText` | public TMP_Text |
| `modUploadText` | public TMP_Text |
| `modUploadHelpText` | public TMP_Text |
| `modUseModsText` | public TMP_Text |
| `modUseModsDescriptionText` | public TMP_Text |
| `modWarningHeaderText` | public TMP_Text |
| `modWarningDescriptionText` | public TMP_Text |
| `modWarningConfirmText` | public TMP_Text |
| `modUpdateButtonText` | public TMP_Text |
| `modSearchPlaceholderText` | public TMP_Text |
| `init` | private bool |
| `pulledPublishedItems` | private bool |

### Methods

```csharp
private void Start()
```

```csharp
private void Initialize()
```

```csharp
public void LoadLocalizedText()
```

```csharp
public void SetSteamWorkshopTabs()
```

```csharp
public void OnClickBackToMainPanel()
```

```csharp
public void OnToggleUseMods()
```

```csharp
public void OnClickTabSteamWorkshopUpload()
```

```csharp
public void OnClickTabSteamWorkshopBrowse()
```

```csharp
public void OnClickUpdateOwnedItem()
```

```csharp
public void ShowModWarningDialog(string warningHeader, string warningDesc)
```

```csharp
public void OnClickCloseModWarningDialog()
```

```csharp
public void OnClickRefreshInstalledMods()
```

```csharp
public void RefreshInstalledMods()
```

```csharp
public void PlayCloseModMenuAudio()
```
