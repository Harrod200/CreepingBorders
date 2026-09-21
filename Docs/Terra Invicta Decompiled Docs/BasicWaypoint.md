# BasicWaypoint

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/BasicWaypoint.cs`.*


## Class `BasicWaypoint`

```csharp
public class BasicWaypoint : IWaypoint
```

### Fields

| Name | Type |
|---|---|
| `PreviousOrientation` | public BasicWaypoint.WaypointOrientation |
| `Heading` | public Vector3 |
| `_previousOrientation` | protected BasicWaypoint.WaypointOrientation |
| `WaypointOrientation` | public struct |
| `Position` | public Vector3 |
| `Rotation` | public Quaternion |
| `Velocity` | public Vector3 |
| `Timing` | public TIDateTime |

### Properties

- `public float AlphaBlendValue`
- `public Vector3 Position`
- `public Vector3 Velocity`
- `public Quaternion Rotation`
- `public TIDateTime Timing`

### Methods

```csharp
public void SetHeading(Vector3 headingDirection, bool preserveRoll)
```

```csharp
protected BasicWaypoint()
```

```csharp
protected BasicWaypoint(IWaypoint waypoint)
```

```csharp
public virtual void SetData(IWaypoint waypoint)
```

```csharp
protected void SetData(Vector3 position, Vector3 velocity, Quaternion rotation, TIDateTime timing, float alphaBlendValue)
```
