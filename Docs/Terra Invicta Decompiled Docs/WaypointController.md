# WaypointController

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/WaypointController.cs`.*


## Class `WaypointController`

```csharp
public class WaypointController
```

### Fields

| Name | Type |
|---|---|
| `OnWaypointReadyForInput` | public event Action<WaypointController> |
| `OnWaypointEndingInput` | public event Action<WaypointController> |
| `OnWaypointRemovalRequested` | public event Action<AdjustableWaypoint> |
| `BaseColorIndex` | public int |
| `IsInputLocked` | private bool |
| `IsPositionallyLocked` | private bool |
| `IsDvLocked` | public bool |
| `IsSystemFailureLocked` | public bool |
| `ColorInterpolationRatio` | public float |
| `IsHandlingRotationInput` | public bool |
| `IsHandlingMovementInput` | public bool |
| `showingDVText` | public bool |
| `_waypointSharedData` | private readonly WaypointSharedData |
| `_waypoint` | private AdjustableWaypoint |
| `_shipState` | private TISpaceShipState |
| `_visual` | public WaypointVisual |
| `_combatCamera` | private SpaceCombatCameraController |
| `_combatCameraTransform` | private Transform |
| `mouseStartDragPixelCoord` | private Vector3 |
| `_lastCameraPosition` | private Vector3 |
| `_shouldUpdateWaypointScale` | private bool |
| `_cachedState` | private WaypointController.WaypointState |
| `_isHandlingAltitudeInput` | private bool |
| `_isHandlingLateralInput` | private bool |
| `_isHandlingDragInput` | private bool |
| `_isHandlingYawInput` | private bool |
| `_isHandlingPitchInput` | private bool |
| `_isHandlingRollInput` | private bool |
| `_isTerminatingInput` | private bool |
| `_isHandlingResetInput` | private bool |
| `_isHandlingBurnInput` | private bool |
| `_wasDragStartedThisFrame` | private bool |
| `_wasDragEndedThisFrame` | private bool |
| `_isActiveInputHandler` | private bool |
| `_isMouseOverEndEventPending` | private bool |
| `_lastUpdateFrame` | private int |
| `_isSystemFailureLocked` | private bool |
| `_isDvLocked` | private bool |
| `_dragInputScaler` | private readonly float |
| `waypointProjectionPlane` | private Plane |
| `WaypointState` | private struct |
| `Position` | public Vector3 |
| `Rotation` | public Quaternion |
| `Normal` | public Vector3 |
| `WorldPosition` | public Vector3 |
| `WorldRotation` | public Quaternion |

### Methods

```csharp
private float WaypointRotationSnap()
```

```csharp
public WaypointController(AdjustableWaypoint waypoint, int index, WaypointSharedData waypointSharedData, Transform parent, Vector3 initialForward, bool isCoreWaypoint, TISpaceShipState shipState)
```

```csharp
private void SetWaypointState(Vector3 worldPosition, Quaternion worldRotation)
```

```csharp
private void SetWaypointState()
```

```csharp
private void RefreshVisualColor()
```

```csharp
private void AddListeners()
```

```csharp
private void RemoveListeners()
```

```csharp
public void UpdateVisualPositionRotation()
```

```csharp
private void AddVisualListeners()
```

```csharp
private void RemoveVisualListeners()
```

```csharp
private void HandleOnWaypointMouseOverBegin()
```

```csharp
private void HandleOnWaypointMouseOverEnd()
```

```csharp
public void RotateColorIndex()
```

```csharp
private void DecrementColorIndex()
```

```csharp
public void SetActive(bool isActive)
```

```csharp
public void SetRenderer(bool isActive)
```

```csharp
public void ToggleRenderer()
```

```csharp
public void UpdateVisuals()
```

```csharp
private void UpdateInputVisuals(bool isYawPressed, bool isPitchPressed, bool isAltitudePressed, bool isLateralPressed, bool isBurnPressed, bool isRollPressed)
```

```csharp
public void ClearGizmoVisuals()
```

```csharp
private bool IsWaypointScaleUpdateRequired()
```

```csharp
public void ProcessInput()
```

```csharp
private void DetectInput()
```

```csharp
private void EvaluateForDragInput(bool isMouseLeftPressed, bool isMouseLeftPressedThisFrame, bool isMouseLeftReleased, bool isAltitudePressed, bool isLateralPressed, bool isBurnPressed)
```

```csharp
private void EvaluateForRotationInput(bool isMouseLeftPressed, bool isYawPressed, bool isPitchPressed, bool isRollPressed)
```

```csharp
private void EvaluateForResetInput(bool isMouseRightPressed)
```

```csharp
private void ResolveInput()
```

```csharp
private void HandleResetInput()
```

```csharp
private void HandleTerminateInput(bool forceEnd = false)
```

```csharp
private void HandleRotationInput()
```

```csharp
private void HandleMovementInput()
```

```csharp
private void HandleYawInput()
```

```csharp
private void HandlePitchInput()
```

```csharp
private void HandleRollInput()
```

```csharp
private void HandleMovementDragInput(Vector3 dragPlaneNormal, bool isRelativeMovment = false)
```

```csharp
private void HandleBurnDragInput()
```

```csharp
public void BeginHandleInput()
```

```csharp
public void EndHandleInput()
```

```csharp
private void ToggleHighlight()
```

```csharp
public void SetInputHandling(bool isActiveInputHandler)
```

```csharp
public void Destroy()
```

```csharp
public void ToggleHeightLine(bool shouldRenderHeightLine)
```

```csharp
public void ToggleWaypointDVCost(bool shouldShowDVCost)
```
