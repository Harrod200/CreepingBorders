# RegionUtility

*Decompiled from `PavonisInteractive/TerraInvicta/RegionUtility.cs`.*


## Class `RegionUtility`

```csharp
public static class RegionUtility
```

### Fields

| Name | Type |
|---|---|
| `PI` | private const float |
| `TWOPI` | private const float |
| `segmentationQuality` | public static float |
| `maxSegLength` | public static float |
| `minSegLength` | public static float |
| `minFibonacciPoints` | public static int |
| `maxFibonacciPoints` | public static int |
| `SQRT_5` | private const float |
| `phi` | private const float |
| `s_vectorCache` | private static Dictionary<Vector3, int> |

### Methods

```csharp
public static List<List<Vector3>> CreateSegmentedPolysAsVector3(TIRegionOutline region, Transform parent = null, float? overrideQuality = null)
```

```csharp
public static List<VectorLine> CreateSegmentedPolysAsVectorLine(TIRegionOutline region, float xScale = 6.2831855f, float yscale = 3.1415927f, Transform parent = null, float? overrideQuality = null)
```

```csharp
public static List<CurvedPolyPoint> Scale2DPoly(CurvedPolyPoint[] inPoints, float xScale = 6.2831855f, float yScale = 3.1415927f, float zOffset = 0f)
```

```csharp
public static List<Vector3> DrawRegionSpline(List<CurvedPolyPoint> points, float? overrideQuality = null)
```

```csharp
public static void DrawRegionSpline(VectorLine line, List<CurvedPolyPoint> points, float? overrideQuality = null)
```

```csharp
public static int GetNumRegionPoints(List<CurvedPolyPoint> points, float? overrideQuality = null)
```

```csharp
public static int GetNumRegionSegments(CurvedPolyPoint p1, CurvedPolyPoint p2, float? overrideQuality = null)
```

```csharp
public static float BezierCurveLength(CurvedPolyPoint point1, CurvedPolyPoint point2)
```

```csharp
public static void MakeCurve(List<Vector3> m_points3, Vector3 anchor1, Vector3 control1, Vector3 anchor2, Vector3 control2, int segments, int index)
```

```csharp
private static Vector3 GetBezierPoint3D(ref Vector3 anchor1, ref Vector3 control1, ref Vector3 anchor2, ref Vector3 control2, float t)
```

```csharp
public static List<Polygon> VectorLineListToPolygonList(List<VectorLine> vlList)
```

```csharp
public static List<Polygon> VectorListToPolygonList(List<List<Vector3>> vList, string polyName = "foo")
```

```csharp
public static Polygon VectorLineToPolygon(VectorLine vl)
```

```csharp
public static Polygon VectorListToPolygon(List<Vector3> vl, string polyName = "")
```

```csharp
public static void TriangulatePolygon(Polygon poly, float? overrideQuality = null)
```

```csharp
private static int NumberFibonacciSpherePointsFromQuality(float? overrideQuality = null)
```

```csharp
public static List<Vector2> Create2DFibonacciSpherePoints(int numPoints, double minLat, double maxLat, double minLon, double maxLon)
```

```csharp
public static List<Vector2> Create2DFibonacciSpherePoints(int numPoints, bool display = false)
```

```csharp
public static void ConvertVectorLineTo3DInPlace(VectorLine vl, float radius = 20.005f)
```

```csharp
public static VectorLine ConvertVectorLineTo3D(VectorLine vl, float radius = 20.005f)
```

```csharp
public static void ConvertVectorListTo3DInPlace(List<Vector3> vList, float radius = 20.005f)
```

```csharp
public static List<Vector3List> ConvertVector3List(List<List<Vector3>> list)
```

```csharp
public static List<List<Vector3>> ConvertVector3List(List<Vector3List> list)
```

```csharp
public static List<Vector3Array> ConvertVector3Array(List<Vector3[]> list)
```

```csharp
public static List<Vector3[]> ConvertVector3Array(List<Vector3Array> list)
```

```csharp
public static Vector2 RotatePoint(Vector2 pointToRotate, Vector2 centerPoint, float angleInDegrees)
```

```csharp
public static Vector2 TwoDimFromThreeDimCartesian(Vector3 p)
```

```csharp
public static PolygonPoint LatLonFromSpherePoint(Vector3 pIn)
```

```csharp
public static Vector2d LatLonVector2FromSpherePoint(Vector3 pIn)
```

```csharp
public static Vector3 ScaledTwoDimCartesian(double x, double y, float xScale, float yScale)
```

```csharp
public static void ThreeDimFromTwoDimCartesian(Vector3 v, float radius = 20.005f)
```

```csharp
public static Vector3 ThreeDimFromTwoDimCartesian(double x, double y, float radius = 20.005f)
```

```csharp
public static bool ContainsPoint2D(PolygonPoint[] polyPoints, double x, double y)
```

```csharp
public static void Draw2DRegionPolyOutlines(List<VectorLine> polys, float mapOffset = -0.01f, Transform parent = null)
```

```csharp
public static void DisplayRegionOutline3D(List<VectorLine> polys, Transform parent = null)
```

```csharp
public static List<VectorLine> DisplayRegionOutline3D(List<List<Vector3>> polys, string polyName, Transform parent = null)
```

```csharp
public static Vector3[] MeshFromPolygon(Polygon poly, bool is3D = false, float offset = -0.0025f)
```

```csharp
public static List<Vector3[]> MeshFromPolygon(List<Polygon> polyList, bool is3D = false, float offset = -0.0025f)
```

```csharp
public static Mesh CreateSurfaceMesh(Vector3[] surfPoints)
```

```csharp
public static GameObject CreateSurface(string name, Vector3[] surfPoints, Material material)
```
