# fsReflectedConverter

*Decompiled from `FullSerializer/Internal/fsReflectedConverter.cs`.*


## Class `fsReflectedConverter`

```csharp
public class fsReflectedConverter : fsConverter
```

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

```csharp
public override object CreateInstance(fsData data, Type storageType)
```
