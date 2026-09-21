# LuDecomposition

*Decompiled from `UnityEngine/LuDecomposition.cs`.*


## Class `LuDecomposition`

```csharp
public class LuDecomposition
```

### Fields

| Name | Type |
|---|---|
| `NonSingular` | public bool |
| `Determinant` | public double |
| `LowerTriangularFactor` | public Matrix |
| `UpperTriangularFactor` | public Matrix |
| `PivotPermutationVector` | public double[] |
| `LU` | private Matrix |
| `pivotSign` | private int |
| `pivotVector` | private int[] |

### Methods

```csharp
public LuDecomposition(Matrix value)
```

```csharp
public Matrix Solve(Matrix value)
```
