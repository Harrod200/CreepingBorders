# Point2DList

*Decompiled from `Poly2Tri/Point2DList.cs`.*


## Class `Point2DList`

```csharp
public class Point2DList : IEnumerable<Point2D>, IEnumerable, IList<Point2D>, ICollection<Point2D>
```

### Fields

| Name | Type |
|---|---|
| `BoundingBox` | public Rect2D |
| `WindingOrder` | public Point2DList.WindingOrderType |
| `Epsilon` | public double |
| `Count` | public int |
| `IsReadOnly` | public virtual bool |
| `kMaxPolygonVertices` | public static readonly int |
| `kLinearSlop` | public static readonly double |
| `kAngularSlop` | public static readonly double |
| `mPoints` | protected List<Point2D> |
| `mBoundingBox` | protected Rect2D |
| `mWindingOrder` | protected Point2DList.WindingOrderType |
| `mEpsilon` | protected double |
| `WindingOrderType` | public enum |
| `uint` | public enum PolygonError : |

### Methods

```csharp
public Point2DList()
```

```csharp
public Point2DList(int capacity)
```

```csharp
public Point2DList(IList<Point2D> l)
```

```csharp
public Point2DList(Point2DList l)
```

```csharp
public override string ToString()
```

```csharp
public void Clear()
```

```csharp
public int IndexOf(Point2D p)
```

```csharp
public virtual void Add(Point2D p)
```

```csharp
protected virtual void Add(Point2D p, int idx, bool bCalcWindingOrderAndEpsilon)
```

```csharp
public virtual void AddRange(Point2DList l)
```

```csharp
public virtual void AddRange(IEnumerator<Point2D> iter, Point2DList.WindingOrderType windingOrder)
```

```csharp
public virtual void Insert(int idx, Point2D item)
```

```csharp
public virtual bool Remove(Point2D p)
```

```csharp
public virtual void RemoveAt(int idx)
```

```csharp
public virtual void RemoveRange(int idxStart, int count)
```

```csharp
public bool Contains(Point2D p)
```

```csharp
public void CopyTo(Point2D[] array, int arrayIndex)
```

```csharp
public void CalculateBounds()
```

```csharp
public double CalculateEpsilon()
```

```csharp
public Point2DList.WindingOrderType CalculateWindingOrder()
```

```csharp
public int NextIndex(int index)
```

```csharp
public int PreviousIndex(int index)
```

```csharp
public double GetSignedArea()
```

```csharp
public double GetArea()
```

```csharp
public Point2D GetCentroid()
```

```csharp
public void Translate(Point2D vector)
```

```csharp
public void Scale(Point2D value)
```

```csharp
public void Rotate(double radians)
```

```csharp
public bool IsDegenerate()
```

```csharp
public bool IsConvex()
```

```csharp
public bool IsSimple()
```

```csharp
public Point2DList.PolygonError CheckPolygon()
```

```csharp
public static string GetErrorString(Point2DList.PolygonError error)
```

```csharp
public void RemoveDuplicateNeighborPoints()
```

```csharp
public void Simplify()
```

```csharp
public void Simplify(double bias)
```

```csharp
public void MergeParallelEdges(double tolerance)
```

```csharp
public void ProjectToAxis(Point2D axis, out double min, out double max)
```
