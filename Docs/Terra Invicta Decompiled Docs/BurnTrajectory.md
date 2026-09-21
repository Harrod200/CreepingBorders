# BurnTrajectory

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/BurnTrajectory.cs`.*


## Class `BurnTrajectory`

```csharp
public sealed class BurnTrajectory : HoldTrajectory
```

### Fields

| Name | Type |
|---|---|
| `_linearAcceleration` | private float |
| `IsValidBurnTrajectory` | public bool |

### Methods

```csharp
public BurnTrajectory(IPreviousTrajectory start, IProposedWaypoint end, float requiredDisplacement, float linearAcceleration)
```

```csharp
public override bool IsInBurn(TIDateTime time)
```

```csharp
public static float TimeRequiredForDisplacement(Vector3 desiredDisplacementVector, float linearAcceleration)
```

```csharp
protected override Vector3 PositionAt(float elapsedTime)
```

```csharp
protected override Vector3 VelocityAt(float elapsedTime)
```

```csharp
protected override Vector3 AccelerationAt(float elapsedTime)
```

```csharp
public override List<ValueTuple<TIDateTime, bool>> GetBurnTimings()
```
