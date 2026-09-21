# PointSet

*Decompiled from `Poly2Tri/PointSet.cs`.*


## Class `PointSet`

```csharp
public class PointSet : Point2DList, ITriangulatable, IEnumerable<TriangulationPoint>, IEnumerable, IList<TriangulationPoint>, ICollection<TriangulationPoint>
```

### Fields

| Name | Type |
|---|---|
| `Points` | public IList<TriangulationPoint> |
| `set` | private |
| `Precision` | public double |
| `MinX` | public double |
| `MaxX` | public double |
| `MinY` | public double |
| `MaxY` | public double |
| `Bounds` | public Rect2D |
| `TriangulationMode` | public virtual TriangulationMode |
| `mPointMap` | protected Dictionary<uint, TriangulationPoint> |
| `mPrecision` | protected double |

### Properties

- `public IList<DelaunayTriangle> Triangles`
- `public string FileName`
- `public bool DisplayFlipX`
- `public bool DisplayFlipY`
- `public float DisplayRotate`

### Methods

```csharp
public PointSet(List<TriangulationPoint> bounds)
```

```csharp
public int IndexOf(TriangulationPoint p)
```

```csharp
public override void Add(Point2D p)
```

```csharp
public virtual void Add(TriangulationPoint p)
```

```csharp
protected override void Add(Point2D p, int idx, bool constrainToBounds)
```

```csharp
protected bool Add(TriangulationPoint p, int idx, bool constrainToBounds)
```

```csharp
public override void AddRange(IEnumerator<Point2D> iter, Point2DList.WindingOrderType windingOrder)
```

```csharp
public virtual bool AddRange(List<TriangulationPoint> points)
```

```csharp
public bool TryGetPoint(double x, double y, out TriangulationPoint p)
```

```csharp
public void Insert(int idx, TriangulationPoint item)
```

```csharp
public override bool Remove(Point2D p)
```

```csharp
public bool Remove(TriangulationPoint p)
```

```csharp
public override void RemoveAt(int idx)
```

```csharp
public bool Contains(TriangulationPoint p)
```

```csharp
public void CopyTo(TriangulationPoint[] array, int arrayIndex)
```

```csharp
protected bool ConstrainPointToBounds(Point2D p)
```

```csharp
protected bool ConstrainPointToBounds(TriangulationPoint p)
```

```csharp
public virtual void AddTriangle(DelaunayTriangle t)
```

```csharp
public void AddTriangles(IEnumerable<DelaunayTriangle> list)
```

```csharp
public void ClearTriangles()
```

```csharp
public virtual bool Initialize()
```

```csharp
public virtual void Prepare(TriangulationContext tcx)
```
