# fsEnumConverter

*Decompiled from `FullSerializer/Internal/fsEnumConverter.cs`.*


## Class `fsEnumConverter`

```csharp
public class fsEnumConverter : fsConverter
```

### Methods

```csharp
public override bool CanProcess(Type type)
```

```csharp
public override bool RequestCycleSupport(Type storageType)
```

```csharp
public override bool RequestInheritanceSupport(Type storageType)
```

```csharp
public override object CreateInstance(fsData data, Type storageType)
```

```csharp
public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
```

```csharp
public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
```

```csharp
private static bool ArrayContains<T>(T[] values, T value)
```
