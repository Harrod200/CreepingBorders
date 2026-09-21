# SVector3

*Decompiled from `SVector3.cs`.*


## Struct `SVector3`

```csharp
public struct SVector3
```

### Fields

| Name | Type |
|---|---|
| `radius` | public float |
| `polar` | public float |
| `azimuth` | public float |

### Methods

```csharp
public SVector3(float radius, float polar, float azimuth)
```

```csharp
public Vector3 ToCartesian()
```

```csharp
public static SVector3 ToSpherical(Vector3 v)
```
