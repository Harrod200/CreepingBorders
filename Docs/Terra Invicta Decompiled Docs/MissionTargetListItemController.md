# MissionTargetListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/MissionTargetListItemController.cs`.*


## Class `MissionTargetListItemController`

```csharp
public class MissionTargetListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `targetIcon` | public Image |
| `orgFlag` | public Image |
| `orgTier` | public TMP_Text |
| `targetTooltip` | public TooltipTrigger |
| `targetText` | public TMP_Text |
| `controller` | private NotificationScreenController |
| `project` | private TIProjectTemplate |
| `org` | private TIOrgState |
| `orgListItem` | private bool |
| `orgDetailObject` | public GameObject |
| `orgNationFlag` | public Image |
| `assignedCouncilorIcon` | public Image |
| `summaryDescription` | public TMP_Text |
| `missionImages` | public List<Image> |

### Methods

```csharp
public void Init(NotificationScreenController controller)
```

```csharp
public void SetListItem(TIOrgState org)
```

```csharp
public void SetListItem(TIProjectTemplate project)
```

```csharp
public void SetListItem(TIFactionState faction, ProjectProgress projectProgress)
```

```csharp
public void OnClicked()
```
