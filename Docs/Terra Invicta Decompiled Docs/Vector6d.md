# Vector6d

*Decompiled from `UnityEngine/Vector6d.cs`.*


## Struct `Vector6d`

```csharp
public struct Vector6d
```

### Fields

| Name | Type |
|---|---|
| `normalized` | public Vector6d |
| `magnitude` | public double |
| `sqrMagnitude` | public double |
| `zero` | public static Vector6d |
| `one` | public static Vector6d |
| `operator` | public static bool |
| `v` | public double[] |
| `kEpsilon` | public const float |

### Methods

```csharp
public Vector6d(double x, double y, double z, double i, double j, double k)
```

```csharp
public Vector6d(float x, float y, float z, float i, float j, float k)
```

```csharp
public Vector6d(Vector3 v3, Vector3 i3)
```

```csharp
public Vector6d(Vector3d v3, Vector3d i3)
```

```csharp
public static Vector6d Lerp(Vector6d from, Vector6d to, double t)
```

```csharp
public static Vector6d Slerp(Vector6d from, Vector6d to, double t)
```

```csharp
public void Set(double new_x, double new_y, double new_z, double new_i, double new_j, double new_k)
```

```csharp
public static Vector6d Scale(Vector6d a, Vector6d b)
```

```csharp
public void Scale(Vector6d scale)
```

```csharp
public override int GetHashCode()
```

```csharp
public override bool Equals(object other)
```

```csharp
public static Vector6d Normalize(Vector6d value)
```

```csharp
public void Normalize()
```

```csharp
public override string ToString()
```

```csharp
public static double Dot(Vector6d lhs, Vector6d rhs)
```

```csharp
public static Vector6d Project(Vector6d vector, Vector6d onNormal)
```

```csharp
public static Vector6d Exclude(Vector6d excludeThis, Vector6d fromThat)
```

```csharp
public static double Angle(Vector6d from, Vector6d to)
```

```csharp
public static double Distance(Vector6d a, Vector6d b)
```

```csharp
public static Vector6d ClampMagnitude(Vector6d vector, double maxLength)
```

```csharp
public static double Magnitude(Vector6d a)
```

```csharp
public static double SqrMagnitude(Vector6d a)
```

```csharp
public static Vector6d Min(Vector6d lhs, Vector6d rhs)
```

```csharp
public static Vector6d Max(Vector6d lhs, Vector6d rhs)
```

```csharp
public static double AngleBetween(Vector6d from, Vector6d to)
```
