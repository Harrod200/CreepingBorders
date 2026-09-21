# UILineRenderer

*Decompiled from `UILineRenderer.cs`.*


## Class `UILineRenderer`

```csharp
public class UILineRenderer : Graphic
```

### Fields

| Name | Type |
|---|---|
| `mainTexture` | public override Texture |
| `texture` | public Texture |
| `uvRect` | public Rect |
| `m_Texture` | private Texture |
| `m_UVRect` | private Rect |
| `LineThickness` | public float |
| `UseMargins` | public bool |
| `Margin` | public Vector2 |
| `Points` | public Vector2[] |
| `relativeSize` | public bool |

### Methods

```csharp
protected new void OnPopulateMesh(Mesh toFill)
```

```csharp
protected UIVertex[] SetVbo(VertexHelper vbo, Vector2[] vertices, Vector2[] uvs)
```

```csharp
public Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angles)
```
