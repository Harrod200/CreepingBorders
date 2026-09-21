# BezierPath

*Decompiled from `BezierPath.cs`.*


## Class `BezierPath`

```csharp
public class BezierPath
```

### Fields

| Name | Type |
|---|---|
| `Segments` | public List<BezierCurve> |

### Methods

```csharp
public BezierPath(IEnumerable<BezierCurve> curves = null)
```

```csharp
public int GetIndex(double t, out double lerpFactor)
```

```csharp
public Vector3d GetPosition(double t)
```

```csharp
public double GetValue(double t, Func<int, double> GetValueAtIndex)
```

```csharp
public double GetValue<T>(double t, IEnumerable<T> elements, Func<T, double> GetElementValue)
```

```csharp
public double GetPartialVisualLength(Vector3d eye, double t0, double t1, Func<Vector3d, Vector3d> GetTransformedPosition = null, int resolution = 5)
```

```csharp
public double GetVisualLength(Vector3d eye, Func<Vector3d, Vector3d> GetTransformedPosition = null, int resolution = 5)
```

```csharp
public double GetMiddleX(Func<double, double, double> Function, double x0, double x1, double toleranceFraction = 0.05000000074505806)
```

```csharp
public List<double> Subdivide(Func<double, double, double> Function, int steps, bool fast = true)
```

```csharp
public IEnumerable<double> Subdivide(Func<double, double, double> Function, double x0, double x1, int steps, bool fast = true)
```

```csharp
public List<double> GetEqualVisualLengthSudvision(Vector3d eye, Func<Vector3d, Vector3d> GetTransformedPosition, int subdivisionCount = 7)
```

```csharp
public double GetVisualLengthOfSubdivisionSegment(List<double> subdivision, int index, Vector3d eye, Func<Vector3d, Vector3d> GetTransformedPosition)
```

```csharp
public List<double> GetTransformedLengthOfSubdivisionSegments(List<double> subdivision, Vector3d eye, Func<Vector3d, Vector3d> GetTransformedPosition = null)
```

```csharp
public Func<double, double> GetBakedVisualTFunction(Vector3d eye, Func<Vector3d, Vector3d> GetTransformedPosition = null, int resolution = 10)
```

```csharp
public double GetVisualT(double t, Vector3d eye, Func<Vector3d, Vector3d> GetTransformedPosition = null, List<double> subdivision = null, List<double> transformedLengths = null)
```

```csharp
public void Smooth()
```
