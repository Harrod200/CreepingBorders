# fsMetaType

*Decompiled from `FullSerializer/fsMetaType.cs`.*


## Class `fsMetaType`

```csharp
public class fsMetaType
```

### Fields

| Name | Type |
|---|---|
| `HasDefaultConstructor` | public bool |
| `IsDefaultConstructorPublic` | public bool |
| `_configMetaTypes` | private static Dictionary<fsConfig, Dictionary<Type, fsMetaType>> |
| `ReflectedType` | public Type |
| `_hasDefaultConstructorCache` | private bool? |
| `_isDefaultConstructorPublicCache` | private bool? |
| `Exception` | public class AotFailureException : |

### Properties

- `public fsMetaProperty[] Properties`

### Methods

```csharp
public static fsMetaType Get(fsConfig config, Type type)
```

```csharp
public static void ClearCache()
```

```csharp
private fsMetaType(fsConfig config, Type reflectedType)
```

```csharp
private static void CollectProperties(fsConfig config, List<fsMetaProperty> properties, Type reflectedType)
```

```csharp
private static bool IsAutoProperty(PropertyInfo property, MemberInfo[] members)
```

```csharp
private static bool CanSerializeProperty(fsConfig config, PropertyInfo property, MemberInfo[] members, bool annotationFreeValue)
```

```csharp
private static bool CanSerializeField(fsConfig config, FieldInfo field, bool annotationFreeValue)
```

```csharp
public void EmitAotData(bool throwException)
```

```csharp
public object CreateInstance()
```

```csharp
public AotFailureException(string reason)
```
