# SpaceCombatCameraController

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/SpaceCombatCameraController.cs`.*


## Class `SpaceCombatCameraController`

```csharp
public class SpaceCombatCameraController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `OnCameraMovementFinished` | public event SpaceCombatCameraController.CameraMovement |
| `maxZoom` | private float |
| `minZoom` | private float |
| `maxPan` | private float |
| `minPan` | private float |
| `minCameraMovementSpeed` | private float |
| `maxCameraMovementSpeed` | private float |
| `minScrollSpeedOffset` | private float |
| `maxScrollSpeedOffset` | private float |
| `mouseRotateSpeedOffset` | private float |
| `keyRotateSpeedOffset` | private float |
| `Position` | private Vector3 |
| `Scale` | private float |
| `IsDragging` | public bool |
| `ScaledMaxZoom` | private float |
| `ScaledMinZoom` | private float |
| `ZOOM_TIME` | private const float |
| `_spaceCombatCamera` | private Camera |
| `_cameraFocalPoint` | private Vector3 |
| `_scrollSpeedOffset` | private float |
| `_cameraMovementSpeed` | private float |
| `_freelookZoomMultiplier` | private float |
| `_dragging` | private bool |
| `_placingWaypoint` | private bool |
| `_spaceCombat` | private SpaceCombatManager |
| `_activePlayerFleetControllerIdx` | private int |
| `_zoomTimeRemaining` | private float |
| `_freelookZoomTimer` | private float |
| `_targetCameraPos` | private Vector3 |
| `_targetPolarOffset` | private double |
| `_isTargetPolarOffsetIncreasing` | private bool |
| `_scale` | private float |
| `_polarOffset` | private Polar |
| `IsCameraMovementBlocked` | public bool |
| `_mainCamera` | private Camera |
| `_focusedTarget` | private CombatantController |
| `_previousTarget` | private CombatantController |
| `_clockController` | private SpaceCombatSpeedController |
| `_followCameraOffset` | private Vector3 |
| `_cameraEulerAngles` | private Vector3 |
| `_spaceCombatRoot` | private Transform |
| `_gridCollider` | private Collider |
| `_screenRect` | private readonly Rect |
| `_cameraMovement` | private SpaceCombatCameraController.Movement |
| `_layersMask` | private int |
| `_gridColliderFound` | private bool |
| `_cameraOrientationChanged` | private bool |
| `Movement` | private enum |

### Methods

```csharp
private void Awake()
```

```csharp
private void OnEnable()
```

```csharp
private void Update()
```

```csharp
private void InitializeCamera()
```

```csharp
private void SetCameraState(SpaceCombatCameraController.Movement state)
```

```csharp
public void OnHudEnabled()
```

```csharp
public void LookAtCombatant(CombatantController combatant)
```

```csharp
public void LookAtObject(GameObject target)
```

```csharp
public void ClearFocusedTarget()
```

```csharp
public void OnShipDestroyed(CombatShipController ship)
```

```csharp
private void CycleShipController(bool up)
```

```csharp
private void CheckInput(out bool rightDown, out bool middleDown, out bool rightUp, out bool middleUp, out bool right, out bool middle, out float xAxis, out float yAxis, out float zAxis, out float pAxis, out float aAxis, out float rAxis)
```

```csharp
private void HandleDebug()
```

```csharp
private void HandleSpecializedInput()
```

```csharp
private void HandleDebugHideUI()
```

```csharp
private void TryIssueCombatCommand<TShip, TFleet>() where TShip : IShipCommand where TFleet : IFleetCommand
```

```csharp
private void IssueCommandToShip(TISpaceShipState shipToReceiveCommands, IShipCommand fleetSelectPrimaryTargetCommand)
```

```csharp
private void IssueCommandToShips(List<TISpaceShipState> shipsToRecieveCommands, IShipCommand fleetSelectPrimaryTargetCommand)
```

```csharp
private void IssueCommandToFleet(IFleetCommand fleetSelectPrimaryTargetCommand)
```

```csharp
private void HandleWaypointPlacement(bool rightUp, bool rightDown, bool altDown)
```

```csharp
private void FollowTarget(float pAxis, float aAxis)
```

```csharp
private void HandleMovement(float xAxis, float yAxis, float zAxis, bool middle, bool right)
```

```csharp
private void HandleRotation(float pAxis, float aAxis)
```

```csharp
private void HandleZoom(float rAxis)
```

```csharp
public delegate void CameraMovement(Vector3 worldOffset, Quaternion worldRotation)
```
