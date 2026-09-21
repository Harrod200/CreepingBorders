# SpaceCombatCameraBlend

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombatCameraBlend.cs`.*


## Class `SpaceCombatCameraBlend`

```csharp
public class SpaceCombatCameraBlend : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `_material` | public Material |
| `_additiveCamera` | public Camera |
| `isDestroyed` | private bool |
| `_renderTexture` | private RenderTexture |

### Methods

```csharp
private void OnPreRender()
```

```csharp
private void OnRenderImage(RenderTexture src, RenderTexture dest)
```

```csharp
public void SetUp(Material mat, Camera cam)
```

```csharp
public void CleanUp()
```

```csharp
private void OnDestroy()
```
