# WaypointVisual

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/WaypointVisual.cs`.*


## Class `WaypointVisual`

```csharp
public class WaypointVisual : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `PlayerScaleModifier` | private float |
| `CoreWaypointScaleModifier` | private float |
| `OnWaypointMouseOverBegin` | public event Action |
| `OnWaypointMouseOverEnd` | public event Action |
| `IsOverlapping` | public bool |
| `IsVisible` | public bool |
| `GizmoRoot` | public GameObject |
| `ColorInterpolationRatio` | public float |
| `BaseColorIndex` | public int |
| `set` | private |
| `BaseColor` | public Color |
| `BaseColorAlpha` | public float |
| `ScaledRadius` | public float |
| `colors` | private List<Color> |
| `waypointHoverColor` | private Color |
| `waypointLockedColor` | private Color |
| `waypointSystemLockedColor` | private Color |
| `minScale` | private float |
| `maxScale` | private float |
| `adjustedMaxScale` | private float |
| `isPlayerWaypoint` | public bool |
| `gizmoRoot` | private GameObject |
| `rotationAxisRenderer` | private Renderer[] |
| `capsuleCollider` | private CapsuleCollider |
| `waypointOcclusionLayermask` | private LayerMask |
| `waypointUI` | public WaypointUIController |
| `ALBEDO_COLOR` | private const string |
| `EMISSION_COLOR` | private const string |
| `NAME` | private const string |
| `BASE_INITIAL_SCALING_FACTOR` | private const float |
| `ACTIVE_INPUT_SCALE_MODIFIER` | private const float |
| `NO_INPUT_SCALE_MODIFIER` | private const float |
| `PLAYER_SCALE_MODIFIER` | private const float |
| `NON_PLAYER_SCALE_MODIFIER` | private const float |
| `CORE_WAYPOINT_SCALE_MODIFER` | private const float |
| `NON_CORE_WAYPOINT_SCALE_MODIFIER` | private const float |
| `_renderer` | private Renderer |
| `_camera` | private Camera |
| `_cameraTransform` | private Transform |
| `_spaceCombatCameraController` | private SpaceCombatCameraController |
| `_heightLineRenderer` | private WaypointVisual.HeightLineRenderer |
| `_initialScale` | private Vector3 |
| `_emissionColorId` | private int |
| `_hoverEmissionColor` | private Color |
| `_lockedEmissionColor` | private Color |
| `_isHighlighted` | private bool |
| `_isInputHandlingDelayedForCameraDrag` | private bool |
| `_scalingFactor` | private float |
| `_inputHandlingScaleFactor` | private float |
| `_isCoreWaypoint` | private bool |
| `_isPlacementWaypoint` | public bool |
| `_containsPartialWaypoint` | private bool |
| `_shipState` | private TISpaceShipState |
| `_shipTransform` | private Transform |
| `_overlappingPercentage` | private float |
| `_isOverlapping` | private bool |
| `PitchRotationGizmo` | public WaypointGizmoVisual |
| `YawRotationGizmo` | public WaypointGizmoVisual |
| `RollRotationGizmo` | public WaypointGizmoVisual |
| `MovementGizmo` | public WaypointGizmoVisual |
| `AltitudeGizmo` | public WaypointGizmoVisual |
| `LateralGizmo` | public WaypointGizmoVisual |
| `BurnGizmo` | public WaypointGizmoVisual |
| `_lockRotation` | private Quaternion |
| `_isLockRotationSet` | private bool |
| `_colorInterpolationRatio` | private float |
| `_baseColorIndex` | private int |
| `_baseColor` | private Color |
| `_spaceCombatUiLayerMask` | private int |
| `HeightLineRenderer` | private class |
| `SPACE_COMBAT_UI` | private const string |
| `HEIGHT_LINE_RENDERER` | private const string |
| `s_lineCount` | private static int |
| `_defaultColor` | private readonly Color |
| `_line` | private VectorLine |
| `thisT` | public Transform |

### Methods

```csharp
public static WaypointVisual Create(Transform waypointVisualPrefab, int colorIndex, Transform parent, TISpaceShipState shipState)
```

```csharp
public static WaypointVisual Create(IMovableWaypoint waypoint, Transform waypointVisualPrefab, int colorIndex, Transform parent, Vector3 initialForward, bool isCoreWaypoint, TISpaceShipState shipState)
```

```csharp
private void Initialize(int baseColorIndex, bool isCoreWaypoint, TISpaceShipState shipState)
```

```csharp
public Vector3 GetShipPosition()
```

```csharp
private IEnumerator SetHeightlineParent()
```

```csharp
public void DecrementColorIndex()
```

```csharp
public void SetColorIndex(int index, float colorInterpolationRatio)
```

```csharp
private void SelectBaseColor()
```

```csharp
private void InitializeWaypointScale()
```

```csharp
public void UpdateWaypointScale()
```

```csharp
private void Update()
```

```csharp
private void LateUpdate()
```

```csharp
private void InitializeWaypointColors()
```

```csharp
public void ShowBaseColor()
```

```csharp
public void ShowHighlightColor()
```

```csharp
public void ShowLockedColor()
```

```csharp
public void ShowSystemFailureLockedColor()
```

```csharp
public void SetInputHandling(bool isActive)
```

```csharp
private float InputScaleModifier(bool isActive)
```

```csharp
public void SetRendererEnabled(bool setActive)
```

```csharp
public void ToggleRenderer()
```

```csharp
public void ToggleHighlight()
```

```csharp
private void OnMouseEnter()
```

```csharp
private void OnMouseExit()
```

```csharp
public void HandleMouseEnter()
```

```csharp
public void HandleMouseExit()
```

```csharp
public void SetPositionRotation(Vector3 position, Quaternion rotation)
```

```csharp
public void ToggleHeightLine(bool shouldRenderLine)
```

```csharp
public void ToggleWaypointDVCost(bool shouldShow)
```

```csharp
public void ToggleWaypointCollisionWarning(bool shouldShow)
```

```csharp
public void ShowYawGizmo(bool value)
```

```csharp
public void ShowYawGizmoHighlight(bool value)
```

```csharp
public void ShowPitchGizmo(bool value)
```

```csharp
public void ShowPitchGizmoHighlight(bool value)
```

```csharp
public void ShowRollGizmo(bool value)
```

```csharp
public void ShowRollGizmoHighlight(bool value)
```

```csharp
public void ShowMovementGizmo(bool value, bool highlight = false)
```

```csharp
public void ShowMovementInvalid(bool value)
```

```csharp
public void ShowAltitudeGizmo(bool value)
```

```csharp
public void ShowAltitudeGizmoHighlight(bool highlight)
```

```csharp
public void ShowAltitudeInvalid(bool value)
```

```csharp
public void ShowLateralGizmo(bool value)
```

```csharp
public void ShowLateralGizmoHighlight(bool highlight)
```

```csharp
public void ShowLateralInvalid(bool value)
```

```csharp
public void ShowBurnGizmo(bool value)
```

```csharp
public void ShowBurnHighlight(bool highlight)
```

```csharp
public void ShowBurnInvalid(bool value)
```

```csharp
public void LockMovementGizmoRotation(bool value)
```

```csharp
public void OnDestroy()
```

```csharp
public HeightLineRenderer(string name)
```

```csharp
public void SetRenderPosition(Vector3 waypointPosition)
```

```csharp
public void ToggleRenderState(bool shouldRender)
```

```csharp
public void Destroy()
```
