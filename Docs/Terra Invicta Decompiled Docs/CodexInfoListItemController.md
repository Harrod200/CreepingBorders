# CodexInfoListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/CodexInfoListItemController.cs`.*


## Class `CodexInfoListItemController`

```csharp
public class CodexInfoListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `controller` | public CodexController |
| `template` | public TICodexEntryTemplate |
| `locTextIndex` | public int |
| `infoText` | public TMP_Text |
| `infoImage` | public Image |
| `titleImage` | public Image |
| `infoIllustration` | public Image |
| `title` | public TMP_Text |
| `subTitle` | public TMP_Text |
| `titleContainer` | public GameObject |
| `usingTemplate` | public bool |
| `templateOverrideString` | public string |
| `templateImagePath` | public string |

### Properties

- `private readonly string[] locTagSeparator = new string[]`
- `private readonly string[] locTagEndSeparator = new string[]`

### Methods

```csharp
public void Init(CodexController controller, TICodexEntryTemplate codexTemplate, int locIndex)
```

```csharp
public void InitCodexTemplateItemWithIcon(CodexController controller, TICodexEntryTemplate codexTemplate, string templateText, string iconPath)
```

```csharp
public void InitCodexTemplateItem(CodexController controller, TICodexEntryTemplate codexTemplate, string templateText)
```

```csharp
public void UpdateListItem()
```
