# DTSweep

*Decompiled from `Poly2Tri/DTSweep.cs`.*


## Class `DTSweep`

```csharp
public static class DTSweep
```

### Fields

| Name | Type |
|---|---|
| `PI_div2` | private const double |
| `PI_3div4` | private const double |

### Methods

```csharp
public static void Triangulate(DTSweepContext tcx)
```

```csharp
private static void Sweep(DTSweepContext tcx)
```

```csharp
private static void FixupConstrainedEdges(DTSweepContext tcx)
```

```csharp
private static void FinalizationConvexHull(DTSweepContext tcx)
```

```csharp
private static void TurnAdvancingFrontConvex(DTSweepContext tcx, AdvancingFrontNode b, AdvancingFrontNode c)
```

```csharp
private static void FinalizationPolygon(DTSweepContext tcx)
```

```csharp
private static void FinalizationConstraints(DTSweepContext tcx)
```

```csharp
private static AdvancingFrontNode PointEvent(DTSweepContext tcx, TriangulationPoint point)
```

```csharp
private static AdvancingFrontNode NewFrontTriangle(DTSweepContext tcx, TriangulationPoint point, AdvancingFrontNode node)
```

```csharp
private static void EdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
```

```csharp
private static void FillEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
```

```csharp
private static void FillRightConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
```

```csharp
private static void FillRightConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
```

```csharp
private static void FillRightBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
```

```csharp
private static void FillRightAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
```

```csharp
private static void FillLeftConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
```

```csharp
private static void FillLeftConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
```

```csharp
private static void FillLeftBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
```

```csharp
private static void FillLeftAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
```

```csharp
private static bool IsEdgeSideOfTriangle(DelaunayTriangle triangle, TriangulationPoint ep, TriangulationPoint eq)
```

```csharp
private static void EdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle triangle, TriangulationPoint point)
```

```csharp
private static void FlipEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle t, TriangulationPoint p)
```

```csharp
private static bool NextFlipPoint(TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle ot, TriangulationPoint op, out TriangulationPoint newP)
```

```csharp
private static DelaunayTriangle NextFlipTriangle(DTSweepContext tcx, Orientation o, DelaunayTriangle t, DelaunayTriangle ot, TriangulationPoint p, TriangulationPoint op)
```

```csharp
private static void FlipScanEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle flipTriangle, DelaunayTriangle t, TriangulationPoint p)
```

```csharp
private static void FillAdvancingFront(DTSweepContext tcx, AdvancingFrontNode n)
```

```csharp
private static void FillBasin(DTSweepContext tcx, AdvancingFrontNode node)
```

```csharp
private static void FillBasinReq(DTSweepContext tcx, AdvancingFrontNode node)
```

```csharp
private static bool IsShallow(DTSweepContext tcx, AdvancingFrontNode node)
```

```csharp
private static double HoleAngle(AdvancingFrontNode node)
```

```csharp
private static double BasinAngle(AdvancingFrontNode node)
```

```csharp
private static void Fill(DTSweepContext tcx, AdvancingFrontNode node)
```

```csharp
private static bool Legalize(DTSweepContext tcx, DelaunayTriangle t)
```

```csharp
private static void RotateTrianglePair(DelaunayTriangle t, TriangulationPoint p, DelaunayTriangle ot, TriangulationPoint op)
```
