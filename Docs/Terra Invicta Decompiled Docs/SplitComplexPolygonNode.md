# SplitComplexPolygonNode

*Decompiled from `Poly2Tri/SplitComplexPolygonNode.cs`.*


## Class `SplitComplexPolygonNode`

```csharp
public class SplitComplexPolygonNode
```

### Fields

| Name | Type |
|---|---|
| `NumConnected` | public int |
| `Position` | public Point2D |
| `operator` | public static bool |
| `mConnected` | private List<SplitComplexPolygonNode> |
| `mPosition` | private Point2D |

### Methods

```csharp
public SplitComplexPolygonNode()
```

```csharp
public SplitComplexPolygonNode(Point2D pos)
```

```csharp
public override bool Equals(object obj)
```

```csharp
public bool Equals(SplitComplexPolygonNode pn)
```

```csharp
public override int GetHashCode()
```

```csharp
public override string ToString()
```

```csharp
private bool IsRighter(double sinA, double cosA, double sinB, double cosB)
```

```csharp
private int remainder(int x, int modulus)
```

```csharp
public void AddConnection(SplitComplexPolygonNode toMe)
```

```csharp
public void RemoveConnection(SplitComplexPolygonNode fromMe)
```

```csharp
private void RemoveConnectionByIndex(int index)
```

```csharp
public void ClearConnections()
```

```csharp
private bool IsConnectedTo(SplitComplexPolygonNode me)
```

```csharp
public SplitComplexPolygonNode GetRightestConnection(SplitComplexPolygonNode incoming)
```

```csharp
public SplitComplexPolygonNode GetRightestConnection(Point2D incomingDir)
```
