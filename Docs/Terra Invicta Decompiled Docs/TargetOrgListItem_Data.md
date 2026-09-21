# TargetOrgListItem_Data

*Decompiled from `PavonisInteractive/TerraInvicta/TargetOrgListItem_Data.cs`.*


## Class `TargetOrgListItem_Data`

```csharp
public class TargetOrgListItem_Data
```

### Fields

| Name | Type |
|---|---|
| `showInList` | public bool |
| `controller` | public CouncilorMissionCanvasController |
| `selectButtonText` | public string |
| `successChance` | public string |
| `warningIcon` | public Sprite |
| `owningCouncilorBackgroundColor` | public Color32 |
| `owningCouncilorForeground` | public Sprite |
| `orgIcon` | public Sprite |
| `tier` | public string |
| `orgName` | public string |
| `orgDescription` | public string |
| `persuasion` | public string |
| `investigation` | public string |
| `espionage` | public string |
| `command` | public string |
| `administration` | public string |
| `science` | public string |
| `security` | public string |
| `money` | public string |
| `influence` | public string |
| `ops` | public string |
| `research` | public string |
| `boost` | public string |
| `missionControl` | public string |
| `projects` | public string |
| `priority_ECO` | public string |
| `priority_WEL` | public string |
| `priority_ENV` | public string |
| `priority_KNO` | public string |
| `priority_GOV` | public string |
| `priority_UNI` | public string |
| `priority_MIL` | public string |
| `priority_OPP` | public string |
| `priority_FUN` | public string |
| `priority_SPO` | public string |
| `priority_FLI` | public string |
| `priority_MC` | public string |
| `miningBonus` | public string |
| `techBonus` | public string |
| `missionsTip` | public string |
| `org` | public TIOrgState |
| `targetingCouncilor` | public TICouncilorState |
| `missionTemplate` | public TIMissionTemplate |
| `validTarget` | public bool |

### Properties

- `public float toHitValue`

### Methods

```csharp
public void SetTargetOrgData(TIOrgState org, TICouncilorState targetingCouncilor, TIMissionTemplate missionTemplate, bool validTarget, CouncilorMissionCanvasController controller)
```
