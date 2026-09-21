# TriangulationConstraint

*Decompiled from `Poly2Tri/TriangulationConstraint.cs`.*


## Class `TriangulationConstraint`

```csharp
public class TriangulationConstraint : Edge
```

### Fields

| Name | Type |
|---|---|
| `P` | public TriangulationPoint |
| `Q` | public TriangulationPoint |
| `ConstraintCode` | public uint |
| `mContraintCode` | private uint |

### Methods

```csharp
public TriangulationConstraint(TriangulationPoint p1, TriangulationPoint p2)
```

```csharp
public override string ToString()
```

```csharp
public void CalculateContraintCode()
```

```csharp
public static uint CalculateContraintCode(TriangulationPoint p, TriangulationPoint q)
```
