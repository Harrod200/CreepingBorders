# RegionEffectRenderer

*Decompiled from `RegionEffectRenderer.cs`.*


## Class `RegionEffectRenderer`

```csharp
public class RegionEffectRenderer : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `s_borderTextureUniform` | private static int |
| `s_Instance` | public static RegionEffectRenderer |
| `m_pCamera` | private Camera |
| `m_regionCommandBuffer` | private CommandBuffer |
| `m_borderMaskRT` | private RenderTexture |
| `m_borderLineBufferRT` | private RenderTexture |
| `m_BorderMaterial` | private Material |
| `m_zMesh` | private MeshFilter |
| `m_regionList` | private List<RegionMeshBorderEffect> |
| `MASK_DOWNSCALE_PASSES` | private const int |
| `earthObject` | private GameObject |
| `initialized` | private bool |
| `ignoreFirst` | private bool |
| `listeningForEarthSwap` | private bool |

### Methods

```csharp
private void Awake()
```

```csharp
public void Initialize()
```

```csharp
public void OnForceUpdateSpaceBodyModelFinished(ForceUpdateSpaceBodyModelFinished e)
```

```csharp
private void OnDestroy()
```

```csharp
private void OnEnable()
```

```csharp
private void OnDisable()
```

```csharp
private void OnPreRender()
```

```csharp
private void InitRenderTextures()
```

```csharp
private void ReleaseRenderTextures()
```

```csharp
public void AddRegion(RegionMeshBorderEffect region)
```
