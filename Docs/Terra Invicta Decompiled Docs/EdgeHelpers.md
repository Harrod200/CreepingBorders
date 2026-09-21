# EdgeHelpers

*Decompiled from `EdgeHelpers.cs`.*


## Class `EdgeHelpers`

```csharp
public static class EdgeHelpers
```

### Fields

| Name | Type |
|---|---|
| `Edge` | public struct |
| `v1` | public int |
| `v2` | public int |
| `triangleIndex` | public int |
| `normal` | public Vector3 |

### Methods

```csharp
private static Vector3 CalculateNormal(Vector3 v1, Vector3 v2)
```

```csharp
public static List<EdgeHelpers.Edge> GetEdges(int[] indices, Vector3[] vertices)
```

```csharp
public static List<EdgeHelpers.Edge> GetEdges(int[] indices)
```

```csharp
public static List<EdgeHelpers.Edge> FindBoundary(this List<EdgeHelpers.Edge> aEdges)
```

```csharp
public static List<EdgeHelpers.Edge> SortEdges(this List<EdgeHelpers.Edge> aEdges)
```

```csharp
public Edge(int aV1, int aV2, int aIndex, Vector3 normal)
```
