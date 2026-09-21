# RotateCloudsSolarSystemScene

*Decompiled from `RotateCloudsSolarSystemScene.cs`.*


## Class `RotateCloudsSolarSystemScene`

```csharp
public class RotateCloudsSolarSystemScene : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `speedY` | private float |
| `activatedTransparency` | private const float |
| `distantTransparency` | private const float |
| `transparencyDelta` | private readonly float |
| `gameTime` | private GameTimeManager |
| `baseAlbedoColor` | private Color |

### Methods

```csharp
private void Awake()
```

```csharp
public void InitAlbedoControl()
```

```csharp
private void OnMapActivationChanged(MapActivationChangedEvent e)
```

```csharp
public void OnCloudThresholdChange(EarthParticulateThresholdChanges e)
```

```csharp
private void SetMaterial(int idx)
```

```csharp
private IEnumerator DarkenClouds()
```

```csharp
private IEnumerator LightenClouds()
```

```csharp
private void LateUpdate()
```

```csharp
private void OnDestroy()
```
