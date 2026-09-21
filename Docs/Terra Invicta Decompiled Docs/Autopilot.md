# Autopilot

*Decompiled from `PavonisInteractive/TerraInvicta/Assets/Autopilot.cs`.*


## Class `Autopilot`

```csharp
public class Autopilot : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `Activated` | public bool |
| `IsOkayButtonClickable` | private bool |
| `IsCloseButtonClickable` | private bool |
| `IsGotoButtonClickable` | private bool |
| `Singleton` | public static Autopilot |
| `gameTimeManager` | private GameTimeManager |
| `CanvasManager` | private CanvasManager |
| `notificationScreenController` | private NotificationScreenController |
| `councilorMissionCanvasController` | private CouncilorMissionCanvasController |
| `researchScreenController` | private ResearchScreenController |
| `precombatController` | private PrecombatController |
| `activated` | private bool |
| `CycleIndex` | public int |
| `SaveRate` | public int |
| `IgnoreExeptions` | public bool |

### Methods

```csharp
public static void Pause()
```

```csharp
private void Start()
```

```csharp
private void Update()
```

```csharp
private void LogCallback(string condition, string stackTrace, LogType type)
```

```csharp
private bool IsButtonClickable(Button button)
```

```csharp
private void OnStartMissionPhase(MissionPhaseStart e)
```
