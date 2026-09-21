# BurnBezierDescription

*Decompiled from `PavonisInteractive/TerraInvicta/BurnBezierDescription.cs`.*


## Class `BurnBezierDescription`

```csharp
public class BurnBezierDescription
```

### Fields

| Name | Type |
|---|---|
| `startPosition` | public Vector3d |
| `endPosition` | public Vector3d |
| `startVelocityControlPoint` | public Vector3d |
| `endVelocityControlPoint` | public Vector3d |

### Methods

```csharp
public BurnBezierDescription()
```

```csharp
public BurnBezierDescription(CartesianState startState, CartesianState endState, double duration_s)
```

```csharp
public Vector3d LocationInBurn(double timeInBurn, double totalBurnDuration)
```

```csharp
public Vector3d VelocityInBurn(double timeInBurn, double totalBurnDuration)
```

```csharp
public double MaxAccelerationDuringBurn_mps2(double burnDuration_s)
```

```csharp
public double InitialAcceleration(double burnDuration_s)
```

```csharp
public double FinalAcceleration(double burnDuration_s)
```

```csharp
public string deepDump()
```
