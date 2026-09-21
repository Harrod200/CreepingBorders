# HabModelController

*Decompiled from `PavonisInteractive/TerraInvicta/HabModelController.cs`.*


## Class `HabModelController`

```csharp
public class HabModelController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `habComponentLink` | public HabComponent |
| `councilorControllers` | public List<SpaceCouncilorController> |
| `sectorDataControllers` | public List<SectorDataPanelController> |
| `habModuleControllers` | private List<HabModuleController> |
| `spaceObjectController` | private SpaceObjectController |
| `shuttleObject` | private GameObject |
| `habState` | private TIHabState |
| `showUIIcons` | private bool |
| `viewed` | private bool |
| `lastViewedTime` | private TIDateTime |
| `gameTime` | private GameTimeManager |
| `fullSolarSystemVisualization` | private bool |
| `mouseOverHabUIIcon` | public bool |
| `killerFleet` | private TISpaceFleetState |

### Methods

```csharp
public void Initialize(TIHabState habState, bool fullSolarSystemVisualization, SpaceObjectController spaceObjectController = null)
```

```csharp
public void OnEnable()
```

```csharp
public void OnDisable()
```

```csharp
public void TurnOffIcons()
```

```csharp
public void TurnOnIcons()
```

```csharp
private void RandomizeShuttleModel()
```

```csharp
private bool RandomizeShuttleModule()
```

```csharp
private float ShowShuttleChance()
```

```csharp
public void UpdateAllCouncilors(CouncilorPositionUpdated e)
```

```csharp
public void UpdateAllCouncilors(CouncilorDepartsHab e)
```

```csharp
public void UpdateAllCouncilors(TICouncilorState conditionalCouncilor = null)
```

```csharp
public bool CanUseMarker(SpaceCouncilorController controller)
```

```csharp
public void AddCouncilorMarker(TICouncilorState councilor)
```

```csharp
public List<HabModuleController> GetModuleControllers()
```

```csharp
public void HabHitByNukeInCombat(TIFactionState shootingFaction, Vector3 hitLocation)
```

```csharp
private IEnumerator NuclearBlastDestroyModules(TIFactionState shootingFaction, List<HabModuleController> modules)
```

```csharp
public void OnHabDestroyed(HabDestroyed e)
```

```csharp
private void HabDestroyed()
```

```csharp
public void OnDestroy()
```
