# SteamMainBase

*Decompiled from `LapinerTools/Steam/SteamMainBase.cs`.*


## Class `SteamMainBase`

```csharp
public class SteamMainBase<SteamMainT> : MonoBehaviour where SteamMainT : SteamMainBase<SteamMainT>
```

### Fields

| Name | Type |
|---|---|
| `Instance` | public static SteamMainT |
| `IsInstanceSet` | public static bool |
| `OnError` | public event Action<ErrorEventArgs> |
| `IsDebugLogEnabled` | public bool |
| `s_instance` | protected static SteamMainT |
| `m_pendingRequests` | protected SteamRequestList |
| `m_singleShotEventHandlers` | private Dictionary<string, List<object>> |
| `m_lock` | protected object |
| `m_isDebugLogEnabled` | protected bool |

### Methods

```csharp
public void Execute<T>(SteamAPICall_t p_steamCall, CallResult<T>.APIDispatchDelegate p_onCompleted)
```

```csharp
protected virtual void OnDisable()
```

```csharp
protected virtual void LateUpdate()
```

```csharp
protected virtual bool CheckAndLogResultNoEvent<Trequest>(string p_logText, EResult p_result, bool p_bIOFailure)
```

```csharp
protected virtual bool CheckAndLogResult<Trequest, Tevent>(string p_logText, EResult p_result, bool p_bIOFailure, string p_eventName, ref Action<Tevent> p_event)
```

```csharp
protected virtual void HandleError(string p_logPrefix, ErrorEventArgs p_error)
```

```csharp
protected virtual void InvokeEventHandlerSafely<T>(Action<T> p_handler, T p_data)
```

```csharp
protected virtual void SetSingleShotEventHandler<T>(string p_eventName, ref Action<T> p_event, Action<T> p_handler)
```

```csharp
protected virtual void CallSingleShotEventHandlers<T>(string p_eventName, T p_args, ref Action<T> p_event)
```

```csharp
protected virtual void ClearSingleShotEventHandlers<T>(string p_eventName, ref Action<T> p_event)
```
