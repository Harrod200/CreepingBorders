# WeightedList

*Decompiled from `PavonisInteractive/TerraInvicta/Ship/WeightedList.cs`.*


## Class `WeightedList`

```csharp
public class WeightedList<T>
```

### Fields

| Name | Type |
|---|---|
| `Count` | public int |
| `set` | private |
| `entries` | private IList<WeightedList<T>.Entry<T>> |
| `weight` | private long |
| `random` | private Random |
| `item` | public U |
| `weight` | public int |

### Methods

```csharp
public WeightedList()
```

```csharp
public void Add(T item, int weight)
```

```csharp
public void Remove(T item)
```

```csharp
public T Random()
```

```csharp
public Entry(U item, int weight)
```
