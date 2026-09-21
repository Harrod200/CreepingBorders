# fsBaseConverter

*Decompiled from `FullSerializer/fsBaseConverter.cs`.*


## Class `fsBaseConverter`

```csharp
public abstract class fsBaseConverter
```

### Fields

| Name | Type |
|---|---|
| `Serializer` | public fsSerializer |

### Methods

```csharp
public virtual object CreateInstance(fsData data, Type storageType)
```

```csharp
public virtual bool RequestCycleSupport(Type storageType)
```

```csharp
public virtual bool RequestInheritanceSupport(Type storageType)
```

```csharp
public abstract fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
```

```csharp
public abstract fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
```

```csharp
protected fsResult FailExpectedType(fsData data, params fsDataType[] types)
```

```csharp
protected fsResult CheckType(fsData data, fsDataType type)
```

```csharp
protected fsResult CheckKey(fsData data, string key, out fsData subitem)
```

```csharp
protected fsResult CheckKey(Dictionary<string, fsData> data, string key, out fsData subitem)
```

```csharp
protected fsResult SerializeMember<T>(Dictionary<string, fsData> data, Type overrideConverterType, string name, T value)
```

```csharp
protected fsResult DeserializeMember<T>(Dictionary<string, fsData> data, Type overrideConverterType, string name, out T value)
```
