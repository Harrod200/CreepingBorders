# OcTree

*Decompiled from `PavonisInteractive/TerraInvicta/GamePlayScript/PathFinding/OcTree.cs`.*


## Class `OcTree`

```csharp
public class OcTree
```

### Fields

| Name | Type |
|---|---|
| `BASE_MAP_SIZE` | private readonly int |
| `BASE_NODE_SIZE` | private readonly float |
| `_offset` | private Vector3 |
| `_navVolume` | private OcTreeNode[,,] |
| `DepthPriority` | public enum |

### Methods

```csharp
public OcTreeNode RandomNode()
```

```csharp
public OcTree(int volumeSize, float baseNodeSize, Vector3 center)
```

```csharp
public bool IsValidPosition(Vector3 position, out int x, out int y, out int z)
```

```csharp
public OcTreeNode GetChildNodeAtPosition(Vector3 position, int depth)
```

```csharp
public OcTreeNode GetChildNodeAtPosition(Vector3 position, OcTree.DepthPriority priority)
```

```csharp
public void DrawGizmos(bool forceAll = false)
```

```csharp
public void DrawGizmos(int COUNT, int depth = 0)
```
