# TriangulationPointEnumerator

*Decompiled from `Poly2Tri/TriangulationPointEnumerator.cs`.*


## Class `TriangulationPointEnumerator`

```csharp
public class TriangulationPointEnumerator : IEnumerator<TriangulationPoint>, IEnumerator, IDisposable
```

### Fields

| Name | Type |
|---|---|
| `Current` | public TriangulationPoint |
| `mPoints` | protected IList<Point2D> |
| `position` | protected int |

### Methods

```csharp
public TriangulationPointEnumerator(IList<Point2D> points)
```

```csharp
public bool MoveNext()
```

```csharp
public void Reset()
```
