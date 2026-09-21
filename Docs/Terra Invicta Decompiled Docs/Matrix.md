# Matrix

*Decompiled from `UnityEngine/Matrix.cs`.*


## Class `Matrix`

```csharp
public class Matrix
```

### Fields

| Name | Type |
|---|---|
| `Array` | internal double[][] |
| `Rows` | public int |
| `Columns` | public int |
| `Square` | public bool |
| `Symmetric` | public bool |
| `Norm1` | public double |
| `InfinityNorm` | public double |
| `FrobeniusNorm` | public double |
| `operator` | public static bool |
| `Inverse` | public Matrix |
| `Determinant` | public double |
| `Trace` | public double |
| `data` | private double[][] |
| `rows` | private int |
| `columns` | private int |

### Methods

```csharp
public Matrix(int rows, int columns)
```

```csharp
public Matrix(int rows, int columns, double value)
```

```csharp
public Matrix(double[][] value)
```

```csharp
public override bool Equals(object obj)
```

```csharp
public static bool Equals(Matrix left, Matrix right)
```

```csharp
public override int GetHashCode()
```

```csharp
public Matrix Submatrix(int startRow, int endRow, int startColumn, int endColumn)
```

```csharp
public Matrix Submatrix(int[] rowIndexes, int[] columnIndexes)
```

```csharp
public Matrix Submatrix(int i0, int i1, int[] c)
```

```csharp
public Matrix Submatrix(int[] r, int j0, int j1)
```

```csharp
public Matrix Clone()
```

```csharp
public Matrix Transpose()
```

```csharp
public static Matrix Negate(Matrix value)
```

```csharp
public static Matrix Add(Matrix left, Matrix right)
```

```csharp
public static Matrix Subtract(Matrix left, Matrix right)
```

```csharp
public static Matrix Multiply(Matrix left, double right)
```

```csharp
public static Matrix Multiply(Matrix left, Matrix right)
```

```csharp
public Matrix Solve(Matrix rightHandSide)
```

```csharp
public static Matrix Diagonal(int rows, int columns, double value)
```

```csharp
public override string ToString()
```

```csharp
private static double Hypotenuse(double a, double b)
```
