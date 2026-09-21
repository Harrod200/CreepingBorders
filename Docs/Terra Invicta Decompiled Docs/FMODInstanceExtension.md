# FMODInstanceExtension

*Decompiled from `PavonisInteractive/TerraInvicta/Audio/FMODInstanceExtension.cs`.*


## Class `FMODInstanceExtension`

```csharp
public static class FMODInstanceExtension
```

### Methods

```csharp
public static bool Play(this EventInstance eventInstance)
```

```csharp
public static bool Play(this EventInstance eventInstance, GameObject targetObject)
```

```csharp
public static bool IsPlaying(this EventInstance eventInstance)
```

```csharp
public static bool IsStopped(this EventInstance eventInstance)
```

```csharp
public static bool Stop(this EventInstance eventInstance, global::FMOD.Studio.STOP_MODE stopMode = global::FMOD.Studio.STOP_MODE.IMMEDIATE)
```

```csharp
public static bool Release(this EventInstance eventInstance)
```

```csharp
public static float GetVolume(this EventInstance eventInstance)
```

```csharp
public static bool SetVolume(this EventInstance eventInstance, float volume)
```

```csharp
public static bool ChangeVolume(this EventInstance eventInstance, float volumeDelta)
```

```csharp
public static int GetLength(this EventInstance eventInstance)
```

```csharp
public static int GetTime(this EventInstance eventInstance)
```

```csharp
public static bool SetTime(this EventInstance eventInstance, int time)
```

```csharp
public static bool SetProperty(this EventInstance eventInstance, EVENT_PROPERTY property, float value)
```

```csharp
public static float GetProperty(this EventInstance eventInstance, EVENT_PROPERTY property)
```

```csharp
public static float GetParameter(this EventInstance eventInstance, string parameterName)
```

```csharp
public static bool SetParameter(this EventInstance eventInstance, PARAMETER_TYPE parameter, float value)
```

```csharp
public static bool SetParameter(this EventInstance eventInstance, string paramterName, float value)
```

```csharp
public static PLAYBACK_STATE GetPlaybackState(this EventInstance eventInstance)
```

```csharp
public static bool SetDistance(this EventInstance eventInstance, float maximumDistance, float minimumDistance = 1f)
```
