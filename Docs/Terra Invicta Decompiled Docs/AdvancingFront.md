# AdvancingFront

*Decompiled from `Poly2Tri/AdvancingFront.cs`.*


## Class `AdvancingFront`

```csharp
public class AdvancingFront
```

### Fields

| Name | Type |
|---|---|
| `Head` | public AdvancingFrontNode |
| `Tail` | public AdvancingFrontNode |
| `Search` | protected AdvancingFrontNode |

### Methods

```csharp
public AdvancingFront(AdvancingFrontNode head, AdvancingFrontNode tail)
```

```csharp
public void AddNode(AdvancingFrontNode node)
```

```csharp
public void RemoveNode(AdvancingFrontNode node)
```

```csharp
public override string ToString()
```

```csharp
private AdvancingFrontNode FindSearchNode(double x)
```

```csharp
public AdvancingFrontNode LocateNode(TriangulationPoint point)
```

```csharp
private AdvancingFrontNode LocateNode(double x)
```

```csharp
public AdvancingFrontNode LocatePoint(TriangulationPoint point)
```
