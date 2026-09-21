# EventManager

*Decompiled from `PavonisInteractive/TerraInvicta/EventManager.cs`.*


## Class `EventManager`

```csharp
public class EventManager : MonoBehaviour, IEventManager
```

### Fields

| Name | Type |
|---|---|
| `deferredQueue` | private List<QueuedDelegate> |
| `allQueuedDelegates` | private HashSet<Delegate> |
| `delegates` | private Dictionary<EventManager.EventKey, EventManager.EventDelegate> |
| `delegateLookup` | private Dictionary<ValueTuple<Delegate, string>, EventManager.EventDelegate> |
| `delegatePreFilters` | private Dictionary<Delegate, object> |
| `delegateGOs` | private Dictionary<Delegate, MonoBehaviour> |
| `delegateRequireGO` | private Dictionary<Delegate, bool> |
| `delegatesQueueable` | private HashSet<Delegate> |
| `onceLookups` | private Dictionary<ValueTuple<Delegate, string>, Delegate> |
| `secondsWorkedPerUpdate` | private Queue<float> |
| `eventsProcessedPerUpdate` | private Queue<int> |
| `eventsQueuedPerFrame` | private Queue<int> |
| `eventCountLastUpdate` | private int |
| `minAvailableSeconds` | private const float |
| `maxDelayInSeconds` | private const float |
| `catchupTimeInSeconds` | private const float |
| `maxFrametime` | private const float |
| `EventKey` | private struct |
| `eventType` | public Type |
| `eventName` | public string |

### Methods

```csharp
public void ClearAllEvents()
```

```csharp
private EventManager.EventDelegate AddDelegate<T>(EventManager.EventDelegate<T> del, string eventName = null) where T : GameEvent
```

```csharp
public void AddListener<T>(EventManager.EventDelegate<T> del, string eventName = null, object preFilterObject = null, bool queueable = true, bool callOnce = false) where T : GameEvent
```

```csharp
public void RemoveListener<T>(EventManager.EventDelegate<T> del, string eventName = null) where T : GameEvent
```

```csharp
public void RemoveAll()
```

```csharp
public void ClearPendingEvents(GameEvent evt, string eventName = null, params object[] sourceObjects)
```

```csharp
private bool SameEvent(QueuedDelegate qd, QueuedDelegate qd2)
```

```csharp
private void ClearQueueOfEvents(ref List<QueuedDelegate> queue, GameEvent evt, string eventName = null, params object[] sourceObjects)
```

```csharp
public void TriggerEvent(GameEvent evt, string eventName = null, params object[] sourceObjects)
```

```csharp
private void Start()
```

```csharp
private void Update()
```

```csharp
public void OnApplicationQuit()
```

```csharp
public EventKey(Type myType, string myName = null)
```

```csharp
public override int GetHashCode()
```

```csharp
public delegate void EventDelegate<T>(T e) where T : GameEvent
```

```csharp
private delegate void EventDelegate(GameEvent e)
```
