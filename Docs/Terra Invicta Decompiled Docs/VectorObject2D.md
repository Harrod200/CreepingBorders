# VectorObject2D

*Decompiled from `Vectrosity/VectorObject2D.cs`.*


## Class `VectorObject2D`

```csharp
public class VectorObject2D : RawImage, IVectorObject
```

### Fields

| Name | Type |
|---|---|
| `m_updateVerts` | private bool |
| `m_updateUVs` | private bool |
| `m_updateColors` | private bool |
| `m_updateNormals` | private bool |
| `m_updateTangents` | private bool |
| `m_updateTris` | private bool |
| `m_mesh` | private Mesh |
| `vectorLine` | public VectorLine |
| `vertexHelper` | private static VertexHelper |

### Methods

```csharp
public void SetVectorLine(VectorLine vectorLine, Texture tex, Material mat, bool useCustomMaterial)
```

```csharp
public void Destroy()
```

```csharp
public void DestroyNow()
```

```csharp
public void Enable(bool enable)
```

```csharp
public void SetTexture(Texture tex)
```

```csharp
public void SetMaterial(Material mat)
```

```csharp
protected override void UpdateGeometry()
```

```csharp
private void SetupMesh()
```

```csharp
private void SetMeshBounds()
```

```csharp
protected override void OnPopulateMesh(VertexHelper vh)
```

```csharp
public void SetName(string name)
```

```csharp
public void UpdateVerts()
```

```csharp
public void UpdateUVs()
```

```csharp
public void UpdateColors()
```

```csharp
public void UpdateNormals()
```

```csharp
public void UpdateTangents()
```

```csharp
public void UpdateTris()
```

```csharp
public void UpdateMeshAttributes()
```

```csharp
public void ClearMesh()
```

```csharp
public int VertexCount()
```
