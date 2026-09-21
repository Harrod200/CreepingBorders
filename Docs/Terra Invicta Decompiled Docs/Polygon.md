# Polygon

*Decompiled from `Poly2Tri/Polygon.cs`.*


## Class `Polygon`

```csharp
public class Polygon : Point2DList, ITriangulatable, IEnumerable<TriangulationPoint>, IEnumerable, IList<TriangulationPoint>, ICollection<TriangulationPoint>
```

### Fields

| Name | Type |
|---|---|
| `Points` | public IList<TriangulationPoint> |
| `Triangles` | public IList<DelaunayTriangle> |
| `TriangulationMode` | public TriangulationMode |
| `Precision` | public double |
| `MinX` | public double |
| `MaxX` | public double |
| `MinY` | public double |
| `MaxY` | public double |
| `Bounds` | public Rect2D |
| `Holes` | public IList<Polygon> |
| `mPointMap` | protected Dictionary<uint, TriangulationPoint> |
| `mTriangles` | protected List<DelaunayTriangle> |
| `mPrecision` | private double |
| `mHoles` | protected List<Polygon> |
| `mSteinerPoints` | protected List<TriangulationPoint> |
| `_last` | protected PolygonPoint |

### Properties

- `public string FileName`
- `public bool DisplayFlipX`
- `public bool DisplayFlipY`
- `public float DisplayRotate`

### Methods

```csharp
public Polygon(IList<PolygonPoint> points)
```

```csharp
public Polygon(IEnumerable<PolygonPoint> points)
```

```csharp
public Polygon(params PolygonPoint[] points)
```

```csharp
public int IndexOf(TriangulationPoint p)
```

```csharp
public override void Add(Point2D p)
```

```csharp
public void Add(TriangulationPoint p)
```

```csharp
public void Add(PolygonPoint p)
```

```csharp
protected override void Add(Point2D p, int idx, bool bCalcWindingOrderAndEpsilon)
```

```csharp
public void AddRange(IList<PolygonPoint> points, Point2DList.WindingOrderType windingOrder)
```

```csharp
public void AddRange(IList<TriangulationPoint> points, Point2DList.WindingOrderType windingOrder)
```

```csharp
public void Insert(int idx, TriangulationPoint p)
```

```csharp
public bool Remove(TriangulationPoint p)
```

```csharp
public void RemovePoint(PolygonPoint p)
```

```csharp
public bool Contains(TriangulationPoint p)
```

```csharp
public void CopyTo(TriangulationPoint[] array, int arrayIndex)
```

```csharp
public void AddSteinerPoint(TriangulationPoint point)
```

```csharp
public void AddSteinerPoints(List<TriangulationPoint> points)
```

```csharp
public void ClearSteinerPoints()
```

```csharp
public void AddHole(Polygon poly)
```

```csharp
public void AddTriangle(DelaunayTriangle t)
```

```csharp
public void AddTriangles(IEnumerable<DelaunayTriangle> list)
```

```csharp
public void ClearTriangles()
```

```csharp
public bool IsPointInside(TriangulationPoint p)
```

```csharp
public void Prepare(TriangulationContext tcx)
```
