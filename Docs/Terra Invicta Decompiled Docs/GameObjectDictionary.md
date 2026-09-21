# GameObjectDictionary

*Decompiled from `PavonisInteractive/TerraInvicta/GameObjectDictionary.cs`.*


## Class `GameObjectDictionary`

```csharp
public class GameObjectDictionary<TKey> : IEnumerable<GameObject>, IEnumerable
```

### Fields

| Name | Type |
|---|---|
| `gameObject` | public GameObject |
| `transform` | public Transform |
| `name` | private string |
| `lookup` | private IDictionary<TKey, GameObject> |
| `_gameObject` | private GameObject |

### Methods

```csharp
public GameObjectDictionary(string name)
```

```csharp
public bool Add(TKey key, GameObject value, bool worldPositionStays = false, bool overwrite = false)
```

```csharp
public bool ContainsKey(TKey key)
```

```csharp
public bool TryFind(TKey key, out GameObject value)
```

```csharp
public bool Remove(TKey key, bool destroy = true)
```

```csharp
public void Clear(bool destroy = true)
```

```csharp
public IEnumerator<GameObject> GetEnumerator()
```
