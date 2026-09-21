# fsPortableReflection

*Decompiled from `FullSerializer/Internal/fsPortableReflection.cs`.*


## Class `fsPortableReflection`

```csharp
public static class fsPortableReflection
```

### Fields

| Name | Type |
|---|---|
| `EmptyTypes` | public static Type[] |
| `_cachedAttributeQueries` | private static IDictionary<fsPortableReflection.AttributeQuery, Attribute> |
| `DeclaredFlags` | private static BindingFlags |
| `AttributeQuery` | private struct |
| `MemberInfo` | public MemberInfo |
| `AttributeType` | public Type |

### Methods

```csharp
public static bool HasAttribute<TAttribute>(MemberInfo element)
```

```csharp
public static bool HasAttribute<TAttribute>(MemberInfo element, bool shouldCache)
```

```csharp
public static bool HasAttribute(MemberInfo element, Type attributeType)
```

```csharp
public static bool HasAttribute(MemberInfo element, Type attributeType, bool shouldCache)
```

```csharp
public static Attribute GetAttribute(MemberInfo element, Type attributeType, bool shouldCache)
```

```csharp
public static TAttribute GetAttribute<TAttribute>(MemberInfo element, bool shouldCache) where TAttribute : Attribute
```

```csharp
public static TAttribute GetAttribute<TAttribute>(MemberInfo element) where TAttribute : Attribute
```

```csharp
public static PropertyInfo GetDeclaredProperty(this Type type, string propertyName)
```

```csharp
public static MethodInfo GetDeclaredMethod(this Type type, string methodName)
```

```csharp
public static ConstructorInfo GetDeclaredConstructor(this Type type, Type[] parameters)
```

```csharp
public static ConstructorInfo[] GetDeclaredConstructors(this Type type)
```

```csharp
public static MemberInfo[] GetFlattenedMember(this Type type, string memberName)
```

```csharp
public static MethodInfo GetFlattenedMethod(this Type type, string methodName)
```

```csharp
public static IEnumerable<MethodInfo> GetFlattenedMethods(this Type type, string methodName)
```

```csharp
public static PropertyInfo GetFlattenedProperty(this Type type, string propertyName)
```

```csharp
public static MemberInfo GetDeclaredMember(this Type type, string memberName)
```

```csharp
public static MethodInfo[] GetDeclaredMethods(this Type type)
```

```csharp
public static PropertyInfo[] GetDeclaredProperties(this Type type)
```

```csharp
public static FieldInfo[] GetDeclaredFields(this Type type)
```

```csharp
public static MemberInfo[] GetDeclaredMembers(this Type type)
```

```csharp
public static MemberInfo AsMemberInfo(Type type)
```

```csharp
public static bool IsType(MemberInfo member)
```

```csharp
public static Type AsType(MemberInfo member)
```

```csharp
public static Type Resolve(this Type type)
```

```csharp
public bool Equals(fsPortableReflection.AttributeQuery x, fsPortableReflection.AttributeQuery y)
```

```csharp
public int GetHashCode(fsPortableReflection.AttributeQuery obj)
```
