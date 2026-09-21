# fsDateConverter

*Decompiled from `FullSerializer/Internal/fsDateConverter.cs`.*


## Class `fsDateConverter`

```csharp
public class fsDateConverter : fsConverter
```

### Fields

| Name | Type |
|---|---|
| `DateTimeFormatString` | private string |
| `DefaultDateTimeFormatString` | private const string |
| `DateTimeOffsetFormatString` | private const string |

### Methods

```csharp
public override bool CanProcess(Type type)
```

```csharp
public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
```

```csharp
public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
```
