# BezierCurve

*Decompiled from `BezierCurve.cs`.*


## Class `BezierCurve`

```csharp
public class BezierCurve
```

### Fields

| Name | Type |
|---|---|
| `Length` | public double |
| `FastLength` | public double |
| `A` | public Vector3d |
| `B` | public Vector3d |
| `ControlPointA` | public Vector3d |
| `ControlPointB` | public Vector3d |
| `Type` | public BezierCurveType |
| `cacheA` | private Vector3d |
| `cacheB` | private Vector3d |
| `cacheControlPointA` | private Vector3d |
| `cacheControlPointB` | private Vector3d |
| `cacheType` | private BezierCurveType |
| `cachedLength` | private double |

### Methods

```csharp
public void RefreshCache()
```

```csharp
public double ComputeLength(int resolution = 10)
```

```csharp
public Vector3d GetPosition(double t)
```
