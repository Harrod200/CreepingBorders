# fsIEnumerableConverter

*Decompiled from `FullSerializer/Internal/fsIEnumerableConverter.cs`.*


## Class `fsIEnumerableConverter`

```csharp
public class fsIEnumerableConverter : fsConverter
```

### Methods

```csharp
public override bool CanProcess(Type type)
```

```csharp
public override object CreateInstance(fsData data, Type storageType)
```

```csharp
public override fsResult TrySerialize(object instance_, out fsData serialized, Type storageType)
```

```csharp
private bool IsStack(Type type)
```

```csharp
public override fsResult TryDeserialize(fsData data, ref object instance_, Type storageType)
```

```csharp
private static int HintSize(IEnumerable collection)
```

```csharp
private static Type GetElementType(Type objectType)
```

```csharp
private static void TryClear(Type type, object instance)
```

```csharp
private static int TryGetExistingSize(Type type, object instance)
```

```csharp
private static MethodInfo GetAddMethod(Type type)
```
