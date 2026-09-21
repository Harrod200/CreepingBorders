# fsData

*Decompiled from `FullSerializer/fsData.cs`.*


## Class `fsData`

```csharp
public sealed class fsData
```

### Fields

| Name | Type |
|---|---|
| `Type` | public fsDataType |
| `IsNull` | public bool |
| `IsDouble` | public bool |
| `IsInt64` | public bool |
| `IsBool` | public bool |
| `IsString` | public bool |
| `IsDictionary` | public bool |
| `IsList` | public bool |
| `AsDouble` | public double |
| `AsInt64` | public long |
| `AsBool` | public bool |
| `AsString` | public string |
| `AsDictionary` | public Dictionary<string, fsData> |
| `AsList` | public List<fsData> |
| `operator` | public static bool |
| `_value` | private object |
| `True` | public static readonly fsData |
| `False` | public static readonly fsData |
| `Null` | public static readonly fsData |

### Methods

```csharp
public fsData()
```

```csharp
public fsData(bool boolean)
```

```csharp
public fsData(double f)
```

```csharp
public fsData(long i)
```

```csharp
public fsData(string str)
```

```csharp
public fsData(Dictionary<string, fsData> dict)
```

```csharp
public fsData(List<fsData> list)
```

```csharp
public static fsData CreateDictionary()
```

```csharp
public static fsData CreateList()
```

```csharp
public static fsData CreateList(int capacity)
```

```csharp
internal void BecomeDictionary()
```

```csharp
internal fsData Clone()
```

```csharp
private T Cast<T>()
```

```csharp
public override string ToString()
```

```csharp
public override bool Equals(object obj)
```

```csharp
public bool Equals(fsData other)
```

```csharp
public override int GetHashCode()
```
