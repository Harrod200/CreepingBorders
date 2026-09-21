# AudioMenuController

*Decompiled from `AudioMenuController.cs`.*


## Class `AudioMenuController`

```csharp
public class AudioMenuController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `volumeMasterTitle` | public TextMeshProUGUI |
| `volumeMusicTitle` | public TextMeshProUGUI |
| `volumeUITitle` | public TextMeshProUGUI |
| `volumeEffectsTitle` | public TextMeshProUGUI |
| `volumeVoiceTitle` | public TextMeshProUGUI |
| `volumeAmbienceTitle` | public TextMeshProUGUI |
| `toggleMuteInBackgroundTitle` | public TextMeshProUGUI |
| `applyChangesTitle` | public TextMeshProUGUI |
| `volumeMasterValueText` | public TextMeshProUGUI |
| `volumeMusicValueText` | public TextMeshProUGUI |
| `volumeUIValueText` | public TextMeshProUGUI |
| `volumeEffectsValueText` | public TextMeshProUGUI |
| `volumeVoiceValueText` | public TextMeshProUGUI |
| `volumeAmbienceValueText` | public TextMeshProUGUI |
| `volumeMasterSlider` | public Slider |
| `volumeMusicSlider` | public Slider |
| `volumeUISlider` | public Slider |
| `volumeEffectsSlider` | public Slider |
| `volumeVoiceSlider` | public Slider |
| `volumeAmbienceSlider` | public Slider |
| `toggleMuteInBackgroundToggle` | public Toggle |
| `eventInstanceSFX` | private EventInstance |
| `eventInstanceVO` | private EventInstance |
| `eventInstanceAMB` | private EventInstance |
| `initEventSFX` | private bool |
| `initEventVO` | private bool |
| `initEventAMB` | private bool |
| `initEventUI` | private bool |
| `playUIEffect` | private bool |
| `audioEffectDelay` | private float |
| `ambientPlayTimer` | private float |
| `canvasManager` | protected CanvasManager |
| `isInitializing` | private bool |

### Methods

```csharp
private void Start()
```

```csharp
public void Init()
```

```csharp
public void UpdateMasterVolume()
```

```csharp
public void UpdateMusicVolume()
```

```csharp
public void UpdateEffectsVolume()
```

```csharp
public void UpdateVoiceVolume()
```

```csharp
public void UpdateAmbienceVolume()
```

```csharp
public void UpdateUIVolume()
```

```csharp
public void UpdateOnToggleMuteInBackground()
```

```csharp
public void ApplyAudioSettings()
```

```csharp
private void Update()
```

```csharp
private void PlayUIEvent()
```

```csharp
private void PlaySFXEvent()
```

```csharp
private void OnDisable()
```

```csharp
public void LoadLocalizedText()
```
