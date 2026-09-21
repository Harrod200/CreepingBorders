# Point2DEnumerator

*Decompiled from `Poly2Tri/Point2DEnumerator.cs`.*


## Class `Point2DEnumerator`

```csharp
public class Point2DEnumerator : IEnumerator<Point2D>, IEnumerator, IDisposable
```

### Fields

| Name | Type |
|---|---|
| `Current` | public Point2D |
| `mPoints` | protected IList<Point2D> |
| `position` | protected int |

### Methods

```csharp
public Point2DEnumerator(IList<Point2D> points)
```

```csharp
public bool MoveNext()
```

```csharp
public void Reset()
```
