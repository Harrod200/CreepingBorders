# Tuple

*Decompiled from `PavonisInteractive/TerraInvicta/Tuple.cs`.*


## Class `Tuple`

```csharp
public sealed class Tuple
```

### Fields

| Name | Type |
|---|---|
| `Count` | public int |
| `boolType` | private Type |
| `intType` | private Type |
| `floatType` | private Type |
| `doubleType` | private Type |
| `stringType` | private Type |
| `objectType` | private Type |
| `listType` | private Type |
| `data` | private List<Tuple.TupleValue> |
| `TupleValue` | private struct |
| `b` | public bool? |
| `i` | public int? |
| `f` | public float? |
| `d` | public double? |
| `s` | public string |
| `o` | public object |
| `l` | public List<object> |
| `type` | public Type |

### Properties

- `public string Id`

### Methods

```csharp
public Tuple(string newId = "", int capacity = 4)
```

```csharp
public bool Set<T>(int index, T value) where T : struct
```

```csharp
public Type GetType(int index)
```
