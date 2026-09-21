# DelaunayTriangle

*Decompiled from `Poly2Tri/DelaunayTriangle.cs`.*


## Class `DelaunayTriangle`

```csharp
public class DelaunayTriangle
```

### Fields

| Name | Type |
|---|---|
| `EdgeIsConstrained` | public FixedBitArray3 |
| `Points` | public FixedArray3<TriangulationPoint> |
| `Neighbors` | public FixedArray3<DelaunayTriangle> |
| `mEdgeIsConstrained` | private FixedBitArray3 |
| `EdgeIsDelaunay` | public FixedBitArray3 |

### Properties

- `public bool IsInterior`

### Methods

```csharp
public DelaunayTriangle(TriangulationPoint p1, TriangulationPoint p2, TriangulationPoint p3)
```

```csharp
public int IndexOf(TriangulationPoint p)
```

```csharp
public int IndexCWFrom(TriangulationPoint p)
```

```csharp
public int IndexCCWFrom(TriangulationPoint p)
```

```csharp
public bool Contains(TriangulationPoint p)
```

```csharp
private void MarkNeighbor(TriangulationPoint p1, TriangulationPoint p2, DelaunayTriangle t)
```

```csharp
public void MarkNeighbor(DelaunayTriangle t)
```

```csharp
public void ClearNeighbors()
```

```csharp
public void ClearNeighbor(DelaunayTriangle triangle)
```

```csharp
public void Clear()
```

```csharp
public TriangulationPoint OppositePoint(DelaunayTriangle t, TriangulationPoint p)
```

```csharp
public DelaunayTriangle NeighborCWFrom(TriangulationPoint point)
```

```csharp
public DelaunayTriangle NeighborCCWFrom(TriangulationPoint point)
```

```csharp
public DelaunayTriangle NeighborAcrossFrom(TriangulationPoint point)
```

```csharp
public TriangulationPoint PointCCWFrom(TriangulationPoint point)
```

```csharp
public TriangulationPoint PointCWFrom(TriangulationPoint point)
```

```csharp
private void RotateCW()
```

```csharp
public void Legalize(TriangulationPoint oPoint, TriangulationPoint nPoint)
```

```csharp
public override string ToString()
```

```csharp
public void MarkNeighborEdges()
```

```csharp
public void MarkEdge(DelaunayTriangle triangle)
```

```csharp
public void MarkEdge(List<DelaunayTriangle> tList)
```

```csharp
public void MarkConstrainedEdge(int index)
```

```csharp
public void MarkConstrainedEdge(DTSweepConstraint edge)
```

```csharp
public void MarkConstrainedEdge(TriangulationPoint p, TriangulationPoint q)
```

```csharp
public double Area()
```

```csharp
public TriangulationPoint Centroid()
```

```csharp
public int EdgeIndex(TriangulationPoint p1, TriangulationPoint p2)
```

```csharp
public bool GetConstrainedEdgeCCW(TriangulationPoint p)
```

```csharp
public bool GetConstrainedEdgeCW(TriangulationPoint p)
```

```csharp
public bool GetConstrainedEdgeAcross(TriangulationPoint p)
```

```csharp
protected void SetConstrainedEdge(int idx, bool ce)
```

```csharp
public void SetConstrainedEdgeCCW(TriangulationPoint p, bool ce)
```

```csharp
public void SetConstrainedEdgeCW(TriangulationPoint p, bool ce)
```

```csharp
public void SetConstrainedEdgeAcross(TriangulationPoint p, bool ce)
```

```csharp
public bool GetDelaunayEdgeCCW(TriangulationPoint p)
```

```csharp
public bool GetDelaunayEdgeCW(TriangulationPoint p)
```

```csharp
public bool GetDelaunayEdgeAcross(TriangulationPoint p)
```

```csharp
public void SetDelaunayEdgeCCW(TriangulationPoint p, bool ce)
```

```csharp
public void SetDelaunayEdgeCW(TriangulationPoint p, bool ce)
```

```csharp
public void SetDelaunayEdgeAcross(TriangulationPoint p, bool ce)
```

```csharp
public bool GetEdge(int idx, out DTSweepConstraint edge)
```

```csharp
public bool GetEdgeCCW(TriangulationPoint p, out DTSweepConstraint edge)
```

```csharp
public bool GetEdgeCW(TriangulationPoint p, out DTSweepConstraint edge)
```

```csharp
public bool GetEdgeAcross(TriangulationPoint p, out DTSweepConstraint edge)
```
