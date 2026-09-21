# RegionListItem_Data

*Decompiled from `PavonisInteractive/TerraInvicta/RegionListItem_Data.cs`.*


## Class `RegionListItem_Data`

```csharp
public class RegionListItem_Data
```

### Fields

| Name | Type |
|---|---|
| `viewingNation` | public TINationState |
| `showInList` | public bool |
| `regionState` | public TIRegionState |
| `claim` | public bool |
| `hostileClaim_perm` | public bool |
| `hostileClaim_temp` | public bool |
| `claimsOnRegion` | public List<TINationState> |
| `abductionsEnabled` | public bool |
| `abductionsText` | public string |
| `regionNameString` | public string |

### Methods

```csharp
public void SetRegionData(TIRegionState region, bool isClaim, bool isHostileClaim_Perm, bool isHostileClaim_Temp, TINationState viewingNation)
```
