# fsMetaProperty

*Decompiled from `FullSerializer/Internal/fsMetaProperty.cs`.*


## Class `fsMetaProperty`

```csharp
public class fsMetaProperty
```

### Fields

| Name | Type |
|---|---|
| `_memberInfo` | private MemberInfo |

### Properties

- `public Type StorageType`
- `public Type OverrideConverterType`
- `public bool CanRead`
- `public bool CanWrite`
- `public string JsonName`
- `public string MemberName`
- `public bool IsPublic`
- `public bool IsReadOnly`

### Methods

```csharp
internal fsMetaProperty(fsConfig config, FieldInfo field)
```

```csharp
internal fsMetaProperty(fsConfig config, PropertyInfo property)
```

```csharp
private void CommonInitialize(fsConfig config)
```

```csharp
public void Write(object context, object value)
```

```csharp
public object Read(object context)
```
