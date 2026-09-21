# NationsScreenController

*Decompiled from `PavonisInteractive/TerraInvicta/NationsScreenController.cs`.*


## Class `NationsScreenController`

```csharp
public class NationsScreenController : CanvasControllerBase, IInfoScreen, ICanvas
```

### Fields

| Name | Type |
|---|---|
| `NationsPanelHeader` | public TMP_Text |
| `primaryCanvas` | public Canvas |
| `filterFactionToggle` | public Toggle |
| `NationsScreenUITutorialController` | public UITutorialController |
| `nationItemDictionary` | public Dictionary<NationsScreenNationListItemController, TIGameState> |
| `nationOpenedStatus` | public Dictionary<NationsScreenNationListItemController, bool> |
| `filterFaction` | public TIFactionState |
| `primaryList` | public ListManagerBase |
| `nationModels` | public List<NationScreenNationListItemModel> |
| `nationListAdapter` | public NationScreenNationListAdapter |
| `initialized` | private bool |
| `currentNationSort` | private SortNationDataBy |
| `reverseSort` | private bool |
| `fullScreenPanel` | public GameObject |
| `showAllNationsText` | public TMP_Text |
| `nameColumnText` | public TMP_Text |
| `controlPointColumnText` | public TMP_Text |
| `playerFactionIcon` | public Image |
| `highestPopularityIcon` | public Image |
| `stoFightersPanelImage` | public Image |
| `stoFightersPanelButton` | public Button |
| `updateDelta_s` | private const float |
| `timeToNextUpdate_s` | private float |
| `firstSort` | private bool |
| `canViewSTOFighters` | public bool |
| `allNationsList` | private List<TIGameState> |
| `suppressDropDownAudio` | public bool |
| `CPBreakdown` | public GameObject |
| `CPBreakdownHeader` | public TMP_Text |
| `CPMaintenanceText` | public TMP_Text |
| `OpenCPBreakdownButtonText` | public TMP_Text |
| `CloseCPBreakdownButtonText` | public TMP_Text |

### Methods

```csharp
public override void Initialize()
```

```csharp
private void InitializeMainList()
```

```csharp
public void BuildMainList(List<TINationState> allNations, bool initialization)
```

```csharp
public void SetNationListModelData()
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
public void OnNationGrowsControlPoint(NationGrowsNewControlPoint e)
```

```csharp
public void OnNationShedsControlPoint(NationShedsControlPoint e)
```

```csharp
public override bool Visible()
```

```csharp
public void CloseInfoScreen(bool toggle = false)
```

```csharp
public override void UpdateUIScaling()
```

```csharp
public void OnExitButtonSelected()
```

```csharp
public void ToggleFilterFaction(bool playAudio = true)
```

```csharp
public void SortNationDictionary(int sortBy)
```

```csharp
public void SortNationDictionary(int sortBy, bool forceSameOrder)
```

```csharp
public List<NationsScreenNationListItemController> GetControlPointLinesForNation(TINationState nation)
```

```csharp
public NationsScreenNationListItemController GetNationLineForControlPoint(TIControlPoint controlPoint)
```

```csharp
public void UpdateFullList()
```

```csharp
public IEnumerator UpdateFullListGradual()
```

```csharp
public void OnOpenCPBreakdown()
```

```csharp
public void OnCloseCPBreakdown()
```

```csharp
public void UpdateCPBreakdown()
```
