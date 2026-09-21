# BezierCurves

*Decompiled from `Pixelplacement/BezierCurves.cs`.*


## Class `BezierCurves`

```csharp
public static class BezierCurves
```

### Methods

```csharp
public static Vector3 GetPoint(Vector3 startPosition, Vector3 controlPoint, Vector3 endPosition, float percentage)
```

```csharp
public static Vector3 GetFirstDerivative(Vector3 startPoint, Vector3 controlPoint, Vector3 endPosition, float percentage)
```

```csharp
public static Vector3 GetPoint(Vector3 startPosition, Vector3 endPosition, Vector3 startTangent, Vector3 endTangent, float percentage, bool evenDistribution, int distributionSteps)
```

```csharp
public static Vector3 GetFirstDerivative(Vector3 startPosition, Vector3 endPosition, Vector3 startTangent, Vector3 endTangent, float percentage)
```

```csharp
private static Vector3 Locate(Vector3 startPosition, Vector3 endPosition, Vector3 startTangent, Vector3 endTangent, float percentage)
```
