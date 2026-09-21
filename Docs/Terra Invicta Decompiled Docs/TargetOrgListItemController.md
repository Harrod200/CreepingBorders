# TargetOrgListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/TargetOrgListItemController.cs`.*


## Class `TargetOrgListItemController`

```csharp
public class TargetOrgListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `controller` | private CouncilorMissionCanvasController |
| `selectButton` | public Button |
| `selectButtonText` | public TMP_Text |
| `successChance` | public TMP_Text |
| `warningIcon` | public Image |
| `owningCouncilorBackground` | public Image |
| `owningCouncilorForeground` | public Image |
| `orgIcon` | public Image |
| `tier` | public TMP_Text |
| `orgName` | public TMP_Text |
| `orgDescription` | public TooltipTrigger |
| `persuasion` | public TMP_Text |
| `investigation` | public TMP_Text |
| `espionage` | public TMP_Text |
| `command` | public TMP_Text |
| `administration` | public TMP_Text |
| `science` | public TMP_Text |
| `security` | public TMP_Text |
| `money` | public TMP_Text |
| `influence` | public TMP_Text |
| `ops` | public TMP_Text |
| `research` | public TMP_Text |
| `boost` | public TMP_Text |
| `missionControl` | public TMP_Text |
| `projects` | public TMP_Text |
| `priority_ECO` | public TMP_Text |
| `priority_WEL` | public TMP_Text |
| `priority_ENV` | public TMP_Text |
| `priority_KNO` | public TMP_Text |
| `priority_GOV` | public TMP_Text |
| `priority_UNI` | public TMP_Text |
| `priority_MIL` | public TMP_Text |
| `priority_OPP` | public TMP_Text |
| `priority_FUN` | public TMP_Text |
| `priority_SPO` | public TMP_Text |
| `priority_FLI` | public TMP_Text |
| `priority_MC` | public TMP_Text |
| `miningBonus` | public TMP_Text |
| `techBonus` | public TMP_Text |
| `missionIcons` | public ListManagerBase |
| `missionIconsGroup` | public HorizontalLayoutGroup |
| `missionsTip` | public TooltipTrigger |
| `org` | private TIOrgState |

### Properties

- `public float toHitValue`

### Methods

```csharp
public void SetListItem(TargetOrgListItem_Data data)
```

```csharp
public void TurnOffListItem()
```

```csharp
public void OnSelectButtonPressed()
```
