# MapController

*Decompiled from `MapController.cs`.*


## Class `MapController`

```csharp
public class MapController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `initializing` | public bool |
| `isActive` | public bool |
| `GetNationControllers` | public IList<NationController> |
| `mapTransitionTime` | public static float |
| `maxLift` | public float |
| `markerContainerPrefab` | public GameObject |
| `nationContainerPrefab` | public GameObject |
| `nationControllerLookup` | protected Dictionary<string, NationController> |
| `arcs` | protected Dictionary<string, MapArc> |
| `airplaneTexture` | public Sprite |
| `regionTooltips` | public List<TooltipTrigger> |
| `regionTooltipsActive` | private bool |
| `mapTransform` | public Transform |
| `lastLeftClickedRegion` | public RegionClickHandler |
| `lastRightClickedRegion` | public RegionClickHandler |
| `_initializing` | private bool |
| `_isActive` | private bool |
| `spaceController` | private SpaceObjectController |
| `outlineName` | private string |
| `currentOutlines` | private RegionOutlineCollection |
| `lockout` | public bool |
| `lerpLockout` | private bool |

### Methods

```csharp
private void Awake()
```

```csharp
public NationController GetNation(string nationName)
```

```csharp
public NationController GetNation(TINationState nation)
```

```csharp
public RegionController GetRegionController(TIRegionState region)
```

```csharp
public RegionController GetRegionController(string regionName)
```

```csharp
public void AddNationToLookup(NationController newNation, bool replace = false)
```

```csharp
public void SetOutlineWidths(float newWidth)
```

```csharp
public IEnumerator SetRegionVisualizers(bool active)
```

```csharp
public void MakeActive(bool active)
```

```csharp
public void ResetMapColors()
```

```csharp
public void ActivateRegionTooltips()
```

```csharp
public void DeactivateRegionTooltips()
```

```csharp
private void OnEnable()
```

```csharp
private IEnumerator LerpActive(bool show)
```

```csharp
public void SetLiftValue(float newLift, string nationName = "")
```

```csharp
public TIRegionOutline GetOutlineData(string regionName)
```

```csharp
public void InitializeMap(SpaceObjectController controller, string regionAssetPath)
```

```csharp
private void OnMissionPhaseComplete(TimeEventComplete e)
```

```csharp
private string GetKey(TICouncilorState councilorState)
```

```csharp
private void OnMissionAssigned(CouncilorMissionAssigned e)
```

```csharp
private void Fly(TICouncilorState councilor, TIGameState destination)
```

```csharp
private Vector3 GetCouncilorLocation(TIRegionState region, TINationState nation = null)
```

```csharp
public void DrawArc(string key, Sprite sprite, Vector3 start, Vector3 end, TICouncilorState councilor)
```

```csharp
public void RemoveAllArc()
```

```csharp
public void RemoveArc(string lookup)
```

```csharp
public MapArc GetArc(string lookup)
```
