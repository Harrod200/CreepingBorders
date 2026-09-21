# fsVersionManager

*Decompiled from `FullSerializer/Internal/fsVersionManager.cs`.*


## Class `fsVersionManager`

```csharp
public static class fsVersionManager
```

### Fields

| Name | Type |
|---|---|
| `_cache` | private static readonly Dictionary<Type, fsOption<fsVersionedType>> |

### Methods

```csharp
public static fsResult GetVersionImportPath(string currentVersion, fsVersionedType targetVersion, out List<fsVersionedType> path)
```

```csharp
private static bool GetVersionImportPathRecursive(List<fsVersionedType> path, string currentVersion, fsVersionedType current)
```

```csharp
public static fsOption<fsVersionedType> GetVersionedType(Type type)
```

```csharp
private static void VerifyConstructors(fsVersionedType type)
```

```csharp
private static void VerifyUniqueVersionStrings(fsVersionedType type)
```
