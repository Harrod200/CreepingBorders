# DTSweepContext

*Decompiled from `Poly2Tri/DTSweepContext.cs`.*


## Class `DTSweepContext`

```csharp
public class DTSweepContext : TriangulationContext
```

### Fields

| Name | Type |
|---|---|
| `Algorithm` | public override TriangulationAlgorithm |
| `ALPHA` | private readonly float |
| `Front` | public AdvancingFront |
| `Basin` | public DTSweepBasin |
| `EdgeEvent` | public DTSweepEdgeEvent |
| `_comparator` | private DTSweepPointComparator |

### Properties

- `public TriangulationPoint Head`
- `public TriangulationPoint Tail`

### Methods

```csharp
public DTSweepContext()
```

```csharp
public void RemoveFromList(DelaunayTriangle triangle)
```

```csharp
public void MeshClean(DelaunayTriangle triangle)
```

```csharp
private void MeshCleanReq(DelaunayTriangle triangle)
```

```csharp
public override void Clear()
```

```csharp
public void AddNode(AdvancingFrontNode node)
```

```csharp
public void RemoveNode(AdvancingFrontNode node)
```

```csharp
public AdvancingFrontNode LocateNode(TriangulationPoint point)
```

```csharp
public void CreateAdvancingFront()
```

```csharp
public void MapTriangleToNodes(DelaunayTriangle t)
```

```csharp
public override void PrepareTriangulation(ITriangulatable t)
```

```csharp
public void FinalizeTriangulation()
```

```csharp
public override TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b)
```
