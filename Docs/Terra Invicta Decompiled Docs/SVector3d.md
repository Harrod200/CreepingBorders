# SVector3d

*Decompiled from `SVector3d.cs`.*


## Struct `SVector3d`

```csharp
public struct SVector3d
```

### Fields

| Name | Type |
|---|---|
| `radius` | public double |
| `polar` | public double |
| `azimuth` | public double |

### Methods

```csharp
public SVector3d(double radius, double polar, double azimuth)
```

```csharp
public Vector3d ToCartesian()
```

```csharp
public static SVector3d ToSpherical(Vector3d v)
```
