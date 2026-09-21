# Vector7d

*Decompiled from `UnityEngine/Vector7d.cs`.*


## Class `Vector7d`

```csharp
public class Vector7d
```

### Fields

| Name | Type |
|---|---|
| `normalized` | public Vector7d |
| `magnitude` | public double |
| `sqrMagnitude` | public double |
| `zero` | public static Vector7d |
| `one` | public static Vector7d |
| `operator` | public static bool |
| `v` | public double[] |
| `kEpsilon` | public const float |

### Methods

```csharp
public Vector7d(double x, double y, double z, double i, double j, double k, double w)
```

```csharp
public Vector7d(float x, float y, float z, float i, float j, float k, float w)
```

```csharp
public Vector7d(Vector3 v3, Vector3 i3, float w)
```

```csharp
public Vector7d(Vector3d v3, Vector3d i3, double w)
```

```csharp
public Vector7d(Vector7d v7)
```

```csharp
public static Vector7d Lerp(Vector7d from, Vector7d to, double t)
```

```csharp
public void Set(double new_x, double new_y, double new_z, double new_i, double new_j, double new_k, double new_w)
```

```csharp
public static Vector7d Scale(Vector7d a, Vector7d b)
```

```csharp
public void Scale(Vector7d scale)
```

```csharp
public override int GetHashCode()
```

```csharp
public override bool Equals(object other)
```

```csharp
public static Vector7d Normalize(Vector7d value)
```

```csharp
public void Normalize()
```

```csharp
public override string ToString()
```

```csharp
public static double Dot(Vector7d lhs, Vector7d rhs)
```

```csharp
public static Vector7d Project(Vector7d vector, Vector7d onNormal)
```

```csharp
public static Vector7d Exclude(Vector7d excludeThis, Vector7d fromThat)
```

```csharp
public static double Angle(Vector7d from, Vector7d to)
```

```csharp
public static double Distance(Vector7d a, Vector7d b)
```

```csharp
public static Vector7d ClampMagnitude(Vector7d vector, double maxLength)
```

```csharp
public static double Magnitude(Vector7d a)
```

```csharp
public static double SqrMagnitude(Vector7d a)
```

```csharp
public static Vector7d Min(Vector7d lhs, Vector7d rhs)
```

```csharp
public static Vector7d Max(Vector7d lhs, Vector7d rhs)
```

```csharp
public static double AngleBetween(Vector7d from, Vector7d to)
```
