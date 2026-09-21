# StaticObjectPoolDictionary

*Decompiled from `PavonisInteractive/TerraInvicta/StaticObjectPoolDictionary.cs`.*


## Class `StaticObjectPoolDictionary`

```csharp
public static class StaticObjectPoolDictionary
```

### Fields

| Name | Type |
|---|---|
| `_objectPools` | private static Dictionary<GameObject, StaticObjectPoolDictionary.ObjectRef[]> |
| `ObjectRef` | private struct |
| `RefCount` | public int |
| `Instance` | public GameObject |

### Methods

```csharp
private static StaticObjectPoolDictionary.ObjectRef CreateObject(GameObject prefab)
```

```csharp
public static void InitializePool(GameObject prefab, int size = 12)
```

```csharp
public static void ResizeObjectPool(GameObject prefab, int amount)
```

```csharp
public static bool TryClaimObject(GameObject prefab, out GameObject entry)
```

```csharp
public static void TryClaimObjects(GameObject prefab, ref GameObject[] entries)
```

```csharp
public static void ReleaseClaimedObject(GameObject prefab, ref GameObject entry)
```

```csharp
public static void ReleaseClaimedObjects(GameObject prefab, ref GameObject[] entries)
```
