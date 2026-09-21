# Singleton

*Decompiled from `Singleton.cs`.*


## Class `Singleton`

```csharp
public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `Instance` | public static T |
| `m_ShuttingDown` | private static bool |
| `m_Lock` | private static object |
| `m_Instance` | private static T |

### Methods

```csharp
private void OnApplicationQuit()
```

```csharp
private void OnDestroy()
```
