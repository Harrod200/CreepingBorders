# Quaterniond

*Decompiled from `UnityEngine/Quaterniond.cs`.*


## Struct `Quaterniond`

```csharp
public struct Quaterniond
```

### Fields

| Name | Type |
|---|---|
| `identity` | public static Quaterniond |
| `operator` | public static bool |
| `kEpsilon` | public const double |
| `w` | public double |
| `x` | public double |
| `y` | public double |
| `z` | public double |

### Methods

```csharp
public static explicit operator Quaternion(Quaterniond q)
```

```csharp
public static implicit operator Quaterniond(Quaternion q)
```

```csharp
public Quaterniond(double x, double y, double z, double w)
```

```csharp
public Quaterniond(float x, float y, float z, float w)
```

```csharp
public Quaterniond(Quaterniond q)
```

```csharp
public override readonly bool Equals(object other)
```

```csharp
public override readonly int GetHashCode()
```

```csharp
public readonly double Angle(Quaterniond a, Quaterniond b)
```

```csharp
public static Quaterniond AngleAxis(double angle, Vector3d axis)
```

```csharp
public static Quaterniond AngleAxis(float angle, Vector3d axis)
```

```csharp
public static double Dot(in Quaterniond lhs, in Quaterniond rhs)
```

```csharp
public static Quaterniond Inverse(Quaterniond q)
```

```csharp
public static Quaterniond Lerp(Quaterniond from, Quaterniond to, double t)
```

```csharp
public void Set(double new_w, double new_x, double new_y, double new_z)
```

```csharp
public override readonly string ToString()
```

```csharp
internal readonly Quaterniond Normalized()
```

```csharp
internal static double Magnitude(in Quaterniond a)
```

```csharp
internal static double SqrMagnitude(in Quaterniond a)
```

```csharp
public static Quaterniond Euler(double x, double y, double z)
```

```csharp
public static Quaterniond Euler(float x, float y, float z)
```

```csharp
public static Quaterniond Euler(Vector3d v)
```

```csharp
public static Quaterniond Euler(Vector3 v)
```

```csharp
public static Quaterniond FromToRotation(Vector3d from, Vector3d to)
```

```csharp
public static Quaterniond FromToRotation(Vector3 from, Vector3 to)
```

```csharp
public static Quaterniond LookRotation(Vector3d forward, Vector3d upwards)
```

```csharp
public static Quaterniond LookRotation(Vector3d forward)
```

```csharp
public static Quaterniond RotateTowards(Quaterniond from, Quaterniond to, double maxDegreesDelta)
```

```csharp
public static Quaterniond Slerp(Quaterniond from, Quaterniond to, double t)
```

```csharp
public static Quaterniond SetFromToRotation(Vector3d fromDirection, Vector3d toDirection)
```

```csharp
public static Quaterniond SetLookRotation(Vector3d view)
```

```csharp
public static Quaterniond SetLookRotation(Vector3d view, Vector3d up)
```

```csharp
public static void ToAngleAxis(Quaterniond qd, out double angle, out Vector3d axis)
```
