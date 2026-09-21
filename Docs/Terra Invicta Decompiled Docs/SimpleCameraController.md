# SimpleCameraController

*Decompiled from `UnityTemplateProjects/SimpleCameraController.cs`.*


## Class `SimpleCameraController`

```csharp
public class SimpleCameraController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `m_TargetCameraState` | private SimpleCameraController.CameraState |
| `m_InterpolatingCameraState` | private SimpleCameraController.CameraState |
| `boost` | public float |
| `positionLerpTime` | public float |
| `mouseSensitivityCurve` | public AnimationCurve |
| `rotationLerpTime` | public float |
| `invertY` | public bool |
| `CameraState` | private class |
| `yaw` | public float |
| `pitch` | public float |
| `roll` | public float |
| `x` | public float |
| `y` | public float |
| `z` | public float |

### Methods

```csharp
private void OnEnable()
```

```csharp
private Vector3 GetInputTranslationDirection()
```

```csharp
private void Update()
```

```csharp
public void SetFromTransform(Transform t)
```

```csharp
public void Translate(Vector3 translation)
```

```csharp
public void LerpTowards(SimpleCameraController.CameraState target, float positionLerpPct, float rotationLerpPct)
```

```csharp
public void UpdateTransform(Transform t)
```
