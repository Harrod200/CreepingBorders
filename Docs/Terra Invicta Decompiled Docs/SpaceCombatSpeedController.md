# SpaceCombatSpeedController

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/SpaceCombatSpeedController.cs`.*


## Class `SpaceCombatSpeedController`

```csharp
public class SpaceCombatSpeedController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `IsPaused` | public bool |
| `combatTimeString` | public string |
| `pauseButton` | public GameObject |
| `playButton` | public GameObject |
| `combatTimeText` | private TMP_Text |
| `speedText` | private TMP_Text |
| `speedPausedText` | private TMP_Text |
| `TimePipsList` | public ListManagerBase |
| `gameTime` | private GameTimeManager |

### Methods

```csharp
private void OnEnable()
```

```csharp
private void OnDisable()
```

```csharp
private void OnDestroy()
```

```csharp
public void Play()
```

```csharp
public void Pause()
```

```csharp
public void TogglePause()
```

```csharp
public void PauseNoToggle()
```

```csharp
public void IncreaseSpeed()
```

```csharp
public void DecreaseSpeed()
```

```csharp
public void SetSpeed(int speedIndex)
```

```csharp
private void SetSpeedString(SpeedSetting speed)
```

```csharp
private void OnCombatSecond(CombatSecond e)
```

```csharp
private void UpdateClock()
```

```csharp
public void UpdateClockDisplay()
```

```csharp
private string ToTimeString(int seconds)
```
