# RungeKutta4

*Decompiled from `PavonisInteractive/TerraInvicta/RungeKutta4.cs`.*


## Class `RungeKutta4`

```csharp
public static class RungeKutta4
```

### Fields

| Name | Type |
|---|---|
| `sixth` | private static double |

### Methods

```csharp
public static Matrix rk4(double t, Matrix x, Matrix u, double mu, double dt, RungeKutta4.VectorRkDelegate f)
```

```csharp
public delegate Matrix VectorRkDelegate(double t, Matrix x, Matrix u, double mu)
```
