# PolygonUtil

*Decompiled from `Poly2Tri/PolygonUtil.cs`.*


## Class `PolygonUtil`

```csharp
public class PolygonUtil
```

### Fields

| Name | Type |
|---|---|
| `PolyUnionError` | public enum |
| `uint` | public enum PolyOperation : |

### Methods

```csharp
public static Point2DList.WindingOrderType CalculateWindingOrder(IList<Point2D> l)
```

```csharp
public static bool PolygonsAreSame2D(IList<Point2D> poly1, IList<Point2D> poly2)
```

```csharp
public static bool PointInPolygon2D(IList<Point2D> polygon, Point2D p)
```

```csharp
public static bool PolygonsIntersect2D(IList<Point2D> poly1, Rect2D boundRect1, IList<Point2D> poly2, Rect2D boundRect2)
```

```csharp
public bool PolygonContainsPolygon(IList<Point2D> poly1, Rect2D boundRect1, IList<Point2D> poly2, Rect2D boundRect2)
```

```csharp
public static bool PolygonContainsPolygon(IList<Point2D> poly1, Rect2D boundRect1, IList<Point2D> poly2, Rect2D boundRect2, bool runIntersectionTest)
```

```csharp
public static void ClipPolygonToEdge2D(Point2D edgeBegin, Point2D edgeEnd, IList<Point2D> poly, out List<Point2D> outPoly)
```

```csharp
public static void ClipPolygonToPolygon(IList<Point2D> poly, IList<Point2D> clipPoly, out List<Point2D> outPoly)
```

```csharp
public static PolygonUtil.PolyUnionError PolygonUnion(Point2DList polygon1, Point2DList polygon2, out Point2DList union)
```

```csharp
protected static void PolygonUnionInternal(PolygonOperationContext ctx)
```

```csharp
public static PolygonUtil.PolyUnionError PolygonIntersect(Point2DList polygon1, Point2DList polygon2, out Point2DList intersectOut)
```

```csharp
protected static void PolygonIntersectInternal(PolygonOperationContext ctx)
```

```csharp
public static PolygonUtil.PolyUnionError PolygonSubtract(Point2DList polygon1, Point2DList polygon2, out Point2DList subtract)
```

```csharp
public static void PolygonSubtractInternal(PolygonOperationContext ctx)
```

```csharp
public static PolygonUtil.PolyUnionError PolygonOperation(PolygonUtil.PolyOperation operations, Point2DList polygon1, Point2DList polygon2, out Dictionary<uint, Point2DList> results)
```

```csharp
public static PolygonUtil.PolyUnionError PolygonOperation(PolygonOperationContext ctx)
```

```csharp
public static List<Point2DList> SplitComplexPolygon(Point2DList verts, double epsilon)
```

```csharp
private static List<Point2DList> SplitComplexPolygonCleanup(IList<Point2D> orig)
```
