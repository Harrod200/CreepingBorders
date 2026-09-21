# OcTreeNode

*Decompiled from `PavonisInteractive/TerraInvicta/GamePlayScript/PathFinding/OcTreeNode.cs`.*


## Class `OcTreeNode`

```csharp
public class OcTreeNode
```

### Fields

| Name | Type |
|---|---|
| `HasChildren` | public bool |
| `CanContainChildren` | public bool |
| `Depth` | public int |
| `Length` | public float |
| `Center` | public Vector3 |
| `Root` | public OcTreeNode |
| `Parent` | public OcTreeNode |
| `MAX_DEPTH` | private const int |
| `_bounds` | private Bounds |
| `_center` | private Vector3 |
| `_depth` | private int |
| `_length` | private float |
| `_root` | private OcTreeNode |
| `_parent` | private OcTreeNode |
| `_children` | private OcTreeNode[] |

### Properties

- `private bool Marked`

### Methods

```csharp
public OcTreeNode(float length, Vector3 center, int depth = 0)
```

```csharp
public OcTreeNode(OcTreeNode root, OcTreeNode parent, Bounds bounds, float length, int depth = 0)
```

```csharp
public OcTreeNode GetChildNode(Vector3 point)
```

```csharp
public bool Contains(Vector3 p)
```

```csharp
public bool Intersects(ref Bounds b)
```

```csharp
private void SetValues(float lengthVal, Vector3 centerVal)
```

```csharp
private void CreateChildren()
```

```csharp
public void DrawAllBounds(bool forceAll = false)
```

```csharp
public void DrawImmediateBounds()
```

```csharp
public void DrawChildrenNodes(int depth)
```
