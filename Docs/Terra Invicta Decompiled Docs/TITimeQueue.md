# TITimeQueue

*Decompiled from `PavonisInteractive/TerraInvicta/TITimeQueue.cs`.*


## Class `TITimeQueue`

```csharp
public class TITimeQueue
```

### Fields

| Name | Type |
|---|---|
| `gameTime` | private GameTimeManager |
| `stopClockEvents` | private List<TITimeEvent> |

### Properties

- `public List<TITimeEvent> events`

### Methods

```csharp
public TITimeQueue()
```

```csharp
public void Initialize()
```

```csharp
public float GetDeltaTime(float deltaTime, DateTime now)
```

```csharp
public void UpdateToTime(DateTime dateTime)
```

```csharp
public void AddEvent(TITimeEvent newEvent)
```

```csharp
public void RemoveEvent(TITimeEvent timeEvent)
```

```csharp
public TITimeEvent FindEvent(string eventName, TIGameState eventObject, TIGameState eventObject2, TIDataTemplate eventDataTemplate)
```

```csharp
public TIDateTime ExtendEvent(string eventName, TIGameState eventObject, TIGameState eventObject2, TIDataTemplate eventTemplate, int value, TITimeQueueRepeatType unit)
```

```csharp
public void SubstituteStateInEvents(TIGameState oldState, TIGameState newState)
```

```csharp
public void CancelEvent(string eventName, TIGameState eventObject, TIGameState eventObject2, TIDataTemplate eventTemplate, TIDateTime eventTime)
```

```csharp
public void CancelEvent(string eventName, TIGameState eventObject, TIGameState eventObject2, string eventTemplateName, TIDateTime eventTime)
```

```csharp
public void CancelEvents(string eventName, TIGameState eventObject, TIGameState eventObject2, TIDataTemplate eventTemplate)
```

```csharp
public void CancelAllTimeEventsForObject(TIGameState eventObject)
```

```csharp
public void CancelAllTimeEventsByName(string eventName)
```

```csharp
public void ClearQueue()
```

```csharp
private void AddSorted(TITimeEvent evt)
```

```csharp
private TITimeEvent GetNextEvent()
```

```csharp
private TITimeEvent GetNextStopClockEvent()
```

```csharp
public int Compare(TITimeEvent evt1, TITimeEvent evt2)
```
