# NationsScreenNationListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/NationsScreenNationListItemController.cs`.*


## Class `NationsScreenNationListItemController`

```csharp
public class NationsScreenNationListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `activePlayer` | private TIFactionState |
| `controller` | public NationsScreenController |
| `controlPoint` | public TIControlPoint |
| `nation` | public TINationState |
| `nationLine` | public bool |
| `selectedPresetValue` | private int |
| `customPresetInList` | private bool |
| `priorityPresetDictionary` | private Dictionary<TIPriorityPresetTemplate, int> |
| `canvasGroup` | public CanvasGroup |
| `layoutElement` | public LayoutElement |
| `nationLineObject` | public GameObject |
| `nationName` | public TMP_Text |
| `federationObject` | public GameObject |
| `federationFlag` | public Image |
| `federationName` | public TMP_Text |
| `nationFlag` | public Image |
| `CPImage` | public Image[] |
| `CPCrackdownImage` | public GameObject[] |
| `CPDefendedImage` | public GameObject[] |
| `mostPopularFactionIcon` | public Image |
| `mostPopularFactionValue` | public TMP_Text |
| `myFactionIcon` | public Image |
| `sustainabilityIcon` | public Image |
| `myFactionValue` | public TMP_Text |
| `population` | public TMP_Text |
| `investmentPoints` | public TMP_Text |
| `perCapitaGDP` | public TMP_Text |
| `sustainability` | public TMP_Text |
| `government` | public TMP_Text |
| `education` | public TMP_Text |
| `inequality` | public TMP_Text |
| `cohesion` | public TMP_Text |
| `unrest` | public TMP_Text |
| `funding` | public TMP_Text |
| `research` | public TMP_Text |
| `boost` | public TMP_Text |
| `missionControl` | public TMP_Text |
| `warPeaceIcon` | public Image |
| `miltech` | public TMP_Text |
| `armies` | public TMP_Text |
| `navies` | public TMP_Text |
| `stoFighters` | public TMP_Text |
| `nukes` | public TMP_Text |
| `nationPriorityPresetDropdown` | public TMP_Dropdown |
| `federationTT` | public TooltipTrigger |
| `mostPopularFactionValueTT` | public TooltipTrigger |
| `myFactionValueTT` | public TooltipTrigger |
| `populationTT` | public TooltipTrigger |
| `investmentPointsTT` | public TooltipTrigger |
| `perCapitaGDPTT` | public TooltipTrigger |
| `sustainabilityTT` | public TooltipTrigger |
| `governmentTT` | public TooltipTrigger |
| `educationTT` | public TooltipTrigger |
| `inequalityTT` | public TooltipTrigger |
| `cohesionTT` | public TooltipTrigger |
| `unrestTT` | public TooltipTrigger |
| `fundingTT` | public TooltipTrigger |
| `researchTT` | public TooltipTrigger |
| `boostTT` | public TooltipTrigger |
| `missionControlTT` | public TooltipTrigger |
| `warPeaceIconTT` | public TooltipTrigger |
| `miltechTT` | public TooltipTrigger |
| `armiesTT` | public TooltipTrigger |
| `naviesTT` | public TooltipTrigger |
| `stoFightersTT` | public TooltipTrigger |
| `nuclearWeaponsTT` | public TooltipTrigger |
| `controlPointTT` | public TooltipTrigger[] |
| `policiesTT` | public TooltipTrigger |

### Methods

```csharp
public void SetGameState(TIGameState targetState)
```

```csharp
public void UpdateListItem()
```

```csharp
public void UpdateNationItem(NationsScreenNationListItem_Data data)
```

```csharp
public string BuildRelationsTooltip()
```

```csharp
private string SetControlPointTip(TINationState nation, TIControlPoint controlPoint)
```

```csharp
public void OnClickNationListItemController()
```

```csharp
public void OnNationPriorityTemplateChanged()
```

```csharp
public void OnSyncPrioritiesButtonClicked()
```

```csharp
public void OnGotoNationClicked()
```

```csharp
public void OnCustomPriorityPresetsChanged(CustomPriorityPresetsChanged e)
```
