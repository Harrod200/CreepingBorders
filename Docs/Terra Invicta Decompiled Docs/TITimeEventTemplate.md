# TITimeEventTemplate

*Decompiled from `TITimeEventTemplate.cs`.*


## Class `TITimeEventTemplate`

```csharp
public class TITimeEventTemplate : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `eventType` | public TITimeQueueRepeatType |
| `timeStep` | public int? |
| `eventName` | public string |
| `stopClock` | public bool |
| `pauseTime` | public bool |
| `priority` | public float |
| `repeatChanges` | public List<TITimeEventTemplate.RepeatChange> |
| `RepeatChange` | public struct |
| `ConditionMet` | public bool |
| `triggerCondition` | public TIGlobalCondition |
| `updateEventType` | public TITimeQueueRepeatType |

### Methods

```csharp
public TITimeEventTemplate(string name)
```

```csharp
public override TIGameState CreateGameState()
```
