# SplineAnchor

*Decompiled from `Pixelplacement/SplineAnchor.cs`.*


## Class `SplineAnchor`

```csharp
public class SplineAnchor : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `Anchor` | public Transform |
| `set` | private |
| `InTangent` | public Transform |
| `set` | private |
| `OutTangent` | public Transform |
| `set` | private |
| `tangentMode` | public TangentMode |
| `_initialized` | private bool |
| `_masterTangent` | private Transform |
| `_slaveTangent` | private Transform |
| `_previousTangentMode` | private TangentMode |
| `_previousInPosition` | private Vector3 |
| `_previousOutPosition` | private Vector3 |
| `_previousAnchorPosition` | private Vector3 |
| `_skinnedBounds` | private Bounds |
| `_anchor` | private Transform |
| `_inTangent` | private Transform |
| `_outTangent` | private Transform |

### Properties

- `public bool RenderingChange`
- `public bool Changed`

### Methods

```csharp
private void Awake()
```

```csharp
private void Update()
```

```csharp
private void TangentChanged()
```

```csharp
private void Initialize()
```

```csharp
public void SetTangentStatus(bool inStatus, bool outStatus)
```

```csharp
public void Tilt(Vector3 angles)
```
