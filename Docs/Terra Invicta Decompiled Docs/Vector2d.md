# Vector2d

*Decompiled from `UnityEngine/Vector2d.cs`.*


## Struct `Vector2d`

```csharp
public struct Vector2d
```

### Fields

| Name | Type |
|---|---|
| `normalized` | public readonly Vector2d |
| `magnitude` | public readonly double |
| `sqrMagnitude` | public readonly double |
| `operator` | public static bool |
| `kEpsilon` | public const double |
| `x` | public double |
| `y` | public double |
| `zero` | public static readonly Vector2d |
| `one` | public static readonly Vector2d |
| `up` | public static readonly Vector2d |
| `down` | public static readonly Vector2d |
| `right` | public static readonly Vector2d |
| `left` | public static readonly Vector2d |

### Methods

```csharp
public static explicit operator Vector2(Vector2d v)
```

```csharp
public static explicit operator Vector3(Vector2d v)
```

```csharp
public static implicit operator Vector2d(Vector3d v)
```

```csharp
public static implicit operator Vector3d(Vector2d v)
```

```csharp
public Vector2d(double x, double y)
```

```csharp
public override readonly bool Equals(object other)
```

```csharp
public override readonly int GetHashCode()
```

```csharp
public void Set(double new_x, double new_y)
```

```csharp
public static Vector2d Lerp(Vector2d from, Vector2d to, double t)
```

```csharp
public static Vector2d MoveTowards(Vector2d current, Vector2d target, double maxDistanceDelta)
```

```csharp
public static Vector2d Scale(Vector2d a, Vector2d b)
```

```csharp
public void Scale(Vector2d scale)
```

```csharp
public static double Dot(in Vector2d lhs, in Vector2d rhs)
```

```csharp
public static Vector2d Normalize(Vector2d v)
```

```csharp
public void Normalize()
```

```csharp
public static double Angle(in Vector2d from, in Vector2d to)
```

```csharp
public static double Distance(in Vector2d a, in Vector2d b)
```

```csharp
public static Vector2d ClampMagnitude(Vector2d vector, double maxLength)
```

```csharp
public static double Magnitude(in Vector2d a)
```

```csharp
public static double SqrMagnitude(in Vector2d a)
```

```csharp
public static Vector2d Min(Vector2d lhs, Vector2d rhs)
```

```csharp
public static Vector2d Max(Vector2d lhs, Vector2d rhs)
```

```csharp
public override readonly string ToString()
```
