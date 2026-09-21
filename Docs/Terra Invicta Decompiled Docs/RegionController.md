# RegionController

*Decompiled from `PavonisInteractive/TerraInvicta/RegionController.cs`.*


## Class `RegionController`

```csharp
public class RegionController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `mapColorationStyle` | private static MapColorationStyle |
| `ArmyMarkerController` | public ArmyMarkerController |
| `defaultMaterial` | public Material |
| `mapVisualizer` | public MapController |
| `nationVisualizer` | private NationController |
| `outline` | private TIRegionOutline |
| `regionShapes` | private List<List<Vector3>> |
| `regionSurfacePoints` | private List<Vector3[]> |
| `polyLatLons` | private List<Polygon> |
| `regionOutlines` | private List<VectorLine> |
| `regionSurfaces` | private List<GameObject> |
| `surfaceRenderers` | private List<Renderer> |
| `surfaceColliders` | private List<MeshCollider> |
| `customMaterial` | private Material |
| `is3D` | private bool |
| `tokenContainer` | private Transform |
| `tokenPositions` | private Dictionary<string, Vector3> |
| `markerContainers` | public List<MarkerContainerController> |
| `iMarkerControllers` | private List<IMarkerControl> |
| `surfaceContainer` | private Transform |
| `mouseOver` | private bool |
| `regionTooltip` | public TooltipTrigger |
| `heldValidTarget` | private bool |
| `scalingVector` | public Vector3 |
| `boundRect` | private Rect2D |
| `timeSegmentingCurves` | public static float |
| `timePolyConvert` | public static float |
| `timeAddInteriorPoints` | public static float |
| `timeTriangulate` | public static float |
| `timeDisplayOutline` | public static float |
| `timeDisplayMesh` | public static float |
| `cachedMaxPopulation` | private static float |
| `cachedMinPopulation` | private static float |
| `cachedMinPerCapitaGDP` | private static float |
| `cachedMaxPerCapitaGDP` | private static float |
| `cachedMaxMilitaryTechLevel` | private static float |
| `cachedMaxBoostIncome` | private static float |
| `cachedMaxIPs` | private static float |
| `cachedFrame` | private static int |
| `delay1` | private static WaitForSeconds |

### Properties

- `public TIRegionState region`

### Methods

```csharp
public void Initialize(TIRegionState gamestate, NationController nationVis)
```

```csharp
protected Color GetRegionFillColor()
```

```csharp
private void CreateVisualizers()
```

```csharp
public void ChangeRegionOwner(RegionControlChanged e)
```

```csharp
public bool GetCouncilorLocation(out Vector3 location)
```

```csharp
public bool GetArmyLocation(out Vector3 location)
```

```csharp
public bool GetSeaLocation(out Vector3 location)
```

```csharp
public List<MarkerController> GetMarkers(List<MarkerType> filterForTypes)
```

```csharp
public List<IMarkerControl> GetIMarkerControllers()
```

```csharp
public T GetIMarkerController<T>() where T : IMarkerControl
```

```csharp
private string RegionTooltip(TooltipTrigger tip)
```

```csharp
public void Update3DShapeWithQuality(float? quality = null)
```

```csharp
private Transform NewContainer(string name)
```

```csharp
private void CreateLabelPositions()
```

```csharp
public void MouseUp()
```

```csharp
public void MouseOver()
```

```csharp
public void MouseExit()
```

```csharp
private bool RegionContainsPoint(PolygonPoint point)
```

```csharp
private Vector3 ComputeScalingVector()
```

```csharp
private void OnRegionSelected(RegionStateSelected e)
```

```csharp
public void OnRegionDeselected(CurrentOtherStateDeselected e)
```

```csharp
public void RestoreRegionTexture()
```

```csharp
public void OnOccupationStatusChange(OccupationStatusChange e)
```

```csharp
public void SetBaselineTexture(Color color)
```

```csharp
public void SetHighlightTexture(Color color)
```

```csharp
public void SetSelectedTexture(Color color)
```

```csharp
public void SetAllowedTargetTexture(Color color)
```

```csharp
public void SetOccupiedTexture(Color color)
```

```csharp
private void SetTextureProperties(Color difColor, int? textureValue, float? xAnimSpeed, float? yAnimSpeed, float? patternOpacity, bool setTiling = false, Vector2 tiling = default(Vector2), bool setTilingOffset = false, Vector2 tilingOffset = default(Vector2), float? alpha = null, float emissionStrength = 0.1f)
```

```csharp
public void SetWidth(float newWidth)
```

```csharp
public void SetLiftValue(float newLift)
```

```csharp
public void EnableRegionVisualizers(bool enable = true)
```

```csharp
public void EnableMarkerVisualizers(bool enable = true)
```

```csharp
public void FlashRegion(RegionFlashEvent e)
```

```csharp
public IEnumerator FlashRegion()
```
