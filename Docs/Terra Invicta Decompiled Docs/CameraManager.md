# CameraManager

*Decompiled from `PavonisInteractive/TerraInvicta/Systems/Camera/CameraManager.cs`.*


## Class `CameraManager`

```csharp
public class CameraManager : ComponentSystem
```

### Fields

| Name | Type |
|---|---|
| `GameObject` | public GameObject |
| `Transform` | public Transform |
| `FocalPoint` | public Vector3d |
| `TargetSpherical` | public SVector3d |
| `Spherical` | public SVector3d |
| `TargetPosition` | public Vector3d |
| `Position` | public Vector3d |
| `SurfacePosition` | public SurfacePosition |
| `WorldForward` | public Vector3 |
| `Forward` | public Vector3 |
| `IsTransitioningUp` | private bool |
| `Up` | public Vector3 |
| `TargetLookRotation` | public Quaternion |
| `BillboardRotation` | public Quaternion |
| `UseSurfaceRotation` | public bool |
| `WorldScale` | public double |
| `unityCamera` | public Camera |
| `unityCameraTransform` | public Transform |
| `shouldBeginSelectionChangeAnimation` | private bool |
| `isSelectionChangeAnimationComplete` | private bool |
| `SelectedState` | public TISpaceObjectState |
| `OutermostSpaceBody` | private TISpaceBodyState |
| `SurfaceDegrees` | private float |
| `SurfaceRotation` | public Quaternion |
| `Skybox` | public Skybox |
| `LOD` | public CameraManagerLOD |
| `cachedFocalPoint` | private Vector3d |
| `focalPointCachedFrame` | private int |
| `focalPointCachedSpaceObjectController` | private SpaceObjectController |
| `targetSpherical` | private SVector3d |
| `lastTargetSpherical` | private SVector3d |
| `spherical` | private SVector3d |
| `lastSpherical` | private SVector3d |
| `lastWorldForward` | private Vector3 |
| `lastTargetWorldForward` | private Vector3 |
| `lastWorldUp` | private Vector3 |
| `UpTransitionDuration` | private float |
| `UpTransitionTimeElapsed` | private float |
| `transitionUp` | private Vector3 |
| `_skybox` | private Skybox |
| `skyboxBackdrop` | public Sprite |
| `skyboxBackdropPath` | public string |
| `_unityCamera` | private Camera |
| `_unityCameraTransform` | private Transform |
| `selection` | private SpaceObjectSelection |
| `config` | public CameraConfig |
| `Singleton` | public static CameraManager |
| `lastObjectSelected` | private SpaceObjectController |
| `lastPosition` | private Vector3d |
| `usedSurfaceRotationLastFrame` | private bool |
| `firstUpdateCompleted` | private bool |
| `selectionChangeAnimationDuration` | private const float |
| `selectionChangeAnimationTimeElapsed` | private float |
| `selectionChangeWorldForward` | private Vector3 |
| `selectionChangeWorldUp` | private Vector3 |
| `tiltChangeAnimationDuration` | private float |
| `tiltChangeAnimationTimeElapsed` | private float |
| `playTiltChangeAnimation` | private bool |
| `tiltAnimationStartingWorldUp` | private Vector3 |
| `IsAltitudeChanging` | public bool |
| `outermostSpaceBody` | private TISpaceBodyState |
| `cachedSurfaceRotation` | private Quaternion |
| `surfaceRotationCachedFrame` | private int |
| `surfaceRotationCachedSpaceObjectController` | private SpaceObjectController |
| `cachedPosition` | private Vector3d |

### Properties

- `public Vector3 WorldUp`
- `public bool IsAnimating`
- `public bool ForceVisualizationUpdate`

### Methods

```csharp
private void CacheFocalPoint()
```

```csharp
protected override void OnStartRunning()
```

```csharp
protected override void OnUpdate()
```

```csharp
private void HandleInput()
```

```csharp
private void HandleAnimations()
```

```csharp
private void Transition(Vector3d transitionFocalPoint, Quaternion transitionRotation, bool setTargetSpherical, bool maintainTargetRadius)
```

```csharp
public void OnSelectionChanged()
```

```csharp
public void RotateToPolarAzimuth(double polar, double azimuth)
```

```csharp
public void RotateToLatitudeLongitude(double latitude, double longitude)
```

```csharp
public void Rotate(double polarDelta, double azimuthDelta)
```

```csharp
public void Rotate_Degrees(double polarDelta, double azimuthDelta)
```

```csharp
public void Zoom(double distance, bool isGoto = true)
```

```csharp
private void ClampTargetRadius()
```

```csharp
private static float GetSurfaceDegrees(SpaceObjectController spaceObject)
```

```csharp
private void CacheSurfaceRotation()
```

```csharp
private static Quaternion ComputeSurfaceRotation(SpaceObjectController spaceObject, float surfaceDegrees)
```

```csharp
private static Quaternion ComputeSurfaceRotation(SpaceObjectController spaceObject)
```

```csharp
private Quaternion ComputeSurfaceRotation(float surfaceDegrees)
```

```csharp
private static Vector3d ComputePosition(SVector3d spherical, Vector3d focalPoint, Quaternion physicalRotation)
```

```csharp
private void CachePosition()
```

```csharp
private static SVector3d ComputeSphericalCoordinates(Vector3d position, Vector3d focalPoint, Quaternion physicalRotation)
```

```csharp
public void SetSkybox(int variant)
```

```csharp
public float ScaledDistance(double distance)
```

```csharp
public float3 ScaledPosition_DoNotTouchCache(Vector3d worldPoint)
```

```csharp
public float3 ScaledPosition(Vector3d worldPoint, Vector3d focalPoint, Quaternion surfaceRotation)
```

```csharp
public float3 ScaledPosition(Vector3d worldPoint)
```

```csharp
public float3 FastScaledPosition(Vector3d worldPoint)
```

```csharp
public void ScaledPositions(Orbit orbit)
```
