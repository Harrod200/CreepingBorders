# StringSerializationAPI

*Decompiled from `StringSerializationAPI.cs`.*


## Class `StringSerializationAPI`

```csharp
public static class StringSerializationAPI
```

### Fields

| Name | Type |
|---|---|
| `_serializer` | private static readonly fsSerializer |

### Methods

```csharp
public static string SerializePretty(Type type, object value)
```

```csharp
public static string SerializeCompressed(Type type, object value)
```

```csharp
public static object Deserialize(Type type, string serializedState)
```

```csharp
public static fsData Serialize(Type type, object value)
```
