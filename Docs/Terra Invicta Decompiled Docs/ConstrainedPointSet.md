# ConstrainedPointSet

*Decompiled from `Poly2Tri/ConstrainedPointSet.cs`.*


## Class `ConstrainedPointSet`

```csharp
public class ConstrainedPointSet : PointSet
```

### Fields

| Name | Type |
|---|---|
| `TriangulationMode` | public override TriangulationMode |
| `mConstraintMap` | protected Dictionary<uint, TriangulationConstraint> |
| `mHoles` | protected List<Contour> |

### Methods

```csharp
public ConstrainedPointSet(List<TriangulationPoint> bounds)
```

```csharp
public ConstrainedPointSet(List<TriangulationPoint> bounds, List<TriangulationConstraint> constraints)
```

```csharp
public ConstrainedPointSet(List<TriangulationPoint> bounds, int[] indices)
```

```csharp
protected void AddBoundaryConstraints()
```

```csharp
public override void Add(Point2D p)
```

```csharp
public override void Add(TriangulationPoint p)
```

```csharp
public override bool AddRange(List<TriangulationPoint> points)
```

```csharp
public bool AddHole(List<TriangulationPoint> points, string name)
```

```csharp
public bool AddConstraints(List<TriangulationConstraint> constraints)
```

```csharp
public bool AddConstraint(TriangulationConstraint tc)
```

```csharp
public bool TryGetConstraint(uint constraintCode, out TriangulationConstraint tc)
```

```csharp
public int GetNumConstraints()
```

```csharp
public Dictionary<uint, TriangulationConstraint>.Enumerator GetConstraintEnumerator()
```

```csharp
public int GetNumHoles()
```

```csharp
public Contour GetHole(int idx)
```

```csharp
public int GetActualHoles(out List<Contour> holes)
```

```csharp
protected void InitializeHoles()
```

```csharp
public override bool Initialize()
```

```csharp
public override void Prepare(TriangulationContext tcx)
```

```csharp
public override void AddTriangle(DelaunayTriangle t)
```
