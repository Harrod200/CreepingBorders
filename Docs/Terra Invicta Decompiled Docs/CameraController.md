# CameraController

*Decompiled from `TMPro/Examples/CameraController.cs`.*


## Class `CameraController`

```csharp
public class CameraController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `cameraTransform` | private Transform |
| `dummyTarget` | private Transform |
| `CameraTarget` | public Transform |
| `FollowDistance` | public float |
| `MaxFollowDistance` | public float |
| `MinFollowDistance` | public float |
| `ElevationAngle` | public float |
| `MaxElevationAngle` | public float |
| `MinElevationAngle` | public float |
| `OrbitalAngle` | public float |
| `CameraMode` | public CameraController.CameraModes |
| `MovementSmoothing` | public bool |
| `RotationSmoothing` | public bool |
| `previousSmoothing` | private bool |
| `MovementSmoothingValue` | public float |
| `RotationSmoothingValue` | public float |
| `MoveSensitivity` | public float |
| `currentVelocity` | private Vector3 |
| `desiredPosition` | private Vector3 |
| `mouseX` | private float |
| `mouseY` | private float |
| `moveVector` | private Vector3 |
| `mouseWheel` | private float |
| `mainCamera` | private Camera |
| `event_SmoothingValue` | private const string |
| `event_FollowDistance` | private const string |
| `CameraModes` | public enum |

### Methods

```csharp
private void Awake()
```

```csharp
private void Start()
```

```csharp
private void LateUpdate()
```

```csharp
private void GetPlayerInput()
```
