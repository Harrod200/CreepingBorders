# CodexController

*Decompiled from `PavonisInteractive/TerraInvicta/CodexController.cs`.*


## Class `CodexController`

```csharp
public class CodexController : CanvasControllerBase
```

### Fields

| Name | Type |
|---|---|
| `primaryPanelTransform` | public RectTransform |
| `allCodexEntries` | public List<TICodexEntryTemplate> |
| `codexTopicListManager` | public ListManagerBase |
| `codexInfoListManager` | public ListManagerBase |
| `selectedTopic` | public TICodexEntryTemplate |
| `resetTutorialButton` | public GameObject |
| `codexItemsContainer` | public RectTransform |
| `codexSearchTitle` | public TMP_Text |
| `codexSearch` | public TMP_InputField |
| `codexSearchDictionary` | public Dictionary<TICodexEntryTemplate, string> |
| `infoLocCount` | private int |
| `codexTutorialController` | public UITutorialController |
| `resetMilestones` | private readonly List<CampaignMilestone> |

### Methods

```csharp
public override void Initialize()
```

```csharp
private void TutorialButtonVisibility()
```

```csharp
public void SelectTopic(string topic)
```

```csharp
public void UpdateCodexSearch()
```

```csharp
public void BuildCodexSearchDictionary()
```

```csharp
private void addSearchKey(TICodexEntryTemplate entry, string searchString)
```

```csharp
private IEnumerator SelectTopicIE(string topic)
```

```csharp
public void DisplayMainCodexText()
```

```csharp
public void ShowCodex(string topic = "codex_welcome")
```

```csharp
public override void UpdateUIScaling()
```

```csharp
public void OnClickCloseCodex()
```

```csharp
public void HideCodex()
```

```csharp
public static void ShowCodexPanel(string topic = "codex_welcome")
```

```csharp
public static void HideCodexPanel()
```

```csharp
public void OnClickResetTutorial()
```

```csharp
private void HandleMissionTemplate(TICodexEntryTemplate template, bool cacheSearchMode = false)
```

```csharp
private void HandleAlienMissionTemplate(TICodexEntryTemplate template, bool cacheSearchMode = false)
```

```csharp
private void HandleTraitTemplate(TICodexEntryTemplate template, bool cacheSearchMode = false)
```

```csharp
private void HandleArmyOperationTemplate(TICodexEntryTemplate template, bool cacheSearchMode = false)
```

```csharp
private void HandlePolicyTemplate(TICodexEntryTemplate template, bool cacheSearchMode = false)
```

```csharp
private void HandleFleetOperationTemplate(TICodexEntryTemplate template, bool cacheSearchMode = false)
```

```csharp
private void HandleTechCategoryList(TICodexEntryTemplate template, bool cacheSearchMode = false)
```

```csharp
private void HandleCouncilorTypeTemplate(TICodexEntryTemplate template, bool cacheSearchMode = false)
```

```csharp
private void HandleOfficerTypeTemplate(TICodexEntryTemplate template, bool cacheSearchMode = false)
```
