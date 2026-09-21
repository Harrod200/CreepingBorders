# PolygonOperationContext

*Decompiled from `Poly2Tri/PolygonOperationContext.cs`.*


## Class `PolygonOperationContext`

```csharp
public class PolygonOperationContext
```

### Fields

| Name | Type |
|---|---|
| `Union` | public Point2DList |
| `Intersect` | public Point2DList |
| `Subtract` | public Point2DList |
| `mOperations` | public PolygonUtil.PolyOperation |
| `mOriginalPolygon1` | public Point2DList |
| `mOriginalPolygon2` | public Point2DList |
| `mPoly1` | public Point2DList |
| `mPoly2` | public Point2DList |
| `mIntersections` | public List<EdgeIntersectInfo> |
| `mStartingIndex` | public int |
| `mError` | public PolygonUtil.PolyUnionError |
| `mPoly1VectorAngles` | public List<int> |
| `mPoly2VectorAngles` | public List<int> |
| `mOutput` | public Dictionary<uint, Point2DList> |

### Methods

```csharp
public void Clear()
```

```csharp
public bool Init(PolygonUtil.PolyOperation operations, Point2DList polygon1, Point2DList polygon2)
```

```csharp
private bool VerticesIntersect(Point2DList polygon1, Point2DList polygon2, out List<EdgeIntersectInfo> intersections)
```

```csharp
public bool PointInPolygonAngle(Point2D point, Point2DList polygon)
```

```csharp
public double VectorAngle(Point2D p1, Point2D p2)
```
