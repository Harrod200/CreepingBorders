# BaseSiteListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/BaseSiteListItemController.cs`.*


## Class `BaseSiteListItemController`

```csharp
public class BaseSiteListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `site` | private TIHabSiteState |
| `SiteName` | public TMP_Text |
| `statusImage` | public Image |
| `Water` | public TMP_Text |
| `Volatiles` | public TMP_Text |
| `Metals` | public TMP_Text |
| `Nobles` | public TMP_Text |
| `Fissiles` | public TMP_Text |
| `tip` | public TooltipTrigger |
| `victory` | public bool |
| `statusTipValue` | private int |
| `controller` | private SpaceObjectDetailController |

### Methods

```csharp
public void SetListItem(TIHabSiteState habSite, TIFactionState viewingFaction, bool showSiteName, bool victoryBase, SpaceObjectDetailController controller)
```

```csharp
public void SetSiteNameText(bool showSiteName)
```

```csharp
public void OnSiteButtonClicked()
```

```csharp
public void OnBaseIconClicked()
```

```csharp
public string SetStatusTip(int setting)
```
