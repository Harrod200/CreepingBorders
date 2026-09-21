# IntelSpaceBodyListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/IntelSpaceBodyListItemController.cs`.*


## Class `IntelSpaceBodyListItemController`

```csharp
public class IntelSpaceBodyListItemController : MonoBehaviour, IListPaneItem<TISpaceBodyState>
```

### Fields

| Name | Type |
|---|---|
| `spaceBodyIcon` | public Image |
| `spaceBodyName` | public TMP_Text |
| `description` | public TMP_Text |
| `description2` | public TMP_Text |
| `orbitIcon` | public Image |
| `orbitSemimajor_Axis` | public TMP_Text |
| `dimensions` | public TMP_Text |
| `waterValueIcon` | public Image |
| `volatilesValueIcon` | public Image |
| `metalsValueIcon` | public Image |
| `noblesValueIcon` | public Image |
| `fertilesValueIcon` | public Image |
| `solarValueIcon` | public Image |
| `prospectedIcon` | public Image |
| `canResendProspectorMarker` | public Image |
| `habSitesCount` | public TMP_Text |
| `habSitesIcon` | public GameObject |
| `earthLaunchWindow` | public TMP_Text |
| `habSiteHohmannTip` | public TooltipTrigger |
| `orderProspecting` | public Button |
| `prospectTooltip` | public TooltipTrigger |
| `orbitSortWeight` | public double |
| `DescSortWeight` | public double |
| `orbitValue` | public double |
| `sizeValue` | public double |
| `sumWater` | public SiteProfileRating |
| `sumVolatiles` | public SiteProfileRating |
| `sumMetals` | public SiteProfileRating |
| `sumNobles` | public SiteProfileRating |
| `sumFissiles` | public SiteProfileRating |
| `sumSolar` | public float |
| `prospectedRecorded` | private bool |
| `spaceBody` | public TISpaceBodyState |
| `intelController` | private IntelScreenController |
| `stationsGrid` | public ListManagerBase |
| `basesGrid` | public ListManagerBase |
| `habInfoTip1` | public TooltipTrigger |
| `habInfoTip2` | public TooltipTrigger |
| `playerTagButtonImage` | public Image |

### Methods

```csharp
public void Initialize(TISpaceBodyState spaceBody)
```

```csharp
public void SetSiteProfileRatingIconsAndValues()
```

```csharp
public void OnClickSortButton(int sortValue)
```

```csharp
public void OnClickGotoButton()
```

```csharp
public void OnClickProspectButton()
```

```csharp
private string SetProspectTooltip(TIResourcesCost cost, bool overtake)
```

```csharp
private string SetHabValuesTooltip()
```

```csharp
public void Refresh()
```

```csharp
private void SetPlanetTag()
```

```csharp
public void OnClickPlanetTag()
```
