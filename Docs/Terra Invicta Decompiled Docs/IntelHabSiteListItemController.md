# IntelHabSiteListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/IntelHabSiteListItemController.cs`.*


## Class `IntelHabSiteListItemController`

```csharp
public class IntelHabSiteListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `site` | public TIHabSiteState |
| `habImage` | public Image |
| `mineImage` | public Image |
| `habSiteName` | public TMP_Text |
| `habName` | public TMP_Text |
| `spaceBodyIcon` | public Image |
| `spaceBodyName` | public TMP_Text |
| `water` | public TMP_Text |
| `volatiles` | public TMP_Text |
| `metals` | public TMP_Text |
| `nobles` | public TMP_Text |
| `fissiles` | public TMP_Text |
| `siteDescription` | public TMP_Text |
| `earthLaunchWindow` | public TMP_Text |
| `playerTagButtonImage` | public Image |
| `controller` | private IntelScreenController |
| `habSiteHohmannTip` | public TooltipTrigger |
| `planetTag` | public PlayerTag |
| `launchWindowPenalty` | public double |
| `orbitValue` | public double |

### Methods

```csharp
public void Initialize(IntelScreenHabSiteListItem_Data data)
```

```csharp
public void Refresh()
```

```csharp
public void OnClickSort(int sort)
```

```csharp
public void OnClickGoto()
```

```csharp
public void OnClickPlanetTag()
```

```csharp
private void SetPlanetTag()
```
