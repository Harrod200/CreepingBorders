# Spline

*Decompiled from `Pixelplacement/Spline.cs`.*


## Class `Spline`

```csharp
public class Spline : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `OnSplineChanged` | public event Action |
| `Anchors` | public SplineAnchor[] |
| `SecondaryColor` | public Color |
| `color` | public Color |
| `toolScale` | public float |
| `defaultTangentMode` | public TangentMode |
| `direction` | public SplineDirection |
| `loop` | public bool |
| `followers` | public SplineFollower[] |
| `_anchors` | private SplineAnchor[] |
| `_curveCount` | private int |
| `_previousAnchorCount` | private int |
| `_previousChildCount` | private int |
| `_wasLooping` | private bool |
| `_previousLoopChoice` | private bool |
| `_anchorsChanged` | private bool |
| `_previousDirection` | private SplineDirection |
| `_curvePercentage` | private float |
| `_operatingCurve` | private int |
| `_currentCurve` | private float |
| `_previousLength` | private int |
| `_slicesPerCurve` | private int |
| `_splineReparams` | private List<Spline.SplineReparam> |
| `_lengthDirty` | private bool |
| `SplineReparam` | private class |
| `length` | public float |
| `percentage` | public float |

### Properties

- `public float Length`

### Methods

```csharp
private void Reset()
```

```csharp
private void Update()
```

```csharp
private void HangleLengthChange()
```

```csharp
private float Reparam(float percent)
```

```csharp
public void CalculateLength()
```

```csharp
public Vector3 Up(float percentage, bool normalized = true)
```

```csharp
public Vector3 Right(float percentage, bool normalized = true)
```

```csharp
public Vector3 Forward(float percentage, bool normalized = true)
```

```csharp
public Vector3 GetDirection(float percentage, bool normalized = true)
```

```csharp
public Vector3 GetPosition(float percentage, bool normalized = true)
```

```csharp
public Vector3 GetPosition(float percentage, Vector3 relativeOffset, bool normalized = true)
```

```csharp
public float ClosestPoint(Vector3 point, int divisions = 100)
```

```csharp
public GameObject[] AddAnchors(int count)
```

```csharp
public CurveDetail GetCurve(float percentage)
```

```csharp
public SplineReparam(float length, float percentage)
```
