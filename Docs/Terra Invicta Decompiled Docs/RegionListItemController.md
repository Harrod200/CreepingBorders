# RegionListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/RegionListItemController.cs`.*


## Class `RegionListItemController`

```csharp
public class RegionListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `region` | private TIRegionState |
| `regionName` | public TMP_Text |
| `regionPop` | public TMP_Text |
| `regionBoost` | public TMP_Text |
| `regionMC` | public TMP_Text |
| `ClaimsPanel` | public LayoutGroup |
| `regionTooltip` | public TooltipTrigger |
| `occupierFlag` | public Image |
| `occupationPct` | public TMP_Text |
| `backgroundImage` | public Image |
| `claimsList` | public ListManagerBase |
| `abductions` | public TMP_Text |
| `friendlyClaimColor` | public static readonly Color |
| `tempHostileClaimColor` | public static readonly Color |
| `hostileClaimColor` | public static readonly Color |

### Methods

```csharp
public void UpdateListItem(RegionListItem_Data data)
```

```csharp
public void OnRegionButtonPressed()
```
