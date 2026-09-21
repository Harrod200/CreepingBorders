# GameTimeManager

*Decompiled from `PavonisInteractive/TerraInvicta/Systems/GameTime/GameTimeManager.cs`.*


## Class `GameTimeManager`

```csharp
public class GameTimeManager : ManagerSystem
```

### Fields

| Name | Type |
|---|---|
| `SpeedChanged` | public event GameTimeManager.SpeedChangeCallback |
| `currentTime` | public TIDateTime |
| `IsTimeFlowing` | public bool |
| `SpaceCombatPausedText` | public string |
| `IsBlocked` | public bool |
| `isBlockedByPrompt` | public bool |
| `lastSpeed` | public float |
| `Paused` | public bool |
| `DontCapSpeed` | public bool |
| `CurrentSpeedSetting` | public SpeedSetting |
| `promptQueue` | private TIPromptQueueState |
| `combatTimeQueue` | private TITimeQueue |
| `timeState` | private TITimeState |
| `lastSpeedIndex` | public int |
| `blocked` | public bool |
| `spaceObjectSelection` | private SpaceObjectSelection |
| `strategySpeeds` | private List<SpeedSetting> |
| `combatSpeeds` | private List<SpeedSetting> |
| `strategyStartingSpeedIndex` | private int |
| `combatStartingSpeedIndex` | private int |
| `pausedFrame` | private int |
| `antiSeizureControl_km` | private const float |

### Properties

- `public static GameTimeManager Singleton`
- `public DateTime Now`
- `public TITimeQueue timeQueue`
- `public List<SpeedSetting> currentSpeeds`
- `public int currentSpeedIndex`
- `public float currentSpeed`

### Methods

```csharp
private void OnSpeedChanged(SpeedSetting speed)
```

```csharp
internal float GetDeltaTime(float deltaTime)
```

```csharp
internal void UpdateTime(float deltaTime)
```

```csharp
internal void SetTime(TIDateTime time)
```

```csharp
internal void UpdateEvents()
```

```csharp
internal void UpdateCombatEvents()
```

```csharp
public void Initialize()
```

```csharp
public void AddTimeEvent(TITimeEvent timeEvent)
```

```csharp
public TIDateTime GetTimeForPendingEvent(string eventName, TIGameState eventObject, TIGameState eventObject2, TIDataTemplate eventTemplate)
```

```csharp
public TIDateTime ExtendTimeEvent(string eventName, TIGameState eventObject, TIGameState eventObject2, TIDataTemplate eventTemplate, int value, TITimeQueueRepeatType unit)
```

```csharp
public void CancelTimeEvent(string eventName, TIGameState eventObject, TIGameState eventObject2, TIDataTemplate eventTemplate, TIDateTime eventDateTime)
```

```csharp
public void CancelTimeEvents(string eventName, TIGameState eventObject, TIGameState eventObject2, TIDataTemplate eventTemplate)
```

```csharp
public void AddCombatTimeEvent(TITimeEvent timeEvent)
```

```csharp
public TIDateTime ExtendCombatTimeEvent(string eventName, TIGameState eventObject, TIGameState eventObject2, TIDataTemplate eventTemplate, int value, TITimeQueueRepeatType unit)
```

```csharp
public void CancelCombatTimeEvent(string eventName, TIGameState eventObject, TIGameState eventObject2, TIDataTemplate eventTemplate, TIDateTime eventDateTime)
```

```csharp
public void ClearCombatTimeEvents()
```

```csharp
public void SubstituteStatesInTimeQueue(TIGameState oldState, TIGameState newState)
```

```csharp
public void CancelAllTimeEventsForObject(TIGameState eventObject)
```

```csharp
public void CancelAllTimeEventsByName(string eventName)
```

```csharp
public void UpdateCurrentSpeedState(SpeedSettingState state)
```

```csharp
public void Play()
```

```csharp
public void Pause()
```

```csharp
public void PauseAndBlock()
```

```csharp
public void UnPauseAndUnBlock()
```

```csharp
public void UnBlock()
```

```csharp
public bool TogglePause()
```

```csharp
public bool PausedThisFrame()
```

```csharp
public int MaxSpeedIdx()
```

```csharp
public bool ResetSpeed(bool barycenterFallback = false)
```

```csharp
public bool IncreaseSpeed()
```

```csharp
public bool DecreaseSpeed()
```

```csharp
public void SetSpeed(int idx, bool pushBeyondCap)
```

```csharp
public void PreserveStrategySpeed()
```

```csharp
public void Reset()
```

```csharp
public delegate void SpeedChangeCallback(SpeedSetting speed)
```
