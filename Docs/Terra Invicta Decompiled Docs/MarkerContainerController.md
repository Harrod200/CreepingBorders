# MarkerContainerController

*Decompiled from `PavonisInteractive/TerraInvicta/MarkerContainerController.cs`.*


## Class `MarkerContainerController`

```csharp
public class MarkerContainerController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `canvasWidth` | public float |
| `canvasHeight` | public float |
| `markerPrefab` | public GameObject |
| `thisCanvas` | public Canvas |
| `rectTransform` | public RectTransform |
| `region` | private RegionController |
| `template` | private TIMapGroupVisualizerTemplate |
| `mainCamera` | private Camera |
| `map` | private Transform |
| `markers` | private List<MarkerController> |
| `minScale` | private const float |
| `maxScale` | private const float |
| `iconTimeToSettle` | private const float |
| `scaleMultiplier` | private const float |
| `modelScaleFactor` | public const float |
| `armyModelScaleAdjust` | public const float |
| `launchFacilityScaleAdjust` | public const float |
| `cameraModelLoadThreshold` | public const float |
| `cameraMgr` | private CameraManager |
| `prevScale` | private float |
| `forceUpdate` | private bool |
| `adjustedScaleMultiplier` | public float |

### Methods

```csharp
private void Awake()
```

```csharp
private void Update()
```

```csharp
public void Refresh()
```

```csharp
public void InitializeWithRegionInfo(RegionController owner, TIMapGroupVisualizerTemplate template)
```

```csharp
protected MarkerController GetMarkerByPriority(int priority)
```

```csharp
public MarkerController ManageMarkerStack(MarkerController marker, bool delete, MarkerType mType, TIGameState location, string markerName = "", int forceIndex = -1, bool forceEmptyCreation = false)
```

```csharp
protected MarkerController AddMarker(int forceIndex = -1, string markerName = "")
```

```csharp
public void ScaleMarker(float newScale, MarkerController marker)
```

```csharp
public void RemoveMarker(MarkerController marker)
```

```csharp
public int GetNumMarkers()
```

```csharp
public List<MarkerController> GetMarkers()
```

```csharp
protected void AutoArrangeMarkers()
```

```csharp
protected void ArrangeInColumn(int numMarkers, bool exceedCanvas = false)
```

```csharp
protected void ArrangeInColumn_FromTop(int numMarkers, float offsetMultiplier = 1f)
```

```csharp
protected void ArrangeMultipleTypes(bool exceedCanvas = true)
```

```csharp
protected void ArrangeInLine(int numMarkers, bool exceedCanvas = false)
```

```csharp
protected void ArrangeInLine_FixedPositions(int totalPossible)
```

```csharp
protected void ArrangeInLine_FromLeft(int numMarkers, float offsetMultiplier = 1f)
```

```csharp
public float GetNewScale()
```

```csharp
public float DistanceForCamera()
```

```csharp
public void InitializeGeoscapeModel(MarkerController marker, string assetPath)
```
