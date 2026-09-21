# EarthNightLightShaderDriver

*Decompiled from `PavonisInteractive/TerraInvicta/EarthNightLightShaderDriver.cs`.*


## Class `EarthNightLightShaderDriver`

```csharp
public class EarthNightLightShaderDriver : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `BlendSpace` | private float |
| `nukeAnimation` | private AnimationCurve |
| `earthMeshRenderer` | private MeshRenderer |
| `SunTransform` | private Transform |
| `EarthTransform` | private Transform |
| `mapRegionTemplates` | private TIMapRegionTemplate[] |
| `gdpList` | private float[] |
| `gdpAnimationList` | private float[] |
| `gdpDisplayList` | private float[] |
| `alienControlList` | private float[] |
| `oilList` | private float[] |
| `oilAnimationList` | private float[] |
| `oilDisplayList` | private float[] |
| `_materialBlock` | private MaterialPropertyBlock |
| `showEarthLights` | private bool |
| `spaceCombatEnabled` | private bool |
| `geoScapeActive` | private bool |

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
private void OnDisable()
```

```csharp
public void OnRegionNuked(RegionNuked e)
```

```csharp
public void OnRegionGDPLightsRecalculation(RegionGDPLightsRecalculation e)
```

```csharp
public void OnCombatStarts(CombatStarts e)
```

```csharp
public void OnCombatEnds(CombatEnds e)
```

```csharp
public void OnMapChanged(MapActivationChangedEvent e)
```

```csharp
public void RegionChangedOwner(RegionControlChanged e)
```

```csharp
public void Initialize()
```

```csharp
public void UpdateRegionLightValues()
```

```csharp
private void UpdateSpecificRegionLightValues(TIRegionState currentRegion, bool sendToShader = true)
```

```csharp
private void UpdateShader()
```

```csharp
private void UpdateShowEarthLights()
```

```csharp
public void HandleNukeRegion(TIRegionState currentRegion)
```

```csharp
private IEnumerator NukeRegion(TIRegionState currentRegion)
```
