# BlurUtility

*Decompiled from `BlurUtility.cs`.*


## Class `BlurUtility`

```csharp
public class BlurUtility : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `s_downsampleMaterial` | private static Material |
| `s_blurMaterial` | private static Material |
| `s_kernelWeights11` | private static float[] |

### Properties

- `private static float[] s_kernelWeights3 = new float[]`
- `private static float[] s_kernelWeights5 = new float[]`
- `private static float[] s_kernelWeights7 = new float[]`
- `private static float[] s_kernelWeights9 = new float[]`

### Methods

```csharp
public static void BlurRenderTexture(ref CommandBuffer commandBuffer, RenderTexture target, int targetIterations)
```
