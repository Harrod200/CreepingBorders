# Math3d

*Decompiled from `Math3d.cs`.*


## Class `Math3d`

```csharp
public static class Math3d
```

### Fields

| Name | Type |
|---|---|
| `tempChild` | private static Transform |
| `tempParent` | private static Transform |
| `positionRegister` | private static Vector3[] |
| `posTimeRegister` | private static float[] |
| `positionSamplesTaken` | private static int |
| `rotationRegister` | private static Quaternion[] |
| `rotTimeRegister` | private static float[] |
| `rotationSamplesTaken` | private static int |
| `LineSegment` | public struct |
| `A` | public Vector3 |
| `B` | public Vector3 |
| `Line` | public struct |
| `Point` | public Vector3 |
| `Direction` | public Vector3 |

### Methods

```csharp
public static void Init()
```

```csharp
public static Vector2 GetPointOnSpline(float percentage, Vector2[] cPoints)
```

```csharp
public static float[] GetLineSplineIntersections(Vector2[] linePoints, Vector2[] cPoints)
```

```csharp
private static void SolveCubic(out int nRoots, out float x1, out float x2, out float x3, float a, float b, float c, float d)
```

```csharp
private static float CubeRoot(float d)
```

```csharp
public static Vector3 AddVectorLength(Vector3 vector, float size)
```

```csharp
public static Vector3 SetVectorLength(Vector3 vector, float size)
```

```csharp
public static Quaternion SubtractRotation(Quaternion B, Quaternion A)
```

```csharp
public static Quaternion AddRotation(Quaternion A, Quaternion B)
```

```csharp
public static Vector3 TransformDirectionMath(Quaternion rotation, Vector3 vector)
```

```csharp
public static Vector3 InverseTransformDirectionMath(Quaternion rotation, Vector3 vector)
```

```csharp
public static Vector3 RotateVectorFromTo(Quaternion from, Quaternion to, Vector3 vector)
```

```csharp
public static bool PlanePlaneIntersection(out Vector3 linePoint, out Vector3 lineVec, Vector3 plane1Normal, Vector3 plane1Position, Vector3 plane2Normal, Vector3 plane2Position)
```

```csharp
public static bool LinePlaneIntersection(out Vector3 intersection, Vector3 linePoint, Vector3 lineVec, Vector3 planeNormal, Vector3 planePoint)
```

```csharp
public static bool LineLineIntersection(out Vector3 intersection, Vector3 linePoint1, Vector3 lineVec1, Vector3 linePoint2, Vector3 lineVec2)
```

```csharp
public static bool ClosestPointsOnTwoLines(out Vector3 closestPointLine1, out Vector3 closestPointLine2, Vector3 linePoint1, Vector3 lineVec1, Vector3 linePoint2, Vector3 lineVec2)
```

```csharp
public static Vector3 ProjectPointOnLine(Vector3 linePoint, Vector3 lineVec, Vector3 point)
```

```csharp
public static Vector3 ProjectPointOnLineSegment(Vector3 linePoint1, Vector3 linePoint2, Vector3 point)
```

```csharp
public static Vector3 ProjectPointOnPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 point)
```

```csharp
public static Vector3 ProjectVectorOnPlane(Vector3 planeNormal, Vector3 vector)
```

```csharp
public static float SignedDistancePlanePoint(Vector3 planeNormal, Vector3 planePoint, Vector3 point)
```

```csharp
public static float SignedDotProduct(Vector3 vectorA, Vector3 vectorB, Vector3 normal)
```

```csharp
public static float SignedVectorAngle(Vector3 referenceVector, Vector3 otherVector, Vector3 normal)
```

```csharp
public static float AngleVectorPlane(Vector3 vector, Vector3 normal)
```

```csharp
public static float DotProductAngle(Vector3 vec1, Vector3 vec2)
```

```csharp
public static void PlaneFrom3Points(out Vector3 planeNormal, out Vector3 planePoint, Vector3 pointA, Vector3 pointB, Vector3 pointC)
```

```csharp
public static Vector3 GetForwardVector(Quaternion q)
```

```csharp
public static Vector3 GetUpVector(Quaternion q)
```

```csharp
public static Vector3 GetRightVector(Quaternion q)
```

```csharp
public static Quaternion QuaternionFromMatrix(Matrix4x4 m)
```

```csharp
public static Vector3 PositionFromMatrix(Matrix4x4 m)
```

```csharp
public static void LookRotationExtended(ref GameObject gameObjectInOut, Vector3 alignWithVector, Vector3 alignWithNormal, Vector3 customForward, Vector3 customUp)
```

```csharp
public static void TransformWithParent(out Quaternion childRotation, out Vector3 childPosition, Quaternion parentRotation, Vector3 parentPosition, Quaternion startParentRotation, Vector3 startParentPosition, Quaternion startChildRotation, Vector3 startChildPosition)
```

```csharp
public static void PreciseAlign(ref GameObject gameObjectInOut, Vector3 alignWithVector, Vector3 alignWithNormal, Vector3 alignWithPosition, Vector3 triangleForward, Vector3 triangleNormal, Vector3 trianglePosition)
```

```csharp
public static void VectorsToTransform(ref GameObject gameObjectInOut, Vector3 positionVector, Vector3 directionVector, Vector3 normalVector)
```

```csharp
public static int PointOnWhichSideOfLineSegment(Vector3 linePoint1, Vector3 linePoint2, Vector3 point)
```

```csharp
public static float MouseDistanceToLine(Vector3 linePoint1, Vector3 linePoint2)
```

```csharp
public static float MouseDistanceToCircle(Vector3 point, float radius)
```

```csharp
public static bool IsLineInRectangle(Vector3 linePoint1, Vector3 linePoint2, Vector3 rectA, Vector3 rectB, Vector3 rectC, Vector3 rectD)
```

```csharp
public static bool IsPointInRectangle(Vector3 point, Vector3 rectA, Vector3 rectC, Vector3 rectB, Vector3 rectD)
```

```csharp
public static bool AreLineSegmentsCrossing(Vector3 pointA1, Vector3 pointA2, Vector3 pointB1, Vector3 pointB2)
```

```csharp
public static bool LinearAcceleration(out Vector3 vector, Vector3 position, int samples)
```

```csharp
public static bool AngularAcceleration(out Vector3 vector, Quaternion rotation, int samples)
```

```csharp
public static float LinearFunction2DBasic(float x, float Qx, float Qy)
```

```csharp
public static float LinearFunction2DFull(float x, float Px, float Py, float Qx, float Qy)
```

```csharp
private static Vector3 RotDiffToSpeedVec(Quaternion rotation, float deltaTime)
```

```csharp
public static float PointLineDistance(Ray ray, Vector3 point)
```

```csharp
public static float Distance(this Vector3 point, Math3d.Line line)
```

```csharp
public static float Distance(this Math3d.Line line, Vector3 point)
```

```csharp
public static float Distance(this Vector3 point, Math3d.LineSegment line_segment)
```

```csharp
public static float Distance(this Math3d.LineSegment line_segment, Vector3 point)
```

```csharp
public static float Distance(this Vector3 a, Vector3 b)
```

```csharp
public static Vector3 Crossed(this Vector3 a, Vector3 b)
```

```csharp
public static float Dot(this Vector3 a, Vector3 b)
```

```csharp
public LineSegment(Vector3 a, Vector3 b)
```

```csharp
public Line(Vector3 point, Vector3 direction)
```
