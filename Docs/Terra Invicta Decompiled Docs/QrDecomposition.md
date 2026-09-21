# QrDecomposition

*Decompiled from `UnityEngine/QrDecomposition.cs`.*


## Class `QrDecomposition`

```csharp
public class QrDecomposition
```

### Fields

| Name | Type |
|---|---|
| `FullRank` | public bool |
| `UpperTriangularFactor` | public Matrix |
| `OrthogonalFactor` | public Matrix |
| `QR` | private Matrix |
| `Rdiag` | private double[] |

### Methods

```csharp
public QrDecomposition(Matrix value)
```

```csharp
public Matrix Solve(Matrix value)
```

```csharp
private static double Hypotenuse(double a, double b)
```
