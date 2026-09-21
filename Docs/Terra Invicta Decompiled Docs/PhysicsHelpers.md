# PhysicsHelpers

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/PhysicsHelpers.cs`.*


## Class `PhysicsHelpers`

```csharp
public static class PhysicsHelpers
```

### Methods

```csharp
public static Vector3 DisplacementFromAccelerationAndTime(Vector3 heading, float a, float t)
```

```csharp
public static float DisplacementFromVelocityAccelerationAndTime(float v, float a, float t)
```

```csharp
public static float DisplacementFromAccelerationAndTime(float a, float t)
```

```csharp
public static float TimeFromDisplacementAndAcceleration(float d, float a)
```

```csharp
public static float TimeSquaredFromDisplacementAndAcceleration(float d, float a)
```

```csharp
public static float AccelerationFromDisplacementAndTime(float d, float t)
```

```csharp
public static float AccelerationFromDisplacementTimeAndBurnDuration(float d, float t, float b)
```

```csharp
public static float DisplacementFromVelocityAndTime(float v, float t)
```

```csharp
public static Vector3 DisplacementFromVelocityAndTime(Vector3 v, float t)
```

```csharp
public static Vector3 PositionFromVelocityAndTime(Vector3 pos, Vector3 v, float t)
```

```csharp
public static Vector3 VelocityFromAccelerationAndTime(Vector3 heading, float a, float t)
```

```csharp
public static float VelocityFromAccelerationAndTime(float a, float t)
```

```csharp
public static float RadianAngleBetweenQuaternions(Quaternion q1, Quaternion q2)
```

```csharp
public static float RadianAngleBetweenVectors(Vector3 v1, Vector3 v2)
```

```csharp
public static Vector3 RotateVectorAroundAxis(Vector3 v, Vector3 a, float d)
```
