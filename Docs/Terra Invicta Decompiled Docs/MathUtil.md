# MathUtil

*Decompiled from `Poly2Tri/MathUtil.cs`.*


## Class `MathUtil`

```csharp
public class MathUtil
```

### Fields

| Name | Type |
|---|---|
| `EPSILON` | public static double |

### Methods

```csharp
public static bool AreValuesEqual(double val1, double val2)
```

```csharp
public static bool AreValuesEqual(double val1, double val2, double tolerance)
```

```csharp
public static bool IsValueBetween(double val, double min, double max, double tolerance)
```

```csharp
public static double RoundWithPrecision(double f, double precision)
```

```csharp
public static double Clamp(double a, double low, double high)
```

```csharp
public static void Swap<T>(ref T a, ref T b)
```

```csharp
public static uint Jenkins32Hash(byte[] data, uint nInitialValue)
```

```csharp
public static Vector3d GetSphericalPosition(double latitude, double longitude, Quaterniond parentRotation, float parentRadius, Vector3d parentPosition)
```
