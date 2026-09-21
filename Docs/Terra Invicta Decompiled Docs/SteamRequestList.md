# SteamRequestList

*Decompiled from `LapinerTools/Steam/Data/Internal/SteamRequestList.cs`.*


## Class `SteamRequestList`

```csharp
public class SteamRequestList
```

### Fields

| Name | Type |
|---|---|
| `m_requests` | private Dictionary<Type, List<object>> |

### Methods

```csharp
public void Add<T>(CallResult<T> p_request)
```

```csharp
public int Count()
```

```csharp
public int Count<T>()
```

```csharp
public void Clear<T>()
```

```csharp
public void RemoveInactive()
```

```csharp
public void RemoveInactive<T>()
```

```csharp
public void Cancel()
```

```csharp
public void Cancel<T>()
```

```csharp
private static void CancelInternal<T>(List<object> p_requests)
```

```csharp
private static void RemoveInactiveInternal<T>(List<object> p_requests)
```
