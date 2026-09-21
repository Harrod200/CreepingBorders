# CometController

*Decompiled from `PavonisInteractive/TerraInvicta/CometController.cs`.*


## Class `CometController`

```csharp
public class CometController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `Comet` | public TISpaceBodyState |
| `ParticleControllers` | public IEnumerable<CometParticleController> |
| `FrostLine_AU` | public static float |
| `IsCometOutgassing` | public bool |
| `Productivity` | public float |
| `DistanceBasedProductivity` | public float |
| `IsInOverrideRenderMode` | public bool |
| `OverrideSizeFactor` | public float |
| `DoNotDisplay` | public bool |
| `ComaController` | public CometComaController |
| `DustTailController` | public CometDustTailController |
| `GasTailController` | public CometGasTailController |

### Properties

- `public SpaceObjectController SpaceObjectController`
- `public float VolatileFraction`
- `public float VolatileWaterFraction`
- `public TISpaceBodyState OverrideComet`
- `public Camera OverrideCamera`

### Methods

```csharp
public void InitiateOverrideRenderMode(TISpaceBodyState overrideComet, Camera overrideCamera, bool drawingToRenderTexture)
```

```csharp
private void Start()
```
