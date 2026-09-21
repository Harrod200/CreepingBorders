# Point2D

*Decompiled from `Poly2Tri/Point2D.cs`.*


## Class `Point2D`

```csharp
public class Point2D : IComparable<Point2D>
```

### Fields

| Name | Type |
|---|---|
| `X` | public virtual double |
| `Y` | public virtual double |
| `Zf` | public virtual float |
| `Xf` | public float |
| `Yf` | public float |
| `mX` | protected double |
| `mY` | protected double |
| `mZf` | protected float |

### Methods

```csharp
public Point2D()
```

```csharp
public Point2D(double x, double y)
```

```csharp
public Point2D(double x, double y, float z)
```

```csharp
public Point2D(Point2D p)
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
public bool Equals(Point2D p)
```

```csharp
public bool Equals(Point2D p, double epsilon)
```

```csharp
public int CompareTo(Point2D other)
```

```csharp
public virtual void Set(double x, double y)
```

```csharp
public virtual void Set(Point2D p)
```

```csharp
public void Add(Point2D p)
```

```csharp
public void Add(double scalar)
```

```csharp
public void Subtract(Point2D p)
```

```csharp
public void Subtract(double scalar)
```

```csharp
public void Multiply(Point2D p)
```

```csharp
public void Multiply(double scalar)
```

```csharp
public void Divide(Point2D p)
```

```csharp
public void Divide(double scalar)
```

```csharp
public void Negate()
```

```csharp
public double Magnitude()
```

```csharp
public double MagnitudeSquared()
```

```csharp
public double MagnitudeReciprocal()
```

```csharp
public void Normalize()
```

```csharp
public double Dot(Point2D p)
```

```csharp
public double Cross(Point2D p)
```

```csharp
public void Clamp(Point2D low, Point2D high)
```

```csharp
public void Abs()
```

```csharp
public void Reciprocal()
```

```csharp
public void Translate(Point2D vector)
```

```csharp
public void Translate(double x, double y)
```

```csharp
public void Scale(Point2D vector)
```

```csharp
public void Scale(double scalar)
```

```csharp
public void Scale(double x, double y)
```

```csharp
public void Rotate(double radians)
```

```csharp
public void RotateDegrees(double degrees)
```

```csharp
public static double Dot(Point2D lhs, Point2D rhs)
```

```csharp
public static double Cross(Point2D lhs, Point2D rhs)
```

```csharp
public static Point2D Clamp(Point2D a, Point2D low, Point2D high)
```

```csharp
public static Point2D Min(Point2D a, Point2D b)
```

```csharp
public static Point2D Max(Point2D a, Point2D b)
```

```csharp
public static Point2D Abs(Point2D a)
```

```csharp
public static Point2D Reciprocal(Point2D a)
```

```csharp
public static Point2D Perpendicular(Point2D lhs, double scalar)
```

```csharp
public static Point2D Perpendicular(double scalar, Point2D rhs)
```

```csharp
public static bool operator <(Point2D lhs, Point2D rhs)
```

```csharp
public static bool operator >(Point2D lhs, Point2D rhs)
```
