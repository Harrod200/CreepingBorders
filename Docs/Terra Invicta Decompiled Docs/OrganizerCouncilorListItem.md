# OrganizerCouncilorListItem

*Decompiled from `PavonisInteractive/TerraInvicta/OrganizerCouncilorListItem.cs`.*


## Class `OrganizerCouncilorListItem`

```csharp
public class OrganizerCouncilorListItem : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `councilorImage` | public Image |
| `councilorHomeFlag` | public Image |
| `councilorNameText` | public TMP_Text |
| `professionText` | public TMP_Text |
| `adminValueText` | public TMP_Text |
| `adminValue2Text` | public TMP_Text |
| `persuasionValueText` | public TMP_Text |
| `investigationValueText` | public TMP_Text |
| `espionageValueText` | public TMP_Text |
| `commandValueText` | public TMP_Text |
| `scienceValueText` | public TMP_Text |
| `securityValueText` | public TMP_Text |
| `loyaltyValueText` | public TMP_Text |
| `orgTotalText` | public TMP_Text |
| `orgLimitText` | public TMP_Text |
| `adminTooltip` | public TooltipTrigger |
| `persuasionTooltip` | public TooltipTrigger |
| `investigationTooltip` | public TooltipTrigger |
| `espionageTooltip` | public TooltipTrigger |
| `commandTooltip` | public TooltipTrigger |
| `scienceTooltip` | public TooltipTrigger |
| `securityTooltip` | public TooltipTrigger |
| `loyaltyTooltip` | public TooltipTrigger |
| `councilorOrgsList` | public ListManagerBase |
| `councilorTraitsList` | public ListManagerBase |
| `councilorMissionsList` | public ListManagerBase |
| `orgScrollRect` | public ScrollRect |
| `traitScrollRect` | public ScrollRect |
| `missionScrollRect` | public ScrollRect |
| `dragDestination` | public CouncilorOrgsDragDestination |
| `minimizeButton` | public Button |
| `gridController` | private CouncilGridController |
| `councilor` | private TICouncilorState |
| `activePlayer` | private TIFactionState |
| `borderImage` | public Image |
| `minimized` | private bool |

### Methods

```csharp
public void SetListItem(TICouncilorState councilor, CouncilGridController controller)
```

```csharp
public void UpdateListItem()
```

```csharp
public void ToggleMinimize()
```

```csharp
public void PushToTop()
```

```csharp
public void UpdateOrgIsValid(TIOrgState org)
```

```csharp
public void ResetBorder()
```

```csharp
public void UpdateBorderForValidCouncilor()
```

```csharp
public IEnumerator UpdateScrollRectEnabled(ScrollRect scrollRect, bool enabled)
```
