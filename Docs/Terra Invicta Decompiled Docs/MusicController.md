# MusicController

*Decompiled from `PavonisInteractive/TerraInvicta/Audio/MusicController.cs`.*


## Class `MusicController`

```csharp
public class MusicController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `Instance` | public static MusicController |
| `currentMusicDescription` | private EventDescription |
| `currentMusicInstance` | private EventInstance |
| `currentFanfareInstance` | private EventInstance |
| `musicFadeTime` | private float |
| `_instance` | private static MusicController |
| `musicProgression` | private CampaignMusicProgression |
| `playingFanfare` | private bool |

### Methods

```csharp
private void Awake()
```

```csharp
private void Start()
```

```csharp
public void ChangeMusicScene()
```

```csharp
public void VolumeUpdated()
```

```csharp
private void PlaySceneMusic()
```

```csharp
private void ChangedActiveScene(Scene scene, LoadSceneMode loadSceneMode)
```

```csharp
private IEnumerator WaitForScene(Scene scene)
```

```csharp
private IEnumerator ChangeMusic()
```

```csharp
public void PlayFanfare(string path)
```

```csharp
private IEnumerator StartFanfare(string path)
```

```csharp
private IEnumerator UpdateFanFare()
```

```csharp
private void StopFanfare()
```

```csharp
private void Update()
```
