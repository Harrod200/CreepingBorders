# SteamManager

*Decompiled from `SteamManager.cs`.*


## Class `SteamManager`

```csharp
public class SteamManager : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `Instance` | protected static SteamManager |
| `Initialized` | public static bool |
| `s_EverInitialized` | protected static bool |
| `s_instance` | protected static SteamManager |
| `m_bInitialized` | protected bool |
| `m_SteamAPIWarningMessageHook` | protected SteamAPIWarningMessageHook_t |

### Methods

```csharp
protected static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText)
```

```csharp
private static void InitOnPlayMode()
```

```csharp
protected virtual void Awake()
```

```csharp
protected virtual void OnEnable()
```

```csharp
protected virtual void OnDestroy()
```

```csharp
protected virtual void Update()
```
