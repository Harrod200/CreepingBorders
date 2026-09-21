# SplineRenderer

*Decompiled from `Pixelplacement/SplineRenderer.cs`.*


## Class `SplineRenderer`

```csharp
public class SplineRenderer : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `segmentsPerCurve` | public int |
| `startPercentage` | public float |
| `endPercentage` | public float |
| `_lineRenderer` | private LineRenderer |
| `_spline` | private Spline |
| `_initialized` | private bool |
| `_previousAnchorsLength` | private int |
| `_previousSegmentsPerCurve` | private int |
| `_vertexCount` | private int |
| `_previousStart` | private float |
| `_previousEnd` | private float |

### Methods

```csharp
private void Reset()
```

```csharp
private void Update()
```

```csharp
private void UpdateLineRenderer()
```

```csharp
private void ConfigureLineRenderer()
```
