# IntelFactionGridItemController

*Decompiled from `PavonisInteractive/TerraInvicta/IntelFactionGridItemController.cs`.*


## Class `IntelFactionGridItemController`

```csharp
public class IntelFactionGridItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `factionName` | public TMP_Text |
| `factionIcon` | public Image |
| `factionLeaderBackgroundIcon` | public Image |
| `factionLeader` | public TMP_Text |
| `factionGoal` | public TMP_Text |
| `factionVictory` | public TMP_Text |
| `factionColorBackgroundImage` | public Image |
| `factionLeaderNameGradientImage` | public Image |
| `factionVictoryGradientImage` | public Image |
| `factionLeaderImage` | public Image |
| `penetratedLabel` | public TMP_Text |
| `councilorsTabTitle` | public TMP_Text |
| `resourcesTabTitle` | public TMP_Text |
| `objectivesTabTitle` | public TMP_Text |
| `relationsTabTitle` | public TMP_Text |
| `techTabTitle` | public TMP_Text |
| `councilorTab` | public TabbedPaneController |
| `resourcesTab` | public TabbedPaneController |
| `objectivesTab` | public TabbedPaneController |
| `relationsTab` | public TabbedPaneController |
| `projectsTab` | public TabbedPaneController |
| `factionTabbedPaneManager` | public TabbedPaneManager |
| `councilorsTabButton` | public Button |
| `resourcesTabButton` | public Button |
| `objectivesTabButton` | public Button |
| `relationsTabButton` | public Button |
| `projectsTabButton` | public Button |
| `setIgnoreFactionButtonObject` | public GameObject |
| `setAllowCommsFactionButtonObject` | public GameObject |
| `ignoringThisFactionTT` | public TooltipTrigger |
| `allowingCommsFromThisFactionTT` | public TooltipTrigger |
| `setIgnoreFactionDiplomacyButtonObject` | public GameObject |
| `setAllowFactionDiplomacyButtonObject` | public GameObject |
| `ignoringFactionDiplomacyTT` | public TooltipTrigger |
| `allowingFactionDiplomacyTT` | public TooltipTrigger |
| `councilorList` | public ListManagerBase |
| `councilorListItems` | private IntelCouncilorListItem[] |
| `money` | public TMP_Text |
| `influence` | public TMP_Text |
| `ops` | public TMP_Text |
| `boost` | public TMP_Text |
| `missionControl` | public TMP_Text |
| `research` | public TMP_Text |
| `projects` | public TMP_Text |
| `water` | public TMP_Text |
| `volatiles` | public TMP_Text |
| `metals` | public TMP_Text |
| `nobles` | public TMP_Text |
| `fertiles` | public TMP_Text |
| `antimatter` | public TMP_Text |
| `exotics` | public TMP_Text |
| `controlPoints` | public TMP_Text |
| `cpSprite` | public Image |
| `antimatterPanel` | public GameObject |
| `exoticsPanel` | public GameObject |
| `objectivesList` | public ListManagerBase |
| `noKnownObjectivesText` | public TMP_Text |
| `projectsList` | public ListManagerBase |
| `projectListItems` | private IntelProjectsListItemController[] |
| `relationsGrid` | public ListManagerBase |
| `faction` | private TIFactionState |
| `factionView` | private FactionView |
| `intelController` | private IntelScreenController |

### Methods

```csharp
public void Initialize(TIFactionState faction, IntelScreenController intelController)
```

```csharp
public void Refresh()
```

```csharp
private void RefreshResources()
```

```csharp
public void RefreshCouncilors()
```

```csharp
private void RefreshObjectives()
```

```csharp
private void RefreshRelations()
```

```csharp
private void RefreshProjects()
```

```csharp
private void OnCouncilCompositionChanged(CouncilCompositionChanged e)
```

```csharp
private void OnClickRelations()
```

```csharp
private void OnClickObjectives()
```

```csharp
private void OnClickResources()
```

```csharp
private void OnClickProjects()
```

```csharp
private void OnClickCouncilors()
```

```csharp
public void OnLeaderImageClicked()
```

```csharp
public void OnIgnoreFaction()
```

```csharp
public void OnAllowFactionContacts()
```

```csharp
public void OnIgnoreFactionNationDiplo()
```

```csharp
public void OnAllowFactionNationDiplo()
```
