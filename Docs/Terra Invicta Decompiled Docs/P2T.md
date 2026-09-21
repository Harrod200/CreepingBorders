# P2T

*Decompiled from `Poly2Tri/P2T.cs`.*


## Class `P2T`

```csharp
public static class P2T
```

### Fields

| Name | Type |
|---|---|
| `_defaultAlgorithm` | private static TriangulationAlgorithm |

### Methods

```csharp
public static void Triangulate(PolygonSet ps)
```

```csharp
public static void Triangulate(Polygon p)
```

```csharp
public static void Triangulate(ConstrainedPointSet cps)
```

```csharp
public static void Triangulate(PointSet ps)
```

```csharp
public static TriangulationContext CreateContext(TriangulationAlgorithm algorithm)
```

```csharp
public static void Triangulate(TriangulationAlgorithm algorithm, ITriangulatable t)
```

```csharp
public static void Triangulate(TriangulationContext tcx)
```
