# OptionsScreenController

*Decompiled from `PavonisInteractive/TerraInvicta/OptionsScreenController.cs`.*


## Class `OptionsScreenController`

```csharp
public class OptionsScreenController : CanvasControllerBase, ICanvas
```

### Fields

| Name | Type |
|---|---|
| `menu` | private MenuManager |
| `optionsMenuController` | public OptionsMenuController |
| `optionsHeaderText` | public TMP_Text |
| `saveGameText` | public TMP_Text |
| `loadGameText` | public TMP_Text |
| `settingsText` | public TMP_Text |
| `exitToMainMenuText` | public TMP_Text |
| `exitGameText` | public TMP_Text |
| `backtoGameText` | public TMP_Text |
| `quoteText` | public TMP_Text |
| `codexButtonText` | public TMP_Text |
| `difficultyText` | public TMP_Text |
| `versionText` | public TMP_Text |
| `mainMenuObject` | public GameObject |
| `loadMenuObject` | public GameObject |
| `saveMenuObject` | public GameObject |
| `settingsMenuObject` | public GameObject |
| `exitToMainMenuButton` | public Button |
| `loadGameButton` | public Button |
| `saveGameButton` | public Button |
| `mainSaveGameButton` | public Button |
| `mainLoadGameButton` | public Button |
| `exitWithoutSaveWarningObject` | public GameObject |
| `exitWarningMask` | public GameObject |
| `exitWithoutSaveWarningText` | public TMP_Text |
| `exitWithoutSaveConfirm` | public TMP_Text |
| `exitWithoutSaveCancel` | public TMP_Text |
| `optionsSettingsHeader` | public TMP_Text |
| `optionsVideoHeader` | public TMP_Text |
| `optionsGraphicsHeader` | public TMP_Text |
| `optionsAudioHeader` | public TMP_Text |
| `optionsGameplayHeader` | public TMP_Text |
| `optionsControlsHeader` | public TMP_Text |
| `optionsNotificationsHeader` | public TMP_Text |
| `crashPanel` | public GameObject |
| `crashHeaderText` | public TMP_Text |
| `crashMainText` | public TMP_Text |
| `crashExceptionText` | public TMP_Text |
| `crashCloseButtonText` | public TMP_Text |
| `crashSaveFolderButtonText` | public TMP_Text |
| `crashLogFolderButtonText` | public TMP_Text |
| `discordLinkText` | public TMP_Text |
| `emailLinkText` | public TMP_Text |
| `emailLabelText` | public TMP_Text |
| `moddingText` | public TMP_Text |
| `quotes` | public string[] |
| `bankedPause` | private bool |
| `fullExiting` | private bool |
| `graphics_SkyboxOption` | public TMP_Text |

### Methods

```csharp
public override void Initialize()
```

```csharp
public override void Show()
```

```csharp
public override void Hide()
```

```csharp
public void OnReturnPressed()
```

```csharp
public void ExitToMainMenu()
```

```csharp
public void PlayMenuButtonAudio()
```

```csharp
public void PlayMenuCloseAudio()
```

```csharp
public void ShowExceptionDialog(string message, string exception)
```

```csharp
public void ShowSaveFolder()
```

```csharp
public void ShowLogFolder()
```

```csharp
public void OnClickDiscordLink()
```

```csharp
public void OnClickEmailLink()
```

```csharp
public void ExitGameWithException()
```

```csharp
public void ExitGame()
```

```csharp
private void ShowExitConfirmation(bool fullExit)
```

```csharp
private void ShowExitWarning()
```

```csharp
public void OnCancelExit()
```

```csharp
public void OnConfirmExit()
```

```csharp
public void OnCodexOpen()
```

```csharp
public override void OnDestroy()
```

```csharp
private void OnSkyboxChanged()
```
