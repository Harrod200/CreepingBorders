# AudioManager

*Decompiled from `PavonisInteractive/TerraInvicta/Audio/AudioManager.cs`.*


## Class `AudioManager`

```csharp
public static class AudioManager
```

### Fields

| Name | Type |
|---|---|
| `lastEventPlayed` | private static string |
| `lastTimePlayedUISpecial` | private static float |
| `lastTimePlayedUI` | private static float |
| `lastTimePlayedUIGlobal` | private static float |
| `uiSpecialrepetitionDelay` | private static float |
| `uiSFXRepetitionDelay` | private static float |
| `uiSFXRepetitionDelayGlobal` | private static float |
| `tutorialVOEvent` | private static EventInstance |
| `cinematicAudioEvent` | private static EventInstance |

### Methods

```csharp
public static void Initialize()
```

```csharp
public static void CreateFMODObjects(string eventPath, out EventDescription eventDescription, out EventInstance eventInstance)
```

```csharp
public static EventInstance CreateFMODInstance(string eventPath)
```

```csharp
public static EventInstance CreateFMODInstance(string eventPath, GameObject target)
```

```csharp
public static EventDescription CreateFMODDescription(string eventPath)
```

```csharp
public static void PlayEvent(EventInstance instance)
```

```csharp
public static void StopEvent(EventInstance instance, global::FMOD.Studio.STOP_MODE stopMode = global::FMOD.Studio.STOP_MODE.ALLOWFADEOUT)
```

```csharp
public static void StopAllEvents()
```

```csharp
public static void PlayTutorialVO(string eventPath)
```

```csharp
public static void StopTutorialVO()
```

```csharp
public static void PlayCinematicAudio(string eventPath)
```

```csharp
public static void StopCinematicAudio()
```

```csharp
public static void PlayOneShot(string eventPath, bool useUIDelay = false, bool useGlobalUIDelay = false)
```

```csharp
public static void PlayOneShot(string eventPath, Vector3 position)
```

```csharp
public static void PlayOneShot(string eventPath, GameObject gameObject)
```

```csharp
public static bool VerifyPath(string eventPath, bool logError = true)
```

```csharp
public static string GetScenarioAudioPostFix(string audioPath)
```

```csharp
public static bool SetIntensity(float intensity)
```

```csharp
public static float GetIntensity()
```

```csharp
public static float GetCombatAudioMaxDistance(EventInstance eventInstance)
```

```csharp
public static float GetCombatAudioMinDistance(EventInstance eventInstance)
```

```csharp
public static IEnumerator FadeAudio(EventInstance eventInstance, float time, float targetVolume)
```
