# BusManager

*Decompiled from `PavonisInteractive/TerraInvicta/Audio/BusManager.cs`.*


## Class `BusManager`

```csharp
public static class BusManager
```

### Properties

- `public static Bus Master`
- `public static Bus SFX`
- `public static Bus UI`
- `public static Bus UI_Special_UI_Reverb`
- `public static Bus Voice`
- `public static Bus Ambient`
- `public static Bus Music`

### Methods

```csharp
public static void Initialize()
```

```csharp
private static void GetBuses()
```

```csharp
private static void SetInitialVolume()
```

```csharp
public static void SetVolume(Bus bus, float volume)
```

```csharp
public static float GetVolume(Bus bus)
```

```csharp
public static void StopAllEvents(Bus bus, FMOD.Studio.STOP_MODE stopMode = FMOD.Studio.STOP_MODE.IMMEDIATE)
```
