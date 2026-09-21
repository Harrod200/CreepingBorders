# LambertEquations

*Decompiled from `PavonisInteractive/TerraInvicta/LambertEquations.cs`.*


## Struct `LambertEquations`

```csharp
public struct LambertEquations
```

### Fields

| Name | Type |
|---|---|
| `lambda` | private double |
| `lambda2` | private double |
| `lambda3` | private double |

### Properties

- `public Vector3d initialVelocity`
- `public Vector3d finalVelocity`
- `public Vector3d burn0`
- `public Vector3d burn1`

### Methods

```csharp
public double SolveLambert(double TransitTimeSeconds, CartesianState InitialState, CartesianState EndState, double barycenterMu, bool bRetrograde = false, bool bFastPass = false)
```

```csharp
private double householder(double T, double x0, double allowedError, int maxIterations)
```

```csharp
private double xToTimeOfTransit(double x)
```

```csharp
private double xToTimeOfTransit_Lagrange(double x)
```

```csharp
private double xToTimeOfTransit_Lancaster(double x)
```

```csharp
private double xToTimeOfTransit_Battin(double x)
```

```csharp
private double hypergeometricF(double z, double tol)
```

```csharp
private void dTdx(ref double DT, ref double DDT, ref double DDDT, double x, double T)
```
