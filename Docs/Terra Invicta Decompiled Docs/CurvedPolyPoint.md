# CurvedPolyPoint

*Decompiled from `PavonisInteractive/TerraInvicta/CurvedPolyPoint.cs`.*


## Struct `CurvedPolyPoint`

```csharp
public struct CurvedPolyPoint
```

### Fields

| Name | Type |
|---|---|
| `x` | public float |
| `y` | public float |
| `operator` | public static bool |
| `bezier` | public bool |
| `anchor` | public Vector2 |
| `bezier1` | public Vector2 |
| `bezier2` | public Vector2 |

### Methods

```csharp
public CurvedPolyPoint(Vector2 val)
```

```csharp
public CurvedPolyPoint(float x, float y)
```

```csharp
public CurvedPolyPoint(float x, float y, float b1x, float b1y, float b2x, float b2y)
```

```csharp
public CurvedPolyPoint(double x, double y, double b1x, double b1y, double b2x, double b2y)
```

```csharp
public CurvedPolyPoint(Vector6d val)
```

```csharp
public CurvedPolyPoint NormalizeToRadial(float width, float height)
```

```csharp
public CurvedPolyPoint Scale(float xScale, float yScale, float zScale = 1f)
```

```csharp
private float ScaleWidth(float x, float width)
```

```csharp
private float ScaleHeight(float y, float height)
```

```csharp
public static explicit operator Vector2(CurvedPolyPoint p)
```

```csharp
public static explicit operator PolygonPoint(CurvedPolyPoint p)
```

```csharp
public override bool Equals(object other)
```

```csharp
public override int GetHashCode()
```
