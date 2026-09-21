# PolygonPoint

*Decompiled from `Poly2Tri/PolygonPoint.cs`.*


## Class `PolygonPoint`

```csharp
public class PolygonPoint : TriangulationPoint
```

### Fields

| Name | Type |
|---|---|
| `zero` | public static PolygonPoint |

### Properties

- `public PolygonPoint Next`
- `public PolygonPoint Previous`

### Methods

```csharp
public PolygonPoint(double x, double y)
```

```csharp
public PolygonPoint(double x, double y, float z)
```

```csharp
public static Point2D ToBasePoint(PolygonPoint p)
```

```csharp
public static TriangulationPoint ToTriangulationPoint(PolygonPoint p)
```
