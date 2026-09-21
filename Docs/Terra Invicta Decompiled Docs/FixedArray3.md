# FixedArray3

*Decompiled from `Poly2Tri/FixedArray3.cs`.*


## Struct `FixedArray3`

```csharp
public struct FixedArray3<T> : IEnumerable<T>, IEnumerable where T : class
```

### Fields

| Name | Type |
|---|---|
| `_0` | public T |
| `_1` | public T |
| `_2` | public T |

### Methods

```csharp
public bool Contains(T value)
```

```csharp
public int IndexOf(T value)
```

```csharp
public void Clear()
```

```csharp
public void Clear(T value)
```

```csharp
private IEnumerable<T> Enumerate()
```

```csharp
public IEnumerator<T> GetEnumerator()
```
