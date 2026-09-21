# Mathd

*Decompiled from `UnityEngine/Mathd.cs`.*


## Struct `Mathd`

```csharp
public struct Mathd
```

### Fields

| Name | Type |
|---|---|
| `G` | public static double |
| `HALFPI` | public const double |
| `PI` | public const double |
| `TWOPI` | public const double |
| `Infinity` | public const double |
| `NegativeInfinity` | public const double |
| `Deg2Rad` | public const double |
| `Rad2Deg` | public const double |
| `Epsilon` | public const double |
| `TWOPIf` | public const float |
| `Log10Two` | public const float |
| `LnTwo` | public const float |

### Methods

```csharp
public static double Sinh(double d)
```

```csharp
public static double Cosh(double d)
```

```csharp
public static double Tanh(double x)
```

```csharp
public static double ACosh(double x)
```

```csharp
public static double ASinh(double x)
```

```csharp
public static double Sin(double d)
```

```csharp
public static double Cos(double d)
```

```csharp
public static double Tan(double d)
```

```csharp
public static double Asin(double d)
```

```csharp
public static double Acos(double d)
```

```csharp
public static double Atan(double d)
```

```csharp
public static double Atan2(double y, double x)
```

```csharp
public static double Atanh(double d)
```

```csharp
public static double Sqrt(double d)
```

```csharp
public static double Abs(double d)
```

```csharp
public static int Abs(int value)
```

```csharp
public static double Normalize_Rad(double angle)
```

```csharp
public static double Min(double a, double b)
```

```csharp
public static double Min(params double[] values)
```

```csharp
public static int Min(int a, int b)
```

```csharp
public static int Min(params int[] values)
```

```csharp
public static double Max(double a, double b)
```

```csharp
public static double Max(params double[] values)
```

```csharp
public static int Max(int a, int b)
```

```csharp
public static int Max(params int[] values)
```

```csharp
public static double Pow(double d, double p)
```

```csharp
public static double Exp(double power)
```

```csharp
public static double Log(double d, double p)
```

```csharp
public static double Log(double d)
```

```csharp
public static double Log10(double d)
```

```csharp
public static double Ceil(double d)
```

```csharp
public static double Floor(double d)
```

```csharp
public static double Round(double d)
```

```csharp
public static int CeilToInt(double d)
```

```csharp
public static int FloorToInt(double d)
```

```csharp
public static int RoundToInt(double d)
```

```csharp
public static double Sign(double d)
```

```csharp
public static double Clamp(double value, double min, double max)
```

```csharp
public static int Clamp(int value, int min, int max)
```

```csharp
public static double Clamp01(double value)
```

```csharp
public static double ClampRadiansTwoPI(double angle)
```

```csharp
public static double ClampRadiansPI(double angle)
```

```csharp
public static double Lerp(double from, double to, double t)
```

```csharp
public static double LerpAngle(double a, double b, double t)
```

```csharp
public static double LerpRadians(double a, double b, double t)
```

```csharp
public static double Berp(double a, double b, double t)
```

```csharp
public static double BerpRadians(double a, double b, double t)
```

```csharp
public static double MoveTowards(double current, double target, double maxDelta)
```

```csharp
public static double MoveTowardsAngle(double current, double target, double maxDelta)
```

```csharp
public static double SmoothStep(double from, double to, double t)
```

```csharp
public static double Gamma(double value, double absmax, double gamma)
```

```csharp
public static bool Approximately(double a, double b)
```

```csharp
public static double SmoothDamp(double current, double target, ref double currentVelocity, double smoothTime, double maxSpeed)
```

```csharp
public static double SmoothDamp(double current, double target, ref double currentVelocity, double smoothTime)
```

```csharp
public static double SmoothDamp(double current, double target, ref double currentVelocity, double smoothTime, double maxSpeed, double deltaTime)
```

```csharp
public static double SmoothDampAngle(double current, double target, ref double currentVelocity, double smoothTime, double maxSpeed)
```

```csharp
public static double SmoothDampAngle(double current, double target, ref double currentVelocity, double smoothTime)
```

```csharp
public static double SmoothDampAngle(double current, double target, ref double currentVelocity, double smoothTime, double maxSpeed, double deltaTime)
```

```csharp
public static double Repeat(double t, double length)
```

```csharp
public static double PingPong(double t, double length)
```

```csharp
public static double InverseLerp(double from, double to, double value)
```

```csharp
public static double DeltaAngle(double current, double target)
```

```csharp
internal static bool LineIntersection(in Vector2d p1, in Vector2d p2, in Vector2d p3, in Vector2d p4, ref Vector2d result)
```

```csharp
internal static bool LineSegmentIntersection(in Vector2d p1, in Vector2d p2, in Vector2d p3, in Vector2d p4, ref Vector2d result)
```

```csharp
public static int d100()
```

```csharp
public static double AngularRadiusOfSphere_Rad(double radius, double distance)
```

```csharp
public static double AngularDiameterOfSphere(double radius, double distance)
```

```csharp
public static double AngularDiameterOfPlane(double radius, double distance)
```

```csharp
public static double SumProduct(double[] list1, double[] list2)
```

```csharp
public static double WeightedMean(double[] list1, double[] weights)
```
