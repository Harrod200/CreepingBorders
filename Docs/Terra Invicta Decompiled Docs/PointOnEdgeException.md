# PointOnEdgeException

*Decompiled from `Poly2Tri/PointOnEdgeException.cs`.*


## Class `PointOnEdgeException`

```csharp
public class PointOnEdgeException : NotImplementedException
```

### Fields

| Name | Type |
|---|---|
| `A` | public readonly TriangulationPoint |
| `B` | public readonly TriangulationPoint |
| `C` | public readonly TriangulationPoint |

### Methods

```csharp
public PointOnEdgeException(string message, TriangulationPoint a, TriangulationPoint b, TriangulationPoint c)
```
