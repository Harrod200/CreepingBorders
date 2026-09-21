# DTSweepDebugContext

*Decompiled from `Poly2Tri/DTSweepDebugContext.cs`.*


## Class `DTSweepDebugContext`

```csharp
public class DTSweepDebugContext : TriangulationDebugContext
```

### Fields

| Name | Type |
|---|---|
| `PrimaryTriangle` | public DelaunayTriangle |
| `SecondaryTriangle` | public DelaunayTriangle |
| `ActivePoint` | public TriangulationPoint |
| `ActiveNode` | public AdvancingFrontNode |
| `ActiveConstraint` | public DTSweepConstraint |
| `IsDebugContext` | public bool |
| `_primaryTriangle` | private DelaunayTriangle |
| `_secondaryTriangle` | private DelaunayTriangle |
| `_activePoint` | private TriangulationPoint |
| `_activeNode` | private AdvancingFrontNode |
| `_activeConstraint` | private DTSweepConstraint |

### Methods

```csharp
public DTSweepDebugContext(DTSweepContext tcx)
```

```csharp
public override void Clear()
```
