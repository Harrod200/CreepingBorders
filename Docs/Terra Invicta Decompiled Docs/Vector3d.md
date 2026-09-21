# Vector3d

*Decompiled from `UnityEngine/Vector3d.cs`.*


## Struct `Vector3d`

```csharp
public struct Vector3d
```

### Fields

| Name | Type |
|---|---|
| `xzy` | public readonly Vector3d |
| `normalized` | public readonly Vector3d |
| `magnitude` | public readonly double |
| `sqrMagnitude` | public readonly double |
| `operator` | public static bool |
| `kEpsilon` | public const double |
| `x` | public double |
| `y` | public double |
| `z` | public double |
| `zero` | public static readonly Vector3d |
| `one` | public static readonly Vector3d |
| `forward` | public static readonly Vector3d |
| `back` | public static readonly Vector3d |
| `up` | public static readonly Vector3d |
| `down` | public static readonly Vector3d |
| `left` | public static readonly Vector3d |
| `right` | public static readonly Vector3d |

### Methods

```csharp
public static explicit operator Vector3(Vector3d v)
```

```csharp
public static implicit operator Vector3d(Vector3 v)
```

```csharp
public Vector3d(double x, double y, double z)
```

```csharp
public Vector3d(float x, float y, float z)
```

```csharp
public Vector3d(Vector3d v3)
```

```csharp
public Vector3d(double x, double y)
```

```csharp
public override readonly bool Equals(object other)
```

```csharp
public override readonly int GetHashCode()
```

```csharp
public void Set(double new_x, double new_y, double new_z)
```

```csharp
public static Vector3d Lerp(Vector3d from, Vector3d to, double t)
```

```csharp
public static Vector3d MoveTowards(Vector3d current, Vector3d target, double maxDistanceDelta)
```

```csharp
public static Vector3d Scale(Vector3d a, Vector3d b)
```

```csharp
public void Scale(Vector3d scale)
```

```csharp
public static Vector3d SmoothDamp(Vector3d current, Vector3d target, ref Vector3d currentVelocity, double smoothTime, double maxSpeed)
```

```csharp
public static Vector3d SmoothDamp(Vector3d current, Vector3d target, ref Vector3d currentVelocity, double smoothTime)
```

```csharp
public static Vector3d SmoothDamp(Vector3d current, Vector3d target, ref Vector3d currentVelocity, double smoothTime, double maxSpeed, double deltaTime)
```

```csharp
public static Vector3d Cross(Vector3d lhs, Vector3d rhs)
```

```csharp
public static double Dot(in Vector3d lhs, in Vector3d rhs)
```

```csharp
public static Vector3d Normalize(Vector3d v)
```

```csharp
public void Normalize()
```

```csharp
public static Vector3d Reflect(Vector3d inDirection, Vector3d inNormal)
```

```csharp
public static Vector3d Project(Vector3d vector, Vector3d onNormal)
```

```csharp
public static Vector3d Exclude(Vector3d excludeThis, Vector3d fromThat)
```

```csharp
public static double Angle(in Vector3d from, in Vector3d to)
```

```csharp
public static double SignedAngle(in Vector3d from, in Vector3d to, in Vector3d axis)
```

```csharp
public static double Distance(in Vector3d a, in Vector3d b)
```

```csharp
public static Vector3d ClampMagnitude(Vector3d vector, double maxLength)
```

```csharp
public static double Magnitude(in Vector3d a)
```

```csharp
public static double SqrMagnitude(in Vector3d a)
```

```csharp
public static Vector3d Min(Vector3d lhs, Vector3d rhs)
```

```csharp
public static Vector3d Max(Vector3d lhs, Vector3d rhs)
```

```csharp
public static Vector3d RotateAround(Vector3d vector, Vector3d axis, double radians)
```

```csharp
public static Vector3d Flatten(Vector3d vector, Vector3d normalVector)
```

```csharp
public static Vector3d SwapYZ(Vector3d v)
```

```csharp
public static bool Approximately(in Vector3d a, in Vector3d b)
```

```csharp
public override readonly string ToString()
```

```csharp
public static Vector3d FromVector3(Vector3 v)
```

```csharp
public static Vector3d Slerp(Vector3d a, Vector3d b, double t)
```

```csharp
public static Vector3d RotateTowards(Vector3d a, Vector3d b, double maxRadians, double maxMag)
```

```csharp
public static void OrthoNormalize(ref Vector3d normal, ref Vector3d tangent)
```

```csharp
public static void OrthoNormalize(ref Vector3d normal, ref Vector3d tangent, ref Vector3d binormal)
```
