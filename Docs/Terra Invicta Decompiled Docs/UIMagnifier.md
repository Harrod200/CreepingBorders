# UIMagnifier

*Decompiled from `PavonisInteractive/TerraInvicta/UIMagnifier.cs`.*


## Class `UIMagnifier`

```csharp
public class UIMagnifier : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `magnifiedImage` | public RawImage |
| `magnifierCanvas` | private Canvas |
| `blockerRect` | public RectTransform |
| `lensRect` | private RectTransform |
| `screenRT` | private RenderTexture |
| `zoom` | public float |
| `minZoom` | public float |
| `maxZoom` | public float |
| `zoomStep` | public float |
| `zoomSmoothTime` | public float |
| `targetZoom` | private float |
| `zoomVelocity` | private float |
| `isHotkeyHeld` | private bool |
| `hasCapturedThisHold` | private bool |
| `IsMagnifierActive` | public static bool |
| `uvX` | private float |
| `uvY` | private float |
| `baseUVSize` | private float |
| `uvSize` | private float |
| `uvHalf` | private float |

### Methods

```csharp
private void Awake()
```

```csharp
private void OnEnable()
```

```csharp
private void OnDisable()
```

```csharp
private void Update()
```

```csharp
private void EnsureRenderTexture()
```

```csharp
private void AssignTexture()
```

```csharp
private void CaptureScreen()
```

```csharp
private void UpdateLensAndImage()
```
