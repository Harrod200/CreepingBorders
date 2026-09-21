# TargetingListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/TargetingListItemController.cs`.*


## Class `TargetingListItemController`

```csharp
public class TargetingListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `councilorName` | public TMP_Text |
| `missionName` | public TMP_Text |
| `successChanceText` | public TMP_Text |
| `councilorImage` | public Image |
| `councilorBackgroundImage` | public Image |
| `tooltip` | public TooltipTrigger |
| `heldMission` | private TIMissionTemplate |
| `heldCouncilor` | private TICouncilorState |
| `heldTarget` | private TIGameState |

### Methods

```csharp
public void OnTargetingItemSelected()
```

```csharp
public void UpdateListItem(TIMissionTemplate mission, TICouncilorState councilor, string successChance, TIGameState target)
```
