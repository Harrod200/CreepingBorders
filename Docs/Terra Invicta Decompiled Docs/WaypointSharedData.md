# WaypointSharedData

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/WaypointSharedData.cs`.*


## Class `WaypointSharedData`

```csharp
public class WaypointSharedData
```

### Properties

- `public float WaypointTimeDelta`
- `public float LinearAcceleration`
- `public float CruiseAcceleration`
- `public float MaxAngularVelocity`
- `public float AngularAccelerationRads`
- `public Transform WaypointPrefab`

### Methods

```csharp
public WaypointSharedData(Transform waypointPrefab, float waypointTimeDelta, float linearAcceleration, float cruiseAcceleration, float angularAccelerationRads, float maxAngularVelocity)
```

```csharp
public void UpdatePropulsionValues(float linearAcceleration, float cruiseAcceleration, float angularAccelerationRads, float maxAngularVelocity)
```
