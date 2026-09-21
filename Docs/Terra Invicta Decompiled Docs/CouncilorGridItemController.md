# CouncilorGridItemController

*Decompiled from `PavonisInteractive/TerraInvicta/CouncilorGridItemController.cs`.*


## Class `CouncilorGridItemController`

```csharp
public class CouncilorGridItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `controller` | public CouncilGridController |
| `primaryPanel` | public GameObject |
| `councilorName` | public TMP_Text |
| `councilorProfession` | public TMP_Text |
| `councilorLocation` | public TMP_Text |
| `councilorMission` | public TMP_Text |
| `councilorHomeNationFlag` | public Image |
| `backgroundImage` | public Image |
| `councilorStillImage` | public Image |
| `backgroundImageInitialPosition` | private Vector3 |
| `councilorVideoTexture` | public RawImage |
| `councilorVideo` | public VideoPlayer |
| `backgroundMask` | public RectMask2D |
| `persuasion` | public TMP_Text |
| `investigation` | public TMP_Text |
| `espionage` | public TMP_Text |
| `command` | public TMP_Text |
| `administration` | public TMP_Text |
| `science` | public TMP_Text |
| `security` | public TMP_Text |
| `apparentLoyalty` | public TMP_Text |
| `persuasionTitle` | public TMP_Text |
| `investigationTitle` | public TMP_Text |
| `espionageTitle` | public TMP_Text |
| `commandTitle` | public TMP_Text |
| `administrationTitle` | public TMP_Text |
| `scienceTitle` | public TMP_Text |
| `securityTitle` | public TMP_Text |
| `apparentLoyaltyTitle` | public TMP_Text |
| `loyaltyTip` | public TooltipTrigger |
| `moneyIncome` | public TMP_Text |
| `influenceIncome` | public TMP_Text |
| `opsIncome` | public TMP_Text |
| `researchIncome` | public TMP_Text |
| `boostIncome` | public TMP_Text |
| `mCIncome` | public TMP_Text |
| `projects` | public TMP_Text |
| `XPText` | public TMP_Text |
| `XPValue` | public TMP_Text |
| `statusIcon` | public Image |
| `statusText` | public TMP_Text |
| `statusTextContainer` | public GameObject |
| `statusTooltip1` | public TooltipTrigger |
| `statusTooltip2` | public TooltipTrigger |
| `turnedEnemyCouncilorFailurePanel` | public GameObject |
| `turnedEnemyCouncilorFailureText` | public TMP_Text |
| `turnedEnemyCouncilorSlider` | public Slider |
| `factionLoyaltyIcon` | public Image |
| `trackingMePanel` | public GameObject |
| `trackingMeList` | public ListManagerBase |
| `trackingMeTip` | public TooltipTrigger |
| `councilorAdviceButton` | public Button |
| `councilorAdvicePanel` | public GameObject |
| `advanceAdviceButton` | public Button |
| `adviceText` | public TMP_Text |
| `adviceIdx` | public int |

### Properties

- `public TICouncilorState councilor`
- `public int index`

### Methods

```csharp
public void Awake()
```

```csharp
public void Init(CouncilGridController controller, int index)
```

```csharp
public void ItemSelected()
```

```csharp
public void OnClickGotoButton()
```

```csharp
public void UpdateListItem(TICouncilorState councilor, bool forceRefresh = false)
```

```csharp
private IEnumerator StartVideo()
```

```csharp
public void OnAdviceButtonClicked()
```

```csharp
public void OnAdvanceAdviceButtonClicked()
```

```csharp
public void SetAutoFailText()
```

```csharp
public void OnTurnedSliderChangedValue()
```
