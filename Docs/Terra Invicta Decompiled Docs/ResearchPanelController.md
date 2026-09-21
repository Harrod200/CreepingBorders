# ResearchPanelController

*Decompiled from `PavonisInteractive/TerraInvicta/ResearchPanelController.cs`.*


## Class `ResearchPanelController`

```csharp
public class ResearchPanelController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `controller` | private ResearchScreenController |
| `mainInfoPanel` | public GameObject |
| `projectName` | public TMP_Text |
| `summary` | public TMP_Text |
| `piechartCircle` | public Image |
| `wedge` | public Image |
| `techCategoryIcon` | public Image |
| `techCategoryIconFaded` | public Image |
| `techCategoryGradient` | public Image |
| `techCategoryBonus` | public TMP_Text |
| `techTooltip` | public TooltipTrigger |
| `researchTypePanel` | public GameObject |
| `researchTypeIcon` | public Image |
| `researchTypeBonus` | public TMP_Text |
| `researchTooltip` | public TooltipTrigger |
| `progressFraction` | public TMP_Text |
| `completionDate` | public TMP_Text |
| `playerContributionObject` | public GameObject |
| `playerContribution` | public TMP_Text |
| `factionContribution` | public ListManagerBase |
| `factionContributionBar` | public ListManagerBase |
| `leftButtonOverlayPanel` | public GameObject |
| `leftButtonText` | public TMP_Text |
| `rightButtonText` | public TMP_Text |
| `leftPanelHeadline` | public TMP_Text |
| `leftPanelMainText` | public TMP_Text |
| `ContributionWeightPercentageText` | public TMP_Text |
| `forceSelectTechOverlay` | public Canvas |
| `forceSelectTechButtonText` | public TMP_Text |
| `lowPriorityImage` | public Image |
| `mediumPriorityImage` | public Image |
| `highPriorityImage` | public Image |
| `priority` | private int |
| `globalResearchState` | private TIGlobalResearchState |
| `grayColor` | private static readonly Color32 |

### Properties

- `public int slot`

### Methods

```csharp
public void Init(ResearchScreenController controller, int idx)
```

```csharp
public static string TechCategoryTooltip(TIFactionState faction, TIGenericTechTemplate currentGenericTemplate)
```

```csharp
public void UpdatePanel(TIFactionState faction)
```

```csharp
public void OnEnable()
```

```csharp
public void ActivateLeftButtonPanel()
```

```csharp
public void ExitLeftPanel()
```

```csharp
public void ActivateRightButtonPanel()
```

```csharp
public void OnSelectTechButtonSelected()
```

```csharp
public void OnPriorityButtonClicked()
```

```csharp
public void OnRightPriorityButtonClicked()
```
