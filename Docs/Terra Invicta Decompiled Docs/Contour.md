# Contour

*Decompiled from `Poly2Tri/Contour.cs`.*


## Class `Contour`

```csharp
public class Contour : Point2DList, ITriangulatable, IEnumerable<TriangulationPoint>, IEnumerable, IList<TriangulationPoint>, ICollection<TriangulationPoint>
```

### Fields

| Name | Type |
|---|---|
| `Name` | public string |
| `Triangles` | public IList<DelaunayTriangle> |
| `set` | private |
| `TriangulationMode` | public TriangulationMode |
| `FileName` | public string |
| `DisplayFlipX` | public bool |
| `DisplayFlipY` | public bool |
| `DisplayRotate` | public float |
| `Precision` | public double |
| `MinX` | public double |
| `MaxX` | public double |
| `MinY` | public double |
| `MaxY` | public double |
| `Bounds` | public Rect2D |
| `mHoles` | private List<Contour> |
| `mParent` | private ITriangulatable |
| `mName` | private string |

### Methods

```csharp
public Contour(ITriangulatable parent)
```

```csharp
public Contour(ITriangulatable parent, IList<TriangulationPoint> points, Point2DList.WindingOrderType windingOrder)
```

```csharp
public override string ToString()
```

```csharp
public int IndexOf(TriangulationPoint p)
```

```csharp
public void Add(TriangulationPoint p)
```

```csharp
protected override void Add(Point2D p, int idx, bool bCalcWindingOrderAndEpsilon)
```

```csharp
public override void AddRange(IEnumerator<Point2D> iter, Point2DList.WindingOrderType windingOrder)
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
public bool Contains(TriangulationPoint p)
```

```csharp
public void CopyTo(TriangulationPoint[] array, int arrayIndex)
```

```csharp
protected void AddHole(Contour c)
```

```csharp
public int GetNumHoles(bool parentIsHole)
```

```csharp
public int GetNumHoles()
```

```csharp
public Contour GetHole(int idx)
```

```csharp
public void GetActualHoles(bool parentIsHole, ref List<Contour> holes)
```

```csharp
public List<Contour>.Enumerator GetHoleEnumerator()
```

```csharp
public void InitializeHoles(ConstrainedPointSet cps)
```

```csharp
public static void InitializeHoles(List<Contour> holes, ITriangulatable parent, ConstrainedPointSet cps)
```

```csharp
public void Prepare(TriangulationContext tcx)
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
public Point2D FindPointInContour()
```

```csharp
public bool IsPointInsideContour(Point2D p)
```
