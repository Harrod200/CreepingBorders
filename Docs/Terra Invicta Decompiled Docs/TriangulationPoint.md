# TriangulationPoint

*Decompiled from `Poly2Tri/TriangulationPoint.cs`.*


## Class `TriangulationPoint`

```csharp
public class TriangulationPoint : Point2D
```

### Fields

| Name | Type |
|---|---|
| `X` | public override double |
| `Y` | public override double |
| `VertexCode` | public uint |
| `HasEdges` | public bool |
| `kVertexCodeDefaultPrecision` | public static readonly double |
| `mVertexCode` | protected uint |

### Properties

- `public List<DTSweepConstraint> Edges`

### Methods

```csharp
public TriangulationPoint(double x, double y)
```

```csharp
public TriangulationPoint(double x, double y, float z)
```

```csharp
public TriangulationPoint(double x, double y, float z, double precision)
```

```csharp
public override string ToString()
```

```csharp
public override int GetHashCode()
```

```csharp
public override bool Equals(object obj)
```

```csharp
public override void Set(double x, double y)
```

```csharp
public static uint CreateVertexCode(double x, double y, double precision)
```

```csharp
public void AddEdge(DTSweepConstraint e)
```

```csharp
public bool HasEdge(TriangulationPoint p)
```

```csharp
public bool GetEdge(TriangulationPoint p, out DTSweepConstraint edge)
```

```csharp
public static Point2D ToPoint2D(TriangulationPoint p)
```

```csharp
public void Reset()
```
