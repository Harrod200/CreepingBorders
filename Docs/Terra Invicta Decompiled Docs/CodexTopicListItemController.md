# CodexTopicListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/CodexTopicListItemController.cs`.*


## Class `CodexTopicListItemController`

```csharp
public class CodexTopicListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `controller` | public CodexController |
| `template` | public TICodexEntryTemplate |
| `backgroundImage` | public Image |
| `topicTitle` | public TMP_Text |
| `topicIcon` | public Image |
| `dividerLine` | public Image |
| `buttonLayout` | public HorizontalLayoutGroup |

### Methods

```csharp
public void Init(CodexController controller, TICodexEntryTemplate codexTemplate)
```

```csharp
public void OnClickCodexTopic()
```

```csharp
public void UpdateListItem(bool isLastEntry = false, bool nextTopicIsMainTopic = false)
```
