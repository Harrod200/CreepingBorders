# fsCyclicReferenceManager

*Decompiled from `FullSerializer/Internal/fsCyclicReferenceManager.cs`.*


## Class `fsCyclicReferenceManager`

```csharp
public class fsCyclicReferenceManager
```

### Fields

| Name | Type |
|---|---|
| `_objectIds` | private Dictionary<object, int> |
| `_nextId` | private int |
| `_marked` | private Dictionary<int, object> |
| `_depth` | private int |
| `Instance` | public static readonly IEqualityComparer<object> |

### Methods

```csharp
public void Enter()
```

```csharp
public bool Exit()
```

```csharp
public object GetReferenceObject(int id)
```

```csharp
public void AddReferenceWithId(int id, object reference)
```

```csharp
public int GetReferenceId(object item)
```

```csharp
public bool IsReference(object item)
```

```csharp
public void MarkSerialized(object item)
```
