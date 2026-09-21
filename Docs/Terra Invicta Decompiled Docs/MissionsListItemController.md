# MissionsListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/MissionsListItemController.cs`.*


## Class `MissionsListItemController`

```csharp
public class MissionsListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `missionIcon` | public Image |
| `missionName` | public TMP_Text |
| `missionDescription` | public TooltipTrigger |
| `sourceIcon` | public Image |
| `councilorsWithMissionCount` | public TMP_Text |
| `councilorsWithMissionIcon` | public Image |
| `lineSeparator` | public Image |
| `headerBackgroundObject` | public Image |
| `automateSettingsToggle` | public Toggle |
| `councilorsWithMissionToolTip` | public TooltipTrigger |
| `councilorState` | private TICouncilorState |
| `missionTemplate` | private TIMissionTemplate |
| `inAutomateMode` | public bool |

### Methods

```csharp
public void SetListItem(TIMissionTemplate missionTemplate, TICouncilorState councilor, int totalCouncilorsWithMission = -1, bool automateMode = false, bool disableLineSeparator = false)
```

```csharp
public void SetListItem(CouncilorAttribute attribute, TICouncilorState councilor, TIMissionTemplate missionTemplate = null, bool isHeader = false, bool isFirstHeader = false)
```

```csharp
public void SetSimpleListItem(TIMissionTemplate missionTemplate, TICouncilorState councilor)
```

```csharp
public void OnToggleAutomateMode()
```
