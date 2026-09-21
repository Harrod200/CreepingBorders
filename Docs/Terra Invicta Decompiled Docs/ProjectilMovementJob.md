# ProjectilMovementJob

*Decompiled from `PavonisInteractive/TerraInvicta/Jobs/ProjectilMovementJob.cs`.*


## Struct `ProjectilMovementJob`

```csharp
public struct ProjectilMovementJob : IJobParallelForTransform
```

### Fields

| Name | Type |
|---|---|
| `EPSILON` | private const float |
| `DEG_TO_RADS` | private const float |
| `zeroVector` | private static readonly global::System.Numerics.Vector3 |
| `ElapsedTimeSinceLastUpdate` | public float |
| `ScalingFactor` | public float |
| `_projectileData` | public NativeArray<ProjectileJobData> |
| `_navigation_Constant` | private const float |

### Methods

```csharp
public void Execute(int index, TransformAccess transform)
```

```csharp
private void BallisticMovement(int index, TransformAccess transform)
```

```csharp
private void MissileMovement(int index, TransformAccess transform)
```

```csharp
private static float Min(float f1, float f2)
```

```csharp
private static float Abs(float f)
```

```csharp
public static float Dot(global::System.Numerics.Vector3 lhs, global::System.Numerics.Vector3 rhs)
```

```csharp
public static float SqrMagnitude(global::System.Numerics.Vector3 vector)
```

```csharp
public static float Magnitude(global::System.Numerics.Vector3 vector)
```

```csharp
public static float Distance(global::System.Numerics.Vector3 l, global::System.Numerics.Vector3 r)
```
