# fsForwardConverter

*Decompiled from `FullSerializer/Internal/fsForwardConverter.cs`.*


## Class `fsForwardConverter`

```csharp
public class fsForwardConverter : fsConverter
```

### Fields

| Name | Type |
|---|---|
| `_memberName` | private string |

### Methods

```csharp
public fsForwardConverter(fsForwardAttribute attribute)
```

```csharp
public override bool CanProcess(Type type)
```

```csharp
private fsResult GetProperty(object instance, out fsMetaProperty property)
```

```csharp
public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
```

```csharp
public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
```

```csharp
public override object CreateInstance(fsData data, Type storageType)
```
