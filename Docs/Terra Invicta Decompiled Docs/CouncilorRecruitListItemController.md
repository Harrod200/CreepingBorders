# CouncilorRecruitListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/CouncilorRecruitListItemController.cs`.*


## Class `CouncilorRecruitListItemController`

```csharp
public class CouncilorRecruitListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `controller` | private CouncilGridController |
| `candidateName` | public TMP_Text |
| `profession` | public TMP_Text |
| `cost` | public TMP_Text |
| `persuasion` | public TMP_Text |
| `investigation` | public TMP_Text |
| `espionage` | public TMP_Text |
| `command` | public TMP_Text |
| `administration` | public TMP_Text |
| `science` | public TMP_Text |
| `security` | public TMP_Text |
| `loyalty` | public TMP_Text |
| `persuasionTitle` | public TMP_Text |
| `investigationTitle` | public TMP_Text |
| `espionageTitle` | public TMP_Text |
| `commandTitle` | public TMP_Text |
| `administrationTitle` | public TMP_Text |
| `scienceTitle` | public TMP_Text |
| `securityTitle` | public TMP_Text |
| `loyaltyTitle` | public TMP_Text |
| `jobTooltip` | public TooltipTrigger |
| `portrait` | public Image |
| `nationalityFlag` | public Image |
| `councilor` | public TICouncilorState |
| `council` | public TIFactionState |
| `backgroundImage` | public Image |
| `defaultBackground` | public Sprite |
| `selectedBackground` | public Sprite |
| `newRibbon` | public Image |

### Methods

```csharp
public void Init(CouncilGridController controller)
```

```csharp
public void ItemSelected()
```

```csharp
public void UpdateListItem(TICouncilorState councilor, TIFactionState council)
```

```csharp
public void SetSelected(bool selected)
```
