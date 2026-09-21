# EarthSunBlendTESTER

*Decompiled from `PavonisInteractive/TerraInvicta/EarthSunBlendTESTER.cs`.*


## Class `EarthSunBlendTESTER`

```csharp
public class EarthSunBlendTESTER : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `earthMeshRenderer` | private MeshRenderer |
| `SunTransform` | public Transform |
| `EarthTransform` | public Transform |
| `uniformGDP` | public bool |
| `numMapRegions` | private int |
| `gdpList` | private float[] |
| `gdpAnimationList` | private float[] |
| `gdpDisplayList` | private float[] |
| `alienControlList` | private float[] |
| `normalizedGDP` | public float |
| `targetVisualID` | public int |
| `targetNormalizedGDP` | public float |
| `targetAlienControl` | public float |
| `uniformOil` | public bool |
| `numOilRegions` | private int |
| `oilList` | private float[] |
| `oilAnimationList` | private float[] |
| `oilDisplayList` | private float[] |
| `normalizedOil` | public float |
| `targetOilID` | public int |
| `targetOil` | public float |
| `nukeAnimation` | private AnimationCurve |
| `_materialBlock` | private MaterialPropertyBlock |

### Methods

```csharp
private void Awake()
```

```csharp
private void Start()
```

```csharp
private void Update()
```

```csharp
public void UpdateRegionGDPValues()
```

```csharp
public void UpdateRegionAlienControlValues(bool alienControl)
```

```csharp
public void UpdateRegionOilValues()
```

```csharp
public void UpdateSpecificGDP()
```

```csharp
public void UpdateSpecificAlienControl()
```

```csharp
public void UpdateSpecificOil()
```

```csharp
private void UpdateShader()
```

```csharp
private void UpdateSpecificRegionLightValues(int visualID, int oilID, bool sendToShader = true)
```

```csharp
public void HandleNukeRegion()
```

```csharp
private IEnumerator NukeRegion(int visualID, int oilID)
```
