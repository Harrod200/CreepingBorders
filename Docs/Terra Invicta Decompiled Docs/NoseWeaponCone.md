# NoseWeaponCone

*Decompiled from `NoseWeaponCone.cs`.*


## Class `NoseWeaponCone`

```csharp
public class NoseWeaponCone : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `numCapRows` | public int |
| `numVertices` | public int |
| `radiusTop` | public float |
| `radiusBottom` | public float |
| `length` | public float |
| `openingAngle` | public float |
| `outside` | public bool |
| `inside` | public bool |
| `addCollider` | public bool |

### Methods

```csharp
private void Start()
```

```csharp
public void CreateCone(float angle)
```

```csharp
private void CreateSideVerticesNormalsUVs(ref Vector3[] vertices, ref Vector3[] normals, ref Vector2[] uvs, int offset)
```

```csharp
private void CreateSideTris(out int[] tris, int multiplier, int offset)
```

```csharp
private void CreateCapVerticesNormalsUVs(ref Vector3[] vertices, ref Vector3[] normals, ref Vector2[] uvs, int offset)
```

```csharp
private void CreateCapTris(out int[] tris, int multiplier, int offset)
```

```csharp
private T[] ConcatArrays<T>(params T[][] list)
```

```csharp
private Vector3 RotateRadiansOnAxis(Vector3 v, Vector3 axis, float radians)
```
