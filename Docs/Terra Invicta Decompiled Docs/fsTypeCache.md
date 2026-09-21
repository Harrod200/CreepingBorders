# fsTypeCache

*Decompiled from `FullSerializer/Internal/fsTypeCache.cs`.*


## Class `fsTypeCache`

```csharp
public static class fsTypeCache
```

### Fields

| Name | Type |
|---|---|
| `_cachedTypes` | private static Dictionary<string, Type> |
| `_assembliesByName` | private static Dictionary<string, Assembly> |
| `_assembliesByIndex` | private static List<Assembly> |

### Methods

```csharp
private static void OnAssemblyLoaded(object sender, AssemblyLoadEventArgs args)
```

```csharp
private static bool TryDirectTypeLookup(string assemblyName, string typeName, out Type type)
```

```csharp
private static bool TryIndirectTypeLookup(string typeName, out Type type)
```

```csharp
public static void Reset()
```

```csharp
public static Type GetType(string name)
```

```csharp
public static Type GetType(string name, string assemblyHint)
```
