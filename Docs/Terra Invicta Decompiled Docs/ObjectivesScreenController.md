# ObjectivesScreenController

*Decompiled from `PavonisInteractive/TerraInvicta/ObjectivesScreenController.cs`.*


## Class `ObjectivesScreenController`

```csharp
public class ObjectivesScreenController : CanvasControllerBase, IInfoScreen, ICanvas
```

### Fields

| Name | Type |
|---|---|
| `objectivesPanelHeader` | public TMP_Text |
| `listContainerHeader` | public TMP_Text |
| `detailContainerHeader` | public TMP_Text |
| `factionIconPanel` | public GameObject |
| `factionIcon` | public Image |
| `factionGradient` | public Image |
| `detailImageContainer` | public GameObject |
| `detailImage` | public Image |
| `detailHeader` | public TMP_Text |
| `detailCategory` | public TMP_Text |
| `detailBodyText` | public TMP_Text |
| `objectiveDetailPanel` | public RectTransform |
| `objectiveDetailPanelVLG` | public VerticalLayoutGroup |
| `headerGradient` | public RectTransform |
| `detailContainer` | public RectTransform |
| `primaryCanvas` | public Canvas |
| `objectivesList` | public ListManagerBase |
| `objectivesTutorialController` | public UITutorialController |

### Methods

```csharp
public override void Initialize()
```

```csharp
public override void UpdateActivePlayerUIElements(bool startup)
```

```csharp
public override void Show()
```

```csharp
public override void Hide()
```

```csharp
public override void Refresh()
```

```csharp
public override bool Visible()
```

```csharp
public void CloseInfoScreen(bool toggle = false)
```

```csharp
public void OnExitButtonSelected()
```

```csharp
public void OnCloseAndPlayClicked()
```

```csharp
private void OnObjectiveComplete(ObjectiveComplete e)
```

```csharp
private void UpdateObjectivesList(TIFactionState faction)
```

```csharp
public void SetSelectedObjectiveEntry(TIObjectiveTemplate objective, string heldDataName, TIFactionState faction)
```
