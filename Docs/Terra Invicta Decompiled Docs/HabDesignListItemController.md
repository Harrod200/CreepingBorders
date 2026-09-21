# HabDesignListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/HabDesignListItemController.cs`.*


## Class `HabDesignListItemController`

```csharp
internal class HabDesignListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `applyTemplateButton` | public Button |
| `applyTemplateButtonText` | public TMP_Text |
| `icon` | public Image |
| `spaceObjectIcon` | public Image |
| `designName` | public TMP_Text |
| `habTemplate` | private TIHabTemplate |
| `allModulesList` | public TooltipTrigger |
| `controller` | private HabitatsScreenController |
| `benefitsList` | public TMP_Text |
| `moduleIcons` | public Image[] |
| `renameTemplatePanel` | public GameObject |
| `renameInputField` | public TMP_InputField |
| `backgroundImage` | public Image |

### Methods

```csharp
public void SetListItem(TIHabTemplate template, HabitatsScreenController controller, int listIndex)
```

```csharp
public void OnClickRename()
```

```csharp
public void OnClickRevertRename()
```

```csharp
public void OnClickSaveName()
```

```csharp
public void ShowRenameTemplatePanel()
```

```csharp
public void OnDeleteClicked()
```

```csharp
public void OnClickApplyTemplate()
```
