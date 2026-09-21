# TriangulationContext

*Decompiled from `Poly2Tri/TriangulationContext.cs`.*


## Class `TriangulationContext`

```csharp
public abstract class TriangulationContext
```

### Fields

| Name | Type |
|---|---|
| `DTDebugContext` | public DTSweepDebugContext |
| `Triangles` | public readonly List<DelaunayTriangle> |
| `Points` | public readonly List<TriangulationPoint> |

### Properties

- `public TriangulationDebugContext DebugContext`
- `public TriangulationMode TriangulationMode`
- `public ITriangulatable Triangulatable`
- `public int StepCount`
- `public abstract TriangulationAlgorithm Algorithm`

### Methods

```csharp
public void Done()
```

```csharp
public virtual void PrepareTriangulation(ITriangulatable t)
```

```csharp
public abstract TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b)
```

```csharp
public void Update(string message)
```

```csharp
public virtual void Clear()
```
