# TITimeEvent

*Decompiled from `PavonisInteractive/TerraInvicta/TITimeEvent.cs`.*


## Class `TITimeEvent`

```csharp
public class TITimeEvent : TIGameState
```

### Fields

| Name | Type |
|---|---|
| `template` | public TITimeEventTemplate |
| `time` | public TIDateTime |
| `eventObject` | public TIGameState |
| `eventObject2` | public TIGameState |
| `eventDataTemplate` | public TIDataTemplate |
| `triggerTime` | private TIDateTime |
| `eventObjectID` | public GameStateID |
| `eventObject2ID` | public GameStateID |
| `eventDataTemplateName` | public string |
| `_eventDataTemplate` | private TIDataTemplate |
| `eventName` | public string |
| `repeatType` | public TITimeQueueRepeatType |
| `timeStep` | public int |
| `stopClock` | public bool |
| `pauseTime` | public bool |
| `combatEvent` | public bool |
| `isComplete` | public bool |
| `repeatChangeTriggered` | public List<bool> |
| `startMonth` | public int |
| `gameTime` | private GameTimeManager |

### Methods

```csharp
public static TITimeEvent CreateNewTimeEvent(TIDateTime triggerTime, TIGameState eventObject = null, TIGameState eventObject2 = null, TIDataTemplate eventDataTemplate = null, string eventName = "", bool stopClock = true, bool pauseTime = false, TITimeQueueRepeatType repeatType = TITimeQueueRepeatType.None, int timeStep = 1, bool addToQueue = true, bool combat = false)
```

```csharp
public override bool Initialize()
```

```csharp
public override void InitWithTemplate(TIDataTemplate template)
```

```csharp
public override void PostGameStateCreateInit_OnCreationOnly_1()
```

```csharp
public override void PostGlobalGameStateCreateInit_2()
```

```csharp
public void StartEvent()
```

```csharp
public void EndEvent()
```

```csharp
public void CheckChangeRepeatTime()
```

```csharp
public TIDateTime GetNextEventTime(TIDateTime dt)
```

```csharp
public override string ToString()
```
