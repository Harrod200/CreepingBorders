# VectorLine

*Decompiled from `Vectrosity/VectorLine.cs`.*


## Class `VectorLine`

```csharp
public class VectorLine
```

### Fields

| Name | Type |
|---|---|
| `lineVertices` | public Vector3[] |
| `lineUVs` | public Vector2[] |
| `lineColors` | public Color[] |
| `lineTriangles` | public List<int> |
| `rectTransform` | public RectTransform |
| `color` | public Color |
| `is2D` | public bool |
| `points2` | public List<Vector2> |
| `points3` | public List<Vector3> |
| `pointsCount` | private int |
| `lineWidth` | public float |
| `maxWeldDistance` | public float |
| `name` | public string |
| `material` | public Material |
| `texture` | public Texture |
| `layer` | public int |
| `active` | public bool |
| `lineType` | public LineType |
| `capLength` | public float |
| `smoothWidth` | public bool |
| `smoothColor` | public bool |
| `joins` | public Joins |
| `isAutoDrawing` | public bool |
| `drawStart` | public int |
| `drawEnd` | public int |
| `endPointsUpdate` | public int |
| `endCap` | public string |
| `continuousTexture` | public bool |
| `drawTransform` | public Transform |
| `useViewportCoords` | public bool |
| `textureScale` | public float |
| `textureOffset` | public float |
| `matrix` | public Matrix4x4 |
| `drawDepth` | public int |
| `collider` | public bool |
| `trigger` | public bool |
| `physicsMaterial` | public PhysicsMaterial2D |
| `alignOddWidthToPixels` | public bool |
| `canvas` | public static Canvas |
| `camTransformPosition` | public static Vector3 |
| `camTransformExists` | public static bool |
| `lineManager` | public static LineManager |
| `s_defaultMaterial` | private static Material |
| `m_useCustomMaterial` | private bool |
| `m_lineVertices` | private Vector3[] |
| `m_lineUVs` | private Vector2[] |
| `m_lineColors` | private Color[] |
| `m_lineTriangles` | private List<int> |
| `m_vertexCount` | private int |
| `m_go` | private GameObject |
| `m_rectTransform` | private RectTransform |
| `m_vectorObject` | private IVectorObject |
| `m_color` | private Color |
| `m_canvasState` | private CanvasState |
| `m_is2D` | private bool |
| `m_points2` | private List<Vector2> |
| `m_points3` | private List<Vector3> |
| `m_pointsCount` | private int |
| `m_screenPoints` | private Vector3[] |
| `m_lineWidths` | private float[] |
| `m_lineWidth` | private float |
| `m_maxWeldDistance` | private float |
| `m_distances` | private float[] |
| `m_name` | private string |
| `m_material` | private Material |
| `m_originalTexture` | private Texture |
| `m_texture` | private Texture |
| `m_active` | private bool |
| `m_lineType` | private LineType |
| `m_capLength` | private float |
| `m_smoothWidth` | private bool |
| `m_smoothColor` | private bool |
| `m_joins` | private Joins |
| `m_isAutoDrawing` | private bool |
| `m_drawStart` | private int |
| `m_drawEnd` | private int |
| `m_endPointsUpdate` | private int |
| `m_useNormals` | private bool |
| `m_useTangents` | private bool |
| `m_normalsCalculated` | private bool |
| `m_tangentsCalculated` | private bool |
| `m_capType` | private EndCap |
| `m_endCap` | private string |
| `m_useCapColors` | private bool |
| `m_frontColor` | private Color32 |
| `m_backColor` | private Color32 |
| `m_frontEndCapIndex` | private int |
| `m_backEndCapIndex` | private int |
| `m_lineUVBottom` | private float |
| `m_lineUVTop` | private float |
| `m_frontCapUVBottom` | private float |
| `m_frontCapUVTop` | private float |
| `m_backCapUVBottom` | private float |
| `m_backCapUVTop` | private float |
| `m_continuousTexture` | private bool |
| `m_drawTransform` | private Transform |
| `m_viewportDraw` | private bool |
| `m_textureScale` | private float |
| `m_useTextureScale` | private bool |
| `m_textureOffset` | private float |
| `m_useMatrix` | private bool |
| `m_matrix` | private Matrix4x4 |
| `m_collider` | private bool |
| `m_trigger` | private bool |
| `m_physicsMaterial` | private PhysicsMaterial2D |
| `m_alignOddWidthToPixels` | private bool |
| `v3zero` | private static Vector3 |
| `m_canvas` | private static Canvas |
| `camTransform` | private static Transform |
| `cam3D` | private static Camera |
| `oldPosition` | private static Vector3 |
| `oldRotation` | private static Vector3 |
| `lineManagerCreated` | private static bool |
| `m_lineManager` | private static LineManager |
| `capDictionary` | private static Dictionary<string, CapInfo> |
| `endianDiff1` | private static int |
| `endianDiff2` | private static int |
| `byteBlock` | private static byte[] |
| `FunctionName` | private enum |

### Properties

- `private static string[] functionNames = new string[]`

### Methods

```csharp
public static string Version()
```

```csharp
private void AddColliderIfNeeded()
```

```csharp
public VectorLine(string name, List<Vector3> points, float width)
```

```csharp
public VectorLine(string name, List<Vector3> points, Texture texture, float width)
```

```csharp
public VectorLine(string name, List<Vector3> points, float width, LineType lineType)
```

```csharp
public VectorLine(string name, List<Vector3> points, Texture texture, float width, LineType lineType)
```

```csharp
public VectorLine(string name, List<Vector3> points, float width, LineType lineType, Joins joins)
```

```csharp
public VectorLine(string name, List<Vector3> points, Texture texture, float width, LineType lineType, Joins joins)
```

```csharp
public VectorLine(string name, List<Vector2> points, float width)
```

```csharp
public VectorLine(string name, List<Vector2> points, Texture texture, float width)
```

```csharp
public VectorLine(string name, List<Vector2> points, float width, LineType lineType)
```

```csharp
public VectorLine(string name, List<Vector2> points, Texture texture, float width, LineType lineType)
```

```csharp
public VectorLine(string name, List<Vector2> points, float width, LineType lineType, Joins joins)
```

```csharp
public VectorLine(string name, List<Vector2> points, Texture texture, float width, LineType lineType, Joins joins)
```

```csharp
protected void SetupLine(string lineName, Texture texture, float width, LineType lineType, Joins joins, bool use2D)
```

```csharp
private void SetupTriangles(int startVert)
```

```csharp
private void SetLastFillTriangles()
```

```csharp
private void SetupEndCap(float[] uvHeights)
```

```csharp
private void ResetLine()
```

```csharp
private void SetEndCapUVs()
```

```csharp
private void RemoveEndCap()
```

```csharp
private static void SetupTransform(RectTransform rectTransform)
```

```csharp
private void ResizeMeshArrays(int newCount)
```

```csharp
public void Resize(int newCount)
```

```csharp
private void Resize()
```

```csharp
private void ResizeLineWidths(int newSize)
```

```csharp
private void SetUVs(int startIndex, int endIndex)
```

```csharp
private bool SetVertexCount()
```

```csharp
private int MaxPoints()
```

```csharp
public void AddNormals()
```

```csharp
public void AddTangents()
```

```csharp
public Vector4[] CalculateTangents(Vector3[] normals)
```

```csharp
public static GameObject SetupVectorCanvas()
```

```csharp
public static void SetCanvasCamera(Camera cam)
```

```csharp
public void SetCanvas(GameObject canvasObject)
```

```csharp
public void SetCanvas(GameObject canvasObject, bool worldPositionStays)
```

```csharp
public void SetCanvas(Canvas canvas)
```

```csharp
public void SetCanvas(Canvas canvas, bool worldPositionStays)
```

```csharp
public void SetMask(GameObject maskObject)
```

```csharp
public void SetMask(GameObject maskObject, bool worldPositionStays)
```

```csharp
public void SetMask(Mask mask)
```

```csharp
public void SetMask(Mask mask, bool worldPositionStays)
```

```csharp
private bool CheckCamera3D()
```

```csharp
public static void SetCamera3D()
```

```csharp
public static void SetCamera3D(GameObject cameraObject)
```

```csharp
public static void SetCamera3D(Camera camera)
```

```csharp
public static bool CameraHasMoved()
```

```csharp
public static void UpdateCameraInfo()
```

```csharp
public int GetSegmentNumber()
```

```csharp
private void SetEndCapColors()
```

```csharp
public void SetEndCapColor(Color32 color)
```

```csharp
public void SetEndCapColor(Color32 frontColor, Color32 backColor)
```

```csharp
public void SetEndCapIndex(EndCap endCap, int index)
```

```csharp
public void SetColor(Color color)
```

```csharp
public void SetColor(Color color, int index)
```

```csharp
public void SetColor(Color color, int startIndex, int endIndex)
```

```csharp
public void SetColors(List<Color> lineColors)
```

```csharp
public void SetMaterial(Material material, bool ownsMaterial)
```

```csharp
private void SetSegmentStartEnd(out int start, out int end)
```

```csharp
public Color GetColor(int index)
```

```csharp
private void SetupWidths(int max)
```

```csharp
public void SetWidth(float width)
```

```csharp
public void SetWidth(float width, int index)
```

```csharp
public void SetWidth(float width, int startIndex, int endIndex)
```

```csharp
public void SetWidths(List<float> lineWidths)
```

```csharp
public void SetWidths(List<int> lineWidths)
```

```csharp
private void SetWidths(List<float> lineWidthsFloat, List<int> lineWidthsInt, int arrayLength, bool doFloat)
```

```csharp
public float GetWidth(int index)
```

```csharp
public static VectorLine SetLine(Color color, params Vector2[] points)
```

```csharp
public static VectorLine SetLine(Color color, float time, params Vector2[] points)
```

```csharp
public static VectorLine SetLine(Color color, params Vector3[] points)
```

```csharp
public static VectorLine SetLine(Color color, float time, params Vector3[] points)
```

```csharp
public static VectorLine SetLine3D(Color color, params Vector3[] points)
```

```csharp
public static VectorLine SetLine3D(Color color, float time, params Vector3[] points)
```

```csharp
public static VectorLine SetRay(Color color, Vector3 origin, Vector3 direction)
```

```csharp
public static VectorLine SetRay(Color color, float time, Vector3 origin, Vector3 direction)
```

```csharp
public static VectorLine SetRay3D(Color color, Vector3 origin, Vector3 direction)
```

```csharp
public static VectorLine SetRay3D(Color color, float time, Vector3 origin, Vector3 direction)
```

```csharp
private void CheckNormals()
```

```csharp
private void CheckLine(bool draw3D)
```

```csharp
private void DrawEndCap(bool draw3D)
```

```csharp
private void ScaleCapVertices(int offset, float scale, Vector3 center)
```

```csharp
private void SetContinuousTexture()
```

```csharp
private bool UseMatrix(out Matrix4x4 thisMatrix)
```

```csharp
private bool CheckPointCount()
```

```csharp
private void ClearTriangles()
```

```csharp
private void SetupDrawStartEnd(out int start, out int end, bool clearVertices)
```

```csharp
private void ZeroVertices(int startIndex, int endIndex)
```

```csharp
private void SetupCanvasState(CanvasState wantedState)
```

```csharp
public void Draw()
```

```csharp
private void Line2D(int start, int end, Matrix4x4 thisMatrix, bool useTransformMatrix)
```

```csharp
private void Line3D(int start, int end, Matrix4x4 thisMatrix, bool useTransformMatrix)
```

```csharp
private void CheckDrawStartFill(int start)
```

```csharp
public void Draw3D()
```

```csharp
private bool IntersectAndDoSkip(ref Vector3 pos1, ref Vector3 pos2, ref Vector3 p1, ref Vector3 p2, ref float screenHeight, ref Ray ray, ref Plane cameraPlane)
```

```csharp
private Vector3 PlaneIntersectionPoint(ref Ray ray, ref Plane plane, ref Vector3 p1, ref Vector3 p2)
```

```csharp
private void DrawPoints()
```

```csharp
private void DrawPoints3D()
```

```csharp
private void SkipQuad(ref int idx, ref int widthIdx, ref int widthIdxAdd)
```

```csharp
private void SkipQuad3D(ref int idx, ref int widthIdx, ref int widthIdxAdd)
```

```csharp
private void WeldJoins(int start, int end, bool connectFirstAndLast)
```

```csharp
private void WeldJoinsDiscrete(int start, int end, bool connectFirstAndLast)
```

```csharp
private void SetIntersectionPoint(int p1, int p2, int p3, int p4)
```

```csharp
private void WeldJoins3D(int start, int end, bool connectFirstAndLast)
```

```csharp
private void WeldJoinsDiscrete3D(int start, int end, bool connectFirstAndLast)
```

```csharp
private void SetIntersectionPoint3D(int p1, int p2, int p3, int p4)
```

```csharp
public static void LineManagerCheckDistance()
```

```csharp
public static void LineManagerDisable()
```

```csharp
public static void LineManagerEnable()
```

```csharp
public void Draw3DAuto()
```

```csharp
public void Draw3DAuto(float time)
```

```csharp
public void StopDrawing3DAuto()
```

```csharp
private void SetTextureScale()
```

```csharp
private void ResetTextureScale()
```

```csharp
private void SetCollider(bool convertToWorldSpace)
```

```csharp
private void SetPathVerticesContinuous(ref int i, ref int startIdx, ref int endIdx, Vector2[] path)
```

```csharp
private void SetPathWorldVerticesContinuous(ref int i, ref Vector3 v3, ref int startIdx, ref int endIdx, Vector2[] path)
```

```csharp
private void SetPathVerticesDiscrete(ref int i, ref int pIdx, Vector2[] path, PolygonCollider2D collider)
```

```csharp
private void SetPathWorldVerticesDiscrete(ref int i, ref Vector3 v3, ref int pIdx, Vector2[] path, PolygonCollider2D collider)
```

```csharp
public static List<Vector3> BytesToVector3List(byte[] lineBytes)
```

```csharp
public static List<Vector2> BytesToVector2List(byte[] lineBytes)
```

```csharp
private static void SetupByteBlock()
```

```csharp
private static float ConvertToFloat(byte[] bytes, int i)
```

```csharp
public static void Destroy(ref VectorLine line)
```

```csharp
public static void Destroy(VectorLine[] lines)
```

```csharp
public static void Destroy(List<VectorLine> lines)
```

```csharp
private static void DestroyLine(ref VectorLine line)
```

```csharp
public static void Destroy(ref VectorLine line, GameObject go)
```

```csharp
public void SetDistances()
```

```csharp
public float GetLength()
```

```csharp
public Vector2 GetPoint01(float distance)
```

```csharp
public Vector2 GetPoint01(float distance, out int index)
```

```csharp
public Vector2 GetPoint(float distance)
```

```csharp
public Vector2 GetPoint(float distance, out int index)
```

```csharp
public Vector3 GetPoint3D01(float distance)
```

```csharp
public Vector3 GetPoint3D01(float distance, out int index)
```

```csharp
public Vector3 GetPoint3D(float distance)
```

```csharp
public Vector3 GetPoint3D(float distance, out int index)
```

```csharp
private void SetDistanceIndex(out int i, float distance)
```

```csharp
public static void SetEndCap(string name, EndCap capType)
```

```csharp
public static void SetEndCap(string name, EndCap capType, params Texture2D[] textures)
```

```csharp
public static void SetEndCap(string name, EndCap capType, float offset, params Texture2D[] textures)
```

```csharp
public static void SetEndCap(string name, EndCap capType, float offsetFront, float offsetBack, params Texture2D[] textures)
```

```csharp
public static void SetEndCap(string name, EndCap capType, float offsetFront, float offsetBack, float scaleFront, float scaleBack, params Texture2D[] textures)
```

```csharp
private static Color32[] GetRowPixels(Color32[] texPixels, int numberOfRows, int row, int w)
```

```csharp
private static Color32[] GetRotatedPixels(Texture2D tex)
```

```csharp
public static void RemoveEndCap(string name)
```

```csharp
public bool Selected(Vector2 p)
```

```csharp
public bool Selected(Vector2 p, out int index)
```

```csharp
public bool Selected(Vector2 p, int extraDistance, out int index)
```

```csharp
public bool Selected(Vector2 p, int extraDistance, int extraLength, out int index)
```

```csharp
public bool Selected(Vector2 p, Camera cam)
```

```csharp
public bool Selected(Vector2 p, out int index, Camera cam)
```

```csharp
public bool Selected(Vector2 p, int extraDistance, out int index, Camera cam)
```

```csharp
public bool Selected(Vector2 p, int extraDistance, int extraLength, out int index, Camera cam)
```

```csharp
private bool Approximately(Vector2 p1, Vector2 p2)
```

```csharp
private bool Approximately(Vector3 p1, Vector3 p2)
```

```csharp
private bool Approximately(float a, float b)
```

```csharp
private bool WrongArrayLength(int arrayLength, VectorLine.FunctionName functionName)
```

```csharp
private bool CheckArrayLength(VectorLine.FunctionName functionName, int segments, int index)
```

```csharp
public void MakeRect(Rect rect)
```

```csharp
public void MakeRect(Rect rect, int index)
```

```csharp
public void MakeRect(Vector3 bottomLeft, Vector3 topRight)
```

```csharp
public void MakeRect(Vector3 bottomLeft, Vector3 topRight, int index)
```

```csharp
public void MakeRoundedRect(Rect rect, float cornerRadius, int cornerSegments)
```

```csharp
public void MakeRoundedRect(Rect rect, float cornerRadius, int cornerSegments, int index)
```

```csharp
public void MakeRoundedRect(Vector3 bottomLeft, Vector3 topRight, float cornerRadius, int cornerSegments)
```

```csharp
public void MakeRoundedRect(Vector3 bottomLeft, Vector3 topRight, float cornerRadius, int cornerSegments, int index)
```

```csharp
private void CopyAndAddPoints(int cornerPointCount, int originalCount, int sectionNumber, Vector2 add, int index)
```

```csharp
private void Exchange(ref Vector3 v1, ref Vector3 v2, int i)
```

```csharp
public void MakeCircle(Vector3 origin, float radius)
```

```csharp
public void MakeCircle(Vector3 origin, float radius, int segments)
```

```csharp
public void MakeCircle(Vector3 origin, float radius, int segments, float pointRotation)
```

```csharp
public void MakeCircle(Vector3 origin, float radius, int segments, int index)
```

```csharp
public void MakeCircle(Vector3 origin, float radius, int segments, float pointRotation, int index)
```

```csharp
public void MakeCircle(Vector3 origin, Vector3 upVector, float radius)
```

```csharp
public void MakeCircle(Vector3 origin, Vector3 upVector, float radius, int segments)
```

```csharp
public void MakeCircle(Vector3 origin, Vector3 upVector, float radius, int segments, float pointRotation)
```

```csharp
public void MakeCircle(Vector3 origin, Vector3 upVector, float radius, int segments, int index)
```

```csharp
public void MakeCircle(Vector3 origin, Vector3 upVector, float radius, int segments, float pointRotation, int index)
```

```csharp
public void MakeEllipse(Vector3 origin, float xRadius, float yRadius)
```

```csharp
public void MakeEllipse(Vector3 origin, float xRadius, float yRadius, int segments)
```

```csharp
public void MakeEllipse(Vector3 origin, float xRadius, float yRadius, int segments, int index)
```

```csharp
public void MakeEllipse(Vector3 origin, float xRadius, float yRadius, int segments, float pointRotation)
```

```csharp
public void MakeEllipse(Vector3 origin, Vector3 upVector, float xRadius, float yRadius)
```

```csharp
public void MakeEllipse(Vector3 origin, Vector3 upVector, float xRadius, float yRadius, int segments)
```

```csharp
public void MakeEllipse(Vector3 origin, Vector3 upVector, float xRadius, float yRadius, int segments, int index)
```

```csharp
public void MakeEllipse(Vector3 origin, Vector3 upVector, float xRadius, float yRadius, int segments, float pointRotation)
```

```csharp
public void MakeEllipse(Vector3 origin, Vector3 upVector, float xRadius, float yRadius, int segments, float pointRotation, int index)
```

```csharp
public void MakeArc(Vector3 origin, float xRadius, float yRadius, float startDegrees, float endDegrees)
```

```csharp
public void MakeArc(Vector3 origin, float xRadius, float yRadius, float startDegrees, float endDegrees, int segments)
```

```csharp
public void MakeArc(Vector3 origin, float xRadius, float yRadius, float startDegrees, float endDegrees, int segments, int index)
```

```csharp
public void MakeArc(Vector3 origin, Vector3 upVector, float xRadius, float yRadius, float startDegrees, float endDegrees)
```

```csharp
public void MakeArc(Vector3 origin, Vector3 upVector, float xRadius, float yRadius, float startDegrees, float endDegrees, int segments)
```

```csharp
public void MakeArc(Vector3 origin, Vector3 upVector, float xRadius, float yRadius, float startDegrees, float endDegrees, int segments, int index)
```

```csharp
private void MakeEllipse(Vector3 origin, Vector3 upVector, float xRadius, float yRadius, float startDegrees, float endDegrees, int segments, float pointRotation, int index)
```

```csharp
public void MakeCurve(Vector2[] curvePoints)
```

```csharp
public void MakeCurve(Vector2[] curvePoints, int segments)
```

```csharp
public void MakeCurve(Vector2[] curvePoints, int segments, int index)
```

```csharp
public void MakeCurve(Vector3[] curvePoints)
```

```csharp
public void MakeCurve(Vector3[] curvePoints, int segments)
```

```csharp
public void MakeCurve(Vector3[] curvePoints, int segments, int index)
```

```csharp
public void MakeCurve(Vector3 anchor1, Vector3 control1, Vector3 anchor2, Vector3 control2)
```

```csharp
public void MakeCurve(Vector3 anchor1, Vector3 control1, Vector3 anchor2, Vector3 control2, int segments)
```

```csharp
public void MakeCurve(Vector3 anchor1, Vector3 control1, Vector3 anchor2, Vector3 control2, int segments, int index)
```

```csharp
private static Vector2 GetBezierPoint(ref Vector2 anchor1, ref Vector2 control1, ref Vector2 anchor2, ref Vector2 control2, float t)
```

```csharp
private static Vector3 GetBezierPoint3D(ref Vector3 anchor1, ref Vector3 control1, ref Vector3 anchor2, ref Vector3 control2, float t)
```

```csharp
public void MakeSpline(Vector2[] splinePoints)
```

```csharp
public void MakeSpline(Vector2[] splinePoints, bool loop)
```

```csharp
public void MakeSpline(Vector2[] splinePoints, int segments)
```

```csharp
public void MakeSpline(Vector2[] splinePoints, int segments, bool loop)
```

```csharp
public void MakeSpline(Vector2[] splinePoints, int segments, int index)
```

```csharp
public void MakeSpline(Vector2[] splinePoints, int segments, int index, bool loop)
```

```csharp
public void MakeSpline(Vector3[] splinePoints)
```

```csharp
public void MakeSpline(Vector3[] splinePoints, bool loop)
```

```csharp
public void MakeSpline(Vector3[] splinePoints, int segments)
```

```csharp
public void MakeSpline(Vector3[] splinePoints, int segments, bool loop)
```

```csharp
public void MakeSpline(Vector3[] splinePoints, int segments, int index)
```

```csharp
public void MakeSpline(Vector3[] splinePoints, int segments, int index, bool loop)
```

```csharp
private void MakeSpline(Vector2[] splinePoints2, Vector3[] splinePoints3, int segments, int index, bool loop)
```

```csharp
private static Vector2 GetSplinePoint(ref Vector2 p0, ref Vector2 p1, ref Vector2 p2, ref Vector2 p3, float t)
```

```csharp
private static void GetSplineCubic3D(ref Vector3 p0, ref Vector3 p1, ref Vector3 p2, ref Vector3 p3, ref Vector4 px, ref Vector4 py, ref Vector4 pz)
```

```csharp
private static Vector3 SolveSplineCubic3D(ref Vector4 px, ref Vector4 py, ref Vector4 pz, float t)
```

```csharp
private static Vector3 GetSplinePoint3D(ref Vector3 p0, ref Vector3 p1, ref Vector3 p2, ref Vector3 p3, float t)
```

```csharp
private static float VectorDistanceSquared(ref Vector2 p, ref Vector2 q)
```

```csharp
private static float VectorDistanceSquared(ref Vector3 p, ref Vector3 q)
```

```csharp
private static void InitNonuniformCatmullRom(float x0, float x1, float x2, float x3, float dt0, float dt1, float dt2, ref Vector4 p)
```

```csharp
private static float EvalCubicPoly(ref Vector4 p, float t)
```

```csharp
public void MakeText(string text, Vector3 startPos, float size)
```

```csharp
public void MakeText(string text, Vector3 startPos, float size, bool uppercaseOnly)
```

```csharp
public void MakeText(string text, Vector3 startPos, float size, float charSpacing, float lineSpacing)
```

```csharp
public void MakeText(string text, Vector3 startPos, float size, float charSpacing, float lineSpacing, bool uppercaseOnly)
```

```csharp
public void MakeWireframe(Mesh mesh)
```

```csharp
private static void CheckPairPoints(Dictionary<Vector3Pair, bool> pairs, Vector3 p1, Vector3 p2, List<Vector3> linePoints)
```

```csharp
public void MakeCube(Vector3 position, float xSize, float ySize, float zSize)
```

```csharp
public void MakeCube(Vector3 position, float xSize, float ySize, float zSize, int index)
```
