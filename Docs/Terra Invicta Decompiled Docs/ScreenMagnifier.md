# ScreenMagnifier

*Decompiled from `PavonisInteractive/TerraInvicta/ScreenMagnifier.cs`.*


## Class `ScreenMagnifier`

```csharp
public class ScreenMagnifier : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `material` | public Material |
| `boxSizeUV` | public Vector2 |
| `zoom` | public float |
| `zoomBounds` | public Vector2 |
| `borderColor` | public Color |
| `borderThicknessPixels` | public float |
| `cam` | private Camera |
| `cbCapture` | private CommandBuffer |
| `cbFinal` | private CommandBuffer |
| `capturedRT` | private int |
| `magnifying` | private bool |

### Methods

```csharp
private void OnValidate()
```

```csharp
private void OnEnable()
```

```csharp
private void OnDisable()
```

```csharp
private void StartMagnify()
```

```csharp
private void StopMagnify()
```

```csharp
private void Update()
```
