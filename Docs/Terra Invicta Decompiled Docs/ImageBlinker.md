# ImageBlinker

*Decompiled from `PavonisInteractive/TerraInvicta/ImageBlinker.cs`.*


## Class `ImageBlinker`

```csharp
public class ImageBlinker : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `EffectiveRestColor` | private Color |
| `Image` | public Image |
| `secondsElapsed` | private float |
| `blinkingDuration` | private float |
| `blinkCount` | private int |
| `restColor` | private Color |
| `blinkColor` | private Color |

### Methods

```csharp
public void Update()
```

```csharp
public static void Blink(Image image, float blinkingDuration, int blinkCount, Color blinkColor)
```
