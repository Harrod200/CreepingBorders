# HabListItem

*Decompiled from `PavonisInteractive/TerraInvicta/HabListItem.cs`.*


## Class `HabListItem`

```csharp
public class HabListItem : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `Previewer` | public IHabitatsPreviewer |
| `hasInit` | private bool |
| `controller` | public HabitatsScreenController |
| `habIcon` | public Image |
| `SectorIcon` | public Image[] |
| `habName` | public TMP_Text |
| `habLocation` | public TMP_Text |
| `button` | public Button |
| `buttonDefaultBackground` | public Sprite |
| `buttonSelectedBackground` | public Sprite |
| `habState` | public TIHabState |
| `defendedExpiration` | public TooltipTrigger |
| `tierIcon` | public Image |
| `availableBuildSlotsObject` | public GameObject |
| `dockedFleetIconObject` | public GameObject |
| `dockedFleetIcon` | public Image |
| `habPowerAlertIcon` | public GameObject |
| `underConstructionIcon` | public GameObject |
| `defendedObjectIcon` | public GameObject |
| `customHabIcon` | public Image |
| `populationText` | public TMP_Text |
| `resourcesText` | public TMP_Text[] |
| `techText` | public TMP_Text |
| `resupplyImage` | public Image |
| `shipConstructionImage` | public Image |
| `moduleConstructionTimeImage` | public Image |
| `defenseText` | public TMP_Text |
| `assaultText` | public TMP_Text |
| `locationSortValue` | public double |
| `MCSortValue` | public float |
| `WaterSortValue` | public float |
| `VolatilesSortValue` | public float |
| `MetalsSortValue` | public float |
| `NobleMetalsSortValue` | public float |
| `FissilesSortValue` | public float |
| `AntimatterSortValue` | public float |
| `ExoticsSortValue` | public float |
| `ResupplySortValue` | public bool |
| `ShipyardSortValue` | public bool |
| `ConstructionSortValue` | public bool |
| `TierSortValue` | public int |
| `PopulationSortValue` | public int |
| `PowerSortValue` | public bool |
| `ModuleConstructionSortValue` | public bool |
| `MoneySortValue` | public float |
| `InfluenceSortValue` | public float |
| `OpsSortValue` | public float |
| `ResearchSortValue` | public float |
| `ProjectsSortValue` | public float |
| `BoostSortValue` | public float |

### Methods

```csharp
private void Awake()
```

```csharp
private void Start()
```

```csharp
private void Init()
```

```csharp
private void AddListeners()
```

```csharp
private void RemoveListeners()
```

```csharp
private void OnSelect()
```

```csharp
public void SetHabState(TIHabState habState, HabitatsScreenController controller, IHabitatsPreviewer previewer)
```

```csharp
public void SetTextColor(Color color)
```

```csharp
public void SetHighlight(bool highlight)
```

```csharp
public void UpdateData(HabModuleConstructionStatusChange e)
```

```csharp
public void UpdateData(HabPowerManagementUpdated e)
```

```csharp
public void UpdateData(HabModuleDestroyed e)
```

```csharp
public void UpdateData(FleetArrivesAtDestination e)
```

```csharp
public void UpdateData(FleetUndocks e)
```

```csharp
public void UpdateData(HabDefendInterestsUpdated e)
```

```csharp
public void UpdateData(SectorAssignedToFaction e)
```

```csharp
public void UpdateData(BeginBombardment e)
```

```csharp
public void UpdateData(EndBombardment e)
```

```csharp
public void UpdateData(BeginHabAssault e)
```

```csharp
public void UpdateData(EndHabAssault e)
```

```csharp
public string defendedTip()
```

```csharp
public void UpdateItem()
```

```csharp
private void UpdateHabData()
```

```csharp
private void OnDestroy()
```

```csharp
private void RemoveButtonListeners()
```
