# Rect2D

*Decompiled from `Poly2Tri/Rect2D.cs`.*


## Class `Rect2D`

```csharp
public class Rect2D
```

### Fields

| Name | Type |
|---|---|
| `MinX` | public double |
| `MaxX` | public double |
| `MinY` | public double |
| `MaxY` | public double |
| `Left` | public double |
| `Right` | public double |
| `Top` | public double |
| `Bottom` | public double |
| `Width` | public double |
| `Height` | public double |
| `Empty` | public bool |
| `mMinX` | private double |
| `mMaxX` | private double |
| `mMinY` | private double |
| `mMaxY` | private double |

### Methods

```csharp
public Rect2D()
```

```csharp
public override int GetHashCode()
```

```csharp
public override bool Equals(object obj)
```

```csharp
public bool Equals(Rect2D r)
```

```csharp
public bool Equals(Rect2D r, double epsilon)
```

```csharp
public void Clear()
```

```csharp
public void Set(double xmin, double xmax, double ymin, double ymax)
```

```csharp
public void Set(Rect2D b)
```

```csharp
public void SetSize(double w, double h)
```

```csharp
public bool Contains(double x, double y)
```

```csharp
public bool Contains(Point2D p)
```

```csharp
public bool Contains(Rect2D r)
```

```csharp
public bool ContainsInclusive(double x, double y)
```

```csharp
public bool ContainsInclusive(double x, double y, double epsilon)
```

```csharp
public bool ContainsInclusive(Point2D p)
```

```csharp
public bool ContainsInclusive(Point2D p, double epsilon)
```

```csharp
public bool ContainsInclusive(Rect2D r)
```

```csharp
public bool ContainsInclusive(Rect2D r, double epsilon)
```

```csharp
public bool Intersects(Rect2D r)
```

```csharp
public Point2D GetCenter()
```

```csharp
public bool IsNormalized()
```

```csharp
public void Normalize()
```

```csharp
public void AddPoint(Point2D p)
```

```csharp
public void Inflate(double w, double h)
```

```csharp
public void Inflate(double left, double top, double right, double bottom)
```

```csharp
public void Offset(double w, double h)
```

```csharp
public void SetPosition(double x, double y)
```

```csharp
public bool Intersection(Rect2D r1, Rect2D r2)
```

```csharp
public void Union(Rect2D r1, Rect2D r2)
```
