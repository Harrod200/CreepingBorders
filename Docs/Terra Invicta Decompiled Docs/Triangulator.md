# Triangulator

*Decompiled from `Triangulator.cs`.*


## Class `Triangulator`

```csharp
public class Triangulator
```

### Fields

| Name | Type |
|---|---|
| `m_points` | private List<CurvedPolyPoint> |

### Methods

```csharp
public Triangulator(CurvedPolyPoint[] points)
```

```csharp
public List<int> Triangulate()
```

```csharp
private float Area()
```

```csharp
private bool Snip(int u, int v, int w, int n, int[] V)
```

```csharp
private bool InsideTriangle(Vector2 A, Vector2 B, Vector2 C, Vector2 P)
```
