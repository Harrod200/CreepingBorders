# TIRegionOutline

*Decompiled from `PavonisInteractive/TerraInvicta/TIRegionOutline.cs`.*


## Class `TIRegionOutline`

```csharp
public class TIRegionOutline
```

### Fields

| Name | Type |
|---|---|
| `name` | public string |
| `regionName` | public string |
| `nationTag` | public string |
| `poly2DList` | public List<CurvedPolygon> |
| `regionShapes` | public List<Vector3List> |
| `regionSurfacePoints` | public List<Vector3Array> |
| `labelPositions` | public List<LabelPosition> |

### Methods

```csharp
public Mesh ToMesh()
```

```csharp
public Mesh ToMesh2()
```

```csharp
public Mesh ToBorder(float width)
```

```csharp
public Mesh ToQuad(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, float inset)
```

```csharp
public Vector2[] CalculateClampedUVForMesh(Mesh msh)
```

```csharp
public float[] ComputeArcLengths(Vector3[] verts, int startIdx, int endIdx)
```

```csharp
public Vector2[] CalculateLinearUVForMesh(Mesh msh)
```
